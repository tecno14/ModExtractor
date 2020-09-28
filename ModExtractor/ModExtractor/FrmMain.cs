using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ModExtractor
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        #region FoldersDialog
        private void BtnModedGame_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog ofd = new FolderBrowserDialog())
            {
                if (DialogResult.OK != ofd.ShowDialog(this))
                    return;
                TbModedGame.Text = ofd.SelectedPath;
            }
        }

        private void BtnSoucreGame_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog ofd = new FolderBrowserDialog())
            {
                if (DialogResult.OK != ofd.ShowDialog(this))
                    return;
                TbOrginalGame.Text = ofd.SelectedPath;
            }
        }

        private void BtnDestinationMod_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog ofd = new FolderBrowserDialog())
            {
                if (DialogResult.OK != ofd.ShowDialog(this))
                    return;
                TbDestinationMod.Text = ofd.SelectedPath;
            }
        }
        #endregion

        private void BtnStartMoveModFiles_Click(object sender, EventArgs e)
        {
            new FrmProcess(TbModedGame.Text, TbOrginalGame.Text, TbDestinationMod.Text).ShowDialog();
        }
    }
}

