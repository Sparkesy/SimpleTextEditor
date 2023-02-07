using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace SimpleTextEditor
{
    public partial class SimpleTextEditor : Form
    {
        public SimpleTextEditor()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.RestoreDirectory = true;
            savefile.InitialDirectory = "c:\\";
            savefile.FileName = String.Format("{0}.txt", textBox1.Text);
            savefile.DefaultExt = "*.txt*";
            savefile.Filter = "TEXT Files|*.txt";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(savefile.FileName))
                    sw.WriteLine(textBox1.Text);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = "c:\\";
            openFile.Filter = "text Files (*.txt)|*.txt|All files (*.*)|*.*";
            openFile.FileName = String.Format("{0}.txt", textBox1.Text);
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                {
                    textBox1.Text = System.IO.File.ReadAllText(openFile.FileName);
                }

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exit();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText((string)textBox1.SelectedText);
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText((string)textBox1.SelectedText);

        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //paste button code
            textBox1.Text = Clipboard.GetText();
        }

        
        private void exit()
        {
            // save or discard popup
            DialogResult result = MessageBox.Show("Do you want to save your changes?", "Save", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.RestoreDirectory = true;
                savefile.InitialDirectory = "c:\\";
                savefile.FileName = String.Format("{0}.txt", textBox1.Text);
                savefile.DefaultExt = "*.txt*";
                savefile.Filter = "TEXT Files|*.txt";

                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    using (System.IO.StreamWriter sw = new System.IO.StreamWriter(savefile.FileName))
                        sw.WriteLine(textBox1.Text);
                    Environment.Exit(0);
                }
            }
            else if (result == DialogResult.No)
            {
                Environment.Exit(0);
            }
        }
    

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //print dialog for the text box
            System.Windows.Forms.PrintDialog dlg = new System.Windows.Forms.PrintDialog();
            dlg.ShowDialog();
        }

        private void SimpleTextEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            exit();
        }

        private void fontToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.FontDialog dlg = new System.Windows.Forms.FontDialog();
            dlg.ShowDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = dlg.Font;
                string fontName;
                float fontSize;
                fontName = dlg.Font.Name;
                fontSize = dlg.Font.Size;
                MessageBox.Show(fontName + "    " + fontSize);

            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open the chatgpt form as a dialog
            ChatGPT chatgpt = new ChatGPT();
            chatgpt.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // about program messagebox with icon
            MessageBox.Show("SparkPad v1.0.0.0", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
        }
    }
}
