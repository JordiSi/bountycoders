using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Drawing;
using Dades;
using System.Data;

namespace ComboFK
{
    public class ComboBoxFK : ComboBox
    {
        private Class1 dades;

        public string controlID
        {
            get { return _controlID; }
            set { _controlID = value; }
        }
        public string taulaBD
        {
            get { return _taulaBD; }
            set { _taulaBD = value; }
        }

        private string _controlID;
        private string _taulaBD;

        public ComboBoxFK()
        {
            dades = new Class1();
            dades.Connectar();

            this.SuspendLayout();
            this.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFK_SelectedIndexChanged);
            this.ResumeLayout(false);
        }

        public void CarregaDades()
        {
            string query = "select * from " + this.taulaBD;
            DataSet dts = new DataSet();

            dts = dades.PortarTaula(query);
            this.DataSource = dts.Tables[0];
        }

        public void ControlCombo()
        {
            foreach (Control ctr1 in this.Parent.Controls)
            {
                if (ctr1.GetType() == typeof(CustomControls.SWTextBox))
                {
                    if (this.controlID == ((CustomControls.SWTextBox)ctr1).Name)
                    {
                        ((CustomControls.SWTextBox)ctr1).Text = this.SelectedIndex.ToString();
                    }
                }      
            } 
        }
        private void ComboBoxFK_SelectedIndexChanged(object sender, EventArgs e)
        {
            ControlCombo();
        }
    }
}
