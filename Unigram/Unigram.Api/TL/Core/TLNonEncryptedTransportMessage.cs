using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation.Metadata;

namespace Telegram.Api.TL
{
    internal class ITLNonEncryptedTransportMessage : ITLTransportMessageBase, TLNonEncryptedTransportMessage
    {
        public Int64 AuthKeyId { get; set; }
        public TLObject Query { get; set; }

        public ITLNonEncryptedTransportMessage() { }
        public ITLNonEncryptedTransportMessage(TLBinaryReader from)
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
            AuthKeyId = from.ReadInt64();
            MsgId = from.ReadInt64();

            var length = from.ReadInt32();
            var innerType = (TLType)from.ReadInt32();
            Query = TLFactory.Read<TLObject>(from, innerType);
            //Query = TLFactory.Read<TLObject>(from, (TLType)from.ReadInt32());
        }

        public override void Write(TLBinaryWriter to)
        {
            using (var output = new MemoryStream())
            {
                using (var writer = new TLBinaryWriter(output))
                {
                    //writer.Write((uint)Object.TypeId);
                    writer.WriteObject(Query);
                    var buffer = output.ToArray();

                    to.Write(AuthKeyId);
                    to.Write(MsgId);
                    to.Write(buffer.Length);
                    to.Write(buffer);
                }
            }
        }
    }

    [Guid(0x533e0631, 0xced2, 0xb8ae, 0xf8, 0xd3, 0xbe, 0xfb, 0x29, 0xad, 0x55, 0x3a)]
    public interface TLNonEncryptedTransportMessage : TLTransportMessageBase
    {
        Int64 AuthKeyId { get; set; }
        TLObject Query { get; set; }
    }
}
