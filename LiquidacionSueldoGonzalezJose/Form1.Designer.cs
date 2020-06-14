namespace LiquidacionSueldoGonzalezJose
{
    partial class Form1
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
            this.txtrut = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbmes = new System.Windows.Forms.Label();
            this.lbanio = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "RUT     :";
            // 
            // txtrut
            // 
            this.txtrut.Location = new System.Drawing.Point(84, 29);
            this.txtrut.MaxLength = 12;
            this.txtrut.Name = "txtrut";
            this.txtrut.Size = new System.Drawing.Size(153, 20);
            this.txtrut.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "NOMBRE     :";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(438, 29);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(286, 20);
            this.txtnombre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "PERIODO DE REMUNERACION      :";
            // 
            // lbmes
            // 
            this.lbmes.AutoSize = true;
            this.lbmes.Location = new System.Drawing.Point(307, 84);
            this.lbmes.Name = "lbmes";
            this.lbmes.Size = new System.Drawing.Size(0, 13);
            this.lbmes.TabIndex = 5;
            // 
            // lbanio
            // 
            this.lbanio.AutoSize = true;
            this.lbanio.Location = new System.Drawing.Point(504, 84);
            this.lbanio.Name = "lbanio";
            this.lbanio.Size = new System.Drawing.Size(0, 13);
            this.lbanio.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(418, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "SUELDO BASE                                                                      " +
    "                                  :     $";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(416, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "OTROS INGRESOS                                                                   " +
    "                             :     $";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 805);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbanio);
            this.Controls.Add(this.lbmes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtrut);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtrut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbmes;
        private System.Windows.Forms.Label lbanio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

