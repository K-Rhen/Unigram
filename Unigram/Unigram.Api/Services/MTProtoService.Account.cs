using System;
using System.Threading;
#if WIN_RT
using Windows.Data.Xml.Dom;
using Windows.UI.Notifications;
#endif
using Telegram.Api.Extensions;
using Telegram.Api.Helpers;
using Telegram.Api.TL;
using Telegram.Api.TL.Methods.Account;
using Telegram.Api.TL.Methods.Auth;

namespace Telegram.Api.Services
{
	public partial class MTProtoService
	{
	    public event EventHandler CheckDeviceLocked;

	    protected virtual void RaiseCheckDeviceLocked()
	    {
            CheckDeviceLocked?.Invoke(this, EventArgs.Empty);
        }

	    private void CheckDeviceLockedInternal(object state)
        {
            RaiseCheckDeviceLocked();
        }

        public void GetTmpPasswordAsync(byte[] hash, int period, Action<TLAccountTmpPassword> callback, Action<TLRPCError> faultCallback = null)
        {
            var obj = new ITLAccountGetTmpPassword { PasswordHash = hash, Period = period };

            const string caption = "account.getTmpPassword";
            SendInformativeMessage(caption, obj, callback, faultCallback);
        }

        public void ReportPeerAsync(TLInputPeerBase peer, TLReportReasonBase reason, Action<bool> callback, Action<TLRPCError> faultCallback = null)
        {
            var obj = new ITLAccountReportPeer { Peer = peer, Reason = reason };

            SendInformativeMessage("account.reportPeer", obj, callback, faultCallback);
        }

	    public void DeleteAccountAsync(string reason, Action<bool> callback, Action<TLRPCError> faultCallback = null)
	    {
            var obj = new ITLAccountDeleteAccount { Reason = reason };

            SendInformativeMessage("account.deleteAccount", obj, callback, faultCallback);
	    }

        public void UpdateDeviceLockedAsync(int period, Action<bool> callback, Action<TLRPCError> faultCallback = null)
        {
            var obj = new ITLAccountUpdateDeviceLocked { Period = period };

            SendInformativeMessage("account.updateDeviceLocked", obj, callback, faultCallback);
        }

	    public void GetWallpapersAsync(Action<TLVector<TLWallPaperBase>> callback, Action<TLRPCError> faultCallback = null)
	    {
            var obj = new ITLAccountGetWallPapers();

            SendInformativeMessage("account.getWallpapers", obj, callback, faultCallback);
	    }

        public void SendChangePhoneCodeAsync(string phoneNumber, bool? currentNumber, Action<TLAuthSentCode> callback, Action<TLRPCError> faultCallback = null)
        {
            var obj = new ITLAccountSendChangePhoneCode { Flags = 0, PhoneNumber = phoneNumber, CurrentNumber = currentNumber };

            SendInformativeMessage("account.sendChangePhoneCode", obj, callback, faultCallback);
        }

        public void ChangePhoneAsync(string phoneNumber, string phoneCodeHash, string phoneCode, Action<TLUserBase> callback, Action<TLRPCError> faultCallback = null)
        {
            var obj = new ITLAccountChangePhone { PhoneNumber = phoneNumber, PhoneCodeHash = phoneCodeHash, PhoneCode = phoneCode };

            SendInformativeMessage<TLUserBase>("account.changePhone", obj, user => _cacheService.SyncUser(user, callback), faultCallback);
        }

        public void RegisterDeviceAsync(int tokenType, string token, Action<bool> callback, Action<TLRPCError> faultCallback = null)
        {
            if (_activeTransport.AuthKey == null)
            {
                faultCallback?.Invoke(new ITLRPCError
                {
                    ErrorCode = 404,
                    ErrorMessage = "Service is not initialized to register device"
                });

                return;
            }

            var obj = new ITLAccountRegisterDevice
            {
                //TokenType = 3,   // MPNS
                //TokenType = 8,   // WNS
                TokenType = tokenType,
                Token = token
            };

            const string methodName = "account.registerDevice";
            Logs.Log.Write(string.Format("{0} {1}", methodName, obj));
            SendInformativeMessage<bool>(methodName, obj,
                result =>
                {
                    Logs.Log.Write(string.Format("{0} result={1}", methodName, result));

                    callback?.Invoke(result);
                },
                error =>
                {
                    Logs.Log.Write(string.Format("{0} error={1}", methodName, error));

                    faultCallback?.Invoke(error);
                });
        }

