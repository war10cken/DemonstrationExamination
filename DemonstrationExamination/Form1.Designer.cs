﻿namespace DemonstrationExamination
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
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1  = new System.Windows.Forms.Button();
            this.button2  = new System.Windows.Forms.Button();
            this.label1   = new System.Windows.Forms.Label();
            this.label2   = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location                = new System.Drawing.Point(162, 154);
            this.button1.Name                    = "button1";
            this.button1.Size                    = new System.Drawing.Size(114, 34);
            this.button1.TabIndex                = 0;
            this.button1.Text                    = "Войти";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location                = new System.Drawing.Point(162, 194);
            this.button2.Name                    = "button2";
            this.button2.Size                    = new System.Drawing.Size(114, 34);
            this.button2.TabIndex                = 1;
            this.button2.Text                    = "Регистрация";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(128, 70);
            this.label1.Name     = "label1";
            this.label1.Size     = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 2;
            this.label1.Text     = "Логин:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(119, 100);
            this.label2.Name     = "label2";
            this.label2.Size     = new System.Drawing.Size(88, 28);
            this.label2.TabIndex = 3;
            this.label2.Text     = "Пароль:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(174, 67);
            this.textBox1.Name     = "textBox1";
            this.textBox1.Size     = new System.Drawing.Size(102, 23);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(174, 97);
            this.textBox2.Name     = "textBox2";
            this.textBox2.Size     = new System.Drawing.Size(102, 23);
            this.textBox2.TabIndex = 5;
            // 
            // EnterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(457, 261);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon            = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name            = "EnterForm";
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text            = "Вход";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

    #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }

}