namespace Auto
{
    partial class FrmAuto
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btVer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ctKilo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.ctPrecio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTrans = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rbSi = new System.Windows.Forms.RadioButton();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione la marca del auto:";
            // 
            // cbMarca
            // 
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Items.AddRange(new object[] {
            "Kia",
            "Nissan",
            "Toyota",
            "Hyundai",
            "Honda"});
            this.cbMarca.Location = new System.Drawing.Point(195, 12);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(161, 21);
            this.cbMarca.TabIndex = 1;
            this.cbMarca.SelectedIndexChanged += new System.EventHandler(this.cbMarca_SelectedIndexChanged);
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(112, 191);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(75, 23);
            this.btGuardar.TabIndex = 2;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // btVer
            // 
            this.btVer.Location = new System.Drawing.Point(193, 191);
            this.btVer.Name = "btVer";
            this.btVer.Size = new System.Drawing.Size(75, 23);
            this.btVer.TabIndex = 3;
            this.btVer.Text = "Visualizar";
            this.btVer.UseVisualStyleBackColor = true;
            this.btVer.Click += new System.EventHandler(this.btVer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingrese el Kilometraje:";
            // 
            // ctKilo
            // 
            this.ctKilo.Location = new System.Drawing.Point(195, 39);
            this.ctKilo.Name = "ctKilo";
            this.ctKilo.Size = new System.Drawing.Size(100, 20);
            this.ctKilo.TabIndex = 5;
            this.ctKilo.TextChanged += new System.EventHandler(this.cbMarca_SelectedIndexChanged);
            this.ctKilo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ctKilo_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Seleccione el estado:";
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Nuevo",
            "Usado"});
            this.cbEstado.Location = new System.Drawing.Point(195, 65);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(121, 21);
            this.cbEstado.TabIndex = 7;
            this.cbEstado.SelectedIndexChanged += new System.EventHandler(this.cbMarca_SelectedIndexChanged);
            // 
            // ctPrecio
            // 
            this.ctPrecio.Location = new System.Drawing.Point(195, 92);
            this.ctPrecio.Name = "ctPrecio";
            this.ctPrecio.Size = new System.Drawing.Size(100, 20);
            this.ctPrecio.TabIndex = 8;
            this.ctPrecio.TextChanged += new System.EventHandler(this.cbMarca_SelectedIndexChanged);
            this.ctPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ctKilo_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ingrese el Precio (US$):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Seleccione el tipo de transmisión:";
            // 
            // cbTrans
            // 
            this.cbTrans.FormattingEnabled = true;
            this.cbTrans.Items.AddRange(new object[] {
            "Manual",
            "Automático"});
            this.cbTrans.Location = new System.Drawing.Point(195, 118);
            this.cbTrans.Name = "cbTrans";
            this.cbTrans.Size = new System.Drawing.Size(121, 21);
            this.cbTrans.TabIndex = 11;
            this.cbTrans.SelectedIndexChanged += new System.EventHandler(this.cbMarca_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "¿Tiene rines de lujo?";
            // 
            // rbSi
            // 
            this.rbSi.AutoSize = true;
            this.rbSi.Location = new System.Drawing.Point(195, 146);
            this.rbSi.Name = "rbSi";
            this.rbSi.Size = new System.Drawing.Size(36, 17);
            this.rbSi.TabIndex = 13;
            this.rbSi.TabStop = true;
            this.rbSi.Text = "Sí";
            this.rbSi.UseVisualStyleBackColor = true;
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Location = new System.Drawing.Point(237, 146);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(39, 17);
            this.rbNo.TabIndex = 14;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = true;
            // 
            // FrmAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 237);
            this.Controls.Add(this.rbNo);
            this.Controls.Add(this.rbSi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbTrans);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ctPrecio);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ctKilo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btVer);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.cbMarca);
            this.Controls.Add(this.label1);
            this.Name = "FrmAuto";
            this.Text = "Gestión de Automóviles";
            this.Load += new System.EventHandler(this.FrmAuto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Button btVer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ctKilo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.TextBox ctPrecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTrans;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbSi;
        private System.Windows.Forms.RadioButton rbNo;
    }
}

