namespace CompiledReports.UI
{
    partial class AuthorizationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            this.signinBtn = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.registerLnk = new System.Windows.Forms.LinkLabel();
            this.remembermeCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // signinBtn
            // 
            this.signinBtn.Location = new System.Drawing.Point(63, 130);
            this.signinBtn.Name = "signinBtn";
            this.signinBtn.Size = new System.Drawing.Size(127, 40);
            this.signinBtn.TabIndex = 0;
            this.signinBtn.Text = "Sign In";
            this.signinBtn.UseVisualStyleBackColor = true;
            // 
            // login
            // 
            this.login.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.login.Location = new System.Drawing.Point(26, 22);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(164, 20);
            this.login.TabIndex = 2;
            this.login.Text = "Login";
            // 
            // password
            // 
            this.password.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.password.Location = new System.Drawing.Point(26, 62);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(164, 20);
            this.password.TabIndex = 3;
            this.password.Text = "Password";
            // 
            // registerLnk
            // 
            this.registerLnk.Location = new System.Drawing.Point(135, 195);
            this.registerLnk.Name = "registerLnk";
            this.registerLnk.Size = new System.Drawing.Size(55, 13);
            this.registerLnk.TabIndex = 0;
            this.registerLnk.TabStop = true;
            this.registerLnk.Text = "Register";
            this.registerLnk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registerLnk_LinkClicked);
            // 
            // remembermeCheckBox
            // 
            this.remembermeCheckBox.AutoSize = true;
            this.remembermeCheckBox.Location = new System.Drawing.Point(26, 98);
            this.remembermeCheckBox.Name = "remembermeCheckBox";
            this.remembermeCheckBox.Size = new System.Drawing.Size(94, 17);
            this.remembermeCheckBox.TabIndex = 4;
            this.remembermeCheckBox.Text = "Remember me";
            this.remembermeCheckBox.UseVisualStyleBackColor = true;
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 217);
            this.Controls.Add(this.remembermeCheckBox);
            this.Controls.Add(this.registerLnk);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.signinBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AuthorizationForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authorization";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signinBtn;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.LinkLabel registerLnk;
        private System.Windows.Forms.CheckBox remembermeCheckBox;
    }
}

