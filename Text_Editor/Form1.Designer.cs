namespace Text_Editor
{
    partial class Form1
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
            this.txtEditor = new System.Windows.Forms.TextBox();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBold = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItalic = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuIUnderline = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSizeFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFormatSmallSize = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFormatMediumSize = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFormatLargeSize = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEditor
            // 
            this.txtEditor.Location = new System.Drawing.Point(12, 40);
            this.txtEditor.Multiline = true;
            this.txtEditor.Name = "txtEditor";
            this.txtEditor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEditor.Size = new System.Drawing.Size(979, 581);
            this.txtEditor.TabIndex = 0;
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuFormat});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(994, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNew,
            this.openToolStripMenuItem,
            this.mnuSave,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuNew
            // 
            this.mnuNew.Name = "mnuNew";
            this.mnuNew.Size = new System.Drawing.Size(180, 22);
            this.mnuNew.Text = "&New";
            this.mnuNew.Click += new System.EventHandler(this.mnuNew_Click);
            // 
            // mnuSave
            // 
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(180, 22);
            this.mnuSave.Text = "&Save";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(180, 22);
            this.mnuExit.Text = "&Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuFormat
            // 
            this.mnuFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBold,
            this.mnuItalic,
            this.mnuIUnderline,
            this.mnuSizeFormat});
            this.mnuFormat.Name = "mnuFormat";
            this.mnuFormat.Size = new System.Drawing.Size(57, 20);
            this.mnuFormat.Text = "F&ormat";
            // 
            // mnuBold
            // 
            this.mnuBold.Name = "mnuBold";
            this.mnuBold.Size = new System.Drawing.Size(180, 22);
            this.mnuBold.Text = "&Bold";
            this.mnuBold.Click += new System.EventHandler(this.mnuBold_Click);
            // 
            // mnuItalic
            // 
            this.mnuItalic.Name = "mnuItalic";
            this.mnuItalic.Size = new System.Drawing.Size(180, 22);
            this.mnuItalic.Text = "&Italic";
            this.mnuItalic.Click += new System.EventHandler(this.mnuItalic_Click);
            // 
            // mnuIUnderline
            // 
            this.mnuIUnderline.Name = "mnuIUnderline";
            this.mnuIUnderline.Size = new System.Drawing.Size(180, 22);
            this.mnuIUnderline.Text = "&Underline";
            this.mnuIUnderline.Click += new System.EventHandler(this.mnuIUnderline_Click);
            // 
            // mnuSizeFormat
            // 
            this.mnuSizeFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFormatSmallSize,
            this.mnuFormatMediumSize,
            this.mnuFormatLargeSize});
            this.mnuSizeFormat.Name = "mnuSizeFormat";
            this.mnuSizeFormat.Size = new System.Drawing.Size(180, 22);
            this.mnuSizeFormat.Text = "Si&ze";
            // 
            // mnuFormatSmallSize
            // 
            this.mnuFormatSmallSize.Checked = true;
            this.mnuFormatSmallSize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuFormatSmallSize.Name = "mnuFormatSmallSize";
            this.mnuFormatSmallSize.Size = new System.Drawing.Size(180, 22);
            this.mnuFormatSmallSize.Text = "&Small";
            this.mnuFormatSmallSize.Click += new System.EventHandler(this.mnuSizeFormat_Click);
            // 
            // mnuFormatMediumSize
            // 
            this.mnuFormatMediumSize.Name = "mnuFormatMediumSize";
            this.mnuFormatMediumSize.Size = new System.Drawing.Size(180, 22);
            this.mnuFormatMediumSize.Text = "&Medium";
            // 
            // mnuFormatLargeSize
            // 
            this.mnuFormatLargeSize.Name = "mnuFormatLargeSize";
            this.mnuFormatLargeSize.Size = new System.Drawing.Size(180, 22);
            this.mnuFormatLargeSize.Text = "&Large";
            // 
            // dlgOpen
            // 
            this.dlgOpen.FileName = "openFileDialog1";
            this.dlgOpen.Filter = "Text Files (*.txt)|*.txt";
            this.dlgOpen.Title = "Open File";
            // 
            // dlgSave
            // 
            this.dlgSave.Filter = "Text Files (*.txt)|*.txt";
            this.dlgSave.Title = "Save File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.mnuFileOpen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 633);
            this.Controls.Add(this.txtEditor);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "Form1";
            this.Text = "Text Editor";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEditor;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuNew;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuFormat;
        private System.Windows.Forms.ToolStripMenuItem mnuBold;
        private System.Windows.Forms.ToolStripMenuItem mnuItalic;
        private System.Windows.Forms.ToolStripMenuItem mnuIUnderline;
        private System.Windows.Forms.ToolStripMenuItem mnuSizeFormat;
        private System.Windows.Forms.ToolStripMenuItem mnuFormatSmallSize;
        private System.Windows.Forms.ToolStripMenuItem mnuFormatMediumSize;
        private System.Windows.Forms.ToolStripMenuItem mnuFormatLargeSize;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.SaveFileDialog dlgSave;
    }
}

