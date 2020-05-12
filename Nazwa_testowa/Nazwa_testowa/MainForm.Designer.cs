using System;
namespace Alledrogo
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button_zaloguj = new System.Windows.Forms.Button();
            this.lb_uzytkownik = new System.Windows.Forms.Label();
            this.lb_user_status = new System.Windows.Forms.Label();
            this.Koszyk_button = new System.Windows.Forms.Button();
            this.koszyk_counter = new System.Windows.Forms.Label();
            this.zNorthwindDataSet = new Alledrogo.ZNorthwindDataSet();
            this.produktyTableAdapter = new Alledrogo.ZNorthwindDataSetTableAdapters.ProduktyTableAdapter();
            this.tableAdapterManager = new Alledrogo.ZNorthwindDataSetTableAdapters.TableAdapterManager();
            this.produkty_DataGridView = new System.Windows.Forms.DataGridView();
            this.produktyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_dodaj = new System.Windows.Forms.Button();
            this.button_wyloguj = new System.Windows.Forms.Button();
            this.textBox_szukaj = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label_kategorie = new System.Windows.Forms.Label();
            this.comboBox_kategorie = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button_Rejestracja = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn_NazwaProduktu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_IloscJednostkowa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_CenaJednostkowa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDproduktu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.zNorthwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produkty_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktyBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // button_zaloguj
            // 
            this.button_zaloguj.BackColor = System.Drawing.Color.Gray;
            this.button_zaloguj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_zaloguj.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.button_zaloguj.ForeColor = System.Drawing.Color.White;
            this.button_zaloguj.Location = new System.Drawing.Point(0, 116);
            this.button_zaloguj.Margin = new System.Windows.Forms.Padding(2);
            this.button_zaloguj.Name = "button_zaloguj";
            this.button_zaloguj.Size = new System.Drawing.Size(220, 37);
            this.button_zaloguj.TabIndex = 0;
            this.button_zaloguj.Text = "Zaloguj się";
            this.button_zaloguj.UseVisualStyleBackColor = false;
            this.button_zaloguj.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_Zaloguj_MouseClick);
            // 
            // lb_uzytkownik
            // 
            this.lb_uzytkownik.AutoSize = true;
            this.lb_uzytkownik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_uzytkownik.Location = new System.Drawing.Point(1043, 76);
            this.lb_uzytkownik.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_uzytkownik.Name = "lb_uzytkownik";
            this.lb_uzytkownik.Size = new System.Drawing.Size(74, 15);
            this.lb_uzytkownik.TabIndex = 1;
            this.lb_uzytkownik.Text = "Użytkownik :";
            // 
            // lb_user_status
            // 
            this.lb_user_status.AutoSize = true;
            this.lb_user_status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lb_user_status.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_user_status.ForeColor = System.Drawing.Color.White;
            this.lb_user_status.Location = new System.Drawing.Point(45, 35);
            this.lb_user_status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_user_status.Name = "lb_user_status";
            this.lb_user_status.Size = new System.Drawing.Size(127, 20);
            this.lb_user_status.TabIndex = 2;
            this.lb_user_status.Text = "Nie zalogowany";
            // 
            // Koszyk_button
            // 
            this.Koszyk_button.BackColor = System.Drawing.Color.Gray;
            this.Koszyk_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Koszyk_button.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.Koszyk_button.ForeColor = System.Drawing.Color.White;
            this.Koszyk_button.Location = new System.Drawing.Point(0, 190);
            this.Koszyk_button.Margin = new System.Windows.Forms.Padding(2);
            this.Koszyk_button.Name = "Koszyk_button";
            this.Koszyk_button.Size = new System.Drawing.Size(220, 37);
            this.Koszyk_button.TabIndex = 3;
            this.Koszyk_button.Text = "Koszyk";
            this.Koszyk_button.UseVisualStyleBackColor = false;
            this.Koszyk_button.Click += new System.EventHandler(this.Button_koszyk_Click);
            // 
            // koszyk_counter
            // 
            this.koszyk_counter.AutoSize = true;
            this.koszyk_counter.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.koszyk_counter.Location = new System.Drawing.Point(98, 162);
            this.koszyk_counter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.koszyk_counter.Name = "koszyk_counter";
            this.koszyk_counter.Size = new System.Drawing.Size(21, 22);
            this.koszyk_counter.TabIndex = 4;
            this.koszyk_counter.Text = "0";
            // 
            // zNorthwindDataSet
            // 
            this.zNorthwindDataSet.DataSetName = "ZNorthwindDataSet";
            this.zNorthwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produktyTableAdapter
            // 
            this.produktyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DostawcyTableAdapter = null;
            this.tableAdapterManager.KategorieTableAdapter = null;
            this.tableAdapterManager.KlienciTableAdapter = null;
            this.tableAdapterManager.PozycjeZamówieniaTableAdapter = null;
            this.tableAdapterManager.PracownicyTableAdapter = null;
            this.tableAdapterManager.ProduktyTableAdapter = this.produktyTableAdapter;
            this.tableAdapterManager.SpedytorzyTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Alledrogo.ZNorthwindDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZamówieniaTableAdapter = null;
            // 
            // produkty_DataGridView
            // 
            this.produkty_DataGridView.AllowUserToAddRows = false;
            this.produkty_DataGridView.AllowUserToDeleteRows = false;
            this.produkty_DataGridView.AllowUserToResizeColumns = false;
            this.produkty_DataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LightSlateGray;
            this.produkty_DataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.produkty_DataGridView.AutoGenerateColumns = false;
            this.produkty_DataGridView.BackgroundColor = System.Drawing.Color.White;
            this.produkty_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produkty_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn_NazwaProduktu,
            this.dataGridViewTextBoxColumn_IloscJednostkowa,
            this.dataGridViewTextBoxColumn_CenaJednostkowa,
            this.IDproduktu});
            this.produkty_DataGridView.DataSource = this.produktyBindingSource;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle11.Format = "N2";
            dataGridViewCellStyle11.NullValue = null;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.produkty_DataGridView.DefaultCellStyle = dataGridViewCellStyle11;
            this.produkty_DataGridView.GridColor = System.Drawing.Color.Salmon;
            this.produkty_DataGridView.Location = new System.Drawing.Point(142, 205);
            this.produkty_DataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.produkty_DataGridView.Name = "produkty_DataGridView";
            this.produkty_DataGridView.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Format = "N2";
            dataGridViewCellStyle12.NullValue = null;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.produkty_DataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.produkty_DataGridView.RowHeadersVisible = false;
            this.produkty_DataGridView.RowHeadersWidth = 51;
            this.produkty_DataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gray;
            this.produkty_DataGridView.RowTemplate.Height = 24;
            this.produkty_DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.produkty_DataGridView.Size = new System.Drawing.Size(398, 348);
            this.produkty_DataGridView.TabIndex = 6;
            // 
            // produktyBindingSource
            // 
            this.produktyBindingSource.DataMember = "Produkty";
            this.produktyBindingSource.DataSource = this.zNorthwindDataSet;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDproduktu";
            this.dataGridViewTextBoxColumn1.HeaderText = "IDproduktu";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IDdostawcy";
            this.dataGridViewTextBoxColumn3.HeaderText = "IDdostawcy";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IDkategorii";
            this.dataGridViewTextBoxColumn4.HeaderText = "IDkategorii";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "StanMagazynu";
            this.dataGridViewTextBoxColumn7.HeaderText = "StanMagazynu";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "IlośćZamówiona";
            this.dataGridViewTextBoxColumn8.HeaderText = "IlośćZamówiona";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "StanMinimum";
            this.dataGridViewTextBoxColumn9.HeaderText = "StanMinimum";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // button_dodaj
            // 
            this.button_dodaj.BackColor = System.Drawing.Color.Gray;
            this.button_dodaj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_dodaj.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.button_dodaj.ForeColor = System.Drawing.Color.White;
            this.button_dodaj.Location = new System.Drawing.Point(0, 227);
            this.button_dodaj.Margin = new System.Windows.Forms.Padding(2);
            this.button_dodaj.Name = "button_dodaj";
            this.button_dodaj.Size = new System.Drawing.Size(220, 37);
            this.button_dodaj.TabIndex = 13;
            this.button_dodaj.Text = "Dodaj";
            this.button_dodaj.UseVisualStyleBackColor = false;
            this.button_dodaj.Click += new System.EventHandler(this.Button_dodaj_Click);
            // 
            // button_wyloguj
            // 
            this.button_wyloguj.BackColor = System.Drawing.Color.Gray;
            this.button_wyloguj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_wyloguj.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.button_wyloguj.ForeColor = System.Drawing.Color.White;
            this.button_wyloguj.Location = new System.Drawing.Point(0, 116);
            this.button_wyloguj.Margin = new System.Windows.Forms.Padding(2);
            this.button_wyloguj.Name = "button_wyloguj";
            this.button_wyloguj.Size = new System.Drawing.Size(220, 37);
            this.button_wyloguj.TabIndex = 20;
            this.button_wyloguj.Text = "Wyloguj";
            this.button_wyloguj.UseVisualStyleBackColor = false;
            this.button_wyloguj.Visible = false;
            this.button_wyloguj.Click += new System.EventHandler(this.button_Wyloguj_Click);
            // 
            // textBox_szukaj
            // 
            this.textBox_szukaj.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_szukaj.Location = new System.Drawing.Point(143, 162);
            this.textBox_szukaj.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_szukaj.Name = "textBox_szukaj";
            this.textBox_szukaj.Size = new System.Drawing.Size(210, 23);
            this.textBox_szukaj.TabIndex = 15;
            this.textBox_szukaj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_szukaj_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(139, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "Szukaj :";
            // 
            // label_kategorie
            // 
            this.label_kategorie.AutoSize = true;
            this.label_kategorie.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_kategorie.ForeColor = System.Drawing.Color.White;
            this.label_kategorie.Location = new System.Drawing.Point(415, 140);
            this.label_kategorie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_kategorie.Name = "label_kategorie";
            this.label_kategorie.Size = new System.Drawing.Size(89, 20);
            this.label_kategorie.TabIndex = 18;
            this.label_kategorie.Text = "Kategorie :";
            // 
            // comboBox_kategorie
            // 
            this.comboBox_kategorie.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_kategorie.FormattingEnabled = true;
            this.comboBox_kategorie.Items.AddRange(new object[] {
            "[ Wybierz ]",
            "Napoje",
            "Przyprawy",
            "Słodycze",
            "Nabiał",
            "Produkty zbożowe",
            "Mięso/Drób",
            "Bakalie",
            "Ryby"});
            this.comboBox_kategorie.Location = new System.Drawing.Point(419, 162);
            this.comboBox_kategorie.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_kategorie.Name = "comboBox_kategorie";
            this.comboBox_kategorie.Size = new System.Drawing.Size(122, 25);
            this.comboBox_kategorie.TabIndex = 19;
            this.comboBox_kategorie.Text = "[ Wybierz ]";
            this.comboBox_kategorie.SelectedIndexChanged += new System.EventHandler(this.comboBox_kategorie_SelectedIndexChanged);
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
            this.panel3.TabIndex = 21;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(759, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(119, 118);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(92)))), ((int)(((byte)(8)))));
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.button_Rejestracja);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.koszyk_counter);
            this.panel2.Controls.Add(this.button_zaloguj);
            this.panel2.Controls.Add(this.button_wyloguj);
            this.panel2.Controls.Add(this.lb_user_status);
            this.panel2.Controls.Add(this.button_dodaj);
            this.panel2.Controls.Add(this.Koszyk_button);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(706, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 428);
            this.panel2.TabIndex = 22;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(87, 321);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(52, 49);
            this.pictureBox5.TabIndex = 25;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(31, 321);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(52, 49);
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(143, 321);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(52, 49);
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // button_Rejestracja
            // 
            this.button_Rejestracja.BackColor = System.Drawing.Color.Gray;
            this.button_Rejestracja.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Rejestracja.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.button_Rejestracja.ForeColor = System.Drawing.Color.White;
            this.button_Rejestracja.Location = new System.Drawing.Point(0, 79);
            this.button_Rejestracja.Margin = new System.Windows.Forms.Padding(2);
            this.button_Rejestracja.Name = "button_Rejestracja";
            this.button_Rejestracja.Size = new System.Drawing.Size(220, 37);
            this.button_Rejestracja.TabIndex = 22;
            this.button_Rejestracja.Text = "Rejestracja";
            this.button_Rejestracja.UseVisualStyleBackColor = false;
            this.button_Rejestracja.Click += new System.EventHandler(this.button_Rejestracja_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Użytkownik :";
            // 
            // dataGridViewTextBoxColumn_NazwaProduktu
            // 
            this.dataGridViewTextBoxColumn_NazwaProduktu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_NazwaProduktu.DataPropertyName = "NazwaProduktu";
            this.dataGridViewTextBoxColumn_NazwaProduktu.FillWeight = 130.4849F;
            this.dataGridViewTextBoxColumn_NazwaProduktu.HeaderText = "NazwaProduktu";
            this.dataGridViewTextBoxColumn_NazwaProduktu.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn_NazwaProduktu.Name = "dataGridViewTextBoxColumn_NazwaProduktu";
            this.dataGridViewTextBoxColumn_NazwaProduktu.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn_IloscJednostkowa
            // 
            this.dataGridViewTextBoxColumn_IloscJednostkowa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_IloscJednostkowa.DataPropertyName = "IlośćJednostkowa";
            this.dataGridViewTextBoxColumn_IloscJednostkowa.FillWeight = 116.5739F;
            this.dataGridViewTextBoxColumn_IloscJednostkowa.HeaderText = "Ilość w opakowaniu";
            this.dataGridViewTextBoxColumn_IloscJednostkowa.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn_IloscJednostkowa.Name = "dataGridViewTextBoxColumn_IloscJednostkowa";
            this.dataGridViewTextBoxColumn_IloscJednostkowa.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn_CenaJednostkowa
            // 
            this.dataGridViewTextBoxColumn_CenaJednostkowa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn_CenaJednostkowa.DataPropertyName = "CenaJednostkowa";
            this.dataGridViewTextBoxColumn_CenaJednostkowa.FillWeight = 52.94118F;
            this.dataGridViewTextBoxColumn_CenaJednostkowa.HeaderText = "Cena";
            this.dataGridViewTextBoxColumn_CenaJednostkowa.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn_CenaJednostkowa.Name = "dataGridViewTextBoxColumn_CenaJednostkowa";
            this.dataGridViewTextBoxColumn_CenaJednostkowa.ReadOnly = true;
            // 
            // IDproduktu
            // 
            this.IDproduktu.DataPropertyName = "IDproduktu";
            this.IDproduktu.HeaderText = "IDproduktu";
            this.IDproduktu.MinimumWidth = 6;
            this.IDproduktu.Name = "IDproduktu";
            this.IDproduktu.ReadOnly = true;
            this.IDproduktu.Visible = false;
            this.IDproduktu.Width = 125;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(926, 553);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.comboBox_kategorie);
            this.Controls.Add(this.label_kategorie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_szukaj);
            this.Controls.Add(this.produkty_DataGridView);
            this.Controls.Add(this.lb_uzytkownik);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alledrogo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zNorthwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produkty_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktyBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_zaloguj;
        private System.Windows.Forms.Label lb_uzytkownik;
        private System.Windows.Forms.Label lb_user_status;
        private System.Windows.Forms.Button Koszyk_button;
        private System.Windows.Forms.Label koszyk_counter;
        private ZNorthwindDataSet zNorthwindDataSet;
        private ZNorthwindDataSetTableAdapters.ProduktyTableAdapter produktyTableAdapter;
        private ZNorthwindDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView produkty_DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Button button_dodaj;
        private System.Windows.Forms.TextBox textBox_szukaj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_kategorie;
        private System.Windows.Forms.ComboBox comboBox_kategorie;
        private System.Windows.Forms.Button button_wyloguj;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Rejestracja;
        private System.Windows.Forms.BindingSource produktyBindingSource;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn_NazwaProduktu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn_IloscJednostkowa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn_CenaJednostkowa;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDproduktu;
    }
}

