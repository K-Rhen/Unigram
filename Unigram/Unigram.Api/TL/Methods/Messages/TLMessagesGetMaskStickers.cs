// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Messages
{
	/// <summary>
	/// RCP method messages.getMaskStickers.
	/// Returns <see cref="Telegram.Api.TL.TLMessagesAllStickersBase"/>
	/// </summary>
	public partial class TLMessagesGetMaskStickers : TLObject
	{
		public Int32 Hash { get; set; }

		public TLMessagesGetMaskStickers() { }
		public TLMessagesGetMaskStickers(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessagesGetMaskStickers; } }

		public override void Read(TLBinaryReader from)
		{
			Hash = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x65B8C79F);
			to.Write(Hash);
		}
	}
}