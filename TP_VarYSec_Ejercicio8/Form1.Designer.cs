namespace TP_VarYSec_Ejercicio8
{
    partial class fIntercambio
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
            this.bCerrar = new System.Windows.Forms.Button();
            this.bIntercambiar = new System.Windows.Forms.Button();
            this.lNumeroA = new System.Windows.Forms.Label();
            this.lNumeroB = new System.Windows.Forms.Label();
            this.tNumeroA = new System.Windows.Forms.TextBox();
            this.tNumeroB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bCerrar
            // 
            this.bCerrar.Location = new System.Drawing.Point(427, 199);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(75, 23);
            this.bCerrar.TabIndex = 0;
            this.bCerrar.Text = "Cerrar";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // bIntercambiar
            // 
            this.bIntercambiar.Location = new System.Drawing.Point(346, 199);
            this.bIntercambiar.Name = "bIntercambiar";
            this.bIntercambiar.Size = new System.Drawing.Size(75, 23);
            this.bIntercambiar.TabIndex = 1;
            this.bIntercambiar.Text = "Intercambiar";
            this.bIntercambiar.UseVisualStyleBackColor = true;
            this.bIntercambiar.Click += new System.EventHandler(this.bIntercambiar_Click);
            // 
            // lNumeroA
            // 
            this.lNumeroA.AutoSize = true;
            this.lNumeroA.Location = new System.Drawing.Point(45, 39);
            this.lNumeroA.Name = "lNumeroA";
            this.lNumeroA.Size = new System.Drawing.Size(57, 13);
            this.lNumeroA.TabIndex = 2;
            this.lNumeroA.Text = "Número A:";
            // 
            // lNumeroB
            // 
            this.lNumeroB.AutoSize = true;
            this.lNumeroB.Location = new System.Drawing.Point(45, 69);
            this.lNumeroB.Name = "lNumeroB";
            this.lNumeroB.Size = new System.Drawing.Size(57, 13);
            this.lNumeroB.TabIndex = 3;
            this.lNumeroB.Text = "Número B:";
            // 
            // tNumeroA
            // 
            this.tNumeroA.Location = new System.Drawing.Point(108, 36);
            this.tNumeroA.Name = "tNumeroA";
            this.tNumeroA.Size = new System.Drawing.Size(100, 20);
            this.tNumeroA.TabIndex = 4;
            // 
            // tNumeroB
            // 
            this.tNumeroB.Location = new System.Drawing.Point(108, 66);
            this.tNumeroB.Name = "tNumeroB";
            this.tNumeroB.Size = new System.Drawing.Size(100, 20);
            this.tNumeroB.TabIndex = 5;
            // 
            // fIntercambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 239);
            this.Controls.Add(this.tNumeroB);
            this.Controls.Add(this.tNumeroA);
            this.Controls.Add(this.lNumeroB);
            this.Controls.Add(this.lNumeroA);
            this.Controls.Add(this.bIntercambiar);
            this.Controls.Add(this.bCerrar);
            this.Name = "fIntercambio";
            this.Text = "Intercambio de números";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCerrar;
        private System.Windows.Forms.Button bIntercambiar;
        private System.Windows.Forms.Label lNumeroA;
        private System.Windows.Forms.Label lNumeroB;
        private System.Windows.Forms.TextBox tNumeroA;
        private System.Windows.Forms.TextBox tNumeroB;
    }
}

