using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Api.Helpers;

namespace Telegram.Api.TL
{
#if !PORTABLE
    public partial interface TLUser
    {
        TLInputUserBase ToInputUser();
    }
#endif

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLUser
    {
        public override string FullName
        {
            get
            {
                if (IsDeleted)
                {
                    return "Deleted Account";
                }

                //if (this is TLUserEmpty)
                //{
                //    return "Empty user";
                //}

                //if (this is TLUserDeleted)
                //{
                //    return "Deleted user";
                //}

                //if (ExtendedInfo != null)
                //{
                //    return string.Format("{0} {1}", ExtendedInfo.FirstName, ExtendedInfo.LastName);
                //}

                var firstName = FirstName ?? string.Empty;
                var lastName = LastName ?? string.Empty;

                if (string.IsNullOrEmpty(firstName) && string.IsNullOrEmpty(lastName))
                {
                    return Phone != null ? "+" + Phone : string.Empty;
                }

                if (string.Equals(firstName, lastName, StringComparison.OrdinalIgnoreCase))
                {
                    return firstName;
                }

                if (string.IsNullOrEmpty(firstName))
                {
                    return lastName;
                }

                if (string.IsNullOrEmpty(lastName))
                {
                    return firstName;
                }

                return string.Format("{0} {1}", firstName, lastName);
            }
        }

        public override void Update(TLUserBase userBase)
        {
            base.Update(userBase);

            try
            {
                var user = userBase as TLUser;
                if (user != null)
                {
                    FirstName = user.FirstName;
                    LastName = user.LastName;
                    Phone = user.Phone;

                    if (Photo != null && user.Photo != null && Photo.GetType() != user.Photo.GetType())
                    {
                        Photo.Update(user.Photo);
                    }
                    else
                    {
                        Photo = user.Photo;
                    }

                    Status = user.Status;
                }
            }
            catch (Exception e)
            {

            }
        }

        // TODO
        public override TLInputPeerBase ToInputPeer()
        {
            if (HasAccessHash)
            {
                //if (IsContact || IsMutualContact)
                //{
                //    var userContact = new ITLInputPeerContact
                //    {
                //        UserId = Id
                //    };

                //    return userContact;
                //}

                //var userForeign = new ITLInputPeerForeign
                //{
                //    UserId = Id,
                //    AccessHash = AccessHash
                //};

                //return userForeign;

                return new ITLInputPeerUser { UserId = Id, AccessHash = AccessHash.Value };
            }

            //if (IsDeleted)
            //{
            //    var userDeleted = new ITLInputPeerContact { UserId = Id };

            //    return userDeleted;
            //}

            if (IsSelf)
            {
                return new ITLInputPeerSelf();
            }

            Helpers.Execute.ShowDebugMessage("TLUser.ToInputPeer unknown " + FirstName);

            return new ITLInputPeerUser { UserId = Id };
            //return null;
        }

        public TLInputUserBase ToInputUser()
        {
            if (HasAccessHash)
            {
                //if (IsSet(Flags, (int)UserFlags.Contact)
                //    || IsSet(Flags, (int)UserFlags.ContactMutual))
                //{
                //    var userContact = new ITLInputUserContact
                //    {
                //        UserId = Id
                //    };

                //    return userContact;
                //}

                //var userForeign = new ITLInputUserForeign
                //{
                //    UserId = Id,
                //    AccessHash = AccessHash
                //};

                //return userForeign;

                return new ITLInputUser { AccessHash = AccessHash.Value, UserId = Id };
            }

            //if (IsSet(Flags, (int)UserFlags.Deleted))
            //{
            //    var userDeleted = new ITLInputUserContact { UserId = Id };

            //    return userDeleted;
            //}

            if (IsSelf)
            {
                return new ITLInputUserSelf();
            }

            Helpers.Execute.ShowDebugMessage("TLUser.ToInputUser unknown " + FullName);

            return new ITLInputUser { UserId = Id };
            //return null;
        }

        public override TLPeerBase ToPeer()
        {
            return new ITLPeerUser { UserId = Id };
        }
    }
}
