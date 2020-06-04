namespace Alledrogo
{
    partial class Koszyk
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Koszyk));
            this.textBox_do_zaplaty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_usun = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Kup = new System.Windows.Forms.Button();
            this.zNorthwindDataSet = new Alledrogo.ZNorthwindDataSet();
            this.produktyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produktyTableAdapter = new Alledrogo.ZNorthwindDataSetTableAdapters.ProduktyTableAdapter();
            this.zNorthwindDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produktyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.DataGridView_koszyk = new System.Windows.Forms.DataGridView();
            this.NazwaProduktu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IloscJednostkowa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Ilosc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CenaJednostkowa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDproduktu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.zNorthwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zNorthwindDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_koszyk)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_do_zaplaty
            // 
            this.textBox_do_zaplaty.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_do_zaplaty.Location = new System.Drawing.Point(487, 505);
            this.textBox_do_zaplaty.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_do_zaplaty.Name = "textBox_do_zaplaty";
            this.textBox_do_zaplaty.ReadOnly = true;
            this.textBox_do_zaplaty.Size = new System.Drawing.Size(89, 27);
            this.textBox_do_zaplaty.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(388, 512);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Do zapłaty :";
            // 
            // button_usun
            // 
            this.button_usun.BackColor = System.Drawing.Color.Gray;
            this.button_usun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_usun.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.button_usun.ForeColor = System.Drawing.Color.White;
            this.button_usun.Location = new System.Drawing.Point(21, 98);
            this.button_usun.Margin = new System.Windows.Forms.Padding(2);
            this.button_usun.Name = "button_usun";
            this.button_usun.Size = new System.Drawing.Size(180, 36);
            this.button_usun.TabIndex = 5;
            this.button_usun.Text = "Usuń";
            this.button_usun.UseVisualStyleBackColor = false;
            this.button_usun.Click += new System.EventHandler(this.button_usun_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(239, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 36);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lista Zakupów";
            // 
            // button_Kup
            // 
            this.button_Kup.BackColor = System.Drawing.Color.Gray;
            this.button_Kup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Kup.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.button_Kup.ForeColor = System.Drawing.Color.White;
            this.button_Kup.Location = new System.Drawing.Point(21, 62);
            this.button_Kup.Margin = new System.Windows.Forms.Padding(2);
            this.button_Kup.Name = "button_Kup";
            this.button_Kup.Size = new System.Drawing.Size(180, 36);
            this.button_Kup.TabIndex = 8;
            this.button_Kup.Text = "Kup";
            this.button_Kup.UseVisualStyleBackColor = false;
            this.button_Kup.Click += new System.EventHandler(this.button_Kup_Click);
            // 
            // zNorthwindDataSet
            // 
            this.zNorthwindDataSet.DataSetName = "ZNorthwindDataSet";
            this.zNorthwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produktyBindingSource
            // 
            this.produktyBindingSource.DataMember = "Produkty";
            this.produktyBindingSource.DataSource = this.zNorthwindDataSet;
            // 
            // produktyTableAdapter
            // 
            this.produktyTableAdapter.ClearBeforeFill = true;
            // 
            // zNorthwindDataSetBindingSource
            // 
            this.zNorthwindDataSetBindingSource.DataSource = this.zNorthwindDataSet;
            this.zNorthwindDataSetBindingSource.Position = 0;
            // 
            // produktyBindingSource1
            // 
            this.produktyBindingSource1.DataMember = "Produkty";
            this.produktyBindingSource1.DataSource = this.zNorthwindDataSetBindingSource;
            // 
            // DataGridView_koszyk
            // 
            this.DataGridView_koszyk.AllowUserToAddRows = false;
            this.DataGridView_koszyk.AllowUserToDeleteRows = false;
            this.DataGridView_koszyk.AllowUserToResizeColumns = false;
            this.DataGridView_koszyk.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.NullValue = null;
            this.DataGridView_koszyk.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView_koszyk.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_koszyk.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView_koszyk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_koszyk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NazwaProduktu,
            this.IloscJednostkowa,
            this.Column_Ilosc,
            this.CenaJednostkowa,
            this.IDproduktu});
            this.DataGridView_koszyk.GridColor = System.Drawing.Color.Salmon;
            this.DataGridView_koszyk.Location = new System.Drawing.Point(118, 175);
            this.DataGridView_koszyk.Margin = new System.Windows.Forms.Padding(2);
            this.DataGridView_koszyk.Name = "DataGridView_koszyk";
            this.DataGridView_koszyk.ReadOnly = true;
            this.DataGridView_koszyk.RowHeadersVisible = false;
            this.DataGridView_koszyk.RowHeadersWidth = 51;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.DataGridView_koszyk.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView_koszyk.RowTemplate.Height = 24;
            this.DataGridView_koszyk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_koszyk.Size = new System.Drawing.Size(458, 317);
            this.DataGridView_koszyk.TabIndex = 10;
            // 
            // NazwaProduktu
            // 
            this.NazwaProduktu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NazwaProduktu.FillWeight = 169.5438F;
            this.NazwaProduktu.HeaderText = "NazwaProduktu";
            this.NazwaProduktu.MinimumWidth = 6;
            this.NazwaProduktu.Name = "NazwaProduktu";
            this.NazwaProduktu.ReadOnly = true;
            // 
            // IloscJednostkowa
            // 
            this.IloscJednostkowa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IloscJednostkowa.FillWeight = 95.60748F;
            this.IloscJednostkowa.HeaderText = "IloscJednostkowa";
            this.IloscJednostkowa.MinimumWidth = 6;
            this.IloscJednostkowa.Name = "IloscJednostkowa";
            this.IloscJednostkowa.ReadOnly = true;
            // 
            // Column_Ilosc
            // 
            this.Column_Ilosc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Ilosc.FillWeight = 36.95675F;
            this.Column_Ilosc.HeaderText = "Ilosc";
            this.Column_Ilosc.MinimumWidth = 6;
            this.Column_Ilosc.Name = "Column_Ilosc";
            this.Column_Ilosc.ReadOnly = true;
            // 
            // CenaJednostkowa
            // 
            this.CenaJednostkowa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CenaJednostkowa.FillWeight = 102.7578F;
            this.CenaJednostkowa.HeaderText = "CenaJednostkowa";
            this.CenaJednostkowa.MinimumWidth = 6;
            this.CenaJednostkowa.Name = "CenaJednostkowa";
            this.CenaJednostkowa.ReadOnly = true;
            // 
            // IDproduktu
            // 
            this.IDproduktu.HeaderText = "IDproduktu";
            this.IDproduktu.MinimumWidth = 6;
            this.IDproduktu.Name = "IDproduktu";
            this.IDproduktu.ReadOnly = true;
            this.IDproduktu.Visible = false;
            this.IDproduktu.Width = 125;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(92)))), ((int)(((byte)(8)))));
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.button_Kup);
            this.panel2.Controls.Add(this.button_usun);
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel2.Location = new System.Drawing.Point(706, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 428);
            this.panel2.TabIndex = 23;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(88, 318);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(52, 49);
            this.pictureBox5.TabIndex = 28;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(32, 318);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(52, 49);
            this.pictureBox4.TabIndex = 27;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(144, 318);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(52, 49);
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel3.Size = new System.Drawing.Size(926, 125);
            this.panel3.TabIndex = 24;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(760, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(114, 118);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(118, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(458, 113);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Koszyk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(926, 553);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DataGridView_koszyk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_do_zaplaty);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Koszyk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alledrogo";
            ((System.ComponentModel.ISupportInitialize)(this.zNorthwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zNorthwindDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_koszyk)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox textBox_do_zaplaty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_usun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Kup;
        private ZNorthwindDataSet zNorthwindDataSet;
        private System.Windows.Forms.BindingSource produktyBindingSource;
        private ZNorthwindDataSetTableAdapters.ProduktyTableAdapter produktyTableAdapter;
        private System.Windows.Forms.BindingSource produktyBindingSource1;
        private System.Windows.Forms.BindingSource zNorthwindDataSetBindingSource;
        public System.Windows.Forms.DataGridView DataGridView_koszyk;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazwaProduktu;
        private System.Windows.Forms.DataGridViewTextBoxColumn IloscJednostkowa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Ilosc;
        private System.Windows.Forms.DataGridViewTextBoxColumn CenaJednostkowa;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDproduktu;
    }
}