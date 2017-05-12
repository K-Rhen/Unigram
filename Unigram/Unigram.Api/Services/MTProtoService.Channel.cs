using System;
using Telegram.Api.Extensions;
using Telegram.Api.Helpers;
using Telegram.Api.TL;
using Telegram.Api.TL.Methods.Channels;
using Telegram.Api.TL.Methods.Messages;
using Telegram.Api.TL.Methods.Updates;

namespace Telegram.Api.Services
{
    public partial class MTProtoService
    {
        // TODO: Layer 56 
        //public void GetAdminedPublicChannelsCallback(Action<TLMessagesChats> callback, Action<TLRPCError> faultCallback = null)
        //{
        //    var obj = new ITLGetAdminedPublicChannels();

        //    SendInformativeMessage<TLMessagesChats>("updates.getAdminedPublicChannels", obj,
        //        result =>
        //        {
        //            var chats = result as TLChats24;
        //            if (chats != null)
        //            {
        //                _cacheService.SyncUsersAndChats(new ITLVector<TLUserBase>(), chats.Chats, tuple => callback?.Invoke(result));
        //            }
        //        },
        //        faultCallback);
        //}

        public void GetChannelDifferenceAsync(TLInputChannelBase inputChannel, TLChannelMessagesFilterBase filter, int pts, int limit, Action<TLUpdatesChannelDifferenceBase> callback, Action<TLRPCError> faultCallback = null)
        {
            var obj = new ITLUpdatesGetChannelDifference { Channel = inputChannel, Filter = filter, Pts = pts, Limit = limit };

            SendInformativeMessage("updates.getChannelDifference", obj, callback, faultCallback);
        }

        public void GetMessagesAsync(TLInputChannelBase inputChannel, TLVector<int> id, Action<TLMessagesMessagesBase> callback, Action<TLRPCError> faultCallback = null)
        {
            var obj = new ITLChannelsGetMessages { Channel = inputChannel, Id = id };

            SendInformativeMessage("channels.getMessages", obj, callback, faultCallback);
        }

        public void GetAdminedPublicChannelsAsync(Action<TLMessagesChatsBase> callback, Action<TLRPCError> faultCallback = null)
        {
            var obj = new ITLChannelsGetAdminedPublicChannels();

            const string caption = "channels.getAdminedPublicChannels";
            SendInformativeMessage<TLMessagesChatsBase>(caption, obj, 
                result =>
            {
                var chats = result as TLMessagesChats;
                if (chats != null)
                {
                    _cacheService.SyncUsersAndChats(new ITLVector<TLUserBase>(), chats.Chats, tuple => callback?.Invoke(result));
                }
            }, 
            faultCallback);
        }

        public void EditAdminAsync(TLChannel channel, TLInputUserBase userId, TLChannelParticipantRoleBase role, Action<TLUpdatesBase> callback, Action<TLRPCError> faultCallback = null)
        {
            var obj = new ITLChannelsEditAdmin { Channel = channel.ToInputChannel(), UserId = userId, Role = role };

            const string caption = "channels.editAdmin";
            SendInformativeMessage<TLUpdatesBase>(caption, obj,
                result =>
                {
                    var multiPts = result as ITLMultiPts;
                    if (multiPts != null)
                    {
                        _updatesService.SetState(multiPts, caption);
                    }
                    else
                    {
                        ProcessUpdates(result, null);
                    }

                    GetFullChannelAsync(channel.ToInputChannel(),
                        messagesChatFull => callback?.Invoke(result),
                        faultCallback);
                },
                faultCallback);
        }


        public void GetParticipantAsync(TLInputChannelBase inputChannel, TLInputUserBase userId, Action<TLChannelsChannelParticipant> callback, Action<TLRPCError> faultCallback = null)
        {
            var obj = new ITLChannelsGetParticipant { Channel = inputChannel, UserId = userId };

            const string caption = "channels.getParticipant";
            SendInformativeMessage<TLChannelsChannelParticipant>(caption, obj, result =>
            {
                _cacheService.SyncUsers(result.Users, r => { });

                callback?.Invoke(result);
            }, 
            faultCallback);
        }

