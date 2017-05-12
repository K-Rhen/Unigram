using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telegram.Api.TL
{
#if !PORTABLE
    public partial interface TLUpdateBase
    {
        IList<int> GetPts();
    }
#endif

#if !PORTABLE
    internal
#else
    public
#endif
    abstract partial class ITLUpdateBase
    {
        public virtual IList<int> GetPts()
        {
            return new List<int>();
        }
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLUpdateNewMessage
    {
        public override IList<int> GetPts()
        {
            return TLUtils.GetPtsRange(Pts, PtsCount);
        }
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLUpdateChatParticipantAdd
    {
        public override IList<int> GetPts()
        {
            return new List<int>();
        }
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLUpdateChatParticipantDelete
    {
        public override IList<int> GetPts()
        {
            return new List<int>();
        }
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLUpdateNewEncryptedMessage
    {
        public override IList<int> GetPts()
        {
            return new List<int>();
        }
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLUpdateEncryption
    {
        public override IList<int> GetPts()
        {
            return new List<int>();
        }
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLUpdateMessageID
    {
        public override IList<int> GetPts()
        {
            return new List<int>();
        }
    }

    //internal partial class ITLUpdateReadMessages
    //{
    //    public override IList<int> GetPts()
    //    {
    //        return TLUtils.GetPtsRange(Pts, PtsCount);
    //    }
    //}

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLUpdateReadMessagesContents
    {
        public override IList<int> GetPts()
        {
            return TLUtils.GetPtsRange(Pts, PtsCount);
        }
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLUpdateReadHistoryInbox
    {
        public override IList<int> GetPts()
        {
            return TLUtils.GetPtsRange(Pts, PtsCount);
        }
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLUpdateReadHistoryOutbox
    {
        public override IList<int> GetPts()
        {
            return TLUtils.GetPtsRange(Pts, PtsCount);
        }
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLUpdateEncryptedMessagesRead
    {
        public override IList<int> GetPts()
        {
            return new List<int>();
        }
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLUpdateDeleteMessages
    {
        public override IList<int> GetPts()
        {
            return TLUtils.GetPtsRange(Pts, PtsCount);
        }
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLUpdateUserTyping
    {
        public override IList<int> GetPts()
        {
            return new List<int>();
        }
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLUpdateChatUserTyping
    {
        public override IList<int> GetPts()
        {
            return new List<int>();
        }
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLUpdateEncryptedChatTyping
    {
        public override IList<int> GetPts()
        {
            return new List<int>();
        }
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLUpdateChatParticipants
    {
        public override IList<int> GetPts()
        {
            return new List<int>();
        }
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLUpdateUserStatus
    {
        public override IList<int> GetPts()
        {
            return new List<int>();
        }
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLUpdateUserName
    {
        public override IList<int> GetPts()
        {
            return new List<int>();
        }
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLUpdateUserPhoto
    {
        public override IList<int> GetPts()
        {
            return new List<int>();
        }
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLUpdateContactRegistered
    {
        public override IList<int> GetPts()
        {
            return new List<int>();
        }
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLUpdateContactLink
    {
        public override IList<int> GetPts()
        {
            return new List<int>();
        }
    }

    //internal partial class ITLUpdateActivation
    //{
    //    public override IList<int> GetPts()
    //    {
    //        return new List<int>();
    //    }
    //}

    //internal partial class ITLUpdateNewAuthorization
    //{
    //    public override IList<int> GetPts()
    //    {
    //        return new List<int>();
    //    }
    //}

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLUpdateDCOptions
    {
        public override IList<int> GetPts()
        {
            return new List<int>();
        }
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLUpdateNotifySettings
    {
        public override IList<int> GetPts()
        {
            return new List<int>();
        }
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLUpdateUserBlocked
    {
        public override IList<int> GetPts()
        {
            return new List<int>();
        }
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLUpdatePrivacy
    {
        public override IList<int> GetPts()
        {
            return new List<int>();
        }
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLUpdateUserPhone
    {
        public override IList<int> GetPts()
        {
            return new List<int>();
        }
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLUpdateServiceNotification
    {
        public override IList<int> GetPts()
        {
            return new List<int>();
        }
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLUpdateWebPage
    {
        public override IList<int> GetPts()
        {
            return TLUtils.GetPtsRange(Pts, PtsCount);
        }
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLUpdateChannelTooLong
    {
        public override IList<int> GetPts()
        {
            return new List<int>();
        }
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLUpdateNewChannelMessage : ITLMultiChannelPts
    {
        public override IList<int> GetPts()
        {
            return TLUtils.GetPtsRange(Pts, PtsCount);
        }
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLUpdateReadChannelInbox
    {
        public override IList<int> GetPts()
        {
            return new List<int>();
        }
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLUpdateDeleteChannelMessages : ITLMultiChannelPts
    {
        public override IList<int> GetPts()
        {
            return TLUtils.GetPtsRange(Pts, PtsCount);
        }
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLUpdateEditChannelMessage : ITLMultiChannelPts
    {
        public override IList<int> GetPts()
        {
            return new List<int>();
        }
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLUpdateChannelMessageViews
    {
        public override IList<int> GetPts()
        {
            return new List<int>();
        }
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLUpdateChannel
    {
        public override IList<int> GetPts()
        {
            return new List<int>();
        }
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLUpdateChatAdmins
    {
        public override IList<int> GetPts()
        {
            return new List<int>();
        }
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLUpdateChatParticipantAdmin
    {
        public override IList<int> GetPts()
        {
            return new List<int>();
        }
    }
}
