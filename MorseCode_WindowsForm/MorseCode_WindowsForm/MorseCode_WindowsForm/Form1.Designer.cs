﻿namespace WindowsFormsApp1
{
    partial class Form1
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
            this.txtPlainText = new System.Windows.Forms.TextBox();
            this.Enkodo = new System.Windows.Forms.Button();
            this.txtEncodedText1 = new System.Windows.Forms.TextBox();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shkruaj tekstin";
            // 
            // txtPlainText
            // 
            this.txtPlainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlainText.Location = new System.Drawing.Point(12, 34);
            this.txtPlainText.Multiline = true;
            this.txtPlainText.Name = "txtPlainText";
            this.txtPlainText.Size = new System.Drawing.Size(857, 58);
            this.txtPlainText.TabIndex = 1;
            // 
            // Enkodo
            // 
            this.Enkodo.Location = new System.Drawing.Point(757, 98);
            this.Enkodo.Name = "Enkodo";
            this.Enkodo.Size = new System.Drawing.Size(112, 33);
            this.Enkodo.TabIndex = 3;
            this.Enkodo.Text = "Enkodo";
            this.Enkodo.UseVisualStyleBackColor = true;
            this.Enkodo.Click += new System.EventHandler(this.Enkodo_Click);
            // 
            // txtEncodedText1
            // 
            this.txtEncodedText1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEncodedText1.Location = new System.Drawing.Point(12, 145);
            this.txtEncodedText1.Multiline = true;
            this.txtEncodedText1.Name = "txtEncodedText1";
            this.txtEncodedText1.Size = new System.Drawing.Size(857, 58);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 487);
            this.Controls.Add(this.txtEncodedText1);
            this.Controls.Add(this.Enkodo);
            this.Controls.Add(this.txtPlainText);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlainText;
        private System.Windows.Forms.Button Enkodo;
        private System.Windows.Forms.TextBox txtEncodedText1;
    }
}

