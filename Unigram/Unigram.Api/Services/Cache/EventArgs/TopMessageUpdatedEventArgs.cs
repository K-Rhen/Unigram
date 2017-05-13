using Telegram.Api.TL;

namespace Telegram.Api.Services.Cache.EventArgs
{
    public sealed class TopMessageUpdatedEventArgs : System.EventArgs
    {
        public TLPeerBase Peer { get; private set; }

        public TLDialog Dialog { get; set; }

        public TLMessageBase Message { get; private set; }

        // TODO: Encrypted public TLDecryptedMessageBase DecryptedMessage { get; protected set; }

        public TopMessageUpdatedEventArgs(TLPeerBase peer)
        {
            Peer = peer;
        }

        public TopMessageUpdatedEventArgs(TLDialog dialog, TLMessageBase message)
        {
            Dialog = dialog;
            Message = message;
        }

        // TODO: Encrypted 
        //public TopMessageUpdatedEventArgs(TLDialog dialog, TLDecryptedMessageBase message)
        //{
        //    Dialog = dialog;
        //    DecryptedMessage = message;
        //}
    }
}