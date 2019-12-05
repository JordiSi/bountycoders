using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Drawing;

namespace CustomControls
{
    public class SWTextBox : TextBox
    {
        public enum TipoDato
        {
            Numero,
            Texto,
            Fecha,
            Codigo
        }

        public string CampoBD
        {
            get { return _CampoBD; }
            set { _CampoBD = value; }
        }
        public string IdCombobox
        {
            get { return _IdCombobox; }
            set { _IdCombobox = value; }
        }
        public bool Llenar
        {
            get { return _Llenar; }
            set { _Llenar = value; }
        }
        public bool Foranea
        {
            get { return _Foranea; }
            set { _Foranea = value; }
        }

        private TipoDato _TipoValor;
        private string _CampoBD;
        private bool _Llenar;
        private bool _Foranea;
        private string _IdCombobox;

        public SWTextBox()
        {
            InitializeComponent();
        }

        public TipoDato TipoValor
        {
            get { return _TipoValor; }
            set { _TipoValor = value; }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SWTextBox_KeyPress);
            this.Leave += new System.EventHandler(this.SWTextBox_Leave);
            this.Enter += new System.EventHandler(this.SWTextBox_Enter);
            this.TextChanged += new System.EventHandler(this.SWTextBox_TextChanged);
            this.ResumeLayout(false);

        }

        Regex rgxFecha = new Regex("^([0]?[1-9]|[1][0-2])[./-]([0]?[1-9]|[1|2][0-9]|[3][0|1])[./-]([0-9]{4}|[0-9]{2})$", RegexOptions.IgnoreCase);
        Regex rgxCodigo = new Regex("^([A-Z]{4})[-]([0-9]{3})[/]([1]|[3]|[5]|[7]|[9])([A]|[E]|[I]|[O]|[U])", RegexOptions.IgnoreCase);

        private void SWTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TipoValor == TipoDato.Numero)
            {
                if (char.IsLetter(e.KeyChar) || !char.IsLetterOrDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else if (TipoValor == TipoDato.Texto)
            {
                if (char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else { }
        }
        private void SWTextBox_Leave(object sender, EventArgs e)
        {
            this.BackColor = DefaultBackColor;
            if (TipoValor == TipoDato.Fecha)
            {
                if (!rgxFecha.IsMatch(this.Text))
                {
                    this.Text = "";
                    MessageBox.Show("Introdueix la data correctament.");
                }

            }
            else if (TipoValor == TipoDato.Codigo)
            {
                if (!rgxCodigo.IsMatch(this.Text))
                {
                    this.Text = "";
                    MessageBox.Show("Introdueix el codi correctament.");
                }

            }
        }
        private void SWTextBox_Enter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGreen;
        }
        private void SWTextBox_TextChanged(object sender, EventArgs e)
        {
            if (((SWTextBox)sender).Foranea)
            {
                foreach (Control ctr1 in this.Parent.Controls)
                {
                    if (ctr1.Name == this.IdCombobox && (ctr1.Text != ""))
                    {
                        ((ComboBoxFK)ctr1).SelectedValue = this.Text;
                    }
                }
            }

        }
    }
}
