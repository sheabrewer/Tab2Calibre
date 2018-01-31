namespace Tab2Calibre
{
    partial class Form1
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
            this.textBoxArtist = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSong = new System.Windows.Forms.TextBox();
            this.Song = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.textBoxCalibre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonCalibre = new System.Windows.Forms.Button();
            this.textBoxTextEditor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxArtist
            // 
            this.textBoxArtist.Location = new System.Drawing.Point(57, 19);
            this.textBoxArtist.Name = "textBoxArtist";
            this.textBoxArtist.Size = new System.Drawing.Size(327, 20);
            this.textBoxArtist.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Artist";
            // 
            // textBoxSong
            // 
            this.textBoxSong.Location = new System.Drawing.Point(57, 46);
            this.textBoxSong.Name = "textBoxSong";
            this.textBoxSong.Size = new System.Drawing.Size(327, 20);
            this.textBoxSong.TabIndex = 2;
            // 
            // Song
            // 
            this.Song.AutoSize = true;
            this.Song.Location = new System.Drawing.Point(10, 45);
            this.Song.Name = "Song";
            this.Song.Size = new System.Drawing.Size(32, 13);
            this.Song.TabIndex = 3;
            this.Song.Text = "Song";
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(57, 73);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(116, 21);
            this.comboBoxType.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Type";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(16, 187);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(672, 23);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Add to Calibre";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Text Editor";
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(538, 114);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 0;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // textBoxCalibre
            // 
            this.textBoxCalibre.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Tab2Calibre.Properties.Settings.Default, "txtDB", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxCalibre.Location = new System.Drawing.Point(120, 142);
            this.textBoxCalibre.Name = "textBoxCalibre";
            this.textBoxCalibre.Size = new System.Drawing.Size(408, 20);
            this.textBoxCalibre.TabIndex = 9;
            this.textBoxCalibre.Text = global::Tab2Calibre.Properties.Settings.Default.txtDB;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Calibre DB Location";
            // 
            // buttonCalibre
            // 
            this.buttonCalibre.Location = new System.Drawing.Point(538, 141);
            this.buttonCalibre.Name = "buttonCalibre";
            this.buttonCalibre.Size = new System.Drawing.Size(75, 23);
            this.buttonCalibre.TabIndex = 11;
            this.buttonCalibre.Text = "Browse";
            this.buttonCalibre.UseVisualStyleBackColor = true;
            this.buttonCalibre.Click += new System.EventHandler(this.buttonCalibre_Click);
            // 
            // textBoxTextEditor
            // 
            this.textBoxTextEditor.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Tab2Calibre.Properties.Settings.Default, "txtEditor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxTextEditor.Location = new System.Drawing.Point(120, 115);
            this.textBoxTextEditor.Name = "textBoxTextEditor";
            this.textBoxTextEditor.Size = new System.Drawing.Size(411, 20);
            this.textBoxTextEditor.TabIndex = 7;
            this.textBoxTextEditor.Text = global::Tab2Calibre.Properties.Settings.Default.txtEditor;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 233);
            this.Controls.Add(this.buttonCalibre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCalibre);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTextEditor);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.Song);
            this.Controls.Add(this.textBoxSong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxArtist);
            this.Name = "Form1";
            this.Text = "Tab2Calibre";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxArtist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSong;
        private System.Windows.Forms.Label Song;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxTextEditor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TextBox textBoxCalibre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonCalibre;
    }
}

