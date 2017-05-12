using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telegram.Api.TL
{
#if !PORTABLE
    public partial interface TLRichTextBase
    {
        string ToString(bool reserved);
    }
#endif

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLRichTextBase
    {
        public override string ToString()
        {
            return ToString(false);
        }

        public virtual string ToString(bool reserved)
        {
            throw new NotImplementedException();
        }
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLTextBold
    {
        public override string ToString(bool reserved)
        {
            return Text.ToString();
        }
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLTextConcat
    {
        public override string ToString(bool reserved)
        {
            var result = new string[Texts.Count];
			for (int i = 0; i < result.Length; i++)
            {
                result[i] = Texts[i].ToString();
            }

            return string.Join(string.Empty, result);
        }
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLTextEmail
    {
        public override string ToString(bool reserved)
        {
            return Text.ToString();
        }
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLTextEmpty
    {
        public override string ToString(bool reserved)
        {
            return string.Empty;   
        }
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLTextFixed
    {
        public override string ToString(bool reserved)
        {
            return Text.ToString();
        }
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLTextItalic
    {
        public override string ToString(bool reserved)
        {
            return Text.ToString();
        }
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLTextPlain
    {
        public override string ToString(bool reserved)
        {
            return Text;
        }
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLTextStrike
    {
        public override string ToString(bool reserved)
        {
            return Text.ToString();
        }
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLTextUnderline
    {
        public override string ToString(bool reserved)
        {
            return Text.ToString();
        }
    }

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLTextUrl
    {
        public override string ToString(bool reserved)
        {
            return Text.ToString();
        }
    }
}
