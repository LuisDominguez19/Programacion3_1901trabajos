
namespace Examen_SegundoParcial.Vistas
{
    partial class DetallesView
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
            this.textnomb = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Cliente = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textsoporte = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.texttotal = new System.Windows.Forms.TextBox();
            this.Cliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // textnomb
            // 
            this.textnomb.Location = new System.Drawing.Point(52, 29);
            this.textnomb.Name = "textnomb";
            this.textnomb.ReadOnly = true;
            this.textnomb.Size = new System.Drawing.Size(261, 20);
            this.textnomb.TabIndex = 0;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(49, 9);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(50, 13);
            this.Nombre.TabIndex = 1;
            this.Nombre.Text = "Nombre";
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha.Location = new System.Drawing.Point(363, 16);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(42, 13);
            this.Fecha.TabIndex = 2;
            this.Fecha.Text = "Fecha";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(366, 32);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(114, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // Cliente
            // 
            this.Cliente.Controls.Add(this.label3);
            this.Cliente.Controls.Add(this.texttotal);
            this.Cliente.Controls.Add(this.label2);
            this.Cliente.Controls.Add(this.textsoporte);
            this.Cliente.Controls.Add(this.label1);
            this.Cliente.Controls.Add(this.textBox1);
            this.Cliente.Location = new System.Drawing.Point(43, 73);
            this.Cliente.Name = "Cliente";
            this.Cliente.Size = new System.Drawing.Size(581, 190);
            this.Cliente.TabIndex = 4;
            this.Cliente.TabStop = false;
            this.Cliente.Text = "Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Telefono";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(261, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tipo de soporte";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textsoporte
            // 
            this.textsoporte.Location = new System.Drawing.Point(9, 92);
            this.textsoporte.Name = "textsoporte";
            this.textsoporte.ReadOnly = true;
            this.textsoporte.Size = new System.Drawing.Size(261, 20);
            this.textsoporte.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(295, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total";
            // 
            // texttotal
            // 
            this.texttotal.Location = new System.Drawing.Point(289, 92);
            this.texttotal.Name = "texttotal";
            this.texttotal.ReadOnly = true;
            this.texttotal.Size = new System.Drawing.Size(261, 20);
            this.texttotal.TabIndex = 6;
            // 
            // Detalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 275);
            this.Controls.Add(this.Cliente);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.textnomb);
            this.Name = "Detalles";
            this.Text = "Detalles";
            this.Cliente.ResumeLayout(false);
            this.Cliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textnomb;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox Cliente;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textsoporte;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox texttotal;
    }
}