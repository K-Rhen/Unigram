using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Api.Aggregator;
using Telegram.Api.Services;
using Telegram.Api.Services.Cache;
using Telegram.Api.TL;
using Unigram.Collections;
using Unigram.Common;
using Windows.UI.Xaml.Navigation;

namespace Unigram.ViewModels
{
    public class DialogSharedMediaViewModel : UnigramViewModelBase
    {
        public DialogSharedMediaViewModel(IMTProtoService protoService, ICacheService cacheService, ITelegramEventAggregator aggregator)
            : base(protoService, cacheService, aggregator)
        {
        }

        public override Task OnNavigatedToAsync(object parameter, NavigationMode mode, IDictionary<string, object> state)
        {
            Media = new MediaCollection(ProtoService, (TLInputPeerBase)parameter, new ITLInputMessagesFilterPhotoVideo());
            Files = new MediaCollection(ProtoService, (TLInputPeerBase)parameter, new ITLInputMessagesFilterDocument());
            Links = new MediaCollection(ProtoService, (TLInputPeerBase)parameter, new ITLInputMessagesFilterUrl());
            Music = new MediaCollection(ProtoService, (TLInputPeerBase)parameter, new ITLInputMessagesFilterMusic());

            RaisePropertyChanged(() => Media);
            RaisePropertyChanged(() => Files);
            RaisePropertyChanged(() => Links);
            RaisePropertyChanged(() => Music);

            return Task.CompletedTask;
        }

        public MediaCollection Media { get; private set; }
        public MediaCollection Files { get; private set; }
        public MediaCollection Links { get; private set; }
        public MediaCollection Music { get; private set; }
    }
}
