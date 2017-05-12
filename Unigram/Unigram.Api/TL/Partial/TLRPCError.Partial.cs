using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telegram.Api.TL
{
#if !PORTABLE
    internal
#else
	public
#endif
    partial class ITLRPCError
    {
        public override string ToString()
        {
            return string.Format("{0} {1}", ErrorCode, ErrorMessage);
        }
    }
}
