using Microsoft.AspNetCore.Mvc;
using Test.Models;

namespace Test.Controllers
{
    public class StaffBaseController : Controller
    {
        protected readonly MyDbContext _db;

        public StaffBaseController(MyDbContext db)
        {
            _db = db;
        }
    }
}
