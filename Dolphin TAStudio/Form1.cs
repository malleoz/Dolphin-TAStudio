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

namespace Dolphin_TAStudio
{
    public partial class Form1 : Form
    {
        private DataTable table = new DataTable();
        private string fileName;
        private bool changed = false;
        private int frameCount;
        public Form1()
        {
            InitializeComponent();
            // Disable menu buttons when no data is loaded
            copyToolStripMenuItem.Enabled = false;
            pasteToolStripMenuItem.Enabled = false;
            saveToolStripMenuItem.Enabled = false;
            saveAsToolStripMenuItem.Enabled = false;
            undoToolStripMenuItem.Enabled = false;
            redoToolStripMenuItem.Enabled = false;
        }

        private void openData(string fileLocation)
        {
            // Read from file and assert that it is formatted properly
            using (StreamReader reader = new StreamReader(fileLocation))
            {
                string data = reader.ReadLine();
                frameCount = 0;

                while (!reader.EndOfStream)
                {
                    // TODO: Implement parser
                }
            }
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Implement save before closing
            // if (changed)....

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                clearDataTable();
                fileName = openFileDialog1.FileName;
                openData(fileName);
            }
        }

        private void clearDataTable()
        {
            table.Columns.Clear();
            table.Clear();
            undoToolStripMenuItem.Enabled = false;
            fileName = null;
            changed = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pasteCtrlVToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
