namespace Eco_Driving_App
{
    partial class cars_form
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
            this.dgvsamochody = new System.Windows.Forms.DataGridView();
            this.btnanuluj = new System.Windows.Forms.Button();
            this.btnwyczysc = new System.Windows.Forms.Button();
            this.btndodaj = new System.Windows.Forms.Button();
            this.cbpaliwo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtmodel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmarka = new System.Windows.Forms.TextBox();
            this.txtmoc = new System.Windows.Forms.TextBox();
            this.txtpojemnosc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtrok = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsamochody)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvsamochody
            // 
            this.dgvsamochody.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsamochody.Location = new System.Drawing.Point(12, 12);
            this.dgvsamochody.Name = "dgvsamochody";
            this.dgvsamochody.Size = new System.Drawing.Size(651, 210);
            this.dgvsamochody.TabIndex = 1;
            // 
            // btnanuluj
            // 
            this.btnanuluj.BackColor = System.Drawing.Color.DarkOrange;
            this.btnanuluj.FlatAppearance.BorderSize = 0;
            this.btnanuluj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnanuluj.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnanuluj.ForeColor = System.Drawing.Color.White;
            this.btnanuluj.Location = new System.Drawing.Point(426, 590);
            this.btnanuluj.Name = "btnanuluj";
            this.btnanuluj.Size = new System.Drawing.Size(118, 41);
            this.btnanuluj.TabIndex = 21;
            this.btnanuluj.Text = "Anuluj";
            this.btnanuluj.UseVisualStyleBackColor = false;
            this.btnanuluj.Click += new System.EventHandler(this.btnanuluj_Click);
            // 
            // btnwyczysc
            // 
            this.btnwyczysc.BackColor = System.Drawing.Color.Tomato;
            this.btnwyczysc.FlatAppearance.BorderSize = 0;
            this.btnwyczysc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnwyczysc.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnwyczysc.ForeColor = System.Drawing.Color.White;
            this.btnwyczysc.Location = new System.Drawing.Point(291, 590);
            this.btnwyczysc.Name = "btnwyczysc";
            this.btnwyczysc.Size = new System.Drawing.Size(118, 41);
            this.btnwyczysc.TabIndex = 20;
            this.btnwyczysc.Text = "Wyczyść";
            this.btnwyczysc.UseVisualStyleBackColor = false;
            this.btnwyczysc.Click += new System.EventHandler(this.btnwyczysc_Click);
            // 
            // btndodaj
            // 
            this.btndodaj.BackColor = System.Drawing.Color.LimeGreen;
            this.btndodaj.FlatAppearance.BorderSize = 0;
            this.btndodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndodaj.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btndodaj.ForeColor = System.Drawing.Color.White;
            this.btndodaj.Location = new System.Drawing.Point(156, 590);
            this.btndodaj.Name = "btndodaj";
            this.btndodaj.Size = new System.Drawing.Size(118, 41);
            this.btndodaj.TabIndex = 19;
            this.btndodaj.Text = "Dodaj";
            this.btndodaj.UseVisualStyleBackColor = false;
            this.btndodaj.Click += new System.EventHandler(this.btndodaj_Click);
            // 
            // cbpaliwo
            // 
            this.cbpaliwo.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbpaliwo.FormattingEnabled = true;
            this.cbpaliwo.Items.AddRange(new object[] {
            "Benzyna",
            "Diesel",
            "LPG"});
            this.cbpaliwo.Location = new System.Drawing.Point(309, 351);
            this.cbpaliwo.Name = "cbpaliwo";
            this.cbpaliwo.Size = new System.Drawing.Size(354, 31);
            this.cbpaliwo.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(27, 357);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 23);
            this.label7.TabIndex = 28;
            this.label7.Text = "Rodzaj paliwa:";
            // 
            // txtmodel
            // 
            this.txtmodel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtmodel.Location = new System.Drawing.Point(309, 302);
            this.txtmodel.Name = "txtmodel";
            this.txtmodel.Size = new System.Drawing.Size(354, 29);
            this.txtmodel.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(27, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 23);
            this.label5.TabIndex = 25;
            this.label5.Text = "Model:";
            // 
            // txtmarka
            // 
            this.txtmarka.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtmarka.Location = new System.Drawing.Point(309, 253);
            this.txtmarka.Name = "txtmarka";
            this.txtmarka.Size = new System.Drawing.Size(354, 29);
            this.txtmarka.TabIndex = 23;
            this.txtmarka.TextChanged += new System.EventHandler(this.txtzaplacone_TextChanged);
            // 
            // txtmoc
            // 
            this.txtmoc.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtmoc.Location = new System.Drawing.Point(309, 449);
            this.txtmoc.Name = "txtmoc";
            this.txtmoc.Size = new System.Drawing.Size(354, 29);
            this.txtmoc.TabIndex = 34;
            // 
            // txtpojemnosc
            // 
            this.txtpojemnosc.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtpojemnosc.Location = new System.Drawing.Point(309, 400);
            this.txtpojemnosc.Name = "txtpojemnosc";
            this.txtpojemnosc.Size = new System.Drawing.Size(354, 29);
            this.txtpojemnosc.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(27, 406);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(242, 23);
            this.label9.TabIndex = 30;
            this.label9.Text = "Pojemność silnika (w litrach):";
            // 
            // txtrok
            // 
            this.txtrok.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtrok.Location = new System.Drawing.Point(309, 498);
            this.txtrok.Name = "txtrok";
            this.txtrok.Size = new System.Drawing.Size(354, 29);
            this.txtrok.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(27, 504);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 23);
            this.label11.TabIndex = 36;
            this.label11.Text = "Rok produkcji:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(27, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 23);
            this.label2.TabIndex = 39;
            this.label2.Text = "Marka:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(27, 455);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 23);
            this.label3.TabIndex = 40;
            this.label3.Text = "Moc silnika (w KM):";
            // 
            // cars_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 643);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtrok);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtmoc);
            this.Controls.Add(this.txtpojemnosc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbpaliwo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtmodel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtmarka);
            this.Controls.Add(this.btnanuluj);
            this.Controls.Add(this.btnwyczysc);
            this.Controls.Add(this.btndodaj);
            this.Controls.Add(this.dgvsamochody);
            this.Name = "cars_form";
            this.Text = "Lista samochodów";
            this.Load += new System.EventHandler(this.cars_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsamochody)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvsamochody;
        private System.Windows.Forms.Button btnanuluj;
        private System.Windows.Forms.Button btnwyczysc;
        private System.Windows.Forms.Button btndodaj;
        private System.Windows.Forms.ComboBox cbpaliwo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtmodel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmarka;
        private System.Windows.Forms.TextBox txtmoc;
        private System.Windows.Forms.TextBox txtpojemnosc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtrok;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}