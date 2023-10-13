namespace ModExtractor
{
    partial class FrmMain
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
            this.BtnModedGame = new System.Windows.Forms.Button();
            this.TbModedGame = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnSoucreGame = new System.Windows.Forms.Button();
            this.TbOrginalGame = new System.Windows.Forms.TextBox();
            this.TbDestinationMod = new System.Windows.Forms.TextBox();
            this.BtnDestinationMod = new System.Windows.Forms.Button();
            this.BtnStartMoveModFiles = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnModedGame
            // 
            this.BtnModedGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnModedGame.Location = new System.Drawing.Point(442, 46);
            this.BtnModedGame.Name = "BtnModedGame";
            this.BtnModedGame.Size = new System.Drawing.Size(40, 20);
            this.BtnModedGame.TabIndex = 0;
            this.BtnModedGame.Text = "...";
            this.BtnModedGame.UseVisualStyleBackColor = true;
            this.BtnModedGame.Click += new System.EventHandler(this.BtnModedGame_Click);
            // 
            // TbModedGame
            // 
            this.TbModedGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TbModedGame.Location = new System.Drawing.Point(93, 46);
            this.TbModedGame.Name = "TbModedGame";
            this.TbModedGame.Size = new System.Drawing.Size(325, 20);
            this.TbModedGame.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Modded game";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Original game";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Destination Mod";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.linkLabel2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.TbDestinationMod, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.BtnDestinationMod, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.BtnStartMoveModFiles, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.TbOrginalGame, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnSoucreGame, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TbModedGame, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnModedGame, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.linkLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.78947F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.05263F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.05263F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.05263F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.05263F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(503, 218);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // BtnSoucreGame
            // 
            this.BtnSoucreGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSoucreGame.Location = new System.Drawing.Point(442, 91);
            this.BtnSoucreGame.Name = "BtnSoucreGame";
            this.BtnSoucreGame.Size = new System.Drawing.Size(40, 20);
            this.BtnSoucreGame.TabIndex = 5;
            this.BtnSoucreGame.Text = "...";
            this.BtnSoucreGame.UseVisualStyleBackColor = true;
            this.BtnSoucreGame.Click += new System.EventHandler(this.BtnSoucreGame_Click);
            // 
            // TbOrginalGame
            // 
            this.TbOrginalGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TbOrginalGame.Location = new System.Drawing.Point(93, 91);
            this.TbOrginalGame.Name = "TbOrginalGame";
            this.TbOrginalGame.Size = new System.Drawing.Size(325, 20);
            this.TbOrginalGame.TabIndex = 3;
            // 
            // TbDestinationMod
            // 
            this.TbDestinationMod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TbDestinationMod.Location = new System.Drawing.Point(93, 136);
            this.TbDestinationMod.Name = "TbDestinationMod";
            this.TbDestinationMod.Size = new System.Drawing.Size(325, 20);
            this.TbDestinationMod.TabIndex = 4;
            // 
            // BtnDestinationMod
            // 
            this.BtnDestinationMod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnDestinationMod.Location = new System.Drawing.Point(442, 136);
            this.BtnDestinationMod.Name = "BtnDestinationMod";
            this.BtnDestinationMod.Size = new System.Drawing.Size(40, 20);
            this.BtnDestinationMod.TabIndex = 6;
            this.BtnDestinationMod.Text = "...";
            this.BtnDestinationMod.UseVisualStyleBackColor = true;
            this.BtnDestinationMod.Click += new System.EventHandler(this.BtnDestinationMod_Click);
            // 
            // BtnStartMoveModFiles
            // 
            this.BtnStartMoveModFiles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnStartMoveModFiles.Font = new System.Drawing.Font("Tahoma", 9F);
            this.BtnStartMoveModFiles.Location = new System.Drawing.Point(181, 178);
            this.BtnStartMoveModFiles.Name = "BtnStartMoveModFiles";
            this.BtnStartMoveModFiles.Size = new System.Drawing.Size(149, 30);
            this.BtnStartMoveModFiles.TabIndex = 7;
            this.BtnStartMoveModFiles.Text = "Move Mod Files";
            this.BtnStartMoveModFiles.UseVisualStyleBackColor = true;
            this.BtnStartMoveModFiles.Click += new System.EventHandler(this.BtnStartMoveModFiles_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label4.Location = new System.Drawing.Point(187, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "wael.had.sy@gmail.com";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.linkLabel1.Location = new System.Drawing.Point(21, 10);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(47, 14);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Donate";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.linkLabel2.Location = new System.Drawing.Point(424, 10);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(76, 14);
            this.linkLabel2.TabIndex = 10;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Source code";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 218);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModExtractor v1.3";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnModedGame;
        private System.Windows.Forms.TextBox TbModedGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BtnSoucreGame;
        private System.Windows.Forms.TextBox TbOrginalGame;
        private System.Windows.Forms.TextBox TbDestinationMod;
        private System.Windows.Forms.Button BtnDestinationMod;
        private System.Windows.Forms.Button BtnStartMoveModFiles;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}

