using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Api.Services.Cache;

namespace Telegram.Api.TL
{
#if !PORTABLE
    public partial interface TLChannelParticipantBase
    {
        TLUser User { get; }

        bool IsCreator { get; }
        bool IsEditor { get; }
    }
#endif

#if !PORTABLE
    internal 
#else
    public
#endif
    abstract partial class ITLChannelParticipantBase
    {
        private TLUser _user;
        public TLUser User
        {
            get
            {
                if (_user == null)
                    _user = InMemoryCacheService.Current.GetUser(UserId) as TLUser;
                return _user;
            }
        }

        public bool IsCreator
        {
            get
            {
                return this is TLChannelParticipantCreator;
            }
        }

        //public bool IsMod
        //{
        //    get
        //    {
        //        return this is TLChannelParticipantModerator || IsAdmin;
        //    }
        //}

        public bool IsEditor
        {
            get
            {
                return this is TLChannelParticipantEditor || IsCreator;
            }
        }
    }
}
