namespace Exercice8Forms
{
    partial class DatosForm
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
            this.DestinoXbox = new System.Windows.Forms.TextBox();
            this.destinoYBox = new System.Windows.Forms.TextBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.compañiaBox = new System.Windows.Forms.TextBox();
            this.velocidadBox = new System.Windows.Forms.TextBox();
            this.origenXBox = new System.Windows.Forms.TextBox();
            this.OrigenYBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DestinoXbox
            // 
            this.DestinoXbox.Location = new System.Drawing.Point(135, 138);
            this.DestinoXbox.Name = "DestinoXbox";
            this.DestinoXbox.Size = new System.Drawing.Size(44, 20);
            this.DestinoXbox.TabIndex = 41;
            // 
            // destinoYBox
            // 
            this.destinoYBox.Location = new System.Drawing.Point(195, 138);
            this.destinoYBox.Name = "destinoYBox";
            this.destinoYBox.Size = new System.Drawing.Size(43, 20);
            this.destinoYBox.TabIndex = 40;
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(138, 38);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(100, 20);
            this.idBox.TabIndex = 39;
            // 
            // compañiaBox
            // 
            this.compañiaBox.Location = new System.Drawing.Point(138, 68);
            this.compañiaBox.Name = "compañiaBox";
            this.compañiaBox.Size = new System.Drawing.Size(100, 20);
            this.compañiaBox.TabIndex = 38;
            // 
            // velocidadBox
            // 
            this.velocidadBox.Location = new System.Drawing.Point(135, 174);
            this.velocidadBox.Name = "velocidadBox";
            this.velocidadBox.Size = new System.Drawing.Size(100, 20);
            this.velocidadBox.TabIndex = 37;
            // 
            // origenXBox
            // 
            this.origenXBox.Location = new System.Drawing.Point(138, 104);
            this.origenXBox.Name = "origenXBox";
            this.origenXBox.Size = new System.Drawing.Size(41, 20);
            this.origenXBox.TabIndex = 36;
            // 
            // OrigenYBox
            // 
            this.OrigenYBox.Location = new System.Drawing.Point(195, 104);
            this.OrigenYBox.Name = "OrigenYBox";
            this.OrigenYBox.Size = new System.Drawing.Size(40, 20);
            this.OrigenYBox.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Velocidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Destino";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Compañia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Origen";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 42;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DatosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 295);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DestinoXbox);
            this.Controls.Add(this.destinoYBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.compañiaBox);
            this.Controls.Add(this.velocidadBox);
            this.Controls.Add(this.origenXBox);
            this.Controls.Add(this.OrigenYBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DatosForm";
            this.Text = "DatosForm";
            this.Load += new System.EventHandler(this.DatosForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DestinoXbox;
        private System.Windows.Forms.TextBox destinoYBox;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.TextBox compañiaBox;
        private System.Windows.Forms.TextBox velocidadBox;
        private System.Windows.Forms.TextBox origenXBox;
        private System.Windows.Forms.TextBox OrigenYBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}