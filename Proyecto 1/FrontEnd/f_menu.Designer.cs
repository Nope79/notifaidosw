namespace Proyecto_1
{
    partial class f_menu
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
            this.btn_area = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_inventario = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lbl_presentacion = new System.Windows.Forms.Label();
            this.p_1 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.p_1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_area
            // 
            this.btn_area.AutoSize = true;
            this.btn_area.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_area.Depth = 0;
            this.btn_area.Icon = null;
            this.btn_area.Location = new System.Drawing.Point(329, 8);
            this.btn_area.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_area.Name = "btn_area";
            this.btn_area.Primary = true;
            this.btn_area.Size = new System.Drawing.Size(107, 36);
            this.btn_area.TabIndex = 4;
            this.btn_area.Text = "    ÁREA     \' ";
            this.btn_area.UseVisualStyleBackColor = true;
            this.btn_area.Click += new System.EventHandler(this.btn_area_Click_1);
            // 
            // btn_inventario
            // 
            this.btn_inventario.AutoSize = true;
            this.btn_inventario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_inventario.Depth = 0;
            this.btn_inventario.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inventario.Icon = null;
            this.btn_inventario.Location = new System.Drawing.Point(12, 8);
            this.btn_inventario.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_inventario.Name = "btn_inventario";
            this.btn_inventario.Primary = true;
            this.btn_inventario.Size = new System.Drawing.Size(121, 36);
            this.btn_inventario.TabIndex = 5;
            this.btn_inventario.Text = "INVENTARIO";
            this.btn_inventario.UseVisualStyleBackColor = true;
            this.btn_inventario.Click += new System.EventHandler(this.btn_inventario_Click_1);
            // 
            // lbl_presentacion
            // 
            this.lbl_presentacion.BackColor = System.Drawing.Color.AliceBlue;
            this.lbl_presentacion.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_presentacion.Location = new System.Drawing.Point(202, 18);
            this.lbl_presentacion.Name = "lbl_presentacion";
            this.lbl_presentacion.Size = new System.Drawing.Size(107, 40);
            this.lbl_presentacion.TabIndex = 6;
            this.lbl_presentacion.Text = "¡Que tal!";
            this.lbl_presentacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_presentacion.Click += new System.EventHandler(this.lbl_presentacion_Click_1);
            // 
            // p_1
            // 
            this.p_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p_1.Controls.Add(this.panel1);
            this.p_1.Controls.Add(this.lbl_presentacion);
            this.p_1.Location = new System.Drawing.Point(166, 81);
            this.p_1.Name = "p_1";
            this.p_1.Size = new System.Drawing.Size(510, 149);
            this.p_1.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_area);
            this.panel1.Controls.Add(this.btn_inventario);
            this.panel1.Location = new System.Drawing.Point(34, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 58);
            this.panel1.TabIndex = 7;
            // 
            // f_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 275);
            this.Controls.Add(this.p_1);
            this.Name = "f_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.p_1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btn_area;
        private MaterialSkin.Controls.MaterialRaisedButton btn_inventario;
        private System.Windows.Forms.Label lbl_presentacion;
        private System.Windows.Forms.Panel p_1;
        private System.Windows.Forms.Panel panel1;
    }
}

