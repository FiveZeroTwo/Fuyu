using System.Runtime.Serialization;
using Fuyu.Platform.Common.Models.EFT.Common;

namespace Fuyu.Platform.Common.Models.EFT.Locations
{
    [DataContract]
    public struct ColliderProperties
    {
        [DataMember]
        public Vector3 Center;

        [DataMember]
        public float Radius;
    }
}