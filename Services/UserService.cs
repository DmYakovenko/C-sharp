using CRUD.Models;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace CRUD.Services
{
    public class UserService
    {
        private readonly DatabaseConnection _dbConnection;

        public UserService(DatabaseConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public List<User> GetUsers()
        {
            List<User> users = new List<User>();
            using (var conn = _dbConnection.GetConnection())
            {
                conn.Open();
                var query = "SELECT Id, Name, Email, Age FROM Users";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            users.Add(new User
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Email = reader.GetString(2),
                                Age = reader.GetInt32(3)
                            });
                        }
                    }
                }
            }
            return users;
        }

        public User GetUserById(int id)
        {
            using (var conn = _dbConnection.GetConnection())
            {
                conn.Open();
                var query = "SELECT Id, Name, Email, Age FROM Users WHERE Id = @id";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new User
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Email = reader.GetString(2),
                                Age = reader.GetInt32(3)
                            };
                        }
                    }
                }
            }
            return null;
        }

        public void CreateUser(User user)
        {
            using (var conn = _dbConnection.GetConnection())
            {
                conn.Open();
                var query = "INSERT INTO Users (Name, Email, Age) VALUES (@name, @email, @age)";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", user.Name);
                    cmd.Parameters.AddWithValue("@email", user.Email);
                    cmd.Parameters.AddWithValue("@age", user.Age);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateUser(User user)
        {
            using (var conn = _dbConnection.GetConnection())
            {
                conn.Open();
                var query = "UPDATE Users SET Name = @name, Email = @email, Age = @age WHERE Id = @id";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", user.Name);
                    cmd.Parameters.AddWithValue("@email", user.Email);
                    cmd.Parameters.AddWithValue("@age", user.Age);
                    cmd.Parameters.AddWithValue("@id", user.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteUser(int id)
        {
            using (var conn = _dbConnection.GetConnection())
            {
                conn.Open();
                var query = "DELETE FROM Users WHERE Id = @id";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
