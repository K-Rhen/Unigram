using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Api.Helpers;
using Telegram.Api.Services.Cache;

namespace Telegram.Api.TL
{
#if !PORTABLE
    public partial interface TLMessageMediaBase : INotifyPropertyChanged
    {

    }
#endif

#if !PORTABLE
    internal
#else
    public
#endif
    abstract partial class ITLMessageMediaBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public override void RaisePropertyChanged(string propertyName)
        {
            Execute.OnUIThread(() => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName)));
        }
    }
}
