using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telegram.Api.TL
{
#if !PORTABLE
    public partial interface TLUserFull
    {
        void Update(TLUserFull userFull);
    }
#endif

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLUserFull
    {
        public void Update(TLUserFull userFull)
        {
            // TODO: update
        }

        //public TLUserBase ToUser()
        //{
        //    User.Link = Link;
        //    User.ProfilePhoto = ProfilePhoto;
        //    User.NotifySettings = NotifySettings;
        //    User.IsBlocked = IsBlocked;
        //    User.BotInfo = BotInfo;

        //    return User;
        //}
    }
}
