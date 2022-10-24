using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assignment2_WinFormsApp
{
    public partial class TxtEditorScr : Form
    {

        private String filePath;
        private String usr;
        private UserType perms;
        private LoginSc loginForm;
        public TxtEditorScr(LoginSc oldForm, String usr, UserType perms)
        {
            this.loginForm = oldForm;
            this.usr = usr;
            this.perms = perms;
            InitializeComponent();
        }

        private void TxtEditorScr_Load(object sender, EventArgs e)
        {
            foreach (FontFamily font in new InstalledFontCollection().Families)
            {
                fontToolStripComboBox.Items.Add(font.Name);
            }
            fontToolStripComboBox.Text = editorTextBox.SelectionFont.Name.ToString();

            usrToolStripLbl.Text += this.usr;
        }


        private void openFile()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the path
                    filePath = openFileDialog.FileName;

                    // Read the contents of the file
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        editorTextBox.Text = reader.ReadToEnd();
                    }
                }
            }
        }
        private void newFile()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = "c:\\";
                saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = false;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the path
                    filePath = saveFileDialog.FileName;

                    // write File
                    File.Create(filePath).Close();

                    // clears text
                    editorTextBox.Text = "";
                }
            }
        }

        private void saveFile()
        {
            if (filePath == null)
            {
                saveAsFile();
            }
            else
            {
                File.WriteAllText(filePath, editorTextBox.Text);
            }
        }
        private void saveAsFile()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = "c:\\";
                saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = false;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the path
                    filePath = saveFileDialog.FileName;

                    // write file
                    File.WriteAllText(filePath, editorTextBox.Text);
                }
            }
        }
        private void logout()
        {
            this.Hide();
            loginForm.Show();
        }

        private void showAbout()
        {
            new AboutDlg().ShowDialog();
        }

        #region MenuStrip
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile();
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newFile();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveAsFile();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logout();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(editorTextBox.SelectedRtf);
            editorTextBox.SelectedRtf = "";
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(editorTextBox.SelectedRtf);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editorTextBox.SelectedRtf = Clipboard.GetText();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showAbout();
        }
        #endregion

        #region ToolStrip
        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            newFile();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void saveAsToolStripButton_Click(object sender, EventArgs e)
        {
            saveAsFile();
        }

        private void boldToolStripButton_Click(object sender, EventArgs e)
        {
            FontStyle style = editorTextBox.SelectionFont.Style;

            if (editorTextBox.SelectionFont.Bold)
            {
                style &= ~FontStyle.Bold;
            }
            else
            {
                style |= FontStyle.Bold;
            }

            editorTextBox.SelectionFont = new Font(editorTextBox.SelectionFont, style);
        }

        private void italicsToolStripButton_Click(object sender, EventArgs e)
        {
            FontStyle style = editorTextBox.SelectionFont.Style;

            if (editorTextBox.SelectionFont.Italic)
            {
                style &= ~FontStyle.Italic;
            }
            else
            {
                style |= FontStyle.Italic;
            }

            editorTextBox.SelectionFont = new Font(editorTextBox.SelectionFont, style);
        }

        private void underlineToolStripButton_Click(object sender, EventArgs e)
        {
            FontStyle style = editorTextBox.SelectionFont.Style;

            if (editorTextBox.SelectionFont.Underline)
            {
                style &= ~FontStyle.Underline;
            }
            else
            {
                style |= FontStyle.Underline;
            }

            editorTextBox.SelectionFont = new Font(editorTextBox.SelectionFont, style);
        }
        private void fontToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            editorTextBox.SelectionFont = new Font(fontToolStripComboBox.Text, editorTextBox.SelectionFont.Size);
        }

        private void aboutToolStripButton_Click(object sender, EventArgs e)
        {
            showAbout();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(editorTextBox.SelectedRtf);
            editorTextBox.SelectedRtf = "";
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(editorTextBox.SelectedRtf);
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            editorTextBox.SelectedRtf = Clipboard.GetText();
        }


        #endregion
    }
}
