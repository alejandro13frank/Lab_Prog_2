namespace FrmSistemaSolar
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
            this.btnAgregarPlaneta = new System.Windows.Forms.Button();
            this.btnAgregarSatelite = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnMoverAstros = new System.Windows.Forms.Button();
            this.txtNombrePlaneta = new System.Windows.Forms.TextBox();
            this.txtNombreSatelite = new System.Windows.Forms.TextBox();
            this.txtOrbitaPlaneta = new System.Windows.Forms.TextBox();
            this.cmbPlaneta = new System.Windows.Forms.ComboBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.numRotacion = new System.Windows.Forms.NumericUpDown();
            this.numSatelite = new System.Windows.Forms.NumericUpDown();
            this.numRotacionSatelite = new System.Windows.Forms.NumericUpDown();
            this.numOrbitaSatelite = new System.Windows.Forms.NumericUpDown();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numRotacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSatelite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRotacionSatelite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOrbitaSatelite)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarPlaneta
            // 
            this.btnAgregarPlaneta.Location = new System.Drawing.Point(93, 266);
            this.btnAgregarPlaneta.Name = "btnAgregarPlaneta";
            this.btnAgregarPlaneta.Size = new System.Drawing.Size(160, 40);
            this.btnAgregarPlaneta.TabIndex = 0;
            this.btnAgregarPlaneta.Text = "AgregarPlaneta";
            this.btnAgregarPlaneta.UseVisualStyleBackColor = true;
            this.btnAgregarPlaneta.Click += new System.EventHandler(this.BtnAgregarPlaneta_Click);
            // 
            // btnAgregarSatelite
            // 
            this.btnAgregarSatelite.Location = new System.Drawing.Point(276, 266);
            this.btnAgregarSatelite.Name = "btnAgregarSatelite";
            this.btnAgregarSatelite.Size = new System.Drawing.Size(160, 40);
            this.btnAgregarSatelite.TabIndex = 1;
            this.btnAgregarSatelite.Text = "AgregarSatelite";
            this.btnAgregarSatelite.UseVisualStyleBackColor = true;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(93, 312);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(343, 40);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "Mostrar Info";
            this.btnMostrar.UseVisualStyleBackColor = true;
            // 
            // btnMoverAstros
            // 
            this.btnMoverAstros.Location = new System.Drawing.Point(93, 358);
            this.btnMoverAstros.Name = "btnMoverAstros";
            this.btnMoverAstros.Size = new System.Drawing.Size(343, 40);
            this.btnMoverAstros.TabIndex = 3;
            this.btnMoverAstros.Text = "MoverAstros";
            this.btnMoverAstros.UseVisualStyleBackColor = true;
            // 
            // txtNombrePlaneta
            // 
            this.txtNombrePlaneta.Location = new System.Drawing.Point(204, 74);
            this.txtNombrePlaneta.Name = "txtNombrePlaneta";
            this.txtNombrePlaneta.Size = new System.Drawing.Size(170, 20);
            this.txtNombrePlaneta.TabIndex = 4;
            // 
            // txtNombreSatelite
            // 
            this.txtNombreSatelite.Location = new System.Drawing.Point(547, 114);
            this.txtNombreSatelite.Name = "txtNombreSatelite";
            this.txtNombreSatelite.Size = new System.Drawing.Size(170, 20);
            this.txtNombreSatelite.TabIndex = 5;
            // 
            // txtOrbitaPlaneta
            // 
            this.txtOrbitaPlaneta.Location = new System.Drawing.Point(204, 114);
            this.txtOrbitaPlaneta.Name = "txtOrbitaPlaneta";
            this.txtOrbitaPlaneta.Size = new System.Drawing.Size(170, 20);
            this.txtOrbitaPlaneta.TabIndex = 6;
            // 
            // cmbPlaneta
            // 
            this.cmbPlaneta.FormattingEnabled = true;
            this.cmbPlaneta.Location = new System.Drawing.Point(547, 74);
            this.cmbPlaneta.Name = "cmbPlaneta";
            this.cmbPlaneta.Size = new System.Drawing.Size(170, 21);
            this.cmbPlaneta.TabIndex = 7;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(204, 198);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(170, 21);
            this.cmbTipo.TabIndex = 8;
            // 
            // numRotacion
            // 
            this.numRotacion.Location = new System.Drawing.Point(204, 140);
            this.numRotacion.Name = "numRotacion";
            this.numRotacion.Size = new System.Drawing.Size(170, 20);
            this.numRotacion.TabIndex = 9;
            // 
            // numSatelite
            // 
            this.numSatelite.Location = new System.Drawing.Point(204, 166);
            this.numSatelite.Name = "numSatelite";
            this.numSatelite.Size = new System.Drawing.Size(170, 20);
            this.numSatelite.TabIndex = 10;
            // 
            // numRotacionSatelite
            // 
            this.numRotacionSatelite.Location = new System.Drawing.Point(547, 166);
            this.numRotacionSatelite.Name = "numRotacionSatelite";
            this.numRotacionSatelite.Size = new System.Drawing.Size(170, 20);
            this.numRotacionSatelite.TabIndex = 11;
            // 
            // numOrbitaSatelite
            // 
            this.numOrbitaSatelite.Location = new System.Drawing.Point(547, 140);
            this.numOrbitaSatelite.Name = "numOrbitaSatelite";
            this.numOrbitaSatelite.Size = new System.Drawing.Size(170, 20);
            this.numOrbitaSatelite.TabIndex = 12;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(738, 45);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(196, 298);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.numOrbitaSatelite);
            this.Controls.Add(this.numRotacionSatelite);
            this.Controls.Add(this.numSatelite);
            this.Controls.Add(this.numRotacion);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.cmbPlaneta);
            this.Controls.Add(this.txtOrbitaPlaneta);
            this.Controls.Add(this.txtNombreSatelite);
            this.Controls.Add(this.txtNombrePlaneta);
            this.Controls.Add(this.btnMoverAstros);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnAgregarSatelite);
            this.Controls.Add(this.btnAgregarPlaneta);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numRotacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSatelite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRotacionSatelite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOrbitaSatelite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarPlaneta;
        private System.Windows.Forms.Button btnAgregarSatelite;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnMoverAstros;
        private System.Windows.Forms.TextBox txtNombrePlaneta;
        private System.Windows.Forms.TextBox txtNombreSatelite;
        private System.Windows.Forms.TextBox txtOrbitaPlaneta;
        private System.Windows.Forms.ComboBox cmbPlaneta;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.NumericUpDown numRotacion;
        private System.Windows.Forms.NumericUpDown numSatelite;
        private System.Windows.Forms.NumericUpDown numRotacionSatelite;
        private System.Windows.Forms.NumericUpDown numOrbitaSatelite;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

