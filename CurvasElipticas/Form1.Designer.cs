namespace CurvasElipticas
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
            this.x1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelP = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.y1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelQ = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.y2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.x2 = new System.Windows.Forms.TextBox();
            this.calculaLambda = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.fieldA = new System.Windows.Forms.TextBox();
            this.fieldMod = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.texto = new System.Windows.Forms.Label();
            this.panelP.SuspendLayout();
            this.panelQ.SuspendLayout();
            this.SuspendLayout();
            // 
            // x1
            // 
            this.x1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.x1.Location = new System.Drawing.Point(36, 11);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(73, 20);
            this.x1.TabIndex = 0;
            this.x1.TextChanged += new System.EventHandler(this.ativaBotao);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "x1:";
            // 
            // panelP
            // 
            this.panelP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelP.Controls.Add(this.label2);
            this.panelP.Controls.Add(this.y1);
            this.panelP.Controls.Add(this.label1);
            this.panelP.Controls.Add(this.x1);
            this.panelP.Location = new System.Drawing.Point(31, 29);
            this.panelP.Name = "panelP";
            this.panelP.Size = new System.Drawing.Size(119, 90);
            this.panelP.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "y1:";
            // 
            // y1
            // 
            this.y1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.y1.Location = new System.Drawing.Point(36, 47);
            this.y1.Name = "y1";
            this.y1.Size = new System.Drawing.Size(73, 20);
            this.y1.TabIndex = 2;
            this.y1.TextChanged += new System.EventHandler(this.ativaBotao);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "P:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Q:";
            // 
            // panelQ
            // 
            this.panelQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelQ.Controls.Add(this.label5);
            this.panelQ.Controls.Add(this.y2);
            this.panelQ.Controls.Add(this.label6);
            this.panelQ.Controls.Add(this.x2);
            this.panelQ.Location = new System.Drawing.Point(218, 29);
            this.panelQ.Name = "panelQ";
            this.panelQ.Size = new System.Drawing.Size(119, 90);
            this.panelQ.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "y2:";
            // 
            // y2
            // 
            this.y2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.y2.Location = new System.Drawing.Point(36, 47);
            this.y2.Name = "y2";
            this.y2.Size = new System.Drawing.Size(73, 20);
            this.y2.TabIndex = 2;
            this.y2.TextChanged += new System.EventHandler(this.ativaBotao);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "x2:";
            // 
            // x2
            // 
            this.x2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.x2.Location = new System.Drawing.Point(36, 11);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(73, 20);
            this.x2.TabIndex = 0;
            this.x2.TextChanged += new System.EventHandler(this.ativaBotao);
            // 
            // calculaLambda
            // 
            this.calculaLambda.Enabled = false;
            this.calculaLambda.Location = new System.Drawing.Point(112, 184);
            this.calculaLambda.Name = "calculaLambda";
            this.calculaLambda.Size = new System.Drawing.Size(121, 23);
            this.calculaLambda.TabIndex = 6;
            this.calculaLambda.Text = "Calcular Lambda";
            this.calculaLambda.UseVisualStyleBackColor = true;
            this.calculaLambda.Click += new System.EventHandler(this.calcularLambda);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(222, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "A:";
            // 
            // fieldA
            // 
            this.fieldA.Location = new System.Drawing.Point(245, 132);
            this.fieldA.Name = "fieldA";
            this.fieldA.Size = new System.Drawing.Size(58, 20);
            this.fieldA.TabIndex = 8;
            // 
            // fieldMod
            // 
            this.fieldMod.Location = new System.Drawing.Point(68, 135);
            this.fieldMod.Name = "fieldMod";
            this.fieldMod.Size = new System.Drawing.Size(63, 20);
            this.fieldMod.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "p:";
            // 
            // texto
            // 
            this.texto.AutoSize = true;
            this.texto.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto.Location = new System.Drawing.Point(85, 249);
            this.texto.Name = "texto";
            this.texto.Size = new System.Drawing.Size(65, 20);
            this.texto.TabIndex = 11;
            this.texto.Text = "Valores:";
            this.texto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 323);
            this.Controls.Add(this.texto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.fieldMod);
            this.Controls.Add(this.fieldA);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.calculaLambda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panelQ);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelP);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Curvas Elipticas";
            this.panelP.ResumeLayout(false);
            this.panelP.PerformLayout();
            this.panelQ.ResumeLayout(false);
            this.panelQ.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox x1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox y1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelQ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox y2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox x2;
        private System.Windows.Forms.Button calculaLambda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox fieldA;
        private System.Windows.Forms.TextBox fieldMod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label texto;
    }
}

