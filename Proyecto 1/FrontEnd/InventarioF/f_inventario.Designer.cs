using System.Windows.Forms;

namespace Proyecto_1.FrontEnd
{
    partial class f_inventario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.dgv_inventario = new System.Windows.Forms.DataGridView();
            this.btn_crear = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_eliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_actualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inventario)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_regresar
            // 
            this.btn_regresar.Location = new System.Drawing.Point(12, 447);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(108, 27);
            this.btn_regresar.TabIndex = 20;
            this.btn_regresar.Text = "REGRESAR";
            this.btn_regresar.UseVisualStyleBackColor = true;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // dgv_inventario
            // 
            this.dgv_inventario.AllowUserToAddRows = false;
            this.dgv_inventario.AllowUserToDeleteRows = false;
            this.dgv_inventario.AllowUserToResizeColumns = false;
            this.dgv_inventario.AllowUserToResizeRows = false;
            this.dgv_inventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_inventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_inventario.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_inventario.Location = new System.Drawing.Point(12, 98);
            this.dgv_inventario.Name = "dgv_inventario";
            this.dgv_inventario.ReadOnly = true;
            this.dgv_inventario.RowHeadersVisible = false;
            this.dgv_inventario.RowHeadersWidth = 51;
            this.dgv_inventario.RowTemplate.Height = 24;
            this.dgv_inventario.Size = new System.Drawing.Size(1536, 293);
            this.dgv_inventario.TabIndex = 10;
            this.dgv_inventario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_inventario_CellClick);
            // 
            // btn_crear
            // 
            this.btn_crear.AutoSize = true;
            this.btn_crear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_crear.Depth = 0;
            this.btn_crear.Icon = null;
            this.btn_crear.Location = new System.Drawing.Point(42, 12);
            this.btn_crear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_crear.Name = "btn_crear";
            this.btn_crear.Primary = true;
            this.btn_crear.Size = new System.Drawing.Size(76, 36);
            this.btn_crear.TabIndex = 11;
            this.btn_crear.Text = "CREAR";
            this.btn_crear.UseVisualStyleBackColor = true;
            this.btn_crear.Click += new System.EventHandler(this.btn_crear_Click_1);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.AutoSize = true;
            this.btn_eliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_eliminar.Depth = 0;
            this.btn_eliminar.Enabled = false;
            this.btn_eliminar.Icon = null;
            this.btn_eliminar.Location = new System.Drawing.Point(386, 12);
            this.btn_eliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Primary = true;
            this.btn_eliminar.Size = new System.Drawing.Size(100, 36);
            this.btn_eliminar.TabIndex = 13;
            this.btn_eliminar.Text = "ELIMINAR";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click_1);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.AutoSize = true;
            this.btn_actualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_actualizar.Depth = 0;
            this.btn_actualizar.Enabled = false;
            this.btn_actualizar.Icon = null;
            this.btn_actualizar.Location = new System.Drawing.Point(195, 12);
            this.btn_actualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Primary = true;
            this.btn_actualizar.Size = new System.Drawing.Size(124, 36);
            this.btn_actualizar.TabIndex = 14;
            this.btn_actualizar.Text = "ACTUALIZAR";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click_1);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(2, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1554, 314);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btn_eliminar);
            this.panel2.Controls.Add(this.btn_actualizar);
            this.panel2.Controls.Add(this.btn_crear);
            this.panel2.Location = new System.Drawing.Point(516, 411);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(528, 63);
            this.panel2.TabIndex = 16;
            // 
            // f_inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1560, 486);
            this.Controls.Add(this.dgv_inventario);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "f_inventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.f_inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inventario)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.DataGridView dgv_inventario;
        private MaterialSkin.Controls.MaterialRaisedButton btn_crear;
        private MaterialSkin.Controls.MaterialRaisedButton btn_eliminar;
        private MaterialSkin.Controls.MaterialRaisedButton btn_actualizar;
        private Panel panel1;
        private Panel panel2;
    }
}