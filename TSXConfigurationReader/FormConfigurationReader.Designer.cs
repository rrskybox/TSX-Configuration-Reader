namespace TSXConfigurationReader
{
    partial class FormConfigurationReader
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
            System.Windows.Forms.Button OpenButton;
            System.Windows.Forms.Button ParseButton;
            System.Windows.Forms.Button SearchButton;
            this.INIopenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ConfigFileTextBox = new System.Windows.Forms.TextBox();
            this.cfgTreeView = new System.Windows.Forms.TreeView();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            OpenButton = new System.Windows.Forms.Button();
            ParseButton = new System.Windows.Forms.Button();
            SearchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenButton
            // 
            OpenButton.Location = new System.Drawing.Point(12, 12);
            OpenButton.Name = "OpenButton";
            OpenButton.Size = new System.Drawing.Size(75, 23);
            OpenButton.TabIndex = 0;
            OpenButton.Text = "Open";
            OpenButton.UseVisualStyleBackColor = true;
            OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // ParseButton
            // 
            ParseButton.Location = new System.Drawing.Point(516, 680);
            ParseButton.Name = "ParseButton";
            ParseButton.Size = new System.Drawing.Size(63, 23);
            ParseButton.TabIndex = 4;
            ParseButton.Text = "Collapse";
            ParseButton.UseVisualStyleBackColor = true;
            ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // SearchButton
            // 
            SearchButton.Location = new System.Drawing.Point(415, 680);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new System.Drawing.Size(63, 23);
            SearchButton.TabIndex = 6;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // INIopenFileDialog
            // 
            this.INIopenFileDialog.Filter = "Config Files (.ini)|*.ini|All Files (*.*)|*.*\"";
            // 
            // ConfigFileTextBox
            // 
            this.ConfigFileTextBox.Location = new System.Drawing.Point(93, 15);
            this.ConfigFileTextBox.Name = "ConfigFileTextBox";
            this.ConfigFileTextBox.Size = new System.Drawing.Size(486, 20);
            this.ConfigFileTextBox.TabIndex = 1;
            // 
            // cfgTreeView
            // 
            this.cfgTreeView.Location = new System.Drawing.Point(12, 53);
            this.cfgTreeView.Name = "cfgTreeView";
            this.cfgTreeView.Size = new System.Drawing.Size(567, 607);
            this.cfgTreeView.TabIndex = 2;
            this.cfgTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.cfgTreeView_AfterSelect);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(12, 682);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(397, 20);
            this.SearchTextBox.TabIndex = 5;
            this.SearchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchTextBox_KeyDown);
            // 
            // FormConfigurationReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(595, 722);
            this.Controls.Add(SearchButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(ParseButton);
            this.Controls.Add(this.cfgTreeView);
            this.Controls.Add(this.ConfigFileTextBox);
            this.Controls.Add(OpenButton);
            this.Name = "FormConfigurationReader";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog INIopenFileDialog;
        private System.Windows.Forms.TextBox ConfigFileTextBox;
        private System.Windows.Forms.TreeView cfgTreeView;
        private System.Windows.Forms.TextBox SearchTextBox;
    }
}