        public void GetParticipantsAsync(TLInputChannelBase inputChannel, TLChannelParticipantsFilterBase filter, int offset, int limit, Action<TLChannelsChannelParticipants> callback, Action<TLRPCError> faultCallback = null)
        {
            var obj = new ITLChannelsGetParticipants { Channel = inputChannel, Filter = filter, Offset = offset, Limit = limit };

            const string caption = "channels.getParticipants";
            SendInformativeMessage<TLChannelsChannelParticipants>(caption, obj,
                result =>
                {
                    //for (var i = 0; i < result.Users.Count; i++)
                    //{
                    //    var cachedUser = _cacheService.GetUser(result.Users[i].Id) as TLUser;
                    //    if (cachedUser != null)
                    //    {
                    //        // TODO: cachedUser._status = ((TLUser)result.Users[i]).Status;
                    //        cachedUser.Status = ((TLUser)result.Users[i]).Status;
                    //        result.Users[i] = cachedUser;
                    //    }
                    //}

                    _cacheService.SyncUsers(result.Users, r => { });

                    callback?.Invoke(result);
                },
                faultCallback);
        }

        public void EditTitleAsync(TLChannel channel, string title, Action<TLUpdatesBase> callback, Action<TLRPCError> faultCallback = null)
        {
            var obj = new ITLChannelsEditTitle { Channel = channel.ToInputChannel(), Title = title };

            const string caption = "channels.editTitle";
            SendInformativeMessage<TLUpdatesBase>(caption, obj,
                result =>
                {
                    var multiPts = result as ITLMultiPts;
                    if (multiPts != null)
                    {
                        _updatesService.SetState(multiPts, caption);
                    }
                    else
                    {
                        ProcessUpdates(result, null);
                    }

                    callback?.Invoke(result);
                },
                faultCallback);
        }

        public void EditAboutAsync(TLChannel channel, string about, Action<bool> callback, Action<TLRPCError> faultCallback = null)
        {
            var obj = new ITLChannelsEditAbout { Channel = channel.ToInputChannel(), About = about };

            const string caption = "channels.editAbout";
            SendInformativeMessage<bool>(caption, obj, callback, faultCallback);
        }

        public void JoinChannelAsync(TLChannel channel, Action<TLUpdatesBase> callback, Action<TLRPCError> faultCallback = null)
        {
            var obj = new ITLChannelsJoinChannel { Channel = channel.ToInputChannel() };

            const string caption = "channels.joinChannel";
            SendInformativeMessage<TLUpdatesBase>(caption, obj,
                result =>
                {
                    channel.IsLeft = false;
                    if (channel.ParticipantsCount != null)
                    {
                        channel.ParticipantsCount = channel.ParticipantsCount + 1;
                    }
                    _cacheService.Commit();

                    var multiPts = result as ITLMultiPts;
                    if (multiPts != null)
                    {
                        _updatesService.SetState(multiPts, caption);
                    }
                    else
                    {
                        ProcessUpdates(result, null);
                    }

                    callback?.Invoke(result);
                },
                faultCallback);
        }

        public void LeaveChannelAsync(TLChannel channel, Action<TLUpdatesBase> callback, Action<TLRPCError> faultCallback = null)
        {
            var obj = new ITLChannelsLeaveChannel { Channel = channel.ToInputChannel() };

            const string caption = "channels.leaveChannel";
            SendInformativeMessage<TLUpdatesBase>(caption, obj,
                result =>
                {
                    channel.IsLeft = true;
                    if (channel.ParticipantsCount != null)
                    {
                        channel.ParticipantsCount = new int?(channel.ParticipantsCount.Value - 1);
                    }
                    _cacheService.Commit();

                    var multiPts = result as ITLMultiPts;
                    if (multiPts != null)
                    {
                        _updatesService.SetState(multiPts, caption);
                    }
                    else
                    {
                        ProcessUpdates(result, null);
                    }

                    callback?.Invoke(result);
                },
                faultCallback);
        }

        public void KickFromChannelAsync(TLChannel channel, TLInputUserBase userId, bool kicked, Action<TLUpdatesBase> callback, Action<TLRPCError> faultCallback = null)
        {
            var obj = new ITLChannelsKickFromChannel { Channel = channel.ToInputChannel(), UserId = userId, Kicked = kicked };

            const string caption = "channels.kickFromChannel";
            SendInformativeMessage<TLUpdatesBase>(caption, obj,
                result =>
                {
                    var multiPts = result as ITLMultiPts;
                    if (multiPts != null)
                    {
                        _updatesService.SetState(multiPts, caption);
                    }
                    else
                    {
                        ProcessUpdates(result, null);
                    }

                    GetFullChannelAsync(channel.ToInputChannel(),
                        messagesChatFull => callback?.Invoke(result),
                        faultCallback);
                },
                faultCallback);
        }

