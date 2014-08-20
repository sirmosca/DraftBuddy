namespace DraftBuddy
{
    partial class DraftBuddy
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
            this.UxGroupBoxView = new System.Windows.Forms.GroupBox();
            this.UxRadioButtonWatch = new System.Windows.Forms.RadioButton();
            this.UxRadioButtonPk = new System.Windows.Forms.RadioButton();
            this.UxRadioButtonAll = new System.Windows.Forms.RadioButton();
            this.UxRadioButtonDef = new System.Windows.Forms.RadioButton();
            this.UxRadioButtonTe = new System.Windows.Forms.RadioButton();
            this.UxRadioButtonWrRb = new System.Windows.Forms.RadioButton();
            this.UxRadioButtonWr = new System.Windows.Forms.RadioButton();
            this.UxRadioButtonRb = new System.Windows.Forms.RadioButton();
            this.UxRadioButtonQB = new System.Windows.Forms.RadioButton();
            this.UxDataGridView = new System.Windows.Forms.DataGridView();
            this.UxTextBoxSearch = new System.Windows.Forms.TextBox();
            this.UxCheckBoxShowDrafted = new System.Windows.Forms.CheckBox();
            this.UxFantasyTeamViewButton = new System.Windows.Forms.Button();
            this.UxFantasyTeamContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showOnlyMyTeamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllTeamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showNoTeamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.UxFantasyTeamNameTextBox = new System.Windows.Forms.TextBox();
            this.UxGroupBoxView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UxDataGridView)).BeginInit();
            this.UxFantasyTeamContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // UxGroupBoxView
            // 
            this.UxGroupBoxView.Controls.Add(this.UxRadioButtonWatch);
            this.UxGroupBoxView.Controls.Add(this.UxRadioButtonPk);
            this.UxGroupBoxView.Controls.Add(this.UxRadioButtonAll);
            this.UxGroupBoxView.Controls.Add(this.UxRadioButtonDef);
            this.UxGroupBoxView.Controls.Add(this.UxRadioButtonTe);
            this.UxGroupBoxView.Controls.Add(this.UxRadioButtonWrRb);
            this.UxGroupBoxView.Controls.Add(this.UxRadioButtonWr);
            this.UxGroupBoxView.Controls.Add(this.UxRadioButtonRb);
            this.UxGroupBoxView.Controls.Add(this.UxRadioButtonQB);
            this.UxGroupBoxView.Location = new System.Drawing.Point(8, 139);
            this.UxGroupBoxView.Name = "UxGroupBoxView";
            this.UxGroupBoxView.Size = new System.Drawing.Size(105, 228);
            this.UxGroupBoxView.TabIndex = 0;
            this.UxGroupBoxView.TabStop = false;
            this.UxGroupBoxView.Text = "View";
            // 
            // UxRadioButtonWatch
            // 
            this.UxRadioButtonWatch.AutoSize = true;
            this.UxRadioButtonWatch.Location = new System.Drawing.Point(7, 206);
            this.UxRadioButtonWatch.Name = "UxRadioButtonWatch";
            this.UxRadioButtonWatch.Size = new System.Drawing.Size(57, 17);
            this.UxRadioButtonWatch.TabIndex = 8;
            this.UxRadioButtonWatch.Text = "Watch";
            this.UxRadioButtonWatch.UseVisualStyleBackColor = true;
            this.UxRadioButtonWatch.Click += new System.EventHandler(this.UxRadioButtonWatchClick);
            // 
            // UxRadioButtonPk
            // 
            this.UxRadioButtonPk.AutoSize = true;
            this.UxRadioButtonPk.Location = new System.Drawing.Point(7, 182);
            this.UxRadioButtonPk.Name = "UxRadioButtonPk";
            this.UxRadioButtonPk.Size = new System.Drawing.Size(39, 17);
            this.UxRadioButtonPk.TabIndex = 7;
            this.UxRadioButtonPk.Text = "PK";
            this.UxRadioButtonPk.UseVisualStyleBackColor = true;
            this.UxRadioButtonPk.Click += new System.EventHandler(this.UxRadioButtonPkClick);
            // 
            // UxRadioButtonAll
            // 
            this.UxRadioButtonAll.AutoSize = true;
            this.UxRadioButtonAll.Checked = true;
            this.UxRadioButtonAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UxRadioButtonAll.Location = new System.Drawing.Point(7, 20);
            this.UxRadioButtonAll.Name = "UxRadioButtonAll";
            this.UxRadioButtonAll.Size = new System.Drawing.Size(39, 17);
            this.UxRadioButtonAll.TabIndex = 0;
            this.UxRadioButtonAll.TabStop = true;
            this.UxRadioButtonAll.Text = "All";
            this.UxRadioButtonAll.UseVisualStyleBackColor = true;
            this.UxRadioButtonAll.Click += new System.EventHandler(this.UxRadioButtonAllClick);
            // 
            // UxRadioButtonDef
            // 
            this.UxRadioButtonDef.AutoSize = true;
            this.UxRadioButtonDef.Location = new System.Drawing.Point(7, 158);
            this.UxRadioButtonDef.Name = "UxRadioButtonDef";
            this.UxRadioButtonDef.Size = new System.Drawing.Size(46, 17);
            this.UxRadioButtonDef.TabIndex = 6;
            this.UxRadioButtonDef.Text = "DEF";
            this.UxRadioButtonDef.UseVisualStyleBackColor = true;
            this.UxRadioButtonDef.Click += new System.EventHandler(this.UxRadioButtonDefClick);
            // 
            // UxRadioButtonTe
            // 
            this.UxRadioButtonTe.AutoSize = true;
            this.UxRadioButtonTe.Location = new System.Drawing.Point(7, 135);
            this.UxRadioButtonTe.Name = "UxRadioButtonTe";
            this.UxRadioButtonTe.Size = new System.Drawing.Size(39, 17);
            this.UxRadioButtonTe.TabIndex = 5;
            this.UxRadioButtonTe.Text = "TE";
            this.UxRadioButtonTe.UseVisualStyleBackColor = true;
            this.UxRadioButtonTe.Click += new System.EventHandler(this.UxRadioButtonTeClick);
            // 
            // UxRadioButtonWrRb
            // 
            this.UxRadioButtonWrRb.AutoSize = true;
            this.UxRadioButtonWrRb.Location = new System.Drawing.Point(7, 112);
            this.UxRadioButtonWrRb.Name = "UxRadioButtonWrRb";
            this.UxRadioButtonWrRb.Size = new System.Drawing.Size(64, 17);
            this.UxRadioButtonWrRb.TabIndex = 4;
            this.UxRadioButtonWrRb.Text = "WR\\RB";
            this.UxRadioButtonWrRb.UseVisualStyleBackColor = true;
            this.UxRadioButtonWrRb.Click += new System.EventHandler(this.UxRadioButtonWrRbClick);
            // 
            // UxRadioButtonWr
            // 
            this.UxRadioButtonWr.AutoSize = true;
            this.UxRadioButtonWr.Location = new System.Drawing.Point(7, 89);
            this.UxRadioButtonWr.Name = "UxRadioButtonWr";
            this.UxRadioButtonWr.Size = new System.Drawing.Size(44, 17);
            this.UxRadioButtonWr.TabIndex = 3;
            this.UxRadioButtonWr.Text = "WR";
            this.UxRadioButtonWr.UseVisualStyleBackColor = true;
            this.UxRadioButtonWr.Click += new System.EventHandler(this.UxRadioButtonWrClick);
            // 
            // UxRadioButtonRb
            // 
            this.UxRadioButtonRb.AutoSize = true;
            this.UxRadioButtonRb.Location = new System.Drawing.Point(7, 66);
            this.UxRadioButtonRb.Name = "UxRadioButtonRb";
            this.UxRadioButtonRb.Size = new System.Drawing.Size(40, 17);
            this.UxRadioButtonRb.TabIndex = 2;
            this.UxRadioButtonRb.Text = "RB";
            this.UxRadioButtonRb.UseVisualStyleBackColor = true;
            this.UxRadioButtonRb.Click += new System.EventHandler(this.UxRadioButtonRbClick);
            // 
            // UxRadioButtonQB
            // 
            this.UxRadioButtonQB.AutoSize = true;
            this.UxRadioButtonQB.Location = new System.Drawing.Point(7, 43);
            this.UxRadioButtonQB.Name = "UxRadioButtonQB";
            this.UxRadioButtonQB.Size = new System.Drawing.Size(40, 17);
            this.UxRadioButtonQB.TabIndex = 1;
            this.UxRadioButtonQB.Text = "QB";
            this.UxRadioButtonQB.UseVisualStyleBackColor = true;
            this.UxRadioButtonQB.Click += new System.EventHandler(this.UxRadioButtonQbClick);
            // 
            // UxDataGridView
            // 
            this.UxDataGridView.AllowUserToAddRows = false;
            this.UxDataGridView.AllowUserToDeleteRows = false;
            this.UxDataGridView.AllowUserToOrderColumns = true;
            this.UxDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UxDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UxDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UxDataGridView.Location = new System.Drawing.Point(119, 38);
            this.UxDataGridView.Name = "UxDataGridView";
            this.UxDataGridView.RowHeadersVisible = false;
            this.UxDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UxDataGridView.Size = new System.Drawing.Size(586, 402);
            this.UxDataGridView.TabIndex = 1;
            this.UxDataGridView.DataSourceChanged += new System.EventHandler(this.UxDataGridViewDataSourceChanged);
            this.UxDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UxDataGridViewCellContentClick);
            this.UxDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.UxDataGridViewCellEndEdit);
            this.UxDataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.UxDataGridViewColumnHeaderMouseClick);
            this.UxDataGridView.CurrentCellDirtyStateChanged += new System.EventHandler(this.UxDataGridViewCurrentCellDirtyStateChanged);
            this.UxDataGridView.Paint += new System.Windows.Forms.PaintEventHandler(this.UxDataGridViewPaint);
            // 
            // UxTextBoxSearch
            // 
            this.UxTextBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UxTextBoxSearch.ForeColor = System.Drawing.Color.LightGray;
            this.UxTextBoxSearch.Location = new System.Drawing.Point(119, 12);
            this.UxTextBoxSearch.Name = "UxTextBoxSearch";
            this.UxTextBoxSearch.Size = new System.Drawing.Size(586, 20);
            this.UxTextBoxSearch.TabIndex = 2;
            this.UxTextBoxSearch.Text = "Search...";
            this.UxTextBoxSearch.Click += new System.EventHandler(this.UxTextBoxSearchClick);
            this.UxTextBoxSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.UxTextBoxSearchKeyUp);
            // 
            // UxCheckBoxShowDrafted
            // 
            this.UxCheckBoxShowDrafted.Checked = true;
            this.UxCheckBoxShowDrafted.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UxCheckBoxShowDrafted.Location = new System.Drawing.Point(8, 373);
            this.UxCheckBoxShowDrafted.Name = "UxCheckBoxShowDrafted";
            this.UxCheckBoxShowDrafted.Size = new System.Drawing.Size(105, 38);
            this.UxCheckBoxShowDrafted.TabIndex = 3;
            this.UxCheckBoxShowDrafted.Text = "Show Drafted";
            this.UxCheckBoxShowDrafted.UseVisualStyleBackColor = true;
            // 
            // UxFantasyTeamViewButton
            // 
            this.UxFantasyTeamViewButton.ContextMenuStrip = this.UxFantasyTeamContextMenu;
            this.UxFantasyTeamViewButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.UxFantasyTeamViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UxFantasyTeamViewButton.Location = new System.Drawing.Point(8, 417);
            this.UxFantasyTeamViewButton.Name = "UxFantasyTeamViewButton";
            this.UxFantasyTeamViewButton.Size = new System.Drawing.Size(105, 23);
            this.UxFantasyTeamViewButton.TabIndex = 4;
            this.UxFantasyTeamViewButton.Text = "Team Display";
            this.UxFantasyTeamViewButton.UseVisualStyleBackColor = true;
            this.UxFantasyTeamViewButton.Click += new System.EventHandler(this.UxFantasyTeamViewButton_Click);
            // 
            // UxFantasyTeamContextMenu
            // 
            this.UxFantasyTeamContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showOnlyMyTeamToolStripMenuItem,
            this.showAllTeamsToolStripMenuItem,
            this.showNoTeamsToolStripMenuItem});
            this.UxFantasyTeamContextMenu.Name = "UxFantasyTeamContextMenu";
            this.UxFantasyTeamContextMenu.Size = new System.Drawing.Size(185, 70);
            // 
            // showOnlyMyTeamToolStripMenuItem
            // 
            this.showOnlyMyTeamToolStripMenuItem.Name = "showOnlyMyTeamToolStripMenuItem";
            this.showOnlyMyTeamToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.showOnlyMyTeamToolStripMenuItem.Text = "Show Only My Team";
            this.showOnlyMyTeamToolStripMenuItem.Click += new System.EventHandler(this.showOnlyMyTeamToolStripMenuItem_Click);
            // 
            // showAllTeamsToolStripMenuItem
            // 
            this.showAllTeamsToolStripMenuItem.Name = "showAllTeamsToolStripMenuItem";
            this.showAllTeamsToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.showAllTeamsToolStripMenuItem.Text = "Show All Teams";
            this.showAllTeamsToolStripMenuItem.Click += new System.EventHandler(this.showAllTeamsToolStripMenuItem_Click);
            // 
            // showNoTeamsToolStripMenuItem
            // 
            this.showNoTeamsToolStripMenuItem.Name = "showNoTeamsToolStripMenuItem";
            this.showNoTeamsToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.showNoTeamsToolStripMenuItem.Text = "Show No Teams";
            this.showNoTeamsToolStripMenuItem.Click += new System.EventHandler(this.showNoTeamsToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Team Name";
            // 
            // UxFantasyTeamNameTextBox
            // 
            this.UxFantasyTeamNameTextBox.Location = new System.Drawing.Point(8, 38);
            this.UxFantasyTeamNameTextBox.Name = "UxFantasyTeamNameTextBox";
            this.UxFantasyTeamNameTextBox.Size = new System.Drawing.Size(105, 20);
            this.UxFantasyTeamNameTextBox.TabIndex = 7;
            this.UxFantasyTeamNameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // DraftBuddy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 452);
            this.Controls.Add(this.UxFantasyTeamNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UxFantasyTeamViewButton);
            this.Controls.Add(this.UxCheckBoxShowDrafted);
            this.Controls.Add(this.UxTextBoxSearch);
            this.Controls.Add(this.UxDataGridView);
            this.Controls.Add(this.UxGroupBoxView);
            this.KeyPreview = true;
            this.Name = "DraftBuddy";
            this.Text = "Draft Buddy 3.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DraftBuddyFormClosing);
            this.Load += new System.EventHandler(this.FantasyDraftLoad);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FantasyDraftKeyUp);
            this.UxGroupBoxView.ResumeLayout(false);
            this.UxGroupBoxView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UxDataGridView)).EndInit();
            this.UxFantasyTeamContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox UxGroupBoxView;
        private System.Windows.Forms.RadioButton UxRadioButtonDef;
        private System.Windows.Forms.RadioButton UxRadioButtonTe;
        private System.Windows.Forms.RadioButton UxRadioButtonWrRb;
        private System.Windows.Forms.RadioButton UxRadioButtonWr;
        private System.Windows.Forms.RadioButton UxRadioButtonRb;
        private System.Windows.Forms.RadioButton UxRadioButtonQB;
        private System.Windows.Forms.RadioButton UxRadioButtonAll;
        private System.Windows.Forms.RadioButton UxRadioButtonWatch;
        private System.Windows.Forms.RadioButton UxRadioButtonPk;
        private System.Windows.Forms.DataGridView UxDataGridView;
        private System.Windows.Forms.TextBox UxTextBoxSearch;
        private System.Windows.Forms.CheckBox UxCheckBoxShowDrafted;
        private System.Windows.Forms.Button UxFantasyTeamViewButton;
        private System.Windows.Forms.ContextMenuStrip UxFantasyTeamContextMenu;
        private System.Windows.Forms.ToolStripMenuItem showOnlyMyTeamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllTeamsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showNoTeamsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UxFantasyTeamNameTextBox;

    }
}