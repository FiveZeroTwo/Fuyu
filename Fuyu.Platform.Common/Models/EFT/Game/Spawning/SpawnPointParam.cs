using System.Runtime.Serialization;
using Fuyu.Platform.Common.Models.EFT.Common;
using Fuyu.Platform.Common.Models.EFT.Locations;

namespace Fuyu.Platform.Common.Models.EFT.Game.Spawning
{
    [DataContract]
    public struct SpawnPointParam
    {
        [DataMember]
        public string Id;

        [DataMember]
        public Vector3 Position;

        [DataMember]
        public float Rotation;

        [DataMember]
        public string[] Sides;

        [DataMember]
        public string[] Categories;

        [DataMember]
        public string Infiltration;

        [DataMember]
        public float DelayToCanSpawnSec;

        [DataMember]
        public ColliderParam ColliderParams;

        [DataMember]
        public string BotZoneName;
    }
}