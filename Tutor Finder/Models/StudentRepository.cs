using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
namespace Tutor_Finder.Models
{
    public class StudentRepository
    {
        string constring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TutorFinder;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public bool AddStudent(Student s)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            Console.WriteLine($"{s.Gender}");
            string query = $"insert into [Student] values ('{s.FirstName}'," +
                $"'{s.LastName}','{s.Password}','{s.Gender}','{s.Education}','{s.Address}'," +
                $"'{s.Country}','{s.PhoneCode}','{s.PhoneNumber}','{s.Email}')";
            SqlCommand cmd = new SqlCommand(query, con);
            int value = cmd.ExecuteNonQuery();
            if (value > 0)
                return true;
            else
                return false;
        }

        public bool Login(Student s)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string query = $"select * from [Student] where Email=@e and Password=@p";

            SqlParameter p1 = new SqlParameter("e", s.Email);
            SqlParameter p2 = new SqlParameter("p", s.Password);
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)//IF LOGIN MATCHED WITH Student
            {
                return true;
            }
            else
                return false;
        }
    }
}