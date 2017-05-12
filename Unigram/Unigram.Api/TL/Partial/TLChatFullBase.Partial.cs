using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telegram.Api.TL
{
#if !PORTABLE
    public partial interface TLChatFullBase
    {
        void Update(TLChatFullBase chatFull);
    }
#endif

#if !PORTABLE
    internal
#else
    public
#endif
    abstract partial class ITLChatFullBase
    {
        public virtual void Update(TLChatFullBase chatFull)
        {
            this.BotInfo = chatFull.BotInfo;
            this.ChatPhoto = chatFull.ChatPhoto;
            this.ExportedInvite = chatFull.ExportedInvite;
            this.Id = chatFull.Id;
            this.NotifySettings = chatFull.NotifySettings;
        }

        //public TLChatBase ToChat(TLChatBase chat)
        //{
        //    //chat.NotifySettings = NotifySettings;
        //    //chat.Participants = Participants;
        //    //chat.ChatPhoto = ChatPhoto;

        //    //var channel = chat as TLChannel;
        //    //if (channel != null)
        //    //{
        //    //    channel.ExportedInvite = ExportedInvite;
        //    //    channel.About = About;
        //    //    channel.ParticipantsCount = ParticipantsCount;
        //    //    channel.AdminsCount = AdminsCount;
        //    //    channel.KickedCount = KickedCount;
        //    //    channel.ReadInboxMaxId = ReadInboxMaxId;
        //    //}

        //    return chat;
        //}
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLChatFull
    {
        public override void Update(TLChatFullBase chatFull)
        {
            if (chatFull is TLChatFull chat)
            {
                this.Participants = chat.Participants;
            }

            base.Update(chatFull);
        }
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLChannelFull
    {
        public override void Update(TLChatFullBase chatFull)
        {
            if (chatFull is TLChannelFull channel)
            {
                this.Flags = channel.Flags;
                this.About = channel.About;
                this.ParticipantsCount = channel.ParticipantsCount;
                this.AdminsCount = channel.AdminsCount;
                this.KickedCount = channel.KickedCount;
                this.ReadInboxMaxId = channel.ReadInboxMaxId;
                this.ReadOutboxMaxId = channel.ReadOutboxMaxId;
                this.UnreadCount = channel.UnreadCount;
                this.MigratedFromChatId = channel.MigratedFromChatId;
                this.MigratedFromMaxId = channel.MigratedFromMaxId;
                this.PinnedMsgId = channel.PinnedMsgId;
            }

            base.Update(chatFull);
        }
    }
}
