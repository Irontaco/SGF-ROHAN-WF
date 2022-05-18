using SGF_ROHAN_WF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Windows.Forms;
using System.Data;

namespace SGF_ROHAN_WF.Controller
{
    public class ClientRepositoryDbHandler : IClientRepository, IOracleCustomType
    {
        DataPersistence DataPersistence;
        private Dictionary<int, Client> ClientData;

        public ClientRepositoryDbHandler(DataPersistence dataPers)
        {
            DataPersistence = dataPers;
            ClientData = DataPersistence.CurrentData.ClientData;

        }

        public bool CreateClient(Client client)
        {
            using (OracleConnection con = new OracleConnection())
            {
                con.ConnectionString = "Data Source=localhost/orclpdb;User Id=devusr; Password=devpass;";
                con.Open();

                OracleCommand cmd = new OracleCommand();

                string query = "INSERT INTO CLIENT(names, email, phone, business) VALUES (:1, :2, :3, :4)";

                cmd.CommandText = query;
                cmd.Connection = con;

                try
                {
                    OracleParameter param1 = cmd.CreateParameter();
                    param1.ParameterName = "1";
                    param1.OracleDbType = OracleDbType.Varchar2;
                    param1.Value = client.FullName;
                    param1.SourceColumn = "NAMES";
                    param1.Direction = ParameterDirection.Input;

                    OracleParameter param2 = cmd.CreateParameter();
                    param2.ParameterName = "2";
                    param2.OracleDbType = OracleDbType.Varchar2;
                    param2.Value = client.Email;
                    param2.SourceColumn = "EMAIL";
                    param2.Direction = ParameterDirection.Input;

                    OracleParameter param3 = cmd.CreateParameter();
                    param3.ParameterName = "3";
                    param3.OracleDbType = OracleDbType.Varchar2;
                    param3.Value = client.PhoneNumber;
                    param3.SourceColumn = "PHONE";
                    param3.Direction = ParameterDirection.Input;

                    OracleParameter param4 = cmd.CreateParameter();
                    param4.ParameterName = "4";
                    param4.OracleDbType = OracleDbType.Varchar2;
                    param4.Value = client.RegisteredBusiness;
                    param4.SourceColumn = "BUSINESS";
                    param4.Direction = ParameterDirection.Input;


                    cmd.Parameters.Add(param1);
                    cmd.Parameters.Add(param2);
                    cmd.Parameters.Add(param3);
                    cmd.Parameters.Add(param4);

                    cmd.ExecuteNonQuery();
                }catch(OracleException ex)
                {
                    MessageBox.Show(ex.ToString());
                }catch(ArgumentException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    cmd.Dispose();
                    con.Close();
                }

                return true;
            }
        }

        public bool DeleteClient(int id)
        {
            return false;
        }

        public bool DeleteClient(string id)
        {

            using (OracleConnection con = new OracleConnection())
            {
                con.ConnectionString = "Data Source=localhost/orclpdb;User Id=devusr; Password=devpass;";
                con.Open();

                OracleCommand cmd = new OracleCommand();

                string query = "DELETE FROM CLIENT WHERE NAMES = :1";

                cmd.CommandText = query;
                cmd.Connection = con;

                try
                {
                    OracleParameter param1 = cmd.CreateParameter();
                    param1.ParameterName = "1";
                    param1.OracleDbType = OracleDbType.Varchar2;
                    param1.Value = id.Remove(id.Length-1,1);
                    param1.SourceColumn = "NAMES";
                    param1.Direction = ParameterDirection.Input;

                    cmd.Parameters.Add(param1);

                    cmd.ExecuteNonQuery();
                }
                catch (OracleException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    cmd.Dispose();
                    con.Close();
                }

                return true;
            }
        }

        public void FromCustomObject(OracleConnection con, object udt)
        {
            throw new NotImplementedException();
        }

        public List<Client> GetAllClients()
        {

            List<Client> clients = new List<Client>();
            using (OracleConnection con = new OracleConnection())
            {
                con.ConnectionString = "Data Source=localhost/orclpdb;User Id=devusr; Password=devpass;";
                con.Open();

                OracleCommand cmd = new OracleCommand();

                string query = "SELECT NAMES FROM CLIENT";

                cmd.CommandText = query;
                cmd.Connection = con;

                OracleDataReader reader = cmd.ExecuteReader();

                try
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Client client = new Client();
                            client.Names = reader.GetString(0).ToString();

                            clients.Add(client);
                        }   

                        reader.Close();
                        return clients;
                    }

                }
                catch (OracleException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    cmd.Dispose();
                    con.Close();
                }

                return null;
            }


        }

        public Client GetClientFromId(int id)
        {
            throw new NotImplementedException();
        }

        public Client GetClientFromName(string name)
        {


            using (OracleConnection con = new OracleConnection())
            {
                con.ConnectionString = "Data Source=localhost/orclpdb;User Id=devusr; Password=devpass;";
                con.Open();

                OracleCommand cmd = new OracleCommand();

                string query = "SELECT NAMES FROM CLIENT WHERE NAMES ='" + name.Remove(name.Length-1,1) + "'";

                MessageBox.Show(query);

                cmd.CommandText = query;
                cmd.Connection = con;

                OracleDataReader reader = cmd.ExecuteReader();

                try
                {

                    MessageBox.Show(reader.HasRows.ToString());
                    if (reader.HasRows)
                    {
                        Client client = new Client();
                        client.Names = reader.GetString(0);

                        MessageBox.Show(client.Names);
                        reader.Close();
                        return client;
                    }

                }
                catch (OracleException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    cmd.Dispose();
                    con.Close();
                }

                return null;
            }
        }

        public void ToCustomObject(OracleConnection con, object udt)
        {
            throw new NotImplementedException();
        }

        public bool UpdateClient(int id, Client updatedClientData)
        {
            throw new NotImplementedException();
        }
    }
}
