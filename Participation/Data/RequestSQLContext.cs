using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Participation.Classes;
using Participation.Data;
using Oracle.DataAccess.Client;
using Oracle.DataAccess;
using System.Windows.Forms;

namespace Participation.Data
{
    public class RequestSQLContext : IRequestContext
    {
        Database database = new Database();

        public void Cycle(Request request)
        {
            throw new NotImplementedException();
        }
        
        /// <summary>
        /// Gets a client belonging to a specific account
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public Client GetClientByID(Account account)
        {
            
            Client ret;

            string username = "";
            string email = "";
            string name = "";
            string password = "";
            string phone = "";
            string adress = "";
            int housenumber = -1;
            string city = "";
            string zipcode = "";
            int hascar = -1;
            int haslicence = -1;
            DateTime date = DateTime.Now;
            string picture = "";
            string usertype = "";
            int hasov = -1;
            string handicap = "";

            try
            {
                database.OpenConnection();
                database.Query = "select a.username, a.email, u.name, a.password, u.phone, u.adress, u.housenumber, u.city, u.zipcode, u.hascar, u.haslicence, u.birthdate, u.picture, u.usertype, c.OVPossibility, c.handicap from CLIENT c, USERINFO u, ACCOUNT a where c.accountid = u.accountid and u.accountid = a.accountid and c.ACCOUNTID = :id"; 

                database.Command.Parameters.Add(new OracleParameter("id", account.ID));

                OracleDataReader reader = database.Command.ExecuteReader();                

                while (reader.Read())
                {
                    username = (string)reader["username"];
                    email = (string)reader["email"];
                    name = (string)reader["name"];
                    password = (string)reader["password"];
                    phone = (string)reader["phone"];
                    adress = (string)reader["adress"];
                    housenumber = (int)reader["housenumber"];
                    city = (string)reader["city"];
                    zipcode = (string)reader["zipcode"];
                    hascar = (int)reader["hascar"];
                    date = (DateTime)reader["birthdate"];
                    picture = (string)reader["picture"];
                    usertype = (string)reader["usertype"];
                    hasov = (int)reader["OVPossibility"];
                    handicap = (string)reader["handicap"];
                }
            }
            catch (OracleException e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
            finally
            {
                database.Commit();
                database.CloseConnection();
            }

            List<string> Queryresult = new List<string>();
            bool retCar;
            bool retLicence;
            bool retOV;
            DateTime retDate;

            retDate = Convert.ToDateTime(Queryresult[11]);

            if (hascar == 0)
            {
                retCar = false;
            }
            else
            {
                retCar = true;
            }
            if (haslicence == 0)
            {
                retLicence = false;
            }
            else
            {
                retLicence = true;
            }
            if (hasov == 0)
            {
                retOV = false;
            }
            else
            {
                retOV = true;
            }

            ret = new Client(account.ID, username, email, name, password, phone, adress, housenumber, city, zipcode, retCar, retLicence, date, picture, usertype, retOV, handicap);
            return ret;
        }

        public void GetRequestData(Request request)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets a list of responses for the given request
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public List<Response> GetResponses(Request request)
        {
            List<Response> ret = new List<Response>();

            int responseID = -1;
            int userID = -1;
            DateTime dateResponse = DateTime.Now;
            string text = "";

            using (database.OpenConnection())
            {
                try
                {
                    database.Query = "select r.responseID, r.Userid, r.DateResponse, r.Text from response r, request req where req.RequestID = r.RequestID and req.RequestID = :id";
                    database.Command.Parameters.Add(new OracleParameter("id", request.ID));

                    OracleDataReader reader = database.Command.ExecuteReader();
                    while (reader.Read())
                    {
                        responseID = (int)reader["responseID"];
                        userID = (int)reader["Userid"];
                        dateResponse = (DateTime)reader["DateResponse"];
                        text = (string)reader["Text"];

                        ret.Add(new Response(dateResponse, responseID, request, text, GetUser(userID)));
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                finally
                {
                    database.Commit();
                    database.CloseConnection();
                }
            }
            return ret;
        }

        /// <summary>
        /// gets a user by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public User GetUser(int id)
        {
            //select a.accountid, a.email, a.password, u.name, u.phone, u.adress, u.housenumber, u.city, u. zipcode, u.hascar, u. haslicense, u.birthdate,
            //u.picture, u.usertype
            //from userinfo u, account a where :id = u.AccountID and u.accountid = a.accountid;

            User ret;

            int accountid = -1;
            string username = "";
            string email = "";
            string password = "";
            string name = "";
            string phone = "";
            string adress = "";
            int housenumber = -1;
            string city = "";
            string zipcode = "";
            int hascar = -1;
            int haslicence = -1;
            DateTime birthdate = DateTime.Now;
            string picture = "";
            string usertype = "";

            using (database.OpenConnection())
            {
                try
                {
                    database.Query = "select a.accountid, a.username, a.email, a.password, u.name, u.phone, u.adress, u.housenumber, u.city, u.zipcode, u.hascar, u.haslicense, u.birthdate,"
                        + " u.picture, u.usertype from userinfo u, account a where :id = u.AccountID and u.accountid = a.accountid";
                    database.Command.Parameters.Add(new OracleParameter("id", id));

                    OracleDataReader reader = database.Command.ExecuteReader();
                    while (reader.Read())
                    {
                        accountid = (int)reader["accountid"];
                        username = (string)reader["username"];
                        email = (string)reader["email"];
                        password = (string)reader["password"];
                        name = (string)reader["name"];
                        phone = (string)reader["phone"];
                        adress = (string)reader["adress"];
                        housenumber = (int)reader["housenumber"];
                        city = (string)reader["city"];
                        zipcode = (string)reader["zipcode"];
                        hascar = (int)reader["hascar"];
                        haslicence = (int)reader["haslicence"];
                        birthdate = (DateTime)reader["birthdate"];
                        picture = (string)reader["picture"];
                        usertype = (string)reader["usertype"];
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    database.Commit();
                    database.CloseConnection();
                }
            }

            bool retCar;
            bool retLicence;

            if (hascar == 0)
            {
                retCar = false;
            }
            else
            {
                retCar = true;
            }
            if (haslicence == 0)
            {
                retLicence = false;
            }
            else
            {
                retLicence = true;
            }

            ret = new User(accountid, username, email, password, name, phone, adress, housenumber, city, zipcode, retCar, retLicence, birthdate, picture, usertype);
            return ret;
        }

        /// <summary>
        /// insert a new request into the databse
        /// </summary>
        /// <param name="account">the account that owns the request</param>
        /// <param name="title"></param>
        /// <param name="text">the content of the request</param>
        /// <param name="location">the location at wich the request will be held</param>
        /// <param name="from">the start date</param>
        /// <param name="till">followup date</param>
        /// <param name="urgent">if the request is urgent or not</param>
        /// <param name="repeat">how freqeuntly the request will be repeated</param>
        public void Insert(Account account, string title, string text, string location, DateTime from, DateTime till, bool urgent, Repeat repeat)
        {
            using (database.OpenConnection())
            {
                try
                {
                    int _urgent = 0;
                    if (urgent)
                    {
                        _urgent = 1;
                    }

                    //MessageBox.Show(from.ToString());
                    database.Query = "insert into REQUEST(AccountID, Title, Text, Location, FromWhen, Till, Urgent, RequestRepeat, requestid)" 
                                    + "values(:id, :title, :text, :location, to_date('24-08-2013', 'dd-mm-yyyy'), to_date('24-08-2013', 'dd-mm-yyyy'), :urgent, :repeatreq, :id)";
                    database.Command.Parameters.Add(new OracleParameter("id", account.ID));
                    database.Command.Parameters.Add(new OracleParameter("title", title));
                    database.Command.Parameters.Add(new OracleParameter("text", text));
                    database.Command.Parameters.Add(new OracleParameter("location", location));
                    database.Command.Parameters.Add(new OracleParameter("fromwhen", from));
                    database.Command.Parameters.Add(new OracleParameter("till", till));
                    database.Command.Parameters.Add(new OracleParameter("urgent", _urgent));
                    database.Command.Parameters.Add(new OracleParameter("repeatreq", 7));
                    database.Command.Parameters.Add(new OracleParameter("id", 1));

                    database.Command.ExecuteNonQuery();
                }
                catch (OracleException e)
                {
                    MessageBox.Show(e.Message);
                }
                finally
                {
                    database.Commit();
                    database.CloseConnection();
                }
            }
        }

        public void InsertReview(Account subject, Account author, string Text, DateTime date, int grade)
        {
            //            insert into REVIEW(AccountIDA, AccountIDB, Text, ReviewDate, Grade)
            //values(:IDA, :IDB, :Text, :RDate, :Grade);

            string _IDA = Convert.ToString(subject.ID);
            string _IDB = Convert.ToString(author.ID);
            string _RDate = date.ToString();
            string _Grade = Convert.ToString(grade);

            throw new NotImplementedException();
        }
    }
}
