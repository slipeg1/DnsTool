namespace DnsTool
{
    partial class DnsToolWindow
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
            this.OutputWindow = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.UrlTextBox = new System.Windows.Forms.TextBox();
            this.LookUpButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.WhoisBox = new System.Windows.Forms.CheckBox();
            this.IPVFourBox = new System.Windows.Forms.CheckBox();
            this.IPVSixBox = new System.Windows.Forms.CheckBox();
            this.PingButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PingUpDown = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PingUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // OutputWindow
            // 
            this.OutputWindow.BackColor = System.Drawing.SystemColors.InfoText;
            this.OutputWindow.ForeColor = System.Drawing.SystemColors.Info;
            this.OutputWindow.Location = new System.Drawing.Point(154, 56);
            this.OutputWindow.Name = "OutputWindow";
            this.OutputWindow.ReadOnly = true;
            this.OutputWindow.Size = new System.Drawing.Size(381, 354);
            this.OutputWindow.TabIndex = 1;
            this.OutputWindow.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.IPVSixBox);
            this.panel1.Controls.Add(this.IPVFourBox);
            this.panel1.Controls.Add(this.WhoisBox);
            this.panel1.Controls.Add(this.ClearButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.UrlTextBox);
            this.panel1.Controls.Add(this.LookUpButton);
            this.panel1.Controls.Add(this.OutputWindow);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 422);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Brown;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "URL to resolve :";
            // 
            // UrlTextBox
            // 
            this.UrlTextBox.BackColor = System.Drawing.Color.Black;
            this.UrlTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.UrlTextBox.ForeColor = System.Drawing.SystemColors.Info;
            this.UrlTextBox.Location = new System.Drawing.Point(149, 17);
            this.UrlTextBox.Name = "UrlTextBox";
            this.UrlTextBox.Size = new System.Drawing.Size(254, 26);
            this.UrlTextBox.TabIndex = 3;
            // 
            // LookUpButton
            // 
            this.LookUpButton.BackColor = System.Drawing.Color.Red;
            this.LookUpButton.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.LookUpButton.FlatAppearance.BorderSize = 2;
            this.LookUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LookUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LookUpButton.Location = new System.Drawing.Point(409, 17);
            this.LookUpButton.Name = "LookUpButton";
            this.LookUpButton.Size = new System.Drawing.Size(126, 28);
            this.LookUpButton.TabIndex = 2;
            this.LookUpButton.Text = "DNS Lookup";
            this.LookUpButton.UseVisualStyleBackColor = false;
            this.LookUpButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LookUpButton_MouseClick);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.Red;
            this.ClearButton.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.ClearButton.FlatAppearance.BorderSize = 2;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(19, 56);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(124, 28);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // WhoisBox
            // 
            this.WhoisBox.AutoSize = true;
            this.WhoisBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhoisBox.Location = new System.Drawing.Point(19, 90);
            this.WhoisBox.Name = "WhoisBox";
            this.WhoisBox.Size = new System.Drawing.Size(68, 17);
            this.WhoisBox.TabIndex = 6;
            this.WhoisBox.Text = "WHOIS";
            this.WhoisBox.UseVisualStyleBackColor = true;
            // 
            // IPVFourBox
            // 
            this.IPVFourBox.AutoSize = true;
            this.IPVFourBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPVFourBox.Location = new System.Drawing.Point(90, 90);
            this.IPVFourBox.Name = "IPVFourBox";
            this.IPVFourBox.Size = new System.Drawing.Size(53, 17);
            this.IPVFourBox.TabIndex = 7;
            this.IPVFourBox.Text = "IPV4";
            this.IPVFourBox.UseVisualStyleBackColor = true;
            // 
            // IPVSixBox
            // 
            this.IPVSixBox.AutoSize = true;
            this.IPVSixBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPVSixBox.Location = new System.Drawing.Point(90, 113);
            this.IPVSixBox.Name = "IPVSixBox";
            this.IPVSixBox.Size = new System.Drawing.Size(53, 17);
            this.IPVSixBox.TabIndex = 8;
            this.IPVSixBox.Text = "IPV6";
            this.IPVSixBox.UseVisualStyleBackColor = true;
            // 
            // PingButton
            // 
            this.PingButton.BackColor = System.Drawing.Color.Red;
            this.PingButton.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.PingButton.FlatAppearance.BorderSize = 2;
            this.PingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PingButton.Location = new System.Drawing.Point(5, 4);
            this.PingButton.Name = "PingButton";
            this.PingButton.Size = new System.Drawing.Size(76, 28);
            this.PingButton.TabIndex = 9;
            this.PingButton.Text = "PING";
            this.PingButton.UseVisualStyleBackColor = false;
            this.PingButton.Click += new System.EventHandler(this.PingButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(54, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "/n";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Brown;
            this.panel2.Controls.Add(this.PingUpDown);
            this.panel2.Controls.Add(this.PingButton);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(7, 343);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(88, 67);
            this.panel2.TabIndex = 12;
            // 
            // PingUpDown
            // 
            this.PingUpDown.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.PingUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PingUpDown.ForeColor = System.Drawing.SystemColors.Info;
            this.PingUpDown.Location = new System.Drawing.Point(11, 40);
            this.PingUpDown.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.PingUpDown.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.PingUpDown.Name = "PingUpDown";
            this.PingUpDown.Size = new System.Drawing.Size(40, 16);
            this.PingUpDown.TabIndex = 12;
            this.PingUpDown.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // DnsToolWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(571, 446);
            this.Controls.Add(this.panel1);
            this.Name = "DnsToolWindow";
            this.Text = "DnsTool";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PingUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox OutputWindow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button LookUpButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UrlTextBox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.CheckBox IPVSixBox;
        private System.Windows.Forms.CheckBox IPVFourBox;
        private System.Windows.Forms.CheckBox WhoisBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button PingButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown PingUpDown;
    }
}

