namespace Laboratorio_5
{
    partial class Snake
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Snake));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel = new System.Windows.Forms.Panel();
            this.mejoresPuntajes = new System.Windows.Forms.Button();
            this.botonEmpezar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.puntos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel
            // 
            this.panel.BackgroundImage = global::Laboratorio_5.Properties.Resources.fondo;
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel.Location = new System.Drawing.Point(17, 16);
            this.panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(633, 462);
            this.panel.TabIndex = 0;
            // 
            // mejoresPuntajes
            // 
            this.mejoresPuntajes.Location = new System.Drawing.Point(683, 400);
            this.mejoresPuntajes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mejoresPuntajes.Name = "mejoresPuntajes";
            this.mejoresPuntajes.Size = new System.Drawing.Size(163, 44);
            this.mejoresPuntajes.TabIndex = 1;
            this.mejoresPuntajes.Text = "Mejores Puntajes";
            this.mejoresPuntajes.UseVisualStyleBackColor = true;
            this.mejoresPuntajes.Click += new System.EventHandler(this.mejoresPuntajes_Click);
            // 
            // botonEmpezar
            // 
            this.botonEmpezar.Location = new System.Drawing.Point(683, 58);
            this.botonEmpezar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botonEmpezar.Name = "botonEmpezar";
            this.botonEmpezar.Size = new System.Drawing.Size(163, 44);
            this.botonEmpezar.TabIndex = 2;
            this.botonEmpezar.Text = "Empezar partida";
            this.botonEmpezar.UseVisualStyleBackColor = true;
            this.botonEmpezar.Click += new System.EventHandler(this.botonEmpezar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(689, 151);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "PUNTAJE";
            // 
            // puntos
            // 
            this.puntos.AutoSize = true;
            this.puntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puntos.Location = new System.Drawing.Point(751, 209);
            this.puntos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.puntos.Name = "puntos";
            this.puntos.Size = new System.Drawing.Size(19, 20);
            this.puntos.TabIndex = 4;
            this.puntos.Text = "0";
            // 
            // Snake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(877, 486);
            this.Controls.Add(this.puntos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonEmpezar);
            this.Controls.Add(this.mejoresPuntajes);
            this.Controls.Add(this.panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Snake";
            this.Text = "Snake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.moverPieza);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button mejoresPuntajes;
        private System.Windows.Forms.Button botonEmpezar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label puntos;
    }
}

