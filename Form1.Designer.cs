namespace DataBaseProject
{
    partial class Dashboard
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
            this.SaveButton = new System.Windows.Forms.Button();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.StoryTextbox = new System.Windows.Forms.RichTextBox();
            this.SelectionBox = new System.Windows.Forms.ComboBox();
            this.LoadButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.database1DataSet = new DataBaseProject.Database1DataSet();
            this.storyTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storyTableTableAdapter = new DataBaseProject.Database1DataSetTableAdapters.StoryTableTableAdapter();
            this.AuthorTextbox = new System.Windows.Forms.RichTextBox();
            this.TitleTextbox = new System.Windows.Forms.RichTextBox();
            this._AuthorLabel = new System.Windows.Forms.Label();
            this._TitleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storyTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(50)))));
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveButton.Location = new System.Drawing.Point(592, 12);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(87, 61);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorLabel.ForeColor = System.Drawing.Color.Silver;
            this.AuthorLabel.Location = new System.Drawing.Point(9, 41);
            this.AuthorLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(15, 18);
            this.AuthorLabel.TabIndex = 1;
            this.AuthorLabel.Text = "-";
            // 
            // StoryTextbox
            // 
            this.StoryTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(50)))));
            this.StoryTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StoryTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.StoryTextbox.Location = new System.Drawing.Point(12, 81);
            this.StoryTextbox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.StoryTextbox.Name = "StoryTextbox";
            this.StoryTextbox.Size = new System.Drawing.Size(1008, 667);
            this.StoryTextbox.TabIndex = 2;
            this.StoryTextbox.Text = "";
            // 
            // SelectionBox
            // 
            this.SelectionBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(50)))));
            this.SelectionBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SelectionBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SelectionBox.FormattingEnabled = true;
            this.SelectionBox.Location = new System.Drawing.Point(12, 12);
            this.SelectionBox.Name = "SelectionBox";
            this.SelectionBox.Size = new System.Drawing.Size(369, 26);
            this.SelectionBox.TabIndex = 3;
            // 
            // LoadButton
            // 
            this.LoadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(50)))));
            this.LoadButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoadButton.Location = new System.Drawing.Point(389, 12);
            this.LoadButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(87, 26);
            this.LoadButton.TabIndex = 4;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = false;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(9, 59);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(16, 18);
            this.TitleLabel.TabIndex = 5;
            this.TitleLabel.Text = "-";
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // storyTableBindingSource
            // 
            this.storyTableBindingSource.DataMember = "StoryTable";
            this.storyTableBindingSource.DataSource = this.database1DataSet;
            // 
            // storyTableTableAdapter
            // 
            this.storyTableTableAdapter.ClearBeforeFill = true;
            // 
            // AuthorTextbox
            // 
            this.AuthorTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(50)))));
            this.AuthorTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AuthorTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AuthorTextbox.Location = new System.Drawing.Point(761, 12);
            this.AuthorTextbox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.AuthorTextbox.MaxLength = 50;
            this.AuthorTextbox.Name = "AuthorTextbox";
            this.AuthorTextbox.Size = new System.Drawing.Size(259, 26);
            this.AuthorTextbox.TabIndex = 6;
            this.AuthorTextbox.Text = "";
            // 
            // TitleTextbox
            // 
            this.TitleTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(50)))));
            this.TitleTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitleTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TitleTextbox.Location = new System.Drawing.Point(761, 47);
            this.TitleTextbox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TitleTextbox.MaxLength = 50;
            this.TitleTextbox.Name = "TitleTextbox";
            this.TitleTextbox.Size = new System.Drawing.Size(259, 26);
            this.TitleTextbox.TabIndex = 7;
            this.TitleTextbox.Text = "";
            // 
            // _AuthorLabel
            // 
            this._AuthorLabel.AutoSize = true;
            this._AuthorLabel.Location = new System.Drawing.Point(689, 14);
            this._AuthorLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this._AuthorLabel.Name = "_AuthorLabel";
            this._AuthorLabel.Size = new System.Drawing.Size(62, 18);
            this._AuthorLabel.TabIndex = 8;
            this._AuthorLabel.Text = "Name:";
            // 
            // _TitleLabel
            // 
            this._TitleLabel.AutoSize = true;
            this._TitleLabel.Location = new System.Drawing.Point(689, 49);
            this._TitleLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this._TitleLabel.Name = "_TitleLabel";
            this._TitleLabel.Size = new System.Drawing.Size(52, 18);
            this._TitleLabel.TabIndex = 9;
            this._TitleLabel.Text = "Title:";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(38)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1034, 761);
            this.Controls.Add(this._TitleLabel);
            this.Controls.Add(this._AuthorLabel);
            this.Controls.Add(this.TitleTextbox);
            this.Controls.Add(this.AuthorTextbox);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.SelectionBox);
            this.Controls.Add(this.StoryTextbox);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.SaveButton);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Dashboard";
            this.Text = "SQL Database Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storyTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.RichTextBox StoryTextbox;
        private System.Windows.Forms.ComboBox SelectionBox;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Label TitleLabel;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource storyTableBindingSource;
        private Database1DataSetTableAdapters.StoryTableTableAdapter storyTableTableAdapter;
        private System.Windows.Forms.RichTextBox AuthorTextbox;
        private System.Windows.Forms.RichTextBox TitleTextbox;
        private System.Windows.Forms.Label _AuthorLabel;
        private System.Windows.Forms.Label _TitleLabel;
    }
}

