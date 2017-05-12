using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telegram.Api.TL
{
#if !PORTABLE
    public partial interface TLInputFileLocationBase
    {
        bool LocationEquals(TLInputFileLocationBase location);

        string GetPartFileName(int partNumbert);

        string GetFileName();

        string GetLocationString();
    }
#endif

#if !PORTABLE
    internal
#else
    public
#endif
    abstract partial class ITLInputFileLocationBase
    {
        public abstract bool LocationEquals(TLInputFileLocationBase location);

        public abstract string GetPartFileName(int partNumbert);

        public abstract string GetFileName();

        public abstract string GetLocationString();
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLInputFileLocation
    {
        public override bool LocationEquals(TLInputFileLocationBase location)
        {
            if (location == null) return false;

            var fileLocation = location as TLInputFileLocation;
            if (fileLocation == null) return false;

            return
                VolumeId == fileLocation.VolumeId
                && LocalId == fileLocation.LocalId
                && Secret == fileLocation.Secret;
        }

        public override string GetPartFileName(int partNumbert)
        {
            return string.Format("file{0}_{1}_{2}_{3}.dat", VolumeId, LocalId, Secret, partNumbert);
        }

        public override string GetFileName()
        {
            return string.Format("file{0}_{1}_{2}.dat", VolumeId, LocalId, Secret);
        }

        public override string GetLocationString()
        {
            return string.Format("volume_id={0} local_id={1}", VolumeId, LocalId);
        }
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLInputDocumentFileLocation
    {
        public override bool LocationEquals(TLInputFileLocationBase location)
        {
            if (location == null) return false;

            var fileLocation = location as TLInputDocumentFileLocation;
            if (fileLocation == null) return false;

            var fileLocation54 = location as TLInputDocumentFileLocation;
            if (fileLocation54 != null)
            {
                return
                    Id == fileLocation54.Id
                    && AccessHash == fileLocation54.AccessHash
                    && Version == fileLocation54.Version;
            }

            return
                Id == fileLocation.Id
                && AccessHash == fileLocation.AccessHash;
        }

        public override string GetPartFileName(int partNumbert)
        {
            if (Version > 0)
            {
                return string.Format("document{0}_{1}_{2}.dat", Id, Version, partNumbert);
            }

            return string.Format("document{0}_{1}_{2}.dat", Id, AccessHash, partNumbert);
        }

        public override string GetFileName()
        {
            if (Version > 0)
            {
                return string.Format("document{0}_{1}.dat", Id, Version);
            }

            return string.Format("document{0}_{1}.dat", Id, AccessHash);
        }

        public override string GetLocationString()
        {
            return string.Format("id={0} version={1}", Id, Version);
        }
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLInputEncryptedFileLocation
    {
        public override bool LocationEquals(TLInputFileLocationBase location)
        {
            if (location == null) return false;

            var fileLocation = location as TLInputEncryptedFileLocation;
            if (fileLocation == null) return false;

            return
                Id == fileLocation.Id
                && AccessHash == fileLocation.AccessHash;
        }

        public override string GetPartFileName(int partNumbert)
        {
            return string.Format("encrypted{0}_{1}_{2}.dat", Id, AccessHash, partNumbert);
        }

        public override string GetFileName()
        {
            return string.Format("encrypted{0}_{1}.dat", Id, AccessHash);
        }

        public override string GetLocationString()
        {
            return string.Format("id={0}", Id);
        }
    }
}
