using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation.Metadata;

namespace Telegram.Api.TL
{
#if !PORTABLE
    internal
#else
    public
#endif
    class ITLInt256 : ITLObject, TLInt256
    {
        public TLInt128 Low { get; set; }
        public TLInt128 High { get; set; }

        public ITLInt256()
        {
            Low = new ITLInt128();
            High = new ITLInt128();
        }

        public ITLInt256(TLBinaryReader from)
        {
            Low = new ITLInt128();
            High = new ITLInt128();

            Read(from);
        }

        public override TLType TypeId { get { return TLType.Int256; } }

        public override void Read(TLBinaryReader from)
        {
            Low.Read(from);
            High.Read(from);
        }

        public override void Write(TLBinaryWriter to)
        {
            Low.Write(to);
            High.Write(to);
        }

        #region Operators
        public static bool operator ==(ITLInt256 a, ITLInt256 b)
        {
            return a.Low == b.Low && a.High == b.High;
        }

        public static bool operator !=(ITLInt256 a, ITLInt256 b)
        {
            return a.Low != b.Low || a.High != b.High;
        }

        public override bool Equals(object obj)
        {
            var b = obj as ITLInt256;
            if ((object)b == null)
            {
                return false;
            }

            return base.Equals(obj) || (Low == b.Low && High == b.High);
        }

        public override int GetHashCode()
        {
            return Low.GetHashCode() ^ High.GetHashCode();
        }
        #endregion

        public static TLInt256 Random()
        {
            return new ITLInt256
            {
                Low = ITLInt128.Random(),
                High = ITLInt128.Random()
            };
        }
    }

#if !PORTABLE
    [Guid(0x042b981a, 0x1451, 0xb6a0, 0xb4, 0x88, 0x66, 0x2e, 0x8d, 0xc6, 0xfc, 0x52)]
    public partial interface TLInt256 : TLObject
    {
        TLInt128 Low { get; set; }
        TLInt128 High { get; set; }
    }
#endif

}
