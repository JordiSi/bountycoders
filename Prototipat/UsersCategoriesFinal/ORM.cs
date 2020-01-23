using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersCategoriesFinal
{
    public static class ORM
    {
        public partial class Form1 : frm_UsersCategories
        {
            public Form1()
            {
                InitializeComponent();
            }
            private void Form1_load(object sender, EventArgs e)
            {
                UsersCategoriesBindingSource.DataSource = ORM.SelectAllUserCategories();
            }
        }
        public static BountyCodersEntities bd = new BountyCodersEntities();

        public static List<UserCategories> SelectAllUserCategories()
        {
            List<UserCategories> _userCategories =
                (from p in bd.UserCategories
                 select p
                 ).ToList();
            return _userCategories;
        }
        public static List<UserCategories> SelectUserCategoriesByCodeCategory(string Code)
        {
            List<UserCategories> _userCategories = (from p in bd.UserCategories
                                                    where p.CodeCategory.Contains(Code)
                                                    orderby p.CodeCategory ascending
                                                    select p).ToList();
            return _userCategories;
        }
    }
}
