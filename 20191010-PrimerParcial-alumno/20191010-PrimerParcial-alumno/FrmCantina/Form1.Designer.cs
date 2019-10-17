namespace FrmCantina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numCapacidad = new System.Windows.Forms.NumericUpDown();
            this.numContenido = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rBtnCerveza = new System.Windows.Forms.RadioButton();
            this.rBtnAgua = new System.Windows.Forms.RadioButton();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.barra = new ControlCantina.Barra();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numContenido)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(116, 407);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(188, 20);
            this.txtMarca.TabIndex = 0;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(325, 407);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(192, 21);
            this.cmbTipo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Botella Tipo";
            // 
            // numCapacidad
            // 
            this.numCapacidad.Location = new System.Drawing.Point(116, 474);
            this.numCapacidad.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numCapacidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCapacidad.Name = "numCapacidad";
            this.numCapacidad.Size = new System.Drawing.Size(120, 20);
            this.numCapacidad.TabIndex = 4;
            this.numCapacidad.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // numContenido
            // 
            this.numContenido.Location = new System.Drawing.Point(325, 474);
            this.numContenido.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numContenido.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numContenido.Name = "numContenido";
            this.numContenido.Size = new System.Drawing.Size(120, 20);
            this.numContenido.TabIndex = 5;
            this.numContenido.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Contenido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 440);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Capacida";
            // 
            // rBtnCerveza
            // 
            this.rBtnCerveza.AutoSize = true;
            this.rBtnCerveza.Location = new System.Drawing.Point(12, 391);
            this.rBtnCerveza.Name = "rBtnCerveza";
            this.rBtnCerveza.Size = new System.Drawing.Size(64, 17);
            this.rBtnCerveza.TabIndex = 8;
            this.rBtnCerveza.TabStop = true;
            this.rBtnCerveza.Text = "Cerveza";
            this.rBtnCerveza.UseVisualStyleBackColor = true;
            // 
            // rBtnAgua
            // 
            this.rBtnAgua.AutoSize = true;
            this.rBtnAgua.Location = new System.Drawing.Point(11, 443);
            this.rBtnAgua.Name = "rBtnAgua";
            this.rBtnAgua.Size = new System.Drawing.Size(50, 17);
            this.rBtnAgua.TabIndex = 9;
            this.rBtnAgua.TabStop = true;
            this.rBtnAgua.Text = "Agua";
            this.rBtnAgua.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(488, 464);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // barra
            // 
            this.barra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("barra.BackgroundImage")));
            this.barra.Location = new System.Drawing.Point(12, 1);
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(551, 368);
            this.barra.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 498);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.barra);
            this.Controls.Add(this.rBtnAgua);
            this.Controls.Add(this.rBtnCerveza);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numContenido);
            this.Controls.Add(this.numCapacidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.txtMarca);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCapacidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numContenido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numCapacidad;
        private System.Windows.Forms.NumericUpDown numContenido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rBtnCerveza;
        private System.Windows.Forms.RadioButton rBtnAgua;
        private ControlCantina.Barra barra;
        private System.Windows.Forms.Button btnAgregar;
    }
}

