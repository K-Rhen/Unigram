using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation.Metadata;

namespace Telegram.Api.TL
{
    internal class ITLTransportMessage : ITLContainerTransportMessage, TLTransportMessage
    {
        public Int64 Salt { get; set; }
        public Int64 SessionId { get; set; }

        public ITLTransportMessage() { }
        public ITLTransportMessage(TLBinaryReader from)
        {
            Read(from);
        }

        public override void Read(TLBinaryReader from)
        {
            Salt = from.ReadInt64();
            SessionId = from.ReadInt64();
            base.Read(from);
        }

        public override void Write(TLBinaryWriter to)
        {
            using (var output = new MemoryStream())
            {
                using (var writer = new TLBinaryWriter(output))
                {
                    writer.WriteObject(Query);
                    var buffer = output.ToArray();

                    to.Write(Salt);
                    to.Write(SessionId);
                    to.Write(MsgId);
                    to.Write(SeqNo);
                    to.Write(buffer.Length);
                    to.Write(buffer);
                }
            }
        }
    }

    [Guid(0xf6d14faa, 0x9a04, 0x33c7, 0x13, 0xce, 0x62, 0x0c, 0xfb, 0xa7, 0x45, 0x1d)]
    public interface TLTransportMessage : TLContainerTransportMessage
    {
        Int64 Salt { get; set; }
        Int64 SessionId { get; set; }
    }
}