        public void DeleteChannelAsync(TLChannel channel, Action<TLUpdatesBase> callback, Action<TLRPCError> faultCallback = null)
        {
            var obj = new ITLChannelsDeleteChannel { Channel = channel.ToInputChannel() };

            const string caption = "channels.deleteChannel";
            SendInformativeMessage<TLUpdatesBase>(caption, obj,
                result =>
                {
                    var multiPts = result as ITLMultiPts;
                    if (multiPts != null)
                    {
                        _updatesService.SetState(multiPts, caption);
                    }
                    else
                    {
                        ProcessUpdates(result, null);
                    }

                    callback?.Invoke(result);
                },
                faultCallback);
        }

        public void InviteToChannelAsync(TLInputChannelBase channel, TLVector<TLInputUserBase> users, Action<TLUpdatesBase> callback, Action<TLRPCError> faultCallback = null)
        {
            var obj = new ITLChannelsInviteToChannel { Channel = channel, Users = users };

            const string caption = "channels.inviteToChannel";
            SendInformativeMessage<TLUpdatesBase>(caption, obj,
                result =>
                {


                    var multiPts = result as ITLMultiPts;
                    if (multiPts != null)
                    {
                        _updatesService.SetState(multiPts, caption);
                    }
                    else
                    {
                        ProcessUpdates(result, null);
                    }

                    callback?.Invoke(result);
                },
                faultCallback);
        }

        public void DeleteMessagesAsync(TLInputChannelBase channel, TLVector<int> id, Action<TLMessagesAffectedMessages> callback, Action<TLRPCError> faultCallback = null)
        {
            var obj = new ITLChannelsDeleteMessages { Channel = channel, Id = id };

            const string caption = "channels.deleteMessages";
            SendInformativeMessage<TLMessagesAffectedMessages>(caption, obj,
                result =>
                {
                    //var multiPts = result as ITLMultiPts;
                    //if (multiPts != null)
                    //{
                    //    _updatesService.SetState(multiPts, caption);
                    //}
                    //else
                    //{
                    //    _updatesService.SetState(null, result.Pts, null, null, null, caption);
                    //}

                    callback?.Invoke(result);
                },
                faultCallback);
        }

        public void UpdateChannelAsync(int? channelId, Action<TLMessagesChatFull> callback, Action<TLRPCError> faultCallback = null)
        {
            var channel = _cacheService.GetChat(channelId) as TLChannel;
            if (channel != null)
            {
                GetFullChannelAsync(channel.ToInputChannel(), callback, faultCallback);
                return;
            }

            var channelForbidden = _cacheService.GetChat(channelId) as TLChannelForbidden;
            if (channelForbidden != null)
            {
                GetFullChannelAsync(channelForbidden.ToInputChannel(), callback, faultCallback);
                return;
            }
        }

        public void GetFullChannelAsync(TLInputChannelBase channel, Action<TLMessagesChatFull> callback, Action<TLRPCError> faultCallback = null)
        {
            var obj = new ITLChannelsGetFullChannel { Channel = channel };

            SendInformativeMessage<TLMessagesChatFull>(
                "cnannels.getFullChannel", obj,
                messagesChatFull =>
                {
                    _cacheService.SyncChat(messagesChatFull, result => callback?.Invoke(messagesChatFull));
                },
                faultCallback);
        }

        // TODO: Layer 56 
        //public void GetImportantHistoryCallback(TLInputChannelBase channel, TLPeerBase peer, bool sync, int? offsetId, int? addOffset, int? limit, int? maxId, int? minId, Action<TLMessagesMessagesBase> callback, Action<TLRPCError> faultCallback = null)
        //{
        //    var obj = new ITLGetImportantHistory { Channel = channel, OffsetId = offsetId, OffsetDate = 0, AddOffset = addOffset, Limit = limit, MaxId = maxId, MinId = minId };

        //    SendInformativeMessage("channels.getImportantHistory", obj, callback, faultCallback);
        //}

        public void ReadHistoryAsync(TLChannel channel, int maxId, Action<bool> callback, Action<TLRPCError> faultCallback = null)
        {
            var obj = new ITLChannelsReadHistory { Channel = channel.ToInputChannel(), MaxId = maxId };

            SendInformativeMessage<bool>("channels.readHistory", obj,
                result =>
                {
                    channel.ReadInboxMaxId = maxId;

                    _cacheService.Commit();

                    callback?.Invoke(result);
                },
                faultCallback);
        }