        public void UnregisterDeviceAsync(int tokenType, string token, Action<bool> callback, Action<TLRPCError> faultCallback = null)
        {
            var obj = new ITLAccountUnregisterDevice
            {
                //TokenType = 3,   // MPNS
                //TokenType = 8,   // WNS
                TokenType = tokenType,
                Token = token
            };

            const string methodName = "account.unregisterDevice";
            Logs.Log.Write(string.Format("{0} {1}", methodName, obj));
            SendInformativeMessage<bool>("account.unregisterDevice", obj,
                result =>
                {
                    Logs.Log.Write(string.Format("{0} result={1}", methodName, result));

                    callback?.Invoke(result);
                },
                error =>
                {
                    Logs.Log.Write(string.Format("{0} error={1}", methodName, error));

                    faultCallback?.Invoke(error);
                });
        }

        public void GetNotifySettingsAsync(TLInputNotifyPeerBase peer, Action<TLPeerNotifySettingsBase> callback, Action<TLRPCError> faultCallback = null)
        {
            var obj = new ITLAccountGetNotifySettings { Peer = peer };

            SendInformativeMessage("account.getNotifySettings", obj, callback, faultCallback);
        }

        public void ResetNotifySettingsAsync(Action<bool> callback, Action<TLRPCError> faultCallback = null)
        {
            Execute.ShowDebugMessage(string.Format("account.resetNotifySettings"));

            var obj = new ITLAccountResetNotifySettings();

            SendInformativeMessage("account.resetNotifySettings", obj, callback, faultCallback);
        }

	    public void UpdateNotifySettingsAsync(TLInputNotifyPeerBase peer, TLInputPeerNotifySettings settings, Action<bool> callback, Action<TLRPCError> faultCallback = null)
        {
            //Execute.ShowDebugMessage(string.Format("account.updateNotifySettings peer=[{0}] settings=[{1}]", peer, settings));

            var obj = new ITLAccountUpdateNotifySettings { Peer = peer, Settings = settings };

            SendInformativeMessage("account.updateNotifySettings", obj, callback, faultCallback);
        }

        public void UpdateProfileAsync(string firstName, string lastName, string about, Action<TLUserBase> callback, Action<TLRPCError> faultCallback = null)
        {
            var obj = new ITLAccountUpdateProfile { FirstName = firstName, LastName = lastName, About = about };

            SendInformativeMessage<TLUserBase>("account.updateProfile", obj, result => _cacheService.SyncUser(result, callback), faultCallback);
        }

        public void UpdateStatusAsync(bool offline, Action<bool> callback, Action<TLRPCError> faultCallback = null)
        {
            if (_activeTransport.AuthKey == null) return;

#if WIN_RT
            if (_deviceInfo != null && _deviceInfo.IsBackground)
            {
                var message = string.Format("::{0} {1} account.updateStatus {2}", _deviceInfo.BackgroundTaskName, _deviceInfo.BackgroundTaskId, offline);
                Logs.Log.Write(message);
#if DEBUG
                AddToast("task", message);
#endif
            }
#endif
            var obj = new ITLAccountUpdateStatus { Offline = offline };
            System.Diagnostics.Debug.WriteLine("account.updateStatus offline=" + offline);
            SendInformativeMessage("account.updateStatus", obj, callback, faultCallback);
        }
#if WIN_RT
        public static void AddToast(string caption, string message)
        {
            var toastNotifier = ToastNotificationManager.CreateToastNotifier();

            var toastXml = ToastNotificationManager.GetTemplateContent(ToastTemplateType.ToastText02);
            SetText(toastXml, caption, message);

            try
            {
                var toast = new ToastNotification(toastXml);
                //RemoveToastGroup(group);
                toastNotifier.Show(toast);
            }
            catch (Exception ex)
            {
                Logs.Log.Write(ex.ToString());
            }
        }

        private static void SetText(XmlDocument document, string caption, string message)
        {
            var toastTextElements = document.GetElementsByTagName("text");
            toastTextElements[0].InnerText = caption ?? string.Empty;
            toastTextElements[1].InnerText = message ?? string.Empty;
        }
#endif

	    public void CheckUsernameAsync(string username, Action<bool> callback, Action<TLRPCError> faultCallback = null)
	    {
            var obj = new ITLAccountCheckUsername { Username = username };

            SendInformativeMessage("account.checkUsername", obj, callback, faultCallback);
	    }

	    public void UpdateUsernameAsync(string username, Action<TLUserBase> callback, Action<TLRPCError> faultCallback = null)
	    {
            var obj = new ITLAccountUpdateUsername { Username = username };

            SendInformativeMessage("account.updateUsername", obj, callback, faultCallback);
	    }

	    public void GetAccountTTLAsync(Action<TLAccountDaysTTL> callback, Action<TLRPCError> faultCallback = null)
	    {
            var obj = new ITLAccountGetAccountTTL();

            SendInformativeMessage("account.getAccountTTL", obj, callback, faultCallback);
	    }

