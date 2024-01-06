namespace lab4_ltcsdl
{
    partial class viewQuestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewQuestion));
            this.label1 = new System.Windows.Forms.Label();
            this.uComSet = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.questionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lab4ltcsdlDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lab4_ltcsdlDataSet = new lab4_ltcsdl.lab4_ltcsdlDataSet();
            this.uButtonUpdate = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.questionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.questionTableAdapter = new lab4_ltcsdl.lab4_ltcsdlDataSetTableAdapters.questionTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.questionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.option1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.option2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.option3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.option4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qsetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.questionBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab4ltcsdlDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab4_ltcsdlDataSet)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(43, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "View question";
            // 
            // uComSet
            // 
            this.uComSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uComSet.FormattingEnabled = true;
            this.uComSet.Location = new System.Drawing.Point(474, 196);
            this.uComSet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uComSet.Name = "uComSet";
            this.uComSet.Size = new System.Drawing.Size(437, 45);
            this.uComSet.TabIndex = 9;
            this.uComSet.SelectedIndexChanged += new System.EventHandler(this.uComSet_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(468, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Set";
            // 
            // questionBindingSource1
            // 
            this.questionBindingSource1.DataMember = "question";
            this.questionBindingSource1.DataSource = this.lab4ltcsdlDataSetBindingSource;
            // 
            // lab4ltcsdlDataSetBindingSource
            // 
            this.lab4ltcsdlDataSetBindingSource.DataSource = this.lab4_ltcsdlDataSet;
            this.lab4ltcsdlDataSetBindingSource.Position = 0;
            // 
            // lab4_ltcsdlDataSet
            // 
            this.lab4_ltcsdlDataSet.DataSetName = "lab4_ltcsdlDataSet";
            this.lab4_ltcsdlDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uButtonUpdate
            // 
            this.uButtonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uButtonUpdate.Location = new System.Drawing.Point(1137, 182);
            this.uButtonUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uButtonUpdate.Name = "uButtonUpdate";
            this.uButtonUpdate.Size = new System.Drawing.Size(204, 72);
            this.uButtonUpdate.TabIndex = 26;
            this.uButtonUpdate.Text = "Delete";
            this.uButtonUpdate.UseVisualStyleBackColor = true;
            this.uButtonUpdate.Click += new System.EventHandler(this.uButtonUpdate_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripButton1,
            this.toolStripLabel2,
            this.toolStripButton2,
            this.toolStripLabel3,
            this.toolStripButton3,
            this.toolStripLabel4,
            this.toolStripButton4,
            this.toolStripLabel5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1441, 30);
            this.toolStrip1.TabIndex = 28;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(153, 25);
            this.toolStripLabel1.Text = "AddNewQuestion";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(34, 25);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(142, 25);
            this.toolStripLabel2.Text = "UpdateQuestion";
            this.toolStripLabel2.Click += new System.EventHandler(this.toolStripLabel2_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(34, 25);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(49, 25);
            this.toolStripLabel3.Text = "View";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(34, 25);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(116, 25);
            this.toolStripLabel4.Text = "Studentresult";
            this.toolStripLabel4.Click += new System.EventHandler(this.toolStripLabel4_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(34, 25);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(72, 25);
            this.toolStripLabel5.Text = "LogOut";
            this.toolStripLabel5.Click += new System.EventHandler(this.toolStripLabel5_Click);
            // 
            // questionBindingSource
            // 
            this.questionBindingSource.DataMember = "question";
            this.questionBindingSource.DataSource = this.lab4_ltcsdlDataSet;
            // 
            // questionTableAdapter
            // 
            this.questionTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.questionIdDataGridViewTextBoxColumn,
            this.qNoDataGridViewTextBoxColumn,
            this.questionDataGridViewTextBoxColumn,
            this.option1DataGridViewTextBoxColumn,
            this.option2DataGridViewTextBoxColumn,
            this.option3DataGridViewTextBoxColumn,
            this.option4DataGridViewTextBoxColumn,
            this.answerDataGridViewTextBoxColumn,
            this.qsetDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.questionBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(52, 271);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1361, 572);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // questionIdDataGridViewTextBoxColumn
            // 
            this.questionIdDataGridViewTextBoxColumn.DataPropertyName = "questionId";
            this.questionIdDataGridViewTextBoxColumn.HeaderText = "questionId";
            this.questionIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.questionIdDataGridViewTextBoxColumn.Name = "questionIdDataGridViewTextBoxColumn";
            this.questionIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.questionIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // qNoDataGridViewTextBoxColumn
            // 
            this.qNoDataGridViewTextBoxColumn.DataPropertyName = "qNo";
            this.qNoDataGridViewTextBoxColumn.HeaderText = "qNo";
            this.qNoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.qNoDataGridViewTextBoxColumn.Name = "qNoDataGridViewTextBoxColumn";
            this.qNoDataGridViewTextBoxColumn.Width = 150;
            // 
            // questionDataGridViewTextBoxColumn
            // 
            this.questionDataGridViewTextBoxColumn.DataPropertyName = "question";
            this.questionDataGridViewTextBoxColumn.HeaderText = "question";
            this.questionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.questionDataGridViewTextBoxColumn.Name = "questionDataGridViewTextBoxColumn";
            this.questionDataGridViewTextBoxColumn.Width = 150;
            // 
            // option1DataGridViewTextBoxColumn
            // 
            this.option1DataGridViewTextBoxColumn.DataPropertyName = "option1";
            this.option1DataGridViewTextBoxColumn.HeaderText = "option1";
            this.option1DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.option1DataGridViewTextBoxColumn.Name = "option1DataGridViewTextBoxColumn";
            this.option1DataGridViewTextBoxColumn.Width = 150;
            // 
            // option2DataGridViewTextBoxColumn
            // 
            this.option2DataGridViewTextBoxColumn.DataPropertyName = "option2";
            this.option2DataGridViewTextBoxColumn.HeaderText = "option2";
            this.option2DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.option2DataGridViewTextBoxColumn.Name = "option2DataGridViewTextBoxColumn";
            this.option2DataGridViewTextBoxColumn.Width = 150;
            // 
            // option3DataGridViewTextBoxColumn
            // 
            this.option3DataGridViewTextBoxColumn.DataPropertyName = "option3";
            this.option3DataGridViewTextBoxColumn.HeaderText = "option3";
            this.option3DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.option3DataGridViewTextBoxColumn.Name = "option3DataGridViewTextBoxColumn";
            this.option3DataGridViewTextBoxColumn.Width = 150;
            // 
            // option4DataGridViewTextBoxColumn
            // 
            this.option4DataGridViewTextBoxColumn.DataPropertyName = "option4";
            this.option4DataGridViewTextBoxColumn.HeaderText = "option4";
            this.option4DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.option4DataGridViewTextBoxColumn.Name = "option4DataGridViewTextBoxColumn";
            this.option4DataGridViewTextBoxColumn.Width = 150;
            // 
            // answerDataGridViewTextBoxColumn
            // 
            this.answerDataGridViewTextBoxColumn.DataPropertyName = "answer";
            this.answerDataGridViewTextBoxColumn.HeaderText = "answer";
            this.answerDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.answerDataGridViewTextBoxColumn.Name = "answerDataGridViewTextBoxColumn";
            this.answerDataGridViewTextBoxColumn.Width = 150;
            // 
            // qsetDataGridViewTextBoxColumn
            // 
            this.qsetDataGridViewTextBoxColumn.DataPropertyName = "qset";
            this.qsetDataGridViewTextBoxColumn.HeaderText = "qset";
            this.qsetDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.qsetDataGridViewTextBoxColumn.Name = "qsetDataGridViewTextBoxColumn";
            this.qsetDataGridViewTextBoxColumn.Width = 150;
            // 
            // questionBindingSource3
            // 
            this.questionBindingSource3.DataMember = "question";
            this.questionBindingSource3.DataSource = this.lab4ltcsdlDataSetBindingSource;
            // 
            // questionBindingSource2
            // 
            this.questionBindingSource2.DataMember = "question";
            this.questionBindingSource2.DataSource = this.lab4ltcsdlDataSetBindingSource;
            // 
            // viewQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1441, 885);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.uButtonUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.uComSet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "viewQuestion";
            this.Text = "viewQuestion";
            this.Load += new System.EventHandler(this.viewQuestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab4ltcsdlDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab4_ltcsdlDataSet)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox uComSet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button uButtonUpdate;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private lab4_ltcsdlDataSet lab4_ltcsdlDataSet;
        private System.Windows.Forms.BindingSource questionBindingSource;
        private lab4_ltcsdlDataSetTableAdapters.questionTableAdapter questionTableAdapter;
        private System.Windows.Forms.BindingSource questionBindingSource1;
        private System.Windows.Forms.BindingSource lab4ltcsdlDataSetBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource questionBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn option1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn option2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn option3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn option4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn answerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qsetDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource questionBindingSource3;
    }
}