using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;


namespace FileManager
{
    public partial class Form1 : Form
    {

        DirectoryInfo listViewRoot = null;
        public Form1()
        {
            InitializeComponent();
            InitializeListView();
        }

        public Form1(string[] args)
        {
            InitializeComponent();
            FillView(new DirectoryInfo(args[0]));
        }

        private void listView_DoubleClick(object sender, EventArgs e)
        {
            var selected = listView.SelectedItems[0];
            if (selected.ImageIndex != (int)EntryType.FOLDER && selected.ImageIndex != (int)EntryType.DRIVE)
            {
                try
                {
                    System.Diagnostics.Process.Start(selected.SubItems[1].Text);
                }
                catch (Exception expt)
                {
                    MessageBox.Show(expt.Message);
                }
            }
            else
                FillView(new DirectoryInfo(selected.SubItems[1].Text));

        }

        private void InitializeListView()
        {
            txtCurPath.Text = "Drives";
            listViewRoot = null;
            foreach (var drive in DriveInfo.GetDrives())
                AddEntry(drive.RootDirectory);
            
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblUp_Click(object sender, EventArgs e)
        {
            if (listViewRoot != null)
            {
                var di = listViewRoot.Parent;
                if (di != null && di.Exists)
                {
                    FillView(di);
                }
                else
                {
                    listView.Items.Clear();
                    InitializeListView();
                }
            }
        }

        private void FillView(DirectoryInfo root)
        {
            listView.Items.Clear();
            try
            {
                listViewRoot = root;
                //var entries = (from dir in root.GetFileSystemInfos() where !isHidden(dir) select dir);
                var entries = new List<FileSystemInfo>();
                foreach (var dir in root.GetDirectories().Where(dir => !Funcs.isHidden(dir)))
                    entries.Add(dir);
                foreach (var file in root.GetFiles().Where(file => !Funcs.isHidden(file)))
                    entries.Add(file);
                foreach (var entry in entries)
                    AddEntry(entry);
                txtCurPath.Text = root.FullName;
            }
            catch (Exception expt)
            {
                MessageBox.Show(expt.Message);
            }
        }

        private void AddEntry(FileSystemInfo fsi)
        {
            var lvi = new ListViewItem(fsi.Name);
            lvi.SubItems.Add(fsi.FullName);
            lvi.ImageIndex = (int)Funcs.TypeOf(fsi);
            listView.Items.Add(lvi);
        }

        private void detailsView_Click(object sender, EventArgs e)
        {
            listView.View = View.Details;
        }

        private void smallIconsView_Click(object sender, EventArgs e)
        {
            listView.View = View.SmallIcon;
        }

        private void largeIcons_Click(object sender, EventArgs e)
        {
            listView.View = View.LargeIcon;
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView.View = View.Details;
        }

        private void largeIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView.View = View.LargeIcon;
        }

        private void smallIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView.View = View.SmallIcon;
        }

        private void close_App(object sender, EventArgs e)
        {
            Close();
        }

        bool pressed = false;
        int X, Y;

        private void toolStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            if (pressed)
            {
                SetDesktopLocation(MousePosition.X - X, MousePosition.Y - Y);
            }
        }

        private void toolStrip1_MouseUp(object sender, MouseEventArgs e)
        {
            pressed = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (pressed)
            {
                SetDesktopLocation(MousePosition.X - X, MousePosition.Y - Y);
            }
        }

        private void toolStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            pressed = true;
            X = e.X;
            Y = e.Y;
        }
    }
}
