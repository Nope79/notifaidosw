namespace Proyecto_1.FrontEnd.Notify.MENU_USUARIO.Seccion_User
{
    partial class seccion_mod
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_guardar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_back = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txb_nombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txb_desc = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbl_desc = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_nombre = new MaterialSkin.Controls.MaterialLabel();
            this.txb_friltro = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbl_friltro = new MaterialSkin.Controls.MaterialLabel();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-2, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 328);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.btn_guardar);
            this.panel4.Controls.Add(this.btn_back);
            this.panel4.Location = new System.Drawing.Point(43, 227);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(492, 68);
            this.panel4.TabIndex = 3;
            // 
            // btn_guardar
            // 
            this.btn_guardar.AutoSize = true;
            this.btn_guardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_guardar.Depth = 0;
            this.btn_guardar.Icon = null;
            this.btn_guardar.Location = new System.Drawing.Point(364, 13);
            this.btn_guardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Primary = true;
            this.btn_guardar.Size = new System.Drawing.Size(100, 36);
            this.btn_guardar.TabIndex = 5;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            // 
            // btn_back
            // 
            this.btn_back.AutoSize = true;
            this.btn_back.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_back.Depth = 0;
            this.btn_back.Icon = null;
            this.btn_back.Location = new System.Drawing.Point(17, 13);
            this.btn_back.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_back.Name = "btn_back";
            this.btn_back.Primary = true;
            this.btn_back.Size = new System.Drawing.Size(107, 36);
            this.btn_back.TabIndex = 4;
            this.btn_back.Text = "Regresar";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lbl_friltro);
            this.panel2.Controls.Add(this.txb_friltro);
            this.panel2.Controls.Add(this.txb_nombre);
            this.panel2.Controls.Add(this.txb_desc);
            this.panel2.Controls.Add(this.lbl_desc);
            this.panel2.Controls.Add(this.lbl_nombre);
            this.panel2.Location = new System.Drawing.Point(28, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(523, 150);
            this.panel2.TabIndex = 1;
            // 
            // txb_nombre
            // 
            this.txb_nombre.Depth = 0;
            this.txb_nombre.Hint = "";
            this.txb_nombre.Location = new System.Drawing.Point(195, 27);
            this.txb_nombre.MaxLength = 60;
            this.txb_nombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txb_nombre.Name = "txb_nombre";
            this.txb_nombre.PasswordChar = '\0';
            this.txb_nombre.SelectedText = "";
            this.txb_nombre.SelectionLength = 0;
            this.txb_nombre.SelectionStart = 0;
            this.txb_nombre.Size = new System.Drawing.Size(299, 28);
            this.txb_nombre.TabIndex = 2;
            this.txb_nombre.TabStop = false;
            this.txb_nombre.UseSystemPasswordChar = false;
            // 
            // txb_desc
            // 
            this.txb_desc.Depth = 0;
            this.txb_desc.Hint = "";
            this.txb_desc.Location = new System.Drawing.Point(195, 61);
            this.txb_desc.MaxLength = 60;
            this.txb_desc.MouseState = MaterialSkin.MouseState.HOVER;
            this.txb_desc.Name = "txb_desc";
            this.txb_desc.PasswordChar = '\0';
            this.txb_desc.SelectedText = "";
            this.txb_desc.SelectionLength = 0;
            this.txb_desc.SelectionStart = 0;
            this.txb_desc.Size = new System.Drawing.Size(299, 28);
            this.txb_desc.TabIndex = 3;
            this.txb_desc.TabStop = false;
            this.txb_desc.UseSystemPasswordChar = false;
            // 
            // lbl_desc
            // 
            this.lbl_desc.AutoSize = true;
            this.lbl_desc.Depth = 0;
            this.lbl_desc.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_desc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_desc.Location = new System.Drawing.Point(15, 66);
            this.lbl_desc.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_desc.Name = "lbl_desc";
            this.lbl_desc.Size = new System.Drawing.Size(110, 24);
            this.lbl_desc.TabIndex = 1;
            this.lbl_desc.Text = "Descripción";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Depth = 0;
            this.lbl_nombre.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_nombre.Location = new System.Drawing.Point(15, 31);
            this.lbl_nombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(79, 24);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "Nombre";
            // 
            // txb_friltro
            // 
            this.txb_friltro.Depth = 0;
            this.txb_friltro.Hint = "";
            this.txb_friltro.Location = new System.Drawing.Point(195, 105);
            this.txb_friltro.MaxLength = 60;
            this.txb_friltro.MouseState = MaterialSkin.MouseState.HOVER;
            this.txb_friltro.Name = "txb_friltro";
            this.txb_friltro.PasswordChar = '\0';
            this.txb_friltro.SelectedText = "";
            this.txb_friltro.SelectionLength = 0;
            this.txb_friltro.SelectionStart = 0;
            this.txb_friltro.Size = new System.Drawing.Size(299, 28);
            this.txb_friltro.TabIndex = 4;
            this.txb_friltro.TabStop = false;
            this.txb_friltro.UseSystemPasswordChar = false;
            // 
            // lbl_friltro
            // 
            this.lbl_friltro.AutoSize = true;
            this.lbl_friltro.Depth = 0;
            this.lbl_friltro.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_friltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_friltro.Location = new System.Drawing.Point(15, 105);
            this.lbl_friltro.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_friltro.Name = "lbl_friltro";
            this.lbl_friltro.Size = new System.Drawing.Size(54, 24);
            this.lbl_friltro.TabIndex = 5;
            this.lbl_friltro.Text = "Filtro";
            // 
            // seccion_mod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 388);
            this.Controls.Add(this.panel1);
            this.Name = "seccion_mod";
            this.Text = "Seccion";
            this.Load += new System.EventHandler(this.seccion_mod_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private MaterialSkin.Controls.MaterialRaisedButton btn_guardar;
        private MaterialSkin.Controls.MaterialRaisedButton btn_back;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialLabel lbl_friltro;
        private MaterialSkin.Controls.MaterialSingleLineTextField txb_friltro;
        private MaterialSkin.Controls.MaterialSingleLineTextField txb_nombre;
        private MaterialSkin.Controls.MaterialSingleLineTextField txb_desc;
        private MaterialSkin.Controls.MaterialLabel lbl_desc;
        private MaterialSkin.Controls.MaterialLabel lbl_nombre;
    }
}