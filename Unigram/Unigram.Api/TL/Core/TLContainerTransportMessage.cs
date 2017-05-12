using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation.Metadata;

namespace Telegram.Api.TL
{
    internal class ITLContainerTransportMessage : ITLTransportMessageBase, TLContainerTransportMessage
    {
        public Int32 SeqNo { get; set; }
        public Int32 QueryLength { get; set; }
        public TLObject Query { get; set; }

        public ITLContainerTransportMessage() { }
        public ITLContainerTransportMessage(TLBinaryReader from)
        {
            Read(from);
        }

        public override TLType TypeId
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override void Read(TLBinaryReader from)
        {
            MsgId = from.ReadInt64();
            SeqNo = from.ReadInt32();
            QueryLength = from.ReadInt32();
            Query = TLFactory.Read<TLObject>(from, (TLType)from.ReadInt32());
        }

        public override void Write(TLBinaryWriter to)
        {
            using (var output = new MemoryStream())
            {
                using (var writer = new TLBinaryWriter(output))
                {
                    writer.WriteObject(Query);
                    var buffer = output.ToArray();

                    to.Write(MsgId);
                    to.Write(SeqNo);
                    to.Write(buffer.Length);
                    to.Write(buffer);
                }
            }
        }
    }

    [Guid(0xfc0b51cf, 0x6b01, 0x7d83, 0xe0, 0x95, 0x29, 0xf8, 0x90, 0x1f, 0xac, 0xdf)]
    public interface TLContainerTransportMessage : TLTransportMessageBase
    {
        Int32 SeqNo { get; set; }
        Int32 QueryLength { get; set; }
        TLObject Query { get; set; }
    }
}
