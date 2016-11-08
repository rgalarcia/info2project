namespace Exercice8Forms
{
    partial class MostrarTodosForm
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
            this.vuelosGrid = new System.Windows.Forms.DataGridView();
            this.Cerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vuelosGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // vuelosGrid
            // 
            this.vuelosGrid.AllowUserToAddRows = false;
            this.vuelosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vuelosGrid.Location = new System.Drawing.Point(47, 17);
            this.vuelosGrid.Name = "vuelosGrid";
            this.vuelosGrid.Size = new System.Drawing.Size(583, 246);
            this.vuelosGrid.TabIndex = 0;
            this.vuelosGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vuelosGrid_CellClick);
            this.vuelosGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vuelosGrid_CellContentClick);
            // 
            // Cerrar
            // 
            this.Cerrar.Location = new System.Drawing.Point(191, 289);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(75, 23);
            this.Cerrar.TabIndex = 1;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.UseVisualStyleBackColor = true;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // MostrarTodosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 373);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.vuelosGrid);
            this.Name = "MostrarTodosForm";
            this.Text = "MostrarTodosForm";
            this.Load += new System.EventHandler(this.MostrarTodosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vuelosGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView vuelosGrid;
        private System.Windows.Forms.Button Cerrar;
    }
}