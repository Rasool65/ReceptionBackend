using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReceptionWebApi.DataContext.Models;
using ReceptionWebApi.Repository;

namespace ReceptionWebApi.Controllers
{
    [ApiController]
    [Route("Orders")]
    public class OrderController : ControllerBase
    {
        private ITblOrder _OrderRepo;
        public OrderController(ITblOrder order)
        {
            _OrderRepo = order;
        }

        [HttpGet]
        public ActionResult<IEnumerable<tblOrder>> GetOrders()
        {
            return _OrderRepo.GetTblOrder().ToList();
        }
    }
}
