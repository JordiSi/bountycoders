using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserCategory
{
    public partial class frm_UserCategory : Form
    {
        public frm_UserCategory()
        {
            InitializeComponent();
        }
        private void Form_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = ORM.SelectAllUserCategories();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            bindingSource1.DataSource = ORM.SelectUserNameByName(textBox1.Text);
        }
    }
}