        public void SetAccountTTLAsync(TLAccountDaysTTL ttl, Action<bool> callback, Action<TLRPCError> faultCallback = null)
        {
            var obj = new ITLAccountSetAccountTTL { TTL = ttl};

            SendInformativeMessage("account.setAccountTTL", obj, callback, faultCallback);
        }

        public void DeleteAccountTTLAsync(string reason, Action<bool> callback, Action<TLRPCError> faultCallback = null)
        {
            var obj = new ITLAccountDeleteAccount { Reason = reason };

            SendInformativeMessage("account.deleteAccount", obj, callback, faultCallback);
        }

        public void GetPrivacyAsync(TLInputPrivacyKeyBase key, Action<TLAccountPrivacyRules> callback, Action<TLRPCError> faultCallback = null)
        {
            var obj = new ITLAccountGetPrivacy { Key = key };

            SendInformativeMessage("account.getPrivacy", obj, callback, faultCallback);
        }

        public void SetPrivacyAsync(TLInputPrivacyKeyBase key, TLVector<TLInputPrivacyRuleBase> rules, Action<TLAccountPrivacyRules> callback, Action<TLRPCError> faultCallback = null)
        {
            var obj = new ITLAccountSetPrivacy { Key = key, Rules = rules };

            SendInformativeMessage("account.setPrivacy", obj, callback, faultCallback);
        }

        public void GetAuthorizationsAsync(Action<TLAccountAuthorizations> callback, Action<TLRPCError> faultCallback = null)
        {
            var obj = new ITLAccountGetAuthorizations();

            SendInformativeMessage("account.getAuthorizations", obj, callback, faultCallback);
        }

        public void ResetAuthorizationAsync(long hash, Action<bool> callback, Action<TLRPCError> faultCallback = null)
        {
            var obj = new ITLAccountResetAuthorization { Hash = hash };

            SendInformativeMessage("account.resetAuthorization", obj, callback, faultCallback);
        }

	    public void GetPasswordAsync(Action<TLAccountPasswordBase> callback, Action<TLRPCError> faultCallback = null)
	    {
            var obj = new ITLAccountGetPassword();

            SendInformativeMessage("account.getPassword", obj, callback, faultCallback);
	    }

	    public void GetPasswordSettingsAsync(byte[] currentPasswordHash, Action<TLAccountPasswordSettings> callback, Action<TLRPCError> faultCallback = null)
	    {
            var obj = new ITLAccountGetPasswordSettings { CurrentPasswordHash = currentPasswordHash };

            SendInformativeMessage("account.getPasswordSettings", obj, callback, faultCallback);
	    }

	    public void UpdatePasswordSettingsAsync(byte[] currentPasswordHash, TLAccountPasswordInputSettings newSettings, Action<bool> callback, Action<TLRPCError> faultCallback = null)
	    {
            var obj = new ITLAccountUpdatePasswordSettings { CurrentPasswordHash = currentPasswordHash, NewSettings = newSettings };

            SendInformativeMessage("account.updatePasswordSettings", obj, callback, faultCallback);
	    }

	    public void CheckPasswordAsync(byte[] passwordHash, Action<TLAuthAuthorization> callback, Action<TLRPCError> faultCallback = null)
	    {
            var obj = new ITLAuthCheckPassword { PasswordHash = passwordHash };

            SendInformativeMessage("auth.checkPassword", obj, callback, faultCallback);
	    }

	    public void RequestPasswordRecoveryAsync(Action<TLAuthPasswordRecovery> callback, Action<TLRPCError> faultCallback = null)
	    {
            var obj = new ITLAuthRequestPasswordRecovery();

            SendInformativeMessage("auth.requestPasswordRecovery", obj, callback, faultCallback);
	    }

	    public void RecoverPasswordAsync(string code, Action<TLAuthAuthorization> callback, Action<TLRPCError> faultCallback = null)
	    {
	        var obj = new ITLAuthRecoverPassword {Code = code};

            SendInformativeMessage("auth.recoverPassword", obj, callback, faultCallback);
	    }


	    public void ConfirmPhoneAsync(string phoneCodeHash, string phoneCode, Action<bool> callback, Action<TLRPCError> faultCallback = null)
	    {
            var obj = new ITLAccountConfirmPhone { PhoneCodeHash = phoneCodeHash, PhoneCode = phoneCode };

            SendInformativeMessage("account.confirmPhone", obj, callback, faultCallback);
	    }

	    public void SendConfirmPhoneCodeAsync(string hash, bool currentNumber, Action<TLAuthSentCode> callback, Action<TLRPCError> faultCallback = null)
	    {
            var obj = new ITLAccountSendConfirmPhoneCode { Flags = 0, Hash = hash, CurrentNumber = currentNumber };

            SendInformativeMessage("account.sendConfirmPhoneCode", obj, callback, faultCallback);
	    }
	}
}
