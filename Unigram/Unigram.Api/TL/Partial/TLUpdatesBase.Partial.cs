using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telegram.Api.TL
{
#if !PORTABLE
    public partial interface TLUpdatesBase
    {
        IList<int> GetSeq();

        IList<int> GetPts();
    }
#endif

#if !PORTABLE
    internal
#else
    public
#endif
    abstract partial class ITLUpdatesBase
    {
        public abstract IList<int> GetSeq();

        public abstract IList<int> GetPts();
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLUpdatesTooLong
    {
        public override IList<int> GetSeq()
        {
            return new List<int>();
        }

        public override IList<int> GetPts()
        {
            return new List<int>();
        }
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLUpdateShortSentMessage
    {
        public override IList<int> GetSeq()
        {
            return new List<int>();
        }

        public override IList<int> GetPts()
        {
            return TLUtils.GetPtsRange(Pts, PtsCount);
        }
    }

#if !PORTABLE
    public partial interface TLUpdateShortMessage
    {
        bool IsUnread { get; set; }
    }
#endif

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLUpdateShortMessage
    {
        public bool IsUnread { get; set; } = true;

        public override IList<int> GetSeq()
        {
            return new List<int>();
        }

        public override IList<int> GetPts()
        {
            return TLUtils.GetPtsRange(Pts, PtsCount);
        }
    }

#if !PORTABLE
    public partial interface TLUpdateShortChatMessage
    {
        bool IsUnread { get; set; }
    }
#endif

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLUpdateShortChatMessage
    {
        public bool IsUnread { get; set; } = true;

        public override IList<int> GetSeq()
        {
            return new List<int>();
        }

        public override IList<int> GetPts()
        {
            return TLUtils.GetPtsRange(Pts, PtsCount);
        }
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLUpdateShort
    {
        public override IList<int> GetSeq()
        {
            return new List<int>();
        }

        public override IList<int> GetPts()
        {
            return Update.GetPts();
        }
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLUpdates
    {
        public override IList<int> GetSeq()
        {
            return new List<int> { Seq };
        }

        public override IList<int> GetPts()
        {
            return Updates.SelectMany(x => x.GetPts()).ToList();
        }
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLUpdatesCombined
    {
        public override IList<int> GetSeq()
        {
            var list = new List<int>();

            for (var i = SeqStart; i <= Seq; i++)
            {
                list.Add(i);
            }

            return list;
        }

        public override IList<int> GetPts()
        {
            return Updates.SelectMany(x => x.GetPts()).ToList();
        }
    }
}
