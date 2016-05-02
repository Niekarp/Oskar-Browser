namespace Oskar_Browser
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.PageRefreshButton = new System.Windows.Forms.Button();
            this.PageLoadingButton = new System.Windows.Forms.Button();
            this.UrlField = new System.Windows.Forms.TextBox();
            this.UrlFormAndHomePageButtonGrid = new System.Windows.Forms.TableLayoutPanel();
            this.HomePageButton = new System.Windows.Forms.Button();
            this.MenuDownLine = new System.Windows.Forms.Label();
            this.PreviousPageButton = new System.Windows.Forms.Button();
            this.NextPageButton = new System.Windows.Forms.Button();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.MenuUpLine = new System.Windows.Forms.Label();
            this.AddTabButton = new System.Windows.Forms.Button();
            this.UrlFormAndHomePageButtonGrid.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PageRefreshButton
            // 
            this.PageRefreshButton.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageRefreshButton.Location = new System.Drawing.Point(178, 13);
            this.PageRefreshButton.Name = "PageRefreshButton";
            this.PageRefreshButton.Size = new System.Drawing.Size(34, 27);
            this.PageRefreshButton.TabIndex = 5;
            this.PageRefreshButton.Text = "R";
            this.PageRefreshButton.UseVisualStyleBackColor = true;
            this.PageRefreshButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RefreshButton_MouseClick);
            // 
            // PageLoadingButton
            // 
            this.PageLoadingButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.PageLoadingButton.Location = new System.Drawing.Point(218, 13);
            this.PageLoadingButton.Name = "PageLoadingButton";
            this.PageLoadingButton.Size = new System.Drawing.Size(34, 27);
            this.PageLoadingButton.TabIndex = 6;
            this.PageLoadingButton.UseVisualStyleBackColor = false;
            // 
            // UrlField
            // 
            this.UrlField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UrlField.BackColor = System.Drawing.SystemColors.Window;
            this.UrlField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrlField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.UrlField.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.UrlField.Location = new System.Drawing.Point(3, 7);
            this.UrlField.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.UrlField.Name = "UrlField";
            this.UrlField.Size = new System.Drawing.Size(587, 26);
            this.UrlField.TabIndex = 3;
            this.UrlField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UrlField_KeyDown);
            this.UrlField.Leave += new System.EventHandler(this.UrlField_Leave);
            this.UrlField.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UrlField_MouseUp);
            // 
            // UrlFormAndHomePageButtonGrid
            // 
            this.UrlFormAndHomePageButtonGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UrlFormAndHomePageButtonGrid.BackColor = System.Drawing.Color.Transparent;
            this.UrlFormAndHomePageButtonGrid.ColumnCount = 2;
            this.UrlFormAndHomePageButtonGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.UrlFormAndHomePageButtonGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.UrlFormAndHomePageButtonGrid.Controls.Add(this.UrlField, 0, 0);
            this.UrlFormAndHomePageButtonGrid.Controls.Add(this.HomePageButton, 1, 0);
            this.UrlFormAndHomePageButtonGrid.Location = new System.Drawing.Point(258, 7);
            this.UrlFormAndHomePageButtonGrid.MaximumSize = new System.Drawing.Size(1200, 100);
            this.UrlFormAndHomePageButtonGrid.Name = "UrlFormAndHomePageButtonGrid";
            this.UrlFormAndHomePageButtonGrid.RowCount = 1;
            this.UrlFormAndHomePageButtonGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.UrlFormAndHomePageButtonGrid.Size = new System.Drawing.Size(633, 40);
            this.UrlFormAndHomePageButtonGrid.TabIndex = 8;
            // 
            // HomePageButton
            // 
            this.HomePageButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.HomePageButton.BackColor = System.Drawing.Color.Transparent;
            this.HomePageButton.BackgroundImage = global::Oskar_Browser.Properties.Resources.HomePageButton_test1;
            this.HomePageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomePageButton.Location = new System.Drawing.Point(596, 3);
            this.HomePageButton.Name = "HomePageButton";
            this.HomePageButton.Size = new System.Drawing.Size(34, 34);
            this.HomePageButton.TabIndex = 7;
            this.HomePageButton.UseVisualStyleBackColor = false;
            this.HomePageButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HomePageButton_MouseClick);
            // 
            // MenuDownLine
            // 
            this.MenuDownLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MenuDownLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MenuDownLine.Location = new System.Drawing.Point(-2, 74);
            this.MenuDownLine.Name = "MenuDownLine";
            this.MenuDownLine.Size = new System.Drawing.Size(1100, 1);
            this.MenuDownLine.TabIndex = 9;
            // 
            // PreviousPageButton
            // 
            this.PreviousPageButton.BackColor = System.Drawing.Color.Transparent;
            this.PreviousPageButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.PreviousPageButton.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviousPageButton.ForeColor = System.Drawing.Color.Black;
            this.PreviousPageButton.Image = global::Oskar_Browser.Properties.Resources.PreviousPageButton;
            this.PreviousPageButton.Location = new System.Drawing.Point(3, 8);
            this.PreviousPageButton.Name = "PreviousPageButton";
            this.PreviousPageButton.Size = new System.Drawing.Size(86, 35);
            this.PreviousPageButton.TabIndex = 1;
            this.PreviousPageButton.UseVisualStyleBackColor = false;
            this.PreviousPageButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PreviousPage_MouseDown);
            // 
            // NextPageButton
            // 
            this.NextPageButton.BackColor = System.Drawing.Color.Transparent;
            this.NextPageButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.NextPageButton.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextPageButton.ForeColor = System.Drawing.Color.Black;
            this.NextPageButton.Image = global::Oskar_Browser.Properties.Resources.NextPageButton2;
            this.NextPageButton.Location = new System.Drawing.Point(86, 8);
            this.NextPageButton.Name = "NextPageButton";
            this.NextPageButton.Size = new System.Drawing.Size(86, 35);
            this.NextPageButton.TabIndex = 2;
            this.NextPageButton.UseVisualStyleBackColor = false;
            this.NextPageButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NextPage_MouseDown);
            // 
            // MenuPanel
            // 
            this.MenuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MenuPanel.BackColor = System.Drawing.SystemColors.Control;
            this.MenuPanel.Controls.Add(this.PreviousPageButton);
            this.MenuPanel.Controls.Add(this.NextPageButton);
            this.MenuPanel.Controls.Add(this.PageRefreshButton);
            this.MenuPanel.Controls.Add(this.PageLoadingButton);
            this.MenuPanel.Controls.Add(this.UrlFormAndHomePageButtonGrid);
            this.MenuPanel.Location = new System.Drawing.Point(-1, 22);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(1093, 52);
            this.MenuPanel.TabIndex = 11;
            // 
            // MenuUpLine
            // 
            this.MenuUpLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MenuUpLine.BackColor = System.Drawing.Color.Transparent;
            this.MenuUpLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MenuUpLine.Location = new System.Drawing.Point(-3, 21);
            this.MenuUpLine.Name = "MenuUpLine";
            this.MenuUpLine.Size = new System.Drawing.Size(1100, 1);
            this.MenuUpLine.TabIndex = 12;
            // 
            // AddTabButton
            // 
            this.AddTabButton.BackColor = System.Drawing.SystemColors.Control;
            this.AddTabButton.FlatAppearance.BorderSize = 0;
            this.AddTabButton.ForeColor = System.Drawing.Color.Black;
            this.AddTabButton.Location = new System.Drawing.Point(-2, -2);
            this.AddTabButton.Name = "AddTabButton";
            this.AddTabButton.Size = new System.Drawing.Size(31, 26);
            this.AddTabButton.TabIndex = 13;
            this.AddTabButton.Text = "+";
            this.AddTabButton.UseVisualStyleBackColor = false;
            this.AddTabButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AddTabButton_MouseClick);
            // 
            // MainWindow
            // 
            this.AccessibleDescription = "";
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1092, 749);
            this.Controls.Add(this.MenuUpLine);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.MenuDownLine);
            this.Controls.Add(this.AddTabButton);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainWindow";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "~Oskar Browser~";
            this.UrlFormAndHomePageButtonGrid.ResumeLayout(false);
            this.UrlFormAndHomePageButtonGrid.PerformLayout();
            this.MenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NextPageButton;
        private System.Windows.Forms.Button PreviousPageButton;
        private System.Windows.Forms.Button PageRefreshButton;
        private System.Windows.Forms.Button PageLoadingButton;
        private System.Windows.Forms.Button HomePageButton;
        private System.Windows.Forms.TextBox UrlField;
        private System.Windows.Forms.TableLayoutPanel UrlFormAndHomePageButtonGrid;
        private System.Windows.Forms.Label MenuDownLine;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Label MenuUpLine;
        private System.Windows.Forms.Button AddTabButton;
    }
}

