using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
// Namespace para acceso a SQL SERVER
using System.Data.SqlClient;    // SQL SERVER
using System.Data;              // DATOS GENERALES
using System.Configuration;     // ARCHIVOS DE CONFIG

namespace ServicioWebSUNAT
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        // Acceder a la cadena de conexion
        private static string sqlConnectionString = ConfigurationManager.ConnectionStrings["sqlConnectionString"].ConnectionString;

        [WebMethod(Description = "Listar Empresas con PA")]
        public DataSet listarEmpresas()
        {
            using (SqlConnection conexion = new SqlConnection(sqlConnectionString))
            {
                SqlCommand comando = new SqlCommand("spListarEmpresas", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataSet data = new DataSet();
                adapter.Fill(data);
                return data;
            }
        }

        [WebMethod(Description = "Buscar Empresa con PA")]
        public string[] buscarEmpresa(String RUC)
        {
            using (SqlConnection conexion = new SqlConnection(sqlConnectionString))
            {

                SqlCommand comando = new SqlCommand("spBuscarEmpresa", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@RUC", RUC);

                string[] arreglo = new string[2]; // Areglo que trae los datos de CodError y Mensaje
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataSet data = new DataSet();
                adapter.Fill(data);
                arreglo[0] = data.Tables[0].Rows[0]["CodError"].ToString();
                arreglo[1] = data.Tables[0].Rows[0]["Mensaje"].ToString();
                return arreglo;
            }
        }

        [WebMethod(Description = "Obtener datos de la Empresa con PA")]
        public string[] obtenerDatosEmpresa(String RUC)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(sqlConnectionString))
                {

                    SqlCommand comando = new SqlCommand("spObtenerDatosEmpresa", conexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@RUC", RUC);

                    string[] arreglo = new string[18]; // Areglo que trae los datos de CodError y Mensaje
                    SqlDataAdapter adapter = new SqlDataAdapter(comando);
                    DataSet data = new DataSet();
                    adapter.Fill(data);
                    arreglo[0] = data.Tables[0].Rows[0]["RUC"].ToString();
                    arreglo[1] = data.Tables[0].Rows[0]["RazonSocial"].ToString();
                    arreglo[2] = data.Tables[0].Rows[0]["TipoContribuyente"].ToString();
                    arreglo[3] = data.Tables[0].Rows[0]["NombreComercial"].ToString();
                    arreglo[4] = data.Tables[0].Rows[0]["FechaInscripcion"].ToString();
                    arreglo[5] = data.Tables[0].Rows[0]["FechaInicioActividades"].ToString();
                    arreglo[6] = data.Tables[0].Rows[0]["EstadoContribuyente"].ToString();
                    arreglo[7] = data.Tables[0].Rows[0]["CondicionContribuyente"].ToString();
                    arreglo[8] = data.Tables[0].Rows[0]["DomicioFiscal"].ToString();
                    arreglo[9] = data.Tables[0].Rows[0]["SistemEmisionComprobante"].ToString();
                    arreglo[10] = data.Tables[0].Rows[0]["ActividadComercioExterior"].ToString();
                    arreglo[11] = data.Tables[0].Rows[0]["SistemaContabilidad"].ToString();
                    arreglo[12] = data.Tables[0].Rows[0]["ActividadEconomica"].ToString();
                    arreglo[13] = data.Tables[0].Rows[0]["SistemaEmisionElectronica"].ToString();
                    arreglo[14] = data.Tables[0].Rows[0]["FechaEmisionElectronica"].ToString();
                    arreglo[15] = data.Tables[0].Rows[0]["ComprobantesElectronicos"].ToString();
                    arreglo[16] = data.Tables[0].Rows[0]["FechaAfiliacionPLE"].ToString();
                    arreglo[17] = data.Tables[0].Rows[0]["Padrones"].ToString();
                    return arreglo;
                }
            }
            catch (Exception)
            {
                using (SqlConnection conexion = new SqlConnection(sqlConnectionString))
                {

                    SqlCommand comando = new SqlCommand("spObtenerDatosEmpresa", conexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@RUC", RUC);

                    string[] arreglo = new string[2]; // Areglo que trae los datos de CodError y Mensaje
                    SqlDataAdapter adapter = new SqlDataAdapter(comando);
                    DataSet data = new DataSet();
                    adapter.Fill(data);
                    arreglo[0] = data.Tables[0].Rows[0]["CodError"].ToString();
                    arreglo[1] = data.Tables[0].Rows[0]["Mensaje"].ToString();
                    return arreglo;
                }
            }
        }
    }
}
