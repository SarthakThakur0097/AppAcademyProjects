﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace InvoiceMaker.Models.Repositories
{
    public class ClientRepository
    {
        
        public List<Client> GetClients()
        {
            List<Client> clients = new List<Client>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string sql = @"
          SELECT Id, ClientName, IsActivated
          FROM Client
          ORDER BY ClientName
        ";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string name = reader.GetString(1);
                    bool isActivated = reader.GetBoolean(2);
                    Client client = new Client(id, name, isActivated);
                    clients.Add(client);
                }
            }
            return clients;
        }

        internal List<WorkType> GetWorkTypes()
        {
            throw new NotImplementedException();
        }

        public Client GetById(int id)
        {
           // Client client = new Client();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string sql = @"
                SELECT Id, ClientName, IsActivated
                FROM Client
                WHERE Id = @id 
                   ";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int cid = id;
                    string name = reader.GetString(1);
                    bool isActivated = reader.GetBoolean(2);
                    Client client = new Client(cid, name, isActivated);

                    return client;
                }
            }
            return null;
        }

        private string _connectionString = ConfigurationManager.ConnectionStrings["InvoiceMakerMvc"].ConnectionString;

        public void Insert(Client client)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string sql = @"
      INSERT INTO Client(ClientName, IsActivated)
      VALUES
      (@clientName, @isActivated)
    ";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@clientName", client.Name);
                command.Parameters.AddWithValue("@isActivated", client.IsActive);
                command.ExecuteNonQuery();
            }
        }

       


        public void Update(Client client)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string sql = @"
      UPDATE Client
      SET ClientName = @clientName
        , IsActivated = @isActivated
      WHERE Id = @id
    ";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@clientName", client.Name);
                command.Parameters.AddWithValue("@isActivated", client.IsActive);
                command.Parameters.AddWithValue("@id", client.Id);
                command.ExecuteNonQuery();
            }
        }

    }
}