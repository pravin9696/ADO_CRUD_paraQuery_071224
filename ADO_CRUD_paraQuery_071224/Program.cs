using Microsoft.Data.SqlClient;
using System.Data;

namespace ADO_CRUD_paraQuery_071224
{
    class CRU_operation
    {
        public void insertRecord_SP()
        {
            int rl;
            string nm;
            int tm;
            Console.WriteLine("Enter roll number, Name & Total Marks");
            rl = int.Parse(Console.ReadLine());
            nm = Console.ReadLine();
            tm = int.Parse(Console.ReadLine());

            string qry = "sp_insert";

            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=myDB123;Integrated Security=True;TrustServerCertificate=True");
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = qry;
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@nm1", nm);
            cmd.Parameters.AddWithValue("@rl", rl);
            cmd.Parameters.AddWithValue("@tm", tm);

            SqlParameter sp1 = new SqlParameter("@nm", nm);
            cmd.Parameters.Add(sp1);
            

            int n = cmd.ExecuteNonQuery();
            if (n > 0)
            {
                Console.WriteLine("record inserted Successfully..");
            }
            else
            {
                Console.WriteLine("Record not inserted!!!");
            }
            con.Close();

        }
        public void insertRecord_para()
        {
            int rl;
            string nm;
            int tm;
            Console.WriteLine("Enter roll number, Name & Total Marks");
            rl = int.Parse(Console.ReadLine());
            nm = Console.ReadLine();
            tm = int.Parse(Console.ReadLine());

            string qry = "insert into tblstudent values(@roll,@nm1,@tm)";

            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=myDB123;Integrated Security=True;TrustServerCertificate=True");
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = qry;
            //cmd.Parameters.AddWithValue("@nm1", nm);
            cmd.Parameters.AddWithValue("@roll", rl);           
            cmd.Parameters.AddWithValue("@tm", tm);
            
            SqlParameter sp1=new SqlParameter("@nm1", nm);
            cmd.Parameters.Add(sp1);
            cmd.CommandType = CommandType.Text;

            int n = cmd.ExecuteNonQuery();
            if (n > 0)
            {
                Console.WriteLine("record inserted Successfully..");
            }
            else
            {
                Console.WriteLine("Record not inserted!!!");
            }
            con.Close();

        }
        public void insertRecord()
        {
            int rl;
            string nm;
            int tm;
            Console.WriteLine("Enter roll number, Name & Total Marks");
            rl=int.Parse(Console.ReadLine());
            nm=Console.ReadLine();
            tm=int.Parse(Console.ReadLine());
            string qry = $"insert into tblstudent values({rl},'{nm}',{tm})";
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=myDB123;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = qry;
            cmd.CommandType = CommandType.Text;

            int n=cmd.ExecuteNonQuery();
            if (n>0)
            {
                Console.WriteLine("record inserted Successfully..");
            }
            else
            {
                Console.WriteLine("Record not inserted!!!");
            }
            con.Close();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            new CRU_operation().insertRecord_SP();
        }
    }
}
