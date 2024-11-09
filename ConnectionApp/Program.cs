// See https://aka.ms/new-console-template for more information
using ClassLibrary1;


class Program
{

 public static void Main(string[] args)
    {
        var t = new ClassLibrary1.Class1(); 
        t.Connect();

    }

/*public async void Connect()
{
    var connString = "Host=PostgreSQL;Username=postgres;Password=!QAZ2wsx;Database=shop";

    await using var conn = new NpgsqlConnection(connString);
    await conn.OpenAsync();

    await using (var cmd = new NpgsqlCommand("INSERT INTO data (some_field) VALUES (@p)", conn))
    {
        cmd.Parameters.AddWithValue("p", "Hello world");
        await cmd.ExecuteNonQueryAsync();
    }
    await using (var cmd = new NpgsqlCommand("SELECT some_field FROM data", conn))

    await using (var reader = await cmd.ExecuteReaderAsync())
    {
        while (await reader.ReadAsync())
            Console.WriteLine(reader.GetString(0));
    }*/
}

