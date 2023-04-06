namespace Eco_Driving_App
{
    partial class add_report_form
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
            this.dgvraporty = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtzatankowane = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtzaplacone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtprzebieg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtdata = new System.Windows.Forms.DateTimePicker();
            this.btndodaj = new System.Windows.Forms.Button();
            this.btnwyczysc = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cbdopelna = new System.Windows.Forms.CheckBox();
            this.cbpaliwo = new System.Windows.Forms.ComboBox();
            this.btnanuluj = new System.Windows.Forms.Button();
            this.btn_czyszczenie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvraporty)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvraporty
            // 
            this.dgvraporty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvraporty.Location = new System.Drawing.Point(12, 12);
            this.dgvraporty.Name = "dgvraporty";
            this.dgvraporty.Size = new System.Drawing.Size(655, 289);
            this.dgvraporty.TabIndex = 0;
            this.dgvraporty.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvraporty_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(28, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ilość zatankowanego paliwa:";
            // 
            // txtzatankowane
            // 
            this.txtzatankowane.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtzatankowane.Location = new System.Drawing.Point(273, 325);
            this.txtzatankowane.Name = "txtzatankowane";
            this.txtzatankowane.Size = new System.Drawing.Size(215, 29);
            this.txtzatankowane.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(28, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Zapłacona kwota:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(494, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "litrów";
            // 
            // txtzaplacone
            // 
            this.txtzaplacone.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtzaplacone.Location = new System.Drawing.Point(273, 375);
            this.txtzaplacone.Name = "txtzaplacone";
            this.txtzaplacone.Size = new System.Drawing.Size(215, 29);
            this.txtzaplacone.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(494, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "złotych";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(28, 425);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Przebieg:";
            // 
            // txtprzebieg
            // 
            this.txtprzebieg.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtprzebieg.Location = new System.Drawing.Point(273, 425);
            this.txtprzebieg.Name = "txtprzebieg";
            this.txtprzebieg.Size = new System.Drawing.Size(215, 29);
            this.txtprzebieg.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(494, 425);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "kilometrów";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(28, 475);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "Rodzaj paliwa:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(28, 525);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 23);
            this.label8.TabIndex = 11;
            this.label8.Text = "Data tankowania:";
            // 
            // dtdata
            // 
            this.dtdata.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtdata.Location = new System.Drawing.Point(273, 525);
            this.dtdata.Name = "dtdata";
            this.dtdata.Size = new System.Drawing.Size(324, 30);
            this.dtdata.TabIndex = 12;
            // 
            // btndodaj
            // 
            this.btndodaj.BackColor = System.Drawing.Color.LimeGreen;
            this.btndodaj.FlatAppearance.BorderSize = 0;
            this.btndodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndodaj.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btndodaj.ForeColor = System.Drawing.Color.White;
            this.btndodaj.Location = new System.Drawing.Point(154, 612);
            this.btndodaj.Name = "btndodaj";
            this.btndodaj.Size = new System.Drawing.Size(118, 41);
            this.btndodaj.TabIndex = 13;
            this.btndodaj.Text = "Dodaj";
            this.btndodaj.UseVisualStyleBackColor = false;
            this.btndodaj.Click += new System.EventHandler(this.btndodaj_Click);
            // 
            // btnwyczysc
            // 
            this.btnwyczysc.BackColor = System.Drawing.Color.Tomato;
            this.btnwyczysc.FlatAppearance.BorderSize = 0;
            this.btnwyczysc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnwyczysc.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnwyczysc.ForeColor = System.Drawing.Color.White;
            this.btnwyczysc.Location = new System.Drawing.Point(289, 612);
            this.btnwyczysc.Name = "btnwyczysc";
            this.btnwyczysc.Size = new System.Drawing.Size(118, 41);
            this.btnwyczysc.TabIndex = 14;
            this.btnwyczysc.Text = "Wyczyść";
            this.btnwyczysc.UseVisualStyleBackColor = false;
            this.btnwyczysc.Click += new System.EventHandler(this.btnwyczysc_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(28, 575);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(185, 23);
            this.label9.TabIndex = 15;
            this.label9.Text = "Tankowanie do pełna:";
            // 
            // cbdopelna
            // 
            this.cbdopelna.AutoSize = true;
            this.cbdopelna.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbdopelna.Location = new System.Drawing.Point(273, 576);
            this.cbdopelna.Name = "cbdopelna";
            this.cbdopelna.Size = new System.Drawing.Size(54, 27);
            this.cbdopelna.TabIndex = 16;
            this.cbdopelna.Text = "Tak";
            this.cbdopelna.UseVisualStyleBackColor = true;
            // 
            // cbpaliwo
            // 
            this.cbpaliwo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbpaliwo.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbpaliwo.FormattingEnabled = true;
            this.cbpaliwo.Items.AddRange(new object[] {
            "Benzyna",
            "Diesel",
            "LPG"});
            this.cbpaliwo.Location = new System.Drawing.Point(273, 475);
            this.cbpaliwo.Name = "cbpaliwo";
            this.cbpaliwo.Size = new System.Drawing.Size(215, 31);
            this.cbpaliwo.TabIndex = 17;
            // 
            // btnanuluj
            // 
            this.btnanuluj.BackColor = System.Drawing.Color.DarkOrange;
            this.btnanuluj.FlatAppearance.BorderSize = 0;
            this.btnanuluj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnanuluj.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnanuluj.ForeColor = System.Drawing.Color.White;
            this.btnanuluj.Location = new System.Drawing.Point(424, 612);
            this.btnanuluj.Name = "btnanuluj";
            this.btnanuluj.Size = new System.Drawing.Size(118, 41);
            this.btnanuluj.TabIndex = 18;
            this.btnanuluj.Text = "Anuluj";
            this.btnanuluj.UseVisualStyleBackColor = false;
            this.btnanuluj.Click += new System.EventHandler(this.btnanuluj_Click);
            // 
            // btn_czyszczenie
            // 
            this.btn_czyszczenie.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_czyszczenie.FlatAppearance.BorderSize = 0;
            this.btn_czyszczenie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_czyszczenie.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_czyszczenie.ForeColor = System.Drawing.Color.White;
            this.btn_czyszczenie.Location = new System.Drawing.Point(567, 313);
            this.btn_czyszczenie.Name = "btn_czyszczenie";
            this.btn_czyszczenie.Size = new System.Drawing.Size(49, 109);
            this.btn_czyszczenie.TabIndex = 19;
            this.btn_czyszczenie.Text = "Czyszczenie tabel";
            this.btn_czyszczenie.UseVisualStyleBackColor = false;
            this.btn_czyszczenie.Visible = false;
            this.btn_czyszczenie.Click += new System.EventHandler(this.btn_czyszczenie_Click);
            // 
            // add_report_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 665);
            this.Controls.Add(this.btn_czyszczenie);
            this.Controls.Add(this.btnanuluj);
            this.Controls.Add(this.cbpaliwo);
            this.Controls.Add(this.cbdopelna);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnwyczysc);
            this.Controls.Add(this.btndodaj);
            this.Controls.Add(this.dtdata);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtprzebieg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtzaplacone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtzatankowane);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvraporty);
            this.Name = "add_report_form";
            this.Text = "Dodaj raport spalania";
            this.Load += new System.EventHandler(this.add_report_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvraporty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvraporty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtzatankowane;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtzaplacone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtprzebieg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtdata;
        private System.Windows.Forms.Button btndodaj;
        private System.Windows.Forms.Button btnwyczysc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cbdopelna;
        private System.Windows.Forms.ComboBox cbpaliwo;
        private System.Windows.Forms.Button btnanuluj;
        private System.Windows.Forms.Button btn_czyszczenie;
    }
}