namespace MACusercontrol
{
    partial class Usercontrol
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usercontrol));
            this.btnlogin = new System.Windows.Forms.Button();
            this.btnclean = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txbxuser = new System.Windows.Forms.TextBox();
            this.txbxpassword = new System.Windows.Forms.TextBox();
            this.Lnkpassword = new System.Windows.Forms.LinkLabel();
            this.err_user = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_password = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.err_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_password)).BeginInit();
            this.SuspendLayout();
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Location = new System.Drawing.Point(353, 338);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(94, 35);
            this.btnlogin.TabIndex = 0;
            this.btnlogin.Text = "LOGIN";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btnclean
            // 
            this.btnclean.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnclean.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclean.Location = new System.Drawing.Point(584, 211);
            this.btnclean.Name = "btnclean";
            this.btnclean.Size = new System.Drawing.Size(98, 35);
            this.btnclean.TabIndex = 1;
            this.btnclean.Text = "CLEAN";
            this.btnclean.UseVisualStyleBackColor = false;
            this.btnclean.Click += new System.EventHandler(this.btnclean_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox1.Location = new System.Drawing.Point(357, 269);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(116, 20);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Remember me";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblUser.Location = new System.Drawing.Point(287, 173);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(49, 16);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "USER";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblPassword.Location = new System.Drawing.Point(242, 212);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(94, 16);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "PASSWORD";
            // 
            // txbxuser
            // 
            this.txbxuser.Location = new System.Drawing.Point(350, 173);
            this.txbxuser.Name = "txbxuser";
            this.txbxuser.Size = new System.Drawing.Size(134, 20);
            this.txbxuser.TabIndex = 5;
            this.txbxuser.Validating += new System.ComponentModel.CancelEventHandler(this.txbxuser_Validating);
            // 
            // txbxpassword
            // 
            this.txbxpassword.Location = new System.Drawing.Point(350, 211);
            this.txbxpassword.Name = "txbxpassword";
            this.txbxpassword.PasswordChar = '*';
            this.txbxpassword.Size = new System.Drawing.Size(134, 20);
            this.txbxpassword.TabIndex = 6;
            this.txbxpassword.Text = "\r\n";
            this.txbxpassword.Validating += new System.ComponentModel.CancelEventHandler(this.txbxpassword_Validating);
            // 
            // Lnkpassword
            // 
            this.Lnkpassword.ActiveLinkColor = System.Drawing.Color.GhostWhite;
            this.Lnkpassword.AutoSize = true;
            this.Lnkpassword.BackColor = System.Drawing.Color.Transparent;
            this.Lnkpassword.LinkColor = System.Drawing.Color.Navy;
            this.Lnkpassword.LinkVisited = true;
            this.Lnkpassword.Location = new System.Drawing.Point(360, 244);
            this.Lnkpassword.Name = "Lnkpassword";
            this.Lnkpassword.Size = new System.Drawing.Size(114, 13);
            this.Lnkpassword.TabIndex = 7;
            this.Lnkpassword.TabStop = true;
            this.Lnkpassword.Text = "Forgot your password?";
            this.Lnkpassword.VisitedLinkColor = System.Drawing.Color.White;
            this.Lnkpassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Lnkpassword_LinkClicked);
            // 
            // err_user
            // 
            this.err_user.ContainerControl = this;
            // 
            // err_password
            // 
            this.err_password.ContainerControl = this;
            // 
            // Usercontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MACusercontrol.Properties.Resources.MAC_LOGIN;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lnkpassword);
            this.Controls.Add(this.txbxpassword);
            this.Controls.Add(this.txbxuser);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnclean);
            this.Controls.Add(this.btnlogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Usercontrol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Miguel Angel Cruz Olmedo | 27-2723-2025";
            ((System.ComponentModel.ISupportInitialize)(this.err_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_password)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnclean;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txbxuser;
        private System.Windows.Forms.TextBox txbxpassword;
        private System.Windows.Forms.LinkLabel Lnkpassword;
        private System.Windows.Forms.ErrorProvider err_user;
        private System.Windows.Forms.ErrorProvider err_password;
    }
}

