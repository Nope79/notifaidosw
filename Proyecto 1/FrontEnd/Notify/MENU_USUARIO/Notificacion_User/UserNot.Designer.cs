namespace Proyecto_1.FrontEnd.Notify.MENU_USUARIO.Notificacion_User
{
    partial class UserNot
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.main_panel = new System.Windows.Forms.Panel();
            this.lbl_bienvenue = new MaterialSkin.Controls.MaterialLabel();
            this.grid_panel = new System.Windows.Forms.Panel();
            this.dgv_not_impor = new System.Windows.Forms.DataGridView();
            this.menu_panel = new System.Windows.Forms.Panel();
            this.btn_general = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_activas = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_ocultas = new MaterialSkin.Controls.MaterialRaisedButton();
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
            this.main_panel.Location = new System.Drawing.Point(0, 65);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(1248, 416);
            this.main_panel.TabIndex = 2;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_not_impor.DefaultCellStyle = dataGridViewCellStyle4;
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
            this.menu_panel.Controls.Add(this.btn_general);
            this.menu_panel.Controls.Add(this.btn_activas);
            this.menu_panel.Controls.Add(this.btn_ocultas);
            this.menu_panel.Controls.Add(this.btn_back);
            this.menu_panel.Location = new System.Drawing.Point(0, -2);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Size = new System.Drawing.Size(208, 417);
            this.menu_panel.TabIndex = 0;
            // 
            // btn_general
            // 
            this.btn_general.AutoSize = true;
            this.btn_general.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_general.Depth = 0;
            this.btn_general.Icon = null;
            this.btn_general.Location = new System.Drawing.Point(3, 25);
            this.btn_general.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_general.Name = "btn_general";
            this.btn_general.Primary = true;
            this.btn_general.Size = new System.Drawing.Size(97, 36);
            this.btn_general.TabIndex = 3;
            this.btn_general.Text = "General";
            this.btn_general.UseVisualStyleBackColor = true;
            this.btn_general.Click += new System.EventHandler(this.btn_notificacion_Click);
            // 
            // btn_activas
            // 
            this.btn_activas.AutoSize = true;
            this.btn_activas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_activas.Depth = 0;
            this.btn_activas.Icon = null;
            this.btn_activas.Location = new System.Drawing.Point(3, 128);
            this.btn_activas.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_activas.Name = "btn_activas";
            this.btn_activas.Primary = true;
            this.btn_activas.Size = new System.Drawing.Size(93, 36);
            this.btn_activas.TabIndex = 2;
            this.btn_activas.Text = "Activas";
            this.btn_activas.UseVisualStyleBackColor = true;
            this.btn_activas.Click += new System.EventHandler(this.btn_activas_Click);
            // 
            // btn_ocultas
            // 
            this.btn_ocultas.AutoSize = true;
            this.btn_ocultas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_ocultas.Depth = 0;
            this.btn_ocultas.Icon = null;
            this.btn_ocultas.Location = new System.Drawing.Point(3, 219);
            this.btn_ocultas.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_ocultas.Name = "btn_ocultas";
            this.btn_ocultas.Primary = true;
            this.btn_ocultas.Size = new System.Drawing.Size(98, 36);
            this.btn_ocultas.TabIndex = 1;
            this.btn_ocultas.Text = "Ocultas";
            this.btn_ocultas.UseVisualStyleBackColor = true;
            this.btn_ocultas.Click += new System.EventHandler(this.btn_ocultas_Click);
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
            // UserNot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 480);
            this.Controls.Add(this.main_panel);
            this.Name = "UserNot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.UserNot_Load);
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
        private MaterialSkin.Controls.MaterialRaisedButton btn_general;
        private MaterialSkin.Controls.MaterialRaisedButton btn_activas;
        private MaterialSkin.Controls.MaterialRaisedButton btn_ocultas;
        private MaterialSkin.Controls.MaterialRaisedButton btn_back;
    }
}