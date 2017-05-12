using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Api.TL.Methods.Messages;

namespace Telegram.Api.TL
{
#if !PORTABLE
    public partial interface TLDraftMessageBase
    {
        TLMessagesSaveDraft ToSaveDraftObject(TLInputPeerBase peer);
    }
#endif

#if !PORTABLE
    internal
#else
    public
#endif
    abstract partial class ITLDraftMessageBase
    {
        public abstract TLMessagesSaveDraft ToSaveDraftObject(TLInputPeerBase peer);
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLDraftMessageEmpty
    {
        public override TLMessagesSaveDraft ToSaveDraftObject(TLInputPeerBase peer)
        {
            return new ITLMessagesSaveDraft
            {
                Peer = peer,
                Message = string.Empty
            };
        }
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLDraftMessage
    {
        public override TLMessagesSaveDraft ToSaveDraftObject(TLInputPeerBase peer)
        {
            var obj = new ITLMessagesSaveDraft
            {
                ReplyToMsgId = ReplyToMsgId,
                Peer = peer,
                Message = Message,
                Entities = Entities,
            };

            if (IsNoWebPage)
            {
                obj.IsNoWebPage = true;
            }

            return obj;
        }
    }
}
