using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinTech1.Data
{
    
    /*
     * Получение всех необходимых значений в один класс
     * 
     */
    class DataControl
    {
        private SqlConnection SqlConnection = null;
     
        
        public List<string> Get_Names()
        {
            SqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);
            SqlConnection.Open();
            string combo = "SELECT Name FROM Izdel";
            SqlCommand command = new SqlCommand(combo, SqlConnection);
            SqlDataReader reader = command.ExecuteReader();
            List<string> names = new List<string>();

            while (reader.Read())
            {


                names.Add(reader[0].ToString());
                //MessageBox.Show(reader[0].ToString());

            }

            return names;
           


        }
        public List<Link> GetLinks(Int64 izdelup)
        {
            SqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);
            SqlConnection.Open();
            string combo = "SELECT * FROM Links WHERE IzdelUp = " + izdelup + "";
            SqlCommand command = new SqlCommand(combo, SqlConnection);
            SqlDataReader reader = command.ExecuteReader();
            List<Link> links = new List<Link>();

            while (reader.Read())
            {


                links.Add(new Link(Convert.ToInt64(reader[0]), Convert.ToInt64(reader[1]), Convert.ToInt32(reader[2])));



            }

            return links;


        }


        public List<Izdel>  GetIzdels(string name)
        {
            SqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);
            SqlConnection.Open();
            string combo = "SELECT * FROM Izdel WHERE Name = '"+name+"'";
            SqlCommand command = new SqlCommand(combo, SqlConnection);
            SqlDataReader reader = command.ExecuteReader();
            List<Izdel> izdels = new List<Izdel>();

            while (reader.Read())
            {


                izdels.Add(new Izdel(Convert.ToInt64(reader[0]), reader[1].ToString(), Convert.ToDouble(reader[2])));

              

            }

            return izdels;


        }

        public List<Izdel> GetIzdelsById(Int64 id)
        {
            SqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);
            SqlConnection.Open();
            string combo = "SELECT * FROM Izdel WHERE Id = " + id + "";
            SqlCommand command = new SqlCommand(combo, SqlConnection);
            SqlDataReader reader = command.ExecuteReader();
            List<Izdel> izdels = new List<Izdel>();

            while (reader.Read())
            {


                izdels.Add(new Izdel(Convert.ToInt64(reader[0]), reader[1].ToString(), Convert.ToDouble(reader[2])));



            }

            return izdels;


        }


    }
}
