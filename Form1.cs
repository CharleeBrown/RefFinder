using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Office.Interop.Excel;
using ReferencesFind;

namespace ReferFind
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            refList.SelectionMode = SelectionMode.MultiSimple;
        }
        List<string> newAdd = new List<string>();
        private void sendBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Word Document|*.docx";
            
            if(file.ShowDialog() == DialogResult.OK)
            {
                refList.Items.Clear();
                FileInfo info = new FileInfo(file.FileName);
                title.Text = info.Name;
                title.Enabled = false;
                fileText.Text = info.FullName;
                findRef references = new findRef();
                foreach (string item in references.Finder(fileText.Text))
                {
                        refList.Items.Add(item);
                }
            }
        }
     
        private void Form1_Load(object sender, EventArgs e)
        {}
        private void refList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                System.Text.StringBuilder copy_buffer = new System.Text.StringBuilder();
                foreach (object item in refList.SelectedItems)
                    copy_buffer.AppendLine(item.ToString());
                if (copy_buffer.Length > 0)
                    Clipboard.SetText(copy_buffer.ToString());
            }
        }
    }
}
