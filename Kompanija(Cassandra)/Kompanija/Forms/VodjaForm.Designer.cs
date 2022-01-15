namespace Kompanija.Forms
{
    partial class VodjaForm
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
            this.lbemail = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbprezime = new System.Windows.Forms.Label();
            this.lbime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFormiraj = new System.Windows.Forms.Button();
            this.btnPregledTima = new System.Windows.Forms.Button();
            this.btnPregledProjekta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbemail
            // 
            this.lbemail.AutoSize = true;
            this.lbemail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbemail.ForeColor = System.Drawing.SystemColors.Control;
            this.lbemail.Location = new System.Drawing.Point(105, 69);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(52, 21);
            this.lbemail.TabIndex = 15;
            this.lbemail.Text = "email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(54)))), ((int)(((byte)(70)))));
            this.label3.Location = new System.Drawing.Point(42, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Email:";
            // 
            // lbprezime
            // 
            this.lbprezime.AutoSize = true;
            this.lbprezime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbprezime.ForeColor = System.Drawing.SystemColors.Control;
            this.lbprezime.Location = new System.Drawing.Point(105, 48);
            this.lbprezime.Name = "lbprezime";
            this.lbprezime.Size = new System.Drawing.Size(71, 21);
            this.lbprezime.TabIndex = 13;
            this.lbprezime.Text = "prezime";
            // 
            // lbime
            // 
            this.lbime.AutoSize = true;
            this.lbime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbime.ForeColor = System.Drawing.SystemColors.Control;
            this.lbime.Location = new System.Drawing.Point(105, 27);
            this.lbime.Name = "lbime";
            this.lbime.Size = new System.Drawing.Size(38, 21);
            this.lbime.TabIndex = 12;
            this.lbime.Text = "ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(54)))), ((int)(((byte)(70)))));
            this.label2.Location = new System.Drawing.Point(26, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Prezime:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(54)))), ((int)(((byte)(70)))));
            this.label1.Location = new System.Drawing.Point(55, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ime:";
            // 
            // btnFormiraj
            // 
            this.btnFormiraj.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFormiraj.Location = new System.Drawing.Point(26, 135);
            this.btnFormiraj.Name = "btnFormiraj";
            this.btnFormiraj.Size = new System.Drawing.Size(327, 33);
            this.btnFormiraj.TabIndex = 16;
            this.btnFormiraj.Text = "Formiraj tim";
            this.btnFormiraj.UseVisualStyleBackColor = true;
            this.btnFormiraj.Click += new System.EventHandler(this.btnFormiraj_Click);
            // 
            // btnPregledTima
            // 
            this.btnPregledTima.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPregledTima.Location = new System.Drawing.Point(26, 174);
            this.btnPregledTima.Name = "btnPregledTima";
            this.btnPregledTima.Size = new System.Drawing.Size(327, 33);
            this.btnPregledTima.TabIndex = 17;
            this.btnPregledTima.Text = "Pregled tima";
            this.btnPregledTima.UseVisualStyleBackColor = true;
            this.btnPregledTima.Click += new System.EventHandler(this.btnPregledTima_Click);
            // 
            // btnPregledProjekta
            // 
            this.btnPregledProjekta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPregledProjekta.Location = new System.Drawing.Point(26, 213);
            this.btnPregledProjekta.Name = "btnPregledProjekta";
            this.btnPregledProjekta.Size = new System.Drawing.Size(327, 33);
            this.btnPregledProjekta.TabIndex = 18;
            this.btnPregledProjekta.Text = "Pregled projekta";
            this.btnPregledProjekta.UseVisualStyleBackColor = true;
            this.btnPregledProjekta.Click += new System.EventHandler(this.btnPregledProjekta_Click);
            // 
            // VodjaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(379, 276);
            this.Controls.Add(this.btnPregledProjekta);
            this.Controls.Add(this.btnPregledTima);
            this.Controls.Add(this.btnFormiraj);
            this.Controls.Add(this.lbemail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbprezime);
            this.Controls.Add(this.lbime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "VodjaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.VodjaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbemail;
        private Label label3;
        private Label lbprezime;
        private Label lbime;
        private Label label2;
        private Label label1;
        private Button btnFormiraj;
        private Button btnPregledTima;
        private Button btnPregledProjekta;
    }
}