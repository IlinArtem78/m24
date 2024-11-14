using Npgsql;

namespace ClassLibrary1
{
    public class Class1
    {

        //   Server=адрес_сервера;Database=имя_базы_данных;User Id = логин; Password=пароль;

        public async void Connect()
        {
            var connectionString = "Host=localhost;Database=shop;Username=postgres;Password=!QAZ@WSX;";

            
            
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    using (NpgsqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "SELECT * FROM clients";
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine(reader["id"]);
                                Console.WriteLine(reader["name"]);
                            }
                        }
                    }
                }

            }
                catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);

            }
        }

    }
}
