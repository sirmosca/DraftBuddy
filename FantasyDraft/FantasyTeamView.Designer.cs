namespace DraftBuddy
{
    partial class FantasyTeamView 
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
            this.UxDataGridViewTeam = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.UxDataGridViewTeam)).BeginInit();
            this.SuspendLayout();
            // 
            // UxDataGridViewTeam
            // 
            this.UxDataGridViewTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UxDataGridViewTeam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UxDataGridViewTeam.Location = new System.Drawing.Point(0, 0);
            this.UxDataGridViewTeam.Name = "UxDataGridViewTeam";
            this.UxDataGridViewTeam.RowHeadersVisible = false;
            this.UxDataGridViewTeam.Size = new System.Drawing.Size(702, 387);
            this.UxDataGridViewTeam.TabIndex = 0;
            this.UxDataGridViewTeam.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.UxDataGridViewTeamColumnHeaderMouseClick);
            // 
            // FantasyTeamView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 387);
            this.Controls.Add(this.UxDataGridViewTeam);
            this.Name = "FantasyTeamView";
            this.Text = "Fantasy Team";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PersonTeamViewFormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.UxDataGridViewTeam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView UxDataGridViewTeam;

    }
}