
namespace SistemaTienda
{
    partial class Inventario
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblBienvenidoUsuario = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panelDatos = new System.Windows.Forms.Panel();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtExistencias = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFabrica = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTalla = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBienvenidoUsuario
            // 
            this.lblBienvenidoUsuario.AutoSize = true;
            this.lblBienvenidoUsuario.BackColor = System.Drawing.Color.LightGray;
            this.lblBienvenidoUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBienvenidoUsuario.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenidoUsuario.Location = new System.Drawing.Point(738, 9);
            this.lblBienvenidoUsuario.Name = "lblBienvenidoUsuario";
            this.lblBienvenidoUsuario.Size = new System.Drawing.Size(99, 20);
            this.lblBienvenidoUsuario.TabIndex = 18;
            this.lblBienvenidoUsuario.Text = "Bienvenido";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.LightGray;
            this.lblFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFecha.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(12, 2);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(118, 20);
            this.lblFecha.TabIndex = 17;
            this.lblFecha.Text = "07/08/2022";
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.ForeColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.Image = global::SistemaTienda.Properties.Resources.minimizar__1_;
            this.btnMinimizar.Location = new System.Drawing.Point(955, 2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(33, 36);
            this.btnMinimizar.TabIndex = 15;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Image = global::SistemaTienda.Properties.Resources.cerrar__1_;
            this.btnCerrar.Location = new System.Drawing.Point(994, 7);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(28, 27);
            this.btnCerrar.TabIndex = 14;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panelDatos
            // 
            this.panelDatos.BackColor = System.Drawing.Color.Transparent;
            this.panelDatos.Controls.Add(this.txtPrecio);
            this.panelDatos.Controls.Add(this.label8);
            this.panelDatos.Controls.Add(this.txtTalla);
            this.panelDatos.Controls.Add(this.label7);
            this.panelDatos.Controls.Add(this.txtFabrica);
            this.panelDatos.Controls.Add(this.label6);
            this.panelDatos.Controls.Add(this.txtColor);
            this.panelDatos.Controls.Add(this.label5);
            this.panelDatos.Controls.Add(this.txtExistencias);
            this.panelDatos.Controls.Add(this.label4);
            this.panelDatos.Controls.Add(this.txtDescripcion);
            this.panelDatos.Controls.Add(this.label3);
            this.panelDatos.Controls.Add(this.txtMarca);
            this.panelDatos.Controls.Add(this.label2);
            this.panelDatos.Controls.Add(this.txtProducto);
            this.panelDatos.Controls.Add(this.label1);
            this.panelDatos.Controls.Add(this.btnRegistrar);
            this.panelDatos.Controls.Add(this.dataGridView1);
            this.panelDatos.Location = new System.Drawing.Point(3, 89);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(1028, 520);
            this.panelDatos.TabIndex = 16;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(307, 436);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(210, 31);
            this.txtDescripcion.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(166, 439);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 23);
            this.label3.TabIndex = 56;
            this.label3.Text = "Descripcion";
            // 
            // txtMarca
            // 
            this.txtMarca.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(278, 399);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(210, 31);
            this.txtMarca.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(166, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 23);
            this.label2.TabIndex = 54;
            this.label2.Text = "Marca";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtProducto
            // 
            this.txtProducto.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.Location = new System.Drawing.Point(278, 362);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(210, 31);
            this.txtProducto.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 23);
            this.label1.TabIndex = 52;
            this.label1.Text = "Producto";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.DimGray;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(889, 473);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(130, 37);
            this.btnRegistrar.TabIndex = 8;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1025, 353);
            this.dataGridView1.TabIndex = 51;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Transparent;
            this.panelMenu.Controls.Add(this.btnCerrarSesion);
            this.panelMenu.Controls.Add(this.button5);
            this.panelMenu.Controls.Add(this.button4);
            this.panelMenu.Controls.Add(this.button3);
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.button2);
            this.panelMenu.Location = new System.Drawing.Point(3, 40);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1028, 43);
            this.panelMenu.TabIndex = 13;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Image = global::SistemaTienda.Properties.Resources.iniciar_sesion__4_1;
            this.btnCerrarSesion.Location = new System.Drawing.Point(989, 1);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(39, 40);
            this.btnCerrarSesion.TabIndex = 7;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DimGray;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(668, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 31);
            this.button5.TabIndex = 6;
            this.button5.Text = "Inventario";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DimGray;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(551, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(76, 31);
            this.button4.TabIndex = 5;
            this.button4.Text = "Opcion4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DimGray;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(441, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 31);
            this.button3.TabIndex = 4;
            this.button3.Text = "Opcion3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(330, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "Opcion2";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(205, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "Productos";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtExistencias
            // 
            this.txtExistencias.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExistencias.Location = new System.Drawing.Point(307, 476);
            this.txtExistencias.Name = "txtExistencias";
            this.txtExistencias.Size = new System.Drawing.Size(210, 31);
            this.txtExistencias.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(166, 479);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 23);
            this.label4.TabIndex = 58;
            this.label4.Text = "Existencias";
            // 
            // txtColor
            // 
            this.txtColor.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColor.Location = new System.Drawing.Point(624, 365);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(210, 31);
            this.txtColor.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(552, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 23);
            this.label5.TabIndex = 60;
            this.label5.Text = "Color";
            // 
            // txtFabrica
            // 
            this.txtFabrica.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFabrica.Location = new System.Drawing.Point(646, 439);
            this.txtFabrica.Name = "txtFabrica";
            this.txtFabrica.Size = new System.Drawing.Size(210, 31);
            this.txtFabrica.TabIndex = 63;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(552, 442);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 23);
            this.label6.TabIndex = 62;
            this.label6.Text = "Fabrica";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(552, 405);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 23);
            this.label7.TabIndex = 62;
            this.label7.Text = "Talla";
            // 
            // txtTalla
            // 
            this.txtTalla.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTalla.Location = new System.Drawing.Point(624, 402);
            this.txtTalla.Name = "txtTalla";
            this.txtTalla.Size = new System.Drawing.Size(210, 31);
            this.txtTalla.TabIndex = 63;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(646, 479);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(210, 31);
            this.txtPrecio.TabIndex = 65;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(552, 482);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 23);
            this.label8.TabIndex = 64;
            this.label8.Text = "Precio";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.LightGray;
            this.lblHora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHora.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(12, 22);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(88, 20);
            this.lblHora.TabIndex = 19;
            this.lblHora.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaTienda.Properties.Resources.App_Back;
            this.ClientSize = new System.Drawing.Size(1034, 611);
            this.ControlBox = false;
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblBienvenidoUsuario);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.panelDatos);
            this.Controls.Add(this.panelMenu);
            this.Name = "Inventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Inventario_Load_1);
            this.panelDatos.ResumeLayout(false);
            this.panelDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenidoUsuario;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panelDatos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTalla;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFabrica;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtExistencias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timer1;
    }
}