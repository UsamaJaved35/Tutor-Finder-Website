using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Tutor_Finder.Models
{
    public class TutorRepository
    {
        string constring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TutorFinder;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public bool AddTutor(Tutor t)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string query = $"insert into [Tutor](FirstName,LastName,Password,Gender,Qualification,Experience," +
                $"Subjects,Address,ZipCode,Country,PhoneCode,PhoneNumber,Email) values ('{t.FirstName}'," +
                $"'{t.LastName}','{t.Password}','{t.Gender}','{t.Qualification}','{t.Experience}'," +
                $"'{t.Subjects}','{t.StreetAddress}','{t.ZipCode}','{t.Country}','{t.PhoneCode}'," +
                $"'{t.PhoneNumber}','{t.Email}')";
            SqlCommand cmd = new SqlCommand(query, con);
            int value=cmd.ExecuteNonQuery();
            if (value > 0)
                return true;
            else
                return false;
        }

        public bool Login(Tutor t)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string query = $"select * from [Tutor] where Email=@e and Password=@p";

            SqlParameter p1 = new SqlParameter("e", t.Email);
            SqlParameter p2 = new SqlParameter("p",t.Password);
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)//IF LOGIN MATCHED WITH Tutor
            {
                return true;
            }
            else
                return false;
        }
    }
}