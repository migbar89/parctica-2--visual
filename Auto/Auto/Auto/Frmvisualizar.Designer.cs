namespace Auto
{
    partial class Frmvisualizar
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
            this.gridautos = new System.Windows.Forms.DataGridView();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bteliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridautos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(320, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Autos Registrados";
            // 
            // gridautos
            // 
            this.gridautos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridautos.Location = new System.Drawing.Point(12, 113);
            this.gridautos.Name = "gridautos";
            this.gridautos.Size = new System.Drawing.Size(871, 325);
            this.gridautos.TabIndex = 1;
            // 
            // cbMarca
            // 
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Items.AddRange(new object[] {
            "Todos",
            "Kia",
            "Nissan",
            "Toyota",
            "Hyundai",
            "Honda"});
            this.cbMarca.Location = new System.Drawing.Point(42, 86);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(161, 21);
            this.cbMarca.TabIndex = 2;
            this.cbMarca.SelectedIndexChanged += new System.EventHandler(this.cbMarca_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Buscar por Marca";
            // 
            // bteliminar
            // 
            this.bteliminar.Location = new System.Drawing.Point(941, 113);
            this.bteliminar.Name = "bteliminar";
            this.bteliminar.Size = new System.Drawing.Size(75, 23);
            this.bteliminar.TabIndex = 4;
            this.bteliminar.Text = "Eliminar Auto";
            this.bteliminar.UseVisualStyleBackColor = true;
            this.bteliminar.Click += new System.EventHandler(this.bteliminar_Click);
            // 
            // Frmvisualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 450);
            this.Controls.Add(this.bteliminar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbMarca);
            this.Controls.Add(this.gridautos);
            this.Controls.Add(this.label1);
            this.Name = "Frmvisualizar";
            this.Text = "Visualizar Autos";
            this.Load += new System.EventHandler(this.Frmvisualizar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridautos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridautos;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bteliminar;
    }
}