using NewApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace NewApi.Controllers
{
    public interface IMyRepository
    {
         
              List<user> GetAllUsers();

    }
    public class MyRepository: IMyRepository
    {
        private Model1 model1;

        public MyRepository(Model1 model1)
        {
            this.model1 = model1;
        }

        public
               List<user> GetAllUsers()
        {


            using (Model1 db = new Model1())
            {

               List<user> u = db.users.ToList<user>();
                return u;
                    }
        }
    }
}