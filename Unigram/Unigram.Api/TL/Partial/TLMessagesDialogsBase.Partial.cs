using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telegram.Api.TL
{
#if !PORTABLE
    public partial interface TLMessagesDialogsBase
    {
        TLMessagesDialogsBase GetEmptyObject();
    }
#endif

#if !PORTABLE
    internal
#else
    public
#endif
    abstract partial class ITLMessagesDialogsBase
    {
        public abstract TLMessagesDialogsBase GetEmptyObject();
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLMessagesDialogs
    {
        public override TLMessagesDialogsBase GetEmptyObject()
        {
            return new ITLMessagesDialogs
            {
                Dialogs = new ITLVector<TLDialog>(Dialogs.Count),
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
    partial class ITLMessagesDialogsSlice
    {
        public override TLMessagesDialogsBase GetEmptyObject()
        {
            return new ITLMessagesDialogsSlice
            {
                Count = Count,
                Dialogs = new ITLVector<TLDialog>(Dialogs.Count),
                Messages = new ITLVector<TLMessageBase>(Messages.Count),
                Chats = new ITLVector<TLChatBase>(Chats.Count),
                Users = new ITLVector<TLUserBase>(Users.Count)
            };
        }
    }
}
