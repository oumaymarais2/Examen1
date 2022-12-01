namespace Examen1
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.examenDataSet = new Examen1.ExamenDataSet();
			this.eXMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.eXMTableAdapter = new Examen1.ExamenDataSetTableAdapters.EXMTableAdapter();
			this.dateDebutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dateFinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.matiereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.questionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.reponseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.exameDataSet = new Examen1.ExameDataSet();
			this.eXBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.eXTableAdapter = new Examen1.ExameDataSetTableAdapters.EXTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.examenDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.eXMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.exameDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.eXBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(69, 165);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(86, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Question";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(69, 219);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 24);
			this.label2.TabIndex = 1;
			this.label2.Text = "Reponse";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(182, 112);
			this.textBox3.Multiline = true;
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(269, 23);
			this.textBox3.TabIndex = 2;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(527, 249);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(103, 27);
			this.button1.TabIndex = 7;
			this.button1.Text = "Insert";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(296, 22);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(93, 26);
			this.label3.TabIndex = 8;
			this.label3.Text = "Examen";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(182, 166);
			this.textBox4.Multiline = true;
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(269, 23);
			this.textBox4.TabIndex = 2;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(69, 112);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(72, 24);
			this.label6.TabIndex = 10;
			this.label6.Text = "Matiere";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(182, 219);
			this.textBox5.Multiline = true;
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(269, 23);
			this.textBox5.TabIndex = 2;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(496, 51);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(77, 20);
			this.textBox1.TabIndex = 11;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(579, 51);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(77, 20);
			this.textBox2.TabIndex = 11;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(493, 31);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(59, 13);
			this.label7.TabIndex = 12;
			this.label7.Text = "DateDebut";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(586, 35);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(44, 13);
			this.label8.TabIndex = 13;
			this.label8.Text = "DateFin";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDebutDataGridViewTextBoxColumn,
            this.dateFinDataGridViewTextBoxColumn,
            this.matiereDataGridViewTextBoxColumn,
            this.questionDataGridViewTextBoxColumn,
            this.reponseDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.eXBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(73, 282);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(541, 95);
			this.dataGridView1.TabIndex = 14;
			// 
			// examenDataSet
			// 
			this.examenDataSet.DataSetName = "ExamenDataSet";
			this.examenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// eXMBindingSource
			// 
			this.eXMBindingSource.DataMember = "EXM";
			this.eXMBindingSource.DataSource = this.examenDataSet;
			// 
			// eXMTableAdapter
			// 
			this.eXMTableAdapter.ClearBeforeFill = true;
			// 
			// dateDebutDataGridViewTextBoxColumn
			// 
			this.dateDebutDataGridViewTextBoxColumn.DataPropertyName = "DateDebut";
			this.dateDebutDataGridViewTextBoxColumn.HeaderText = "DateDebut";
			this.dateDebutDataGridViewTextBoxColumn.Name = "dateDebutDataGridViewTextBoxColumn";
			// 
			// dateFinDataGridViewTextBoxColumn
			// 
			this.dateFinDataGridViewTextBoxColumn.DataPropertyName = "DateFin";
			this.dateFinDataGridViewTextBoxColumn.HeaderText = "DateFin";
			this.dateFinDataGridViewTextBoxColumn.Name = "dateFinDataGridViewTextBoxColumn";
			// 
			// matiereDataGridViewTextBoxColumn
			// 
			this.matiereDataGridViewTextBoxColumn.DataPropertyName = "Matiere";
			this.matiereDataGridViewTextBoxColumn.HeaderText = "Matiere";
			this.matiereDataGridViewTextBoxColumn.Name = "matiereDataGridViewTextBoxColumn";
			// 
			// questionDataGridViewTextBoxColumn
			// 
			this.questionDataGridViewTextBoxColumn.DataPropertyName = "Question";
			this.questionDataGridViewTextBoxColumn.HeaderText = "Question";
			this.questionDataGridViewTextBoxColumn.Name = "questionDataGridViewTextBoxColumn";
			// 
			// reponseDataGridViewTextBoxColumn
			// 
			this.reponseDataGridViewTextBoxColumn.DataPropertyName = "Reponse";
			this.reponseDataGridViewTextBoxColumn.HeaderText = "Reponse";
			this.reponseDataGridViewTextBoxColumn.Name = "reponseDataGridViewTextBoxColumn";
			// 
			// exameDataSet
			// 
			this.exameDataSet.DataSetName = "ExameDataSet";
			this.exameDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// eXBindingSource
			// 
			this.eXBindingSource.DataMember = "EX";
			this.eXBindingSource.DataSource = this.exameDataSet;
			// 
			// eXTableAdapter
			// 
			this.eXTableAdapter.ClearBeforeFill = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(668, 389);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.examenDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.eXMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.exameDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.eXBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DataGridView dataGridView1;
		private ExamenDataSet examenDataSet;
		private System.Windows.Forms.BindingSource eXMBindingSource;
		private ExamenDataSetTableAdapters.EXMTableAdapter eXMTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateDebutDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateFinDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn matiereDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn questionDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn reponseDataGridViewTextBoxColumn;
		private ExameDataSet exameDataSet;
		private System.Windows.Forms.BindingSource eXBindingSource;
		private ExameDataSetTableAdapters.EXTableAdapter eXTableAdapter;
	}
}

