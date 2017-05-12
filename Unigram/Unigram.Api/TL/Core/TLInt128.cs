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
    class ITLInt128 : ITLObject, TLInt128
    {
        public long Low { get; set; }
        public long High { get; set; }

        public ITLInt128() { }
        public ITLInt128(TLBinaryReader from)
        {
            Read(from);
        }

        public override TLType TypeId { get { return TLType.Int128; } }

        public override void Read(TLBinaryReader from)
        {
            Low = from.ReadInt64();
            High = from.ReadInt64();
        }

        public override void Write(TLBinaryWriter to)
        {
            to.Write(Low);
            to.Write(High);
        }

#region Operators
        public static bool operator ==(ITLInt128 a, ITLInt128 b)
        {
            return a.Low == b.Low && a.High == b.High;
        }

        public static bool operator !=(ITLInt128 a, ITLInt128 b)
        {
            return a.Low != b.Low || a.High != b.High;
        }

        public override bool Equals(object obj)
        {
            var b = obj as ITLInt128;
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

        public static TLInt128 Random()
        {
            var random = new Random();
            var nonce = new byte[16];
            random.NextBytes(nonce);

            var l = BitConverter.ToInt64(nonce, 0);
            var h = BitConverter.ToInt64(nonce, 8);

            return new ITLInt128 { Low = l, High = h };
        }
    }

#if !PORTABLE
    [Guid(0x364ab97f, 0x1a98, 0x3051, 0x56, 0x77, 0xed, 0xa6, 0x7b, 0xc4, 0xba, 0xc1)]
    public partial interface TLInt128 : TLObject
    {
        long Low { get; set; }
        long High { get; set; }
    }
#endif

}
