using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Gestor_ArticulosTR
{
    public partial class ArticuloCientifico : System.Web.UI.Page
    {
        private string cadenaConexion = ConfigurationManager.ConnectionStrings["ConexionTR"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarRevistas();
                CargarAutores();
                CargarArticulos();
            }
        }

        #region Carga de datos para UI

        private void CargarRevistas()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cadenaConexion))
                {
                    string sql = "SELECT RevistaID, Nombre FROM TR_Revista ORDER BY Nombre";
                    using (SqlDataAdapter da = new SqlDataAdapter(sql, con))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        ddlRevistas.DataSource = dt;
                        ddlRevistas.DataValueField = "RevistaID";
                        ddlRevistas.DataTextField = "Nombre";
                        ddlRevistas.DataBind();

                        ddlRevistas.Items.Insert(0, new System.Web.UI.WebControls.ListItem("-- Seleccione revista --", "0"));
                    }
                }
            }
            catch (Exception ex)
            {
                MostrarMensaje("Error cargando revistas: " + ex.Message, true);
            }
        }

        private void CargarAutores()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cadenaConexion))
                {
                    string sql = "SELECT AutorID, (Nombre + ' ' + Apellido) AS NombreCompleto FROM TR_Autor ORDER BY Nombre";
                    using (SqlDataAdapter da = new SqlDataAdapter(sql, con))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        ddlAutores.DataSource = dt;
                        ddlAutores.DataValueField = "AutorID";
                        ddlAutores.DataTextField = "NombreCompleto";
                        ddlAutores.DataBind();

                        ddlAutores.Items.Insert(0, new System.Web.UI.WebControls.ListItem("-- Seleccione autor --", "0"));
                    }
                }
            }
            catch (Exception ex)
            {
                MostrarMensaje("Error cargando autores: " + ex.Message, true);
            }
        }

        private void CargarArticulos()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cadenaConexion))
                {
                    string query = @"
                        SELECT TOP 10 
                            A.Titulo AS Titulo,
                            CONCAT(AU.Nombre, ' ', AU.Apellido) AS Autor,
                            R.Nombre AS Revista,
                            A.AnioPublicacion AS Anio
                        FROM TR_Articulo A
                        INNER JOIN TR_ArticuloAutor AA ON A.ArticuloID = AA.ArticuloID
                        INNER JOIN TR_Autor AU ON AA.AutorID = AU.AutorID
                        INNER JOIN TR_Revista R ON A.RevistaID = R.RevistaID
                        ORDER BY A.ArticuloID DESC";

                    using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        gvArticulos.DataSource = dt;
                        gvArticulos.DataBind();
                    }
                }
            }
            catch (Exception ex)
            {
                MostrarMensaje("Ocurrió un error al cargar los artículos: " + ex.Message, true);
            }
        }

        #endregion

        #region Eventos de botones (handlers)

        protected void btnGuardarRevista_Click(object sender, EventArgs e)
        {
            string nombre = txtRevistaNombre.Text.Trim();

            if (string.IsNullOrEmpty(nombre))
            {
                MostrarMensaje("Ingrese el nombre de la revista.", true);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(cadenaConexion))
                {
                    string sql = "INSERT INTO TR_Revista (Nombre) VALUES (@Nombre)";
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                MostrarMensaje("Revista guardada correctamente.", false);
                txtRevistaNombre.Text = "";
                CargarRevistas();
            }
            catch (Exception ex)
            {
                MostrarMensaje("Error al guardar revista: " + ex.Message, true);
            }
        }

        protected void btnGuardarAutor_Click(object sender, EventArgs e)
        {
            string nombre = txtAutorNombre.Text.Trim();
            string apellido = txtAutorApellido.Text.Trim();
            string orcid = txtORCID.Text.Trim();
            string afiliacion = txtAfiliacion.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido))
            {
                MostrarMensaje("Ingrese nombre y apellido del autor.", true);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(cadenaConexion))
                {
                    string sql = @"INSERT INTO TR_Autor (Nombre, Apellido, ORCID, Afiliacion)
                                   VALUES (@Nombre, @Apellido, @ORCID, @Afiliacion)";
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@Apellido", apellido);
                        cmd.Parameters.AddWithValue("@ORCID", string.IsNullOrEmpty(orcid) ? (object)DBNull.Value : orcid);
                        cmd.Parameters.AddWithValue("@Afiliacion", string.IsNullOrEmpty(afiliacion) ? (object)DBNull.Value : afiliacion);

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                MostrarMensaje("Autor guardado correctamente.", false);
                txtAutorNombre.Text = txtAutorApellido.Text = txtORCID.Text = txtAfiliacion.Text = "";
                CargarAutores();
            }
            catch (SqlException sqlEx) when (sqlEx.Number == 2627) // unique constraint (ORCID)
            {
                MostrarMensaje("El ORCID ya existe en la base de datos.", true);
            }
            catch (Exception ex)
            {
                MostrarMensaje("Error al guardar autor: " + ex.Message, true);
            }
        }

        protected void btnGuardarArticulo_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text.Trim();
            string resumen = txtResumen.Text.Trim();
            string doi = txtDOI.Text.Trim();
            int revistaId = 0;
            int autorId = 0;
            int anio = 0;

            int.TryParse(ddlRevistas.SelectedValue, out revistaId);
            int.TryParse(ddlAutores.SelectedValue, out autorId);
            int.TryParse(txtAnio.Text.Trim(), out anio);

            if (string.IsNullOrEmpty(titulo))
            {
                MostrarMensaje("Ingrese el título del artículo.", true);
                return;
            }
            if (revistaId == 0)
            {
                MostrarMensaje("Seleccione una revista.", true);
                return;
            }
            if (autorId == 0)
            {
                MostrarMensaje("Seleccione un autor (autor principal).", true);
                return;
            }
            if (anio == 0)
            {
                MostrarMensaje("Ingrese un año de publicación válido (número).", true);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(cadenaConexion))
                {
                    con.Open();
                    using (SqlTransaction tran = con.BeginTransaction())
                    {
                        try
                        {
                            // Insertar artículo y obtener ArticuloID
                            string sqlInsertArticulo = @"
                                INSERT INTO TR_Articulo (Titulo, Resumen, AnioPublicacion, DOI, RevistaID)
                                OUTPUT INSERTED.ArticuloID
                                VALUES (@Titulo, @Resumen, @Anio, @DOI, @RevistaID)";
                            int articuloId;
                            using (SqlCommand cmd = new SqlCommand(sqlInsertArticulo, con, tran))
                            {
                                cmd.Parameters.AddWithValue("@Titulo", titulo);
                                cmd.Parameters.AddWithValue("@Resumen", string.IsNullOrEmpty(resumen) ? (object)DBNull.Value : resumen);
                                cmd.Parameters.AddWithValue("@Anio", anio);
                                cmd.Parameters.AddWithValue("@DOI", string.IsNullOrEmpty(doi) ? (object)DBNull.Value : doi);
                                cmd.Parameters.AddWithValue("@RevistaID", revistaId);

                                articuloId = Convert.ToInt32(cmd.ExecuteScalar());
                            }

                            // Insertar relación Articulo-Autor (orden 1 por defecto)
                            string sqlInsertArticuloAutor = @"
                                INSERT INTO TR_ArticuloAutor (ArticuloID, AutorID, Orden)
                                VALUES (@ArticuloID, @AutorID, @Orden)";
                            using (SqlCommand cmd2 = new SqlCommand(sqlInsertArticuloAutor, con, tran))
                            {
                                cmd2.Parameters.AddWithValue("@ArticuloID", articuloId);
                                cmd2.Parameters.AddWithValue("@AutorID", autorId);
                                cmd2.Parameters.AddWithValue("@Orden", 1);
                                cmd2.ExecuteNonQuery();
                            }

                            tran.Commit();
                        }
                        catch
                        {
                            tran.Rollback();
                            throw;
                        }
                    }
                }

                MostrarMensaje("Artículo guardado correctamente.", false);
                LimpiarFormularioArticulo();
                CargarArticulos();
            }
            catch (SqlException sqlEx) when (sqlEx.Number == 2627) // unique constraint e.g. DOI
            {
                MostrarMensaje("El DOI ya existe en la base de datos.", true);
            }
            catch (Exception ex)
            {
                MostrarMensaje("Error al guardar artículo: " + ex.Message, true);
            }
        }

        #endregion

        #region Utilidades

        private void MostrarMensaje(string texto, bool esError)
        {
            lblMensaje.Text = texto;
            lblMensaje.CssClass = esError ? "h6 text-danger" : "h6 text-success";
        }

        private void LimpiarFormularioArticulo()
        {
            txtTitulo.Text = "";
            txtResumen.Text = "";
            txtAnio.Text = "";
            txtDOI.Text = "";
            if (ddlRevistas.Items.Count > 0) ddlRevistas.SelectedIndex = 0;
            if (ddlAutores.Items.Count > 0) ddlAutores.SelectedIndex = 0;
        }

        #endregion
    }
}


