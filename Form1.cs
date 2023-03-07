using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Tienda_2._0
{
    public partial class Form1 : Form,IVista
    {
        bool camisa = false;
        bool pantalon = true;
        bool mangacorta = false;
        bool cuellocomun = true;
        bool pantaloncomun = true;
        float preciof;
        bool calidad = false;

        public float Preciof { get => preciof; set => preciof = value; }

        // Implementacion


        public void HistorialVendedor(int numID, string fecha, string hora, int codiV, string prendacoti, int unidadescotizadas, float resultadocotizacion)
        {
            lblMostrarHistorial.Text = lblMostrarHistorial.Text + "\n Numero identificador: " + numID.ToString();
            lblMostrarHistorial.Text = lblMostrarHistorial.Text +  "\n Fecha: " + fecha;
            lblMostrarHistorial.Text = lblMostrarHistorial.Text +  "\n Hora : " + hora;
            lblMostrarHistorial.Text = lblMostrarHistorial.Text + "\n Codigo Vendedor : " + codiV.ToString();
            lblMostrarHistorial.Text = lblMostrarHistorial.Text + "\n Prenda Cotizada : " + prendacoti;
            lblMostrarHistorial.Text = lblMostrarHistorial.Text + "\n Unidades Cotizadas : " + unidadescotizadas.ToString();
            lblMostrarHistorial.Text = lblMostrarHistorial.Text + "\n Resultado Final : " + resultadocotizacion.ToString();
            lblMostrarHistorial.Text = lblMostrarHistorial.Text + "\n --------------------------------------------------------: " ;
            lblMostrarHistorial.Text = lblMostrarHistorial.Text + "\n  ";

        }
        public void controCalidad(string mensaje)
        {
            lblcalidadactual.Text = "La calidad actual es " + mensaje.ToString();
        }
        public void PrecioFinal(float p)
        {
            lblPreciofinal.Text = "Precio: " + p.ToString();

            lblmangaactual.Text = this.mangacorta.ToString();
            //lblPreciofinal.Text = "Precio: " + p.ToString();
            MessageBox.Show("Los datos estan correctos! :D");
            if (this.camisa == true)
            {
                if (mangacorta == true)
                {
                    if(cuellocomun == true)
                    {
                        MessageBox.Show("Es una prenda Camisa de Manga corta y Cuello comun");
                        if (calidad == true)
                        {
                            MessageBox.Show("El tipo de calidad es premium");
                        }
                        else
                        {
                            MessageBox.Show("El tipo de calidad es standar");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Es una prenda Camisa de manga corta y Cuello mao");
                        if (calidad == true)
                        {
                            MessageBox.Show("El tipo de calidad es premium");
                        }
                        else
                        {
                            MessageBox.Show("El tipo de calidad es standar");
                        }
                    }
                }
                else if (mangacorta == false)
                {
                    if (cuellocomun == true)
                    {
                        MessageBox.Show("Es una prenda Camisa de Manga larga y Cuello comun");
                        if (calidad == true)
                        {
                            MessageBox.Show("El tipo de calidad es premium");
                        }
                        else
                        {
                            MessageBox.Show("El tipo de calidad es standar");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Es una prenda Camisa de manga larga y Cuello mao");
                        if (calidad == true)
                        {
                            MessageBox.Show("El tipo de calidad es premium");
                        }
                        else
                        {
                            MessageBox.Show("El tipo de calidad es standar");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else if (this.pantalon == true)
            {
                if (pantaloncomun == true)
                {
                    MessageBox.Show("Es un pantalon comun");
                }   
                else if (pantaloncomun == false)
                {
                    MessageBox.Show("Es un pantalon tipo chupin");
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                MessageBox.Show("Error");
            }
            

        }

        public void Errovalidacion(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        public void ErrorStock(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        public Form1()
        {
 
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
    }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCotizar_Click(object sender, EventArgs e)
        {
            //Validacion de los campos, esta validacion valida los string,enteros y flotantes
            bool validarNombreTienda = ValidarCamposVista.validarCampo(txtNombretienda.Text, "string");
            bool validarDireccionTIenda = ValidarCamposVista.validarCampo(txtDirecciontienda.Text, "string");
            bool validarNombrevendedor = ValidarCamposVista.validarCampo(txtNombrevendedor.Text, "string");
            bool validarApellidovendedor = ValidarCamposVista.validarCampo(txtApellido.Text, "string");
            bool validarCodigoVendedor = ValidarCamposVista.validarCampo(txtCodigovendedor.Text, "int");
            bool validarPrecio = ValidarCamposVista.validarCampo(txtPreciounitario.Text, "float");
            bool validarCantidad = ValidarCamposVista.validarCampo(txtCantidad.Text, "int");

           

            if (validarNombreTienda && validarDireccionTIenda && validarNombrevendedor && validarApellidovendedor && validarCodigoVendedor && validarPrecio && validarCantidad == true)
            {
                //en el caso que todas las variables boleanas sean true se pasaran todos los datos a la clase Presentador
                int preciounitario = Convert.ToInt32(txtPreciounitario.Text);
                int codigovendedor = Convert.ToInt32(txtCodigovendedor.Text);
                int cantidad = Convert.ToInt32(txtCantidad.Text);



                Presentador pr1 = new Presentador(txtNombretienda.Text, txtDirecciontienda.Text, txtNombrevendedor.Text, txtApellido.Text, codigovendedor, camisa, pantalon, mangacorta, pantaloncomun, calidad, preciounitario, cantidad, cuellocomun,this);
                //Presentador pr2 = new Presentador(this);
                txtNombretienda.BackColor = System.Drawing.Color.White;
                txtDirecciontienda.BackColor = System.Drawing.Color.White;
                txtNombrevendedor.BackColor = System.Drawing.Color.White;
                txtApellido.BackColor = System.Drawing.Color.White;
                txtCodigovendedor.BackColor = System.Drawing.Color.White;
                txtPreciounitario.BackColor = System.Drawing.Color.White;
                txtCantidad.BackColor = System.Drawing.Color.White;

               



            }
            else
            {
                //en el caso que no sea asi, saldra una ventaana de error y marcara en naranja el campo que esta mal
                MessageBox.Show("Los datos estan incorrectos o falta rellenar campos");

                if (validarNombreTienda == false)
                {
                    txtNombretienda.BackColor = System.Drawing.Color.Orange;
                }
                else
                {
                    txtNombretienda.BackColor = System.Drawing.Color.White;
               
                }

                if (validarDireccionTIenda == false)
                {
                    txtDirecciontienda.BackColor = System.Drawing.Color.Orange;
                }
                else
                {
                  
                    txtDirecciontienda.BackColor = System.Drawing.Color.White;
                 
                }
                
                if(validarNombrevendedor == false)
                {
                    txtNombrevendedor.BackColor = System.Drawing.Color.Orange;
                }
                else
                {
                    txtNombrevendedor.BackColor = System.Drawing.Color.White;
                 
                }
                
                if ( validarApellidovendedor == false)
                {
                    txtApellido.BackColor = System.Drawing.Color.Orange;

                }
                else
                {
             
                    txtApellido.BackColor = System.Drawing.Color.White;
              
                }
                
                if ( validarCodigoVendedor == false)
                {
                    txtCodigovendedor.BackColor = System.Drawing.Color.Orange;

                }
                else
                {
  
                    txtCodigovendedor.BackColor = System.Drawing.Color.White;

                }
                
                if(validarPrecio == false)
                {
                    txtPreciounitario.BackColor = System.Drawing.Color.Orange;

                }
                else
                {
        
                    txtPreciounitario.BackColor = System.Drawing.Color.White;
                }
                
                if (validarCantidad == false)
                {
                    txtCantidad.BackColor = System.Drawing.Color.Orange;

                }
                else
                {

                    txtCantidad.BackColor = System.Drawing.Color.White;
                }
            }
        }

        private void rbtCamisa_CheckedChanged(object sender, EventArgs e)
        {
            this.camisa = true;
            this.pantalon = false;
            this.pantaloncomun = false;


            rbtPantalon.Checked = false;

            chbChupin.Checked = false;


        }

        private void rbtPantalon_CheckedChanged(object sender, EventArgs e)
        {
            this.camisa = false;
            this.mangacorta = false;
            this.cuellocomun = true;
            this.pantalon = true;
            this.pantaloncomun = true;
            rbtCamisa.Checked = false;
            chbCuelloMao.Checked = false;
            chbMangacorta.Checked = false;

        }

        private void chbMangacorta_CheckedChanged(object sender, EventArgs e)
        {
            this.mangacorta = true;
            this.camisa = true;

            rbtCamisa.Checked = true;
            rbtPantalon.Checked = false;

        }

        private void chbCuelloMao_CheckedChanged(object sender, EventArgs e)
        {
            this.cuellocomun = false;
            this.camisa = true;

            rbtCamisa.Checked = true;
            rbtPantalon.Checked = false;


            
        }

        private void chbChupin_CheckedChanged(object sender, EventArgs e)
        {
            this.pantalon = true;
            this.pantaloncomun = false;


            rbtPantalon.Checked = true;

            rbtCamisa.Checked = false;



        }

        private void rbtStandar_CheckedChanged(object sender, EventArgs e)
        {
            this.calidad = false;

            rbtPremium.Checked = false;



        }

        private void lblNombrevendedor_Click(object sender, EventArgs e)
        {

        }

        private void rbtPremium_CheckedChanged(object sender, EventArgs e)
        {
            this.calidad = true;
            rbtStandar.Checked = false;
        }

        private void lblPreciofinal_Click(object sender, EventArgs e)
        {
         
        }

        private void lblmangaactual_Click(object sender, EventArgs e)
        {
            lblmangaactual.Text = this.mangacorta.ToString();
        }
    }
}