        public void CreateChannelAsync(TLChannelsCreateChannelFlag flags, string title, string about, Action<TLUpdatesBase> callback, Action<TLRPCError> faultCallback = null)
        {
            var obj = new ITLChannelsCreateChannel { Flags = flags, Title = title, About = about };

            var caption = "channels.createChannel";
            SendInformativeMessage<TLUpdatesBase>(caption, obj,
                result =>
                {
                    var multiPts = result as ITLMultiPts;
                    if (multiPts != null)
                    {
                        _updatesService.SetState(multiPts, caption);
                    }
                    else
                    {
                        ProcessUpdates(result, null);
                    }

                    callback?.Invoke(result);
                }, 
                faultCallback);
        }

        public void ExportInviteAsync(TLInputChannelBase channel, Action<TLExportedChatInviteBase> callback, Action<TLRPCError> faultCallback = null)
        {
            var obj = new ITLChannelsExportInvite { Channel = channel };

            SendInformativeMessage("channels.exportInvite", obj, callback, faultCallback);
        }

        public void CheckUsernameAsync(TLInputChannelBase channel, string username, Action<bool> callback, Action<TLRPCError> faultCallback = null)
        {
            var obj = new ITLChannelsCheckUsername { Channel = channel, Username = username };

            SendInformativeMessage("channels.checkUsername", obj, callback, faultCallback);
        }

        public void UpdateUsernameAsync(TLInputChannelBase channel, string username, Action<bool> callback, Action<TLRPCError> faultCallback = null)
        {
            var obj = new ITLChannelsUpdateUsername { Channel = channel, Username = username };

            SendInformativeMessage("channels.updateUsername", obj, callback, faultCallback);
        }

        public void EditPhotoAsync(TLChannel channel, TLInputChatPhotoBase photo, Action<TLUpdatesBase> callback, Action<TLRPCError> faultCallback = null)
        {
            var obj = new ITLChannelsEditPhoto { Channel = channel.ToInputChannel(), Photo = photo };

            const string caption = "channels.editPhoto";
            SendInformativeMessage<TLUpdatesBase>(caption, obj,
                result =>
                {
                    var multiPts = result as ITLMultiPts;
                    if (multiPts != null)
                    {
                        _updatesService.SetState(multiPts, caption);
                    }
                    else
                    {
                        ProcessUpdates(result, null, true);
                    }

                    callback?.Invoke(result);
                },
                faultCallback);
        }

        public void DeleteChannelMessagesAsync(TLInputChannelBase channel, TLVector<int> id, Action<TLMessagesAffectedMessages> callback, Action<TLRPCError> faultCallback = null)
        {
            var obj = new ITLChannelsDeleteMessages { Channel = channel, Id = id };

            SendInformativeMessage("channels.deleteMessages", obj, callback, faultCallback);
        }

        public void EditChatAdminAsync(TLInputChannelBase channel, TLInputUserBase userId, TLChannelParticipantRoleBase role, Action<bool> callback, Action<TLRPCError> faultCallback = null)
        {
            var obj = new ITLChannelsEditAdmin { Channel = channel, UserId = userId, Role = role };

            SendInformativeMessage("channels.editAdmin", obj, callback, faultCallback);
        }

        public void ToggleInvitesAsync(TLInputChannelBase channel, bool enabled, Action<TLUpdatesBase> callback, Action<TLRPCError> faultCallback = null)
        {
            var obj = new ITLChannelsToggleInvites { Channel = channel, Enabled = enabled };

            const string caption = "channels.toggleInvites";
            SendInformativeMessage<TLUpdatesBase>(caption, obj,
                result =>
                {
                    var multiPts = result as ITLMultiPts;
                    if (multiPts != null)
                    {
                        _updatesService.SetState(multiPts, caption);
                    }
                    else
                    {
                        ProcessUpdates(result, null);
                    }

                    callback?.Invoke(result);
                },
                faultCallback);
        }

        public void ExportMessageLinkAsync(TLInputChannelBase channel, int id, Action<TLExportedMessageLink> callback, Action<TLRPCError> faultCallback = null)
        {
            var obj = new ITLChannelsExportMessageLink { Channel = channel, Id = id };

            SendInformativeMessage("channels.exportMessageLink", obj, callback, faultCallback);
        }

