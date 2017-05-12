using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telegram.Api.TL
{
#if !PORTABLE
    public partial interface TLContactsImportedContacts
    {
        TLContactsImportedContacts GetEmptyObject();
    }
#endif

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLContactsImportedContacts
    {
        public TLContactsImportedContacts GetEmptyObject()
        {
            return new ITLContactsImportedContacts
            {
                Imported = new ITLVector<TLImportedContact>(Imported.Count),
                RetryContacts = new ITLVector<long>(RetryContacts.Count),
                Users = new ITLVector<TLUserBase>(Users.Count)
            };
        }
    }
}
