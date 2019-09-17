using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace InvoiceMaker.Models.Repositories
{
    public class WorkTypeRepo
    {
        public List<WorkType> GetWorkTypes()
        {
            List<WorkType> workTypes = new List<WorkType>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string sql = @"
                SELECT Id, [Name], Rate
                FROM WorkType
                ORDER BY [Name]
                ";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string name = reader.GetString(1);
                    decimal rate = reader.GetDecimal(2);
                    WorkType workType = new WorkType(id, name, rate);
                    workTypes.Add(workType);
                }
            }
            return workTypes;
        }


        public WorkType GetById(int id)
        {
            // Client client = new Client();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string sql = @"
                SELECT Id, [Name], rate
                FROM WorkType
                WHERE Id = @id 
                   ";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int cid = id;
                    string name = reader.GetString(1);
                    decimal rate = reader.GetDecimal(2);
                    WorkType workType = new WorkType( cid, name, rate);

                    return workType;
                }
            }
            return null;
        }

        private string _connectionString = ConfigurationManager.ConnectionStrings["InvoiceMakerMvc"].ConnectionString;

        public void Insert(WorkType workType)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string sql = @"
                INSERT INTO WorkType([Name], rate)
                VALUES
                (@Name, @rate)
                 ";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@Name", workType.Name);
                command.Parameters.AddWithValue("@rate", workType.Rate);
                command.ExecuteNonQuery();
            }
        }




        public void Update(WorkType workType)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string sql = @"
                UPDATE WorkType
                SET [Name] = @Name
                , rate = @rate
                WHERE Id = @id
                    ";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@Name", workType.Name);
                command.Parameters.AddWithValue("@rate", workType.Rate);
                command.Parameters.AddWithValue("@id", workType.Id);
                command.ExecuteNonQuery();
            }
        }
    }
}