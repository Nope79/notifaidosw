namespace Proyecto_1.FrontEnd.Notify.USUARIOS
{
    partial class usuarios_view
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_guardar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_back = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_nombre1 = new MaterialSkin.Controls.MaterialLabel();
            this.txb_correo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txb_pass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txb_nombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txb_usuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbl_usuario = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_pass = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_correo = new MaterialSkin.Controls.MaterialLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(-2, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 374);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btn_guardar);
            this.panel2.Controls.Add(this.btn_back);
            this.panel2.Location = new System.Drawing.Point(48, 269);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(504, 68);
            this.panel2.TabIndex = 1;
            // 
            // btn_guardar
            // 
            this.btn_guardar.AutoSize = true;
            this.btn_guardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_guardar.Depth = 0;
            this.btn_guardar.Icon = null;
            this.btn_guardar.Location = new System.Drawing.Point(376, 13);
            this.btn_guardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Primary = true;
            this.btn_guardar.Size = new System.Drawing.Size(100, 36);
            this.btn_guardar.TabIndex = 17;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
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
            this.btn_back.TabIndex = 16;
            this.btn_back.Text = "Regresar";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lbl_nombre1);
            this.panel3.Controls.Add(this.txb_correo);
            this.panel3.Controls.Add(this.txb_pass);
            this.panel3.Controls.Add(this.txb_nombre);
            this.panel3.Controls.Add(this.txb_usuario);
            this.panel3.Controls.Add(this.lbl_usuario);
            this.panel3.Controls.Add(this.lbl_pass);
            this.panel3.Controls.Add(this.lbl_correo);
            this.panel3.Location = new System.Drawing.Point(32, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(537, 206);
            this.panel3.TabIndex = 2;
            // 
            // lbl_nombre1
            // 
            this.lbl_nombre1.AutoSize = true;
            this.lbl_nombre1.Depth = 0;
            this.lbl_nombre1.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_nombre1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_nombre1.Location = new System.Drawing.Point(17, 39);
            this.lbl_nombre1.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_nombre1.Name = "lbl_nombre1";
            this.lbl_nombre1.Size = new System.Drawing.Size(79, 24);
            this.lbl_nombre1.TabIndex = 16;
            this.lbl_nombre1.Text = "Nombre";
            // 
            // txb_correo
            // 
            this.txb_correo.Depth = 0;
            this.txb_correo.Hint = "";
            this.txb_correo.Location = new System.Drawing.Point(163, 155);
            this.txb_correo.MaxLength = 60;
            this.txb_correo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txb_correo.Name = "txb_correo";
            this.txb_correo.PasswordChar = '\0';
            this.txb_correo.SelectedText = "";
            this.txb_correo.SelectionLength = 0;
            this.txb_correo.SelectionStart = 0;
            this.txb_correo.Size = new System.Drawing.Size(357, 28);
            this.txb_correo.TabIndex = 15;
            this.txb_correo.TabStop = false;
            this.txb_correo.UseSystemPasswordChar = false;
            // 
            // txb_pass
            // 
            this.txb_pass.Depth = 0;
            this.txb_pass.Hint = "";
            this.txb_pass.Location = new System.Drawing.Point(163, 112);
            this.txb_pass.MaxLength = 60;
            this.txb_pass.MouseState = MaterialSkin.MouseState.HOVER;
            this.txb_pass.Name = "txb_pass";
            this.txb_pass.PasswordChar = '*';
            this.txb_pass.SelectedText = "";
            this.txb_pass.SelectionLength = 0;
            this.txb_pass.SelectionStart = 0;
            this.txb_pass.Size = new System.Drawing.Size(357, 28);
            this.txb_pass.TabIndex = 14;
            this.txb_pass.TabStop = false;
            this.txb_pass.UseSystemPasswordChar = false;
            // 
            // txb_nombre
            // 
            this.txb_nombre.BackColor = System.Drawing.Color.LightSlateGray;
            this.txb_nombre.Depth = 0;
            this.txb_nombre.Hint = "";
            this.txb_nombre.Location = new System.Drawing.Point(163, 35);
            this.txb_nombre.MaxLength = 60;
            this.txb_nombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txb_nombre.Name = "txb_nombre";
            this.txb_nombre.PasswordChar = '\0';
            this.txb_nombre.SelectedText = "";
            this.txb_nombre.SelectionLength = 0;
            this.txb_nombre.SelectionStart = 0;
            this.txb_nombre.Size = new System.Drawing.Size(357, 28);
            this.txb_nombre.TabIndex = 12;
            this.txb_nombre.TabStop = false;
            this.txb_nombre.UseSystemPasswordChar = false;
            // 
            // txb_usuario
            // 
            this.txb_usuario.Depth = 0;
            this.txb_usuario.Hint = "";
            this.txb_usuario.Location = new System.Drawing.Point(163, 69);
            this.txb_usuario.MaxLength = 60;
            this.txb_usuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txb_usuario.Name = "txb_usuario";
            this.txb_usuario.PasswordChar = '\0';
            this.txb_usuario.SelectedText = "";
            this.txb_usuario.SelectionLength = 0;
            this.txb_usuario.SelectionStart = 0;
            this.txb_usuario.Size = new System.Drawing.Size(357, 28);
            this.txb_usuario.TabIndex = 13;
            this.txb_usuario.TabStop = false;
            this.txb_usuario.UseSystemPasswordChar = false;
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Depth = 0;
            this.lbl_usuario.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_usuario.Location = new System.Drawing.Point(17, 73);
            this.lbl_usuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(74, 24);
            this.lbl_usuario.TabIndex = 9;
            this.lbl_usuario.Text = "Usuario";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.BackColor = System.Drawing.Color.LightSlateGray;
            this.lbl_pass.Depth = 0;
            this.lbl_pass.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_pass.Location = new System.Drawing.Point(17, 116);
            this.lbl_pass.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(105, 24);
            this.lbl_pass.TabIndex = 10;
            this.lbl_pass.Text = "Contraseña";
            // 
            // lbl_correo
            // 
            this.lbl_correo.AutoSize = true;
            this.lbl_correo.Depth = 0;
            this.lbl_correo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_correo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_correo.Location = new System.Drawing.Point(17, 159);
            this.lbl_correo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_correo.Name = "lbl_correo";
            this.lbl_correo.Size = new System.Drawing.Size(66, 24);
            this.lbl_correo.TabIndex = 11;
            this.lbl_correo.Text = "Correo";
            this.lbl_correo.Click += new System.EventHandler(this.lbl_correo_Click);
            // 
            // usuarios_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 434);
            this.Controls.Add(this.panel1);
            this.Name = "usuarios_view";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "USUARIOS";
            this.Load += new System.EventHandler(this.usuarios_view_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txb_correo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txb_nombre;
        private MaterialSkin.Controls.MaterialSingleLineTextField txb_pass;
        private MaterialSkin.Controls.MaterialSingleLineTextField txb_usuario;
        private MaterialSkin.Controls.MaterialLabel lbl_usuario;
        private MaterialSkin.Controls.MaterialLabel lbl_pass;
        private MaterialSkin.Controls.MaterialLabel lbl_correo;
        private MaterialSkin.Controls.MaterialRaisedButton btn_guardar;
        private MaterialSkin.Controls.MaterialRaisedButton btn_back;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialLabel lbl_nombre1;
    }
}