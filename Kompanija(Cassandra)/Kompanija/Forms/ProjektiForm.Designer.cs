namespace Kompanija.Forms
{
    partial class ProjektiForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvProjekti = new System.Windows.Forms.DataGridView();
            this.naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prioritet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumpocetka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rokkraja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumkraja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjekti)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProjekti
            // 
            this.dgvProjekti.AllowUserToAddRows = false;
            this.dgvProjekti.AllowUserToDeleteRows = false;
            this.dgvProjekti.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProjekti.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProjekti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjekti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.naziv,
            this.prioritet,
            this.datumpocetka,
            this.rokkraja,
            this.datumkraja});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProjekti.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProjekti.Location = new System.Drawing.Point(12, 34);
            this.dgvProjekti.MultiSelect = false;
            this.dgvProjekti.Name = "dgvProjekti";
            this.dgvProjekti.ReadOnly = true;
            this.dgvProjekti.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProjekti.RowTemplate.Height = 25;
            this.dgvProjekti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProjekti.Size = new System.Drawing.Size(825, 331);
            this.dgvProjekti.TabIndex = 0;
            // 
            // naziv
            // 
            this.naziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.naziv.HeaderText = "Naziv";
            this.naziv.Name = "naziv";
            this.naziv.ReadOnly = true;
            // 
            // prioritet
            // 
            this.prioritet.HeaderText = "Prioritet";
            this.prioritet.Name = "prioritet";
            this.prioritet.ReadOnly = true;
            // 
            // datumpocetka
            // 
            this.datumpocetka.HeaderText = "Datum pocetka";
            this.datumpocetka.Name = "datumpocetka";
            this.datumpocetka.ReadOnly = true;
            this.datumpocetka.Width = 180;
            // 
            // rokkraja
            // 
            this.rokkraja.HeaderText = "Rok kraja";
            this.rokkraja.Name = "rokkraja";
            this.rokkraja.ReadOnly = true;
            this.rokkraja.Width = 150;
            // 
            // datumkraja
            // 
            this.datumkraja.HeaderText = "Datum kraja";
            this.datumkraja.Name = "datumkraja";
            this.datumkraja.ReadOnly = true;
            this.datumkraja.Width = 150;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDodaj.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDodaj.Location = new System.Drawing.Point(12, 384);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(250, 40);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj projekat";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.BackColor = System.Drawing.Color.CadetBlue;
            this.btnIzmeni.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIzmeni.Location = new System.Drawing.Point(299, 384);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(250, 40);
            this.btnIzmeni.TabIndex = 2;
            this.btnIzmeni.Text = "Izmeni projekat";
            this.btnIzmeni.UseVisualStyleBackColor = false;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.IndianRed;
            this.btnObrisi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnObrisi.Location = new System.Drawing.Point(587, 384);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(250, 40);
            this.btnObrisi.TabIndex = 3;
            this.btnObrisi.Text = "Obrisi projekat";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Projekti:";
            // 
            // ProjektiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(849, 441);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvProjekti);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ProjektiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ProjektiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjekti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvProjekti;
        private Button btnDodaj;
        private Button btnIzmeni;
        private Button btnObrisi;
        private Label label1;
        private DataGridViewTextBoxColumn naziv;
        private DataGridViewTextBoxColumn prioritet;
        private DataGridViewTextBoxColumn datumpocetka;
        private DataGridViewTextBoxColumn rokkraja;
        private DataGridViewTextBoxColumn datumkraja;
    }
}