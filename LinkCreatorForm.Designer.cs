namespace LinkAndWorksetCreator
{
    partial class LinkCreatorForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dataGridView2 = new DataGridView();
            Column1 = new DataGridViewCheckBoxColumn();
            FileName = new DataGridViewTextBoxColumn();
            colVersion = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            btnExit = new Button();
            openFileDialog1 = new OpenFileDialog();
            btnSelectFiles = new Button();
            btnLinkFiles = new Button();
            checkBoxDGAll = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.BackgroundColor = SystemColors.Control;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column1, FileName, colVersion, Column2 });
            dataGridView2.GridColor = SystemColors.ControlDark;
            dataGridView2.Location = new Point(1, 31);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.Size = new Size(480, 245);
            dataGridView2.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "";
            Column1.Name = "Column1";
            Column1.Width = 25;
            // 
            // FileName
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            FileName.DefaultCellStyle = dataGridViewCellStyle1;
            FileName.HeaderText = "File Name";
            FileName.Name = "FileName";
            FileName.Width = 200;
            // 
            // colVersion
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            colVersion.DefaultCellStyle = dataGridViewCellStyle2;
            colVersion.HeaderText = "Version";
            colVersion.Name = "colVersion";
            colVersion.ReadOnly = true;
            colVersion.Width = 50;
            // 
            // Column2
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            Column2.DefaultCellStyle = dataGridViewCellStyle3;
            Column2.HeaderText = "File Path";
            Column2.Name = "Column2";
            Column2.Width = 250;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(436, 278);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(45, 25);
            btnExit.TabIndex = 3;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "RVT files (*.rvt)|*.rvt";
            openFileDialog1.Multiselect = true;
            // 
            // btnSelectFiles
            // 
            btnSelectFiles.Location = new Point(3, 3);
            btnSelectFiles.Name = "btnSelectFiles";
            btnSelectFiles.Size = new Size(100, 25);
            btnSelectFiles.TabIndex = 1;
            btnSelectFiles.Text = "&Select Files";
            btnSelectFiles.UseVisualStyleBackColor = true;
            btnSelectFiles.Click += btnSelectFiles_Click;
            // 
            // btnLinkFiles
            // 
            btnLinkFiles.Location = new Point(3, 278);
            btnLinkFiles.Name = "btnLinkFiles";
            btnLinkFiles.Size = new Size(100, 25);
            btnLinkFiles.TabIndex = 2;
            btnLinkFiles.Text = "&Link Files";
            btnLinkFiles.UseVisualStyleBackColor = true;
            btnLinkFiles.Click += btnLinkFiles_Click;
            // 
            // checkBoxDGAll
            // 
            checkBoxDGAll.AutoSize = true;
            checkBoxDGAll.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            checkBoxDGAll.FlatAppearance.BorderSize = 0;
            checkBoxDGAll.Location = new Point(8, 38);
            checkBoxDGAll.Name = "checkBoxDGAll";
            checkBoxDGAll.Size = new Size(15, 14);
            checkBoxDGAll.TabIndex = 4;
            checkBoxDGAll.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 282);
            label1.Name = "label1";
            label1.Size = new Size(181, 17);
            label1.TabIndex = 5;
            label1.Text = "Links will be created at origin.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(103, 7);
            label2.Name = "label2";
            label2.Size = new Size(367, 17);
            label2.TabIndex = 6;
            label2.Text = "Only matched link file versions with current document version.";
            // 
            // LinkCreatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 305);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(checkBoxDGAll);
            Controls.Add(btnLinkFiles);
            Controls.Add(btnSelectFiles);
            Controls.Add(btnExit);
            Controls.Add(dataGridView2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LinkCreatorForm";
            Text = "Link Creator";
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView2;
        private Button btnExit;
        private OpenFileDialog openFileDialog1;
        private Button btnSelectFiles;
        private Button btnLinkFiles;
        private CheckBox checkBoxDGAll;
        private DataGridViewCheckBoxColumn Column1;
        private DataGridViewTextBoxColumn FileName;
        private DataGridViewTextBoxColumn colVersion;
        private DataGridViewTextBoxColumn Column2;
        private Label label1;
        private Label label2;
    }
}