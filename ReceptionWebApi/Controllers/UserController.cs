using Microsoft.AspNetCore.Mvc;
using ReceptionWebApi.DataContext.Models;
using ReceptionWebApi.Repository;

namespace ReceptionWebApi.Controllers
{
    [ApiController]
    [Route("Users")]
    public class UserController : ControllerBase
    {
        private ITblUser _UserRepo;
        public UserController(ITblUser user )
        {
            _UserRepo = user;
        }

        [HttpGet]
        public ActionResult<IEnumerable<tblUser>> GetUsers()
        {
          return _UserRepo.GetTblUsers().ToList();
        }

    }
}
