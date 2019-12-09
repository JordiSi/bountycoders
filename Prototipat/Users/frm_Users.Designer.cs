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
        private void InitializeComponent()
        {
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
            this.SuspendLayout();
            // 
            // TB_codeuser
            // 
            this.TB_codeuser.CampoBD = "codeuser";
            this.TB_codeuser.Foranea = false;
            this.TB_codeuser.IdCombobox = null;
            this.TB_codeuser.Llenar = false;
            this.TB_codeuser.Location = new System.Drawing.Point(64, 87);
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
            this.TB_username.Location = new System.Drawing.Point(64, 127);
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
            this.TB_login.Location = new System.Drawing.Point(195, 87);
            this.TB_login.Name = "TB_login";
            this.TB_login.Size = new System.Drawing.Size(100, 20);
            this.TB_login.TabIndex = 33;
            this.TB_login.TipoValor = CustomControls.SWTextBox.TipoDato.Texto;
            // 
            // TB_password
            // 
            this.TB_password.CampoBD = "password";
            this.TB_password.Foranea = false;
            this.TB_password.IdCombobox = null;
            this.TB_password.Llenar = false;
            this.TB_password.Location = new System.Drawing.Point(195, 127);
            this.TB_password.Name = "TB_password";
            this.TB_password.Size = new System.Drawing.Size(100, 20);
            this.TB_password.TabIndex = 34;
            this.TB_password.TipoValor = CustomControls.SWTextBox.TipoDato.Texto;
            // 
            // TB_iduserank
            // 
            this.TB_iduserank.CampoBD = "iduserrank";
            this.TB_iduserank.Foranea = false;
            this.TB_iduserank.IdCombobox = "CB_iduserank";
            this.TB_iduserank.Llenar = false;
            this.TB_iduserank.Location = new System.Drawing.Point(337, 62);
            this.TB_iduserank.Name = "TB_iduserank";
            this.TB_iduserank.Size = new System.Drawing.Size(100, 20);
            this.TB_iduserank.TabIndex = 35;
            this.TB_iduserank.TipoValor = CustomControls.SWTextBox.TipoDato.Numero;
            // 
            // TB_idusercategory
            // 
            this.TB_idusercategory.CampoBD = "idusercategory";
            this.TB_idusercategory.Foranea = false;
            this.TB_idusercategory.IdCombobox = "CB_idusercategory";
            this.TB_idusercategory.Llenar = false;
            this.TB_idusercategory.Location = new System.Drawing.Point(337, 149);
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
            this.CB_iduserank.Location = new System.Drawing.Point(326, 88);
            this.CB_iduserank.Name = "CB_iduserank";
            this.CB_iduserank.Size = new System.Drawing.Size(121, 21);
            this.CB_iduserank.TabIndex = 37;
            this.CB_iduserank.taulaBD = "userranks";
            this.CB_iduserank.ValueMember = "iduserrank";
            // 
            // TB_idplanet
            // 
            this.TB_idplanet.CampoBD = "idplanet";
            this.TB_idplanet.Foranea = false;
            this.TB_idplanet.IdCombobox = "CB_idplanet";
            this.TB_idplanet.Llenar = false;
            this.TB_idplanet.Location = new System.Drawing.Point(467, 149);
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
            this.CB_idplanet.Location = new System.Drawing.Point(467, 126);
            this.CB_idplanet.Name = "CB_idplanet";
            this.CB_idplanet.Size = new System.Drawing.Size(121, 21);
            this.CB_idplanet.TabIndex = 39;
            this.CB_idplanet.taulaBD = "planets";
            this.CB_idplanet.ValueMember = "idplanet";
            // 
            // TB_idspecie
            // 
            this.TB_idspecie.CampoBD = "idspecie";
            this.TB_idspecie.Foranea = true;
            this.TB_idspecie.IdCombobox = "CB_idspecie";
            this.TB_idspecie.Llenar = false;
            this.TB_idspecie.Location = new System.Drawing.Point(594, 62);
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
            this.CB_idusercategory.Location = new System.Drawing.Point(326, 126);
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
            this.CB_idspecie.Location = new System.Drawing.Point(594, 88);
            this.CB_idspecie.Name = "CB_idspecie";
            this.CB_idspecie.Size = new System.Drawing.Size(121, 21);
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
            this.TB_photo.Location = new System.Drawing.Point(467, 89);
            this.TB_photo.Name = "TB_photo";
            this.TB_photo.Size = new System.Drawing.Size(100, 20);
            this.TB_photo.TabIndex = 43;
            this.TB_photo.TipoValor = CustomControls.SWTextBox.TipoDato.Texto;
            // 
            // frm_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(960, 516);
            this.Controls.Add(this.TB_photo);
            this.Controls.Add(this.CB_idspecie);
            this.Controls.Add(this.CB_idusercategory);
            this.Controls.Add(this.TB_idspecie);
            this.Controls.Add(this.CB_idplanet);
            this.Controls.Add(this.TB_idplanet);
            this.Controls.Add(this.CB_iduserank);
            this.Controls.Add(this.TB_idusercategory);
            this.Controls.Add(this.TB_iduserank);
            this.Controls.Add(this.TB_password);
            this.Controls.Add(this.TB_login);
            this.Controls.Add(this.TB_username);
            this.Controls.Add(this.TB_codeuser);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frm_Users";
            this.taula = "users";
            this.Controls.SetChildIndex(this.btn_updateDTG, 0);
            this.Controls.SetChildIndex(this.btn_Nou, 0);
            this.Controls.SetChildIndex(this.TB_codeuser, 0);
            this.Controls.SetChildIndex(this.TB_username, 0);
            this.Controls.SetChildIndex(this.TB_login, 0);
            this.Controls.SetChildIndex(this.TB_password, 0);
            this.Controls.SetChildIndex(this.TB_iduserank, 0);
            this.Controls.SetChildIndex(this.TB_idusercategory, 0);
            this.Controls.SetChildIndex(this.CB_iduserank, 0);
            this.Controls.SetChildIndex(this.TB_idplanet, 0);
            this.Controls.SetChildIndex(this.CB_idplanet, 0);
            this.Controls.SetChildIndex(this.TB_idspecie, 0);
            this.Controls.SetChildIndex(this.CB_idusercategory, 0);
            this.Controls.SetChildIndex(this.CB_idspecie, 0);
            this.Controls.SetChildIndex(this.TB_photo, 0);
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
    }
}
