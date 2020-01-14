using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersFinal
{
    public static class ORM
    {
        public static BountyCodersEntities bd = new BountyCodersEntities();
        public static List <Users> SelectAllUsers()
        {
            List<Users> _users =
                (from u in bd.Users
                 select u
                 ).ToList();
            return _users;
        }
        public static List<Users> SelectUserNameByName(string name)
        {
            List<Users> _users = (from u in bd.Users
                                  where u.UserName.Contains(name)
                                  orderby u.UserName ascending
                                  select u).ToList();
            return _users;
        }
    }
    public partial class Form1 : frm_Users
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
