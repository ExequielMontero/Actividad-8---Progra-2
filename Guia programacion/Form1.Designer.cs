namespace Guia_programacion
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
            this.lbVer = new System.Windows.Forms.ListBox();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnResguardar = new System.Windows.Forms.Button();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbVer
            // 
            this.lbVer.FormattingEnabled = true;
            this.lbVer.Location = new System.Drawing.Point(14, 12);
            this.lbVer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbVer.Name = "lbVer";
            this.lbVer.Size = new System.Drawing.Size(751, 433);
            this.lbVer.TabIndex = 1;
            this.lbVer.SelectedIndexChanged += new System.EventHandler(this.lbVer_SelectedIndexChanged);
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(772, 71);
            this.btnImportar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(158, 44);
            this.btnImportar.TabIndex = 2;
            this.btnImportar.Text = "2- Importar cuentas";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(772, 12);
            this.btnVer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(158, 44);
            this.btnVer.TabIndex = 3;
            this.btnVer.Text = "1- Ver cuentas";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(773, 175);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(158, 44);
            this.btnExportar.TabIndex = 4;
            this.btnExportar.Text = "4- Exportar cuentas";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnResguardar
            // 
            this.btnResguardar.Location = new System.Drawing.Point(773, 235);
            this.btnResguardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnResguardar.Name = "btnResguardar";
            this.btnResguardar.Size = new System.Drawing.Size(158, 44);
            this.btnResguardar.TabIndex = 5;
            this.btnResguardar.Text = "5- Resguardar (Backup)";
            this.btnResguardar.UseVisualStyleBackColor = true;
            this.btnResguardar.Click += new System.EventHandler(this.btnResguardar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Location = new System.Drawing.Point(773, 294);
            this.btnRestaurar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(158, 44);
            this.btnRestaurar.TabIndex = 6;
            this.btnRestaurar.Text = "6- Restaurar(Restore)";
            this.btnRestaurar.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Enabled = false;
            this.btnLimpiar.Location = new System.Drawing.Point(773, 121);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(158, 44);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "3- Limpiar cuentas internamente";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.btnResguardar);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.lbVer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Banco";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbVer;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnResguardar;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

