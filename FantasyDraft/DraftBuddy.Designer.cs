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
            this.UxGroupBoxView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UxDataGridView)).BeginInit();
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
            this.UxGroupBoxView.Location = new System.Drawing.Point(12, 12);
            this.UxGroupBoxView.Name = "UxGroupBoxView";
            this.UxGroupBoxView.Size = new System.Drawing.Size(77, 228);
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
            this.UxDataGridView.Location = new System.Drawing.Point(97, 38);
            this.UxDataGridView.Name = "UxDataGridView";
            this.UxDataGridView.RowHeadersVisible = false;
            this.UxDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UxDataGridView.Size = new System.Drawing.Size(608, 364);
            this.UxDataGridView.TabIndex = 1;
            this.UxDataGridView.DataSourceChanged += new System.EventHandler(this.UxDataGridViewDataSourceChanged);
            this.UxDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UxDataGridViewCellContentClick);
            this.UxDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.UxDataGridViewCellEndEdit);
            this.UxDataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.UxDataGridViewColumnHeaderMouseClick);
            this.UxDataGridView.CurrentCellDirtyStateChanged += new System.EventHandler(this.UxDataGridViewCurrentCellDirtyStateChanged);
            this.UxDataGridView.Paint += new System.Windows.Forms.PaintEventHandler(this.UxDataGridViewPaint);
            this.UxDataGridView.DoubleClick += new System.EventHandler(this.UxDataGridViewDoubleClick);
            // 
            // UxTextBoxSearch
            // 
            this.UxTextBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.UxTextBoxSearch.ForeColor = System.Drawing.Color.LightGray;
            this.UxTextBoxSearch.Location = new System.Drawing.Point(97, 12);
            this.UxTextBoxSearch.Name = "UxTextBoxSearch";
            this.UxTextBoxSearch.Size = new System.Drawing.Size(608, 20);
            this.UxTextBoxSearch.TabIndex = 2;
            this.UxTextBoxSearch.Text = "Search...";
            this.UxTextBoxSearch.Click += new System.EventHandler(this.UxTextBoxSearchClick);
            this.UxTextBoxSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.UxTextBoxSearchKeyUp);
            // 
            // UxCheckBoxShowDrafted
            // 
            this.UxCheckBoxShowDrafted.Location = new System.Drawing.Point(12, 246);
            this.UxCheckBoxShowDrafted.Name = "UxCheckBoxShowDrafted";
            this.UxCheckBoxShowDrafted.Size = new System.Drawing.Size(77, 38);
            this.UxCheckBoxShowDrafted.TabIndex = 3;
            this.UxCheckBoxShowDrafted.Text = "Show Drafted";
            this.UxCheckBoxShowDrafted.UseVisualStyleBackColor = true;
            // 
            // DraftBuddy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 414);
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

    }
}