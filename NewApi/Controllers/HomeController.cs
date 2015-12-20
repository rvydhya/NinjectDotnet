using NewApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NewApi.Controllers
{
    public class HomeController : ApiController
    {
        private IMyRepository _repo;

        public HomeController(IMyRepository repo)
        {
            _repo = repo;
        }
        public
                 List<user>  Get()
        {


         //   var repo = _repo(new Model1());

            return _repo.GetAllUsers();
        }
    }
}
