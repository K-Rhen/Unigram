using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Telegram.Api.TL;
using Telegram.Api.TL.Methods.Channels;
using Telegram.Api.TL.Methods.Contacts;
using Windows.Foundation;

namespace Telegram.Api.Services
{
    public partial class MTProtoService
    {
        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLPhonePhoneCall>> AcceptCallAsync(TLInputPhoneCall peer, byte[] gb)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLPhonePhoneCall>>();
                AcceptCallAsync(peer, gb, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLPhonePhoneCall>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLPhonePhoneCall>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLPhonePhoneCall>> ConfirmCallAsync(TLInputPhoneCall peer, byte[] ga, long fingerprint)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLPhonePhoneCall>>();
                ConfirmCallAsync(peer, ga, fingerprint, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLPhonePhoneCall>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLPhonePhoneCall>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLUpdatesBase>> DiscardCallAsync(TLInputPhoneCall peer, int duration, TLPhoneCallDiscardReasonBase reason, long connectionId)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLUpdatesBase>>();
                DiscardCallAsync(peer, duration, reason, connectionId, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUpdatesBase>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUpdatesBase>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLDataJSON>> GetCallConfigAsync()
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLDataJSON>>();
                GetCallConfigAsync((callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLDataJSON>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLDataJSON>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<bool>> ReceivedCallAsync(TLInputPhoneCall peer)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<bool>>();
                ReceivedCallAsync(peer, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLPhonePhoneCall>> RequestCallAsync(TLInputUserBase userId, int randomId, byte[] gaHash)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLPhonePhoneCall>>();
                RequestCallAsync(userId, randomId, gaHash, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLPhonePhoneCall>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLPhonePhoneCall>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<bool>> SaveCallDebugAsync(TLInputPhoneCall peer, TLDataJSON debug)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<bool>>();
                SaveCallDebugAsync(peer, debug, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLUpdatesBase>> SetCallRatingAsync(TLInputPhoneCall peer, int rating, string comment)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLUpdatesBase>>();
                SetCallRatingAsync(peer, rating, comment, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUpdatesBase>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUpdatesBase>(faultCallback));
                });
                return tsc.Task;
            });
        }









        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLVector<TLStickerSetCoveredBase>>> GetAttachedStickersAsync(TLInputStickeredMediaBase media)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLVector<TLStickerSetCoveredBase>>>();
                GetAttachedStickersAsync(media, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLVector<TLStickerSetCoveredBase>>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLVector<TLStickerSetCoveredBase>>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<T>> SendRequestAsync<T>(string caption, TLObject obj)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<T>>();
                SendRequestAsync<T>(caption, obj, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<T>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<T>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<bool>> ClearSavedInfoAsync(bool info, bool credentials)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<bool>>();
                ClearSavedInfoAsync(info, credentials, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLPaymentsPaymentForm>> GetPaymentFormAsync(int msgId)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLPaymentsPaymentForm>>();
                GetPaymentFormAsync(msgId, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLPaymentsPaymentForm>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLPaymentsPaymentForm>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLPaymentsPaymentReceipt>> GetPaymentReceiptAsync(int msgId)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLPaymentsPaymentReceipt>>();
                GetPaymentReceiptAsync(msgId, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLPaymentsPaymentReceipt>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLPaymentsPaymentReceipt>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLPaymentsSavedInfo>> GetSavedInfoAsync()
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLPaymentsSavedInfo>>();
                GetSavedInfoAsync((callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLPaymentsSavedInfo>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLPaymentsSavedInfo>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLPaymentsPaymentResultBase>> SendPaymentFormAsync(int msgId, string infoId, string optionId, TLInputPaymentCredentialsBase credentials)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLPaymentsPaymentResultBase>>();
                SendPaymentFormAsync(msgId, infoId, optionId, credentials, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLPaymentsPaymentResultBase>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLPaymentsPaymentResultBase>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLAccountTmpPassword>> GetTmpPasswordAsync(byte[] hash, int period)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLAccountTmpPassword>>();
                GetTmpPasswordAsync(hash, period, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLAccountTmpPassword>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLAccountTmpPassword>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLPaymentsValidatedRequestedInfo>> ValidateRequestedInfoAsync(int msgId, TLPaymentRequestedInfo info, bool save)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLPaymentsValidatedRequestedInfo>>();
                ValidateRequestedInfoAsync(msgId, info, save, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLPaymentsValidatedRequestedInfo>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLPaymentsValidatedRequestedInfo>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLMessagesChatsBase>> GetCommonChatsAsync(TLInputUserBase id, int maxId, int limit)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLMessagesChatsBase>>();
                GetCommonChatsAsync(id, maxId, limit, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessagesChatsBase>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessagesChatsBase>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<bool>> ReorderPinnedDialogsAsync(TLVector<TLInputPeerBase> order, bool force)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<bool>>();
                ReorderPinnedDialogsAsync(order, force, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<bool>> ToggleDialogPinAsync(TLInputPeerBase peer, bool pin)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<bool>>();
                ToggleDialogPinAsync(peer, pin, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLAuthSentCode>> SendCodeAsync(string phoneNumber, bool? currentNumber, Action<int> attemptFailed = null)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLAuthSentCode>>();
                SendCodeAsync(phoneNumber, currentNumber, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLAuthSentCode>(callback));
                }, attemptFailed, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLAuthSentCode>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLMessagesRecentStickersBase>> GetRecentStickersAsync(bool attached, int hash)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLMessagesRecentStickersBase>>();
                GetRecentStickersAsync(attached, hash, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessagesRecentStickersBase>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessagesRecentStickersBase>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLMessagesAffectedMessages>> ReadMessageContentsAsync(TLVector<int> id)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLMessagesAffectedMessages>>();
                ReadMessageContentsAsync(id, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessagesAffectedMessages>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessagesAffectedMessages>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLUpdatesBase>> JoinChannelAsync(TLChannel channel)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLUpdatesBase>>();
                JoinChannelAsync(channel, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUpdatesBase>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUpdatesBase>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLMessagesBotCallbackAnswer>> GetBotCallbackAnswerAsync(TLInputPeerBase peer, int messageId, byte[] data, bool game)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLMessagesBotCallbackAnswer>>();
                GetBotCallbackAnswerAsync(peer, messageId, data, game, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessagesBotCallbackAnswer>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessagesBotCallbackAnswer>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLMessagesAffectedMessages>> DeleteMessagesAsync(TLVector<int> id, bool revoke)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLMessagesAffectedMessages>>();
                DeleteMessagesAsync(id, revoke, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessagesAffectedMessages>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessagesAffectedMessages>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLHelpTermsOfService>> GetTermsOfServiceAsync(string langCode)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLHelpTermsOfService>>();
                GetTermsOfServiceAsync(langCode, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLHelpTermsOfService>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLHelpTermsOfService>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLChannelsChannelParticipant>> GetParticipantAsync(TLInputChannelBase inputChannel, TLInputUserBase userId)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLChannelsChannelParticipant>>();
                GetParticipantAsync(inputChannel, userId, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLChannelsChannelParticipant>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLChannelsChannelParticipant>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLMessagesMessagesBase>> GetMessagesAsync(TLInputChannelBase inputChannel, TLVector<int> id)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLMessagesMessagesBase>>();
                GetMessagesAsync(inputChannel, id, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessagesMessagesBase>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessagesMessagesBase>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLUpdatesBase>> AddChatUserAsync(int chatId, TLInputUserBase userId, int fwdLimit)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLUpdatesBase>>();
                AddChatUserAsync(chatId, userId, fwdLimit, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUpdatesBase>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUpdatesBase>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLUpdatesBase>> ForwardMessagesAsync(TLInputPeerBase toPeer, TLInputPeerBase fromPeer, TLVector<int> id, IList<TLMessage> messages, bool withMyScore)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLUpdatesBase>>();
                ForwardMessagesAsync(toPeer, fromPeer, id, messages, withMyScore, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUpdatesBase>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUpdatesBase>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<bool>> ReorderStickerSetsAsync(bool masks, TLVector<long> order)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<bool>>();
                ReorderStickerSetsAsync(masks, order, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLMessage>> SendInlineBotResultAsync(TLMessage message, Action fastCallback)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLMessage>>();
                SendInlineBotResultAsync(message, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessage>(callback));
                }, fastCallback, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessage>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLUpdatesBase>> GetAllDraftsAsync()
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLUpdatesBase>>();
                GetAllDraftsAsync((callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUpdatesBase>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUpdatesBase>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLAccountPrivacyRules>> GetPrivacyAsync(TLInputPrivacyKeyBase key)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLAccountPrivacyRules>>();
                GetPrivacyAsync(key, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLAccountPrivacyRules>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLAccountPrivacyRules>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLNearestDC>> GetNearestDCAsync()
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLNearestDC>>();
                GetNearestDCAsync((callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLNearestDC>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLNearestDC>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLMessagesAffectedMessages>> ReadHistoryAsync(TLInputPeerBase peer, int maxId, int offset)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLMessagesAffectedMessages>>();
                ReadHistoryAsync(peer, maxId, offset, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessagesAffectedMessages>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessagesAffectedMessages>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLAccountPasswordSettings>> GetPasswordSettingsAsync(byte[] currentPasswordHash)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLAccountPasswordSettings>>();
                GetPasswordSettingsAsync(currentPasswordHash, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLAccountPasswordSettings>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLAccountPasswordSettings>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLMessagesAffectedHistory>> DeleteUserHistoryAsync(TLChannel channel, TLInputUserBase userId)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLMessagesAffectedHistory>>();
                DeleteUserHistoryAsync(channel, userId, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessagesAffectedHistory>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessagesAffectedHistory>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLExportedMessageLink>> ExportMessageLinkAsync(TLInputChannelBase channel, int id)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLExportedMessageLink>>();
                ExportMessageLinkAsync(channel, id, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLExportedMessageLink>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLExportedMessageLink>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLUpdatesBase>> EditAdminAsync(TLChannel channel, TLInputUserBase userId, TLChannelParticipantRoleBase role)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLUpdatesBase>>();
                EditAdminAsync(channel, userId, role, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUpdatesBase>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUpdatesBase>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLPeerSettings>> GetPeerSettingsAsync(TLInputPeerBase peer)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLPeerSettings>>();
                GetPeerSettingsAsync(peer, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLPeerSettings>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLPeerSettings>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLMessagesStickerSet>> GetStickerSetAsync(TLInputStickerSetBase stickerset)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLMessagesStickerSet>>();
                GetStickerSetAsync(stickerset, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessagesStickerSet>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessagesStickerSet>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<bool>> SaveGifAsync(TLInputDocumentBase id, bool unsave)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<bool>>();
                SaveGifAsync(id, unsave, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLHelpSupport>> GetSupportAsync()
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLHelpSupport>>();
                GetSupportAsync((callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLHelpSupport>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLHelpSupport>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLMessagesDHConfig>> GetDHConfigAsync(int version, int randomLength)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLMessagesDHConfig>>();
                GetDHConfigAsync(version, randomLength, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessagesDHConfig>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessagesDHConfig>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<bool>> ResetNotifySettingsAsync()
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<bool>>();
                ResetNotifySettingsAsync((callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<bool>> UnblockAsync(TLInputUserBase id)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<bool>>();
                UnblockAsync(id, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<bool>> SetTypingAsync(TLInputPeerBase peer, TLSendMessageActionBase action)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<bool>>();
                SetTypingAsync(peer, action, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLUpdatesDifferenceBase>> GetDifferenceWithoutUpdatesAsync(int pts, int date, int qts)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLUpdatesDifferenceBase>>();
                GetDifferenceWithoutUpdatesAsync(pts, date, qts, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUpdatesDifferenceBase>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUpdatesDifferenceBase>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<bool>> UpdatePasswordSettingsAsync(byte[] currentPasswordHash, TLAccountPasswordInputSettings newSettings)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<bool>>();
                UpdatePasswordSettingsAsync(currentPasswordHash, newSettings, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<bool>> ReadHistoryAsync(TLChannel channel, int maxId)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<bool>>();
                ReadHistoryAsync(channel, maxId, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLContactsTopPeersBase>> GetTopPeersAsync(TLContactsGetTopPeersFlag flags, int offset, int limit, int hash)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLContactsTopPeersBase>>();
                GetTopPeersAsync(flags, offset, limit, hash, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLContactsTopPeersBase>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLContactsTopPeersBase>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLUpdatesBase>> EditChatTitleAsync(int chatId, string title)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLUpdatesBase>>();
                EditChatTitleAsync(chatId, title, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUpdatesBase>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUpdatesBase>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<bool>> CheckUsernameAsync(string username)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<bool>>();
                CheckUsernameAsync(username, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<bool>> ResetAuthorizationsAsync()
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<bool>>();
                ResetAuthorizationsAsync((callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLPhotosPhotosBase>> GetUserPhotosAsync(TLInputUserBase userId, int offset, long maxId, int limit)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLPhotosPhotosBase>>();
                GetUserPhotosAsync(userId, offset, maxId, limit, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLPhotosPhotosBase>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLPhotosPhotosBase>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLPhotosPhoto>> UploadProfilePhotoAsync(TLInputFile file)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLPhotosPhoto>>();
                UploadProfilePhotoAsync(file, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLPhotosPhoto>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLPhotosPhoto>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<bool>> UpdateNotifySettingsAsync(TLInputNotifyPeerBase peer, TLInputPeerNotifySettings settings)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<bool>>();
                UpdateNotifySettingsAsync(peer, settings, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLUploadFile>> GetFileAsync(int dcId, TLInputFileLocationBase location, int offset, int limit)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLUploadFile>>();
                GetFileAsync(dcId, location, offset, limit, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUploadFile>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUploadFile>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLUserBase>> UpdateProfileAsync(string firstName, string lastName, string about)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLUserBase>>();
                UpdateProfileAsync(firstName, lastName, about, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUserBase>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUserBase>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLContactsImportedContacts>> ImportContactsAsync(TLVector<TLInputContactBase> contacts, bool replace)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLContactsImportedContacts>>();
                ImportContactsAsync(contacts, replace, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLContactsImportedContacts>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLContactsImportedContacts>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<bool>> SetTypingAsync(TLInputPeerBase peer, bool typing)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<bool>>();
                SetTypingAsync(peer, typing, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<bool>> RegisterDeviceAsync(int tokenType, string token)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<bool>>();
                RegisterDeviceAsync(tokenType, token, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<bool>> LogOutAsync()
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<bool>>();
                LogOutAsync((callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLUpdatesBase>> ToggleSignaturesAsync(TLInputChannelBase channel, bool enabled)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLUpdatesBase>>();
                ToggleSignaturesAsync(channel, enabled, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUpdatesBase>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUpdatesBase>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLChannelsChannelParticipants>> GetParticipantsAsync(TLInputChannelBase inputChannel, TLChannelParticipantsFilterBase filter, int offset, int limit)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLChannelsChannelParticipants>>();
                GetParticipantsAsync(inputChannel, filter, offset, limit, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLChannelsChannelParticipants>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLChannelsChannelParticipants>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLMessagesMessagesBase>> GetChannelHistoryAsync(string debugInfo, TLInputPeerBase inputPeer, TLPeerBase peer, bool sync, int offset, int maxId, int limit)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLMessagesMessagesBase>>();
                GetChannelHistoryAsync(debugInfo, inputPeer, peer, sync, offset, maxId, limit, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessagesMessagesBase>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessagesMessagesBase>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLUpdatesBase>> DeleteChatUserAsync(int chatId, TLInputUserBase userId)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLUpdatesBase>>();
                DeleteChatUserAsync(chatId, userId, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUpdatesBase>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUpdatesBase>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLUpdatesBase>> ForwardMessageAsync(TLInputPeerBase peer, int fwdMessageId, TLMessage message)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLUpdatesBase>>();
                ForwardMessageAsync(peer, fwdMessageId, message, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUpdatesBase>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUpdatesBase>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLMessagesMessagesBase>> SearchGlobalAsync(string query, int offsetDate, TLInputPeerBase offsetPeer, int offsetId, int limit)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLMessagesMessagesBase>>();
                SearchGlobalAsync(query, offsetDate, offsetPeer, offsetId, limit, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessagesMessagesBase>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessagesMessagesBase>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLMessagesFoundGifs>> SearchGifsAsync(string q, int offset)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLMessagesFoundGifs>>();
                SearchGifsAsync(q, offset, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessagesFoundGifs>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessagesFoundGifs>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLMessagesBotResults>> GetInlineBotResultsAsync(TLInputUserBase bot, TLInputPeerBase peer, TLInputGeoPointBase geoPoint, string query, string offset)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLMessagesBotResults>>();
                GetInlineBotResultsAsync(bot, peer, geoPoint, query, offset, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessagesBotResults>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessagesBotResults>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLMessagesFeaturedStickersBase>> GetFeaturedStickersAsync(int hash)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLMessagesFeaturedStickersBase>>();
                GetFeaturedStickersAsync(hash, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessagesFeaturedStickersBase>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessagesFeaturedStickersBase>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLVector<TLUserBase>>> GetUsersAsync(TLVector<TLInputUserBase> id)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLVector<TLUserBase>>>();
                GetUsersAsync(id, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLVector<TLUserBase>>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLVector<TLUserBase>>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<bool>> UnregisterDeviceAsync(int tokenType, string token)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<bool>>();
                UnregisterDeviceAsync(tokenType, token, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<bool>> ConfirmPhoneAsync(string phoneCodeHash, string phoneCode)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<bool>>();
                ConfirmPhoneAsync(phoneCodeHash, phoneCode, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<bool>> UpdateUsernameAsync(TLInputChannelBase channel, string username)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<bool>>();
                UpdateUsernameAsync(channel, username, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLMessagesStickerSetInstallResultBase>> InstallStickerSetAsync(TLInputStickerSetBase stickerset, bool archived)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLMessagesStickerSetInstallResultBase>>();
                InstallStickerSetAsync(stickerset, archived, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessagesStickerSetInstallResultBase>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessagesStickerSetInstallResultBase>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLChatInviteBase>> CheckChatInviteAsync(string hash)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLChatInviteBase>>();
                CheckChatInviteAsync(hash, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLChatInviteBase>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLChatInviteBase>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLDocumentBase>> GetDocumentByHashAsync(byte[] sha256, int size, string mimeType)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLDocumentBase>>();
                GetDocumentByHashAsync(sha256, size, mimeType, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLDocumentBase>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLDocumentBase>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<bool>> SaveDraftAsync(TLInputPeerBase peer, TLDraftMessageBase draft)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<bool>>();
                SaveDraftAsync(peer, draft, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLUserProfilePhotoBase>> UpdateProfilePhotoAsync(TLInputPhotoBase id)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLUserProfilePhotoBase>>();
                UpdateProfilePhotoAsync(id, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUserProfilePhotoBase>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUserProfilePhotoBase>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLVector<long>>> DeletePhotosAsync(TLVector<TLInputPhotoBase> id)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLVector<long>>>();
                DeletePhotosAsync(id, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLVector<long>>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLVector<long>>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLContactsBlockedBase>> GetBlockedAsync(int offset, int limit)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLContactsBlockedBase>>();
                GetBlockedAsync(offset, limit, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLContactsBlockedBase>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLContactsBlockedBase>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLContactsContactsBase>> GetContactsAsync(string hash)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLContactsContactsBase>>();
                GetContactsAsync(hash, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLContactsContactsBase>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLContactsContactsBase>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLUserFull>> GetFullUserAsync(TLInputUserBase id)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLUserFull>>();
                GetFullUserAsync(id, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUserFull>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUserFull>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLUpdatesDifferenceBase>> GetDifferenceAsync(int pts, int date, int qts)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLUpdatesDifferenceBase>>();
                GetDifferenceAsync(pts, date, qts, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUpdatesDifferenceBase>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUpdatesDifferenceBase>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLAuthAuthorization>> CheckPasswordAsync(byte[] passwordHash)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLAuthAuthorization>>();
                CheckPasswordAsync(passwordHash, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLAuthAuthorization>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLAuthAuthorization>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<bool>> ResetTopPeerRatingAsync(TLTopPeerCategoryBase category, TLInputPeerBase peer)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<bool>>();
                ResetTopPeerRatingAsync(category, peer, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLMessageMediaBase>> GetWebPagePreviewAsync(string message)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLMessageMediaBase>>();
                GetWebPagePreviewAsync(message, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessageMediaBase>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessageMediaBase>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLWebPageBase>> GetWebPageAsync(string url, int hash)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLWebPageBase>>();
                GetWebPageAsync(url, hash, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLWebPageBase>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLWebPageBase>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLUpdatesBase>> EditChatPhotoAsync(int chatId, TLInputChatPhotoBase photo)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLUpdatesBase>>();
                EditChatPhotoAsync(chatId, photo, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUpdatesBase>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUpdatesBase>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLUserBase>> UpdateUsernameAsync(string username)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLUserBase>>();
                UpdateUsernameAsync(username, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUserBase>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUserBase>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLAuthSentCode>> SendConfirmPhoneCodeAsync(string hash, bool currentNumber)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLAuthSentCode>>();
                SendConfirmPhoneCodeAsync(hash, currentNumber, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLAuthSentCode>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLAuthSentCode>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<bool>> EditAboutAsync(TLChannel channel, string about)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<bool>>();
                EditAboutAsync(channel, about, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<bool>> ClearRecentStickersAsync(bool attached)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<bool>>();
                ClearRecentStickersAsync(attached, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<bool>> HideReportSpamAsync(TLInputPeerBase peer)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<bool>>();
                HideReportSpamAsync(peer, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLUpdatesBase>> ImportChatInviteAsync(string hash)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLUpdatesBase>>();
                ImportChatInviteAsync(hash, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUpdatesBase>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUpdatesBase>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLAuthSentCode>> SendChangePhoneCodeAsync(string phoneNumber, bool? currentNumber)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLAuthSentCode>>();
                SendChangePhoneCodeAsync(phoneNumber, currentNumber, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLAuthSentCode>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLAuthSentCode>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLAccountPrivacyRules>> SetPrivacyAsync(TLInputPrivacyKeyBase key, TLVector<TLInputPrivacyRuleBase> rules)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLAccountPrivacyRules>>();
                SetPrivacyAsync(key, rules, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLAccountPrivacyRules>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLAccountPrivacyRules>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<bool>> SetAccountTTLAsync(TLAccountDaysTTL ttl)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<bool>>();
                SetAccountTTLAsync(ttl, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLContactsFound>> SearchAsync(string q, int limit)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLContactsFound>>();
                SearchAsync(q, limit, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLContactsFound>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLContactsFound>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLMessagesChatFull>> GetFullChatAsync(int chatId)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLMessagesChatFull>>();
                GetFullChatAsync(chatId, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessagesChatFull>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessagesChatFull>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLMessagesChatFull>> UpdateChannelAsync(int? channelId)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLMessagesChatFull>>();
                UpdateChannelAsync(channelId, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessagesChatFull>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessagesChatFull>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLExportedChatInviteBase>> ExportChatInviteAsync(int chatId)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLExportedChatInviteBase>>();
                ExportChatInviteAsync(chatId, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLExportedChatInviteBase>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLExportedChatInviteBase>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<bool>> ReportSpamAsync(TLInputPeerBase peer)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<bool>>();
                ReportSpamAsync(peer, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLUpdatesState>> GetStateAsync()
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLUpdatesState>>();
                GetStateAsync((callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUpdatesState>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUpdatesState>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLUpdatesBase>> GetAppChangelogAsync(string prevAppVersion)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLUpdatesBase>>();
                GetAppChangelogAsync(prevAppVersion, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUpdatesBase>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUpdatesBase>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLAuthPasswordRecovery>> RequestPasswordRecoveryAsync()
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLAuthPasswordRecovery>>();
                RequestPasswordRecoveryAsync((callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLAuthPasswordRecovery>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLAuthPasswordRecovery>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLAccountPasswordBase>> GetPasswordAsync()
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLAccountPasswordBase>>();
                GetPasswordAsync((callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLAccountPasswordBase>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLAccountPasswordBase>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLUpdatesBase>> UpdatePinnedMessageAsync(bool silent, TLInputChannelBase channel, int id)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLUpdatesBase>>();
                UpdatePinnedMessageAsync(silent, channel, id, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUpdatesBase>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUpdatesBase>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLUpdatesBase>> EditPhotoAsync(TLChannel channel, TLInputChatPhotoBase photo)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLUpdatesBase>>();
                EditPhotoAsync(channel, photo, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUpdatesBase>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUpdatesBase>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLUpdatesBase>> KickFromChannelAsync(TLChannel channel, TLInputUserBase userId, bool kicked)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLUpdatesBase>>();
                KickFromChannelAsync(channel, userId, kicked, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUpdatesBase>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUpdatesBase>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLMessage>> SendMessageAsync(TLMessage message, Action fastCallback)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLMessage>>();
                SendMessageAsync(message, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessage>(callback));
                }, fastCallback, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessage>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLPong>> PingAsync(long pingId)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLPong>>();
                PingAsync(pingId, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLPong>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLPong>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLMessagesMessagesBase>> GetHistoryAsync(TLInputPeerBase inputPeer, TLPeerBase peer, bool sync, int offset, int offsetDate, int maxId, int limit)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLMessagesMessagesBase>>();
                GetHistoryAsync(inputPeer, peer, sync, offset, offsetDate, maxId, limit, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessagesMessagesBase>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessagesMessagesBase>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<bool>> ResetAuthorizationAsync(long hash)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<bool>>();
                ResetAuthorizationAsync(hash, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLUpdatesBase>> MigrateChatAsync(int chatId)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLUpdatesBase>>();
                MigrateChatAsync(chatId, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUpdatesBase>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUpdatesBase>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLUpdatesBase>> EditMessageAsync(TLInputPeerBase peer, int id, string message, TLVector<TLMessageEntityBase> entities, TLReplyMarkupBase replyMarkup, bool noWebPage)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLUpdatesBase>>();
                EditMessageAsync(peer, id, message, entities, replyMarkup, noWebPage, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUpdatesBase>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUpdatesBase>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLMessagesAffectedMessages>> DeleteMessagesAsync(TLInputChannelBase channel, TLVector<int> id)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLMessagesAffectedMessages>>();
                DeleteMessagesAsync(channel, id, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessagesAffectedMessages>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessagesAffectedMessages>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLUpdatesBase>> CreateChannelAsync(TLChannelsCreateChannelFlag flags, string title, string about)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLUpdatesBase>>();
                CreateChannelAsync(flags, title, about, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUpdatesBase>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUpdatesBase>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLMessagesMessagesBase>> GetMessagesAsync(TLVector<int> id)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLMessagesMessagesBase>>();
                GetMessagesAsync(id, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessagesMessagesBase>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessagesMessagesBase>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<bool>> CancelCodeAsync(string phoneNumber, string phoneCodeHash)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<bool>>();
                CancelCodeAsync(phoneNumber, phoneCodeHash, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLUpdatesBase>> EditTitleAsync(TLChannel channel, string title)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLUpdatesBase>>();
                EditTitleAsync(channel, title, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUpdatesBase>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUpdatesBase>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<bool>> UninstallStickerSetAsync(TLInputStickerSetBase stickerset)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<bool>>();
                UninstallStickerSetAsync(stickerset, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLUpdatesBase>> CreateChatAsync(TLVector<TLInputUserBase> users, string title)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLUpdatesBase>>();
                CreateChatAsync(users, title, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUpdatesBase>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUpdatesBase>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLUpdatesBase>> StartBotAsync(TLInputUserBase bot, string startParam, TLMessage message)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLUpdatesBase>>();
                StartBotAsync(bot, startParam, message, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUpdatesBase>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUpdatesBase>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLMessagesAffectedHistory>> DeleteHistoryAsync(bool justClear, TLInputPeerBase peer, int maxId)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLMessagesAffectedHistory>>();
                DeleteHistoryAsync(justClear, peer, maxId, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessagesAffectedHistory>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessagesAffectedHistory>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLAccountAuthorizations>> GetAuthorizationsAsync()
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLAccountAuthorizations>>();
                GetAuthorizationsAsync((callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLAccountAuthorizations>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLAccountAuthorizations>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<bool>> EditChatAdminAsync(int chatId, TLInputUserBase userId, bool isAdmin)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<bool>>();
                EditChatAdminAsync(chatId, userId, isAdmin, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLUpdatesBase>> InviteToChannelAsync(TLInputChannelBase channel, TLVector<TLInputUserBase> users)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLUpdatesBase>>();
                InviteToChannelAsync(channel, users, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUpdatesBase>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUpdatesBase>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLMessagesArchivedStickers>> GetArchivedStickersAsync(long offsetId, int limit, bool masks)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLMessagesArchivedStickers>>();
                GetArchivedStickersAsync(offsetId, limit, masks, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessagesArchivedStickers>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessagesArchivedStickers>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<bool>> UpdateDeviceLockedAsync(int period)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<bool>>();
                UpdateDeviceLockedAsync(period, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLContactsLink>> DeleteContactAsync(TLInputUserBase id)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLContactsLink>>();
                DeleteContactAsync(id, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLContactsLink>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLContactsLink>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLMessagesDialogsBase>> GetDialogsAsync(int offsetDate, int offsetId, TLInputPeerBase offsetPeer, int limit)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLMessagesDialogsBase>>();
                GetDialogsAsync(offsetDate, offsetId, offsetPeer, limit, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessagesDialogsBase>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessagesDialogsBase>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<bool>> ReportPeerAsync(TLInputPeerBase peer, TLReportReasonBase reason)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<bool>>();
                ReportPeerAsync(peer, reason, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<bool>> ReportSpamAsync(TLInputChannelBase channel, TLInputUserBase userId, TLVector<int> id)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<bool>>();
                ReportSpamAsync(channel, userId, id, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLUpdatesBase>> ToggleInvitesAsync(TLInputChannelBase channel, bool enabled)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLUpdatesBase>>();
                ToggleInvitesAsync(channel, enabled, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUpdatesBase>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUpdatesBase>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLExportedChatInviteBase>> ExportInviteAsync(TLInputChannelBase channel)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLExportedChatInviteBase>>();
                ExportInviteAsync(channel, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLExportedChatInviteBase>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLExportedChatInviteBase>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<bool>> SaveBigFilePartAsync(long fileId, int filePart, int fileTotalParts, byte[] bytes)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<bool>>();
                SaveBigFilePartAsync(fileId, filePart, fileTotalParts, bytes, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<bool>> UpdateStatusAsync(bool offline)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<bool>>();
                UpdateStatusAsync(offline, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<bool>> BlockAsync(TLInputUserBase id)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<bool>>();
                BlockAsync(id, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLAuthAuthorization>> SignUpAsync(string phoneNumber, string phoneCodeHash, string phoneCode, string firstName, string lastName)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLAuthAuthorization>>();
                SignUpAsync(phoneNumber, phoneCodeHash, phoneCode, firstName, lastName, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLAuthAuthorization>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLAuthAuthorization>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLUpdatesBase>> ToggleChatAdminsAsync(int chatId, bool enabled)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLUpdatesBase>>();
                ToggleChatAdminsAsync(chatId, enabled, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUpdatesBase>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUpdatesBase>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLMessagesMessageEditData>> GetMessageEditDataAsync(TLInputPeerBase peer, int id)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLMessagesMessageEditData>>();
                GetMessageEditDataAsync(peer, id, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessagesMessageEditData>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessagesMessageEditData>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<bool>> CheckUsernameAsync(TLInputChannelBase channel, string username)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<bool>>();
                CheckUsernameAsync(channel, username, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLMessagesChatFull>> GetFullChannelAsync(TLInputChannelBase channel)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLMessagesChatFull>>();
                GetFullChannelAsync(channel, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessagesChatFull>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessagesChatFull>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLUpdatesBase>> DeleteChannelAsync(TLChannel channel)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLUpdatesBase>>();
                DeleteChannelAsync(channel, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUpdatesBase>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUpdatesBase>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLMessagesPeerDialogs>> GetPeerDialogsAsync(TLVector<TLInputPeerBase> peers)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLMessagesPeerDialogs>>();
                GetPeerDialogsAsync(peers, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessagesPeerDialogs>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessagesPeerDialogs>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLUpdatesBase>> SendMediaAsync(TLInputPeerBase inputPeer, TLInputMediaBase inputMedia, TLMessage message)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLUpdatesBase>>();
                SendMediaAsync(inputPeer, inputMedia, message, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUpdatesBase>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUpdatesBase>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLMessagesSavedGifsBase>> GetSavedGifsAsync(int hash)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLMessagesSavedGifsBase>>();
                GetSavedGifsAsync(hash, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessagesSavedGifsBase>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessagesSavedGifsBase>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<bool>> SetInlineBotResultsAsync(bool gallery, bool pr, long queryId, TLVector<TLInputBotInlineResultBase> results, int cacheTime, string nextOffset, TLInlineBotSwitchPM switchPM)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<bool>>();
                SetInlineBotResultsAsync(gallery, pr, queryId, results, cacheTime, nextOffset, switchPM, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<bool>> ReadFeaturedStickersAsync(TLVector<long> id)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<bool>>();
                ReadFeaturedStickersAsync(id, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLMessagesAllStickersBase>> GetAllStickersAsync(int hash)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLMessagesAllStickersBase>>();
                GetAllStickersAsync(hash, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessagesAllStickersBase>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessagesAllStickersBase>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLVector<TLWallPaperBase>>> GetWallpapersAsync()
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLVector<TLWallPaperBase>>>();
                GetWallpapersAsync((callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLVector<TLWallPaperBase>>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLVector<TLWallPaperBase>>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLContactsResolvedPeer>> ResolveUsernameAsync(string username)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLContactsResolvedPeer>>();
                ResolveUsernameAsync(username, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLContactsResolvedPeer>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLContactsResolvedPeer>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLAccountDaysTTL>> GetAccountTTLAsync()
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLAccountDaysTTL>>();
                GetAccountTTLAsync((callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLAccountDaysTTL>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLAccountDaysTTL>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLPong>> PingDelayDisconnectAsync(long pingId, int disconnectDelay)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLPong>>();
                PingDelayDisconnectAsync(pingId, disconnectDelay, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLPong>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLPong>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLMessagesChatsBase>> GetAdminedPublicChannelsAsync()
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLMessagesChatsBase>>();
                GetAdminedPublicChannelsAsync((callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessagesChatsBase>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessagesChatsBase>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLUploadFile>> GetFileAsync(TLInputFileLocationBase location, int offset, int limit)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLUploadFile>>();
                GetFileAsync(location, offset, limit, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUploadFile>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUploadFile>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLMessagesMessagesBase>> SearchAsync(TLInputPeerBase peer, string query, TLMessagesFilterBase filter, int minDate, int maxDate, int offset, int maxId, int limit)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLMessagesMessagesBase>>();
                SearchAsync(peer, query, filter, minDate, maxDate, offset, maxId, limit, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessagesMessagesBase>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLMessagesMessagesBase>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<bool>> DeleteAccountAsync(string reason)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<bool>>();
                DeleteAccountAsync(reason, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLUpdatesChannelDifferenceBase>> GetChannelDifferenceAsync(TLInputChannelBase inputChannel, TLChannelMessagesFilterBase filter, int pts, int limit)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLUpdatesChannelDifferenceBase>>();
                GetChannelDifferenceAsync(inputChannel, filter, pts, limit, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUpdatesChannelDifferenceBase>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUpdatesChannelDifferenceBase>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLUpdatesBase>> LeaveChannelAsync(TLChannel channel)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLUpdatesBase>>();
                LeaveChannelAsync(channel, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUpdatesBase>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUpdatesBase>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLUserBase>> ChangePhoneAsync(string phoneNumber, string phoneCodeHash, string phoneCode)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLUserBase>>();
                ChangePhoneAsync(phoneNumber, phoneCodeHash, phoneCode, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUserBase>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLUserBase>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLVector<TLContactStatus>>> GetStatusesAsync()
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLVector<TLContactStatus>>>();
                GetStatusesAsync((callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLVector<TLContactStatus>>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLVector<TLContactStatus>>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<bool>> DeleteAccountTTLAsync(string reason)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<bool>>();
                DeleteAccountTTLAsync(reason, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLPeerNotifySettingsBase>> GetNotifySettingsAsync(TLInputNotifyPeerBase peer)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLPeerNotifySettingsBase>>();
                GetNotifySettingsAsync(peer, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLPeerNotifySettingsBase>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLPeerNotifySettingsBase>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<bool>> SaveFilePartAsync(long fileId, int filePart, byte[] bytes)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<bool>>();
                SaveFilePartAsync(fileId, filePart, bytes, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<bool>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLAuthAuthorization>> SignInAsync(string phoneNumber, string phoneCodeHash, string phoneCode)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLAuthAuthorization>>();
                SignInAsync(phoneNumber, phoneCodeHash, phoneCode, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLAuthAuthorization>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLAuthAuthorization>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLAuthAuthorization>> RecoverPasswordAsync(string code)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLAuthAuthorization>>();
                RecoverPasswordAsync(code, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLAuthAuthorization>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLAuthAuthorization>(faultCallback));
                });
                return tsc.Task;
            });
        }

        [DebuggerStepThrough]
        public IAsyncOperation<MTProtoResponse<TLAuthSentCode>> ResendCodeAsync(string phoneNumber, string phoneCodeHash)
        {
            return AsyncInfo.Run(_ =>
            {
                var tsc = new TaskCompletionSource<MTProtoResponse<TLAuthSentCode>>();
                ResendCodeAsync(phoneNumber, phoneCodeHash, (callback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLAuthSentCode>(callback));
                }, (faultCallback) =>
                {
                    tsc.TrySetResult(new MTProtoResponse<TLAuthSentCode>(faultCallback));
                });
                return tsc.Task;
            });
        }
    }
}
