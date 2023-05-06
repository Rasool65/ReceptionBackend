using Microsoft.AspNetCore.Mvc;
using ReceptionWebApi.DataContext.Models;
using ReceptionWebApi.Repository;

namespace ReceptionWebApi.Controllers
{
    [ApiController]
    [Route("Foods")]
    public class FoodController : ControllerBase
    {
        private IFood _Food;
        public FoodController(IFood food)
        {
            _Food = food;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Food>> GetFoods()
        {
            return _Food.GetFoods().ToList();
        }
    }
}
