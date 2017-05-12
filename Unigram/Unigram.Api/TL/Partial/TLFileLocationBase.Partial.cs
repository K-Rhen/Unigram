using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telegram.Api.TL
{
#if !PORTABLE
    public partial interface TLFileLocationBase
    {
        void Update(TLFileLocationBase fileLocation);
    }
#endif

#if !PORTABLE
    internal
#else
    public
#endif
    abstract partial class ITLFileLocationBase
    {
        public virtual void Update(TLFileLocationBase fileLocation)
        {
            if (fileLocation != null)
            {
                //if (Buffer == null || LocalId.Value != fileLocation.LocalId.Value)
                //{
                //    Buffer = fileLocation.Buffer;
                //}

                VolumeId = fileLocation.VolumeId;
                LocalId = fileLocation.LocalId;
                Secret = fileLocation.Secret;
            }
        }
    }
}
