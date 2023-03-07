
namespace Proyecto_Tienda_2._0
{
    partial class Form1
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
            this.lblNombretienda = new System.Windows.Forms.Label();
            this.txtNombretienda = new System.Windows.Forms.TextBox();
            this.lblDireccionTienda = new System.Windows.Forms.Label();
            this.txtDirecciontienda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombrevendedor = new System.Windows.Forms.TextBox();
            this.lblNombrevendedor = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtCodigovendedor = new System.Windows.Forms.TextBox();
            this.lblCodigovendedor = new System.Windows.Forms.Label();
            this.lblPrenda = new System.Windows.Forms.Label();
            this.rbtCamisa = new System.Windows.Forms.RadioButton();
            this.rbtPantalon = new System.Windows.Forms.RadioButton();
            this.chbMangacorta = new System.Windows.Forms.CheckBox();
            this.chbCuelloMao = new System.Windows.Forms.CheckBox();
            this.chbChupin = new System.Windows.Forms.CheckBox();
            this.lblCalidad = new System.Windows.Forms.Label();
            this.rbtStandar = new System.Windows.Forms.RadioButton();
            this.rbtPremium = new System.Windows.Forms.RadioButton();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPreciounitario = new System.Windows.Forms.TextBox();
            this.lblPreciounitario = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnCotizar = new System.Windows.Forms.Button();
            this.txtPrecioFinal = new System.Windows.Forms.TextBox();
            this.lblHistorial = new System.Windows.Forms.Label();
            this.lblPreciofinal = new System.Windows.Forms.Label();
            this.lblMostrarHistorial = new System.Windows.Forms.Label();
            this.lblmangaactual = new System.Windows.Forms.Label();
            this.lblcalidadactual = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombretienda
            // 
            this.lblNombretienda.AutoSize = true;
            this.lblNombretienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombretienda.Location = new System.Drawing.Point(17, 71);
            this.lblNombretienda.Name = "lblNombretienda";
            this.lblNombretienda.Size = new System.Drawing.Size(54, 13);
            this.lblNombretienda.TabIndex = 0;
            this.lblNombretienda.Text = "Nombre:";
            // 
            // txtNombretienda
            // 
            this.txtNombretienda.Location = new System.Drawing.Point(20, 102);
            this.txtNombretienda.Name = "txtNombretienda";
            this.txtNombretienda.Size = new System.Drawing.Size(100, 20);
            this.txtNombretienda.TabIndex = 1;
            // 
            // lblDireccionTienda
            // 
            this.lblDireccionTienda.AutoSize = true;
            this.lblDireccionTienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionTienda.Location = new System.Drawing.Point(222, 71);
            this.lblDireccionTienda.Name = "lblDireccionTienda";
            this.lblDireccionTienda.Size = new System.Drawing.Size(65, 13);
            this.lblDireccionTienda.TabIndex = 2;
            this.lblDireccionTienda.Text = "Direccion:";
            // 
            // txtDirecciontienda
            // 
            this.txtDirecciontienda.Location = new System.Drawing.Point(203, 102);
            this.txtDirecciontienda.Name = "txtDirecciontienda";
            this.txtDirecciontienda.Size = new System.Drawing.Size(125, 20);
            this.txtDirecciontienda.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "TIENDA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(515, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "VENDEDOR";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNombrevendedor
            // 
            this.txtNombrevendedor.Location = new System.Drawing.Point(429, 102);
            this.txtNombrevendedor.Name = "txtNombrevendedor";
            this.txtNombrevendedor.Size = new System.Drawing.Size(100, 20);
            this.txtNombrevendedor.TabIndex = 7;
            // 
            // lblNombrevendedor
            // 
            this.lblNombrevendedor.AutoSize = true;
            this.lblNombrevendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrevendedor.Location = new System.Drawing.Point(426, 71);
            this.lblNombrevendedor.Name = "lblNombrevendedor";
            this.lblNombrevendedor.Size = new System.Drawing.Size(54, 13);
            this.lblNombrevendedor.TabIndex = 6;
            this.lblNombrevendedor.Text = "Nombre:";
            this.lblNombrevendedor.Click += new System.EventHandler(this.lblNombrevendedor_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(613, 102);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 9;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(610, 71);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(56, 13);
            this.lblApellido.TabIndex = 8;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtCodigovendedor
            // 
            this.txtCodigovendedor.Location = new System.Drawing.Point(429, 188);
            this.txtCodigovendedor.Name = "txtCodigovendedor";
            this.txtCodigovendedor.Size = new System.Drawing.Size(100, 20);
            this.txtCodigovendedor.TabIndex = 11;
            // 
            // lblCodigovendedor
            // 
            this.lblCodigovendedor.AutoSize = true;
            this.lblCodigovendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigovendedor.Location = new System.Drawing.Point(426, 157);
            this.lblCodigovendedor.Name = "lblCodigovendedor";
            this.lblCodigovendedor.Size = new System.Drawing.Size(108, 13);
            this.lblCodigovendedor.TabIndex = 10;
            this.lblCodigovendedor.Text = "Codigo Vendedor:";
            this.lblCodigovendedor.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblPrenda
            // 
            this.lblPrenda.AutoSize = true;
            this.lblPrenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenda.Location = new System.Drawing.Point(29, 258);
            this.lblPrenda.Name = "lblPrenda";
            this.lblPrenda.Size = new System.Drawing.Size(66, 20);
            this.lblPrenda.TabIndex = 12;
            this.lblPrenda.Text = "Prenda";
            // 
            // rbtCamisa
            // 
            this.rbtCamisa.AutoSize = true;
            this.rbtCamisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtCamisa.Location = new System.Drawing.Point(37, 310);
            this.rbtCamisa.Name = "rbtCamisa";
            this.rbtCamisa.Size = new System.Drawing.Size(78, 20);
            this.rbtCamisa.TabIndex = 13;
            this.rbtCamisa.TabStop = true;
            this.rbtCamisa.Text = "Camisa";
            this.rbtCamisa.UseVisualStyleBackColor = true;
            this.rbtCamisa.CheckedChanged += new System.EventHandler(this.rbtCamisa_CheckedChanged);
            // 
            // rbtPantalon
            // 
            this.rbtPantalon.AutoSize = true;
            this.rbtPantalon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtPantalon.Location = new System.Drawing.Point(37, 346);
            this.rbtPantalon.Name = "rbtPantalon";
            this.rbtPantalon.Size = new System.Drawing.Size(87, 20);
            this.rbtPantalon.TabIndex = 14;
            this.rbtPantalon.TabStop = true;
            this.rbtPantalon.Text = "Pantalon";
            this.rbtPantalon.UseVisualStyleBackColor = true;
            this.rbtPantalon.CheckedChanged += new System.EventHandler(this.rbtPantalon_CheckedChanged);
            // 
            // chbMangacorta
            // 
            this.chbMangacorta.AutoSize = true;
            this.chbMangacorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbMangacorta.Location = new System.Drawing.Point(188, 313);
            this.chbMangacorta.Name = "chbMangacorta";
            this.chbMangacorta.Size = new System.Drawing.Size(115, 20);
            this.chbMangacorta.TabIndex = 15;
            this.chbMangacorta.Text = "Manga Corta";
            this.chbMangacorta.UseVisualStyleBackColor = true;
            this.chbMangacorta.CheckedChanged += new System.EventHandler(this.chbMangacorta_CheckedChanged);
            // 
            // chbCuelloMao
            // 
            this.chbCuelloMao.AutoSize = true;
            this.chbCuelloMao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbCuelloMao.Location = new System.Drawing.Point(319, 311);
            this.chbCuelloMao.Name = "chbCuelloMao";
            this.chbCuelloMao.Size = new System.Drawing.Size(105, 20);
            this.chbCuelloMao.TabIndex = 16;
            this.chbCuelloMao.Text = "Cuello Mao";
            this.chbCuelloMao.UseVisualStyleBackColor = true;
            this.chbCuelloMao.CheckedChanged += new System.EventHandler(this.chbCuelloMao_CheckedChanged);
            // 
            // chbChupin
            // 
            this.chbChupin.AutoSize = true;
            this.chbChupin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbChupin.Location = new System.Drawing.Point(188, 346);
            this.chbChupin.Name = "chbChupin";
            this.chbChupin.Size = new System.Drawing.Size(74, 20);
            this.chbChupin.TabIndex = 17;
            this.chbChupin.Text = "Chupin";
            this.chbChupin.UseVisualStyleBackColor = true;
            this.chbChupin.CheckedChanged += new System.EventHandler(this.chbChupin_CheckedChanged);
            // 
            // lblCalidad
            // 
            this.lblCalidad.AutoSize = true;
            this.lblCalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalidad.Location = new System.Drawing.Point(474, 258);
            this.lblCalidad.Name = "lblCalidad";
            this.lblCalidad.Size = new System.Drawing.Size(69, 20);
            this.lblCalidad.TabIndex = 18;
            this.lblCalidad.Text = "Calidad";
            // 
            // rbtStandar
            // 
            this.rbtStandar.AutoSize = true;
            this.rbtStandar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtStandar.Location = new System.Drawing.Point(478, 312);
            this.rbtStandar.Name = "rbtStandar";
            this.rbtStandar.Size = new System.Drawing.Size(89, 20);
            this.rbtStandar.TabIndex = 19;
            this.rbtStandar.TabStop = true;
            this.rbtStandar.Text = "Standard";
            this.rbtStandar.UseVisualStyleBackColor = true;
            this.rbtStandar.CheckedChanged += new System.EventHandler(this.rbtStandar_CheckedChanged);
            // 
            // rbtPremium
            // 
            this.rbtPremium.AutoSize = true;
            this.rbtPremium.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtPremium.Location = new System.Drawing.Point(478, 386);
            this.rbtPremium.Name = "rbtPremium";
            this.rbtPremium.Size = new System.Drawing.Size(86, 20);
            this.rbtPremium.TabIndex = 20;
            this.rbtPremium.TabStop = true;
            this.rbtPremium.Text = "Premium";
            this.rbtPremium.UseVisualStyleBackColor = true;
            this.rbtPremium.CheckedChanged += new System.EventHandler(this.rbtPremium_CheckedChanged);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(628, 258);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(59, 20);
            this.lblPrecio.TabIndex = 21;
            this.lblPrecio.Text = "Precio";
            // 
            // txtPreciounitario
            // 
            this.txtPreciounitario.Location = new System.Drawing.Point(632, 341);
            this.txtPreciounitario.Name = "txtPreciounitario";
            this.txtPreciounitario.Size = new System.Drawing.Size(100, 20);
            this.txtPreciounitario.TabIndex = 23;
            // 
            // lblPreciounitario
            // 
            this.lblPreciounitario.AutoSize = true;
            this.lblPreciounitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreciounitario.Location = new System.Drawing.Point(629, 310);
            this.lblPreciounitario.Name = "lblPreciounitario";
            this.lblPreciounitario.Size = new System.Drawing.Size(95, 13);
            this.lblPreciounitario.TabIndex = 22;
            this.lblPreciounitario.Text = "Precio Unitario:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(632, 413);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 25;
            this.txtCantidad.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(629, 382);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(61, 13);
            this.lblCantidad.TabIndex = 24;
            this.lblCantidad.Text = "Cantidad:";
            this.lblCantidad.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // btnCotizar
            // 
            this.btnCotizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCotizar.Location = new System.Drawing.Point(90, 490);
            this.btnCotizar.Name = "btnCotizar";
            this.btnCotizar.Size = new System.Drawing.Size(148, 42);
            this.btnCotizar.TabIndex = 26;
            this.btnCotizar.Text = "Cotizar";
            this.btnCotizar.UseVisualStyleBackColor = true;
            this.btnCotizar.Click += new System.EventHandler(this.btnCotizar_Click);
            // 
            // txtPrecioFinal
            // 
            this.txtPrecioFinal.Location = new System.Drawing.Point(319, 505);
            this.txtPrecioFinal.Name = "txtPrecioFinal";
            this.txtPrecioFinal.Size = new System.Drawing.Size(136, 20);
            this.txtPrecioFinal.TabIndex = 27;
            // 
            // lblHistorial
            // 
            this.lblHistorial.AutoSize = true;
            this.lblHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorial.Location = new System.Drawing.Point(767, 37);
            this.lblHistorial.Name = "lblHistorial";
            this.lblHistorial.Size = new System.Drawing.Size(194, 20);
            this.lblHistorial.TabIndex = 28;
            this.lblHistorial.Text = "Historial de Cotizacion:";
            // 
            // lblPreciofinal
            // 
            this.lblPreciofinal.AutoSize = true;
            this.lblPreciofinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreciofinal.Location = new System.Drawing.Point(496, 505);
            this.lblPreciofinal.Name = "lblPreciofinal";
            this.lblPreciofinal.Size = new System.Drawing.Size(71, 13);
            this.lblPreciofinal.TabIndex = 29;
            this.lblPreciofinal.Text = "Precio final";
            this.lblPreciofinal.Click += new System.EventHandler(this.lblPreciofinal_Click);
            // 
            // lblMostrarHistorial
            // 
            this.lblMostrarHistorial.AutoSize = true;
            this.lblMostrarHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarHistorial.Location = new System.Drawing.Point(805, 80);
            this.lblMostrarHistorial.Name = "lblMostrarHistorial";
            this.lblMostrarHistorial.Size = new System.Drawing.Size(99, 13);
            this.lblMostrarHistorial.TabIndex = 30;
            this.lblMostrarHistorial.Text = "Mostrar Historial";
            // 
            // lblmangaactual
            // 
            this.lblmangaactual.AutoSize = true;
            this.lblmangaactual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmangaactual.Location = new System.Drawing.Point(619, 508);
            this.lblmangaactual.Name = "lblmangaactual";
            this.lblmangaactual.Size = new System.Drawing.Size(80, 13);
            this.lblmangaactual.TabIndex = 31;
            this.lblmangaactual.Text = "Mangaactual";
            this.lblmangaactual.Click += new System.EventHandler(this.lblmangaactual_Click);
            // 
            // lblcalidadactual
            // 
            this.lblcalidadactual.AutoSize = true;
            this.lblcalidadactual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcalidadactual.Location = new System.Drawing.Point(742, 505);
            this.lblcalidadactual.Name = "lblcalidadactual";
            this.lblcalidadactual.Size = new System.Drawing.Size(83, 13);
            this.lblcalidadactual.TabIndex = 32;
            this.lblcalidadactual.Text = "calidadactual";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 616);
            this.Controls.Add(this.lblcalidadactual);
            this.Controls.Add(this.lblmangaactual);
            this.Controls.Add(this.lblMostrarHistorial);
            this.Controls.Add(this.lblPreciofinal);
            this.Controls.Add(this.lblHistorial);
            this.Controls.Add(this.txtPrecioFinal);
            this.Controls.Add(this.btnCotizar);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtPreciounitario);
            this.Controls.Add(this.lblPreciounitario);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.rbtPremium);
            this.Controls.Add(this.rbtStandar);
            this.Controls.Add(this.lblCalidad);
            this.Controls.Add(this.chbChupin);
            this.Controls.Add(this.chbCuelloMao);
            this.Controls.Add(this.chbMangacorta);
            this.Controls.Add(this.rbtPantalon);
            this.Controls.Add(this.rbtCamisa);
            this.Controls.Add(this.lblPrenda);
            this.Controls.Add(this.txtCodigovendedor);
            this.Controls.Add(this.lblCodigovendedor);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtNombrevendedor);
            this.Controls.Add(this.lblNombrevendedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDirecciontienda);
            this.Controls.Add(this.lblDireccionTienda);
            this.Controls.Add(this.txtNombretienda);
            this.Controls.Add(this.lblNombretienda);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombretienda;
        private System.Windows.Forms.TextBox txtNombretienda;
        private System.Windows.Forms.Label lblDireccionTienda;
        private System.Windows.Forms.TextBox txtDirecciontienda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombrevendedor;
        private System.Windows.Forms.Label lblNombrevendedor;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtCodigovendedor;
        private System.Windows.Forms.Label lblCodigovendedor;
        private System.Windows.Forms.Label lblPrenda;
        private System.Windows.Forms.RadioButton rbtCamisa;
        private System.Windows.Forms.RadioButton rbtPantalon;
        private System.Windows.Forms.CheckBox chbMangacorta;
        private System.Windows.Forms.CheckBox chbCuelloMao;
        private System.Windows.Forms.CheckBox chbChupin;
        private System.Windows.Forms.Label lblCalidad;
        private System.Windows.Forms.RadioButton rbtStandar;
        private System.Windows.Forms.RadioButton rbtPremium;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPreciounitario;
        private System.Windows.Forms.Label lblPreciounitario;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnCotizar;
        private System.Windows.Forms.TextBox txtPrecioFinal;
        private System.Windows.Forms.Label lblHistorial;
        private System.Windows.Forms.Label lblPreciofinal;
        private System.Windows.Forms.Label lblMostrarHistorial;
        private System.Windows.Forms.Label lblmangaactual;
        private System.Windows.Forms.Label lblcalidadactual;
    }
}

