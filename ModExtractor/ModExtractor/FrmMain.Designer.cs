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
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnModedGame
            // 
            this.BtnModedGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnModedGame.Location = new System.Drawing.Point(403, 10);
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
            this.TbModedGame.Location = new System.Drawing.Point(93, 10);
            this.TbModedGame.Name = "TbModedGame";
            this.TbModedGame.Size = new System.Drawing.Size(304, 20);
            this.TbModedGame.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Moded Game";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Orginal Game";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 133);
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
            this.tableLayoutPanel1.Controls.Add(this.BtnSoucreGame, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnModedGame, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.TbModedGame, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TbOrginalGame, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TbDestinationMod, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.BtnDestinationMod, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.BtnStartMoveModFiles, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(446, 204);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // BtnSoucreGame
            // 
            this.BtnSoucreGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSoucreGame.Location = new System.Drawing.Point(403, 50);
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
            this.TbOrginalGame.Location = new System.Drawing.Point(93, 50);
            this.TbOrginalGame.Name = "TbOrginalGame";
            this.TbOrginalGame.Size = new System.Drawing.Size(304, 20);
            this.TbOrginalGame.TabIndex = 3;
            // 
            // TbDestinationMod
            // 
            this.TbDestinationMod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TbDestinationMod.Location = new System.Drawing.Point(93, 130);
            this.TbDestinationMod.Name = "TbDestinationMod";
            this.TbDestinationMod.Size = new System.Drawing.Size(304, 20);
            this.TbDestinationMod.TabIndex = 4;
            // 
            // BtnDestinationMod
            // 
            this.BtnDestinationMod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnDestinationMod.Location = new System.Drawing.Point(403, 130);
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
            this.BtnStartMoveModFiles.Location = new System.Drawing.Point(170, 167);
            this.BtnStartMoveModFiles.Name = "BtnStartMoveModFiles";
            this.BtnStartMoveModFiles.Size = new System.Drawing.Size(149, 30);
            this.BtnStartMoveModFiles.TabIndex = 7;
            this.BtnStartMoveModFiles.Text = "StartMove Mod Files";
            this.BtnStartMoveModFiles.UseVisualStyleBackColor = true;
            this.BtnStartMoveModFiles.Click += new System.EventHandler(this.BtnStartMoveModFiles_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "wael.had.sy@gmail.com\r\n2020";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 204);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModExtractor";
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
    }
}

