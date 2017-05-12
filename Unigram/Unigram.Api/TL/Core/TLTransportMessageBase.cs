using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation.Metadata;

namespace Telegram.Api.TL
{
    internal abstract class ITLTransportMessageBase : ITLObject, TLTransportMessageBase
    {
        public Int64 MsgId { get; set; }
    }

    [Guid(0x1f4b3fa3, 0xeb15, 0x26d2, 0xbc, 0x34, 0x11, 0xa8, 0x11, 0x37, 0xc3, 0xb6)]
    public partial interface TLTransportMessageBase : TLObject
    {
        Int64 MsgId { get; set; }
    }
}
