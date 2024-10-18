using GRUPO_H.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System;
using System.Data.SqlClient;
namespace GRUPO_H.Controllers
{
    public class TablaControler : Controller
    {
        public IActionResult Index()
        {
            var datos = new List<Tabla> { };
            string query = $"SELECT*\r\nFROM FUNC_5 ('')\r\nORDER BY CANTIDAD DESC";
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RAM3DC7\\SQLEXPRESS;Initial Catalog=Proyectodb2;Integrated Security=True"))
            {
                conn.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                datos.Add(new Tabla { Etiqueta = "Localidad", Valor = "Inscritos Por Localidad" });

                dataAdapter.Fill(dataTable);
                foreach (DataRow row in dataTable.Rows)
                {
                    string noma = row["noma"].ToString();
                    int cant = (int)(double)row["cantidad"];
                    datos.Add(new Tabla { Etiqueta = noma, Valor = cant.ToString() });
                }
            }
            // Pasar la lista de datos a la vista serializándola en formato JSON
            return View(datos);
        }

        [HttpGet]
        public IActionResult ObtenerTabla (string numTabla,string filtroFacultad,string filtroPeriodo,string filtroModalidad,string filtroLocalidad,string filtroOrden,string filtroCarrera)
        {
            string query;
            var datos = new List<Tabla> { };
            var datos2 = new List<Tabla2> { };
            switch (numTabla)
            {
                case "1":
                    query = $"SELECT*\r\nFROM FUNC_1 ('{filtroFacultad}','{filtroPeriodo}')\r\nORDER BY CANTIDAD {filtroOrden}";
                    using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RAM3DC7\\SQLEXPRESS;Initial Catalog=Proyectodb2;Integrated Security=True"))
                    {
                        datos.Add(new Tabla { Etiqueta= "Localidad",Valor="Inscritos Por Localidad" });
                        conn.Open();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        foreach (DataRow row in dataTable.Rows)
                        {
                            string noma = row["NOMA"].ToString();
                            int cant = (int)(double)row["CANTIDAD"];
                            datos.Add(new Tabla { Etiqueta = noma, Valor = cant.ToString() });
                        }
                    }
                    break;
                case "2":
                    query = $"SELECT*\r\nFROM FUNC_2 ('{filtroFacultad}', '{filtroPeriodo}', '{filtroLocalidad}')\r\nORDER BY CANTIDAD {filtroOrden}";
                    using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RAM3DC7\\SQLEXPRESS;Initial Catalog=Proyectodb2;Integrated Security=True"))
                    {
                        datos.Add(new Tabla { Etiqueta = "Carrera", Valor = "Inscritos Por Facultad" });
                        conn.Open();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        foreach (DataRow row in dataTable.Rows)
                        {
                            string noma = row["NOMA"].ToString();
                            int cant = (int)(double)row["CANTIDAD"];
                            datos.Add(new Tabla { Etiqueta = noma, Valor = cant.ToString() });
                        }
                    }
                    break;
                case "3":
                    query = $"SELECT*\r\nFROM FUNC_3('{filtroFacultad}', '{filtroPeriodo}', '{filtroLocalidad}')\r\nORDER BY CANTIDAD {filtroOrden}";
                    using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RAM3DC7\\SQLEXPRESS;Initial Catalog=Proyectodb2;Integrated Security=True"))
                    {
                        datos.Add(new Tabla { Etiqueta = "Carrera", Valor = "Inscritos Nuevos" });
                        conn.Open();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        foreach (DataRow row in dataTable.Rows)
                        {
                            string noma = row["NOMA"].ToString();
                            int cant = (int)(double)row["CANTIDAD"];
                            datos.Add(new Tabla { Etiqueta = noma, Valor = cant.ToString() });
                        }
                    }
                    break;
                case "4":
                    query = $"SELECT*\r\nFROM FUNC_4 ('{filtroPeriodo}')\r\nORDER BY CANTIDAD {filtroOrden}";
                    using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RAM3DC7\\SQLEXPRESS;Initial Catalog=Proyectodb2;Integrated Security=True"))
                    {
                        datos.Add(new Tabla { Etiqueta = "Carrera", Valor = "Inscritos por Facultad" });
                        conn.Open();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        foreach (DataRow row in dataTable.Rows)
                        {
                            string noma = row["NOMA"].ToString();
                            int cant = (int)(double)row["CANTIDAD"];
                            datos.Add(new Tabla { Etiqueta = noma, Valor = cant.ToString() });
                        }
                    }
                    break;
                case "5":
                    query = $"SELECT*\r\nFROM FUNC_5 ('{filtroPeriodo}')\r\nORDER BY CANTIDAD {filtroOrden}";
                    using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RAM3DC7\\SQLEXPRESS;Initial Catalog=Proyectodb2;Integrated Security=True"))
                    {
                        datos.Add(new Tabla { Etiqueta = "Localidad", Valor = "Inscritos Por Facultad" });
                        conn.Open();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        foreach (DataRow row in dataTable.Rows)
                        {
                            string noma = row["NOMA"].ToString();
                            int cant = (int)(double)row["CANTIDAD"];
                            datos.Add(new Tabla { Etiqueta = noma, Valor = cant.ToString() });
                        }
                    }
                    break;
                case "6":
                    query = $"SELECT*\r\nFROM FUNC_6('{filtroFacultad}', '{filtroPeriodo}', '{filtroLocalidad}', '{filtroModalidad}')\r\nORDER BY CANTIDAD {filtroOrden}";
                    using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RAM3DC7\\SQLEXPRESS;Initial Catalog=Proyectodb2;Integrated Security=True"))
                    {
                        datos.Add(new Tabla { Etiqueta = "Localidad", Valor = "Inscritos Por Localidad" });
                        conn.Open();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        foreach (DataRow row in dataTable.Rows)
                        {
                            string noma = row["NOMA"].ToString();
                            int cant = (int)(double)row["CANTIDAD"];
                            datos.Add(new Tabla { Etiqueta = noma, Valor = cant.ToString() });
                        }
                    }
                    break;
                case "7":
                    query = $"SELECT*\r\nFROM FUNC_7 ('{filtroPeriodo}')\r\nORDER BY CANTIDAD {filtroOrden}";
                    using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RAM3DC7\\SQLEXPRESS;Initial Catalog=Proyectodb2;Integrated Security=True"))
                    {
                        datos.Add(new Tabla { Etiqueta = "Localidad", Valor = "Inscritos Por Localidad" });
                        conn.Open();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        foreach (DataRow row in dataTable.Rows)
                        {
                            string noma = row["NOMA"].ToString();
                            int cant = (int)(double)row["CANTIDAD"];
                            datos.Add(new Tabla { Etiqueta = noma, Valor = cant.ToString() });
                        }
                    }
                    break;
                case "8":
                    query = $"SELECT*\r\nFROM FUNC_8 ()";
                    using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RAM3DC7\\SQLEXPRESS;Initial Catalog=Proyectodb2;Integrated Security=True"))
                    {
                        datos.Add(new Tabla { Etiqueta = "Localidad", Valor = "Inscritos Por Localidad" });
                        conn.Open();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        foreach (DataRow row in dataTable.Rows)
                        {
                            string noma = row["NOMA"].ToString();
                            int cant = (int)(double)row["CANTIDAD"];
                            datos.Add(new Tabla { Etiqueta = noma, Valor = cant.ToString() });
                        }
                    }
                    break;
                case "9":
                    query = $"SELECT*\r\nFROM FUNC_9 ('{filtroPeriodo}')\r\nORDER BY CANTIDAD {filtroOrden}";
                    using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RAM3DC7\\SQLEXPRESS;Initial Catalog=Proyectodb2;Integrated Security=True"))
                    {
                        datos.Add(new Tabla { Etiqueta = "Localidad", Valor = "Inscritos Por Localidad" });
                        conn.Open();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        foreach (DataRow row in dataTable.Rows)
                        {
                            string noma = row["NOMA"].ToString();
                            int cant = (int)(double)row["CANTIDAD"];
                            datos.Add(new Tabla { Etiqueta = noma, Valor = cant.ToString() });
                        }
                    }
                    break;
                case "10":
                    query = $"SELECT*\r\nFROM FUNC_10 ('{filtroFacultad}', '{filtroPeriodo}', '{filtroLocalidad}', '{filtroModalidad}')\r\nORDER BY CANTIDAD {filtroOrden}";
                    using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RAM3DC7\\SQLEXPRESS;Initial Catalog=Proyectodb2;Integrated Security=True"))
                    {
                        datos.Add(new Tabla { Etiqueta = "Localidad", Valor = "Inscritos Por Localidad" });
                        conn.Open();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        foreach (DataRow row in dataTable.Rows)
                        {
                            string noma = row["NOMA"].ToString();
                            int cant = (int)(double)row["CANTIDAD"];
                            datos.Add(new Tabla { Etiqueta = noma, Valor = cant.ToString() });
                        }
                    }
                    break;
                case "11":
                    query = $"SELECT*\r\nFROM FUNC_11('{filtroPeriodo}')\r\nORDER BY CANTIDAD {filtroOrden}";
                    using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RAM3DC7\\SQLEXPRESS;Initial Catalog=Proyectodb2;Integrated Security=True"))
                    {
                        datos.Add(new Tabla { Etiqueta = "Carrera", Valor = "Total Egresados" });
                        conn.Open();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        foreach (DataRow row in dataTable.Rows)
                        {
                            string noma = row["NOMA"].ToString();
                            int cant = (int)(double)row["CANTIDAD"];
                            datos.Add(new Tabla { Etiqueta = noma, Valor = cant.ToString() });
                        }
                    }
                    break;
                case "12":
                    query = $"SELECT*\r\nFROM FUNC_12 ('{filtroFacultad}','{filtroPeriodo}', '{filtroLocalidad}', '{filtroModalidad}')";
                    using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RAM3DC7\\SQLEXPRESS;Initial Catalog=Proyectodb2;Integrated Security=True"))
                    {
                        datos2.Add(new Tabla2 { Etiqueta = "Periodo", Valor = "Cant. Est. Nuevos", Valor2 = "Cant. Est.Titulados" });
                        conn.Open();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        foreach (DataRow row in dataTable.Rows)
                        {
                            string noma = row["NOMA"].ToString();
                            int cant = (int)(double)row["CANTIDAD1"];
                            int cant2 = (int)(double)row["CANTIDAD2"];
                            datos2.Add(new Tabla2 { Etiqueta = noma, Valor = cant.ToString(), Valor2 = cant2.ToString() });
                        }
                    }
                    break;
                case "13":
                    query = $"SELECT*\r\nFROM FUNC_13 ('{filtroPeriodo}')\r\nORDER BY CANTIDAD1 {filtroOrden}";
                    using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RAM3DC7\\SQLEXPRESS;Initial Catalog=Proyectodb2;Integrated Security=True"))
                    {
                        datos2.Add(new Tabla2 { Etiqueta = "Carrera", Valor = "Cant. Est. Nuevos", Valor2 = "Cant. Est. Titulados" });
                        conn.Open();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        foreach (DataRow row in dataTable.Rows)
                        {
                            string noma = row["NOMA"].ToString();
                            int cant = (int)(double)row["CANTIDAD1"];
                            int cant2 = (int)(double)row["CANTIDAD2"];
                            datos2.Add(new Tabla2 { Etiqueta = noma, Valor = cant.ToString(), Valor2 = cant2.ToString() });
                        }
                    }
                    break;
                case "14":
                    query = $"SELECT*\r\nFROM FUNC_14 () order by CANTIDAD {filtroOrden}";
                    using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RAM3DC7\\SQLEXPRESS;Initial Catalog=Proyectodb2;Integrated Security=True"))
                    {
                        datos.Add(new Tabla { Etiqueta = "Periodo", Valor = "%Desertores" });
                        conn.Open();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        foreach (DataRow row in dataTable.Rows)
                        {
                            string noma = row["NOMA"].ToString();
                            int cant = (int)(double)row["CANTIDAD"];
                            datos.Add(new Tabla { Etiqueta = noma, Valor = cant.ToString() });
                        }
                    }
                    break;
                case "15":
                    query = $"SELECT*\r\nFROM FUNC_15() order by CANTIDAD1 {filtroOrden}";
                    using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RAM3DC7\\SQLEXPRESS;Initial Catalog=Proyectodb2;Integrated Security=True"))
                    {
                        datos2.Add(new Tabla2 { Etiqueta = "Carrera", Valor = "2019-1",Valor2 = "2020-1" });
                        conn.Open();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        foreach (DataRow row in dataTable.Rows)
                        {
                            string noma = row["NOMA"].ToString();
                            int cant = (int)(double)row["CANTIDAD1"];
                            int cant2 = (int)(double)row["CANTIDAD2"];
                            datos2.Add(new Tabla2 { Etiqueta = noma, Valor = cant.ToString(), Valor2 = cant2.ToString() });
                        }
                    }
                    break;
                case "16":
                    query = $"SELECT*\r\nFROM FUNC_16() order by CANTIDAD1 {filtroOrden}";
                    using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RAM3DC7\\SQLEXPRESS;Initial Catalog=Proyectodb2;Integrated Security=True"))
                    {
                        datos2.Add(new Tabla2 { Etiqueta = "Periodo", Valor = "%Sin notas", Valor2 = "%Aprobados" });
                        conn.Open();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        foreach (DataRow row in dataTable.Rows)
                        {
                            string noma = row["NOMA"].ToString();
                            int cant = (int)(double)row["CANTIDAD1"];
                            int cant2 = (int)(double)row["CANTIDAD2"];
                            datos2.Add(new Tabla2 { Etiqueta = noma, Valor = cant.ToString(), Valor2 = cant2.ToString() });
                        }
                    }
                    break;
                case "17":
                    query = $"SELECT*\r\nFROM FUNC_17('{filtroPeriodo}')\r\nORDER BY CANTIDAD2 {filtroOrden}";
                    using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RAM3DC7\\SQLEXPRESS;Initial Catalog=Proyectodb2;Integrated Security=True"))
                    {
                        datos2.Add(new Tabla2 { Etiqueta = "Carrera", Valor = "%Sin notas", Valor2 = "%Aprobados" });
                        conn.Open();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        foreach (DataRow row in dataTable.Rows)
                        {
                            string noma = row["NOMA"].ToString();
                            int cant = (int)(double)row["CANTIDAD1"];
                            int cant2 = (int)(double)row["CANTIDAD2"];
                            datos2.Add(new Tabla2 { Etiqueta = noma, Valor = cant.ToString(), Valor2 = cant2.ToString() });
                        }
                    }
                    break;
                case "18":
                    query = $"SELECT*\r\nFROM FUNC_18() order by CANTIDAD {filtroOrden}";
                    using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RAM3DC7\\SQLEXPRESS;Initial Catalog=Proyectodb2;Integrated Security=True"))
                    {
                        datos.Add(new Tabla { Etiqueta = "Periodo", Valor = "Average of PPS" });
                        conn.Open();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        foreach (DataRow row in dataTable.Rows)
                        {
                            string noma = row["NOMA"].ToString();
                            int cant = (int)(double)row["CANTIDAD"];
                            datos.Add(new Tabla { Etiqueta = noma, Valor = cant.ToString() });
                        }
                    }
                    break;
                case "19":
                    query = $"SELECT*\r\nFROM FUNC_19('{filtroPeriodo}')\r\nORDER BY CANTIDAD {filtroOrden}";
                    using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RAM3DC7\\SQLEXPRESS;Initial Catalog=Proyectodb2;Integrated Security=True"))
                    {
                        datos.Add(new Tabla { Etiqueta = "Carrera", Valor = "Average of PPS" });
                        conn.Open();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        foreach (DataRow row in dataTable.Rows)
                        {
                            string noma = row["NOMA"].ToString();
                            int cant = (int)(double)row["CANTIDAD"];
                            datos.Add(new Tabla { Etiqueta = noma, Valor = cant.ToString() });
                        }
                    }
                    break;
                case "20":
                    query = $"SELECT*\r\nFROM FUNC_20()\r\nORDER BY CANTIDAD {filtroOrden}";
                    using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RAM3DC7\\SQLEXPRESS;Initial Catalog=Proyectodb2;Integrated Security=True"))
                    {
                        datos.Add(new Tabla { Etiqueta = "Periodo", Valor = "Average of PPAC" });
                        conn.Open();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        foreach (DataRow row in dataTable.Rows)
                        {
                            string noma = row["NOMA"].ToString();
                            int cant = (int)(double)row["CANTIDAD"];
                            datos.Add(new Tabla { Etiqueta = noma, Valor = cant.ToString() });
                        }
                    }
                    break;
                case "21":
                    query = $"SELECT*\r\nFROM FUNC_21('{filtroPeriodo}')\r\nORDER BY CANTIDAD {filtroOrden}";
                    using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RAM3DC7\\SQLEXPRESS;Initial Catalog=Proyectodb2;Integrated Security=True"))
                    {
                        datos.Add(new Tabla { Etiqueta = "Carrera", Valor = "Average of PPAC" });
                        conn.Open();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        foreach (DataRow row in dataTable.Rows)
                        {
                            string noma = row["NOMA"].ToString();
                            int cant = (int)(double)row["CANTIDAD"];
                            datos.Add(new Tabla { Etiqueta = noma, Valor = cant.ToString() });
                        }
                    }
                    break;
                case "22":
                    query = $"SELECT*\r\nFROM FUNC_22()\r\nORDER BY CANTIDAD {filtroPeriodo}";
                    using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RAM3DC7\\SQLEXPRESS;Initial Catalog=Proyectodb2;Integrated Security=True"))
                    {
                        datos.Add(new Tabla { Etiqueta = "Periodo", Valor = "Average of PPA1" });
                        conn.Open();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        foreach (DataRow row in dataTable.Rows)
                        {
                            string noma = row["NOMA"].ToString();
                            int cant = (int)(double)row["CANTIDAD"];
                            datos.Add(new Tabla { Etiqueta = noma, Valor = cant.ToString() });
                        }
                    }
                    break;
                case "23":
                    query = $"SELECT*\r\nFROM FUNC_23('{filtroPeriodo}')\r\nORDER BY CANTIDAD {filtroOrden}";
                    using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RAM3DC7\\SQLEXPRESS;Initial Catalog=Proyectodb2;Integrated Security=True"))
                    {
                        datos.Add(new Tabla { Etiqueta = "Carrera", Valor = "Average of PPA1" });
                        conn.Open();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        foreach (DataRow row in dataTable.Rows)
                        {
                            string noma = row["NOMA"].ToString();
                            int cant = (int)(double)row["CANTIDAD"];
                            datos.Add(new Tabla { Etiqueta = noma, Valor = cant.ToString() });
                        }
                    }
                    break;

            }
            // Retornar los datos en formato JSON
            switch (numTabla)
            {
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "10":
                case "11":
                case "14":
                case "18":
                case "19":
                case "20":
                case "21":
                case "22":
                case "23":
                    return Json(datos);
                    break;
                case "12":
                case "13":
                case "15":
                case "16":
                case "17": 
                    return Json(datos2);
                    break;
            }
            return Json(datos);
        }


        [HttpGet]
        public IActionResult ObtenerDatosFiltrados(string filtro)
        {
            var datos = new List<Tabla> { };
            string query = $"SELECT*\r\nFROM FUNC_5pru ('{filtro}')\r\nORDER BY CANTIDAD ASC";
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RAM3DC7\\SQLEXPRESS;Initial Catalog=Proyectodb2;Integrated Security=True"))
            {
                conn.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                datos.Add(new Tabla { Etiqueta = "Localidad", Valor = "Inscritos Por Localidad" });
                dataAdapter.Fill(dataTable);
                foreach (DataRow row in dataTable.Rows)
                {
                    string noma = row["noma"].ToString();
                    int cant = (int)(double)row["cantidad"];
                    datos.Add(new Tabla { Etiqueta = noma, Valor = cant.ToString() });
                }
            } // Retornar los datos en formato JSON
            return Json(datos);
        }
    }
}
