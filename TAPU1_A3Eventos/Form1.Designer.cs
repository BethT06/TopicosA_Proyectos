
namespace TAPU1_A3Eventos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnMostrar = new System.Windows.Forms.Button();
            this.pbLouis2 = new System.Windows.Forms.PictureBox();
            this.pbLouis1 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnVer = new System.Windows.Forms.Button();
            this.lblTexto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLouis2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLouis1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(319, 70);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(137, 40);
            this.btnMostrar.TabIndex = 0;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // pbLouis2
            // 
            this.pbLouis2.Image = global::TAPU1_A3Eventos.Properties.Resources.Loubb;
            this.pbLouis2.Location = new System.Drawing.Point(469, 150);
            this.pbLouis2.Name = "pbLouis2";
            this.pbLouis2.Size = new System.Drawing.Size(197, 158);
            this.pbLouis2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLouis2.TabIndex = 2;
            this.pbLouis2.TabStop = false;
            this.pbLouis2.Click += new System.EventHandler(this.pbLouis2_Click);
            this.pbLouis2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbLouis2_MouseMove);
            // 
            // pbLouis1
            // 
            this.pbLouis1.Image = global::TAPU1_A3Eventos.Properties.Resources.lo;
            this.pbLouis1.Location = new System.Drawing.Point(92, 150);
            this.pbLouis1.Name = "pbLouis1";
            this.pbLouis1.Size = new System.Drawing.Size(185, 159);
            this.pbLouis1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLouis1.TabIndex = 1;
            this.pbLouis1.TabStop = false;
            this.pbLouis1.Click += new System.EventHandler(this.pbLouis1_Click);
            this.pbLouis1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbLouis1_MouseMove);
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(325, 248);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(106, 41);
            this.btnVer.TabIndex = 4;
            this.btnVer.Text = "Ver texto";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.MouseLeave += new System.EventHandler(this.btnVer_MouseLeave);
            this.btnVer.MouseHover += new System.EventHandler(this.btnVer_MouseHover);
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(219, 353);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(176, 16);
            this.lblTexto.TabIndex = 5;
            this.lblTexto.Text = "Pasa sobre el botón:)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(839, 415);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.pbLouis2);
            this.Controls.Add(this.pbLouis1);
            this.Controls.Add(this.btnMostrar);
            this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mostrar Eventos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pbLouis2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLouis1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.PictureBox pbLouis1;
        private System.Windows.Forms.PictureBox pbLouis2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Label lblTexto;
    }
}

