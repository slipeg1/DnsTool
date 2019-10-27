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
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OutputWindow
            // 
            this.OutputWindow.BackColor = System.Drawing.SystemColors.InfoText;
            this.OutputWindow.ForeColor = System.Drawing.SystemColors.Info;
            this.OutputWindow.Location = new System.Drawing.Point(149, 52);
            this.OutputWindow.Name = "OutputWindow";
            this.OutputWindow.ReadOnly = true;
            this.OutputWindow.Size = new System.Drawing.Size(318, 274);
            this.OutputWindow.TabIndex = 1;
            this.OutputWindow.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.UrlTextBox);
            this.panel1.Controls.Add(this.LookUpButton);
            this.panel1.Controls.Add(this.OutputWindow);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 341);
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
            this.UrlTextBox.Size = new System.Drawing.Size(318, 26);
            this.UrlTextBox.TabIndex = 3;
            // 
            // LookUpButton
            // 
            this.LookUpButton.BackColor = System.Drawing.Color.Red;
            this.LookUpButton.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.LookUpButton.FlatAppearance.BorderSize = 2;
            this.LookUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LookUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LookUpButton.Location = new System.Drawing.Point(15, 52);
            this.LookUpButton.Name = "LookUpButton";
            this.LookUpButton.Size = new System.Drawing.Size(128, 28);
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
            this.ClientSize = new System.Drawing.Size(507, 364);
            this.Controls.Add(this.panel1);
            this.Name = "DnsToolWindow";
            this.Text = "DnsTool";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox OutputWindow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button LookUpButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UrlTextBox;
    }
}

