using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Windows.Forms;

namespace Participation.Data
{
    public class Database
    {
        private string _connectionString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.20.31)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SID=orcl)));User Id=EYECT4PARTICIPATION;Password=EYECT4PARTICIPATION";

        private OracleConnection _connection;
        private OracleCommand command;
        private bool success = false;

        public bool Success
        {
            get { return success; }
            set { success = value; }
        }

        /// <summary>
        /// Stel de SQL query in die uitgevoerd moet gaan worden.
        /// </summary>
        public string Query
        {
            set
            {
                OpenConnection();
                // Stel het SQL commando in met de gegeven query
                command = new OracleCommand(value, _connection);
            }
        }

        /// <summary>
        /// Haalt het command-object op waarmee queries uitgevoerd kunnen worden.
        /// </summary>
        public OracleCommand Command
        {
            get { return command; }
        }

        /// <summary>
        /// Open de verbinding met de database
        /// </summary>
        public OracleConnection OpenConnection()
        {

            _connection = new OracleConnection(_connectionString);
            try
            {
                // Controleer of de verbinding niet al open is
                _connection.Open();
            }
            catch (OracleException)
            {
                MessageBox.Show("Something went wrong when trying to connect to the database.");
                throw;
            }
            return _connection;
        }

        /// <summary>
        /// Sluit de verbinding met de database
        /// </summary>
        public void CloseConnection()
        {
            // Controleer of de verbinding niet al gesloten is
            if (_connection.State != System.Data.ConnectionState.Closed)
            {
                _connection.Close();
            }
        }

        /// <summary>
        /// Commit changes
        /// </summary>
        public void Commit()
        {
            using (OracleConnection connection = OpenConnection())
            {
                string query = "commit";
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (OracleException)
                    {
                        // Unexpected error: rethrow to let the caller handle it
                        throw;
                    }
                }
            }
        }
    }
}
