using System.Runtime.Serialization;
using Fuyu.Platform.Common.Models.EFT;
using Fuyu.Platform.Common.Models.EFT.Profiles.Stats;

namespace Fuyu.Platform.Common.Models
{
    [DataContract]
    public struct StatsInfo
    {
        [DataMember]
        public EftStats Eft;
    }
}