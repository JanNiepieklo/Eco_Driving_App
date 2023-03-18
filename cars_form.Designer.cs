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
            ((System.ComponentModel.ISupportInitialize)(this.dgvsamochody)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvsamochody
            // 
            this.dgvsamochody.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsamochody.Location = new System.Drawing.Point(12, 12);
            this.dgvsamochody.Name = "dgvsamochody";
            this.dgvsamochody.Size = new System.Drawing.Size(875, 289);
            this.dgvsamochody.TabIndex = 1;
            // 
            // btnanuluj
            // 
            this.btnanuluj.BackColor = System.Drawing.Color.DarkOrange;
            this.btnanuluj.FlatAppearance.BorderSize = 0;
            this.btnanuluj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnanuluj.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnanuluj.ForeColor = System.Drawing.Color.White;
            this.btnanuluj.Location = new System.Drawing.Point(768, 590);
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
            this.btnwyczysc.Location = new System.Drawing.Point(633, 590);
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
            this.btndodaj.Location = new System.Drawing.Point(498, 590);
            this.btndodaj.Name = "btndodaj";
            this.btndodaj.Size = new System.Drawing.Size(118, 41);
            this.btndodaj.TabIndex = 19;
            this.btndodaj.Text = "Dodaj";
            this.btndodaj.UseVisualStyleBackColor = false;
            // 
            // cars_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 643);
            this.Controls.Add(this.btnanuluj);
            this.Controls.Add(this.btnwyczysc);
            this.Controls.Add(this.btndodaj);
            this.Controls.Add(this.dgvsamochody);
            this.Name = "cars_form";
            this.Text = "Lista samochodów";
            this.Load += new System.EventHandler(this.cars_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsamochody)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvsamochody;
        private System.Windows.Forms.Button btnanuluj;
        private System.Windows.Forms.Button btnwyczysc;
        private System.Windows.Forms.Button btndodaj;
    }
}