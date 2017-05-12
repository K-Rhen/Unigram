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
    public partial interface TLDocumentBase : ITLTransferable, INotifyPropertyChanged
    {
        TLInputDocumentBase ToInputDocument();

        bool IsGif(bool real = false);
        bool IsMusic();
        bool IsVideo();
        bool IsAudio();
        bool IsVoice();
        bool IsSticker();
    }
#endif

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLDocumentBase : ITLTransferable, INotifyPropertyChanged
    {
        public virtual TLInputDocumentBase ToInputDocument()
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

        #region Type
        public bool IsGif(bool real = false)
        {
            return ITLMessage.IsGif(this, real);
        }

        public virtual bool IsMusic()
        {
            return ITLMessage.IsMusic(this);
        }

        public bool IsVideo()
        {
            return ITLMessage.IsVideo(this);
        }

        public bool IsAudio()
        {
            return ITLMessage.IsAudio(this);
        }

        public bool IsVoice()
        {
            return ITLMessage.IsVoice(this);
        }

        public bool IsSticker()
        {
            return ITLMessage.IsSticker(this);
        }
        #endregion
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLDocument
    {
        public override TLInputDocumentBase ToInputDocument()
        {
            return new ITLInputDocument { Id = Id, AccessHash = AccessHash };
        }
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLDocumentEmpty
    {
        public override TLInputDocumentBase ToInputDocument()
        {
            return new ITLInputDocumentEmpty();
        }
    }
}
