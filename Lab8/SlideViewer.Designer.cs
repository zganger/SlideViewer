namespace Lab8
{
    partial class SlideViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenCollection = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveCollection = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.FileList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Delete = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Show = new System.Windows.Forms.Button();
            this.Interval = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(496, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenCollection,
            this.SaveCollection,
            this.Exit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // OpenCollection
            // 
            this.OpenCollection.Name = "OpenCollection";
            this.OpenCollection.Size = new System.Drawing.Size(160, 22);
            this.OpenCollection.Text = "&Open Collection";
            this.OpenCollection.Click += new System.EventHandler(this.openCollection_Click);
            // 
            // SaveCollection
            // 
            this.SaveCollection.Name = "SaveCollection";
            this.SaveCollection.Size = new System.Drawing.Size(160, 22);
            this.SaveCollection.Text = "&Save Collection";
            this.SaveCollection.Click += new System.EventHandler(this.saveCollection_Click);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(160, 22);
            this.Exit.Text = "&Exit";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // FileList
            // 
            this.FileList.FormattingEnabled = true;
            this.FileList.Location = new System.Drawing.Point(33, 27);
            this.FileList.Name = "FileList";
            this.FileList.Size = new System.Drawing.Size(432, 95);
            this.FileList.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Delete);
            this.groupBox1.Controls.Add(this.Add);
            this.groupBox1.Location = new System.Drawing.Point(33, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 38);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(104, 10);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(90, 23);
            this.Delete.TabIndex = 1;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(6, 10);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(92, 23);
            this.Add.TabIndex = 0;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Show
            // 
            this.Show.Location = new System.Drawing.Point(375, 138);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(90, 23);
            this.Show.TabIndex = 3;
            this.Show.Text = "Show";
            this.Show.UseVisualStyleBackColor = true;
            this.Show.Click += new System.EventHandler(this.Show_Click);
            // 
            // Interval
            // 
            this.Interval.Location = new System.Drawing.Point(239, 140);
            this.Interval.Name = "Interval";
            this.Interval.Size = new System.Drawing.Size(130, 20);
            this.Interval.TabIndex = 4;
            this.Interval.Text = "Interval";
            this.Interval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Interval.Click += new System.EventHandler(this.Interval_Click);
            this.Interval.TextChanged += new System.EventHandler(this.Interval_TextChanged);
            // 
            // SlideViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 173);
            this.Controls.Add(this.Interval);
            this.Controls.Add(this.Show);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FileList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SlideViewer";
            this.Text = "Slide Viewer";
            this.Click += new System.EventHandler(this.SlideViewer_Click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenCollection;
        private System.Windows.Forms.ToolStripMenuItem SaveCollection;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        public System.Windows.Forms.ListBox FileList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Show;
        private System.Windows.Forms.TextBox Interval;
    }
}

