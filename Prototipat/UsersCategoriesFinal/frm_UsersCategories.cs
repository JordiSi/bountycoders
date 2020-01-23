using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsersCategoriesFinal
{
    public partial class frm_UsersCategories : Form
    {
        public frm_UsersCategories()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UsersCategoriesBindingSource.DataSource = 
                ORM.SelectUserCategoriesByCodeCategory(textBox1.Text);
        }
    }
}
