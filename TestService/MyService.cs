using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace TestService
{
     class MyService : IMyService
     {
        public List<Country> GetAllCountry()
        {
            List<Country> list = new List<Country>();
            string connectionString = "Server=localhost;Database=WCF;Integrated Security=True;";
            SqlConnection con = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("select * from Country",con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) { 
            Country c = new Country();
                c.CountryId = int.Parse(reader[0].ToString());
                c.CountryName = reader[1].ToString();
                list.Add(c);
            
            }
            reader.Close();
            con.Close();
            return list;
        }

        public string GetData()
        {
            return "www.Benify.com";
        }

        public int GetMax(int[] ar)
        {
            int Max = ar[0];
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] > Max)
                {
                    Max = ar[i];
                }
            }     
            return Max;
        }

        public string GetMessage(string Name)
        {
            return "Hello" + Name;    
        }

        public string GetResult(Student s)
        {
            double Avg = (s.M1 + s.M2 + s.M3)/ 3.0;
            if (Avg < 35)
                return "Fail";
            else
                return "Pass";
        }

        public int[] GetSorted(int[] ar)
        {
            Array.Sort(ar);
            return ar;
        }

        public Student GetTopper(List<Student> students)
        {
            if (students == null || students.Count == 0)
            {
                throw new ArgumentException("The student list is empty or null.");
            }

            return students
                .OrderByDescending(s => (s.M1 + s.M2 + s.M3) / 3.0) 
                .First();
        }
    }
}
