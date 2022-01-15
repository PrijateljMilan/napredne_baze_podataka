namespace Kompanija.Forms
{
    partial class ProjekatVodjaForm
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnAzuriraj = new System.Windows.Forms.Button();
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProjekti.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProjekti.Location = new System.Drawing.Point(12, 12);
            this.dgvProjekti.MultiSelect = false;
            this.dgvProjekti.Name = "dgvProjekti";
            this.dgvProjekti.ReadOnly = true;
            this.dgvProjekti.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProjekti.RowTemplate.Height = 25;
            this.dgvProjekti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProjekti.Size = new System.Drawing.Size(947, 360);
            this.dgvProjekti.TabIndex = 0;
            // 
            // naziv
            // 
            this.naziv.HeaderText = "Naziv";
            this.naziv.Name = "naziv";
            this.naziv.ReadOnly = true;
            this.naziv.Width = 200;
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
            this.datumpocetka.Width = 200;
            // 
            // rokkraja
            // 
            this.rokkraja.HeaderText = "Rok zavrsetka";
            this.rokkraja.Name = "rokkraja";
            this.rokkraja.ReadOnly = true;
            this.rokkraja.Width = 200;
            // 
            // datumkraja
            // 
            this.datumkraja.HeaderText = "Datum zavrsetka";
            this.datumkraja.Name = "datumkraja";
            this.datumkraja.ReadOnly = true;
            this.datumkraja.Width = 200;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Location = new System.Drawing.Point(443, 404);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(275, 27);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAzuriraj.Location = new System.Drawing.Point(724, 386);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(235, 45);
            this.btnAzuriraj.TabIndex = 2;
            this.btnAzuriraj.Text = "Azuriraj datum kraja";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // ProjekatVodjaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(971, 450);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dgvProjekti);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ProjekatVodjaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ProjekatVodjaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjekti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvProjekti;
        private DateTimePicker dateTimePicker1;
        private Button btnAzuriraj;
        private DataGridViewTextBoxColumn naziv;
        private DataGridViewTextBoxColumn prioritet;
        private DataGridViewTextBoxColumn datumpocetka;
        private DataGridViewTextBoxColumn rokkraja;
        private DataGridViewTextBoxColumn datumkraja;
    }
}