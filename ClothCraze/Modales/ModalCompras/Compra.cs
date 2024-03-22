using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace ClothCraze.Modales.ModalCompras
{
    public partial class Compra : UserControl
    {
        public Compra()
        {
            InitializeComponent();
        }

        SqlConnection cnxn = new SqlConnection("Server=localhost; database=ClothCraze; INTEGRATED SECURITY = true");

        public void Productos(string Vestimenta, string Marca, Image Imagen, string Cantidad, string Precio)
        {
            var componente = new Modales.ModalCompras.ProductBuy();
            ContenedorProductos.Controls.Add(componente);
            componente.Dock = DockStyle.Top;
            componente.BringToFront();

            componente.Vestimenta = Vestimenta;
            componente.Marca = Marca;   
            componente.Imagen = Imagen;
            componente.Cantidad = Cantidad;
            componente.Precio = Precio;

        }

        public void ProductosComprado(string vestimenta)
        {
            var componente = new ModalCompras.ProductSent();
            PanelProductos.Controls.Add(componente);
            componente.Dock= DockStyle.Top;
            componente.BringToFront();

            componente.Vestimenta = vestimenta;

        }

        private void Compra_Load(object sender, EventArgs e)
        {

            if(Clases.EstadoSeccion.Nombre != null)
            {
                cnxn.Open();

                string consulta = "SELECT * FROM ProductosCarrito where Usuario = '"+ Clases.EstadoSeccion.Nombre +"'";

                SqlCommand cmd = new SqlCommand(consulta, cnxn);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                cnxn.Close();

                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    Byte[] archivo = (byte[])dt.Rows[i][7];
                    Stream imagen = new MemoryStream(archivo);
                    
                    Image imagenOriginal = Image.FromStream(imagen);

                    string cantidad = dt.Rows[i][8].ToString();
              

                    string precio = dt.Rows[i][6].ToString();
                 

                    Productos(dt.Rows[i][1].ToString(), dt.Rows[i][3].ToString(), imagenOriginal, cantidad, precio);
                }

                if(dt.Rows.Count == 0)
                {
                    LblNotificar.Visible = true;
                    LblNotificar.Text = "The cart is empty";
                }


                cnxn.Open();

                string consulta3 = "SELECT * FROM ProductosComprados where Usuario = '"+ Clases.EstadoSeccion.Nombre +"'";

                SqlCommand cmd3 = new SqlCommand(consulta3, cnxn);
                SqlDataAdapter adp3 = new SqlDataAdapter(cmd3);
                DataTable dt3 = new DataTable();
                adp3.Fill(dt3);

                if(dt3.Rows.Count == null || dt3.Rows.Count == 0)
                {
                    BtnINformaciones.Visible = false;
                }
                else
                {
                    BtnINformaciones.Visible = true;

                    for (int i = 0; i < dt3.Rows.Count; i++)
                    {

                        if (dt3.Rows[i][21].ToString() == "Progreso")
                        {
                            LblPaisInfo.Text = dt3.Rows[i][14].ToString();

                            string CiudadCompleta = dt3.Rows[i][15].ToString();
                            string[] palabras = CiudadCompleta.Split(' ');

                            string SucusarlCompleta = dt3.Rows[i][16].ToString();
                            string TipoSucursal = SucusarlCompleta.Substring(9);

                            switch (TipoSucursal)
                            {
                                case "Principal":
                                    LblSucursalInfo.Text = "Main";
                                break;

                                case "Recibo":
                                    LblSucursalInfo.Text = "receive";
                                break;
                                    
                            }

                            if(dt3.Rows[i][19].ToString() == "" || dt3.Rows[i][20].ToString() == "")
                            {
                                LblLlegadaInfo.Text = "Wait..";
                                LblEstadoInfo.Text = "Wait..";
                            }

                            if (palabras.Length > 1)
                            {
                                LblCiudad.Text = palabras[0][0].ToString() + palabras[1][0].ToString();
                            }
                            else
                            {
                                LblCiudadInfo.Text = palabras[0][0].ToString() + palabras[0][1].ToString();
                            }
                        }
                    }
                }

                cnxn.Close();

                cnxn.Open();

                string consulta4 = "SELECT * FROM ProductosComprados where Usuario = '"+ Clases.EstadoSeccion.Nombre +"'";

                SqlCommand cmd4 = new SqlCommand(consulta4, cnxn);
                SqlDataAdapter adp4 = new SqlDataAdapter(cmd4);
                DataTable dt4 = new DataTable();
                adp4.Fill(dt4);

                for(int i = 0; i < dt4.Rows.Count; i++)
                {
                    int orden = i + 1;

                    string VestimentaOrdenada = orden.ToString() + "." + dt4.Rows[i][1].ToString();

                    ProductosComprado(VestimentaOrdenada);
                }

                cnxn.Close();
              

            }
            else
            {
                LblNotificar.Visible = true;
            }


            cnxn.Open();

            string consulta2 = "SELECT Pais FROM Sucursales";

            SqlCommand cmd2 = new SqlCommand(consulta2, cnxn);
            SqlDataAdapter adp2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            adp2.Fill(dt2);

            for(int i = 0; i < dt2.Rows.Count; i++)
            {
                CmbSucursales.Items.Add(dt2.Rows[i][0].ToString());
            }

            cnxn.Close() ;


            if(CmbSucursales.Text == string.Empty)
            {
                LblPais.Text = "...";
                LblSucursal.Text = "...";
                LblCiudad.Text = "...";
            }


        }

        private void guna2Panel2_Click(object sender, EventArgs e)
        {
            guna2Transition1.HideSync(PanelTarjeta);
            guna2Transition1.ShowSync(PanelTarjetaAtras);
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            Validaciones();
        }

        private void guna2TextBox7_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void guna2TextBox8_TextChanged(object sender, EventArgs e)
        {
            Validaciones();
        }

        private void PanelTarjetaAtras_Click(object sender, EventArgs e)
        {
            guna2Transition1.HideSync(PanelTarjetaAtras);
            guna2Transition1.ShowSync(PanelTarjeta);
        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }



        private void CmbSucursales_SelectedValueChanged(object sender, EventArgs e)
        {
           cnxn.Open() ;

            string consulta = "Select Pais, Ciudad, Tipo from Sucursales where Pais = '"+ CmbSucursales.Text +"'";

            SqlCommand cmd = new SqlCommand(consulta, cnxn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            string NombrePaisCompleto = dt.Rows[0][0].ToString();
            string[] Palabras = NombrePaisCompleto.Split(' ');

            LblPais.Text = Palabras[0][0].ToString() + Palabras[1][0].ToString();
            LblCiudad.Text = dt.Rows[0][1].ToString();
            LblSucursal.Text = dt.Rows[0][2].ToString();

            cnxn.Close();
        }

        private void BtnVaciar_Click(object sender, EventArgs e)
        {
           if(Clases.EstadoSeccion.Nombre != null)
           {
                if(ContenedorProductos.Controls.Count > 1)
                {
                    cnxn.Open();

                    string consulta = "DELETE FROM ProductosCarrito WHERE Usuario = '"+ Clases.EstadoSeccion.Nombre +"'";

                    SqlCommand cmd = new SqlCommand(consulta, cnxn);

                    cmd.ExecuteNonQuery();

                    ContenedorProductos.Controls.Clear();
                    ContenedorProductos.Controls.Add(LblNotificar);
                    LblNotificar.Text = "The cart is empty";
                    LblNotificar.Visible = true;

                    cnxn.Close();

                    VerificarCar();
                }
           }
        }

        DataTable RestarProducto;

        private void BtnComprar_Click(object sender, EventArgs e)
        {
            if(Clases.EstadoSeccion.Nombre != null)
            {
                if(ContenedorProductos.Controls.Count > 1)
                {
                    Validaciones();

                    cnxn.Open();

                    string consulta = "SELECT * FROM ProductosCarrito where Usuario = '" + Clases.EstadoSeccion.Nombre + "'";
                    SqlCommand cmd = new SqlCommand(consulta, cnxn);
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    cnxn.Close();

                    RestarProducto = dt;

                    cnxn.Open();

                    string consulta2 = "INSERT INTO ProductosComprados (Vestimenta, Tipo, Marca, Size, Color, Precio, Imagen, " +
                        "Cantidad, Usuario, NombreTarjeta, NumeroTarjeta, Cvc, Vencimiento, Pais, Ciudad, SucursalEnvio, HoraDeCompra, " +
                        "FechaDeCompra, EstadoLLegada) VALUES (@vVestimenta, @vTipo, @vMarca, @vSize, " +
                        "@vColor, @vPrecio, @vImagen, @vCantidad, @vUsuario, @vNombreTarjeta, @vNumeroTarjeta, @vCvc, @vVencimiento, @vPais, @vCiudad, " +
                        "@vSucursalEnvio, @vHoraDeCompra, @vFechaDeCompra, @vEstadoLLegada)";

                    SqlCommand cmd2 = new SqlCommand(consulta2, cnxn);
                    cmd2.Parameters.Add("@vVestimenta", SqlDbType.NVarChar);
                    cmd2.Parameters.Add("@vTipo", SqlDbType.NVarChar);
                    cmd2.Parameters.Add("@vMarca", SqlDbType.NVarChar);
                    cmd2.Parameters.Add("@vSize", SqlDbType.NVarChar);
                    cmd2.Parameters.Add("@vColor", SqlDbType.NVarChar);
                    cmd2.Parameters.Add("@vPrecio", SqlDbType.Int);
                    cmd2.Parameters.Add("@vImagen", SqlDbType.VarBinary);
                    cmd2.Parameters.Add("@vCantidad", SqlDbType.Int);
                    cmd2.Parameters.Add("@vUsuario", SqlDbType.NVarChar);
                    cmd2.Parameters.Add("@vNombreTarjeta", SqlDbType.NVarChar);
                    cmd2.Parameters.Add("@vNumeroTarjeta", SqlDbType.NVarChar);
                    cmd2.Parameters.Add("@vCvc", SqlDbType.Int);
                    cmd2.Parameters.Add("@vVencimiento", SqlDbType.NVarChar);
                    cmd2.Parameters.Add("@vPais", SqlDbType.NVarChar);
                    cmd2.Parameters.Add("@vCiudad", SqlDbType.NVarChar);
                    cmd2.Parameters.Add("@vSucursalEnvio", SqlDbType.NVarChar);
                    cmd2.Parameters.Add("@vHoraDeCompra", SqlDbType.Int);
                    cmd2.Parameters.Add("@vFechaDeCompra", SqlDbType.Date);
                    cmd2.Parameters.Add("@vEstadoLLegada", SqlDbType.NVarChar);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (Validacion)
                        {
                            // Restablecer el MemoryStream en cada iteración
                            MemoryStream memoria = new MemoryStream();

                            Byte[] archivo = (byte[])dt.Rows[i][7];
                            Stream imagen = new MemoryStream(archivo);

                            Image image = Image.FromStream(imagen);
                            image.Save(memoria, ImageFormat.Png);

                            string Valor = dt.Rows[i][8].ToString();
                            int ConValor = int.Parse(Valor);

                         
                            string ValorCvc = Cvc.Text;
                            int ConvCvc = int.Parse(ValorCvc);
                           

                            string ValorPrecio = dt.Rows[i][6].ToString();
                            int ConvPrecio = int.Parse(ValorPrecio);

                            // Asignar valores a los parámetros
                            cmd2.Parameters["@vVestimenta"].Value = dt.Rows[i][1].ToString();
                            cmd2.Parameters["@vTipo"].Value = dt.Rows[i][2].ToString();
                            cmd2.Parameters["@vMarca"].Value = dt.Rows[i][3].ToString();
                            cmd2.Parameters["@vSize"].Value = dt.Rows[i][4].ToString();
                            cmd2.Parameters["@vColor"].Value = dt.Rows[i][5].ToString();
                            cmd2.Parameters["@vPrecio"].Value = ConvPrecio;
                            cmd2.Parameters["@vImagen"].Value = memoria.GetBuffer();
                            cmd2.Parameters["@vCantidad"].Value = ConValor;
                            cmd2.Parameters["@vUsuario"].Value = Clases.EstadoSeccion.Nombre;
                            cmd2.Parameters["@vNombreTarjeta"].Value = TxtNombreTarjeta.Text;
                            cmd2.Parameters["@vNumeroTarjeta"].Value = PrimerosDigitos.Text + SegundosDigitos.Text + TercerosDigitos.Text + CuartosDigitos.Text;
                            cmd2.Parameters["@vCvc"].Value = ConvCvc;
                            cmd2.Parameters["@vVencimiento"].Value = TxtFechaTarjeta.Text;
                            cmd2.Parameters["@vPais"].Value = LblPais.Text;
                            cmd2.Parameters["@vCiudad"].Value = LblCiudad.Text;
                            cmd2.Parameters["@vSucursalEnvio"].Value = LblSucursal.Text;
                            cmd2.Parameters["@vHoraDeCompra"].Value = DateTime.Now.Hour;
                            cmd2.Parameters["@vFechaDeCompra"].Value = DateTime.Now.Date;
                            cmd2.Parameters["@vEstadoLLegada"].Value = "Progreso";
                        }

                        // Ejecutar la consulta
                        if(Validacion)
                        {
                            cmd2.ExecuteNonQuery();
                            
                        }
                    }

                    if (Validacion)
                    {
                        MessageBox.Show("Compra Exitosa");
                    }


                    cnxn.Close();



                    if (Validacion)
                    {
                        cnxn.Open();

                        string consulta3 = "DELETE FROM ProductosCarrito WHERE Usuario = '"+ Clases.EstadoSeccion.Nombre +"'";

                        SqlCommand cmd3 = new SqlCommand(consulta3, cnxn);

                        if (Validacion)
                        {
                            cmd3.ExecuteNonQuery();
                        }

                        ContenedorProductos.Controls.Clear();
                        ContenedorProductos.Controls.Add(LblNotificar);
                        LblNotificar.Text = "Successful purchase";
                        LblNotificar.Visible = true;

                        cnxn.Close();

                        VerificarCar();
                    }

                    if (Validacion)
                    {
                        cnxn.Open();

                        string consulta5 = "SELECT * FROM InfoAdmin";
                        SqlCommand cmd5 = new SqlCommand(consulta5, cnxn);
                        SqlDataAdapter adp5 = new SqlDataAdapter(cmd5);
                        DataTable dt5 = new DataTable();
                        adp5.Fill(dt5);



                        for (int i = 0; i < RestarProducto.Rows.Count; i++)
                        {
                            string consulta4 = "UPDATE InfoAdmin SET CantidadTotal = @vCantidadTotal where NombreProducto = '"+ RestarProducto.Rows[i][1].ToString() +"'";

                            SqlCommand cmd4 = new SqlCommand(consulta4, cnxn);
                            cmd4.Parameters.Add("@vCantidadTotal", SqlDbType.Int);

                            string valor = RestarProducto.Rows[i][8].ToString();
                            int conv = int.Parse(valor);

                            string All = dt5.Rows[i][2].ToString();
                            int convAll = int.Parse(All);

                            int rst = convAll - conv;

                            cmd4.Parameters["@vCantidadTotal"].Value = rst;

                            cmd4.ExecuteNonQuery();
                        }

                        cnxn.Close();
                    }
                }


            }
        }

        public void VerificarCar()
        {
            cnxn.Open();

            string consulta2 = "SELECT * FROM ProductosCarrito WHERE Usuario = '"+ Clases.EstadoSeccion.Nombre +"'";

            SqlCommand cmd2 = new SqlCommand(consulta2, cnxn);
            SqlDataAdapter adp2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            adp2.Fill(dt2);

            cnxn.Close();

            Clases.Prodcutos.CantidadDeProductosEnCarrito = dt2.Rows.Count;
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
        
        }

        private void guna2GradientButton1_Click_1(object sender, EventArgs e)
        {
            Apagar.HideSync(PanelContenedor);
            Mostrar.ShowSync(PanelInformaciones);
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Apagar.HideSync(PanelInformaciones);
            Mostrar.ShowSync(PanelContenedor);

            
            
        }

        public bool Validacion;

        public void Validaciones()
        {

            if (PrimerosDigitos.Text.Length == 4
                && SegundosDigitos.Text.Length == 4
                && TercerosDigitos.Text.Length == 4
                && CuartosDigitos.Text.Length == 4
                && Cvc.Text.Length == 3
                && TxtNombreTarjeta.Text != string.Empty)
                
            {
                Validacion = true;
            }
            else
            {
                Validacion = false;
            }

            if (PrimerosDigitos.Text.Length < 4)
            {
                PrimerosDigitos.BorderColor = Color.Red;
                //Validacion = false;
            }
            else
            {
                PrimerosDigitos.BorderColor = Color.FromArgb(160, 250, 229);
                //Validacion = true;
            }

            if (SegundosDigitos.Text.Length < 4)
            {
                SegundosDigitos.BorderColor = Color.Red;
                //Validacion = false;
            }
            else
            {
                SegundosDigitos.BorderColor = Color.FromArgb(160, 250, 229);
                //Validacion = true;
            }


            if (TercerosDigitos.Text.Length < 4)
            {
                TercerosDigitos.BorderColor = Color.Red;
                //Validacion = false;
            }
            else
            {
                TercerosDigitos.BorderColor = Color.FromArgb(160, 250, 229);
                //Validacion = true;
            }

            if (CuartosDigitos.Text.Length < 4)
            {
                CuartosDigitos.BorderColor = Color.Red;
                //Validacion = false;
            }
            else
            {
                CuartosDigitos.BorderColor = Color.FromArgb(160, 250, 229);
                //Validacion = true;
            }

            if (TxtNombreTarjeta.Text == string.Empty)
            {
                TxtNombreTarjeta.BorderColor = Color.Red;
                //Validacion = false;
            }
            else
            {
                TxtNombreTarjeta.BorderColor = Color.FromArgb(160, 250, 229);
                //Validacion = true;
            }

            if(Cvc.Text.Length < 3)
            {
                ImgClick.Visible = true;
                //Validacion = false;
                Cvc.BorderColor = Color.Red;
            
                if (PrimerosDigitos.Text.Length == 4
                    && SegundosDigitos.Text.Length == 4 
                    && TercerosDigitos.Text.Length == 4 
                    && CuartosDigitos.Text.Length == 4)
                {
                    MessageBox.Show("add the cvc code");
                }
            }
            else
            {
                ImgClick.Visible = false;
                Cvc.BorderColor = Color.FromArgb(160, 250, 229);
               // Validacion = true;
            }
        }

        private void SegundosDigitos_TextChanged(object sender, EventArgs e)
        {
            Validaciones();
        }

        private void TercerosDigitos_TextChanged(object sender, EventArgs e)
        {
            Validaciones();
        }

        private void CuartosDigitos_TextChanged(object sender, EventArgs e)
        {
            Validaciones();
        }

        private void TxtNombreTarjeta_TextChanged(object sender, EventArgs e)
        {
            Validaciones();
        }

        private void TxtFechaTarjeta_TextChanged(object sender, EventArgs e)
        {
            Validaciones();
        }

        private void PrimerosDigitos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar >= 48) && (e.KeyChar <= 57))
            {    
                timer1.Stop();
            }
            else
            {
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (PrimerosDigitos.Text.Length != 4)
            {
                PrimerosDigitos.Clear();
            }
            if (SegundosDigitos.Text.Length != 4)
            {
                SegundosDigitos.Clear();
            }
            if (TercerosDigitos.Text.Length != 4)
            {
                TercerosDigitos.Clear();
            }
            if (CuartosDigitos.Text.Length != 4)
            {
                CuartosDigitos.Clear();
            }
            if (Cvc.Text.Length != 3)
            {
                Cvc.Clear();
            }
        }

        private void SegundosDigitos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48) && (e.KeyChar <= 57))
            {
                timer1.Stop();
            }
            else
            {
                timer1.Start();
            }
        }

        private void TercerosDigitos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48) && (e.KeyChar <= 57))
            {
                timer1.Stop();
            }
            else
            {
                timer1.Start();
            }
        }

        private void CuartosDigitos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48) && (e.KeyChar <= 57))
            {
                timer1.Stop();
            }
            else
            {
                timer1.Start();
            }
        }

        private void Cvc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48) && (e.KeyChar <= 57))
            {
                timer1.Stop();
            }
            else
            {
                timer1.Start();
            }
        }
    }
}
