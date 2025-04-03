
using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.Common;

namespace SistemaNovo
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Db dbConnection = new Db();
            try
            {
                dbConnection.Open();

                string query = "SELECT * FROM dbo.Produto";
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            finally
            {
                dbConnection.Close();
            }
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}