using System;
using System.Configuration;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FogBugzClient
{
    public partial class LoginForm : Form
    {
        public string Email {
            get { return txtUserName.Text; }
            set { txtUserName.Text = value; } 
        }

        public string Password {
            get { return txtPassword.Text; }
            set { txtPassword.Text = value; } 
        }

        public string Server
        {
            get { return txtServer.Text; }
            set { txtServer.Text = value; }
        }

        public LoginForm()
        {
            InitializeComponent();
        }

        // TODO: Basic input validation (length, etc.)
        // tODO: check that encryption works after restart, and verify decryption failure is handled gracefully

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Server == "")
            {
                Utils.ShowErrorMessage("Unable to determine link to Forgotten Password page.\nPlease configure the server URL", "Not Available");
                return;
            }
            Process.Start(Server + "/default.asp?pg=pgForgotPassword");
        }

        private bool validateTextBoxNotEmpty(TextBox box, string field)
        {
            if (box.Text.Length == 0)
            {
                Utils.ShowErrorMessage("Expecting a non-empty " + field + "...", "Invalid Input");
                return false;
            }
            return true;
        }

        private bool validate()
        {
            if (!validateTextBoxNotEmpty(txtServer, "Server URL")) return false;
            if (!validateTextBoxNotEmpty(txtUserName, "User Name")) return false;
            if (!validateTextBoxNotEmpty(txtPassword, "Password")) return false;

            if (!Uri.IsWellFormedUriString(txtServer.Text, UriKind.Absolute))
            {
                Utils.ShowErrorMessage("The server URL you supplied is not valid: " + txtServer.Text);
                return false;
            }
            return true;
        }

        private void submit()
        {
            if (!validate())
                return;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void anyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                submit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            submit();
        }

    }
}