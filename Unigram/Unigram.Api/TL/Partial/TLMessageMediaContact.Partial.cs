using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Api.Services.Cache;

namespace Telegram.Api.TL
{
#if !PORTABLE
    public partial interface TLMessageMediaContact
    {
        TLUser User { get; }

        string FullName { get; }
    }
#endif

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLMessageMediaContact
    {
        private TLUser _user;
        public TLUser User
        {
            get
            {
                if (_user == null)
                {
                    var user = InMemoryCacheService.Current.GetUser(UserId) as TLUser;
                    if (user == null)
                    {
                        user = new ITLUser
                        {
                            FirstName = FirstName,
                            LastName = LastName,
                            Id = UserId,
                            Phone = PhoneNumber,
                            Photo = new ITLUserProfilePhotoEmpty()
                        };
                    }

                    _user = user;
                }

                return _user;
            }
        }

        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", FirstName, LastName).Trim();
            }
        }
    }
}
