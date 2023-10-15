namespace MainApp
{
    partial class Dialog
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
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.NameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VersionCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.SignInButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToAddRows = false;
            this.DataGrid.AllowUserToDeleteRows = false;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameCol,
            this.AuthorCol,
            this.VersionCol});
            this.DataGrid.Location = new System.Drawing.Point(8, 8);
            this.DataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.RowHeadersVisible = false;
            this.DataGrid.RowHeadersWidth = 62;
            this.DataGrid.RowTemplate.Height = 28;
            this.DataGrid.ShowEditingIcon = false;
            this.DataGrid.ShowRowErrors = false;
            this.DataGrid.Size = new System.Drawing.Size(517, 242);
            this.DataGrid.TabIndex = 1;
            // 
            // NameCol
            // 
            this.NameCol.HeaderText = "Name";
            this.NameCol.MinimumWidth = 8;
            this.NameCol.Name = "NameCol";
            this.NameCol.Width = 200;
            // 
            // AuthorCol
            // 
            this.AuthorCol.HeaderText = "Author";
            this.AuthorCol.MinimumWidth = 8;
            this.AuthorCol.Name = "AuthorCol";
            // 
            // VersionCol
            // 
            this.VersionCol.HeaderText = "Version";
            this.VersionCol.MinimumWidth = 8;
            this.VersionCol.Name = "VersionCol";
            this.VersionCol.Width = 50;
            // 
            // SignUpButton
            // 
            this.SignUpButton.Location = new System.Drawing.Point(420, 254);
            this.SignUpButton.Margin = new System.Windows.Forms.Padding(2);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(107, 31);
            this.SignUpButton.TabIndex = 2;
            this.SignUpButton.Text = "Cancel";
            this.SignUpButton.UseVisualStyleBackColor = true;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // SignInButton
            // 
            this.SignInButton.Location = new System.Drawing.Point(309, 254);
            this.SignInButton.Margin = new System.Windows.Forms.Padding(2);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(107, 31);
            this.SignInButton.TabIndex = 3;
            this.SignInButton.Text = "Ok";
            this.SignInButton.UseVisualStyleBackColor = true;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // Dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.SignInButton);
            this.Controls.Add(this.DataGrid);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Dialog";
            this.Text = "Loaded Plugin List";
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn VersionCol;
    }
}