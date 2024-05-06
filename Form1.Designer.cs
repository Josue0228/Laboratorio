namespace Laboratorio
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textidusario = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textApellidos = new System.Windows.Forms.TextBox();
            this.textCorreoElec = new System.Windows.Forms.TextBox();
            this.textpersonalnumberr = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvpersonas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(863, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario_ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(1055, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(831, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellidos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(955, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "CorreoElec";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(1091, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Personal#";
            // 
            // textidusario
            // 
            this.textidusario.BackColor = System.Drawing.SystemColors.Info;
            this.textidusario.Location = new System.Drawing.Point(847, 104);
            this.textidusario.Name = "textidusario";
            this.textidusario.Size = new System.Drawing.Size(100, 22);
            this.textidusario.TabIndex = 5;
            // 
            // textNombre
            // 
            this.textNombre.BackColor = System.Drawing.SystemColors.Info;
            this.textNombre.Location = new System.Drawing.Point(1036, 104);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(100, 22);
            this.textNombre.TabIndex = 6;
            // 
            // textApellidos
            // 
            this.textApellidos.BackColor = System.Drawing.SystemColors.Info;
            this.textApellidos.Location = new System.Drawing.Point(811, 243);
            this.textApellidos.Name = "textApellidos";
            this.textApellidos.Size = new System.Drawing.Size(100, 22);
            this.textApellidos.TabIndex = 7;
            // 
            // textCorreoElec
            // 
            this.textCorreoElec.BackColor = System.Drawing.SystemColors.Info;
            this.textCorreoElec.Location = new System.Drawing.Point(942, 243);
            this.textCorreoElec.Name = "textCorreoElec";
            this.textCorreoElec.Size = new System.Drawing.Size(100, 22);
            this.textCorreoElec.TabIndex = 8;
            // 
            // textpersonalnumberr
            // 
            this.textpersonalnumberr.BackColor = System.Drawing.SystemColors.Info;
            this.textpersonalnumberr.Location = new System.Drawing.Point(1073, 243);
            this.textpersonalnumberr.Name = "textpersonalnumberr";
            this.textpersonalnumberr.Size = new System.Drawing.Size(100, 22);
            this.textpersonalnumberr.TabIndex = 9;
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.Chartreuse;
            this.btnguardar.Location = new System.Drawing.Point(798, 345);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(97, 47);
            this.btnguardar.TabIndex = 10;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btneditar
            // 
            this.btneditar.BackColor = System.Drawing.Color.Yellow;
            this.btneditar.Location = new System.Drawing.Point(935, 345);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(107, 47);
            this.btneditar.TabIndex = 11;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = false;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Location = new System.Drawing.Point(1073, 345);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 47);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvpersonas
            // 
            this.dgvpersonas.BackgroundColor = System.Drawing.SystemColors.WindowText;
            this.dgvpersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpersonas.Location = new System.Drawing.Point(52, 31);
            this.dgvpersonas.Name = "dgvpersonas";
            this.dgvpersonas.RowHeadersWidth = 51;
            this.dgvpersonas.RowTemplate.Height = 24;
            this.dgvpersonas.Size = new System.Drawing.Size(689, 381);
            this.dgvpersonas.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1208, 450);
            this.Controls.Add(this.dgvpersonas);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.textpersonalnumberr);
            this.Controls.Add(this.textCorreoElec);
            this.Controls.Add(this.textApellidos);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.textidusario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textidusario;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textApellidos;
        private System.Windows.Forms.TextBox textCorreoElec;
        private System.Windows.Forms.TextBox textpersonalnumberr;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvpersonas;
    }
}

