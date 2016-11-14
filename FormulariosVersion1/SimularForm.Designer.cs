namespace Exercice8Forms
{
    partial class SimularForm
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
            this.components = new System.ComponentModel.Container();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Reloj = new System.Windows.Forms.Timer(this.components);
            this.tiempoBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.miPanel = new System.Windows.Forms.Panel();
            this.plan2label = new System.Windows.Forms.Label();
            this.plan1label = new System.Windows.Forms.Label();
            this.V2Box = new System.Windows.Forms.TextBox();
            this.V1Box = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.speedV1 = new System.Windows.Forms.Label();
            this.speedV2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(133, 67);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "Mover vuelo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(802, 421);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "(545, 353)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(309, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "(0, 0)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Mostrar todos los vuelos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Iniciar Simulacion Automatica";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Reloj
            // 
            this.Reloj.Tick += new System.EventHandler(this.Reloj_Tick);
            // 
            // tiempoBox
            // 
            this.tiempoBox.Location = new System.Drawing.Point(193, 120);
            this.tiempoBox.Name = "tiempoBox";
            this.tiempoBox.Size = new System.Drawing.Size(65, 20);
            this.tiempoBox.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Tiempo (s)";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(130, 204);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 27;
            this.button4.Text = "Reiniciar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(95, 247);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(145, 52);
            this.button5.TabIndex = 28;
            this.button5.Text = "Habrá conflicto?";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // miPanel
            // 
            this.miPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.miPanel.BackgroundImage = global::Exercice8Forms.Properties.Resources.image;
            this.miPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.miPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.miPanel.Location = new System.Drawing.Point(312, 65);
            this.miPanel.Name = "miPanel";
            this.miPanel.Size = new System.Drawing.Size(545, 353);
            this.miPanel.TabIndex = 19;
            this.miPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.miPanel_Paint);
            // 
            // plan2label
            // 
            this.plan2label.AutoSize = true;
            this.plan2label.Location = new System.Drawing.Point(26, 402);
            this.plan2label.Name = "plan2label";
            this.plan2label.Size = new System.Drawing.Size(35, 13);
            this.plan2label.TabIndex = 42;
            this.plan2label.Text = "label4";
            // 
            // plan1label
            // 
            this.plan1label.AutoSize = true;
            this.plan1label.Location = new System.Drawing.Point(26, 376);
            this.plan1label.Name = "plan1label";
            this.plan1label.Size = new System.Drawing.Size(35, 13);
            this.plan1label.TabIndex = 41;
            this.plan1label.Text = "label3";
            // 
            // V2Box
            // 
            this.V2Box.Location = new System.Drawing.Point(100, 402);
            this.V2Box.Name = "V2Box";
            this.V2Box.Size = new System.Drawing.Size(100, 20);
            this.V2Box.TabIndex = 40;
            // 
            // V1Box
            // 
            this.V1Box.Location = new System.Drawing.Point(100, 376);
            this.V1Box.Name = "V1Box";
            this.V1Box.Size = new System.Drawing.Size(100, 20);
            this.V1Box.TabIndex = 39;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(44, 437);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(97, 23);
            this.button7.TabIndex = 38;
            this.button7.Text = "Cambiar i reiniciar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "CAMBIAR VELOCIDADES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Actual speed";
            // 
            // speedV1
            // 
            this.speedV1.AutoSize = true;
            this.speedV1.Location = new System.Drawing.Point(234, 383);
            this.speedV1.Name = "speedV1";
            this.speedV1.Size = new System.Drawing.Size(35, 13);
            this.speedV1.TabIndex = 44;
            this.speedV1.Text = "label4";
            // 
            // speedV2
            // 
            this.speedV2.AutoSize = true;
            this.speedV2.Location = new System.Drawing.Point(234, 409);
            this.speedV2.Name = "speedV2";
            this.speedV2.Size = new System.Drawing.Size(35, 13);
            this.speedV2.TabIndex = 45;
            this.speedV2.Text = "label5";
            // 
            // SimularForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1001, 495);
            this.Controls.Add(this.speedV2);
            this.Controls.Add(this.speedV1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.plan2label);
            this.Controls.Add(this.plan1label);
            this.Controls.Add(this.V2Box);
            this.Controls.Add(this.V1Box);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tiempoBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.miPanel);
            this.Name = "SimularForm";
            this.Text = "SimularForm";
            this.Load += new System.EventHandler(this.SimularForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel miPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer Reloj;
        private System.Windows.Forms.TextBox tiempoBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label plan2label;
        private System.Windows.Forms.Label plan1label;
        private System.Windows.Forms.TextBox V2Box;
        private System.Windows.Forms.TextBox V1Box;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label speedV1;
        private System.Windows.Forms.Label speedV2;
    }
}