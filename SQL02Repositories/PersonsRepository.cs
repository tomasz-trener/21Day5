using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL02Repositories
{
    internal class PersonsRepository
    {
       private string connectionString =
            "Server=(localdb)\\mssqllocaldb;Database=VolleyballDatabase;Integrated Security=True;";

        public Person[] GetPersons()
        {
            List<Person> persons = new List<Person>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();
                using (SqlCommand command =
                    new SqlCommand("SELECT Id, FirstName, LastName FROM Persons", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Person person = new Person();
                            person.Id = reader.GetInt32(0);
                            person.FirstName = reader.GetString(1);
                            person.LastName = reader.GetString(2);
                            persons.Add(person);
                        }
                    }
                }
            }
            return persons.ToArray();
        }

        public List<Person> GetPersons2()
        {
            List<Person> persons = new List<Person>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();
                using (SqlCommand command =
                    new SqlCommand("SELECT Id, FirstName, LastName FROM Persons", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Person person = new Person();
                            person.Id = reader.GetInt32(0);
                            person.FirstName = reader.GetString(1);
                            person.LastName = reader.GetString(2);
                            persons.Add(person);
                        }
                    }
                }
            }
            return persons;
        }
    }
}
