using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Api.Helpers;

namespace Telegram.Api.TL
{
#if !PORTABLE
    public partial interface TLChatBase : ITLDialogWith
    {
        void Update(TLChatBase chat);
    }
#endif

#if !PORTABLE
    internal
#else
    public
#endif
    abstract partial class ITLChatBase : ITLDialogWith
    {
        //#region Full chat information

        //public TLChatParticipantsBase Participants { get; set; }

        //public TLPhotoBase ChatPhoto { get; set; }

        //public TLPeerNotifySettingsBase NotifySettings { get; set; }

        //public int UsersOnline { get; set; }

        //public TLExportedChatInviteBase ExportedInvite { get; set; }

        //public TLVector<TLBotInfo> BotInfo { get; set; }

        //#endregion

        public virtual void Update(TLChatBase chat)
        {
            Id = chat.Id;

            //if (chat.Participants != null)
            //{
            //    Participants = chat.Participants;
            //}

            //if (chat.ChatPhoto != null)
            //{
            //    ChatPhoto = chat.ChatPhoto;
            //}

            //if (chat.NotifySettings != null)
            //{
            //    NotifySettings = chat.NotifySettings;
            //}
        }

#region Add
        public virtual string DisplayName
        {
            get
            {
                return null;
            }
        }

        public virtual object PhotoSelf
        {
            get
            {
                return this;
            }
        }
#endregion

        public event PropertyChangedEventHandler PropertyChanged;
        public override void RaisePropertyChanged(string propertyName)
        {
            Execute.OnUIThread(() => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName)));
        }

        public virtual TLInputPeerBase ToInputPeer()
        {
            throw new NotImplementedException();
        }

        public virtual TLPeerBase ToPeer()
        {
            throw new NotImplementedException();
        }
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLChat
    {
        public override string DisplayName
        {
            get
            {
                return Title;
            }
        }

        public override TLInputPeerBase ToInputPeer()
        {
            return new ITLInputPeerChat { ChatId = Id };
        }

        public override TLPeerBase ToPeer()
        {
            return new ITLPeerChat { ChatId = Id };
        }
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLChatForbidden
    {
        public override string DisplayName
        {
            get
            {
                return Title;
            }
        }

        public override TLInputPeerBase ToInputPeer()
        {
            return new ITLInputPeerChat { ChatId = Id };
        }

        public override TLPeerBase ToPeer()
        {
            return new ITLPeerChat { ChatId = Id };
        }
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLChannel
    {
        public override string DisplayName
        {
            get
            {
                return Title;
            }
        }

        public override TLInputPeerBase ToInputPeer()
        {
            return new ITLInputPeerChannel { ChannelId = Id, AccessHash = AccessHash.Value };
        }

        public override TLPeerBase ToPeer()
        {
            return new ITLPeerChannel { ChannelId = Id };
        }
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLChannelForbidden
    {
        public override string DisplayName
        {
            get
            {
                return Title;
            }
        }

        public override TLInputPeerBase ToInputPeer()
        {
            return new ITLInputPeerChannel { ChannelId = Id, AccessHash = AccessHash };
        }

        public override TLPeerBase ToPeer()
        {
            return new ITLPeerChannel { ChannelId = Id };
        }
    }
}
