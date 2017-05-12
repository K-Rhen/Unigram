using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telegram.Api.TL
{
#if PORTABLE
    public class TLMessageActionUnreadMessages : ITLMessageActionBase
    {
        public TLType TypeId => (TLType)0xFFFFFF09;
    }
#endif
}
