using Dashboard.Server.Services;
using Dashboard.Shared;
using Dashboard.Shared.ViewDetails;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Dashboard.Server.Controllers
{
    [Route("api/views/")]
    [ApiController]
    public class ViewDataController : ControllerBase
    {
        readonly DataService dataService;
        readonly SecurityService securityService;
        public ViewDataController(DataService dataService, SecurityService securityService)
        {
            this.dataService = dataService;
            this.securityService = securityService;
        }

        [HttpPost("load")]
        public async Task<ActionResult<UserToken<List<ViewData>>>> GetViews([FromBody] object post)
        {
            var json = JsonConvert.DeserializeObject<UserToken<object>>(post.ToString());
            var viewData = await dataService.LoadAsync<ViewData>(ConstValues.ViewData);
            var user = securityService.GetUser(json.Token);

            if (user == null)
                return Unauthorized();

            var viewIds = user.ViewRightsId();
            var resultViewData = new List<ViewData>();
            
            foreach ( var view in viewData)
                if(viewIds.Contains(view.Id))
                    resultViewData.Add(view);

            return Ok(securityService.RequestToken(json.Token, resultViewData));
        }

        [HttpPost("pie-view-by-id")]
        public async Task<ActionResult<UserToken<PieViewDetails>>> GetViewById([FromBody] object post)
        {
            var json = JsonConvert.DeserializeObject<UserToken<string>>(post.ToString());
            var viewData = await dataService.LoadViewByIdAsync(ConstValues.PieViewData, json.Obj);
            return Ok(securityService.RequestToken(json.Token, viewData));
        }

        [HttpPost("bar-chart-view-by-id")]
        public async Task<ActionResult<UserToken<PieViewDetails>>> GetBarChartViewById([FromBody] object post)
        {
            var json = JsonConvert.DeserializeObject<UserToken<string>>(post.ToString());
            var viewData = await dataService.LoadBarChartViewByIdAsync(ConstValues.BarChartView, json.Obj);
            return Ok(securityService.RequestToken(json.Token, viewData));
        }

        [HttpPost("data-set-by-id")]
        public async Task<ActionResult<UserToken<DataSet>>> GetDataSetById([FromBody] object post)
        {
            var json = JsonConvert.DeserializeObject<UserToken<string>>(post.ToString());
            var viewData = await dataService.LoadSingleByIdAsync(ConstValues.DataSet,json.Obj);
            return Ok(securityService.RequestToken(json.Token, viewData));
        }

    }
}
