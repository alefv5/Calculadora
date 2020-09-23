namespace Calculadora
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
            this.Pantalla = new System.Windows.Forms.TextBox();
            this.botonIgual = new System.Windows.Forms.Button();
            this.botonDEL = new System.Windows.Forms.Button();
            this.botonDiv = new System.Windows.Forms.Button();
            this.botonPunto = new System.Windows.Forms.Button();
            this.boton3 = new System.Windows.Forms.Button();
            this.boton6 = new System.Windows.Forms.Button();
            this.boton9 = new System.Windows.Forms.Button();
            this.botonMult = new System.Windows.Forms.Button();
            this.boton2 = new System.Windows.Forms.Button();
            this.boton5 = new System.Windows.Forms.Button();
            this.boton8 = new System.Windows.Forms.Button();
            this.botonResta = new System.Windows.Forms.Button();
            this.boton0 = new System.Windows.Forms.Button();
            this.boton1 = new System.Windows.Forms.Button();
            this.boton4 = new System.Windows.Forms.Button();
            this.boton7 = new System.Windows.Forms.Button();
            this.botonSuma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Pantalla
            // 
            this.Pantalla.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pantalla.Location = new System.Drawing.Point(12, 21);
            this.Pantalla.Name = "Pantalla";
            this.Pantalla.Size = new System.Drawing.Size(234, 35);
            this.Pantalla.TabIndex = 1;
            this.Pantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // botonIgual
            // 
            this.botonIgual.BackColor = System.Drawing.Color.MediumPurple;
            this.botonIgual.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonIgual.Location = new System.Drawing.Point(185, 124);
            this.botonIgual.Margin = new System.Windows.Forms.Padding(2);
            this.botonIgual.Name = "botonIgual";
            this.botonIgual.Size = new System.Drawing.Size(50, 172);
            this.botonIgual.TabIndex = 46;
            this.botonIgual.Text = "=";
            this.botonIgual.UseVisualStyleBackColor = false;
            this.botonIgual.Click += new System.EventHandler(this.botonIgual_Click);
            // 
            // botonDEL
            // 
            this.botonDEL.BackColor = System.Drawing.Color.MediumPurple;
            this.botonDEL.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDEL.Location = new System.Drawing.Point(164, 308);
            this.botonDEL.Margin = new System.Windows.Forms.Padding(2);
            this.botonDEL.Name = "botonDEL";
            this.botonDEL.Size = new System.Drawing.Size(71, 39);
            this.botonDEL.TabIndex = 44;
            this.botonDEL.Text = "DEL";
            this.botonDEL.UseVisualStyleBackColor = false;
            this.botonDEL.Click += new System.EventHandler(this.botonEliminar_Click);
            // 
            // botonDiv
            // 
            this.botonDiv.BackColor = System.Drawing.Color.MediumPurple;
            this.botonDiv.Font = new System.Drawing.Font("Elephant", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDiv.Location = new System.Drawing.Point(178, 70);
            this.botonDiv.Margin = new System.Windows.Forms.Padding(2);
            this.botonDiv.Name = "botonDiv";
            this.botonDiv.Size = new System.Drawing.Size(47, 44);
            this.botonDiv.TabIndex = 43;
            this.botonDiv.Text = "/";
            this.botonDiv.UseVisualStyleBackColor = false;
            this.botonDiv.Click += new System.EventHandler(this.botonOperador_Click);
            // 
            // botonPunto
            // 
            this.botonPunto.BackColor = System.Drawing.Color.MediumPurple;
            this.botonPunto.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonPunto.Location = new System.Drawing.Point(108, 306);
            this.botonPunto.Margin = new System.Windows.Forms.Padding(2);
            this.botonPunto.Name = "botonPunto";
            this.botonPunto.Size = new System.Drawing.Size(52, 43);
            this.botonPunto.TabIndex = 42;
            this.botonPunto.Text = ",";
            this.botonPunto.UseVisualStyleBackColor = false;
            this.botonPunto.Click += new System.EventHandler(this.botonNumeros_Click);
            // 
            // boton3
            // 
            this.boton3.BackColor = System.Drawing.Color.MediumPurple;
            this.boton3.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton3.Location = new System.Drawing.Point(128, 243);
            this.boton3.Margin = new System.Windows.Forms.Padding(2);
            this.boton3.Name = "boton3";
            this.boton3.Size = new System.Drawing.Size(52, 53);
            this.boton3.TabIndex = 41;
            this.boton3.Text = "3";
            this.boton3.UseVisualStyleBackColor = false;
            this.boton3.Click += new System.EventHandler(this.botonNumeros_Click);
            // 
            // boton6
            // 
            this.boton6.BackColor = System.Drawing.Color.MediumPurple;
            this.boton6.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton6.Location = new System.Drawing.Point(128, 181);
            this.boton6.Margin = new System.Windows.Forms.Padding(2);
            this.boton6.Name = "boton6";
            this.boton6.Size = new System.Drawing.Size(52, 49);
            this.boton6.TabIndex = 40;
            this.boton6.Text = "6";
            this.boton6.UseVisualStyleBackColor = false;
            this.boton6.Click += new System.EventHandler(this.botonNumeros_Click);
            // 
            // boton9
            // 
            this.boton9.BackColor = System.Drawing.Color.MediumPurple;
            this.boton9.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton9.Location = new System.Drawing.Point(129, 124);
            this.boton9.Margin = new System.Windows.Forms.Padding(2);
            this.boton9.Name = "boton9";
            this.boton9.Size = new System.Drawing.Size(52, 54);
            this.boton9.TabIndex = 39;
            this.boton9.Text = "9";
            this.boton9.UseVisualStyleBackColor = false;
            this.boton9.Click += new System.EventHandler(this.botonNumeros_Click);
            // 
            // botonMult
            // 
            this.botonMult.BackColor = System.Drawing.Color.MediumPurple;
            this.botonMult.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonMult.Location = new System.Drawing.Point(128, 70);
            this.botonMult.Margin = new System.Windows.Forms.Padding(2);
            this.botonMult.Name = "botonMult";
            this.botonMult.Size = new System.Drawing.Size(46, 44);
            this.botonMult.TabIndex = 38;
            this.botonMult.Text = "*";
            this.botonMult.UseVisualStyleBackColor = false;
            this.botonMult.Click += new System.EventHandler(this.botonOperador_Click);
            // 
            // boton2
            // 
            this.boton2.BackColor = System.Drawing.Color.MediumPurple;
            this.boton2.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton2.Location = new System.Drawing.Point(70, 243);
            this.boton2.Margin = new System.Windows.Forms.Padding(2);
            this.boton2.Name = "boton2";
            this.boton2.Size = new System.Drawing.Size(54, 53);
            this.boton2.TabIndex = 37;
            this.boton2.Text = "2";
            this.boton2.UseVisualStyleBackColor = false;
            this.boton2.Click += new System.EventHandler(this.botonNumeros_Click);
            // 
            // boton5
            // 
            this.boton5.BackColor = System.Drawing.Color.MediumPurple;
            this.boton5.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton5.Location = new System.Drawing.Point(70, 181);
            this.boton5.Margin = new System.Windows.Forms.Padding(2);
            this.boton5.Name = "boton5";
            this.boton5.Size = new System.Drawing.Size(54, 49);
            this.boton5.TabIndex = 36;
            this.boton5.Text = "5";
            this.boton5.UseVisualStyleBackColor = false;
            this.boton5.Click += new System.EventHandler(this.botonNumeros_Click);
            // 
            // boton8
            // 
            this.boton8.BackColor = System.Drawing.Color.MediumPurple;
            this.boton8.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton8.Location = new System.Drawing.Point(70, 123);
            this.boton8.Margin = new System.Windows.Forms.Padding(2);
            this.boton8.Name = "boton8";
            this.boton8.Size = new System.Drawing.Size(54, 54);
            this.boton8.TabIndex = 35;
            this.boton8.Text = "8";
            this.boton8.UseVisualStyleBackColor = false;
            this.boton8.Click += new System.EventHandler(this.botonNumeros_Click);
            // 
            // botonResta
            // 
            this.botonResta.BackColor = System.Drawing.Color.MediumPurple;
            this.botonResta.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonResta.Location = new System.Drawing.Point(70, 70);
            this.botonResta.Margin = new System.Windows.Forms.Padding(2);
            this.botonResta.Name = "botonResta";
            this.botonResta.Size = new System.Drawing.Size(54, 44);
            this.botonResta.TabIndex = 34;
            this.botonResta.Text = "-";
            this.botonResta.UseVisualStyleBackColor = false;
            this.botonResta.Click += new System.EventHandler(this.botonOperador_Click);
            // 
            // boton0
            // 
            this.boton0.BackColor = System.Drawing.Color.MediumPurple;
            this.boton0.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton0.Location = new System.Drawing.Point(12, 306);
            this.boton0.Margin = new System.Windows.Forms.Padding(2);
            this.boton0.Name = "boton0";
            this.boton0.Size = new System.Drawing.Size(90, 43);
            this.boton0.TabIndex = 33;
            this.boton0.Text = "0";
            this.boton0.UseVisualStyleBackColor = false;
            this.boton0.Click += new System.EventHandler(this.botonNumeros_Click);
            // 
            // boton1
            // 
            this.boton1.BackColor = System.Drawing.Color.MediumPurple;
            this.boton1.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton1.Location = new System.Drawing.Point(12, 243);
            this.boton1.Margin = new System.Windows.Forms.Padding(2);
            this.boton1.Name = "boton1";
            this.boton1.Size = new System.Drawing.Size(54, 53);
            this.boton1.TabIndex = 32;
            this.boton1.Text = "1";
            this.boton1.UseVisualStyleBackColor = false;
            this.boton1.Click += new System.EventHandler(this.botonNumeros_Click);
            // 
            // boton4
            // 
            this.boton4.BackColor = System.Drawing.Color.MediumPurple;
            this.boton4.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton4.Location = new System.Drawing.Point(12, 181);
            this.boton4.Margin = new System.Windows.Forms.Padding(2);
            this.boton4.Name = "boton4";
            this.boton4.Size = new System.Drawing.Size(54, 49);
            this.boton4.TabIndex = 31;
            this.boton4.Text = "4";
            this.boton4.UseVisualStyleBackColor = false;
            this.boton4.Click += new System.EventHandler(this.botonNumeros_Click);
            // 
            // boton7
            // 
            this.boton7.BackColor = System.Drawing.Color.MediumPurple;
            this.boton7.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton7.Location = new System.Drawing.Point(12, 123);
            this.boton7.Margin = new System.Windows.Forms.Padding(2);
            this.boton7.Name = "boton7";
            this.boton7.Size = new System.Drawing.Size(54, 54);
            this.boton7.TabIndex = 30;
            this.boton7.Text = "7";
            this.boton7.UseVisualStyleBackColor = false;
            this.boton7.Click += new System.EventHandler(this.botonNumeros_Click);
            // 
            // botonSuma
            // 
            this.botonSuma.BackColor = System.Drawing.Color.MediumPurple;
            this.botonSuma.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonSuma.Location = new System.Drawing.Point(12, 70);
            this.botonSuma.Margin = new System.Windows.Forms.Padding(2);
            this.botonSuma.Name = "botonSuma";
            this.botonSuma.Size = new System.Drawing.Size(54, 44);
            this.botonSuma.TabIndex = 29;
            this.botonSuma.Text = "+";
            this.botonSuma.UseVisualStyleBackColor = false;
            this.botonSuma.Click += new System.EventHandler(this.botonOperador_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(258, 360);
            this.Controls.Add(this.botonIgual);
            this.Controls.Add(this.botonDEL);
            this.Controls.Add(this.botonDiv);
            this.Controls.Add(this.botonPunto);
            this.Controls.Add(this.boton3);
            this.Controls.Add(this.boton6);
            this.Controls.Add(this.boton9);
            this.Controls.Add(this.botonMult);
            this.Controls.Add(this.boton2);
            this.Controls.Add(this.boton5);
            this.Controls.Add(this.boton8);
            this.Controls.Add(this.botonResta);
            this.Controls.Add(this.boton0);
            this.Controls.Add(this.boton1);
            this.Controls.Add(this.boton4);
            this.Controls.Add(this.boton7);
            this.Controls.Add(this.botonSuma);
            this.Controls.Add(this.Pantalla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Pantalla;
        private System.Windows.Forms.Button botonIgual;
        private System.Windows.Forms.Button botonDEL;
        private System.Windows.Forms.Button botonDiv;
        private System.Windows.Forms.Button botonPunto;
        private System.Windows.Forms.Button boton3;
        private System.Windows.Forms.Button boton6;
        private System.Windows.Forms.Button boton9;
        private System.Windows.Forms.Button botonMult;
        private System.Windows.Forms.Button boton2;
        private System.Windows.Forms.Button boton5;
        private System.Windows.Forms.Button boton8;
        private System.Windows.Forms.Button botonResta;
        private System.Windows.Forms.Button boton0;
        private System.Windows.Forms.Button boton1;
        private System.Windows.Forms.Button boton4;
        private System.Windows.Forms.Button boton7;
        private System.Windows.Forms.Button botonSuma;
    }
}

