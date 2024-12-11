namespace LinkAndWorksetCreator
{
    partial class WorksetCreatorForm
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
            label1 = new Label();
            btnGetRevitLinks = new Button();
            dataGridView1 = new DataGridView();
            col_Check = new DataGridViewCheckBoxColumn();
            col_RvtLinkName = new DataGridViewTextBoxColumn();
            dataGridView2 = new DataGridView();
            dataGridViewCheckBoxColumn1 = new DataGridViewCheckBoxColumn();
            dataGridViewWorksetsID = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            btnGetWorkSets = new Button();
            btnCreateWorksets = new Button();
            Prefix = new Label();
            textBoxPrefix = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 5);
            label1.Name = "label1";
            label1.Size = new Size(43, 17);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // btnGetRevitLinks
            // 
            btnGetRevitLinks.Location = new Point(427, 18);
            btnGetRevitLinks.Name = "btnGetRevitLinks";
            btnGetRevitLinks.Size = new Size(100, 28);
            btnGetRevitLinks.TabIndex = 1;
            btnGetRevitLinks.Text = "Get &Links";
            btnGetRevitLinks.UseVisualStyleBackColor = true;
            btnGetRevitLinks.Click += btnGetRevitLinks_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { col_Check, col_RvtLinkName });
            dataGridView1.Location = new Point(6, 48);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(524, 195);
            dataGridView1.TabIndex = 2;
            // 
            // col_Check
            // 
            col_Check.HeaderText = "";
            col_Check.Name = "col_Check";
            col_Check.ReadOnly = true;
            col_Check.Resizable = DataGridViewTriState.False;
            col_Check.Width = 20;
            // 
            // col_RvtLinkName
            // 
            col_RvtLinkName.HeaderText = "Revit Link Name";
            col_RvtLinkName.Name = "col_RvtLinkName";
            col_RvtLinkName.Width = 500;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewCheckBoxColumn1, dataGridViewWorksetsID, dataGridViewTextBoxColumn1 });
            dataGridView2.Location = new Point(6, 278);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.Size = new Size(524, 129);
            dataGridView2.TabIndex = 3;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            dataGridViewCheckBoxColumn1.Frozen = true;
            dataGridViewCheckBoxColumn1.HeaderText = "";
            dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            dataGridViewCheckBoxColumn1.ReadOnly = true;
            dataGridViewCheckBoxColumn1.Resizable = DataGridViewTriState.False;
            dataGridViewCheckBoxColumn1.Width = 20;
            // 
            // dataGridViewWorksetsID
            // 
            dataGridViewWorksetsID.Frozen = true;
            dataGridViewWorksetsID.HeaderText = "ID";
            dataGridViewWorksetsID.Name = "dataGridViewWorksetsID";
            dataGridViewWorksetsID.ReadOnly = true;
            dataGridViewWorksetsID.Resizable = DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Workset Name";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 400;
            // 
            // btnGetWorkSets
            // 
            btnGetWorkSets.Location = new Point(427, 248);
            btnGetWorkSets.Name = "btnGetWorkSets";
            btnGetWorkSets.Size = new Size(100, 28);
            btnGetWorkSets.TabIndex = 2;
            btnGetWorkSets.Text = "Get &Worksets";
            btnGetWorkSets.UseVisualStyleBackColor = true;
            btnGetWorkSets.Click += btnGetWorkSets_Click;
            // 
            // btnCreateWorksets
            // 
            btnCreateWorksets.Location = new Point(407, 415);
            btnCreateWorksets.Name = "btnCreateWorksets";
            btnCreateWorksets.Size = new Size(120, 28);
            btnCreateWorksets.TabIndex = 3;
            btnCreateWorksets.Text = "&Create Worksets";
            btnCreateWorksets.UseVisualStyleBackColor = true;
            btnCreateWorksets.Click += btnCreateWorkset_Click;
            // 
            // Prefix
            // 
            Prefix.AutoSize = true;
            Prefix.Location = new Point(273, 421);
            Prefix.Name = "Prefix";
            Prefix.Size = new Size(40, 17);
            Prefix.TabIndex = 5;
            Prefix.Text = "Prefix";
            // 
            // textBoxPrefix
            // 
            textBoxPrefix.Location = new Point(315, 417);
            textBoxPrefix.Name = "textBoxPrefix";
            textBoxPrefix.Size = new Size(88, 25);
            textBoxPrefix.TabIndex = 6;
            textBoxPrefix.Text = "RvtLink ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 5);
            label2.Name = "label2";
            label2.Size = new Size(97, 17);
            label2.TabIndex = 0;
            label2.Text = "This Document:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 28);
            label3.Name = "label3";
            label3.Size = new Size(68, 17);
            label3.TabIndex = 0;
            label3.Text = "Revit Links";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 258);
            label4.Name = "label4";
            label4.Size = new Size(61, 17);
            label4.TabIndex = 0;
            label4.Text = "Worksets";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(6, 416);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 26);
            btnExit.TabIndex = 4;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // WorksetCreatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 449);
            Controls.Add(btnExit);
            Controls.Add(textBoxPrefix);
            Controls.Add(Prefix);
            Controls.Add(btnCreateWorksets);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(btnGetWorkSets);
            Controls.Add(btnGetRevitLinks);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "WorksetCreatorForm";
            Text = "Workset Creator";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnGetRevitLinks;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Button btnGetWorkSets;
        private Button btnCreateWorksets;
        private Label Prefix;
        private TextBox textBoxPrefix;
        private Label label2;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewWorksetsID;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private Label label3;
        private Label label4;
        private DataGridViewCheckBoxColumn col_Check;
        private DataGridViewTextBoxColumn col_RvtLinkName;
        private Button btnExit;
    }
}
