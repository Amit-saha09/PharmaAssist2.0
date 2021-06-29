using PharmaAssist2._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PharmaAssist2._0.Repository
{
    public class LoginRepository : Repository<Login>
    {
        public bool Getregistared(string q)
        {
            List<Login> p = this.contex.Logins.Where(x => x.Email == q).ToList();
            if (p == null)
            {
                return true;

            }
            else
            {
                return false;
            }



        }
        public Login Getthat(string q)
        {
            var p = this.contex.Logins.Where(x => x.Email == q).FirstOrDefault();
            return p;

        }
    }
}
    