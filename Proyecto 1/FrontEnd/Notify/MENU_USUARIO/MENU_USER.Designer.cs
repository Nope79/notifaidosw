namespace Proyecto_1.FrontEnd.Notify.MENU_USUARIO
{
    partial class MENU_USER
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.main_panel = new System.Windows.Forms.Panel();
            this.lbl_bienvenue = new MaterialSkin.Controls.MaterialLabel();
            this.grid_panel = new System.Windows.Forms.Panel();
            this.dgv_not_impor = new System.Windows.Forms.DataGridView();
            this.menu_panel = new System.Windows.Forms.Panel();
            this.btn_notificacion = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_secciones = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_grupos = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_back = new MaterialSkin.Controls.MaterialRaisedButton();
            this.main_panel.SuspendLayout();
            this.grid_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_not_impor)).BeginInit();
            this.menu_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_panel
            // 
            this.main_panel.BackColor = System.Drawing.Color.PowderBlue;
            this.main_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.main_panel.Controls.Add(this.lbl_bienvenue);
            this.main_panel.Controls.Add(this.grid_panel);
            this.main_panel.Controls.Add(this.menu_panel);
            this.main_panel.Location = new System.Drawing.Point(0, 64);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(1232, 418);
            this.main_panel.TabIndex = 1;
            // 
            // lbl_bienvenue
            // 
            this.lbl_bienvenue.AutoSize = true;
            this.lbl_bienvenue.Depth = 0;
            this.lbl_bienvenue.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_bienvenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_bienvenue.Location = new System.Drawing.Point(249, 25);
            this.lbl_bienvenue.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_bienvenue.Name = "lbl_bienvenue";
            this.lbl_bienvenue.Size = new System.Drawing.Size(25, 24);
            this.lbl_bienvenue.TabIndex = 1;
            this.lbl_bienvenue.Text = "---";
            // 
            // grid_panel
            // 
            this.grid_panel.BackColor = System.Drawing.Color.LightSlateGray;
            this.grid_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grid_panel.Controls.Add(this.dgv_not_impor);
            this.grid_panel.Location = new System.Drawing.Point(253, 71);
            this.grid_panel.Name = "grid_panel";
            this.grid_panel.Size = new System.Drawing.Size(935, 330);
            this.grid_panel.TabIndex = 1;
            // 
            // dgv_not_impor
            // 
            this.dgv_not_impor.AllowUserToAddRows = false;
            this.dgv_not_impor.AllowUserToDeleteRows = false;
            this.dgv_not_impor.AllowUserToResizeColumns = false;
            this.dgv_not_impor.AllowUserToResizeRows = false;
            this.dgv_not_impor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_not_impor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgv_not_impor.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dgv_not_impor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_not_impor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_not_impor.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_not_impor.Location = new System.Drawing.Point(40, 38);
            this.dgv_not_impor.Name = "dgv_not_impor";
            this.dgv_not_impor.ReadOnly = true;
            this.dgv_not_impor.RowHeadersVisible = false;
            this.dgv_not_impor.RowHeadersWidth = 51;
            this.dgv_not_impor.RowTemplate.Height = 24;
            this.dgv_not_impor.Size = new System.Drawing.Size(857, 269);
            this.dgv_not_impor.TabIndex = 6;
            // 
            // menu_panel
            // 
            this.menu_panel.BackColor = System.Drawing.Color.LightSlateGray;
            this.menu_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.menu_panel.Controls.Add(this.btn_notificacion);
            this.menu_panel.Controls.Add(this.btn_secciones);
            this.menu_panel.Controls.Add(this.btn_grupos);
            this.menu_panel.Controls.Add(this.btn_back);
            this.menu_panel.Location = new System.Drawing.Point(0, -2);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Size = new System.Drawing.Size(208, 417);
            this.menu_panel.TabIndex = 0;
            // 
            // btn_notificacion
            // 
            this.btn_notificacion.AutoSize = true;
            this.btn_notificacion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_notificacion.Depth = 0;
            this.btn_notificacion.Icon = null;
            this.btn_notificacion.Location = new System.Drawing.Point(3, 25);
            this.btn_notificacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_notificacion.Name = "btn_notificacion";
            this.btn_notificacion.Primary = true;
            this.btn_notificacion.Size = new System.Drawing.Size(158, 36);
            this.btn_notificacion.TabIndex = 3;
            this.btn_notificacion.Text = "Notificaciones";
            this.btn_notificacion.UseVisualStyleBackColor = true;
            this.btn_notificacion.Click += new System.EventHandler(this.btn_notificacion_Click);
            // 
            // btn_secciones
            // 
            this.btn_secciones.AutoSize = true;
            this.btn_secciones.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_secciones.Depth = 0;
            this.btn_secciones.Icon = null;
            this.btn_secciones.Location = new System.Drawing.Point(3, 128);
            this.btn_secciones.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_secciones.Name = "btn_secciones";
            this.btn_secciones.Primary = true;
            this.btn_secciones.Size = new System.Drawing.Size(113, 36);
            this.btn_secciones.TabIndex = 2;
            this.btn_secciones.Text = "Secciones";
            this.btn_secciones.UseVisualStyleBackColor = true;
            this.btn_secciones.Click += new System.EventHandler(this.btn_secciones_Click);
            // 
            // btn_grupos
            // 
            this.btn_grupos.AutoSize = true;
            this.btn_grupos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_grupos.Depth = 0;
            this.btn_grupos.Icon = null;
            this.btn_grupos.Location = new System.Drawing.Point(3, 219);
            this.btn_grupos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_grupos.Name = "btn_grupos";
            this.btn_grupos.Primary = true;
            this.btn_grupos.Size = new System.Drawing.Size(89, 36);
            this.btn_grupos.TabIndex = 1;
            this.btn_grupos.Text = "Grupos";
            this.btn_grupos.UseVisualStyleBackColor = true;
            // 
            // btn_back
            // 
            this.btn_back.AutoSize = true;
            this.btn_back.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_back.Depth = 0;
            this.btn_back.Icon = null;
            this.btn_back.Location = new System.Drawing.Point(3, 344);
            this.btn_back.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_back.Name = "btn_back";
            this.btn_back.Primary = true;
            this.btn_back.Size = new System.Drawing.Size(107, 36);
            this.btn_back.TabIndex = 0;
            this.btn_back.Text = "Regresar";
            this.btn_back.UseVisualStyleBackColor = true;
            // 
            // MENU_USER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 481);
            this.Controls.Add(this.main_panel);
            this.Name = "MENU_USER";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.Load += new System.EventHandler(this.MENU_USER_Load);
            this.main_panel.ResumeLayout(false);
            this.main_panel.PerformLayout();
            this.grid_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_not_impor)).EndInit();
            this.menu_panel.ResumeLayout(false);
            this.menu_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel main_panel;
        private MaterialSkin.Controls.MaterialLabel lbl_bienvenue;
        private System.Windows.Forms.Panel grid_panel;
        private System.Windows.Forms.DataGridView dgv_not_impor;
        private System.Windows.Forms.Panel menu_panel;
        private MaterialSkin.Controls.MaterialRaisedButton btn_notificacion;
        private MaterialSkin.Controls.MaterialRaisedButton btn_secciones;
        private MaterialSkin.Controls.MaterialRaisedButton btn_grupos;
        private MaterialSkin.Controls.MaterialRaisedButton btn_back;
    }
}