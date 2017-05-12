using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telegram.Api.TL
{
#if !PORTABLE
    public partial interface TLUserProfilePhotoBase
    {
        void Update(TLUserProfilePhotoBase photo);
    }
#endif

#if !PORTABLE
    internal
#else
    public
#endif
    abstract partial class ITLUserProfilePhotoBase
    {
        public virtual void Update(TLUserProfilePhotoBase photo) { }
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLUserProfilePhoto
    {
        public override void Update(TLUserProfilePhotoBase photo)
        {
            var photoCommon = photo as TLUserProfilePhoto;
            if (photoCommon != null)
            {
                if (PhotoSmall != null)
                {
                    PhotoSmall.Update(photoCommon.PhotoSmall);
                }
                else
                {
                    PhotoSmall = photoCommon.PhotoSmall;
                }
                if (PhotoBig != null)
                {
                    PhotoBig.Update(photoCommon.PhotoBig);
                }
                else
                {
                    PhotoBig = photoCommon.PhotoBig;
                }
            }
        }
    }
}
