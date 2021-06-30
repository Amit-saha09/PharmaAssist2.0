using PharmaAssist2._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PharmaAssist2._0.Repository
{
    public class LoginRepository : Repository<Login>
    {
        public Login Getregistared(string q)
        {
           
               var p = this.contex.Logins.Where(x => x.Email == q).FirstOrDefault();
            return p;


        }
        public Login Getthat(string q)
        {
            var p = this.contex.Logins.Where(x => x.Email == q).FirstOrDefault();
            return p;

        }
    }
}
    