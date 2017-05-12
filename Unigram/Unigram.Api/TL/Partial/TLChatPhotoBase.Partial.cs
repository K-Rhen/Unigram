using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telegram.Api.TL
{
#if !PORTABLE
    public partial interface TLChatPhotoBase
    {
        void Update(TLChatPhotoBase photo);
    }
#endif

#if !PORTABLE
    internal
#else
    public
#endif
    abstract partial class ITLChatPhotoBase
    {
        public virtual void Update(TLChatPhotoBase photo)
        {
        }
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLChatPhoto
    {
        public override void Update(TLChatPhotoBase photo)
        {
            var photoCommon = photo as TLChatPhoto;
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
