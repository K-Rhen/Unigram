using System.Collections.Generic;
using Telegram.Api.TL;

namespace Telegram.Api.Services.Cache.EventArgs
{
    public sealed class MessagesRemovedEventArgs
    {
        public TLDialog Dialog { get; private set; }

        public IList<TLMessageBase> Messages { get; private set; }

        // TODO: Encrypted public TLDecryptedMessageBase DecryptedMessage { get; protected set; }

        public MessagesRemovedEventArgs(TLDialog dialog, TLMessageBase message)
        {
            Dialog = dialog;
            Messages = new List<TLMessageBase> {message};
        }

        public MessagesRemovedEventArgs(TLDialog dialog, IList<TLMessageBase> messages)
        {
            Dialog = dialog;
            Messages = messages;
        }

        // TODO: Encrypted 
        //public MessagesRemovedEventArgs(TLDialog dialog, TLDecryptedMessageBase message)
        //{
        //    Dialog = dialog;
        //    DecryptedMessage = message;
        //}
    }

    public sealed class DialogAddedEventArgs
    {
        public TLDialog Dialog { get; protected set; }

        public DialogAddedEventArgs(TLDialog dialog)
        {
            Dialog = dialog;
        }
    }

    public sealed class DialogRemovedEventArgs
    {
        public TLDialog Dialog { get; protected set; }

        public DialogRemovedEventArgs(TLDialog dialog)
        {
            Dialog = dialog;
        }
    }
}