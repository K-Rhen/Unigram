using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telegram.Api.TL
{
#if !PORTABLE
    public partial interface TLMessagesMessagesBase
    {
        TLMessagesMessagesBase GetEmptyObject();
    }
#endif

#if !PORTABLE
    internal
#else
    public
#endif
    abstract partial class ITLMessagesMessagesBase
    {
        public abstract TLMessagesMessagesBase GetEmptyObject();
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLMessagesMessages
    {
        public override TLMessagesMessagesBase GetEmptyObject()
        {
            return new ITLMessagesMessages
            {
                Messages = new ITLVector<TLMessageBase>(Messages.Count),
                Chats = new ITLVector<TLChatBase>(Chats.Count),
                Users = new ITLVector<TLUserBase>(Users.Count)
            };
        }
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLMessagesMessagesSlice
    {
        public override TLMessagesMessagesBase GetEmptyObject()
        {
            return new ITLMessagesMessagesSlice
            {
                Count = Count,
                Messages = new ITLVector<TLMessageBase>(Messages.Count),
                Chats = new ITLVector<TLChatBase>(Chats.Count),
                Users = new ITLVector<TLUserBase>(Users.Count)
            };
        }
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLMessagesChannelMessages
    {
        public override TLMessagesMessagesBase GetEmptyObject()
        {
            // TODO: Verify
            return new ITLMessagesChannelMessages
            {
                Count = Count,
                Messages = new ITLVector<TLMessageBase>(Messages.Count),
                Chats = new ITLVector<TLChatBase>(Chats.Count),
                Users = new ITLVector<TLUserBase>(Users.Count)
            };
        }
    }
}
