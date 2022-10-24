using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Assignment2_WinFormsApp
{
    public partial class NewUsrScr : Form
    {
        private List<String> users = new List<String>();
        private const String loginPath = "../../../login.txt";

        public NewUsrScr()
        {
            InitializeComponent();
        }

        private void NewUsrScr_Load(object sender, EventArgs e)
        {
            String[] logDoc = System.IO.File.ReadAllText(loginPath).Split("\n");
            foreach (String line in logDoc)
            {
                users.Add(line.Split(",")[0]);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            if ((usrTxtBx.Text != "") && (passTxtBx.Text != "") && (fnTxtBx.Text != "") && (lnTxtBx.Text != "") && (typeComboBox.SelectedIndex != -1))
            {
                if (!users.Contains(usrTxtBx.Text))
                {
                    if (passTxtBx.Text == passConfirmTxtBx.Text)
                    {
                        errorLbl.Text = "";
                        String newUsr = usrTxtBx.Text + "," + passTxtBx.Text + "," + typeComboBox.Text + "," + fnTxtBx.Text + "," + lnTxtBx.Text + "," + dobPicker.Text;
                        using (StreamWriter sw = new StreamWriter(loginPath,true))
                        {
                            sw.WriteLine(newUsr);
                        }
                        this.Close();
                    }
                    else
                    {
                        errorLbl.Text = "Error: Passwords do not match";
                    }
                }
                else
                {
                    errorLbl.Text = "Error: username already taken";
                }
            }
            else
            {
                errorLbl.Text = "Error: Enter all Details";
            }
        }
    }
}
