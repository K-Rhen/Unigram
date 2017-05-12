using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Api.Helpers;

namespace Telegram.Api.TL
{
#if !PORTABLE
    public partial interface TLPhotoBase : ITLTransferable, INotifyPropertyChanged
    {
        TLInputPhotoBase ToInputPhoto();
    }
#endif

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLPhotoBase : ITLTransferable, INotifyPropertyChanged
    {
        public virtual TLInputPhotoBase ToInputPhoto()
        {
            throw new NotImplementedException();
        }

        #region Download/upload

        private double _uploadingProgress;
        public double UploadingProgress
        {
            get
            {
                return _uploadingProgress;
            }
            set
            {
                _uploadingProgress = value;
                RaisePropertyChanged(() => UploadingProgress);
                RaisePropertyChanged(() => Progress);
            }
        }

        private double _downloadingProgress;
        public double DownloadingProgress
        {
            get
            {
                return _downloadingProgress;
            }
            set
            {
                _downloadingProgress = value;
                RaisePropertyChanged(() => DownloadingProgress);
                RaisePropertyChanged(() => Progress);
            }
        }

        public double Progress
        {
            get
            {
                if (_downloadingProgress > 0)
                {
                    return _downloadingProgress;
                }

                return _uploadingProgress;
            }
        }

        public double LastProgress { get; set; }

        public Progress<double> Download()
        {
            DownloadingProgress = 0.02;

            return new Progress<double>((value) =>
            {
                DownloadingProgress = value;
                Debug.WriteLine(value);
            });
        }

        public Progress<double> Upload()
        {
            UploadingProgress = 0.02;

            return new Progress<double>((value) =>
            {
                UploadingProgress = value;
                Debug.WriteLine(value);
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public override void RaisePropertyChanged(string propertyName)
        {
            Execute.OnUIThread(() => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName)));
        }

        #endregion
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLPhoto
    {
        public override TLInputPhotoBase ToInputPhoto()
        {
            return new ITLInputPhoto { Id = Id, AccessHash = AccessHash };
        }
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLPhotoEmpty
    {
        public override TLInputPhotoBase ToInputPhoto()
        {
            return new ITLInputPhotoEmpty();
        }
    }
}
