
using System.Data.SqlClient;//пространство имен для работы с бд
namespace ISp_20_20
{
    public class SQL
    {
        string ConString = @"Data Source = tcp:192.168.9.200,49172;
                            Initial Catalog = Trade;
                            User = student;
                            Password = 123456;";
        public int InsDelUpd(string command)
        {
            SqlConnection con = new SqlConnection(ConString);//строка подключение
            con.Open();//открыть подключение
            SqlCommand com = new SqlCommand(command, con);//создание запроса к бд
            return com.ExecuteNonQuery();//выполнение запроса к бд
        }
        public SqlDataReader Select(string command)
        {
            SqlConnection con = new SqlConnection(ConString);
            con.Open();
            SqlCommand com = new SqlCommand(command, con);
            return com.ExecuteReader();
        }
    }
}
