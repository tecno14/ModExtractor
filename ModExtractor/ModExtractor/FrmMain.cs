using System;
using System.Windows.Forms;

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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.buymeacoffee.com/EmisaTec");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/tecno14/ModExtractor");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.fb.com/EmisaTec");
        }
    }
}

