using Fuyu.Platform.Common.Http;
using Fuyu.Platform.Common.IO;
using Fuyu.Platform.Common.Models.EFT.Responses;
using Fuyu.Platform.Common.Serialization;

namespace Fuyu.Platform.Server.Behaviours
{
    public class HideoutSettings : FuyuBehaviour
    {
        private readonly ResponseBody<HideoutSettingsResponse> _response;

        public HideoutSettings()
        {
            var json = Resx.GetText("fuyu", "database.client.hideout.settings.json");
            _response = Json.Parse<ResponseBody<HideoutSettingsResponse>>(json);
        }

        public override void Run(FuyuContext context)
        {
            SendJson(context, Json.Stringify(_response));
        }
    }
}