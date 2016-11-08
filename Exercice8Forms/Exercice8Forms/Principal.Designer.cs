namespace Exercice8Forms
{
    partial class Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leerPlanDeVueloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.introducirTiempoDeCicloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::Exercice8Forms.Properties.Resources.plane;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(347, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leerPlanDeVueloToolStripMenuItem,
            this.introducirTiempoDeCicloToolStripMenuItem,
            this.simularToolStripMenuItem});
            this.opcionesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // leerPlanDeVueloToolStripMenuItem
            // 
            this.leerPlanDeVueloToolStripMenuItem.Name = "leerPlanDeVueloToolStripMenuItem";
            this.leerPlanDeVueloToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.leerPlanDeVueloToolStripMenuItem.Text = "Leer plan de vuelo";
            this.leerPlanDeVueloToolStripMenuItem.Click += new System.EventHandler(this.leerPlanDeVueloToolStripMenuItem_Click);
            // 
            // introducirTiempoDeCicloToolStripMenuItem
            // 
            this.introducirTiempoDeCicloToolStripMenuItem.Name = "introducirTiempoDeCicloToolStripMenuItem";
            this.introducirTiempoDeCicloToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.introducirTiempoDeCicloToolStripMenuItem.Text = "Introducir parametros de simulacion";
            this.introducirTiempoDeCicloToolStripMenuItem.Click += new System.EventHandler(this.introducirTiempoDeCicloToolStripMenuItem_Click);
            // 
            // simularToolStripMenuItem
            // 
            this.simularToolStripMenuItem.Name = "simularToolStripMenuItem";
            this.simularToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.simularToolStripMenuItem.Text = "Simular";
            this.simularToolStripMenuItem.Click += new System.EventHandler(this.simularToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Exercice8Forms.Properties.Resources.plane;
            this.ClientSize = new System.Drawing.Size(347, 143);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Ventana Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leerPlanDeVueloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem introducirTiempoDeCicloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simularToolStripMenuItem;
    }
}

