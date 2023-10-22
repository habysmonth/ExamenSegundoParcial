namespace CapaPresentacion
{
    partial class Gestion_Liquidacion
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
            this.dtgLiquidaciones = new System.Windows.Forms.DataGridView();
            this.txtBuscarLiquidacion = new System.Windows.Forms.TextBox();
            this.btnBuscarLiquidacion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLiquidaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgLiquidaciones
            // 
            this.dtgLiquidaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLiquidaciones.Location = new System.Drawing.Point(44, 89);
            this.dtgLiquidaciones.Name = "dtgLiquidaciones";
            this.dtgLiquidaciones.RowHeadersWidth = 62;
            this.dtgLiquidaciones.RowTemplate.Height = 28;
            this.dtgLiquidaciones.Size = new System.Drawing.Size(1003, 429);
            this.dtgLiquidaciones.TabIndex = 0;
            // 
            // txtBuscarLiquidacion
            // 
            this.txtBuscarLiquidacion.Location = new System.Drawing.Point(44, 47);
            this.txtBuscarLiquidacion.Name = "txtBuscarLiquidacion";
            this.txtBuscarLiquidacion.Size = new System.Drawing.Size(251, 26);
            this.txtBuscarLiquidacion.TabIndex = 1;
            // 
            // btnBuscarLiquidacion
            // 
            this.btnBuscarLiquidacion.Location = new System.Drawing.Point(301, 42);
            this.btnBuscarLiquidacion.Name = "btnBuscarLiquidacion";
            this.btnBuscarLiquidacion.Size = new System.Drawing.Size(131, 36);
            this.btnBuscarLiquidacion.TabIndex = 2;
            this.btnBuscarLiquidacion.Text = "Liquidar";
            this.btnBuscarLiquidacion.UseVisualStyleBackColor = true;
            this.btnBuscarLiquidacion.Click += new System.EventHandler(this.btnBuscarLiquidacion_Click);
            // 
            // Gestion_Liquidacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 591);
            this.Controls.Add(this.btnBuscarLiquidacion);
            this.Controls.Add(this.txtBuscarLiquidacion);
            this.Controls.Add(this.dtgLiquidaciones);
            this.Name = "Gestion_Liquidacion";
            this.Text = "Gestion_Liquidacion";
            ((System.ComponentModel.ISupportInitialize)(this.dtgLiquidaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgLiquidaciones;
        private System.Windows.Forms.TextBox txtBuscarLiquidacion;
        private System.Windows.Forms.Button btnBuscarLiquidacion;
    }
}