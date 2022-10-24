using Microsoft.VisualBasic.ApplicationServices;

namespace Assignment2_WinFormsApp
{
    public partial class LoginSc : Form
    {
        private List<String[]> users;

        private const String loginPath = "../../../login.txt";
        public LoginSc()
        {
            InitializeComponent();
        }
        private void LoginSc_Load(object sender, EventArgs e)
        {
            loadCreds();
        }

        private void loadCreds()
        {
            users = new List<String[]>();
            String[] logDoc = File.ReadAllText(loginPath).Split("\n");
            foreach (String line in logDoc)
            {
                users.Add(line.Split(","));
            }
        }

        #region Buttons
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void loginBtn_Click(object sender, EventArgs e)
        {
            loadCreds();
            Boolean invalid = true;
            foreach (String[] user in users)
            {
                if ((user[0] == usrTextBox.Text) && (user[1] == passTextBox.Text))
                {
                    invalid = false;
                    Enum.TryParse(user[2], out UserType userType);
                    TxtEditorScr editor = new TxtEditorScr(this, user[0], userType);
                    this.Hide();
                    editor.Closed += (s, args) => this.Close();
                    editor.Show();
                    passTextBox.Text = "";
                    break;
                }
            }
            if(invalid)
            {
                errorLbl.Text = "Invalid Credentials";
            }
            else
            {
                errorLbl.Text = "";
            }


            
        }

        private void newUsrBtn_Click(object sender, EventArgs e)
        {
            new NewUsrScr().ShowDialog();
        }

        #endregion
    }
}