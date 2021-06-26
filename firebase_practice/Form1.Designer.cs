
namespace firebase_practice
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.resultado = new System.Windows.Forms.Button();
            this.txtc = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.txta = new System.Windows.Forms.TextBox();
            this.lblx1 = new System.Windows.Forms.Label();
            this.lblx2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(56, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(606, 381);
            this.dataGridView1.TabIndex = 0;
            // 
            // resultado
            // 
            this.resultado.Location = new System.Drawing.Point(791, 356);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(75, 31);
            this.resultado.TabIndex = 1;
            this.resultado.Text = "resultado";
            this.resultado.UseVisualStyleBackColor = true;
            this.resultado.Click += new System.EventHandler(this.resultado_Click);
            // 
            // txtc
            // 
            this.txtc.Location = new System.Drawing.Point(791, 180);
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(100, 22);
            this.txtc.TabIndex = 3;
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(791, 133);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(100, 22);
            this.txtb.TabIndex = 4;
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(791, 89);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(100, 22);
            this.txta.TabIndex = 5;
            // 
            // lblx1
            // 
            this.lblx1.AutoSize = true;
            this.lblx1.Location = new System.Drawing.Point(757, 256);
            this.lblx1.Name = "lblx1";
            this.lblx1.Size = new System.Drawing.Size(46, 17);
            this.lblx1.TabIndex = 6;
            this.lblx1.Text = "label1";
            // 
            // lblx2
            // 
            this.lblx2.AutoSize = true;
            this.lblx2.Location = new System.Drawing.Point(845, 256);
            this.lblx2.Name = "lblx2";
            this.lblx2.Size = new System.Drawing.Size(46, 17);
            this.lblx2.TabIndex = 7;
            this.lblx2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 450);
            this.Controls.Add(this.lblx2);
            this.Controls.Add(this.lblx1);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txtc);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button resultado;
        private System.Windows.Forms.TextBox txtc;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.Label lblx1;
        private System.Windows.Forms.Label lblx2;
    }
}

