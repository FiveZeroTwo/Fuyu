using System.Runtime.Serialization;

namespace Fuyu.Platform.Common.Models.EFT.Profiles.Stats
{
    [DataContract]
    public struct Counter
    {
        // TODO: proper type. Unable to find
        [DataMember]
        public object[] Items;
    }
}