using System;
using System.Collections.Generic;
using MenuApi.Models.Responses;
using Microsoft.AspNetCore.Mvc;

namespace MenuApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MenuItemsController : ControllerBase
    {
        public IList<MenuItem> GetMenuItems()
        {
            return new List<MenuItem>()
            {
                new MenuItem()
                {
                    Id = Guid.NewGuid().ToString()
                }
            };
        }
    }
}
