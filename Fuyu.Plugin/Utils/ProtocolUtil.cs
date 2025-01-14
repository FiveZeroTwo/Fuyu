using System.Collections.Generic;
using System.Linq;
using HarmonyLib;
using Fuyu.Platform.Plugin.Reflection;

namespace Fuyu.Plugin.Patches
{
    public static class ProtocolUtil
    {
        // NOTE: A dirty hack, probably needs to be implemented cleanly later.
        // Since BackendName already contains the protocol, just never use the entries. 
        public static void RemoveTransportPrefixes()
        {
            var target = "TransportPrefixes";
            var type = PatchHelper.Types.Single(t => t.GetField(target) != null);
            var value = Traverse.Create(type).Field(target).GetValue<Dictionary<ETransportProtocolType, string>>();

            value[ETransportProtocolType.HTTPS] = string.Empty;
            value[ETransportProtocolType.WSS] = string.Empty;
        }
    }
}