namespace Users
{
    partial class frm_Users
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        protected void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TB_codeuser = new CustomControls.SWTextBox();
            this.TB_username = new CustomControls.SWTextBox();
            this.TB_login = new CustomControls.SWTextBox();
            this.TB_password = new CustomControls.SWTextBox();
            this.TB_iduserank = new CustomControls.SWTextBox();
            this.TB_idusercategory = new CustomControls.SWTextBox();
            this.CB_iduserank = new CustomControls.ComboBoxFK();
            this.TB_idplanet = new CustomControls.SWTextBox();
            this.CB_idplanet = new CustomControls.ComboBoxFK();
            this.TB_idspecie = new CustomControls.SWTextBox();
            this.CB_idusercategory = new CustomControls.ComboBoxFK();
            this.CB_idspecie = new CustomControls.ComboBoxFK();
            this.TB_photo = new CustomControls.SWTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BD_Users = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BD_Users)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_codeuser
            // 
            this.TB_codeuser.CampoBD = "codeuser";
            this.TB_codeuser.Foranea = false;
            this.TB_codeuser.IdCombobox = null;
            this.TB_codeuser.Llenar = false;
            this.TB_codeuser.Location = new System.Drawing.Point(84, 91);
            this.TB_codeuser.Name = "TB_codeuser";
            this.TB_codeuser.Size = new System.Drawing.Size(100, 20);
            this.TB_codeuser.TabIndex = 31;
            this.TB_codeuser.TipoValor = CustomControls.SWTextBox.TipoDato.Texto;
            // 
            // TB_username
            // 
            this.TB_username.CampoBD = "username";
            this.TB_username.Foranea = false;
            this.TB_username.IdCombobox = null;
            this.TB_username.Llenar = false;
            this.TB_username.Location = new System.Drawing.Point(84, 125);
            this.TB_username.Name = "TB_username";
            this.TB_username.Size = new System.Drawing.Size(100, 20);
            this.TB_username.TabIndex = 32;
            this.TB_username.TipoValor = CustomControls.SWTextBox.TipoDato.Texto;
            // 
            // TB_login
            // 
            this.TB_login.CampoBD = "login";
            this.TB_login.Foranea = false;
            this.TB_login.IdCombobox = null;
            this.TB_login.Llenar = false;
            this.TB_login.Location = new System.Drawing.Point(258, 91);
            this.TB_login.Name = "TB_login";
            this.TB_login.Size = new System.Drawing.Size(100, 20);
            this.TB_login.TabIndex = 33;
            this.TB_login.TipoValor = CustomControls.SWTextBox.TipoDato.Numero;
            // 
            // TB_password
            // 
            this.TB_password.CampoBD = "password";
            this.TB_password.Foranea = false;
            this.TB_password.IdCombobox = null;
            this.TB_password.Llenar = false;
            this.TB_password.Location = new System.Drawing.Point(258, 125);
            this.TB_password.Name = "TB_password";
            this.TB_password.Size = new System.Drawing.Size(100, 20);
            this.TB_password.TabIndex = 34;
            this.TB_password.TipoValor = CustomControls.SWTextBox.TipoDato.Numero;
            // 
            // TB_iduserank
            // 
            this.TB_iduserank.CampoBD = "iduserrank";
            this.TB_iduserank.Enabled = false;
            this.TB_iduserank.Foranea = true;
            this.TB_iduserank.IdCombobox = "CB_iduserank";
            this.TB_iduserank.Llenar = false;
            this.TB_iduserank.Location = new System.Drawing.Point(449, 86);
            this.TB_iduserank.Name = "TB_iduserank";
            this.TB_iduserank.Size = new System.Drawing.Size(100, 20);
            this.TB_iduserank.TabIndex = 35;
            this.TB_iduserank.TipoValor = CustomControls.SWTextBox.TipoDato.Numero;
            // 
            // TB_idusercategory
            // 
            this.TB_idusercategory.CampoBD = "idusercategory";
            this.TB_idusercategory.Enabled = false;
            this.TB_idusercategory.Foranea = true;
            this.TB_idusercategory.IdCombobox = "CB_idusercategory";
            this.TB_idusercategory.Llenar = false;
            this.TB_idusercategory.Location = new System.Drawing.Point(460, 126);
            this.TB_idusercategory.Name = "TB_idusercategory";
            this.TB_idusercategory.Size = new System.Drawing.Size(100, 20);
            this.TB_idusercategory.TabIndex = 36;
            this.TB_idusercategory.TipoValor = CustomControls.SWTextBox.TipoDato.Numero;
            // 
            // CB_iduserank
            // 
            this.CB_iduserank.controlID = "TB_iduserank";
            this.CB_iduserank.DisplayMember = "descrank";
            this.CB_iduserank.FormattingEnabled = true;
            this.CB_iduserank.Location = new System.Drawing.Point(449, 86);
            this.CB_iduserank.Name = "CB_iduserank";
            this.CB_iduserank.Size = new System.Drawing.Size(121, 21);
            this.CB_iduserank.TabIndex = 37;
            this.CB_iduserank.taulaBD = "userranks";
            this.CB_iduserank.ValueMember = "iduserrank";
            // 
            // TB_idplanet
            // 
            this.TB_idplanet.CampoBD = "idplanet";
            this.TB_idplanet.Enabled = false;
            this.TB_idplanet.Foranea = true;
            this.TB_idplanet.IdCombobox = "CB_idplanet";
            this.TB_idplanet.Llenar = false;
            this.TB_idplanet.Location = new System.Drawing.Point(647, 127);
            this.TB_idplanet.Name = "TB_idplanet";
            this.TB_idplanet.Size = new System.Drawing.Size(100, 20);
            this.TB_idplanet.TabIndex = 38;
            this.TB_idplanet.TipoValor = CustomControls.SWTextBox.TipoDato.Numero;
            // 
            // CB_idplanet
            // 
            this.CB_idplanet.controlID = "TB_idplanet";
            this.CB_idplanet.DisplayMember = "descplanet";
            this.CB_idplanet.FormattingEnabled = true;
            this.CB_idplanet.Location = new System.Drawing.Point(647, 127);
            this.CB_idplanet.Name = "CB_idplanet";
            this.CB_idplanet.Size = new System.Drawing.Size(121, 21);
            this.CB_idplanet.TabIndex = 39;
            this.CB_idplanet.taulaBD = "planets";
            this.CB_idplanet.ValueMember = "idplanet";
            // 
            // TB_idspecie
            // 
            this.TB_idspecie.CampoBD = "idspecie";
            this.TB_idspecie.Enabled = false;
            this.TB_idspecie.Foranea = true;
            this.TB_idspecie.IdCombobox = "CB_idspecie";
            this.TB_idspecie.Llenar = false;
            this.TB_idspecie.Location = new System.Drawing.Point(848, 90);
            this.TB_idspecie.Name = "TB_idspecie";
            this.TB_idspecie.Size = new System.Drawing.Size(100, 20);
            this.TB_idspecie.TabIndex = 40;
            this.TB_idspecie.TipoValor = CustomControls.SWTextBox.TipoDato.Numero;
            // 
            // CB_idusercategory
            // 
            this.CB_idusercategory.controlID = "TB_idusercategory";
            this.CB_idusercategory.DisplayMember = "desccategory";
            this.CB_idusercategory.FormattingEnabled = true;
            this.CB_idusercategory.Location = new System.Drawing.Point(449, 126);
            this.CB_idusercategory.Name = "CB_idusercategory";
            this.CB_idusercategory.Size = new System.Drawing.Size(121, 21);
            this.CB_idusercategory.TabIndex = 41;
            this.CB_idusercategory.taulaBD = "usercategories";
            this.CB_idusercategory.ValueMember = "idusercategory";
            // 
            // CB_idspecie
            // 
            this.CB_idspecie.controlID = "TB_idspecie";
            this.CB_idspecie.DisplayMember = "descspecie";
            this.CB_idspecie.FormattingEnabled = true;
            this.CB_idspecie.Location = new System.Drawing.Point(839, 91);
            this.CB_idspecie.Name = "CB_idspecie";
            this.CB_idspecie.Size = new System.Drawing.Size(109, 21);
            this.CB_idspecie.TabIndex = 42;
            this.CB_idspecie.taulaBD = "species";
            this.CB_idspecie.ValueMember = "idspecie";
            // 
            // TB_photo
            // 
            this.TB_photo.CampoBD = "photo";
            this.TB_photo.Foranea = false;
            this.TB_photo.IdCombobox = null;
            this.TB_photo.Llenar = false;
            this.TB_photo.Location = new System.Drawing.Point(647, 92);
            this.TB_photo.Name = "TB_photo";
            this.TB_photo.Size = new System.Drawing.Size(100, 20);
            this.TB_photo.TabIndex = 43;
            this.TB_photo.TipoValor = CustomControls.SWTextBox.TipoDato.Texto;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "CodeUser";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "UserName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Login";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(364, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "idUserRank";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(364, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "idUserCategory";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(596, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Photo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(596, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 51;
            this.label8.Text = "idPlanet";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.BD_Users;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(871, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 32);
            this.button1.TabIndex = 52;
            this.button1.Text = "IMPRIMIR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(785, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 53;
            this.label9.Text = "idSpecie";
            // 
            // frm_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(960, 516);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_photo);
            this.Controls.Add(this.CB_idspecie);
            this.Controls.Add(this.TB_idspecie);
            this.Controls.Add(this.CB_iduserank);
            this.Controls.Add(this.TB_iduserank);
            this.Controls.Add(this.TB_password);
            this.Controls.Add(this.TB_login);
            this.Controls.Add(this.TB_username);
            this.Controls.Add(this.TB_codeuser);
            this.Controls.Add(this.CB_idplanet);
            this.Controls.Add(this.TB_idplanet);
            this.Controls.Add(this.CB_idusercategory);
            this.Controls.Add(this.TB_idusercategory);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frm_Users";
            this.taula = "users";
            this.Load += new System.EventHandler(this.frm_Users_Load);
            this.Controls.SetChildIndex(this.TB_idusercategory, 0);
            this.Controls.SetChildIndex(this.CB_idusercategory, 0);
            this.Controls.SetChildIndex(this.TB_idplanet, 0);
            this.Controls.SetChildIndex(this.CB_idplanet, 0);
            this.Controls.SetChildIndex(this.btn_updateDTG, 0);
            this.Controls.SetChildIndex(this.btn_Nou, 0);
            this.Controls.SetChildIndex(this.TB_codeuser, 0);
            this.Controls.SetChildIndex(this.TB_username, 0);
            this.Controls.SetChildIndex(this.TB_login, 0);
            this.Controls.SetChildIndex(this.TB_password, 0);
            this.Controls.SetChildIndex(this.TB_iduserank, 0);
            this.Controls.SetChildIndex(this.CB_iduserank, 0);
            this.Controls.SetChildIndex(this.TB_idspecie, 0);
            this.Controls.SetChildIndex(this.CB_idspecie, 0);
            this.Controls.SetChildIndex(this.TB_photo, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.SWTextBox TB_codeuser;
        private CustomControls.SWTextBox TB_username;
        private CustomControls.SWTextBox TB_login;
        private CustomControls.SWTextBox TB_password;
        private CustomControls.SWTextBox TB_iduserank;
        private CustomControls.SWTextBox TB_idusercategory;
        private CustomControls.ComboBoxFK CB_iduserank;
        private CustomControls.SWTextBox TB_idplanet;
        private CustomControls.ComboBoxFK CB_idplanet;
        private CustomControls.SWTextBox TB_idspecie;
        private CustomControls.ComboBoxFK CB_idusercategory;
        private CustomControls.ComboBoxFK CB_idspecie;
        private CustomControls.SWTextBox TB_photo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource BD_Users;
        protected System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
    }
}
