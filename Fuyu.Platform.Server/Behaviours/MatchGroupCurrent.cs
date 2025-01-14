using Fuyu.Platform.Common.Http;
using Fuyu.Platform.Common.Models.EFT.Responses;
using Fuyu.Platform.Common.Serialization;

namespace Fuyu.Platform.Server.Behaviours
{
    public class MatchGroupCurrent : FuyuBehaviour
    {
        public override void Run(FuyuContext context)
        {
            var response = new ResponseBody<MatchGroupCurrentResponse>()
            {
                data = new MatchGroupCurrentResponse()
                {
                    squad = []
                }
            };

            SendJson(context, Json.Stringify(response));
        }
    }
}