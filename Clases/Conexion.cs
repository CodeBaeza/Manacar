using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManaCar.Clases
{
    class Conexion
    {
        MySqlDataReader comando;
        static string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=manacar;Convert Zero Datetime=True;";
        MySqlConnection databaseConnection = new MySqlConnection(connectionString);


        public void Login(string usuarioIntroducido, string contraseña)
        {
            bool encontrado = false;
            string usuario;
            string pass;
            string query = "SELECT * FROM usuarios";
            try
            {
                databaseConnection.Open();
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                comando = commandDatabase.ExecuteReader();
                if (comando.HasRows)
                {
                    while (comando.Read())
                    {
                        string[] row = { comando.GetString(0), comando.GetString(1) };
                        usuario = row[0];
                        pass = row[1];
                        if (usuarioIntroducido == usuario && contraseña == pass)
                        {
                            encontrado = true;
                        }
                    }
                    if (encontrado == true)
                    {
                        
                        MenuAdministracion menu = new MenuAdministracion();
                        menu.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuario no encontrado");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                databaseConnection.Close();
            }
        }
        public void nuevoUsuario(string usuario, string contraseña)
        {

            string queryInsert = "Insert into usuarios (usuario, contraseña) values ('" + usuario + "','" + contraseña + "');";
            try
            {
                databaseConnection.Open();
                MySqlCommand commandDatabase = new MySqlCommand(queryInsert, databaseConnection);
                comando = commandDatabase.ExecuteReader();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                databaseConnection.Close();
            }
        }
        public void eliminarUsuario(string usuario)
        {
            string queryDelete = "Delete from usuarios where usuario='" + usuario + "';";
            try
            {
                databaseConnection.Open();
                MySqlCommand commandDatabase = new MySqlCommand(queryDelete, databaseConnection);
                comando = commandDatabase.ExecuteReader();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                databaseConnection.Close();
            }

        }
        public string buscarUsuarios(string usuarioIntroducido)
        {
            string querySearch = "Select usuario from usuarios where usuario = '" + usuarioIntroducido + "';";
            bool encontrado = false;
            string usuario;
            try
            {
                databaseConnection.Open();
                MySqlCommand comandDatabase = new MySqlCommand(querySearch, databaseConnection);
                comando = comandDatabase.ExecuteReader();
                if (comando.HasRows)
                {
                    while (comando.Read())
                    {
                        string[] row = { comando.GetString(0) };
                        usuario = row[0];
                        if (usuario == usuarioIntroducido)
                        {
                            encontrado = true;
                        }
                    }
                    if (encontrado == true)
                    {
                        return usuarioIntroducido;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                databaseConnection.Close();
            }
            return null;
        }
        public List<UsuariosSistema> mostrarLista()
        {

            List<UsuariosSistema> listaUsuarios = new List<UsuariosSistema>();


            string querySearch = "Select * from usuarios;";


            try
            {
                databaseConnection.Open();
                MySqlCommand comandDatabase = new MySqlCommand(querySearch, databaseConnection);
                comando = comandDatabase.ExecuteReader();
                if (comando.HasRows)
                {
                    while (comando.Read())
                    {

                        UsuariosSistema us = new UsuariosSistema();
                        us.Usuario = comando.GetString(0);
                        //us.Password = comando.GetString(1);
                        listaUsuarios.Add(us);


                    }
                    return listaUsuarios;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                databaseConnection.Close();
            }
            return null;


        }
        public void insertarCliente(string nombre, string apellidos, string dni, DateTime fecha_entrada, DateTime fecha_salida, string matricula, string marca, string modelo, string parking)
        {
            string queryInsert = "Insert into clientes  (nombre, apellidos,dni,fecha_entrada,fecha_salida,matricula,marca,modelo,plaza_parking) values ('" + nombre + "','" + apellidos + "','" + dni + "','" + fecha_entrada + "','" + fecha_salida + "','" + matricula + "','" + marca + "','" + modelo + "','" + parking + "');";
            try
            {
                databaseConnection.Open();
                MySqlCommand comandDatabase = new MySqlCommand(queryInsert, databaseConnection);
                comando = comandDatabase.ExecuteReader();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                databaseConnection.Close();
            }
        }
        public string controlDuplicados(string matriculaRecibida)
        {
            string matricula;
            string querySearch = "Select matricula from clientes where matricula ='" + matriculaRecibida + "';";
            bool encontrado = false;
            try
            {
                databaseConnection.Open();
                MySqlCommand comandDatabase = new MySqlCommand(querySearch, databaseConnection);
                comando = comandDatabase.ExecuteReader();
                if (comando.HasRows)
                {
                    while (comando.Read())
                    {
                        string[] listaMatricula = { comando.GetString(0) };
                        matricula = listaMatricula[0];

                        if (matriculaRecibida == matricula)
                        {
                            encontrado = true;
                        }
                    }
                    if (encontrado == true)
                    {
                        return matriculaRecibida;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                databaseConnection.Close();
            }
            return null;
        }

        public List<DatosClientes> MostrarCliente( string dni)
        {
            List<DatosClientes> listaAux = new List<DatosClientes>();
            string querySearch = "Select nombre, apellidos, dni, fecha_entrada, fecha_salida, matricula, marca, modelo, plaza_parking from clientes where dni ='" + dni + "' ;";

            try
            {
                databaseConnection.Open();
                MySqlCommand comandDatabase = new MySqlCommand(querySearch, databaseConnection);
                comando = comandDatabase.ExecuteReader();
                if (comando.HasRows)
                {
                    while (comando.Read())
                    {

                        DatosClientes dc = new DatosClientes();
                        dc.Nombre = comando.GetString(0);
                        dc.Apellidos = comando.GetString(1);
                        dc.Dni = comando.GetString(2);
                        dc.FechaEntrada = comando.GetDateTime(3);
                        dc.FechaSalida = comando.GetDateTime(4);
                        dc.Matricula = comando.GetString(5);
                        dc.Marca = comando.GetString(6);
                        dc.Modelo = comando.GetString(7);
                        dc.PlazaParking = comando.GetString(8);
                        listaAux.Add(dc);


                    }
                    return listaAux;

                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                databaseConnection.Close();
            }
            return null;
        }

        public void actualizarDatosClientes(string nombre, string apellidos, string dni, DateTime fecha_entrada, DateTime fecha_salida, string matricula, string marca, string modelo, string parking)
        {
            string queryUpdate = " UPDATE clientes SET nombre= '"+nombre+ "', apellidos= '" + apellidos + "', dni= '" + dni + "', fecha_entrada= '" + fecha_entrada + "', fecha_salida= '" + fecha_salida + "', matricula= '" + matricula + "', marca= '" + marca + "', modelo= '" + modelo + "', plaza_parking='" + parking + "' WHERE dni ='" + dni + "'";
            try
            {
                databaseConnection.Open();
                MySqlCommand comandDatabase = new MySqlCommand(queryUpdate, databaseConnection);
                comando = comandDatabase.ExecuteReader();
                

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                databaseConnection.Close();
            }
        }
    
    }
}
