namespace Exercice8Forms
{
    partial class ConflictoForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.v2label = new System.Windows.Forms.Label();
            this.v1label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = " Hay un conflicto, quieres resolverlo?";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "SI";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(143, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "NO";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "velocidades propuestas:";
            // 
            // v2label
            // 
            this.v2label.AutoSize = true;
            this.v2label.Location = new System.Drawing.Point(194, 60);
            this.v2label.Name = "v2label";
            this.v2label.Size = new System.Drawing.Size(19, 13);
            this.v2label.TabIndex = 4;
            this.v2label.Text = "v2";
            // 
            // v1label
            // 
            this.v1label.AutoSize = true;
            this.v1label.Location = new System.Drawing.Point(150, 60);
            this.v1label.Name = "v1label";
            this.v1label.Size = new System.Drawing.Size(19, 13);
            this.v1label.TabIndex = 5;
            this.v1label.Text = "v1";
            // 
            // ConflictoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 188);
            this.Controls.Add(this.v1label);
            this.Controls.Add(this.v2label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "ConflictoForm";
            this.Text = "ConflictoForm";
            this.Load += new System.EventHandler(this.ConflictoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label v2label;
        private System.Windows.Forms.Label v1label;
    }
}