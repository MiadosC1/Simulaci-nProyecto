
namespace ProyectoSimulacion
{
    partial class Menu
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
            this.btnGenerador = new System.Windows.Forms.Button();
            this.btnProblem2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAcerca = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenerador
            // 
            this.btnGenerador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGenerador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerador.Location = new System.Drawing.Point(27, 97);
            this.btnGenerador.Name = "btnGenerador";
            this.btnGenerador.Size = new System.Drawing.Size(436, 76);
            this.btnGenerador.TabIndex = 0;
            this.btnGenerador.Text = "Generador";
            this.btnGenerador.UseVisualStyleBackColor = false;
            this.btnGenerador.Click += new System.EventHandler(this.btnGenerador_Click);
            // 
            // btnProblem2
            // 
            this.btnProblem2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnProblem2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProblem2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProblem2.Location = new System.Drawing.Point(27, 179);
            this.btnProblem2.Name = "btnProblem2";
            this.btnProblem2.Size = new System.Drawing.Size(436, 151);
            this.btnProblem2.TabIndex = 2;
            this.btnProblem2.Text = "VOLADOS";
            this.btnProblem2.UseVisualStyleBackColor = false;
            this.btnProblem2.Click += new System.EventHandler(this.btnProblem2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "MENU";
            // 
            // btnAcerca
            // 
            this.btnAcerca.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAcerca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcerca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcerca.Location = new System.Drawing.Point(27, 413);
            this.btnAcerca.Name = "btnAcerca";
            this.btnAcerca.Size = new System.Drawing.Size(158, 59);
            this.btnAcerca.TabIndex = 5;
            this.btnAcerca.Text = "Acerca de";
            this.btnAcerca.UseVisualStyleBackColor = false;
            this.btnAcerca.Click += new System.EventHandler(this.btnAcerca_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.DimGray;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(314, 413);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(149, 59);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(485, 484);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAcerca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnProblem2);
            this.Controls.Add(this.btnGenerador);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerador;
        private System.Windows.Forms.Button btnProblem2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAcerca;
        private System.Windows.Forms.Button btnSalir;
    }
}

