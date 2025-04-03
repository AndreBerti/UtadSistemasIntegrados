using Microsoft.Data.SqlClient;

public class Db : IDisposable // Implementando IDisposable
{
    private string connectionString = "Server=TEKILA\\MEIBI2022;Database=Produto;Integrated Security=True;TrustServerCertificate=True;";
    private SqlConnection connection;
    private bool disposed = false;

    public Db()
    {
        connection = new SqlConnection(connectionString);
    }

    public void Open()
    {
        if (connection.State == System.Data.ConnectionState.Closed)
        {
            connection.Open();
        }
    }

    public void Close()
    {
        if (connection.State == System.Data.ConnectionState.Open)
        {
            connection.Close();
        }
    }

    public SqlConnection Connection // Propriedade para acessar a conexão
    {
        get { return connection; }
    }

    public SqlDataReader ExecuteQuery(string query)
    {
        SqlCommand command = new SqlCommand(query, connection);
        return command.ExecuteReader();
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
            {
                if (connection != null)
                {
                    connection.Dispose();
                    connection = null;
                }
            }

            disposed = true;
        }
    }

    ~Db()
    {
        Dispose(false);
    }
}
