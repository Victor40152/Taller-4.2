namespace taller4._1
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
            this.btnazul = new System.Windows.Forms.Button();
            this.btnrojo = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnnegro = new System.Windows.Forms.Button();
            this.btnblanco = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnazul
            // 
            this.btnazul.Location = new System.Drawing.Point(103, 94);
            this.btnazul.Name = "btnazul";
            this.btnazul.Size = new System.Drawing.Size(110, 39);
            this.btnazul.TabIndex = 0;
            this.btnazul.Text = "Azul";
            this.btnazul.UseVisualStyleBackColor = true;
            this.btnazul.Click += new System.EventHandler(this.btnazul_Click);
            // 
            // btnrojo
            // 
            this.btnrojo.Location = new System.Drawing.Point(348, 94);
            this.btnrojo.Name = "btnrojo";
            this.btnrojo.Size = new System.Drawing.Size(105, 39);
            this.btnrojo.TabIndex = 1;
            this.btnrojo.Text = "Rojo";
            this.btnrojo.UseVisualStyleBackColor = true;
            this.btnrojo.Click += new System.EventHandler(this.btnrojo_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(589, 94);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 39);
            this.button3.TabIndex = 2;
            this.button3.Text = "Amarillo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnnegro
            // 
            this.btnnegro.Location = new System.Drawing.Point(230, 255);
            this.btnnegro.Name = "btnnegro";
            this.btnnegro.Size = new System.Drawing.Size(105, 39);
            this.btnnegro.TabIndex = 3;
            this.btnnegro.Text = "Negro";
            this.btnnegro.UseVisualStyleBackColor = true;
            this.btnnegro.Click += new System.EventHandler(this.btnnegro_Click);
            // 
            // btnblanco
            // 
            this.btnblanco.Location = new System.Drawing.Point(452, 255);
            this.btnblanco.Name = "btnblanco";
            this.btnblanco.Size = new System.Drawing.Size(105, 39);
            this.btnblanco.TabIndex = 4;
            this.btnblanco.Text = "Blanco";
            this.btnblanco.UseVisualStyleBackColor = true;
            this.btnblanco.Click += new System.EventHandler(this.btnblanco_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnblanco);
            this.Controls.Add(this.btnnegro);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnrojo);
            this.Controls.Add(this.btnazul);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnazul;
        private System.Windows.Forms.Button btnrojo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnnegro;
        private System.Windows.Forms.Button btnblanco;
    }
}

