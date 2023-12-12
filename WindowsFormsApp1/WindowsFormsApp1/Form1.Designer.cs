namespace WindowsFormsApp1
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
            this.button1 = new System.Windows.Forms.Button();
            this.tNum1 = new System.Windows.Forms.TextBox();
            this.tNum2 = new System.Windows.Forms.TextBox();
            this.tNum3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(193, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(397, 122);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tNum1
            // 
            this.tNum1.Location = new System.Drawing.Point(395, 81);
            this.tNum1.Name = "tNum1";
            this.tNum1.Size = new System.Drawing.Size(180, 22);
            this.tNum1.TabIndex = 1;
            // 
            // tNum2
            // 
            this.tNum2.Location = new System.Drawing.Point(401, 126);
            this.tNum2.Name = "tNum2";
            this.tNum2.Size = new System.Drawing.Size(147, 22);
            this.tNum2.TabIndex = 2;
            // 
            // tNum3
            // 
            this.tNum3.Location = new System.Drawing.Point(401, 171);
            this.tNum3.Name = "tNum3";
            this.tNum3.Size = new System.Drawing.Size(174, 22);
            this.tNum3.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tNum3);
            this.Controls.Add(this.tNum2);
            this.Controls.Add(this.tNum1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tNum1;
        private System.Windows.Forms.TextBox tNum2;
        private System.Windows.Forms.TextBox tNum3;
    }
}

