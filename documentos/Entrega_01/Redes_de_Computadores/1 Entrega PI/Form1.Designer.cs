using System;
using System.Windows.Forms;
using System.Drawing;

namespace PI.REDES_Douglas_Erik_Gustavo_Vinicius_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Tit1 = new Label();
            IpDigit = new Label();
            Ipdigitado = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // Tit1
            // 
            Tit1.AutoSize = true;
            Tit1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline);
            Tit1.ForeColor = Color.White;
            Tit1.Location = new Point(257, 24);
            Tit1.Name = "Tit1";
            Tit1.Size = new Size(452, 41);
            Tit1.TabIndex = 0;
            Tit1.Text = "SISTEMA DE VALIDAÇÃO DE IP";
            // 
            // IpDigit
            // 
            IpDigit.AutoSize = true;
            IpDigit.Font = new Font("Arial", 18F, FontStyle.Bold);
            IpDigit.ForeColor = Color.Red;
            IpDigit.Location = new Point(30, 195);
            IpDigit.Name = "IpDigit";
            IpDigit.Size = new Size(289, 35);
            IpDigit.TabIndex = 1;
            IpDigit.Text = "Digite um IP válido:";
            // 
            // Ipdigitado
            // 
            Ipdigitado.Location = new Point(325, 203);
            Ipdigitado.Margin = new Padding(3, 4, 3, 4);
            Ipdigitado.Name = "Ipdigitado";
            Ipdigitado.Size = new Size(329, 27);
            Ipdigitado.TabIndex = 2;
            Ipdigitado.Tag = "";
            // 
            // button1
            // 
            button1.BackColor = Color.SlateGray;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic);
            button1.ForeColor = Color.LemonChiffon;
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(408, 261);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(123, 53);
            button1.TabIndex = 3;
            button1.Text = "Enviar IP";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(914, 600);
            Controls.Add(button1);
            Controls.Add(Ipdigitado);
            Controls.Add(IpDigit);
            Controls.Add(Tit1);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form1";
            Text = "VALIDAÇÃO IP";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Tit1;
        private Label IpDigit;
        private TextBox Ipdigitado;
        private Button button1;
    }
}
