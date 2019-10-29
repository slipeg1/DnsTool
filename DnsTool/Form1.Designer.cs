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
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.OutputWindow = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ClearButton = new System.Windows.Forms.Button();
            this.WhoisBox = new System.Windows.Forms.CheckBox();
            this.IPVSixBox = new System.Windows.Forms.CheckBox();
            this.IPVFourBox = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PingUpDown = new System.Windows.Forms.NumericUpDown();
            this.PingButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UrlTextBox = new System.Windows.Forms.TextBox();
            this.LookUpButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PingUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(37, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(299, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "DNS Tool. Made by Slipeg";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::DnsTool.Properties.Resources.MiniMizeLayer1;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(523, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 30);
            this.button2.TabIndex = 16;
            this.button2.Text = "___";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.BackgroundImage = global::DnsTool.Properties.Resources.XButton;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(574, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 30);
            this.button1.TabIndex = 15;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.BackgroundImage = global::DnsTool.Properties.Resources.Layer_1;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.UrlTextBox);
            this.panel1.Controls.Add(this.LookUpButton);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 439);
            this.panel1.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.OutputWindow);
            this.panel4.Location = new System.Drawing.Point(156, 54);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(425, 366);
            this.panel4.TabIndex = 14;
            // 
            // OutputWindow
            // 
            this.OutputWindow.BackColor = System.Drawing.SystemColors.InfoText;
            this.OutputWindow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OutputWindow.ForeColor = System.Drawing.SystemColors.Info;
            this.OutputWindow.Location = new System.Drawing.Point(15, 12);
            this.OutputWindow.Name = "OutputWindow";
            this.OutputWindow.ReadOnly = true;
            this.OutputWindow.Size = new System.Drawing.Size(389, 336);
            this.OutputWindow.TabIndex = 1;
            this.OutputWindow.Text = "";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Brown;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.ClearButton);
            this.panel3.Controls.Add(this.WhoisBox);
            this.panel3.Controls.Add(this.IPVSixBox);
            this.panel3.Controls.Add(this.IPVFourBox);
            this.panel3.Location = new System.Drawing.Point(15, 56);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(128, 162);
            this.panel3.TabIndex = 13;
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.Red;
            this.ClearButton.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.ClearButton.FlatAppearance.BorderSize = 2;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(6, 3);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(78, 28);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // WhoisBox
            // 
            this.WhoisBox.AutoSize = true;
            this.WhoisBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhoisBox.Location = new System.Drawing.Point(6, 37);
            this.WhoisBox.Name = "WhoisBox";
            this.WhoisBox.Size = new System.Drawing.Size(68, 17);
            this.WhoisBox.TabIndex = 6;
            this.WhoisBox.Text = "WHOIS";
            this.WhoisBox.UseVisualStyleBackColor = true;
            // 
            // IPVSixBox
            // 
            this.IPVSixBox.AutoSize = true;
            this.IPVSixBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPVSixBox.Location = new System.Drawing.Point(6, 60);
            this.IPVSixBox.Name = "IPVSixBox";
            this.IPVSixBox.Size = new System.Drawing.Size(53, 17);
            this.IPVSixBox.TabIndex = 8;
            this.IPVSixBox.Text = "IPV6";
            this.IPVSixBox.UseVisualStyleBackColor = true;
            // 
            // IPVFourBox
            // 
            this.IPVFourBox.AutoSize = true;
            this.IPVFourBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPVFourBox.Location = new System.Drawing.Point(6, 83);
            this.IPVFourBox.Name = "IPVFourBox";
            this.IPVFourBox.Size = new System.Drawing.Size(53, 17);
            this.IPVFourBox.TabIndex = 7;
            this.IPVFourBox.Text = "IPV4";
            this.IPVFourBox.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Brown;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.PingUpDown);
            this.panel2.Controls.Add(this.PingButton);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(15, 224);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Brown;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(14, 20);
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
            this.UrlTextBox.Location = new System.Drawing.Point(156, 17);
            this.UrlTextBox.Name = "UrlTextBox";
            this.UrlTextBox.Size = new System.Drawing.Size(247, 26);
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
            this.LookUpButton.Size = new System.Drawing.Size(172, 28);
            this.LookUpButton.TabIndex = 2;
            this.LookUpButton.Text = "DNS Lookup";
            this.LookUpButton.UseVisualStyleBackColor = false;
            this.LookUpButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LookUpButton_MouseClick);
            // 
            // DnsToolWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(625, 500);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DnsToolWindow";
            this.Text = "DnsTool";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PingUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LookUpButton;
        private System.Windows.Forms.TextBox UrlTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown PingUpDown;
        private System.Windows.Forms.Button PingButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.CheckBox WhoisBox;
        private System.Windows.Forms.CheckBox IPVSixBox;
        private System.Windows.Forms.CheckBox IPVFourBox;
        private System.Windows.Forms.RichTextBox OutputWindow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
    }
}

