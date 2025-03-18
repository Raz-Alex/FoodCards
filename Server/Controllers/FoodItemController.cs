using FoodCards.Server.Services;
using FoodCards.Shared;
using FoodCards.Shared.Dish;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace FoodCards.Server.Controllers
{
    [Route("api/food-items/")]
    [ApiController]
    public class FoodItemController : ControllerBase
    {
        readonly DataService dataService;
        readonly SecurityService securityService;

        public FoodItemController(DataService dataService, SecurityService securityService)
        {
            this.dataService = dataService;
            this.securityService = securityService;
        }

        [HttpPost("save-list")]
        public async Task<ActionResult<UserToken<ServerConfirmation>>> SaveFoodItems([FromBody] object post)
        {
            var json = JsonConvert.DeserializeObject<UserToken<List<FoodItem>>>(post.ToString());
            var result = new UserToken<ServerConfirmation>(new Guid());

            await dataService.SaveAsync(json.Obj, ConstValues.FoodData);
            result.Obj = new ServerConfirmation(ServerConfirmationStatus.OK);

            return Ok(result);
        }

        [HttpPost("save")]
        public async Task<ActionResult<UserToken<ServerConfirmation>>> SaveFoodItem([FromBody] object post)
        {
            var json = JsonConvert.DeserializeObject<UserToken<FoodItem>>(post.ToString());
            var user = securityService.GetUser(json.Token);

            if (user == null)
                return Unauthorized();

            await dataService.InsertAsync(json.Obj, ConstValues.FoodData);

            var result = securityService.GetToken<bool>(user);
            result.Obj = true;

            return Ok(result);
        }

        [HttpPost("load")]
        public async Task<ActionResult<UserToken<List<FoodItem>>>> GetFoodItems([FromBody] object post)
        {
            var json = JsonConvert.DeserializeObject<UserToken<object>>(post.ToString());
            var data = await dataService.LoadAsync<FoodItem>(ConstValues.FoodData);
            var user = securityService.GetUser(json.Token);

            if (user == null)
                return Unauthorized();

            return Ok(securityService.RequestToken(json.Token, data));
        }
    }
}