        public void UpdatePinnedMessageAsync(bool silent, TLInputChannelBase channel, int id, Action<TLUpdatesBase> callback, Action<TLRPCError> faultCallback = null)
        {
            var obj = new ITLChannelsUpdatePinnedMessage { Flags = 0, Channel = channel, Id = id };
            if (silent)
            {
                obj.IsSilent = true;
            }

            const string caption = "channels.updatePinnedMessage";
            SendInformativeMessage<TLUpdatesBase>(caption, obj,
                result =>
                {
                    var multiPts = result as ITLMultiPts;
                    if (multiPts != null)
                    {
                        _updatesService.SetState(multiPts, caption);
                    }
                    else
                    {
                        ProcessUpdates(result, null);
                    }

                    callback?.Invoke(result);
                },
                faultCallback);
        }

        public void ToggleSignaturesAsync(TLInputChannelBase channel, bool enabled, Action<TLUpdatesBase> callback, Action<TLRPCError> faultCallback = null)
        {
            var obj = new ITLChannelsToggleSignatures { Channel = channel, Enabled = enabled };

            const string caption = "channels.toggleSignatures";
            SendInformativeMessage<TLUpdatesBase>(caption, obj,
                result =>
                {
                    var multiPts = result as ITLMultiPts;
                    if (multiPts != null)
                    {
                        _updatesService.SetState(multiPts, caption);
                    }
                    else
                    {
                        ProcessUpdates(result, null);
                    }

                    callback?.Invoke(result);
                },
                faultCallback);
        }

        public void GetMessageEditDataAsync(TLInputPeerBase peer, int id, Action<TLMessagesMessageEditData> callback, Action<TLRPCError> faultCallback = null)
        {
            var obj = new ITLMessagesGetMessageEditData { Peer = peer, Id = id };

            SendInformativeMessage("messages.getMessageEditData", obj, callback, faultCallback);
        }


        public void EditMessageAsync(TLInputPeerBase peer, int id, string message, TLVector<TLMessageEntityBase> entities, TLReplyMarkupBase replyMarkup, bool noWebPage, Action<TLUpdatesBase> callback, Action<TLRPCError> faultCallback = null)
        {
            var obj = new ITLMessagesEditMessage { Flags=0, Peer = peer, Id = id, Message = message, IsNoWebPage = noWebPage, Entities = entities, ReplyMarkup = replyMarkup };

            const string caption = "messages.editMessage";
            SendInformativeMessage<TLUpdatesBase>(caption, obj,
                result =>
                {
                    var multiPts = result as ITLMultiPts;
                    if (multiPts != null)
                    {
                        _updatesService.SetState(multiPts, caption);
                    }
                    else
                    {
                        ProcessUpdates(result, null, true);
                    }

                    callback?.Invoke(result);
                },
                faultCallback);
        }

        public void ReportSpamAsync(TLInputChannelBase channel, TLInputUserBase userId, TLVector<int> id, Action<bool> callback, Action<TLRPCError> faultCallback = null)
        {
            var obj = new ITLChannelsReportSpam { Channel = channel, UserId = userId, Id = id };

            const string caption = "channels.reportSpam";
            SendInformativeMessage<bool>(caption, obj, callback, faultCallback);
        }

        public void DeleteUserHistoryAsync(TLChannel channel, TLInputUserBase userId, Action<TLMessagesAffectedHistory> callback, Action<TLRPCError> faultCallback = null)
        {
            var obj = new ITLChannelsDeleteUserHistory { Channel = channel.ToInputChannel(), UserId = userId };

            const string caption = "channels.deleteUserHistory";
            SendInformativeMessage<TLMessagesAffectedHistory>(caption, obj,
                result =>
                {
                    var multiChannelPts = result as ITLMultiChannelPts;
                    if (multiChannelPts != null)
                    {
                        if (channel.Pts == null || channel.Pts.Value + multiChannelPts.PtsCount != multiChannelPts.Pts)
                        {
                            Execute.ShowDebugMessage(string.Format("channel_id={0} channel_pts={1} affectedHistory24[channel_pts={2} channel_pts_count={3}]", channel.Id, channel.Pts, multiChannelPts.Pts, multiChannelPts.PtsCount));
                        }
                        channel.Pts = multiChannelPts.Pts;
                    }

                    callback?.Invoke(result);
                },
                faultCallback);
        }
    }
}
