using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telegram.Api.TL
{
#if !PORTABLE
    public partial interface TLUpdatesDifferenceBase
    {
        TLUpdatesDifferenceBase GetEmptyObject();
    }
#endif

#if !PORTABLE
    internal
#else
    public
#endif
    abstract partial class ITLUpdatesDifferenceBase
    {
        public abstract TLUpdatesDifferenceBase GetEmptyObject();
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLUpdatesDifferenceEmpty
    {
        public override TLUpdatesDifferenceBase GetEmptyObject()
        {
            return new ITLUpdatesDifferenceEmpty
            {
                Date = Date,
                Seq = Seq
            };
        }
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLUpdatesDifferenceTooLong
    {
        public override TLUpdatesDifferenceBase GetEmptyObject()
        {
            return new ITLUpdatesDifferenceTooLong
            {
                Pts = Pts
            };
        }
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLUpdatesDifference
    {
        public override TLUpdatesDifferenceBase GetEmptyObject()
        {
            return new ITLUpdatesDifference
            {
                NewMessages = new ITLVector<TLMessageBase>(NewMessages.Count),
                NewEncryptedMessages = new ITLVector<TLEncryptedMessageBase>(NewEncryptedMessages.Count),
                OtherUpdates = new ITLVector<TLUpdateBase>(OtherUpdates.Count),
                Users = new ITLVector<TLUserBase>(Users.Count),
                Chats = new ITLVector<TLChatBase>(Chats.Count),
                State = State
            };
        }
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLUpdatesDifferenceSlice
    {
        public override TLUpdatesDifferenceBase GetEmptyObject()
        {
            return new ITLUpdatesDifferenceSlice
            {
                NewMessages = new ITLVector<TLMessageBase>(NewMessages.Count),
                NewEncryptedMessages = new ITLVector<TLEncryptedMessageBase>(NewEncryptedMessages.Count),
                OtherUpdates = new ITLVector<TLUpdateBase>(OtherUpdates.Count),
                Users = new ITLVector<TLUserBase>(Users.Count),
                Chats = new ITLVector<TLChatBase>(Chats.Count),
                IntermediateState = IntermediateState
            };
        }
    }
}
