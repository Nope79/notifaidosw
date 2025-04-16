using System.Drawing;

namespace Proyecto_1.FrontEnd.Notify.MainMenu
{
    partial class Menu_Admin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.main_panel = new System.Windows.Forms.Panel();
            this.menu_lbl = new MaterialSkin.Controls.MaterialLabel();
            this.btn_panel = new System.Windows.Forms.Panel();
            this.btn_delete = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_update = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_add = new MaterialSkin.Controls.MaterialRaisedButton();
            this.grid_panel = new System.Windows.Forms.Panel();
            this.dgv_main = new System.Windows.Forms.DataGridView();
            this.menu_panel = new System.Windows.Forms.Panel();
            this.btn_notificacion = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_usuarios = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_grupos = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_back = new MaterialSkin.Controls.MaterialRaisedButton();
            this.main_panel.SuspendLayout();
            this.btn_panel.SuspendLayout();
            this.grid_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).BeginInit();
            this.menu_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_panel
            // 
            this.main_panel.BackColor = System.Drawing.Color.PowderBlue;
            this.main_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.main_panel.Controls.Add(this.menu_lbl);
            this.main_panel.Controls.Add(this.btn_panel);
            this.main_panel.Controls.Add(this.grid_panel);
            this.main_panel.Controls.Add(this.menu_panel);
            this.main_panel.Location = new System.Drawing.Point(0, 66);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(1218, 416);
            this.main_panel.TabIndex = 0;
            // 
            // menu_lbl
            // 
            this.menu_lbl.AutoSize = true;
            this.menu_lbl.Depth = 0;
            this.menu_lbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.menu_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menu_lbl.Location = new System.Drawing.Point(298, 25);
            this.menu_lbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.menu_lbl.Name = "menu_lbl";
            this.menu_lbl.Size = new System.Drawing.Size(25, 24);
            this.menu_lbl.TabIndex = 1;
            this.menu_lbl.Text = "---";
            // 
            // btn_panel
            // 
            this.btn_panel.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btn_panel.Controls.Add(this.btn_delete);
            this.btn_panel.Controls.Add(this.btn_update);
            this.btn_panel.Controls.Add(this.btn_add);
            this.btn_panel.Location = new System.Drawing.Point(302, 316);
            this.btn_panel.Name = "btn_panel";
            this.btn_panel.Size = new System.Drawing.Size(818, 86);
            this.btn_panel.TabIndex = 2;
            // 
            // btn_delete
            // 
            this.btn_delete.AutoSize = true;
            this.btn_delete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_delete.Depth = 0;
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_delete.Icon = null;
            this.btn_delete.Location = new System.Drawing.Point(680, 26);
            this.btn_delete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Primary = true;
            this.btn_delete.Size = new System.Drawing.Size(100, 36);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Eliminar";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.AutoSize = true;
            this.btn_update.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_update.Depth = 0;
            this.btn_update.Icon = null;
            this.btn_update.Location = new System.Drawing.Point(345, 26);
            this.btn_update.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_update.Name = "btn_update";
            this.btn_update.Primary = true;
            this.btn_update.Size = new System.Drawing.Size(124, 36);
            this.btn_update.TabIndex = 1;
            this.btn_update.Text = "Actualizar";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_add
            // 
            this.btn_add.AutoSize = true;
            this.btn_add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_add.Depth = 0;
            this.btn_add.Icon = null;
            this.btn_add.Location = new System.Drawing.Point(40, 26);
            this.btn_add.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_add.Name = "btn_add";
            this.btn_add.Primary = true;
            this.btn_add.Size = new System.Drawing.Size(84, 36);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Añadir";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // grid_panel
            // 
            this.grid_panel.BackColor = System.Drawing.Color.LightSlateGray;
            this.grid_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grid_panel.Controls.Add(this.dgv_main);
            this.grid_panel.Location = new System.Drawing.Point(302, 71);
            this.grid_panel.Name = "grid_panel";
            this.grid_panel.Size = new System.Drawing.Size(818, 198);
            this.grid_panel.TabIndex = 1;
            // 
            // dgv_main
            // 
            this.dgv_main.AllowUserToAddRows = false;
            this.dgv_main.AllowUserToDeleteRows = false;
            this.dgv_main.AllowUserToResizeColumns = false;
            this.dgv_main.AllowUserToResizeRows = false;
            this.dgv_main.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_main.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgv_main.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dgv_main.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_main.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_main.Location = new System.Drawing.Point(40, 38);
            this.dgv_main.Name = "dgv_main";
            this.dgv_main.ReadOnly = true;
            this.dgv_main.RowHeadersVisible = false;
            this.dgv_main.RowHeadersWidth = 51;
            this.dgv_main.RowTemplate.Height = 24;
            this.dgv_main.Size = new System.Drawing.Size(740, 142);
            this.dgv_main.TabIndex = 6;
            this.dgv_main.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_main_CellClick);
            // 
            // menu_panel
            // 
            this.menu_panel.BackColor = System.Drawing.Color.LightSlateGray;
            this.menu_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.menu_panel.Controls.Add(this.btn_notificacion);
            this.menu_panel.Controls.Add(this.btn_usuarios);
            this.menu_panel.Controls.Add(this.btn_grupos);
            this.menu_panel.Controls.Add(this.btn_back);
            this.menu_panel.Location = new System.Drawing.Point(0, -2);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Size = new System.Drawing.Size(208, 417);
            this.menu_panel.TabIndex = 0;
            // 
            // btn_notificacion
            // 
            this.btn_notificacion.Depth = 0;
            this.btn_notificacion.Icon = null;
            this.btn_notificacion.Location = new System.Drawing.Point(3, 25);
            this.btn_notificacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_notificacion.Name = "btn_notificacion";
            this.btn_notificacion.Primary = true;
            this.btn_notificacion.Size = new System.Drawing.Size(198, 36);
            this.btn_notificacion.TabIndex = 3;
            this.btn_notificacion.Text = "Notificaciones";
            this.btn_notificacion.UseVisualStyleBackColor = true;
            this.btn_notificacion.Click += new System.EventHandler(this.btn_notificacion_Click);
            // 
            // btn_usuarios
            // 
            this.btn_usuarios.AutoSize = true;
            this.btn_usuarios.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_usuarios.Depth = 0;
            this.btn_usuarios.Icon = null;
            this.btn_usuarios.Location = new System.Drawing.Point(3, 128);
            this.btn_usuarios.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_usuarios.Name = "btn_usuarios";
            this.btn_usuarios.Primary = true;
            this.btn_usuarios.Size = new System.Drawing.Size(104, 36);
            this.btn_usuarios.TabIndex = 2;
            this.btn_usuarios.Text = "Usuarios";
            this.btn_usuarios.UseVisualStyleBackColor = true;
            this.btn_usuarios.Click += new System.EventHandler(this.btn_usuarios_Click);
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
            this.btn_grupos.Click += new System.EventHandler(this.btn_grupos_Click);
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
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Menu_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 476);
            this.Controls.Add(this.main_panel);
            this.Name = "Menu_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú";
            this.Load += new System.EventHandler(this.menu_Load);
            this.main_panel.ResumeLayout(false);
            this.main_panel.PerformLayout();
            this.btn_panel.ResumeLayout(false);
            this.btn_panel.PerformLayout();
            this.grid_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).EndInit();
            this.menu_panel.ResumeLayout(false);
            this.menu_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Panel btn_panel;
        private System.Windows.Forms.Panel grid_panel;
        private System.Windows.Forms.Panel menu_panel;
        private MaterialSkin.Controls.MaterialLabel menu_lbl;
        private MaterialSkin.Controls.MaterialRaisedButton btn_update;
        private MaterialSkin.Controls.MaterialRaisedButton btn_add;
        private MaterialSkin.Controls.MaterialRaisedButton btn_delete;
        private MaterialSkin.Controls.MaterialRaisedButton btn_notificacion;
        private MaterialSkin.Controls.MaterialRaisedButton btn_usuarios;
        private MaterialSkin.Controls.MaterialRaisedButton btn_grupos;
        private MaterialSkin.Controls.MaterialRaisedButton btn_back;
        private System.Windows.Forms.DataGridView dgv_main;
    }
}