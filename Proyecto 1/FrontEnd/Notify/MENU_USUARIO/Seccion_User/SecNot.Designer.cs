namespace Proyecto_1.FrontEnd.Notify.MENU_USUARIO.Seccion_User
{
    partial class SecNot
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.main_panel = new System.Windows.Forms.Panel();
            this.menu_lbl = new MaterialSkin.Controls.MaterialLabel();
            this.btn_panel = new System.Windows.Forms.Panel();
            this.btn_delete = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_update = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_add = new MaterialSkin.Controls.MaterialRaisedButton();
            this.grid_panel = new System.Windows.Forms.Panel();
            this.dgv_sec = new System.Windows.Forms.DataGridView();
            this.menu_panel = new System.Windows.Forms.Panel();
            this.btn_back = new MaterialSkin.Controls.MaterialRaisedButton();
            this.main_panel.SuspendLayout();
            this.btn_panel.SuspendLayout();
            this.grid_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sec)).BeginInit();
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
            this.main_panel.Location = new System.Drawing.Point(0, 64);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(977, 438);
            this.main_panel.TabIndex = 1;
            // 
            // menu_lbl
            // 
            this.menu_lbl.AutoSize = true;
            this.menu_lbl.Depth = 0;
            this.menu_lbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.menu_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menu_lbl.Location = new System.Drawing.Point(193, 30);
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
            this.btn_panel.Location = new System.Drawing.Point(186, 315);
            this.btn_panel.Name = "btn_panel";
            this.btn_panel.Size = new System.Drawing.Size(725, 86);
            this.btn_panel.TabIndex = 2;
            // 
            // btn_delete
            // 
            this.btn_delete.AutoSize = true;
            this.btn_delete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_delete.Depth = 0;
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_delete.Icon = null;
            this.btn_delete.Location = new System.Drawing.Point(590, 27);
            this.btn_delete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Primary = true;
            this.btn_delete.Size = new System.Drawing.Size(100, 36);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Eliminar";
            this.btn_delete.UseVisualStyleBackColor = true;
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
            // 
            // grid_panel
            // 
            this.grid_panel.BackColor = System.Drawing.Color.LightSlateGray;
            this.grid_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grid_panel.Controls.Add(this.dgv_sec);
            this.grid_panel.Location = new System.Drawing.Point(197, 71);
            this.grid_panel.Name = "grid_panel";
            this.grid_panel.Size = new System.Drawing.Size(704, 198);
            this.grid_panel.TabIndex = 1;
            // 
            // dgv_sec
            // 
            this.dgv_sec.AllowUserToAddRows = false;
            this.dgv_sec.AllowUserToDeleteRows = false;
            this.dgv_sec.AllowUserToResizeColumns = false;
            this.dgv_sec.AllowUserToResizeRows = false;
            this.dgv_sec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_sec.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgv_sec.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dgv_sec.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_sec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_sec.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_sec.Location = new System.Drawing.Point(40, 23);
            this.dgv_sec.Name = "dgv_sec";
            this.dgv_sec.ReadOnly = true;
            this.dgv_sec.RowHeadersVisible = false;
            this.dgv_sec.RowHeadersWidth = 51;
            this.dgv_sec.RowTemplate.Height = 24;
            this.dgv_sec.Size = new System.Drawing.Size(614, 142);
            this.dgv_sec.TabIndex = 6;
            // 
            // menu_panel
            // 
            this.menu_panel.BackColor = System.Drawing.Color.LightSlateGray;
            this.menu_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.menu_panel.Controls.Add(this.btn_back);
            this.menu_panel.Location = new System.Drawing.Point(0, -2);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Size = new System.Drawing.Size(129, 417);
            this.menu_panel.TabIndex = 0;
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
            // SecNot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 479);
            this.Controls.Add(this.main_panel);
            this.Name = "SecNot";
            this.Text = "Sección";
            this.Load += new System.EventHandler(this.SecNot_Load);
            this.main_panel.ResumeLayout(false);
            this.main_panel.PerformLayout();
            this.btn_panel.ResumeLayout(false);
            this.btn_panel.PerformLayout();
            this.grid_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sec)).EndInit();
            this.menu_panel.ResumeLayout(false);
            this.menu_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel main_panel;
        private MaterialSkin.Controls.MaterialLabel menu_lbl;
        private System.Windows.Forms.Panel btn_panel;
        private MaterialSkin.Controls.MaterialRaisedButton btn_delete;
        private MaterialSkin.Controls.MaterialRaisedButton btn_update;
        private MaterialSkin.Controls.MaterialRaisedButton btn_add;
        private System.Windows.Forms.Panel grid_panel;
        private System.Windows.Forms.DataGridView dgv_sec;
        private System.Windows.Forms.Panel menu_panel;
        private MaterialSkin.Controls.MaterialRaisedButton btn_back;
    }
}