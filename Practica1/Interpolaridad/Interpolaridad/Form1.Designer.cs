﻿namespace Interpolaridad
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.DNI = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.butdni = new System.Windows.Forms.Button();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.txtdnikey = new System.Windows.Forms.TextBox();
            this.IBAN = new System.Windows.Forms.TabPage();
            this.CodPos = new System.Windows.Forms.TabPage();
            this.lbprov = new System.Windows.Forms.Label();
            this.lbpob = new System.Windows.Forms.Label();
            this.butcodpos = new System.Windows.Forms.Button();
            this.txtcodpos = new System.Windows.Forms.TextBox();
            this.txtcodposkey = new System.Windows.Forms.TextBox();
            this.Generar = new System.Windows.Forms.TabPage();
            this.Solicitar = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.DNI.SuspendLayout();
            this.CodPos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.DNI);
            this.tabControl1.Controls.Add(this.IBAN);
            this.tabControl1.Controls.Add(this.CodPos);
            this.tabControl1.Controls.Add(this.Generar);
            this.tabControl1.Controls.Add(this.Solicitar);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(457, 295);
            this.tabControl1.TabIndex = 0;
            // 
            // DNI
            // 
            this.DNI.BackColor = System.Drawing.Color.SteelBlue;
            this.DNI.Controls.Add(this.label1);
            this.DNI.Controls.Add(this.butdni);
            this.DNI.Controls.Add(this.txtdni);
            this.DNI.Controls.Add(this.txtdnikey);
            this.DNI.Location = new System.Drawing.Point(4, 22);
            this.DNI.Name = "DNI";
            this.DNI.Padding = new System.Windows.Forms.Padding(3);
            this.DNI.Size = new System.Drawing.Size(449, 269);
            this.DNI.TabIndex = 0;
            this.DNI.Text = "DNI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Datos";
            // 
            // butdni
            // 
            this.butdni.Location = new System.Drawing.Point(187, 150);
            this.butdni.Name = "butdni";
            this.butdni.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.butdni.Size = new System.Drawing.Size(75, 23);
            this.butdni.TabIndex = 2;
            this.butdni.Text = "Aceptar";
            this.butdni.UseVisualStyleBackColor = true;
            this.butdni.Click += new System.EventHandler(this.butdni_Click);
            // 
            // txtdni
            // 
            this.txtdni.Location = new System.Drawing.Point(77, 110);
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(295, 20);
            this.txtdni.TabIndex = 1;
            this.txtdni.Text = "DNI";
            this.txtdni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtdnikey
            // 
            this.txtdnikey.Location = new System.Drawing.Point(77, 71);
            this.txtdnikey.Name = "txtdnikey";
            this.txtdnikey.Size = new System.Drawing.Size(295, 20);
            this.txtdnikey.TabIndex = 0;
            this.txtdnikey.Text = "Key";
            this.txtdnikey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IBAN
            // 
            this.IBAN.BackColor = System.Drawing.Color.SteelBlue;
            this.IBAN.Location = new System.Drawing.Point(4, 22);
            this.IBAN.Name = "IBAN";
            this.IBAN.Padding = new System.Windows.Forms.Padding(3);
            this.IBAN.Size = new System.Drawing.Size(449, 269);
            this.IBAN.TabIndex = 1;
            this.IBAN.Text = "IBAN";
            // 
            // CodPos
            // 
            this.CodPos.BackColor = System.Drawing.Color.SteelBlue;
            this.CodPos.Controls.Add(this.lbprov);
            this.CodPos.Controls.Add(this.lbpob);
            this.CodPos.Controls.Add(this.butcodpos);
            this.CodPos.Controls.Add(this.txtcodpos);
            this.CodPos.Controls.Add(this.txtcodposkey);
            this.CodPos.Location = new System.Drawing.Point(4, 22);
            this.CodPos.Name = "CodPos";
            this.CodPos.Size = new System.Drawing.Size(449, 269);
            this.CodPos.TabIndex = 2;
            this.CodPos.Text = "CodPos";
            // 
            // lbprov
            // 
            this.lbprov.AutoSize = true;
            this.lbprov.Location = new System.Drawing.Point(235, 156);
            this.lbprov.Name = "lbprov";
            this.lbprov.Size = new System.Drawing.Size(51, 13);
            this.lbprov.TabIndex = 5;
            this.lbprov.Text = "Provincia";
            // 
            // lbpob
            // 
            this.lbpob.AutoSize = true;
            this.lbpob.Location = new System.Drawing.Point(235, 121);
            this.lbpob.Name = "lbpob";
            this.lbpob.Size = new System.Drawing.Size(54, 13);
            this.lbpob.TabIndex = 4;
            this.lbpob.Text = "Población";
            // 
            // butcodpos
            // 
            this.butcodpos.Location = new System.Drawing.Point(78, 151);
            this.butcodpos.Name = "butcodpos";
            this.butcodpos.Size = new System.Drawing.Size(100, 23);
            this.butcodpos.TabIndex = 3;
            this.butcodpos.Text = "Buscar";
            this.butcodpos.UseVisualStyleBackColor = true;
            this.butcodpos.Click += new System.EventHandler(this.butcodpos_Click);
            // 
            // txtcodpos
            // 
            this.txtcodpos.Location = new System.Drawing.Point(78, 115);
            this.txtcodpos.Name = "txtcodpos";
            this.txtcodpos.Size = new System.Drawing.Size(100, 20);
            this.txtcodpos.TabIndex = 2;
            this.txtcodpos.Text = "Código Postal";
            // 
            // txtcodposkey
            // 
            this.txtcodposkey.Location = new System.Drawing.Point(78, 77);
            this.txtcodposkey.Name = "txtcodposkey";
            this.txtcodposkey.Size = new System.Drawing.Size(295, 20);
            this.txtcodposkey.TabIndex = 1;
            this.txtcodposkey.Text = "Key";
            this.txtcodposkey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Generar
            // 
            this.Generar.BackColor = System.Drawing.Color.SteelBlue;
            this.Generar.Location = new System.Drawing.Point(4, 22);
            this.Generar.Name = "Generar";
            this.Generar.Size = new System.Drawing.Size(449, 269);
            this.Generar.TabIndex = 3;
            this.Generar.Text = "Generar";
            // 
            // Solicitar
            // 
            this.Solicitar.BackColor = System.Drawing.Color.SteelBlue;
            this.Solicitar.Location = new System.Drawing.Point(4, 22);
            this.Solicitar.Name = "Solicitar";
            this.Solicitar.Size = new System.Drawing.Size(449, 269);
            this.Solicitar.TabIndex = 4;
            this.Solicitar.Text = "Solicitar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 296);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.DNI.ResumeLayout(false);
            this.DNI.PerformLayout();
            this.CodPos.ResumeLayout(false);
            this.CodPos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage DNI;
        private System.Windows.Forms.TabPage IBAN;
        private System.Windows.Forms.TabPage CodPos;
        private System.Windows.Forms.TabPage Generar;
        private System.Windows.Forms.TabPage Solicitar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butdni;
        private System.Windows.Forms.TextBox txtdni;
        private System.Windows.Forms.TextBox txtdnikey;
        private System.Windows.Forms.Label lbprov;
        private System.Windows.Forms.Label lbpob;
        private System.Windows.Forms.Button butcodpos;
        private System.Windows.Forms.TextBox txtcodpos;
        private System.Windows.Forms.TextBox txtcodposkey;
    }
}
