
namespace Examen_SegundoParcial.Vistas
{
    partial class Tipos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textprecio = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnregresar = new System.Windows.Forms.Button();
            this.comboBoxNombre = new System.Windows.Forms.ComboBox();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textTelf = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio";
            // 
            // textprecio
            // 
            this.textprecio.Location = new System.Drawing.Point(112, 118);
            this.textprecio.Name = "textprecio";
            this.textprecio.Size = new System.Drawing.Size(133, 20);
            this.textprecio.TabIndex = 3;
            this.textprecio.TextChanged += new System.EventHandler(this.textprecio_TextChanged);
            // 
            // btnguardar
            // 
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.Location = new System.Drawing.Point(63, 161);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(163, 23);
            this.btnguardar.TabIndex = 4;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            // 
            // btnregresar
            // 
            this.btnregresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregresar.Location = new System.Drawing.Point(47, 190);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(198, 32);
            this.btnregresar.TabIndex = 5;
            this.btnregresar.Text = "Regresar al Menu";
            this.btnregresar.UseVisualStyleBackColor = true;
            // 
            // comboBoxNombre
            // 
            this.comboBoxNombre.FormattingEnabled = true;
            this.comboBoxNombre.Items.AddRange(new object[] {
            "Mantenimiento Preventivo",
            "Mantenimiento Correctivo"});
            this.comboBoxNombre.Location = new System.Drawing.Point(139, 89);
            this.comboBoxNombre.Name = "comboBoxNombre";
            this.comboBoxNombre.Size = new System.Drawing.Size(157, 21);
            this.comboBoxNombre.TabIndex = 6;
            // 
            // btnnuevo
            // 
            this.btnnuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevo.Location = new System.Drawing.Point(47, 228);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(86, 30);
            this.btnnuevo.TabIndex = 7;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(317, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(415, 175);
            this.dataGridView1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tipo de Soporte";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Telefono";
            // 
            // textTelf
            // 
            this.textTelf.Location = new System.Drawing.Point(112, 57);
            this.textTelf.Name = "textTelf";
            this.textTelf.Size = new System.Drawing.Size(133, 20);
            this.textTelf.TabIndex = 11;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(112, 26);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(133, 20);
            this.textNombre.TabIndex = 12;
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(148, 228);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(78, 30);
            this.btnModificar.TabIndex = 13;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // Tipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 317);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.textTelf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.comboBoxNombre);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.textprecio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Tipos";
            this.Text = "Tipos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textprecio;
        public System.Windows.Forms.Button btnguardar;
        public System.Windows.Forms.Button btnregresar;
        private System.Windows.Forms.ComboBox comboBoxNombre;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textTelf;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Button btnModificar;
    }
}