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

namespace Lab8
{
    public partial class SlideViewer : Form
    {
        public string openCollectionFileName;
        public int interval = 1; //1s default
        public SlideViewer()
        {
            InitializeComponent();
        }

        private void Interval_Click(object sender, EventArgs e)
        {
            if(Interval.Text == "Interval")
            {
                Interval.Text = "";
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (Interval.Text == "") { Interval.Text = "1"; }
            if(FileList.Items.Count == 0)
            {
                MessageBox.Show("No files to remove", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < FileList.SelectedItems.Count; i++)
            {
                FileList.Items.Remove(FileList.SelectedItems[i]);
            }
        }
         
        private void Add_Click(object sender, EventArgs e)
        {
            if (Interval.Text == "") { Interval.Text = "1"; }
            OpenFileDialog newImage = new OpenFileDialog();
            if (newImage.ShowDialog() != DialogResult.OK) return;
            string[] toAdd = newImage.FileNames;
            for (int i = 0; i < toAdd.Length; i++)
            {
                FileList.Items.Add(toAdd[i]);
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveCollection_Click(object sender, EventArgs e)
        {
            if (Interval.Text == "") { Interval.Text = "1"; }
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = " | *.pix";
            saveDialog.DefaultExt = "pix";

            if (FileList.Items.Count == 0)
            {
                MessageBox.Show("No file names to save.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            if (openCollectionFileName == null)
                saveDialog.FileName = null;
            else
                saveDialog.FileName = openCollectionFileName;

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(saveDialog.OpenFile());
                foreach (string item in FileList.Items)
                {
                    streamWriter.WriteLine(item);
                }
                streamWriter.Close();
            }
        }

        private void openCollection_Click(object sender, EventArgs e)
        {
            if (Interval.Text == "") { Interval.Text = "1"; }
            OpenFileDialog openCollection = new OpenFileDialog();
            openCollection.Filter = " | *.pix";
            openCollection.FilterIndex = 1;

            if (openCollection.ShowDialog() == DialogResult.OK)
            {
                FileList.Items.Clear();
                openCollectionFileName = openCollection.FileName;
                StreamReader openStream = new StreamReader(openCollection.OpenFile());
                while (true)
                {
                    string currentLine = openStream.ReadLine();
                    if (currentLine == null) break;
                    FileList.Items.Add(currentLine);
                }
                openStream.Close();
            }
        }

        private void Interval_TextChanged(object sender, EventArgs e)
        {
            bool isInt =  int.TryParse(Interval.Text, out interval);
            if(isInt)
            {
                try
                {
                    interval = Convert.ToInt32(Interval.Text);
                    if (interval <= 0 || interval > 99) throw new Exception();
                }
                catch
                {
                    MessageBox.Show("Please enter a valid integer time interval greater than 0 or less than 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                if (Interval.Text != "" && Interval.Text != "Interval")
                {
                    MessageBox.Show("Please enter a valid integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Interval.Text = "1";
                    interval = 1;
                    return;
                }
            }
        }

        private void SlideViewer_Click(object sender, EventArgs e)
        {
            if (Interval.Text == "") { Interval.Text = "1"; }
        }

        private void Show_Click(object sender, EventArgs e)
        {
            
            if (FileList.Items.Count == 0)
            {
                MessageBox.Show("No images to show.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (Interval.Text == "") { Interval.Text = "1"; }
                return;
            }
            if (Interval.Text == "") { Interval.Text = "1"; }
            (new Slides() { Owner = this }).ShowDialog();
        }
    }
}
