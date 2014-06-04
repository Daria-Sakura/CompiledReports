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
            resources.ApplyResources(this.signinBtn, "signinBtn");
            this.signinBtn.Name = "signinBtn";
            this.signinBtn.UseVisualStyleBackColor = true;
            // 
            // login
            // 
            resources.ApplyResources(this.login, "login");
            this.login.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.login.Name = "login";
            // 
            // password
            // 
            resources.ApplyResources(this.password, "password");
            this.password.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.password.Name = "password";
            // 
            // registerLnk
            // 
            resources.ApplyResources(this.registerLnk, "registerLnk");
            this.registerLnk.Name = "registerLnk";
            this.registerLnk.TabStop = true;
            this.registerLnk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registerLnk_LinkClicked);
            // 
            // remembermeCheckBox
            // 
            resources.ApplyResources(this.remembermeCheckBox, "remembermeCheckBox");
            this.remembermeCheckBox.Name = "remembermeCheckBox";
            this.remembermeCheckBox.UseVisualStyleBackColor = true;
            // 
            // AuthorizationForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.remembermeCheckBox);
            this.Controls.Add(this.registerLnk);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.signinBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AuthorizationForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AuthorizationForm_FormClosing);
            this.Load += new System.EventHandler(this.AuthorizationForm_Load);
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

