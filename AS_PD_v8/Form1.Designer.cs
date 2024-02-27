namespace AS_PD_v8
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.izdevum = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.summa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ienakum = new System.Windows.Forms.NumericUpDown();
            this.papildienakum = new System.Windows.Forms.NumericUpDown();
            this.rekinat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ienakum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.papildienakum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ievadiet Jūsu ienākumus un izdevumus:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ienākumi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Papildus ienākumi:";
            // 
            // izdevum
            // 
            this.izdevum.Location = new System.Drawing.Point(270, 169);
            this.izdevum.Name = "izdevum";
            this.izdevum.Size = new System.Drawing.Size(135, 20);
            this.izdevum.TabIndex = 5;
            this.izdevum.TextChanged += new System.EventHandler(this.izdevum_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(463, 169);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(131, 20);
            this.textBox4.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Izdevumi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(460, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Papildus izdevumi:";
            // 
            // summa
            // 
            this.summa.Location = new System.Drawing.Point(54, 299);
            this.summa.Name = "summa";
            this.summa.Size = new System.Drawing.Size(136, 20);
            this.summa.TabIndex = 9;
            this.summa.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Visi ienākumi:";
            // 
            // ienakum
            // 
            this.ienakum.Location = new System.Drawing.Point(56, 138);
            this.ienakum.Name = "ienakum";
            this.ienakum.Size = new System.Drawing.Size(135, 20);
            this.ienakum.TabIndex = 11;
            this.ienakum.ValueChanged += new System.EventHandler(this.ienakum_ValueChanged);
            // 
            // papildienakum
            // 
            this.papildienakum.Location = new System.Drawing.Point(54, 190);
            this.papildienakum.Name = "papildienakum";
            this.papildienakum.Size = new System.Drawing.Size(137, 20);
            this.papildienakum.TabIndex = 12;
            this.papildienakum.ValueChanged += new System.EventHandler(this.papildienakum_ValueChanged);
            // 
            // rekinat
            // 
            this.rekinat.Location = new System.Drawing.Point(73, 237);
            this.rekinat.Name = "rekinat";
            this.rekinat.Size = new System.Drawing.Size(75, 23);
            this.rekinat.TabIndex = 13;
            this.rekinat.Text = "Aprēķināt";
            this.rekinat.UseVisualStyleBackColor = true;
            this.rekinat.Click += new System.EventHandler(this.rekinat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rekinat);
            this.Controls.Add(this.papildienakum);
            this.Controls.Add(this.ienakum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.summa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.izdevum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ienakum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.papildienakum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox izdevum;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox summa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown ienakum;
        private System.Windows.Forms.NumericUpDown papildienakum;
        private System.Windows.Forms.Button rekinat;
    }
}

