using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telegram.Api.TL
{
#if !PORTABLE
    public partial interface TLPeerBase
    {
        Int32 Id { get; }
    }
#endif

#if !PORTABLE
    internal
#else
    public
#endif
    abstract partial class ITLPeerBase
    {
        public Int32 Id
        {
            get
            {
                if (this is TLPeerUser)
                    return ((TLPeerUser)this).UserId;
                else if (this is TLPeerChat)
                    return ((TLPeerChat)this).ChatId;
                else
                    return ((TLPeerChannel)this).ChannelId;
            }
            set
            {
                if (this is TLPeerUser)
                    ((TLPeerUser)this).UserId = value;
                else if (this is TLPeerChat)
                    ((TLPeerChat)this).ChatId = value;
                else
                    ((TLPeerChannel)this).ChannelId = value;
            }
        }

        public override bool Equals(object obj)
        {
            var peer = obj as ITLPeerBase;
            if ((this is ITLPeerUser && obj is ITLPeerUser) ||
                (this is ITLPeerChat && obj is ITLPeerChat) ||
                (this is ITLPeerChannel && obj is ITLPeerChannel))
            {
                return Id.Equals(peer.Id);
            }

            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        //#region User equality

        //public static bool operator ==(TLPeerBase peer, TLUserBase user)
        //{
        //    if (((object)peer == null) || ((object)peer == null))
        //    {
        //        return false;
        //    }

        //    if (peer is TLPeerUser userPeer && userPeer.UserId == user.Id)
        //    {
        //        return true;
        //    }

        //    return false;
        //}

        //public static bool operator !=(TLPeerBase peer, TLUserBase user)
        //{
        //    return !(peer == user);
        //}

        //#endregion

        //#region Chat equality

        //public static bool operator ==(TLPeerBase peer, TLChat chat)
        //{
        //    if (((object)peer == null) || ((object)peer == null))
        //    {
        //        return false;
        //    }

        //    if (peer is TLPeerChat chatPeer && chatPeer.ChatId == chat.Id)
        //    {
        //        return true;
        //    }

        //    return false;
        //}

        //public static bool operator !=(TLPeerBase peer, TLChat chat)
        //{
        //    return !(peer == chat);
        //}

        //#endregion

        //#region Channel equality

        //public static bool operator ==(TLPeerBase peer, TLChannel channel)
        //{
        //    if (((object)peer == null) || ((object)peer == null))
        //    {
        //        return false;
        //    }

        //    if (peer is TLPeerChannel channelPeer && channelPeer.ChannelId == channel.Id)
        //    {
        //        return true;
        //    }

        //    return false;
        //}

        //public static bool operator !=(TLPeerBase peer, TLChannel channel)
        //{
        //    return !(peer == channel);
        //}

        //#endregion
    }
}