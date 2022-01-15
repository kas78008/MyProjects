using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoCodec
{
    public partial class Form1 : Form
    {
        string strFullPathNameFileIn;
        string strFolderNameOut;
        string strFileName;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnFileOpen_Click(object sender, EventArgs e)
        {
           openFileDialog1.InitialDirectory = "c:\\";
           openFileDialog1.Filter = "All files (*.*)|*.*";
           openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            strFullPathNameFileIn = filename;
            txtbxFulNameFile.Text = strFullPathNameFileIn;

        }

        private void btnFolderSave_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = "c:\\";
            if (folderBrowserDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            strFolderNameOut = folderBrowserDialog1.SelectedPath;
            //  MessageBox.Show(strFolderNameOut);
            txtbxFolderNameOut.Text = strFolderNameOut;

        }
    }
}

