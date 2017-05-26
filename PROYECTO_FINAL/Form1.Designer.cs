namespace PROYECTO_FINAL
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
            this.dataGridViewMostrar1 = new System.Windows.Forms.DataGridView();
            this.buttonComunidad = new System.Windows.Forms.Button();
            this.buttonGarage = new System.Windows.Forms.Button();
            this.buttonGastos = new System.Windows.Forms.Button();
            this.buttonLocal = new System.Windows.Forms.Button();
            this.buttonPiso = new System.Windows.Forms.Button();
            this.buttonPropiedad = new System.Windows.Forms.Button();
            this.buttonPropietario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMostrar1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Bancos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewMostrar1
            // 
            this.dataGridViewMostrar1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMostrar1.Location = new System.Drawing.Point(91, 57);
            this.dataGridViewMostrar1.Name = "dataGridViewMostrar1";
            this.dataGridViewMostrar1.Size = new System.Drawing.Size(328, 223);
            this.dataGridViewMostrar1.TabIndex = 1;
            // 
            // buttonComunidad
            // 
            this.buttonComunidad.Location = new System.Drawing.Point(12, 83);
            this.buttonComunidad.Name = "buttonComunidad";
            this.buttonComunidad.Size = new System.Drawing.Size(73, 23);
            this.buttonComunidad.TabIndex = 2;
            this.buttonComunidad.Text = "Comunidad";
            this.buttonComunidad.UseVisualStyleBackColor = true;
            this.buttonComunidad.Click += new System.EventHandler(this.buttonComunidad_Click);
            // 
            // buttonGarage
            // 
            this.buttonGarage.Location = new System.Drawing.Point(12, 112);
            this.buttonGarage.Name = "buttonGarage";
            this.buttonGarage.Size = new System.Drawing.Size(73, 23);
            this.buttonGarage.TabIndex = 3;
            this.buttonGarage.Text = "Garage";
            this.buttonGarage.UseVisualStyleBackColor = true;
            this.buttonGarage.Click += new System.EventHandler(this.buttonGarage_Click);
            // 
            // buttonGastos
            // 
            this.buttonGastos.Location = new System.Drawing.Point(12, 141);
            this.buttonGastos.Name = "buttonGastos";
            this.buttonGastos.Size = new System.Drawing.Size(73, 23);
            this.buttonGastos.TabIndex = 4;
            this.buttonGastos.Text = "Gastos";
            this.buttonGastos.UseVisualStyleBackColor = true;
            this.buttonGastos.Click += new System.EventHandler(this.buttonGastos_Click);
            // 
            // buttonLocal
            // 
            this.buttonLocal.Location = new System.Drawing.Point(12, 170);
            this.buttonLocal.Name = "buttonLocal";
            this.buttonLocal.Size = new System.Drawing.Size(73, 23);
            this.buttonLocal.TabIndex = 5;
            this.buttonLocal.Text = "Local";
            this.buttonLocal.UseVisualStyleBackColor = true;
            this.buttonLocal.Click += new System.EventHandler(this.buttonLocal_Click);
            // 
            // buttonPiso
            // 
            this.buttonPiso.Location = new System.Drawing.Point(12, 199);
            this.buttonPiso.Name = "buttonPiso";
            this.buttonPiso.Size = new System.Drawing.Size(73, 23);
            this.buttonPiso.TabIndex = 6;
            this.buttonPiso.Text = "Pisos";
            this.buttonPiso.UseVisualStyleBackColor = true;
            this.buttonPiso.Click += new System.EventHandler(this.buttonPiso_Click);
            // 
            // buttonPropiedad
            // 
            this.buttonPropiedad.Location = new System.Drawing.Point(12, 228);
            this.buttonPropiedad.Name = "buttonPropiedad";
            this.buttonPropiedad.Size = new System.Drawing.Size(73, 23);
            this.buttonPropiedad.TabIndex = 7;
            this.buttonPropiedad.Text = "Propiedades";
            this.buttonPropiedad.UseVisualStyleBackColor = true;
            this.buttonPropiedad.Click += new System.EventHandler(this.buttonPropiedad_Click);
            // 
            // buttonPropietario
            // 
            this.buttonPropietario.Location = new System.Drawing.Point(12, 257);
            this.buttonPropietario.Name = "buttonPropietario";
            this.buttonPropietario.Size = new System.Drawing.Size(73, 23);
            this.buttonPropietario.TabIndex = 8;
            this.buttonPropietario.Text = "Propietario";
            this.buttonPropietario.UseVisualStyleBackColor = true;
            this.buttonPropietario.Click += new System.EventHandler(this.buttonPropietario_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 334);
            this.Controls.Add(this.buttonPropietario);
            this.Controls.Add(this.buttonPropiedad);
            this.Controls.Add(this.buttonPiso);
            this.Controls.Add(this.buttonLocal);
            this.Controls.Add(this.buttonGastos);
            this.Controls.Add(this.buttonGarage);
            this.Controls.Add(this.buttonComunidad);
            this.Controls.Add(this.dataGridViewMostrar1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMostrar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewMostrar1;
        private System.Windows.Forms.Button buttonComunidad;
        private System.Windows.Forms.Button buttonGarage;
        private System.Windows.Forms.Button buttonGastos;
        private System.Windows.Forms.Button buttonLocal;
        private System.Windows.Forms.Button buttonPiso;
        private System.Windows.Forms.Button buttonPropiedad;
        private System.Windows.Forms.Button buttonPropietario;
    }
}

