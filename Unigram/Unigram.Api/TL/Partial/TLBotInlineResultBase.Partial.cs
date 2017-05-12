using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telegram.Api.TL
{
#if !PORTABLE
    public partial interface TLBotInlineResultBase
    {
        Int64 QueryId { get; set; }
    }
#endif

#if !PORTABLE
    internal 
#else
    public
#endif
    abstract partial class ITLBotInlineResultBase
    {
        public Int64 QueryId { get; set; }
    }
}
