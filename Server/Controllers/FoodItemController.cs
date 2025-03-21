﻿using FoodCards.Server.Services;
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

        [HttpGet("load-all-fooditems")]
        public async Task<ActionResult<List<FoodItem>>> GetAllFoodItems()
        {
            var data = await dataService.LoadAsync<FoodItem>(ConstValues.FoodData);
            return Ok(data);
        }


        [HttpPost("load")]
        public async Task<ActionResult<UserToken<List<FoodItem>>>> GetFoodItems([FromBody] object post)
        {
            var json = JsonConvert.DeserializeObject<UserToken<object>>(post.ToString());
            var user = securityService.GetUser(json.Token);

            if (user == null)
                return Unauthorized();

            var data = await dataService.LoadAsync<FoodItem>(ConstValues.FoodData);
            return Ok(securityService.RequestToken(json.Token, data));
        }

        [HttpPost("save-meal")]
        public async Task<ActionResult<UserToken<ServerConfirmation>>> SaveMeal([FromBody] object post)
        {
            var json = JsonConvert.DeserializeObject<UserToken<Meal>>(post.ToString());
            var user = securityService.GetUser(json.Token);

            if (user == null)
                return Unauthorized();

            var mealIngredients = new List<MealIngredient>();
            foreach(var ingredient in json.Obj.Ingredients)
            {
                mealIngredients.Add(new()
                {
                    MealId = json.Obj.Id,
                    IngredientId = ingredient.Id,
                    Quantity = ingredient.Quantity
                });
            }

            await dataService.InsertListAsync(mealIngredients, ConstValues.MealData);
            await dataService.InsertAsync(new MealDetails
            {
                Id = json.Obj.Id,
                Name = json.Obj.Name,
                Photo = json.Obj.Photo,
                Breakfast = json.Obj.Breakfast,
                Lunch = json.Obj.Lunch,
                Dinner = json.Obj.Dinner,
                Snack = json.Obj.Snack
            }, ConstValues.MealDetailsData);

            var result = securityService.GetToken<bool>(user);
            result.Obj = true;

            return Ok(result);
        }

        [HttpPost("load-meals")]
        public async Task<ActionResult<UserToken<List<Meal>>>> LoadMeals([FromBody] object post)
        {
            var json = JsonConvert.DeserializeObject<UserToken<object>>(post.ToString());
            var user = securityService.GetUser(json.Token);

            if (user == null)
                return Unauthorized();

            var data = await dataService.LoadAsync<MealIngredient>(ConstValues.MealData);
            var details = await dataService.LoadAsync<MealDetails>(ConstValues.MealDetailsData);

            var meals = data.
                GroupBy(x => x.MealId).
                Select(x => new Meal()
                {
                    Id = x.Key,
                    Ingredients = x.Select(x => new FoodItem() { Id = x.IngredientId, Quantity = x.Quantity }).ToList(),
                }).ToList();

            foreach(var meal in meals)
            {
                var detail = details.Where(x => x.Id == meal.Id).FirstOrDefault();
                if (detail == null)
                    continue;

                meal.Id = detail.Id;
                meal.Name = detail.Name;
                meal.Photo = detail.Photo;
                meal.Breakfast = detail.Breakfast;
                meal.Lunch = detail.Lunch;
                meal.Dinner = detail.Dinner;
                meal.Snack = detail.Snack;
            }

            return Ok(securityService.RequestToken(json.Token, meals));
        }
    }
}
