using System;
using Telegram.Api.Extensions;
using Telegram.Api.Helpers;
using Telegram.Api.TL;
using Telegram.Api.TL.Methods.Auth;
using Telegram.Api.Transport;

namespace Telegram.Api.Services
{
	public partial class MTProtoService
	{
	    public void LogOutAsync(Action callback)
	    {
	        _cacheService.ClearAsync(callback);

            //try to close session
            LogOutAsync(null, null);
	    }

        public void CheckPhoneAsync(string phoneNumber, Action<TLAuthCheckedPhone> callback, Action<TLRPCError> faultCallback = null)
	    {
            var obj = new ITLAuthCheckPhone { PhoneNumber = phoneNumber };

            SendInformativeMessage("auth.checkPhone", obj, callback, faultCallback);
	    }

        public void SendCodeAsync(string phoneNumber, bool? currentNumber, Action<TLAuthSentCode> callback, Action<int> attemptFailed = null, Action<TLRPCError> faultCallback = null)
        {
            var obj = new ITLAuthSendCode
            {
                Flags = 0,
                PhoneNumber = phoneNumber,
                CurrentNumber = currentNumber,
                ApiId = Constants.ApiId,
                ApiHash = Constants.ApiHash
            };

            SendInformativeMessage("auth.sendCode", obj, callback, faultCallback, 3);
        }

        public void ResendCodeAsync(string phoneNumber, string phoneCodeHash, Action<TLAuthSentCode> callback, Action<TLRPCError> faultCallback = null)
        {
            var obj = new ITLAuthResendCode { PhoneNumber = phoneNumber, PhoneCodeHash = phoneCodeHash };

            SendInformativeMessage("auth.resendCode", obj, callback, faultCallback);
        }

        public void CancelCodeAsync(string phoneNumber, string phoneCodeHash, Action<bool> callback, Action<TLRPCError> faultCallback = null)
        {
            var obj = new ITLAuthCancelCode { PhoneNumber = phoneNumber, PhoneCodeHash = phoneCodeHash };

            SendInformativeMessage("auth.cancelCode", obj, callback, faultCallback);
        }

        // Fela: DEPRECATED
        //public void SendCallAsync(string phoneNumber, string phoneCodeHash, Action<bool> callback, Action<TLRPCError> faultCallback = null)
        //{
        //    var obj = new ITLSendCall { PhoneNumber = phoneNumber, PhoneCodeHash = phoneCodeHash };

        //    SendInformativeMessage("auth.sendCall", obj, callback, faultCallback);
        //}

        public void SignUpAsync(string phoneNumber, string phoneCodeHash, string phoneCode, string firstName, string lastName, Action<TLAuthAuthorization> callback, Action<TLRPCError> faultCallback = null)
	    {
            var obj = new ITLAuthSignUp { PhoneNumber = phoneNumber, PhoneCodeHash = phoneCodeHash, PhoneCode = phoneCode, FirstName = firstName, LastName = lastName };

            SendInformativeMessage<TLAuthAuthorization>("auth.signUp", obj,
                auth =>
                {
                    _cacheService.SyncUser(auth.User, result => { });
                    callback(auth);
                },
                faultCallback);
	    }

        public void SignInAsync(string phoneNumber, string phoneCodeHash, string phoneCode, Action<TLAuthAuthorization> callback, Action<TLRPCError> faultCallback = null)
        {
            var obj = new ITLAuthSignIn { PhoneNumber = phoneNumber, PhoneCodeHash = phoneCodeHash, PhoneCode = phoneCode};

            SendInformativeMessage<TLAuthAuthorization>("auth.signIn", obj,
                auth =>
                {
                    _cacheService.SyncUser(auth.User, result => { }); 
                    callback(auth);
                }, 
                faultCallback);
        }

	    public void CancelSignInAsync()
	    {
	        CancelDelayedItemsAsync(true);
	    }

        public void LogOutAsync(Action<bool> callback, Action<TLRPCError> faultCallback = null)
        {
            var obj = new ITLAuthLogOut();

            const string methodName = "auth.logOut";
            Logs.Log.Write(methodName);
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

        public void SendInvitesAsync(TLVector<string> phoneNumbers, string message, Action<bool> callback, Action<TLRPCError> faultCallback = null)
	    {
            var obj = new ITLAuthSendInvites { PhoneNumbers = phoneNumbers, Message = message };

            SendInformativeMessage("auth.sendInvites", obj, callback, faultCallback);
	    }

	    public void ExportAuthorizationAsync(int dcId, Action<TLAuthExportedAuthorization> callback, Action<TLRPCError> faultCallback = null)
	    {
            var obj = new ITLAuthExportAuthorization { DCId = dcId };

            SendInformativeMessage("auth.exportAuthorization dc_id=" + dcId, obj, callback, faultCallback);
	    }

	    public void ImportAuthorizationAsync(int id, byte[] bytes, Action<TLAuthAuthorization> callback, Action<TLRPCError> faultCallback = null)
	    {
            var obj = new ITLAuthImportAuthorization { Id = id, Bytes = bytes };

            SendInformativeMessage("auth.importAuthorization id=" + id, obj, callback, faultCallback);
	    }

        private void ImportAuthorizationByTransportAsync(ITransport transport, int id, byte[] bytes, Action<TLAuthAuthorization> callback, Action<TLRPCError> faultCallback = null)
        {
            var obj = new ITLAuthImportAuthorization { Id = id, Bytes = bytes };

            SendInformativeMessageByTransport(transport, "auth.importAuthorization dc_id=" + transport.DCId, obj, callback, faultCallback);
        }

        public void ResetAuthorizationsAsync(Action<bool> callback, Action<TLRPCError> faultCallback = null)
        {
            var obj = new ITLAuthResetAuthorizations();

            SendInformativeMessage("auth.resetAuthorizations", obj, callback, faultCallback);
        }
	}
}
