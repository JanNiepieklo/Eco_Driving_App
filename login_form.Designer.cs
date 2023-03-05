namespace Eco_Driving_App
{
    partial class login_form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtlogin = new System.Windows.Forms.TextBox();
            this.txthaslo = new System.Windows.Forms.TextBox();
            this.panel_background = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnzaloguj = new System.Windows.Forms.Button();
            this.btnzarejestruj = new System.Windows.Forms.Button();
            this.panel_background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(271, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nazwa użytkownika:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(271, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hasło:";
            // 
            // txtlogin
            // 
            this.txtlogin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtlogin.Location = new System.Drawing.Point(275, 190);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(215, 29);
            this.txtlogin.TabIndex = 4;
            // 
            // txthaslo
            // 
            this.txthaslo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txthaslo.Location = new System.Drawing.Point(275, 272);
            this.txthaslo.Name = "txthaslo";
            this.txthaslo.Size = new System.Drawing.Size(215, 29);
            this.txthaslo.TabIndex = 5;
            // 
            // panel_background
            // 
            this.panel_background.AutoScroll = true;
            this.panel_background.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_background.Controls.Add(this.pictureBox1);
            this.panel_background.Controls.Add(this.label3);
            this.panel_background.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_background.Location = new System.Drawing.Point(0, 0);
            this.panel_background.Name = "panel_background";
            this.panel_background.Size = new System.Drawing.Size(800, 100);
            this.panel_background.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Eco_Driving_App.Properties.Resources.fuel_pump_icon;
            this.pictureBox1.Location = new System.Drawing.Point(315, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(289, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Eco Driving App";
            // 
            // btnzaloguj
            // 
            this.btnzaloguj.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnzaloguj.FlatAppearance.BorderSize = 0;
            this.btnzaloguj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnzaloguj.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnzaloguj.ForeColor = System.Drawing.Color.White;
            this.btnzaloguj.Location = new System.Drawing.Point(247, 333);
            this.btnzaloguj.Name = "btnzaloguj";
            this.btnzaloguj.Size = new System.Drawing.Size(118, 41);
            this.btnzaloguj.TabIndex = 14;
            this.btnzaloguj.Text = "Zaloguj";
            this.btnzaloguj.UseVisualStyleBackColor = false;
            this.btnzaloguj.Click += new System.EventHandler(this.btnzaloguj_Click);
            // 
            // btnzarejestruj
            // 
            this.btnzarejestruj.BackColor = System.Drawing.Color.Crimson;
            this.btnzarejestruj.FlatAppearance.BorderSize = 0;
            this.btnzarejestruj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnzarejestruj.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnzarejestruj.ForeColor = System.Drawing.Color.White;
            this.btnzarejestruj.Location = new System.Drawing.Point(400, 333);
            this.btnzarejestruj.Name = "btnzarejestruj";
            this.btnzarejestruj.Size = new System.Drawing.Size(118, 41);
            this.btnzarejestruj.TabIndex = 15;
            this.btnzarejestruj.Text = "Zarejestruj";
            this.btnzarejestruj.UseVisualStyleBackColor = false;
            this.btnzarejestruj.Click += new System.EventHandler(this.btnzarejestruj_Click);
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnzarejestruj);
            this.Controls.Add(this.btnzaloguj);
            this.Controls.Add(this.panel_background);
            this.Controls.Add(this.txthaslo);
            this.Controls.Add(this.txtlogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "login_form";
            this.Text = "Logowanie";
            this.Load += new System.EventHandler(this.login_form_Load);
            this.panel_background.ResumeLayout(false);
            this.panel_background.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtlogin;
        private System.Windows.Forms.TextBox txthaslo;
        private System.Windows.Forms.Panel panel_background;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnzaloguj;
        private System.Windows.Forms.Button btnzarejestruj;
    }
}