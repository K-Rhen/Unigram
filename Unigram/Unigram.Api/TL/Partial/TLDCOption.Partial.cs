using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Telegram.Api.TL
{
#if !PORTABLE
    public partial interface TLDCOption
    {
        [DataMember]
        String Hostname { get; set; }

        [DataMember]
        bool IsAuthorized { get; set; }

        [DataMember]
        byte[] AuthKey { get; set; }

        [DataMember]
        long? Salt { get; set; }

        [DataMember]
        long ClientTicksDelta { get; set; }

        //[DataMember] //Important this field initialize with random value on each app startup to avoid TLBadMessage result with 32, 33 code (incorrect MsgSeqNo)
        long? SessionId { get; set; }

        bool IsValidIPv4Option(int dcId);

        bool AreEquals(TLDCOption dcOption);
    }
#endif

#if !PORTABLE
    internal
#else
    public
#endif
    partial class ITLDCOption
    {
        [DataMember]
        public String Hostname { get; set; }

        [DataMember]
        public bool IsAuthorized { get; set; }

        [DataMember]
        public byte[] AuthKey { get; set; }

        [DataMember]
        public long? Salt { get; set; }

        [DataMember]
        public long ClientTicksDelta { get; set; }

        //[DataMember] //Important this field initialize with random value on each app startup to avoid TLBadMessage result with 32, 33 code (incorrect MsgSeqNo)
        public long? SessionId { get; set; }

        public bool IsValidIPv4Option(int dcId)
        {
            return !IsIpv6 && Id != null && Id == dcId;
        }

        public bool AreEquals(TLDCOption dcOption)
        {
            if (dcOption == null) return false;

            return Id == dcOption.Id;
        }
    }
}
