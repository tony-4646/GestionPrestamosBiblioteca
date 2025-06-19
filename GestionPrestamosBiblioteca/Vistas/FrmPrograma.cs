using MySql.Data.MySqlClient;
using System;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace GestionPrestamosBiblioteca.Vistas
{
    public partial class FrmPrograma : Form
    {
        private readonly Aplicacion.UsuarioService _usuarioService = new Aplicacion.UsuarioService();
        private readonly Aplicacion.LibroService _libroService = new Aplicacion.LibroService();
        private readonly Aplicacion.PrestamoService _prestamoService = new Aplicacion.PrestamoService();

        public FrmPrograma()
        {
            InitializeComponent();
        }
        private void FrmPrograma_Load(object sender, EventArgs e)
        {
            this.cargaLista();
        }

        public void cargaLista()
        {
            lstUsuarios.DataSource = _usuarioService.todos().ToList();
            lstUsuarios.DisplayMember = "u_nombres";
            lstUsuarios.ValueMember = "id_usuario";

            lstLibros.DataSource = _libroService.todos().ToList();
            lstLibros.DisplayMember = "l_titulo";
            lstLibros.ValueMember = "id_libro";

            lstPrestamos.Items.Clear();
            var prestamos = _prestamoService.todos();
            foreach (var p in prestamos)
            {
                string devuelto = p.p_fechadevolucion.HasValue ? p.p_fechadevolucion.Value.ToShortDateString() : "No devuelto";
                lstPrestamos.Items.Add($"{p.id_prestamo}: {p.nombre_usuario} - {p.titulo_libro} - Prestado: {p.p_fechaprestamo.ToShortDateString()} - Devuelto: {devuelto}");
            }

            CargarUsuarios();
            CargarLibros();
        }

        private void FrmPrograma_Activated(object sender, EventArgs e)
        {
            this.cargaLista();
        }

        //----------------------------libros------------------------------------
        private void btnInsertarLibro_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTituloLibro.Text) || string.IsNullOrWhiteSpace(txtTituloLibro.Text))
                {
                    MessageBox.Show("¡Proporciona un titulo!");
                }
                else
                {
                    var book = new Datos.LibroDTO
                    {
                        l_titulo = txtTituloLibro.Text.Trim(),
                        l_fecha = txtFechaLibro.Text.Trim(),
                        l_autor = txtAutorLibro.Text.Trim(),
                        l_isbn = txtIsbnLibro.Text.Trim()
                    };
                    if (_libroService.insertar(book) == "ok")
                    {
                        MessageBox.Show("Se guardo con exito");
                        this.cargaLista();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error al guadar");
                    }
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                {
                    MessageBox.Show("¡Isbn en uso! prueba otra");
                }
                else
                {
                    MessageBox.Show("Error desconocido");
                }

            }
        }

        private void btnEliminarLibro_Click(object sender, EventArgs e)
        {
            if (lstLibros.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un libro de la lista");
                return;
            }
            if (_libroService.elimnar(Convert.ToInt32(lstLibros.SelectedValue)) == "ok")
            {
                MessageBox.Show("Se elimino con exito");
                this.cargaLista();
            }
            else
            {
                MessageBox.Show("Ocurrio un error al eliminar");
            }
        }

        private void lstLibros_SelectedIndexChanged(object sender, EventArgs e)
        {
            Datos.LibroDTO seleccion = (Datos.LibroDTO)lstLibros.SelectedItem;
            txtTituloLibro.Text = seleccion.l_titulo;
            txtFechaLibro.Text = seleccion.l_fecha;
            txtAutorLibro.Text = seleccion.l_autor;
            txtIsbnLibro.Text = seleccion.l_isbn;
        }

        private void btnLimpiarLibro_Click(object sender, EventArgs e)
        {
            txtTituloLibro.Text = "";
            txtFechaLibro.Text = "";
            txtAutorLibro.Text = "";
            txtIsbnLibro.Text = "";
        }

        //----------------------------Usuario------------------------------------
        private void btnInsertarUsuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTituloLibro.Text) || string.IsNullOrWhiteSpace(txtTituloLibro.Text))
            {
                MessageBox.Show("¡Proporciona un Nombre de cliente!");
            }
            else
            {
                var user = new Datos.UsuarioDTO
                {
                    u_nombres = txtNombresUsuario.Text.Trim(),
                    u_direccion = txtDireccionUsuario.Text.Trim()
                };
                if (_usuarioService.insertar(user) == "ok")
                {
                    MessageBox.Show("Se guardo con exito");
                    this.cargaLista();
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al guadar");
                }
            }

        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (lstUsuarios.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un usaurio de la lista");
                return;
            }
                if (_usuarioService.elimnar(Convert.ToInt32(lstUsuarios.SelectedValue)) == "ok")
                {
                    MessageBox.Show("Se elimino con exito");
                    this.cargaLista();
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al eliminar");
                }
        }

        private void lstUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {

                Datos.UsuarioDTO seleccion = (Datos.UsuarioDTO)lstUsuarios.SelectedItem;
                txtNombresUsuario.Text = seleccion.u_nombres;
                txtDireccionUsuario.Text = seleccion.u_direccion;
        }

        private void btnLimpiarUsuario_Click(object sender, EventArgs e)
        {
            txtNombresUsuario.Text = "";
            txtDireccionUsuario.Text = "";
        }

        //------------------------Prestar/devolver--------------------------------

        private void btnPrestamoRegistrar_Click(object sender, EventArgs e)
        {
            Datos.PrestamoDTO prestamo = new Datos.PrestamoDTO
            {
                id_usuario = Convert.ToInt32(cmbPrestamoUsuarios.SelectedValue),
                id_libro = Convert.ToInt32(cmbPrestamoLibros.SelectedValue),
                p_fechaprestamo = dtpPrestamoFecha.Value.Date
            };

            string respuesta = _prestamoService.insertar(prestamo);
            if (respuesta == "ok")
            {
                MessageBox.Show("Prestamo registrado correctamente");
            }
            else
            {
                MessageBox.Show("Ocurrio un error al registrar");
            }
            this.cargaLista();
        }

        private void btnPrestamoDevolver_Click(object sender, EventArgs e)
        {
            if (lstPrestamos.SelectedItem != null)
            {
                string texto = lstPrestamos.SelectedItem.ToString();
                int idPrestamo = Convert.ToInt32(texto.Split(':')[0]);

                DateTime fecha = DateTime.Now.Date;
                string respuesta = _prestamoService.devolver(idPrestamo, fecha);
                if (respuesta == "ok")
                {
                    MessageBox.Show("Prestamo devuelto correctamente");
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al devolver");
                }
                this.cargaLista();
            }
            else
            {
                MessageBox.Show("Seleccione un prestamo de la lista");
            }
        }

        private void CargarUsuarios()
        {
            cmbPrestamoUsuarios.DataSource = _usuarioService.todos();
            cmbPrestamoUsuarios.DisplayMember = "u_nombres";
            cmbPrestamoUsuarios.ValueMember = "id_usuario";
        }

        private void CargarLibros()
        {
            cmbPrestamoLibros.DataSource = _libroService.todos();
            cmbPrestamoLibros.DisplayMember = "l_titulo";
            cmbPrestamoLibros.ValueMember = "id_libro";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            var FrmAyuda = new Vistas.FrmAyuda();
            FrmAyuda.Show();
        }
    }
}
