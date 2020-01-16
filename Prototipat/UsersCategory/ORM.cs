using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCategoriesFinal
{
    public static class ORM
    {
        public partial class Form : frm_UserCategory
        {
            public Form()
            {
                InitializeComponent();
            }
            private void Form_Load(object sender, EventArgs e)
            {
                BindingSource1.DataSource = ORM.SelectAllUserCategories();
            }
        }

        public static BountyCodersEntities bd = new BountyCodersEntities();
        public static List<UserCategories> SelectAllUserCategories()
        {
            List<UserCategories> _UserCategories =
                (from p in bd.UserCategories
                 select p
                 ).ToList();
            return _UserCategories;
        }
        public static List<UserCategories> SelectUserNameByName(string name)
        {
            List<UserCategories> _UserCategories = (from p in bd.UserCategories
                                                    where p.CodeCategory.Contains(name)
                                                    orderby p.CodeCategory ascending
                                                    select p).ToList();
            return _UserCategories;
        }
    }
}