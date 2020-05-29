namespace Odlot
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.wyswietl2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.systemLotowDataSet = new Odlot.SystemLotowDataSet();
            this.wyswietl2TableAdapter = new Odlot.SystemLotowDataSetTableAdapters.Wyswietl2TableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.systemLotowDataSet1 = new Odlot.SystemLotowDataSet1();
            this.widokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.widokTableAdapter = new Odlot.SystemLotowDataSet1TableAdapters.WidokTableAdapter();
            this.systemLotowDataSet2 = new Odlot.SystemLotowDataSet2();
            this.widok1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.widok1TableAdapter = new Odlot.SystemLotowDataSet2TableAdapters.Widok1TableAdapter();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.systemLotowDataSet3 = new Odlot.SystemLotowDataSet3();
            this.widok3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.widok3TableAdapter = new Odlot.SystemLotowDataSet3TableAdapters.Widok3TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.wyswietl2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemLotowDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemLotowDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widokBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemLotowDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widok1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemLotowDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widok3BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Warszawa",
            "Lublin ",
            "Moskwa ",
            "Londyn"});
            this.comboBox1.Location = new System.Drawing.Point(13, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wybierz lotnisko";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Erbas",
            "Tupolew",
            "Lotnik",
            "Lotnik2"});
            this.comboBox2.Location = new System.Drawing.Point(391, 18);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Samolot";
            // 
            // wyswietl2BindingSource
            // 
            this.wyswietl2BindingSource.DataMember = "Wyswietl2";
            this.wyswietl2BindingSource.DataSource = this.systemLotowDataSet;
            // 
            // systemLotowDataSet
            // 
            this.systemLotowDataSet.DataSetName = "SystemLotowDataSet";
            this.systemLotowDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wyswietl2TableAdapter
            // 
            this.wyswietl2TableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ilosc osob ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 342);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 40);
            this.button2.TabIndex = 7;
            this.button2.Text = "Jakie samoloty ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox2
            // 
            this.listBox2.DataSource = this.wyswietl2BindingSource;
            this.listBox2.DisplayMember = "dokad";
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(13, 56);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(185, 199);
            this.listBox2.TabIndex = 8;
            this.listBox2.ValueMember = "zKad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "label3";
            // 
            // systemLotowDataSet1
            // 
            this.systemLotowDataSet1.DataSetName = "SystemLotowDataSet1";
            this.systemLotowDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // widokBindingSource
            // 
            this.widokBindingSource.DataMember = "Widok";
            this.widokBindingSource.DataSource = this.systemLotowDataSet1;
            // 
            // widokTableAdapter
            // 
            this.widokTableAdapter.ClearBeforeFill = true;
            // 
            // systemLotowDataSet2
            // 
            this.systemLotowDataSet2.DataSetName = "SystemLotowDataSet2";
            this.systemLotowDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // widok1BindingSource
            // 
            this.widok1BindingSource.DataMember = "Widok1";
            this.widok1BindingSource.DataSource = this.systemLotowDataSet2;
            // 
            // widok1TableAdapter
            // 
            this.widok1TableAdapter.ClearBeforeFill = true;
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.widok3BindingSource;
            this.listBox1.DisplayMember = "Opis";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(380, 69);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(177, 199);
            this.listBox1.TabIndex = 10;
            this.listBox1.ValueMember = "Opis";
            // 
            // systemLotowDataSet3
            // 
            this.systemLotowDataSet3.DataSetName = "SystemLotowDataSet3";
            this.systemLotowDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // widok3BindingSource
            // 
            this.widok3BindingSource.DataMember = "Widok3";
            this.widok3BindingSource.DataSource = this.systemLotowDataSet3;
            // 
            // widok3TableAdapter
            // 
            this.widok3TableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 430);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wyswietl2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemLotowDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemLotowDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widokBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemLotowDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widok1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemLotowDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widok3BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource wyswietl2BindingSource;
        private SystemLotowDataSet systemLotowDataSet;
        private SystemLotowDataSetTableAdapters.Wyswietl2TableAdapter wyswietl2TableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label3;
        private SystemLotowDataSet1 systemLotowDataSet1;
        private System.Windows.Forms.BindingSource widokBindingSource;
        private SystemLotowDataSet1TableAdapters.WidokTableAdapter widokTableAdapter;
        private SystemLotowDataSet2 systemLotowDataSet2;
        private System.Windows.Forms.BindingSource widok1BindingSource;
        private SystemLotowDataSet2TableAdapters.Widok1TableAdapter widok1TableAdapter;
        private System.Windows.Forms.ListBox listBox1;
        private SystemLotowDataSet3 systemLotowDataSet3;
        private System.Windows.Forms.BindingSource widok3BindingSource;
        private SystemLotowDataSet3TableAdapters.Widok3TableAdapter widok3TableAdapter;
    }
}

