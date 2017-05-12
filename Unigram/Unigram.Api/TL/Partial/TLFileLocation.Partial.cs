using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telegram.Api.TL
{
#if !PORTABLE
    public partial interface TLFileLocation
    {
        TLInputFileLocation ToInputFileLocation();
    }
#endif

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLFileLocation
    {
        public TLInputFileLocation ToInputFileLocation()
        {
            return new ITLInputFileLocation
            {
                LocalId = LocalId,
                Secret = Secret,
                VolumeId = VolumeId
            };
        }
    }
}
