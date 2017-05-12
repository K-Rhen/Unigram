using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telegram.Api.TL
{
#if !PORTABLE
    public partial interface TLContactsContactsBase
    {
        TLContactsContactsBase GetEmptyObject();
    }
#endif

#if !PORTABLE
    internal
#else
    public
#endif
    abstract partial class ITLContactsContactsBase
    {
        public abstract TLContactsContactsBase GetEmptyObject();
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLContactsContacts
    {
        public override TLContactsContactsBase GetEmptyObject()
        {
            return new ITLContactsContacts
            {
                Contacts = new ITLVector<TLContact>(Contacts.Count),
                Users = new ITLVector<TLUserBase>(Users.Count)
            };
        }
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLContactsContactsNotModified
    {
        public override TLContactsContactsBase GetEmptyObject()
        {
            return new ITLContactsContactsNotModified();
        }
    }
}
