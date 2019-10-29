namespace Ejercicio56
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
            this.rtxtboxTexto = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.stripMenuBtnAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.stripMenuBtnGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.stripMenuBtnGuardarComo = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtxtboxTexto
            // 
            this.rtxtboxTexto.Location = new System.Drawing.Point(12, 27);
            this.rtxtboxTexto.Name = "rtxtboxTexto";
            this.rtxtboxTexto.Size = new System.Drawing.Size(584, 258);
            this.rtxtboxTexto.TabIndex = 0;
            this.rtxtboxTexto.Text = "";
            this.rtxtboxTexto.TextChanged += new System.EventHandler(this.rtxtboxTexto_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(608, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripMenuBtnAbrir,
            this.stripMenuBtnGuardar,
            this.stripMenuBtnGuardarComo});
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(60, 20);
            this.toolStripMenu.Text = "Archivo";
            // 
            // stripMenuBtnAbrir
            // 
            this.stripMenuBtnAbrir.Name = "stripMenuBtnAbrir";
            this.stripMenuBtnAbrir.Size = new System.Drawing.Size(180, 22);
            this.stripMenuBtnAbrir.Text = "Abrir ";
            this.stripMenuBtnAbrir.Click += new System.EventHandler(this.stripMenuBtnAbrir_Click);
            // 
            // stripMenuBtnGuardar
            // 
            this.stripMenuBtnGuardar.Name = "stripMenuBtnGuardar";
            this.stripMenuBtnGuardar.Size = new System.Drawing.Size(180, 22);
            this.stripMenuBtnGuardar.Text = "Guardar";
            this.stripMenuBtnGuardar.Click += new System.EventHandler(this.stripMenuBtnGuardar_Click);
            // 
            // stripMenuBtnGuardarComo
            // 
            this.stripMenuBtnGuardarComo.Name = "stripMenuBtnGuardarComo";
            this.stripMenuBtnGuardarComo.Size = new System.Drawing.Size(180, 22);
            this.stripMenuBtnGuardarComo.Text = "Guardar como...";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 275);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(608, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 297);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.rtxtboxTexto);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Ejercicio55";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtboxTexto;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem stripMenuBtnAbrir;
        private System.Windows.Forms.ToolStripMenuItem stripMenuBtnGuardar;
        private System.Windows.Forms.ToolStripMenuItem stripMenuBtnGuardarComo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

