using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsersFinal
{
    public partial class frm_Users : Form
    {
        public frm_Users()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            usersBindingSource.DataSource = ORM.SelectAllUsers();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            usersBindingSource.DataSource = ORM.SelectUserNameByName(textBox1.Text);
        }
    }
}
