namespace RA.SearchAndReplaceAllText
{
    partial class FrmSearch
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnStopSearch = new System.Windows.Forms.Button();
            this.chkCaseSensitive = new System.Windows.Forms.CheckBox();
            this.txtPreview = new System.Windows.Forms.TextBox();
            this.btnReplaceAll = new System.Windows.Forms.Button();
            this.btnFindAll = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnFindNext = new System.Windows.Forms.Button();
            this.gbSearchIn = new System.Windows.Forms.GroupBox();
            this.chkFileDirectoriesNames = new System.Windows.Forms.CheckBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.txtSearchFilter = new System.Windows.Forms.TextBox();
            this.chkSubdiretories = new System.Windows.Forms.CheckBox();
            this.btnSearchDirectory = new System.Windows.Forms.Button();
            this.txtSearchDirectory = new System.Windows.Forms.TextBox();
            this.rbtnDirectory = new System.Windows.Forms.RadioButton();
            this.btnSearchFile = new System.Windows.Forms.Button();
            this.txtSearchFile = new System.Windows.Forms.TextBox();
            this.rbtnFile = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReplace = new System.Windows.Forms.TextBox();
            this.txtMessages = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbSearchIn.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnStopSearch);
            this.splitContainer1.Panel1.Controls.Add(this.chkCaseSensitive);
            this.splitContainer1.Panel1.Controls.Add(this.txtPreview);
            this.splitContainer1.Panel1.Controls.Add(this.btnReplaceAll);
            this.splitContainer1.Panel1.Controls.Add(this.btnFindAll);
            this.splitContainer1.Panel1.Controls.Add(this.btnReplace);
            this.splitContainer1.Panel1.Controls.Add(this.btnFindNext);
            this.splitContainer1.Panel1.Controls.Add(this.gbSearchIn);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtMessages);
            this.splitContainer1.Size = new System.Drawing.Size(783, 567);
            this.splitContainer1.SplitterDistance = 468;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnStopSearch
            // 
            this.btnStopSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStopSearch.Enabled = false;
            this.btnStopSearch.Location = new System.Drawing.Point(531, 432);
            this.btnStopSearch.Name = "btnStopSearch";
            this.btnStopSearch.Size = new System.Drawing.Size(240, 23);
            this.btnStopSearch.TabIndex = 8;
            this.btnStopSearch.Text = "Stop search";
            this.btnStopSearch.UseVisualStyleBackColor = true;
            this.btnStopSearch.Click += new System.EventHandler(this.btnStopSearch_Click);
            // 
            // chkCaseSensitive
            // 
            this.chkCaseSensitive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkCaseSensitive.AutoSize = true;
            this.chkCaseSensitive.Location = new System.Drawing.Point(531, 157);
            this.chkCaseSensitive.Name = "chkCaseSensitive";
            this.chkCaseSensitive.Size = new System.Drawing.Size(96, 17);
            this.chkCaseSensitive.TabIndex = 2;
            this.chkCaseSensitive.Text = "Case Sensitive";
            this.chkCaseSensitive.UseVisualStyleBackColor = true;
            // 
            // txtPreview
            // 
            this.txtPreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPreview.BackColor = System.Drawing.SystemColors.Window;
            this.txtPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreview.Location = new System.Drawing.Point(531, 238);
            this.txtPreview.Multiline = true;
            this.txtPreview.Name = "txtPreview";
            this.txtPreview.ReadOnly = true;
            this.txtPreview.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPreview.Size = new System.Drawing.Size(240, 130);
            this.txtPreview.TabIndex = 5;
            // 
            // btnReplaceAll
            // 
            this.btnReplaceAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReplaceAll.Location = new System.Drawing.Point(531, 403);
            this.btnReplaceAll.Name = "btnReplaceAll";
            this.btnReplaceAll.Size = new System.Drawing.Size(240, 23);
            this.btnReplaceAll.TabIndex = 7;
            this.btnReplaceAll.Text = "Replace all";
            this.btnReplaceAll.UseVisualStyleBackColor = true;
            this.btnReplaceAll.Click += new System.EventHandler(this.btnReplaceAll_Click);
            // 
            // btnFindAll
            // 
            this.btnFindAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFindAll.Location = new System.Drawing.Point(531, 374);
            this.btnFindAll.Name = "btnFindAll";
            this.btnFindAll.Size = new System.Drawing.Size(240, 23);
            this.btnFindAll.TabIndex = 6;
            this.btnFindAll.Text = "Find all";
            this.btnFindAll.UseVisualStyleBackColor = true;
            this.btnFindAll.Click += new System.EventHandler(this.btnFindAll_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReplace.Location = new System.Drawing.Point(531, 209);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(240, 23);
            this.btnReplace.TabIndex = 4;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnFindNext
            // 
            this.btnFindNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFindNext.Location = new System.Drawing.Point(531, 180);
            this.btnFindNext.Name = "btnFindNext";
            this.btnFindNext.Size = new System.Drawing.Size(240, 23);
            this.btnFindNext.TabIndex = 3;
            this.btnFindNext.Text = "Find next";
            this.btnFindNext.UseVisualStyleBackColor = true;
            this.btnFindNext.Click += new System.EventHandler(this.btnFindNext_Click);
            // 
            // gbSearchIn
            // 
            this.gbSearchIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSearchIn.Controls.Add(this.chkFileDirectoriesNames);
            this.gbSearchIn.Controls.Add(this.lblFilter);
            this.gbSearchIn.Controls.Add(this.txtSearchFilter);
            this.gbSearchIn.Controls.Add(this.chkSubdiretories);
            this.gbSearchIn.Controls.Add(this.btnSearchDirectory);
            this.gbSearchIn.Controls.Add(this.txtSearchDirectory);
            this.gbSearchIn.Controls.Add(this.rbtnDirectory);
            this.gbSearchIn.Controls.Add(this.btnSearchFile);
            this.gbSearchIn.Controls.Add(this.txtSearchFile);
            this.gbSearchIn.Controls.Add(this.rbtnFile);
            this.gbSearchIn.Location = new System.Drawing.Point(531, 12);
            this.gbSearchIn.Name = "gbSearchIn";
            this.gbSearchIn.Size = new System.Drawing.Size(240, 139);
            this.gbSearchIn.TabIndex = 1;
            this.gbSearchIn.TabStop = false;
            this.gbSearchIn.Text = "Search in:";
            // 
            // chkFileDirectoriesNames
            // 
            this.chkFileDirectoriesNames.AutoSize = true;
            this.chkFileDirectoriesNames.Location = new System.Drawing.Point(7, 115);
            this.chkFileDirectoriesNames.Name = "chkFileDirectoriesNames";
            this.chkFileDirectoriesNames.Size = new System.Drawing.Size(179, 17);
            this.chkFileDirectoriesNames.TabIndex = 9;
            this.chkFileDirectoriesNames.Text = "Search in files/directories names";
            this.chkFileDirectoriesNames.UseVisualStyleBackColor = true;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Enabled = false;
            this.lblFilter.Location = new System.Drawing.Point(26, 69);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(32, 13);
            this.lblFilter.TabIndex = 6;
            this.lblFilter.Text = "Filter:";
            // 
            // txtSearchFilter
            // 
            this.txtSearchFilter.Enabled = false;
            this.txtSearchFilter.Location = new System.Drawing.Point(74, 66);
            this.txtSearchFilter.Name = "txtSearchFilter";
            this.txtSearchFilter.Size = new System.Drawing.Size(128, 20);
            this.txtSearchFilter.TabIndex = 7;
            this.txtSearchFilter.Text = "*.*";
            // 
            // chkSubdiretories
            // 
            this.chkSubdiretories.AutoSize = true;
            this.chkSubdiretories.Checked = true;
            this.chkSubdiretories.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSubdiretories.Enabled = false;
            this.chkSubdiretories.Location = new System.Drawing.Point(7, 92);
            this.chkSubdiretories.Name = "chkSubdiretories";
            this.chkSubdiretories.Size = new System.Drawing.Size(139, 17);
            this.chkSubdiretories.TabIndex = 8;
            this.chkSubdiretories.Text = "Search in subdirectories";
            this.chkSubdiretories.UseVisualStyleBackColor = true;
            // 
            // btnSearchDirectory
            // 
            this.btnSearchDirectory.Enabled = false;
            this.btnSearchDirectory.Location = new System.Drawing.Point(208, 40);
            this.btnSearchDirectory.Name = "btnSearchDirectory";
            this.btnSearchDirectory.Size = new System.Drawing.Size(26, 23);
            this.btnSearchDirectory.TabIndex = 5;
            this.btnSearchDirectory.Text = "...";
            this.btnSearchDirectory.UseVisualStyleBackColor = true;
            this.btnSearchDirectory.Click += new System.EventHandler(this.btnSearchDirectory_Click);
            // 
            // txtSearchDirectory
            // 
            this.txtSearchDirectory.Enabled = false;
            this.txtSearchDirectory.Location = new System.Drawing.Point(74, 43);
            this.txtSearchDirectory.Name = "txtSearchDirectory";
            this.txtSearchDirectory.Size = new System.Drawing.Size(128, 20);
            this.txtSearchDirectory.TabIndex = 4;
            // 
            // rbtnDirectory
            // 
            this.rbtnDirectory.AutoSize = true;
            this.rbtnDirectory.Location = new System.Drawing.Point(7, 43);
            this.rbtnDirectory.Name = "rbtnDirectory";
            this.rbtnDirectory.Size = new System.Drawing.Size(67, 17);
            this.rbtnDirectory.TabIndex = 3;
            this.rbtnDirectory.Text = "Directory";
            this.rbtnDirectory.UseVisualStyleBackColor = true;
            // 
            // btnSearchFile
            // 
            this.btnSearchFile.Location = new System.Drawing.Point(208, 17);
            this.btnSearchFile.Name = "btnSearchFile";
            this.btnSearchFile.Size = new System.Drawing.Size(26, 23);
            this.btnSearchFile.TabIndex = 2;
            this.btnSearchFile.Text = "...";
            this.btnSearchFile.UseVisualStyleBackColor = true;
            this.btnSearchFile.Click += new System.EventHandler(this.btnSearchFile_Click);
            // 
            // txtSearchFile
            // 
            this.txtSearchFile.Location = new System.Drawing.Point(74, 20);
            this.txtSearchFile.Name = "txtSearchFile";
            this.txtSearchFile.Size = new System.Drawing.Size(128, 20);
            this.txtSearchFile.TabIndex = 1;
            // 
            // rbtnFile
            // 
            this.rbtnFile.AutoSize = true;
            this.rbtnFile.Checked = true;
            this.rbtnFile.Location = new System.Drawing.Point(7, 20);
            this.rbtnFile.Name = "rbtnFile";
            this.rbtnFile.Size = new System.Drawing.Size(41, 17);
            this.rbtnFile.TabIndex = 0;
            this.rbtnFile.TabStop = true;
            this.rbtnFile.Text = "File";
            this.rbtnFile.UseVisualStyleBackColor = true;
            this.rbtnFile.CheckedChanged += new System.EventHandler(this.rbtnFile_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.splitContainer2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 443);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 16);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.txtFind);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Panel2.Controls.Add(this.txtReplace);
            this.splitContainer2.Size = new System.Drawing.Size(506, 424);
            this.splitContainer2.SplitterDistance = 249;
            this.splitContainer2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find:";
            // 
            // txtFind
            // 
            this.txtFind.AcceptsReturn = true;
            this.txtFind.AcceptsTab = true;
            this.txtFind.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFind.Location = new System.Drawing.Point(1, 19);
            this.txtFind.Multiline = true;
            this.txtFind.Name = "txtFind";
            this.txtFind.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFind.Size = new System.Drawing.Size(246, 402);
            this.txtFind.TabIndex = 1;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Replace with:";
            // 
            // txtReplace
            // 
            this.txtReplace.AcceptsReturn = true;
            this.txtReplace.AcceptsTab = true;
            this.txtReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReplace.Location = new System.Drawing.Point(3, 19);
            this.txtReplace.Multiline = true;
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtReplace.Size = new System.Drawing.Size(246, 402);
            this.txtReplace.TabIndex = 1;
            // 
            // txtMessages
            // 
            this.txtMessages.BackColor = System.Drawing.SystemColors.Window;
            this.txtMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMessages.Location = new System.Drawing.Point(0, 0);
            this.txtMessages.Multiline = true;
            this.txtMessages.Name = "txtMessages";
            this.txtMessages.ReadOnly = true;
            this.txtMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessages.Size = new System.Drawing.Size(783, 95);
            this.txtMessages.TabIndex = 0;
            // 
            // FrmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 567);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmSearch";
            this.Text = "Search And Replace All Text";
            this.Load += new System.EventHandler(this.FrmSearch_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbSearchIn.ResumeLayout(false);
            this.gbSearchIn.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMessages;
        private System.Windows.Forms.GroupBox gbSearchIn;
        private System.Windows.Forms.RadioButton rbtnFile;
        private System.Windows.Forms.Button btnSearchFile;
        private System.Windows.Forms.TextBox txtSearchFile;
        private System.Windows.Forms.Button btnSearchDirectory;
        private System.Windows.Forms.TextBox txtSearchDirectory;
        private System.Windows.Forms.RadioButton rbtnDirectory;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.TextBox txtSearchFilter;
        private System.Windows.Forms.CheckBox chkSubdiretories;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReplace;
        private System.Windows.Forms.Button btnFindNext;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnReplaceAll;
        private System.Windows.Forms.Button btnFindAll;
        private System.Windows.Forms.TextBox txtPreview;
        private System.Windows.Forms.CheckBox chkCaseSensitive;
        private System.Windows.Forms.CheckBox chkFileDirectoriesNames;
        private System.Windows.Forms.Button btnStopSearch;
    }
}

