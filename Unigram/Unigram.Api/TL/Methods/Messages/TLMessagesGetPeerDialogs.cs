// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Messages
{
	/// <summary>
	/// RCP method messages.getPeerDialogs.
	/// Returns <see cref="Telegram.Api.TL.TLMessagesPeerDialogs"/>
	/// </summary>
	public partial class TLMessagesGetPeerDialogs : TLObject
	{
		public TLVector<TLInputPeerBase> Peers { get; set; }

		public TLMessagesGetPeerDialogs() { }
		public TLMessagesGetPeerDialogs(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessagesGetPeerDialogs; } }

		public override void Read(TLBinaryReader from)
		{
			Peers = TLFactory.Read<TLVector<TLInputPeerBase>>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x2D9776B9);
			to.WriteObject(Peers);
		}
	}
}