using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Api.Helpers;

namespace Telegram.Api.TL
{
#if !PORTABLE
    public partial interface TLInputPeerBase
    {
        TLPeerBase ToPeer();
    }
#endif

#if !PORTABLE
    internal
#else
    public
#endif
    abstract partial class ITLInputPeerBase
    {
        public TLPeerBase ToPeer()
        {
            return TLUtils.InputPeerToPeer(this, SettingsHelper.UserId);
        }
    }
}
