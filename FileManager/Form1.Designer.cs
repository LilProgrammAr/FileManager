namespace FileManager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.smallImageList = new System.Windows.Forms.ImageList(this.components);
            this.listView = new System.Windows.Forms.ListView();
            this.clmName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.largeImageList = new System.Windows.Forms.ImageList(this.components);
            this.txtCurPath = new System.Windows.Forms.TextBox();
            this.lblUp = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.largeIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTool = new System.Windows.Forms.ToolStripDropDownButton();
            this.detailsView = new System.Windows.Forms.ToolStripMenuItem();
            this.smallIconsView = new System.Windows.Forms.ToolStripMenuItem();
            this.largeIcons = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // smallImageList
            // 
            this.smallImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("smallImageList.ImageStream")));
            this.smallImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.smallImageList.Images.SetKeyName(0, "folder_small_icon.png");
            this.smallImageList.Images.SetKeyName(1, "archive_small_icon.png");
            this.smallImageList.Images.SetKeyName(2, "file_small_icon.png");
            this.smallImageList.Images.SetKeyName(3, "exe_small_icon.png");
            this.smallImageList.Images.SetKeyName(4, "image_small_icon.png");
            this.smallImageList.Images.SetKeyName(5, "drive_small_icon.png");
            this.smallImageList.Images.SetKeyName(6, "txt_small_icon.png");
            // 
            // listView
            // 
            this.listView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmName,
            this.clmPath});
            this.listView.LargeImageList = this.largeImageList;
            this.listView.Location = new System.Drawing.Point(0, 79);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(498, 459);
            this.listView.SmallImageList = this.smallImageList;
            this.listView.TabIndex = 4;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.DoubleClick += new System.EventHandler(this.listView_DoubleClick);
            // 
            // clmName
            // 
            this.clmName.Text = "Name";
            this.clmName.Width = 137;
            // 
            // clmPath
            // 
            this.clmPath.Text = "Path";
            this.clmPath.Width = 402;
            // 
            // largeImageList
            // 
            this.largeImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("largeImageList.ImageStream")));
            this.largeImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.largeImageList.Images.SetKeyName(0, "folder_large_icon.png");
            this.largeImageList.Images.SetKeyName(1, "archive_large_icon.png");
            this.largeImageList.Images.SetKeyName(2, "file_large_icon.png");
            this.largeImageList.Images.SetKeyName(3, "exe_large_icon.png");
            this.largeImageList.Images.SetKeyName(4, "image_large_icon.png");
            this.largeImageList.Images.SetKeyName(5, "drive_large_icon.png");
            this.largeImageList.Images.SetKeyName(6, "txt_large_icon.png");
            // 
            // txtCurPath
            // 
            this.txtCurPath.Location = new System.Drawing.Point(1, 53);
            this.txtCurPath.Name = "txtCurPath";
            this.txtCurPath.Size = new System.Drawing.Size(497, 20);
            this.txtCurPath.TabIndex = 8;
            // 
            // lblUp
            // 
            this.lblUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lblUp.Name = "lblUp";
            this.lblUp.Size = new System.Drawing.Size(16, 22);
            this.lblUp.Text = "toolStripLabel1";
            this.lblUp.Click += new System.EventHandler(this.lblUp_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton2,
            this.toolStripDropDownButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(974, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStrip1_MouseDown);
            this.toolStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.toolStrip1_MouseMove);
            this.toolStrip1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.toolStrip1_MouseUp);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(38, 22);
            this.toolStripDropDownButton2.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.close_App);
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detailsToolStripMenuItem,
            this.largeIconToolStripMenuItem,
            this.smallIconsToolStripMenuItem});
            this.toolStripDropDownButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton3.Image")));
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(45, 22);
            this.toolStripDropDownButton3.Text = "View";
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.detailsToolStripMenuItem.Text = "Details";
            this.detailsToolStripMenuItem.Click += new System.EventHandler(this.detailsToolStripMenuItem_Click);
            // 
            // largeIconToolStripMenuItem
            // 
            this.largeIconToolStripMenuItem.Name = "largeIconToolStripMenuItem";
            this.largeIconToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.largeIconToolStripMenuItem.Text = "Large icons";
            this.largeIconToolStripMenuItem.Click += new System.EventHandler(this.largeIconToolStripMenuItem_Click);
            // 
            // smallIconsToolStripMenuItem
            // 
            this.smallIconsToolStripMenuItem.Name = "smallIconsToolStripMenuItem";
            this.smallIconsToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.smallIconsToolStripMenuItem.Text = "Small icons";
            this.smallIconsToolStripMenuItem.Click += new System.EventHandler(this.smallIconsToolStripMenuItem_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip2.Location = new System.Drawing.Point(1, 25);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(28, 25);
            this.toolStrip2.TabIndex = 10;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripLabel1.Image = global::FileManager.Properties.Resources.up_icon;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(16, 22);
            this.toolStripLabel1.Text = "lblUp";
            this.toolStripLabel1.Click += new System.EventHandler(this.lblUp_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::FileManager.Properties.Resources.close_icon;
            this.btnClose.Location = new System.Drawing.Point(944, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 11;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.close_App);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(38, 22);
            this.toolStripDropDownButton1.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.closeToolStripMenuItem.Text = "Exit";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // viewTool
            // 
            this.viewTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.viewTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detailsView,
            this.smallIconsView,
            this.largeIcons});
            this.viewTool.Image = ((System.Drawing.Image)(resources.GetObject("viewTool.Image")));
            this.viewTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.viewTool.Name = "viewTool";
            this.viewTool.Size = new System.Drawing.Size(45, 22);
            this.viewTool.Text = "View";
            // 
            // detailsView
            // 
            this.detailsView.Name = "detailsView";
            this.detailsView.Size = new System.Drawing.Size(134, 22);
            this.detailsView.Text = "Details";
            this.detailsView.Click += new System.EventHandler(this.detailsView_Click);
            // 
            // smallIconsView
            // 
            this.smallIconsView.Name = "smallIconsView";
            this.smallIconsView.Size = new System.Drawing.Size(134, 22);
            this.smallIconsView.Text = "Small icons";
            this.smallIconsView.Click += new System.EventHandler(this.smallIconsView_Click);
            // 
            // largeIcons
            // 
            this.largeIcons.Name = "largeIcons";
            this.largeIcons.Size = new System.Drawing.Size(134, 22);
            this.largeIcons.Text = "Large icons";
            this.largeIcons.Click += new System.EventHandler(this.largeIcons_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(974, 649);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtCurPath);
            this.Controls.Add(this.listView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File manager";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList smallImageList;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader clmName;
        private System.Windows.Forms.ColumnHeader clmPath;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel lblUp;
        private System.Windows.Forms.TextBox txtCurPath;
        private System.Windows.Forms.ToolStripDropDownButton viewTool;
        private System.Windows.Forms.ToolStripMenuItem detailsView;
        private System.Windows.Forms.ToolStripMenuItem smallIconsView;
        private System.Windows.Forms.ToolStripMenuItem largeIcons;
        private System.Windows.Forms.ImageList largeImageList;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem largeIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smallIconsToolStripMenuItem;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

