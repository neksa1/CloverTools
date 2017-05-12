namespace CloverTools
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proizvodnaLinijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slikaDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.probaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSet = new CloverTools.TestDataSet();
            this.textID = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textLastname = new System.Windows.Forms.TextBox();
            this.textProductionLine = new System.Windows.Forms.TextBox();
            this.probaTableAdapter = new CloverTools.TestDataSetTableAdapters.probaTableAdapter();
            this.New = new System.Windows.Forms.Button();
            this.editr = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.probaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.proizvodnaLinijaDataGridViewTextBoxColumn,
            this.slikaDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.probaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(542, 193);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            // 
            // proizvodnaLinijaDataGridViewTextBoxColumn
            // 
            this.proizvodnaLinijaDataGridViewTextBoxColumn.DataPropertyName = "Proizvodna linija";
            this.proizvodnaLinijaDataGridViewTextBoxColumn.HeaderText = "Proizvodna linija";
            this.proizvodnaLinijaDataGridViewTextBoxColumn.Name = "proizvodnaLinijaDataGridViewTextBoxColumn";
            // 
            // slikaDataGridViewImageColumn
            // 
            this.slikaDataGridViewImageColumn.DataPropertyName = "Slika";
            this.slikaDataGridViewImageColumn.HeaderText = "Slika";
            this.slikaDataGridViewImageColumn.Name = "slikaDataGridViewImageColumn";
            // 
            // probaBindingSource
            // 
            this.probaBindingSource.DataMember = "proba";
            this.probaBindingSource.DataSource = this.testDataSet;
            // 
            // testDataSet
            // 
            this.testDataSet.DataSetName = "TestDataSet";
            this.testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textID
            // 
            this.textID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.probaBindingSource, "ID", true));
            this.textID.Location = new System.Drawing.Point(284, 25);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(270, 20);
            this.textID.TabIndex = 1;
            // 
            // textName
            // 
            this.textName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.probaBindingSource, "Ime", true));
            this.textName.Location = new System.Drawing.Point(284, 57);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(270, 20);
            this.textName.TabIndex = 2;
            // 
            // textLastname
            // 
            this.textLastname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.probaBindingSource, "Prezime", true));
            this.textLastname.Location = new System.Drawing.Point(284, 89);
            this.textLastname.Name = "textLastname";
            this.textLastname.Size = new System.Drawing.Size(270, 20);
            this.textLastname.TabIndex = 3;
            // 
            // textProductionLine
            // 
            this.textProductionLine.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.probaBindingSource, "Proizvodna linija", true));
            this.textProductionLine.Location = new System.Drawing.Point(284, 121);
            this.textProductionLine.Name = "textProductionLine";
            this.textProductionLine.Size = new System.Drawing.Size(270, 20);
            this.textProductionLine.TabIndex = 4;
            // 
            // probaTableAdapter
            // 
            this.probaTableAdapter.ClearBeforeFill = true;
            // 
            // New
            // 
            this.New.Location = new System.Drawing.Point(104, 148);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(87, 20);
            this.New.TabIndex = 5;
            this.New.Text = "Novo";
            this.New.UseVisualStyleBackColor = true;
            this.New.Click += new System.EventHandler(this.button1_Click);
            // 
            // editr
            // 
            this.editr.Location = new System.Drawing.Point(210, 148);
            this.editr.Name = "editr";
            this.editr.Size = new System.Drawing.Size(87, 20);
            this.editr.TabIndex = 6;
            this.editr.Text = "Izmeni";
            this.editr.UseVisualStyleBackColor = true;
            this.editr.Click += new System.EventHandler(this.button2_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(323, 148);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(87, 20);
            this.cancel.TabIndex = 7;
            this.cancel.Text = "Otkaži";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.button3_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(435, 148);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(87, 20);
            this.Save.TabIndex = 8;
            this.Save.Text = "Sačuvaj";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 388);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.editr);
            this.Controls.Add(this.New);
            this.Controls.Add(this.textProductionLine);
            this.Controls.Add(this.textLastname);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.probaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private TestDataSet testDataSet;
        private System.Windows.Forms.BindingSource probaBindingSource;
        private TestDataSetTableAdapters.probaTableAdapter probaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proizvodnaLinijaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn slikaDataGridViewImageColumn;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textLastname;
        private System.Windows.Forms.TextBox textProductionLine;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Button editr;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button Save;
    }
}

