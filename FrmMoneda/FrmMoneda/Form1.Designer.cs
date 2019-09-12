namespace FrmMoneda
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnCandado = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtNombre.ForeColor = System.Drawing.Color.Maroon;
            this.txtNombre.Location = new System.Drawing.Point(230, 118);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1f513.png");
            this.imageList1.Images.SetKeyName(1, "cerrado.png");
            // 
            // btnCandado
            // 
            this.btnCandado.BackColor = System.Drawing.Color.Transparent;
            this.btnCandado.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCandado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCandado.ForeColor = System.Drawing.Color.Transparent;
            this.btnCandado.ImageIndex = 1;
            this.btnCandado.ImageList = this.imageList1;
            this.btnCandado.Location = new System.Drawing.Point(248, 29);
            this.btnCandado.Name = "btnCandado";
            this.btnCandado.Size = new System.Drawing.Size(72, 70);
            this.btnCandado.TabIndex = 1;
            this.btnCandado.UseVisualStyleBackColor = false;
            this.btnCandado.Click += new System.EventHandler(this.btnLockCotizacion);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(342, 220);
            this.Controls.Add(this.btnCandado);
            this.Controls.Add(this.txtNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnCandado;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

