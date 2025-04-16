using System.Windows.Forms;

namespace Proyecto_1.FrontEnd.Inventario
{
    partial class f_crear_actualizar_inventario
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
            this.lbl_inventario_nombre = new System.Windows.Forms.Label();
            this.lbl_inventario_descripcion = new System.Windows.Forms.Label();
            this.lbl_inventario_serie = new System.Windows.Forms.Label();
            this.lbl_inventario_color = new System.Windows.Forms.Label();
            this.lbl_inventario_fecha = new System.Windows.Forms.Label();
            this.lbl_inventario_tipo = new System.Windows.Forms.Label();
            this.lbl_inventario_observaciones = new System.Windows.Forms.Label();
            this.lbl_area_id = new System.Windows.Forms.Label();
            this.lbx_inventario_color = new System.Windows.Forms.ListBox();
            this.dtp_inventario_fecha = new System.Windows.Forms.DateTimePicker();
            this.lbx_inventario_tipo = new System.Windows.Forms.ListBox();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txb_area_id = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txb_inventario_observaciones = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txb_inventario_serie = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txb_inventario_descripcion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txb_inventario_nombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_guardar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_inventario_nombre
            // 
            this.lbl_inventario_nombre.AutoSize = true;
            this.lbl_inventario_nombre.Font = new System.Drawing.Font("Mongolian Baiti", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inventario_nombre.Location = new System.Drawing.Point(59, 14);
            this.lbl_inventario_nombre.Name = "lbl_inventario_nombre";
            this.lbl_inventario_nombre.Size = new System.Drawing.Size(63, 14);
            this.lbl_inventario_nombre.TabIndex = 13;
            this.lbl_inventario_nombre.Text = "NOMBRE";
            // 
            // lbl_inventario_descripcion
            // 
            this.lbl_inventario_descripcion.AutoSize = true;
            this.lbl_inventario_descripcion.Font = new System.Drawing.Font("Mongolian Baiti", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inventario_descripcion.Location = new System.Drawing.Point(28, 94);
            this.lbl_inventario_descripcion.Name = "lbl_inventario_descripcion";
            this.lbl_inventario_descripcion.Size = new System.Drawing.Size(91, 14);
            this.lbl_inventario_descripcion.TabIndex = 14;
            this.lbl_inventario_descripcion.Text = "DESCRIPCIÓN";
            // 
            // lbl_inventario_serie
            // 
            this.lbl_inventario_serie.AutoSize = true;
            this.lbl_inventario_serie.Font = new System.Drawing.Font("Mongolian Baiti", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inventario_serie.Location = new System.Drawing.Point(460, 55);
            this.lbl_inventario_serie.Name = "lbl_inventario_serie";
            this.lbl_inventario_serie.Size = new System.Drawing.Size(43, 14);
            this.lbl_inventario_serie.TabIndex = 15;
            this.lbl_inventario_serie.Text = "SERIE";
            // 
            // lbl_inventario_color
            // 
            this.lbl_inventario_color.AutoSize = true;
            this.lbl_inventario_color.Font = new System.Drawing.Font("Mongolian Baiti", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inventario_color.Location = new System.Drawing.Point(59, 245);
            this.lbl_inventario_color.Name = "lbl_inventario_color";
            this.lbl_inventario_color.Size = new System.Drawing.Size(51, 14);
            this.lbl_inventario_color.TabIndex = 16;
            this.lbl_inventario_color.Text = "COLOR";
            // 
            // lbl_inventario_fecha
            // 
            this.lbl_inventario_fecha.AutoSize = true;
            this.lbl_inventario_fecha.Font = new System.Drawing.Font("Mongolian Baiti", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inventario_fecha.Location = new System.Drawing.Point(408, 14);
            this.lbl_inventario_fecha.Name = "lbl_inventario_fecha";
            this.lbl_inventario_fecha.Size = new System.Drawing.Size(93, 14);
            this.lbl_inventario_fecha.TabIndex = 17;
            this.lbl_inventario_fecha.Text = "FECHA DE AD.";
            // 
            // lbl_inventario_tipo
            // 
            this.lbl_inventario_tipo.AutoSize = true;
            this.lbl_inventario_tipo.Font = new System.Drawing.Font("Mongolian Baiti", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inventario_tipo.Location = new System.Drawing.Point(29, 189);
            this.lbl_inventario_tipo.Name = "lbl_inventario_tipo";
            this.lbl_inventario_tipo.Size = new System.Drawing.Size(79, 14);
            this.lbl_inventario_tipo.TabIndex = 18;
            this.lbl_inventario_tipo.Text = "TIPO DE AD.";
            // 
            // lbl_inventario_observaciones
            // 
            this.lbl_inventario_observaciones.AutoSize = true;
            this.lbl_inventario_observaciones.Font = new System.Drawing.Font("Mongolian Baiti", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inventario_observaciones.Location = new System.Drawing.Point(3, 137);
            this.lbl_inventario_observaciones.Name = "lbl_inventario_observaciones";
            this.lbl_inventario_observaciones.Size = new System.Drawing.Size(113, 14);
            this.lbl_inventario_observaciones.TabIndex = 19;
            this.lbl_inventario_observaciones.Text = "OBSERVACIONES";
            // 
            // lbl_area_id
            // 
            this.lbl_area_id.AutoSize = true;
            this.lbl_area_id.Font = new System.Drawing.Font("Mongolian Baiti", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_area_id.Location = new System.Drawing.Point(37, 55);
            this.lbl_area_id.Name = "lbl_area_id";
            this.lbl_area_id.Size = new System.Drawing.Size(86, 14);
            this.lbl_area_id.TabIndex = 20;
            this.lbl_area_id.Text = "ID DEL ÁREA";
            // 
            // lbx_inventario_color
            // 
            this.lbx_inventario_color.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbx_inventario_color.Font = new System.Drawing.Font("Mongolian Baiti", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx_inventario_color.FormattingEnabled = true;
            this.lbx_inventario_color.ItemHeight = 14;
            this.lbx_inventario_color.Items.AddRange(new object[] {
            "Rojo",
            "Azul",
            "Morado",
            "Verde",
            "Amarillo",
            "Rosa",
            "Naranja",
            "Cyan",
            "Negro",
            "Blanco"});
            this.lbx_inventario_color.Location = new System.Drawing.Point(138, 229);
            this.lbx_inventario_color.Name = "lbx_inventario_color";
            this.lbx_inventario_color.Size = new System.Drawing.Size(108, 28);
            this.lbx_inventario_color.TabIndex = 5;
            this.lbx_inventario_color.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lbx_inventario_color_KeyUp);
            // 
            // dtp_inventario_fecha
            // 
            this.dtp_inventario_fecha.CalendarTitleBackColor = System.Drawing.Color.Teal;
            this.dtp_inventario_fecha.CustomFormat = "yyyy-MM-dd";
            this.dtp_inventario_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_inventario_fecha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtp_inventario_fecha.Location = new System.Drawing.Point(513, 8);
            this.dtp_inventario_fecha.Name = "dtp_inventario_fecha";
            this.dtp_inventario_fecha.Size = new System.Drawing.Size(254, 22);
            this.dtp_inventario_fecha.TabIndex = 6;
            this.dtp_inventario_fecha.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dtp_inventario_fecha_KeyUp);
            // 
            // lbx_inventario_tipo
            // 
            this.lbx_inventario_tipo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbx_inventario_tipo.Font = new System.Drawing.Font("Mongolian Baiti", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx_inventario_tipo.FormattingEnabled = true;
            this.lbx_inventario_tipo.ItemHeight = 14;
            this.lbx_inventario_tipo.Items.AddRange(new object[] {
            "Directa",
            "Indirecta",
            "De bienes"});
            this.lbx_inventario_tipo.Location = new System.Drawing.Point(138, 173);
            this.lbx_inventario_tipo.Name = "lbx_inventario_tipo";
            this.lbx_inventario_tipo.Size = new System.Drawing.Size(86, 28);
            this.lbx_inventario_tipo.TabIndex = 7;
            this.lbx_inventario_tipo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lbx_inventario_tipo_KeyUp);
            // 
            // btn_regresar
            // 
            this.btn_regresar.Location = new System.Drawing.Point(27, 414);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(116, 24);
            this.btn_regresar.TabIndex = 11;
            this.btn_regresar.Text = "REGRESAR";
            this.btn_regresar.UseVisualStyleBackColor = true;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txb_area_id);
            this.panel1.Controls.Add(this.txb_inventario_observaciones);
            this.panel1.Controls.Add(this.dtp_inventario_fecha);
            this.panel1.Controls.Add(this.lbx_inventario_tipo);
            this.panel1.Controls.Add(this.lbl_inventario_fecha);
            this.panel1.Controls.Add(this.lbx_inventario_color);
            this.panel1.Controls.Add(this.txb_inventario_serie);
            this.panel1.Controls.Add(this.txb_inventario_descripcion);
            this.panel1.Controls.Add(this.lbl_inventario_descripcion);
            this.panel1.Controls.Add(this.txb_inventario_nombre);
            this.panel1.Controls.Add(this.lbl_inventario_observaciones);
            this.panel1.Controls.Add(this.lbl_area_id);
            this.panel1.Controls.Add(this.lbl_inventario_tipo);
            this.panel1.Controls.Add(this.lbl_inventario_nombre);
            this.panel1.Controls.Add(this.lbl_inventario_serie);
            this.panel1.Controls.Add(this.lbl_inventario_color);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(27, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 296);
            this.panel1.TabIndex = 22;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txb_area_id
            // 
            this.txb_area_id.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txb_area_id.Depth = 0;
            this.txb_area_id.ForeColor = System.Drawing.Color.Cornsilk;
            this.txb_area_id.Hint = "";
            this.txb_area_id.Location = new System.Drawing.Point(138, 43);
            this.txb_area_id.MaxLength = 9;
            this.txb_area_id.MouseState = MaterialSkin.MouseState.HOVER;
            this.txb_area_id.Name = "txb_area_id";
            this.txb_area_id.PasswordChar = '\0';
            this.txb_area_id.SelectedText = "";
            this.txb_area_id.SelectionLength = 0;
            this.txb_area_id.SelectionStart = 0;
            this.txb_area_id.Size = new System.Drawing.Size(144, 28);
            this.txb_area_id.TabIndex = 5;
            this.txb_area_id.TabStop = false;
            this.txb_area_id.UseSystemPasswordChar = false;
            this.txb_area_id.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txb_area_id_KeyUp);
            // 
            // txb_inventario_observaciones
            // 
            this.txb_inventario_observaciones.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txb_inventario_observaciones.Depth = 0;
            this.txb_inventario_observaciones.Hint = "";
            this.txb_inventario_observaciones.Location = new System.Drawing.Point(138, 125);
            this.txb_inventario_observaciones.MaxLength = 45;
            this.txb_inventario_observaciones.MouseState = MaterialSkin.MouseState.HOVER;
            this.txb_inventario_observaciones.Name = "txb_inventario_observaciones";
            this.txb_inventario_observaciones.PasswordChar = '\0';
            this.txb_inventario_observaciones.SelectedText = "";
            this.txb_inventario_observaciones.SelectionLength = 0;
            this.txb_inventario_observaciones.SelectionStart = 0;
            this.txb_inventario_observaciones.Size = new System.Drawing.Size(629, 28);
            this.txb_inventario_observaciones.TabIndex = 4;
            this.txb_inventario_observaciones.TabStop = false;
            this.txb_inventario_observaciones.UseSystemPasswordChar = false;
            this.txb_inventario_observaciones.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txb_inventario_observaciones_KeyUp);
            // 
            // txb_inventario_serie
            // 
            this.txb_inventario_serie.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txb_inventario_serie.Depth = 0;
            this.txb_inventario_serie.Hint = "";
            this.txb_inventario_serie.Location = new System.Drawing.Point(513, 48);
            this.txb_inventario_serie.MaxLength = 45;
            this.txb_inventario_serie.MouseState = MaterialSkin.MouseState.HOVER;
            this.txb_inventario_serie.Name = "txb_inventario_serie";
            this.txb_inventario_serie.PasswordChar = '\0';
            this.txb_inventario_serie.SelectedText = "";
            this.txb_inventario_serie.SelectionLength = 0;
            this.txb_inventario_serie.SelectionStart = 0;
            this.txb_inventario_serie.Size = new System.Drawing.Size(191, 28);
            this.txb_inventario_serie.TabIndex = 3;
            this.txb_inventario_serie.TabStop = false;
            this.txb_inventario_serie.UseSystemPasswordChar = false;
            this.txb_inventario_serie.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txb_inventario_serie_KeyUp);
            // 
            // txb_inventario_descripcion
            // 
            this.txb_inventario_descripcion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txb_inventario_descripcion.Depth = 0;
            this.txb_inventario_descripcion.Hint = "";
            this.txb_inventario_descripcion.Location = new System.Drawing.Point(138, 82);
            this.txb_inventario_descripcion.MaxLength = 45;
            this.txb_inventario_descripcion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txb_inventario_descripcion.Name = "txb_inventario_descripcion";
            this.txb_inventario_descripcion.PasswordChar = '\0';
            this.txb_inventario_descripcion.SelectedText = "";
            this.txb_inventario_descripcion.SelectionLength = 0;
            this.txb_inventario_descripcion.SelectionStart = 0;
            this.txb_inventario_descripcion.Size = new System.Drawing.Size(629, 28);
            this.txb_inventario_descripcion.TabIndex = 2;
            this.txb_inventario_descripcion.TabStop = false;
            this.txb_inventario_descripcion.UseSystemPasswordChar = false;
            this.txb_inventario_descripcion.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txb_inventario_descripcion_KeyUp);
            // 
            // txb_inventario_nombre
            // 
            this.txb_inventario_nombre.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txb_inventario_nombre.Depth = 0;
            this.txb_inventario_nombre.ForeColor = System.Drawing.Color.Salmon;
            this.txb_inventario_nombre.Hint = "";
            this.txb_inventario_nombre.Location = new System.Drawing.Point(138, 8);
            this.txb_inventario_nombre.MaxLength = 45;
            this.txb_inventario_nombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txb_inventario_nombre.Name = "txb_inventario_nombre";
            this.txb_inventario_nombre.PasswordChar = '\0';
            this.txb_inventario_nombre.SelectedText = "";
            this.txb_inventario_nombre.SelectionLength = 0;
            this.txb_inventario_nombre.SelectionStart = 0;
            this.txb_inventario_nombre.Size = new System.Drawing.Size(247, 28);
            this.txb_inventario_nombre.TabIndex = 0;
            this.txb_inventario_nombre.TabStop = false;
            this.txb_inventario_nombre.UseSystemPasswordChar = false;
            this.txb_inventario_nombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txb_inventario_nombre_KeyUp);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btn_guardar);
            this.panel2.Location = new System.Drawing.Point(667, 238);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(113, 51);
            this.panel2.TabIndex = 24;
            // 
            // btn_guardar
            // 
            this.btn_guardar.AutoSize = true;
            this.btn_guardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_guardar.Depth = 0;
            this.btn_guardar.Font = new System.Drawing.Font("Mongolian Baiti", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.Icon = null;
            this.btn_guardar.Location = new System.Drawing.Point(6, 8);
            this.btn_guardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Primary = true;
            this.btn_guardar.Size = new System.Drawing.Size(100, 36);
            this.btn_guardar.TabIndex = 23;
            this.btn_guardar.Text = "GUARDAR";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click_1);
            // 
            // f_crear_actualizar_inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 450);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.panel1);
            this.Name = "f_crear_actualizar_inventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario en proceso";
            this.Load += new System.EventHandler(this.f_crear_actualizar_inventario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        private void Txb_inventario_nombre_KeyUp(object sender, KeyEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Label lbl_inventario_nombre;
        private System.Windows.Forms.Label lbl_inventario_descripcion;
        private System.Windows.Forms.Label lbl_inventario_serie;
        private System.Windows.Forms.Label lbl_inventario_color;
        private System.Windows.Forms.Label lbl_inventario_fecha;
        private System.Windows.Forms.Label lbl_inventario_tipo;
        private System.Windows.Forms.Label lbl_inventario_observaciones;
        private System.Windows.Forms.Label lbl_area_id;
        private System.Windows.Forms.ListBox lbx_inventario_color;
        private System.Windows.Forms.DateTimePicker dtp_inventario_fecha;
        private System.Windows.Forms.ListBox lbx_inventario_tipo;
        private System.Windows.Forms.Button btn_regresar;
        private Panel panel1;
        private MaterialSkin.Controls.MaterialRaisedButton btn_guardar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txb_inventario_nombre;
        private MaterialSkin.Controls.MaterialSingleLineTextField txb_inventario_descripcion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txb_inventario_observaciones;
        private MaterialSkin.Controls.MaterialSingleLineTextField txb_inventario_serie;
        private MaterialSkin.Controls.MaterialSingleLineTextField txb_area_id;
        private Panel panel2;
    }
}