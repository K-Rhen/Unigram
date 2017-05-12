using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telegram.Api.TL
{
#if !PORTABLE
    public partial interface TLMessagesStickerSet
    {
        TLDocumentBase Cover { get; }
    }
#endif

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLMessagesStickerSet
    {
        public TLDocumentBase Cover
        {
            get
            {
                if (Documents != null && Documents.Count > 0)
                {
                    return Documents[0];
                }

                return null;
            }
        }
    }
}
