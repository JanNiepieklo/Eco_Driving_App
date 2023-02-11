namespace Eco_Driving_App
{
    partial class Main_Form
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
            this.panel_background = new System.Windows.Forms.Panel();
            this.button_logout = new System.Windows.Forms.Button();
            this.button_statistics = new System.Windows.Forms.Button();
            this.button_reports = new System.Windows.Forms.Button();
            this.button_cars = new System.Windows.Forms.Button();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_background.SuspendLayout();
            this.panel_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_background
            // 
            this.panel_background.AutoScroll = true;
            this.panel_background.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_background.Controls.Add(this.button_logout);
            this.panel_background.Controls.Add(this.button_statistics);
            this.panel_background.Controls.Add(this.button_reports);
            this.panel_background.Controls.Add(this.button_cars);
            this.panel_background.Controls.Add(this.panel_logo);
            this.panel_background.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_background.Location = new System.Drawing.Point(0, 0);
            this.panel_background.Name = "panel_background";
            this.panel_background.Size = new System.Drawing.Size(1064, 100);
            this.panel_background.TabIndex = 0;
            // 
            // button_logout
            // 
            this.button_logout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_logout.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_logout.FlatAppearance.BorderSize = 0;
            this.button_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_logout.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_logout.Location = new System.Drawing.Point(800, 0);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(200, 100);
            this.button_logout.TabIndex = 4;
            this.button_logout.Text = "Wyloguj";
            this.button_logout.UseVisualStyleBackColor = false;
            // 
            // button_statistics
            // 
            this.button_statistics.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_statistics.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_statistics.FlatAppearance.BorderSize = 0;
            this.button_statistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_statistics.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_statistics.Location = new System.Drawing.Point(600, 0);
            this.button_statistics.Name = "button_statistics";
            this.button_statistics.Size = new System.Drawing.Size(200, 100);
            this.button_statistics.TabIndex = 3;
            this.button_statistics.Text = "Statystyki";
            this.button_statistics.UseVisualStyleBackColor = false;
            // 
            // button_reports
            // 
            this.button_reports.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_reports.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_reports.FlatAppearance.BorderSize = 0;
            this.button_reports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_reports.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_reports.Location = new System.Drawing.Point(400, 0);
            this.button_reports.Name = "button_reports";
            this.button_reports.Size = new System.Drawing.Size(200, 100);
            this.button_reports.TabIndex = 2;
            this.button_reports.Text = "Dodaj raport spalania";
            this.button_reports.UseVisualStyleBackColor = false;
            this.button_reports.Click += new System.EventHandler(this.button_reports_Click);
            // 
            // button_cars
            // 
            this.button_cars.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_cars.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_cars.FlatAppearance.BorderSize = 0;
            this.button_cars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cars.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_cars.Location = new System.Drawing.Point(200, 0);
            this.button_cars.Margin = new System.Windows.Forms.Padding(0);
            this.button_cars.Name = "button_cars";
            this.button_cars.Size = new System.Drawing.Size(200, 100);
            this.button_cars.TabIndex = 1;
            this.button_cars.Text = "Samochody";
            this.button_cars.UseVisualStyleBackColor = false;
            this.button_cars.Click += new System.EventHandler(this.button_cars_Click);
            // 
            // panel_logo
            // 
            this.panel_logo.Controls.Add(this.pictureBox1);
            this.panel_logo.Controls.Add(this.label1);
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(200, 100);
            this.panel_logo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Eco_Driving_App.Properties.Resources.fuel_pump_icon;
            this.pictureBox1.Location = new System.Drawing.Point(33, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eco Driving App";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1064, 593);
            this.Controls.Add(this.panel_background);
            this.Name = "Main_Form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_background.ResumeLayout(false);
            this.panel_logo.ResumeLayout(false);
            this.panel_logo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_background;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Button button_statistics;
        private System.Windows.Forms.Button button_reports;
        private System.Windows.Forms.Button button_cars;
        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

