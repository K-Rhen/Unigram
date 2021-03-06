﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Api.Helpers;
using Telegram.Api.Services.FileManager;
using Telegram.Api.TL;
using Unigram.Common;
using Unigram.Converters;
using Unigram.Views;
using Unigram.Native;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace Unigram.Common
{
    public class TLBitmapSource
    {
        private static readonly IDownloadFileManager _downloadFileManager;
        private static readonly IDownloadWebFileManager _downloadWebFileManager;

        static TLBitmapSource()
        {
            _downloadFileManager = UnigramContainer.Current.ResolveType<IDownloadFileManager>();
            _downloadWebFileManager = UnigramContainer.Current.ResolveType<IDownloadWebFileManager>();
        }

        public const int PHASE_PLACEHOLDER = 0;
        public const int PHASE_THUMBNAIL = 1;
        public const int PHASE_FULL = 2;

        public BitmapImage Image { get; private set; } = new BitmapImage { DecodePixelType = DecodePixelType.Logical };
        public int Phase { get; private set; }

        private object _source;

        public TLBitmapSource() { }

        public TLBitmapSource(TLUser user)
        {
            _source = user;

            Image.DecodePixelWidth = 64;
            Image.DecodePixelHeight = 64;

            var userProfilePhoto = user.Photo as TLUserProfilePhoto;
            if (userProfilePhoto != null)
            {
                if (TrySetSource(userProfilePhoto.PhotoSmall as TLFileLocation, PHASE_FULL) == false)
                {
                    //SetProfilePlaceholder(user, "u" + user.Id, user.Id, user.FullName);
                    SetSource(null, userProfilePhoto.PhotoSmall as TLFileLocation, 0, PHASE_FULL);
                }
            }
            else
            {
                SetProfilePlaceholder(user, "u" + user.Id, user.Id, user.FullName);
            }
        }

        public TLBitmapSource(TLChatBase chatBase)
        {
            _source = chatBase;

            Image.DecodePixelWidth = 64;
            Image.DecodePixelHeight = 64;

            TLChatPhotoBase chatPhotoBase = null;

            if (chatBase is TLChannel channel)
            {
                chatPhotoBase = channel.Photo;
            }

            if (chatBase is TLChat chat)
            {
                chatPhotoBase = chat.Photo;
            }

            if (chatPhotoBase is TLChatPhoto chatPhoto)
            {
                if (TrySetSource(chatPhoto.PhotoSmall as TLFileLocation, PHASE_FULL) == false)
                {
                    //SetProfilePlaceholder(chatBase, "c" + chatBase.Id, chatBase.Id, chatBase.DisplayName);
                    SetSource(null, chatPhoto.PhotoSmall as TLFileLocation, 0, PHASE_FULL);
                }
            }
            else
            {
                SetProfilePlaceholder(chatBase, "c" + chatBase.Id, chatBase.Id, chatBase.DisplayName);
            }
        }

        public TLBitmapSource(TLPhotoBase photoBase)
        {
            _source = photoBase;

            var photo = photoBase as TLPhoto;
            if (photo != null)
            {
                if (TrySetSource(photo.Full, PHASE_FULL) == false)
                {
                    SetSource(null, photo.Thumb, PHASE_THUMBNAIL);
                    //SetSource(photo, photo.Full, PHASE_FULL);
                }
            }
        }

        public TLBitmapSource(TLDocument document)
        {
            _source = document;

            SetSource(null, document.Thumb, PHASE_THUMBNAIL);
        }

        public TLBitmapSource(TLWebDocument document)
        {
            _source = document;

            Phase = PHASE_FULL;

            var fileName = BitConverter.ToString(Utils.ComputeMD5(document.Url)).Replace("-", "") + ".jpg";
            if (File.Exists(FileUtils.GetTempFileName(fileName)))
            {
                Image.UriSource = FileUtils.GetTempFileUri(fileName);
            }
            else
            {
                Execute.BeginOnThreadPool(async () =>
                {
                    var result = await _downloadWebFileManager.DownloadFileAsync(fileName, document.DCId, new TLInputWebFileLocation { Url = document.Url, AccessHash = document.AccessHash }, document.Size).AsTask(document.Download());
                    if (result != null && Phase <= PHASE_FULL)
                    {
                        Execute.BeginOnUIThread(() =>
                        {
                            Image.UriSource = FileUtils.GetTempFileUri(fileName);
                        });
                    }
                });
            }
        }

        public void Download()
        {
            if (PHASE_FULL > Phase && _source is TLPhoto photo)
            {
                SetSource(photo, photo.Full, PHASE_FULL);
            }
        }

        private async void SetProfilePlaceholder(object value, string group, int id, string name)
        {
            if (PHASE_PLACEHOLDER >= Phase)
            {
                Phase = PHASE_PLACEHOLDER;

                var fileName = FileUtils.GetTempFileName("placeholders\\" + group + "_placeholder.png");
                if (File.Exists(fileName))
                {
                    Image.UriSource = FileUtils.GetTempFileUri("placeholders//" + group + "_placeholder.png");
                }
                else
                {
                    var file = await ApplicationData.Current.LocalFolder.CreateFileAsync(SettingsHelper.SessionGuid + "\\temp\\placeholders\\" + group + "_placeholder.png", CreationCollisionOption.OpenIfExists);
                    using (var stream = await file.OpenAsync(FileAccessMode.ReadWrite))
                    {
                        if (stream.Size == 0)
                        {
                            PlaceholderImageSource.Draw(BindConvert.Current.Bubble(id).Color, InitialNameStringConverter.Convert(value), stream);
                            stream.Seek(0);
                        }

                        Image.SetSource(stream);
                    }
                }
            }
        }

        private bool TrySetSource(TLPhotoSizeBase photoSizeBase, int phase)
        {
            var photoSize = photoSizeBase as TLPhotoSize;
            if (photoSize != null)
            {
                return TrySetSource(photoSize.Location as TLFileLocation, phase);
            }

            var photoCachedSize = photoSizeBase as TLPhotoCachedSize;
            if (photoCachedSize != null)
            {
                if (phase >= Phase)
                {
                    Phase = phase;
                    Image.SetSource(photoCachedSize.Bytes);
                    return true;
                }
            }

            return false;
        }

        private void SetSource(ITLTransferable transferable, TLPhotoSizeBase photoSizeBase, int phase)
        {
            var photoSize = photoSizeBase as TLPhotoSize;
            if (photoSize != null)
            {
                SetSource(transferable, photoSize.Location as TLFileLocation, photoSize.Size, phase);
            }

            var photoCachedSize = photoSizeBase as TLPhotoCachedSize;
            if (photoCachedSize != null)
            {
                if (phase >= Phase)
                {
                    Phase = phase;
                    Image.SetSource(photoCachedSize.Bytes);
                }
            }
        }

        private bool TrySetSource(TLFileLocation location, int phase)
        {
            if (phase >= Phase && location != null)
            {
                var fileName = string.Format("{0}_{1}_{2}.jpg", location.VolumeId, location.LocalId, location.Secret);
                if (File.Exists(FileUtils.GetTempFileName(fileName)))
                {
                    Phase = phase;

                    Image.UriSource = FileUtils.GetTempFileUri(fileName);
                    return true;
                }
            }

            return false;
        }

        private void SetSource(ITLTransferable transferable, TLFileLocation location, int fileSize, int phase)
        {
            if (phase >= Phase && location != null)
            {
                Phase = phase;

                var fileName = string.Format("{0}_{1}_{2}.jpg", location.VolumeId, location.LocalId, location.Secret);
                if (File.Exists(FileUtils.GetTempFileName(fileName)))
                {
                    Image.UriSource = FileUtils.GetTempFileUri(fileName);
                }
                else
                {
                    Execute.BeginOnThreadPool(async () =>
                    {
                        var result = await _downloadFileManager.DownloadFileAsync(location, fileSize).AsTask(transferable?.Download());
                        if (result != null && Phase <= phase)
                        {
                            Execute.BeginOnUIThread(() =>
                            {
                                if (transferable != null)
                                {
                                    transferable.IsTransferring = false;
                                }

                                Image.UriSource = FileUtils.GetTempFileUri(fileName);
                            });
                        }
                    });
                }
            }
        }
    }

    public static class LazyBitmapImage
    {
        public static async void SetSource(this BitmapSource bitmap, byte[] data)
        {
            using (var stream = new InMemoryRandomAccessStream())
            {
                using (var writer = new DataWriter(stream.GetOutputStreamAt(0)))
                {
                    writer.WriteBytes(data);
                    await writer.StoreAsync();
                }

                try
                {
                    await bitmap.SetSourceAsync(stream);
                }
                catch
                {
                    Debug.Write("AGGRESSIVE");
                }
            }
        }
    }
}