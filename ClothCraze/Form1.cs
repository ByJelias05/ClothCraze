using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using ClothCraze.AddProducts;
using System.Security.Cryptography.X509Certificates;

namespace ClothCraze
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

        SqlConnection cnxn = new SqlConnection("Server=localhost; database=ClothCraze; INTEGRATED SECURITY = true");

        private void Form1_Load(object sender, EventArgs e)
        {
            Clases.Tamaños.size = this.Size;


            TodosLosProdcutos();
        }

        public void TodosLosProdcutos()
        {
            cnxn.Open();

            string consulta = "SELECT Vestimenta, Precio, Imagen FROM Productos";

            SqlCommand cmd = new SqlCommand(consulta, cnxn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Byte[] archivo = (byte[])dt.Rows[i][2];
                Stream imagen = new MemoryStream(archivo);

                Image image = Image.FromStream(imagen);

                Producto(image, dt.Rows[i][1].ToString(), dt.Rows[i][0].ToString());
            }

            cnxn.Close();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
		{
            MessageBox.Show("Existen "+ PanelFillCart.Controls.Count.ToString() +" controladores");

            //MessageBox.Show(CantidadFav.ToString());

        }

		

		private void Maximizar_Click(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Maximized)
			{
				PanelContenedorProductos.Padding = new System.Windows.Forms.Padding(100, 0, 50, 0);
                Clases.Tamaños.size = this.Size;
            }
			else
			{
				PanelContenedorProductos.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
                Clases.Tamaños.size = this.Size;
            }
		}

		public void Modal()
		{
            Form Sombra = new Form();

            using (Modales.Modal Modal = new Modales.Modal())
            {
                Sombra.StartPosition = FormStartPosition.CenterScreen;
                Sombra.FormBorderStyle = FormBorderStyle.None;
                Sombra.Size = this.Size;
                Sombra.Opacity = .50;
                Sombra.BackColor = Color.Black;
                Sombra.ShowInTaskbar = false;
                Sombra.Show();
                Modal.Owner = Sombra;

                Modal.ShowDialog();
                Sombra.Dispose();
            }
        }

        public void ModalSucursal()
        {
            Form Sombra = new Form();

            using (Modales.Sucursales Modal = new Modales.Sucursales())
            {
                Sombra.StartPosition = FormStartPosition.CenterScreen;
                Sombra.FormBorderStyle = FormBorderStyle.None;
                Sombra.Size = this.Size;
                Sombra.Opacity = .50;
                Sombra.BackColor = Color.Black;
                Sombra.ShowInTaskbar = false;
                Sombra.Show();
                Modal.Owner = Sombra;

                Modal.ShowDialog();
                Sombra.Dispose();
            }
        }

        public void ModalCompras()
        {
            Form Sombra = new Form();

            using (Modales.Compras Modal = new Modales.Compras())
            {
                Sombra.StartPosition = FormStartPosition.CenterScreen;
                Sombra.FormBorderStyle = FormBorderStyle.None;
                Sombra.Size = this.Size;
                Sombra.Opacity = .50;
                Sombra.BackColor = Color.Black;
                Sombra.ShowInTaskbar = false;
                Sombra.Show();
                Modal.Owner = Sombra;

                Modal.ShowDialog();
                Sombra.Dispose();
            }
        }

        public void ModalReporte()
        {
            Form Sombra = new Form();

            using (Modales.Reportes Modal = new Modales.Reportes())
            {
                Sombra.StartPosition = FormStartPosition.CenterScreen;
                Sombra.FormBorderStyle = FormBorderStyle.None;
                Sombra.Size = this.Size;
                Sombra.Opacity = .50;
                Sombra.BackColor = Color.Black;
                Sombra.ShowInTaskbar = false;
                Sombra.Show();
                Modal.Owner = Sombra;

                Modal.ShowDialog();
                Sombra.Dispose();
            }
        }

        private void BtnMisOrdenes_Click(object sender, EventArgs e)
        {
            ModalCompras();
        }

        private void BtnSucursales_Click(object sender, EventArgs e)
        {
           ModalSucursal();
        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
			ModalReporte();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           

                if (WindowState == FormWindowState.Minimized)
                {
                    Clases.Ocultar.EstadoPantalla = true;
                }
                else
                {
                    Clases.Ocultar.EstadoPantalla = false;
                }


                if(Clases.EstadoSeccion.TipoUsuario != null)
                {
                    if(Clases.EstadoSeccion.TipoUsuario == "Administrador")
                    {
                       this.Hide();
                    }
                }


              if(Clases.Filtro.EstadoFiltrado == true)
              {
                    PanelContenedorProductos.Controls.Clear();

                    cnxn.Open();

                    string consulta = "select * from Productos";

                    SqlCommand cmd = new SqlCommand(consulta, cnxn);
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);

                    cnxn.Close();

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Byte[] archivo = (byte[])dt.Rows[i][7];
                        Stream imagen = new MemoryStream(archivo);

                        Image image = Image.FromStream(imagen);


                        if(dt.Rows[i][2].ToString() == Clases.Filtro.TipoVestimenta)
                        {

                            if (dt.Rows[i][3].ToString() == Clases.Filtro.MarcaVestimenta)
                            {
                                Producto(image, dt.Rows[i][6].ToString(), dt.Rows[i][1].ToString());

                                
                            }

                            if (dt.Rows[i][4].ToString() == Clases.Filtro.SizeVestimenta)
                            {
                                Producto(image, dt.Rows[i][6].ToString(), dt.Rows[i][1].ToString());
                            }

                            if (dt.Rows[i][5].ToString() == Clases.Filtro.ColorVestimenta)
                            {
                                Producto(image, dt.Rows[i][6].ToString(), dt.Rows[i][1].ToString());
                            }

                        }
                   

                        
                    }

                  

                    //Esto es para que no suceda un spam de los productos con la marca que se escoge//
                    /*->*/
                    Clases.Filtro.EstadoFiltrado = false;


               
                    
              }

        }

        public void ProductCart(Image imagen, string nombre, int id)
        {
            var component = new AddProducts.AddCart();
            PanelFillCart.Controls.Add(component);
            component.Dock = DockStyle.Top;
            component.BringToFront();

            component.ImagenVestimenta = imagen;
            component.NombreVestimenta = nombre;
            component.ID = id;
        }

        public void ProductFavorite(Image imagen, string nombre, int id)
        {
            var component = new AddProducts.AddFavorite();
            PanelFillFav.Controls.Add(component);
            component.Dock = DockStyle.Top;
            component.BringToFront();

            component.ImagenVestimenta = imagen;
            component.NombreVestimenta = nombre;
            component.ID = id;
        }

        public int CantidadFav;
        

        public void MostrarProducts()
        {
            if (Clases.EstadoSeccion.Nombre != null)
            {
                //Mostrar productos de carrito

                cnxn.Open();

                string consulta = "SELECT * FROM ProductosCarrito WHERE Usuario = '"+ Clases.EstadoSeccion.Nombre +"'";

                SqlCommand cmd = new SqlCommand(consulta, cnxn);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                cnxn.Close();   

                if(dt.Rows.Count >= 1)
                {
                    PanelNoProductos2.Visible = false;

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Byte[] archivo = (byte[])dt.Rows[i][7];
                        Stream imagen = new MemoryStream(archivo);

                        Image image = Image.FromStream(imagen);

                        string ObtenerID = dt.Rows[i][0].ToString();
                        int ID = int.Parse(ObtenerID);

                        ProductCart(image, dt.Rows[i][1].ToString(), ID);
                    }
                }
                else
                {
                    PanelNoProductos2.Visible = true;
                }

         

            }

        }

        public void MostrarProducts1()
        {
            if (Clases.EstadoSeccion.Nombre != null)
            {
               

                cnxn.Open();

                string consulta2 = "SELECT * FROM ProductosFavoritos WHERE Usuario = '"+ Clases.EstadoSeccion.Nombre +"'";

                SqlCommand cmd2 = new SqlCommand(consulta2, cnxn);
                SqlDataAdapter adp2 = new SqlDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                adp2.Fill(dt2);

                cnxn.Close();


                if (dt2.Rows.Count >= 1)
                {
                    PanelNoProductos1.Visible = false;

                    for (int i = 0; i < dt2.Rows.Count; i++)
                    {
                        Byte[] archivo = (byte[])dt2.Rows[i][7];
                        Stream imagen = new MemoryStream(archivo);

                        Image image = Image.FromStream(imagen);

                        string ObtenerID = dt2.Rows[i][0].ToString();
                        int ID = int.Parse(ObtenerID);

                        ProductFavorite(image, dt2.Rows[i][1].ToString(), ID);
                    }
                }
                else
                {
                    PanelNoProductos1.Visible = true;
                }

            }

        }


        public void Producto(Image imagen, string precio, string vestimenta)
        {
            var producto = new Products.Products();
            PanelContenedorProductos.Controls.Add(producto);

            producto.ImagenVestimenta = imagen;
            producto.NombreVestimenta = vestimenta;
            producto.PrecioVestimenta = precio;
        }

        private void BtnTodo_Click(object sender, EventArgs e)
        {
            PanelContenedorProductos.Controls.Clear();

            if (PanelContenedorProductos.Controls.Count == 0)
            {
                TodosLosProdcutos();
            }

            Clases.Filtro.TipoVestimenta = BtnTodo.Tag.ToString();
        }

        private void BtnTodo_Leave(object sender, EventArgs e)
        {
            
        }

        private void btnGorras_Click(object sender, EventArgs e)
        {
            VerFiltros();
            PanelContenedorProductos.Controls.Clear();

            if (PanelContenedorProductos.Controls.Count == 0)
            {
                cnxn.Open();

                string consulta = "SELECT Vestimenta, Precio, Imagen FROM Productos WHERE Tipo = '"+ btnGorras.Tag.ToString() +"'";

                SqlCommand cmd = new SqlCommand(consulta, cnxn);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adp.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Byte[] archivo = (byte[])dt.Rows[i][2];
                    Stream imagen = new MemoryStream(archivo);

                    Image image = Image.FromStream(imagen);

                    Producto(image, dt.Rows[i][1].ToString(), dt.Rows[i][0].ToString());
                }

                cnxn.Close();
            }

            Clases.Filtro.TipoVestimenta = btnGorras.Tag.ToString();
         
        }

        public void VerFiltros()
        {
            filtroColor.Enabled = true;    
            filtroSize.Enabled = true;
            filtroMarca.Enabled = true;
        }

        private void btnGorras_Leave(object sender, EventArgs e)
        {
          
        }

        private void BtnCamisetas_Click(object sender, EventArgs e)
        {
            VerFiltros();
            PanelContenedorProductos.Controls.Clear();

            if (PanelContenedorProductos.Controls.Count == 0)
            {
                cnxn.Open();

                string consulta = "SELECT Vestimenta, Precio, Imagen FROM Productos WHERE Tipo = '"+ BtnCamisetas.Tag.ToString() +"'";

                SqlCommand cmd = new SqlCommand(consulta, cnxn);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adp.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Byte[] archivo = (byte[])dt.Rows[i][2];
                    Stream imagen = new MemoryStream(archivo);

                    Image image = Image.FromStream(imagen);

                    Producto(image, dt.Rows[i][1].ToString(), dt.Rows[i][0].ToString());
                }

                cnxn.Close();
            }

            Clases.Filtro.TipoVestimenta = BtnCamisetas.Tag.ToString();
        }

        private void BtnPantalones_Click(object sender, EventArgs e)
        {
            VerFiltros();
            PanelContenedorProductos.Controls.Clear();

            if (PanelContenedorProductos.Controls.Count == 0)
            {
                cnxn.Open();

                string consulta = "SELECT Vestimenta, Precio, Imagen FROM Productos WHERE Tipo = '"+ BtnPantalones.Tag.ToString() +"'";

                SqlCommand cmd = new SqlCommand(consulta, cnxn);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adp.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Byte[] archivo = (byte[])dt.Rows[i][2];
                    Stream imagen = new MemoryStream(archivo);

                    Image image = Image.FromStream(imagen);

                    Producto(image, dt.Rows[i][1].ToString(), dt.Rows[i][0].ToString());
                }

                cnxn.Close();
            }

            Clases.Filtro.TipoVestimenta = BtnPantalones.Tag.ToString();
        }

        private void BtnTenis_Click(object sender, EventArgs e)
        {
            VerFiltros();
            PanelContenedorProductos.Controls.Clear();

            if (PanelContenedorProductos.Controls.Count == 0)
            {
                cnxn.Open();

                string consulta = "SELECT Vestimenta, Precio, Imagen FROM Productos WHERE Tipo = '"+ BtnTenis.Tag.ToString() +"'";

                SqlCommand cmd = new SqlCommand(consulta, cnxn);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adp.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Byte[] archivo = (byte[])dt.Rows[i][2];
                    Stream imagen = new MemoryStream(archivo);

                    Image image = Image.FromStream(imagen);

                    Producto(image, dt.Rows[i][1].ToString(), dt.Rows[i][0].ToString());
                }

                cnxn.Close();
            }

            Clases.Filtro.TipoVestimenta = BtnTenis.Tag.ToString();

        }



        private void filtroMarca_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(Clases.Prodcutos.CantidadDeProductosEnCarrito != PanelFillCart.Controls.Count - 1)
            {
                PanelFillCart.Controls.Clear();
                MostrarProducts();
                timer2.Stop();
                Clases.Prodcutos.CantidadDeProductosEnCarrito = 99999;

                if(PanelFillCart.Controls.Count == 0)
                {
                    PanelFillCart.Controls.Add(PanelNoProductos2);
                }
            }

            if (Clases.Prodcutos.CantidadDeProductosEnFavorito != PanelFillFav.Controls.Count - 1)
            {
                PanelFillFav.Controls.Clear();
                MostrarProducts1();
                timer2.Stop();
                Clases.Prodcutos.CantidadDeProductosEnFavorito = 99999;


                if (PanelFillFav.Controls.Count == 0)
                {
                    PanelFillFav.Controls.Add(PanelNoProductos1);
                }
            }

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
           
            if (Clases.Prodcutos.CantidadDeProductosEnCarrito != 99999)
            {
                VerificarControladoresCarrito();
                if (Clases.Prodcutos.CantidadDeProductosEnCarrito != PanelFillCart.Controls.Count -1)
                {
                    timer2.Start();
                }
            }

            if (Clases.Prodcutos.ConfirmacionMuestraCarrito == true)
            {
                MostrarProducts();
                Clases.Prodcutos.ConfirmacionMuestraCarrito = false;
            }

            
        }

        private void Favorito_Tick(object sender, EventArgs e)
        {
            if (Clases.Prodcutos.CantidadDeProductosEnFavorito != 99999)
            {
                VerificarControladoresFavorito();
                if (Clases.Prodcutos.CantidadDeProductosEnFavorito != PanelFillFav.Controls.Count -1)
                {
                    timer2.Start();
                }
            }

            if (Clases.Prodcutos.ConfirmacionMuestraFavorito == true)
            {
                MostrarProducts1();
                Clases.Prodcutos.ConfirmacionMuestraFavorito = false;
            }

            

        }

        public void VerificarControladoresCarrito()
        {
            Control controlADejar = PanelFillCart.Controls[PanelNoProductos2.Name];

            // Elimina todos los controles del panel excepto el control específico
            foreach (Control control in PanelFillCart.Controls.OfType<Control>().ToList())
            {
                // Verifica si el control actual no es el que deseas conservar
                if (control != controlADejar)
                {
                    // Elimina el control del panel
                    PanelFillCart.Controls.Remove(control);
                    control.Dispose(); // Libera recursos del control eliminado
                }
            }
        }
        public void VerificarControladoresFavorito()
        {
            Control controlADejar = PanelFillFav.Controls[PanelNoProductos1.Name];

            // Elimina todos los controles del panel excepto el control específico
            foreach (Control control in PanelFillFav.Controls.OfType<Control>().ToList())
            {
                // Verifica si el control actual no es el que deseas conservar
                if (control != controlADejar)
                {
                    // Elimina el control del panel
                    PanelFillFav.Controls.Remove(control);
                    control.Dispose(); // Libera recursos del control eliminado
                }
            }
        }

        private void filtroMarca_Load(object sender, EventArgs e)
        {

        }

        private void Minimizar_Click(object sender, EventArgs e)
        {

        }
    }
}
