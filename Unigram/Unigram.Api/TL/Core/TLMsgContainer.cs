using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telegram.Api.TL
{
    internal class ITLMsgContainer : ITLObject
    {
        public List<TLContainerTransportMessage> Messages { get; set; }

        public ITLMsgContainer() { }
        public ITLMsgContainer(TLBinaryReader from)
        {
            Read(from);
        }

        public override TLType TypeId { get { return TLType.MsgContainer; } }

        public override void Read(TLBinaryReader from)
        {
            Messages = new List<TLContainerTransportMessage>();

            var count = from.ReadUInt32();
            for (int i = 0; i < count; i++)
            {
                Messages.Add(new ITLContainerTransportMessage(from));
            }
        }

        public override void Write(TLBinaryWriter to)
        {
            to.Write(0x73F1F8DC);
            to.Write(Messages.Count);
            
            foreach (var item in Messages)
            {
                item.Write(to);
            }
        }
    }
}
