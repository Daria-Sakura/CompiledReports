using CompiledReports.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompiledReports.UI
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private string preFocusedValue = String.Empty;
        private string focusedTextBoxName = String.Empty;

        private void registerLnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.FormClosed += new FormClosedEventHandler(registrationForm_FormClosed);
            registrationForm.Show();
        }

        private void registrationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {
            login.GotFocus += txtBox_OnFocus;
            login.LostFocus += txtBox_OnFocusLost;
            login.Text = GeneralSettings.Default.Login;

            password.GotFocus += txtBox_OnFocus;
            password.LostFocus += txtBox_OnFocusLost;
            password.Text = GeneralSettings.Default.Password;

            remembermeCheckBox.Checked = GeneralSettings.Default.IsRememberMe;
        }

        private void txtBox_OnFocusLost(object sender, EventArgs e)
        {
            TextBox txtBox = (TextBox)sender;
            if (txtBox.Text == String.Empty)
            {
                txtBox.Text = txtBox.Name.First().ToString().ToUpper() + String.Join(String.Empty, txtBox.Name.Skip(1));
                txtBox.ForeColor = SystemColors.InactiveCaption;
            }
        }

        private void txtBox_OnFocus(object sender, EventArgs e)
        {
            TextBox txtBox = (TextBox)sender;
            preFocusedValue = txtBox.Text;
            if( Enum.IsDefined(typeof(Placeholders), preFocusedValue) )
            {
                txtBox.Text = String.Empty;
                txtBox.ForeColor = SystemColors.ControlText;
            }
        }

        private void AuthorizationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            GeneralSettings.Default.IsRememberMe = remembermeCheckBox.Checked;
            if (remembermeCheckBox.Checked)
            {
                GeneralSettings.Default.Login = login.Text;
                GeneralSettings.Default.Password = CryptoHelper.GetMd5Hash(password.Text);
            }
            else
            {
                GeneralSettings.Default.Login = Placeholders.Login.ToString();//.ToDescription();
                GeneralSettings.Default.Password = Placeholders.Password.ToString();//ToDescription();
            }
            GeneralSettings.Default.Save();
        }
    }
}
