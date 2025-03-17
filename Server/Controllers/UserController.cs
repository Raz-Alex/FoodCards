﻿using Dashboard.Server.Services;
using Dashboard.Shared;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Dashboard.Server.Controllers
{
    [Route("api/users/")]
    [ApiController]
    public class UserController : ControllerBase
    {
        readonly DataService dataService;
        readonly SecurityService securityService;

        public UserController(DataService dataService, SecurityService securityService)
        {
            this.dataService = dataService;
            this.securityService = securityService;
        }

        [HttpPost("log-in")]
        public async Task<ActionResult<UserToken<bool>>> GetUser([FromBody] object post)
        {
            var json = JsonConvert.DeserializeObject<UserToken<User>>(post.ToString());
            var userData = await dataService.LoadAsync<User>(ConstValues.UserData);
            var user = userData.Where(x => x.UserName == json.Obj.UserName && x.Password == json.Obj.Password).FirstOrDefault();

            if (user == null)
                return Unauthorized();

            var result = securityService.GetToken<bool>(user);
            result.Obj = true;
            return Ok(result);
        }

        [HttpPost("register")]
        public async Task<ActionResult<UserToken<ServerConfirmation>>> SetUser([FromBody] object post)
        {
            var json = JsonConvert.DeserializeObject<UserToken<User>>(post.ToString());
            var userData = await dataService.LoadAsync<User>(ConstValues.UserData);
            var user = userData.Where(x => x.UserName == json.Obj.UserName && x.Password == json.Obj.Password).FirstOrDefault();

            var result = new UserToken<ServerConfirmation>(new Guid());
            if (user != null)
                result.Obj = new ServerConfirmation(ServerConfirmationStatus.Failed);
            else
            {
                await dataService.InsertAsync(json.Obj, ConstValues.UserData);
                result.Obj = new ServerConfirmation(ServerConfirmationStatus.OK);
            }

            return Ok(result);
        }
    }
}
