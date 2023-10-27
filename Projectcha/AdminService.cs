using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectcha
{
    public class AdminService
    {
        public static void GetAllEmployee()
        {
            using(SqlConnection connect = new SqlConnection("Server=DESKTOP-K36HGB0;Database=Projectcha;Trusted_Connection=True;"))
            {

                connect.Open();
                string query = $"select * from Employee where status != \'deleted\' ";


                SqlCommand cmd = new SqlCommand(query, connect);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            Console.WriteLine($"Col{i}  {reader[i]}");
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
        
        public static void GetByEmployee(string ColumnName, string Value)
        {
            ColumnName = ColumnName.ToLower();
            using (SqlConnection connect = new SqlConnection("Server=DESKTOP-K36HGB0;Database=Projectcha;Trusted_Connection=True;"))
            {

                connect.Open();
                string query = $"select * from Employee where {ColumnName} = \'{Value}\' and status != \'deleted\'";


                SqlCommand cmd = new SqlCommand(query, connect);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            Console.WriteLine($"Col{i}  {reader[i]}");
                        }
                        Console.WriteLine();
                    }
                }
            }
        }

        public static void DeleteEmployee(string ColumnName, string Value)
        {
           
            ColumnName = ColumnName.ToLower();
            using (SqlConnection connect = new SqlConnection("Server=DESKTOP-K36HGB0;Database=Projectcha;Trusted_Connection=True;"))
            {
                connect.Open();
                string query = $"update Employee set status = \'deleted\', delete_date = \'{DateTime.Now.Date}\'  where {ColumnName} = \'{Value}\'";

                Console.WriteLine("Ma'lumot muvaffaqiyatli o'chirildi!!!");

                SqlCommand cmd = new SqlCommand(query, connect);
                cmd.ExecuteNonQuery();
            }
        }

        public static void DeepDeleteEmployee(string ColumnName, string Value)
        { 
            ColumnName = ColumnName.ToLower();

            using (SqlConnection connect = new SqlConnection("Server=DESKTOP-K36HGB0;Database=Projectcha;Trusted_Connection=True;"))
            {

                connect.Open();
                string query = $"delete from Employee where {ColumnName} = \'{Value}\' ";

                SqlCommand cmd = new SqlCommand(query, connect);
                cmd.ExecuteNonQuery();

                Console.WriteLine("Ma'lumot jadvaldan to'liq ochirildi!!!");


            }
        }
        
        public static void UpdateEmployee(string ColumnName, string Value, string ConTableName, string ConValue) 
        {
            ColumnName = ColumnName.ToLower();
            ConTableName = ConTableName.ToLower();
           

            using (SqlConnection connect = new SqlConnection("Server=DESKTOP-K36HGB0;Database=Projectcha;Trusted_Connection=True;"))
            {
                connect.Open();

                string query = $"update Employee set status = \'updated\', {ColumnName} = \'{Value}\', modify_date = \'{DateTime.Now.Date}\' where {ConTableName} = \'{ConValue}\'";

                SqlCommand cmd = new SqlCommand(query, connect);
                cmd.ExecuteNonQuery();

                Console.WriteLine("Ma'lumot muvaffaqiyatli yangilandi!!!");
            }

        }

        public static void CreateEmployee(string Name,string Surname, string Email, string Login,  string Password, string role)
        {
            using (SqlConnection connect = new SqlConnection("Server=DESKTOP-K36HGB0;Database=Projectcha;Trusted_Connection=True;"))
            {

                connect.Open();
                string query = $"insert into Employee (name,surname,email,login,password,status,role,create_date) " +
                    $"values (\'{Name}\',\'{Surname}\',\'{Email}\',\'{Login}\',\'{Password}\',\'created\',\'{role}\',\'{DateTime.Now.Date}\')";

                SqlCommand cmd = new SqlCommand(query, connect);
                cmd.ExecuteNonQuery();

            }
        }


        /*(
name,surname,email,login,password,status,role,create_date,modify_date,delete_date
)*/

    }
}
