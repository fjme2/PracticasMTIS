namespace Interpolaridad
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtcli = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.butgen = new System.Windows.Forms.Button();
            this.txtcant = new System.Windows.Forms.TextBox();
            this.txtref = new System.Windows.Forms.TextBox();
            this.txtgenkey = new System.Windows.Forms.TextBox();
            this.Solicitar = new System.Windows.Forms.TabPage();
            this.lblfecha = new System.Windows.Forms.Label();
            this.lblprecio = new System.Windows.Forms.Label();
            this.butsoli = new System.Windows.Forms.Button();
            this.txtprov = new System.Windows.Forms.TextBox();
            this.txtrefsoli = new System.Windows.Forms.TextBox();
            this.txtkeysoli = new System.Windows.Forms.TextBox();
            this.txtiban = new System.Windows.Forms.TextBox();
            this.txtkeyiban = new System.Windows.Forms.TextBox();
            this.butiban = new System.Windows.Forms.Button();
            this.lbliban = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.DNI.SuspendLayout();
            this.IBAN.SuspendLayout();
            this.CodPos.SuspendLayout();
            this.Generar.SuspendLayout();
            this.Solicitar.SuspendLayout();
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
            this.IBAN.Controls.Add(this.lbliban);
            this.IBAN.Controls.Add(this.butiban);
            this.IBAN.Controls.Add(this.txtiban);
            this.IBAN.Controls.Add(this.txtkeyiban);
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
            this.Generar.Controls.Add(this.dateTimePicker1);
            this.Generar.Controls.Add(this.txtcli);
            this.Generar.Controls.Add(this.lblid);
            this.Generar.Controls.Add(this.butgen);
            this.Generar.Controls.Add(this.txtcant);
            this.Generar.Controls.Add(this.txtref);
            this.Generar.Controls.Add(this.txtgenkey);
            this.Generar.Location = new System.Drawing.Point(4, 22);
            this.Generar.Name = "Generar";
            this.Generar.Size = new System.Drawing.Size(449, 269);
            this.Generar.TabIndex = 3;
            this.Generar.Text = "Generar";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(72, 98);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(140, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // txtcli
            // 
            this.txtcli.Location = new System.Drawing.Point(287, 97);
            this.txtcli.Name = "txtcli";
            this.txtcli.Size = new System.Drawing.Size(80, 20);
            this.txtcli.TabIndex = 10;
            this.txtcli.Text = "Cliente";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(204, 146);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(18, 13);
            this.lblid.TabIndex = 9;
            this.lblid.Text = "ID";
            // 
            // butgen
            // 
            this.butgen.Location = new System.Drawing.Point(72, 139);
            this.butgen.Name = "butgen";
            this.butgen.Size = new System.Drawing.Size(81, 20);
            this.butgen.TabIndex = 8;
            this.butgen.Text = "Enviar";
            this.butgen.UseVisualStyleBackColor = true;
            this.butgen.Click += new System.EventHandler(this.butgen_Click);
            // 
            // txtcant
            // 
            this.txtcant.Location = new System.Drawing.Point(228, 98);
            this.txtcant.Name = "txtcant";
            this.txtcant.Size = new System.Drawing.Size(52, 20);
            this.txtcant.TabIndex = 7;
            this.txtcant.Text = "Cantidad";
            // 
            // txtref
            // 
            this.txtref.Location = new System.Drawing.Point(72, 74);
            this.txtref.Name = "txtref";
            this.txtref.Size = new System.Drawing.Size(295, 20);
            this.txtref.TabIndex = 6;
            this.txtref.Text = "Referencia";
            this.txtref.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtgenkey
            // 
            this.txtgenkey.Location = new System.Drawing.Point(72, 48);
            this.txtgenkey.Name = "txtgenkey";
            this.txtgenkey.Size = new System.Drawing.Size(295, 20);
            this.txtgenkey.TabIndex = 2;
            this.txtgenkey.Text = "Key";
            this.txtgenkey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Solicitar
            // 
            this.Solicitar.BackColor = System.Drawing.Color.SteelBlue;
            this.Solicitar.Controls.Add(this.lblfecha);
            this.Solicitar.Controls.Add(this.lblprecio);
            this.Solicitar.Controls.Add(this.butsoli);
            this.Solicitar.Controls.Add(this.txtprov);
            this.Solicitar.Controls.Add(this.txtrefsoli);
            this.Solicitar.Controls.Add(this.txtkeysoli);
            this.Solicitar.Location = new System.Drawing.Point(4, 22);
            this.Solicitar.Name = "Solicitar";
            this.Solicitar.Size = new System.Drawing.Size(449, 269);
            this.Solicitar.TabIndex = 4;
            this.Solicitar.Text = "Solicitar";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Location = new System.Drawing.Point(272, 133);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(37, 13);
            this.lblfecha.TabIndex = 13;
            this.lblfecha.Text = "Fecha";
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Location = new System.Drawing.Point(146, 133);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(37, 13);
            this.lblprecio.TabIndex = 11;
            this.lblprecio.Text = "Precio";
            // 
            // butsoli
            // 
            this.butsoli.Location = new System.Drawing.Point(265, 102);
            this.butsoli.Name = "butsoli";
            this.butsoli.Size = new System.Drawing.Size(75, 20);
            this.butsoli.TabIndex = 10;
            this.butsoli.Text = "Buscar";
            this.butsoli.UseVisualStyleBackColor = true;
            this.butsoli.Click += new System.EventHandler(this.butsoli_Click);
            // 
            // txtprov
            // 
            this.txtprov.Location = new System.Drawing.Point(103, 102);
            this.txtprov.Name = "txtprov";
            this.txtprov.Size = new System.Drawing.Size(100, 20);
            this.txtprov.TabIndex = 9;
            this.txtprov.Text = "Proveedor";
            // 
            // txtrefsoli
            // 
            this.txtrefsoli.Location = new System.Drawing.Point(79, 76);
            this.txtrefsoli.Name = "txtrefsoli";
            this.txtrefsoli.Size = new System.Drawing.Size(295, 20);
            this.txtrefsoli.TabIndex = 8;
            this.txtrefsoli.Text = "Referencia";
            this.txtrefsoli.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtkeysoli
            // 
            this.txtkeysoli.Location = new System.Drawing.Point(79, 50);
            this.txtkeysoli.Name = "txtkeysoli";
            this.txtkeysoli.Size = new System.Drawing.Size(295, 20);
            this.txtkeysoli.TabIndex = 7;
            this.txtkeysoli.Text = "Key";
            this.txtkeysoli.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtiban
            // 
            this.txtiban.Location = new System.Drawing.Point(74, 83);
            this.txtiban.Name = "txtiban";
            this.txtiban.Size = new System.Drawing.Size(295, 20);
            this.txtiban.TabIndex = 3;
            this.txtiban.Text = "IBAN";
            this.txtiban.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtkeyiban
            // 
            this.txtkeyiban.Location = new System.Drawing.Point(74, 50);
            this.txtkeyiban.Name = "txtkeyiban";
            this.txtkeyiban.Size = new System.Drawing.Size(295, 20);
            this.txtkeyiban.TabIndex = 2;
            this.txtkeyiban.Text = "Key";
            this.txtkeyiban.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // butiban
            // 
            this.butiban.Location = new System.Drawing.Point(181, 118);
            this.butiban.Name = "butiban";
            this.butiban.Size = new System.Drawing.Size(75, 23);
            this.butiban.TabIndex = 4;
            this.butiban.Text = "Comprobar";
            this.butiban.UseVisualStyleBackColor = true;
            this.butiban.Click += new System.EventHandler(this.butiban_Click);
            // 
            // lbliban
            // 
            this.lbliban.AutoSize = true;
            this.lbliban.Location = new System.Drawing.Point(202, 162);
            this.lbliban.Name = "lbliban";
            this.lbliban.Size = new System.Drawing.Size(0, 13);
            this.lbliban.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 296);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "MTIS Practica 1";
            this.tabControl1.ResumeLayout(false);
            this.DNI.ResumeLayout(false);
            this.DNI.PerformLayout();
            this.IBAN.ResumeLayout(false);
            this.IBAN.PerformLayout();
            this.CodPos.ResumeLayout(false);
            this.CodPos.PerformLayout();
            this.Generar.ResumeLayout(false);
            this.Generar.PerformLayout();
            this.Solicitar.ResumeLayout(false);
            this.Solicitar.PerformLayout();
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
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Button butgen;
        private System.Windows.Forms.TextBox txtcant;
        private System.Windows.Forms.TextBox txtref;
        private System.Windows.Forms.TextBox txtgenkey;
        private System.Windows.Forms.TextBox txtcli;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.Button butsoli;
        private System.Windows.Forms.TextBox txtprov;
        private System.Windows.Forms.TextBox txtrefsoli;
        private System.Windows.Forms.TextBox txtkeysoli;
        private System.Windows.Forms.Label lbliban;
        private System.Windows.Forms.Button butiban;
        private System.Windows.Forms.TextBox txtiban;
        private System.Windows.Forms.TextBox txtkeyiban;
    }
}

