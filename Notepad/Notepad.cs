using System.Windows.Forms;

namespace Notepad
{
    public partial class Notepad : Form
    {
        private string fileName = null;
        public Notepad()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Text = String.Empty;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
               textBox.Text = File.ReadAllText(openFileDialog.FileName);
                fileName = openFileDialog.FileName;
            }
           
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fileName))ss
            {

            
                saveFileDialog.DefaultExt = ".txt";
                saveFileDialog.Filter = "Text File|*.txt";
                DialogResult dr = saveFileDialog.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, textBox.Text);
                }

                return;
            }
            
                File.WriteAllText(fileName, textBox.Text);
        }
    }
}