using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Users
{
    public partial class Form_Users : frm_Users
    {
        public Form_Users()
        {
            InitializeComponent();
        }
        private void Frm_Users_Load(object sender, EventArgs e)
        {
            usersBindingSource.DataSource = ORM.SelectAllUsers();
        }
    }
    public static class ORM
    {
        public static BountyCodersEntities bd = new BountyCodersEntities();
        public static List<Users> SelectAllUsers()
        {
            List<Users> _users =
                (from p in bd.Users
                 select p
                 ).ToList();
            return _users;
        }
        public static List<Users> SelectUsersByName(string name)
        {
            List<Users> _users = (from p in bd.Users
                                  where p.UserName.Contains(name)
                                  orderby p.UserName ascending
                                  select p).ToList();
            return _users;
        }
    }
}
