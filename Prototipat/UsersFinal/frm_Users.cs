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
            PlanetsBindingSource.DataSource = ORM.SelectAllPlanets();
            SpeciesBindingSource.DataSource = ORM.SelectAllSpecies();
            UserCategoriesBindingSource.DataSource = ORM.SelectAllUserCategories();
            UserRanksBindingSource.DataSource = ORM.SelectAllUserRanks();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            usersBindingSource.DataSource = ORM.SelectUserNameByName(textBox1.Text);
        }

        private void usersBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Insertar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        //private void toolStripButton1_Click(object sender, EventArgs e)
        //{
        //    InsertUser f = new InsertUser();
        //    f.ShowDialog();
        //}
    }
}
