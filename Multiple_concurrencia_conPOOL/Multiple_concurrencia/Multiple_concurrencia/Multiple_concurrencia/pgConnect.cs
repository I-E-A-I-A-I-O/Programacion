using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_concurrencia
{
    class pgConnect
    {
        private readonly string username = "postgres";
        private readonly string password = "JeSuS20o*";
        private readonly string db_name = "Multiple_concurrencia_test";
        private readonly string host = "localhost";
        private readonly string[] words = new string[] {"Jhon", "Jann", "Yin", "Yonh", "Yunh", "Mark", "Carl",
            "Andrea", "Maria", "Gabriela", "Antonio", "Pedro", "Carla", "Alejandra", "Alejandro",
            "Josefa", "Jose", "Chavez", "Maburro", "Guaidog", "Ernesto", "Jannet", "Elliot", "Darlene", "ability", "able", "about", "above" 
                ,"accept", "according" 
                ,"account" ,"across" ,"act" ,"action" ,"activity"
             , "actually", "add", "address", "administration", "admit", "adult", "affect", "after", "again", "against"
             , "age", "agency", "agent", "ago", "agree", "agreement", "ahead", "air", "all", "allow", "almost", "alone",
            "along", "already", "also", "although", "always", "American", "among", "amount", "analysis", "and", "animal", "another",
        "both", "box", "boy", "break", "bring", "brother", "budget", "build", "building", "business", "but",
        "buy", "by", "call", "camera", "campaign", "can", "cancer", "candidate", "capital", "car", "card",
        "care", "career", "carry", "case", "catch", "cause", "cell", "center", "central", "century", "certain",
        "certainly", "chair", "challenge", "chance", "change", "character", "charge", "check", "child", "choice"};

        public void fill_table()
        {
            int container;
            Random ran = new Random();

            var conString = String.Format("Host={0};Username={1};Password={2};Database={3}", host, username, password, db_name);
            using var con = new NpgsqlConnection(conString);
            con.Open();

            var cmd = String.Format("Insert into {0} values(@names_0, @names_1, @names_2, @names_3, @names_4, @names_5," +
                " @names_6, @names_7, @names_8, @names_9, @names_10, @names_11, @names_12, @names_13, @names_14," +
                " @names_15, @names_16, @names_17, @names_18, @names_19)", "names");

            using var ins = new NpgsqlCommand(cmd, con);

            for (int m = 0; m < 20; m++) {

                container = ran.Next(words.Length);
                ins.Parameters.AddWithValue("names_" + m.ToString(), words[container]);
            }

            ins.ExecuteNonQuery();
            con.Close();
        }

        public void do_select()
        {
            var conString = String.Format("Host={0};Username={1};Password={2};Database={3}", host, username, password, db_name);
            using var con = new NpgsqlConnection(conString);
            con.Open();

            var cmd = String.Format("Select * from {0}", "names");
            using var ins = new NpgsqlCommand(cmd, con);

            using NpgsqlDataReader rdr = ins.ExecuteReader();

            while (rdr.Read())
            {
                rdr.GetString(0);
                rdr.GetString(1);
                rdr.GetString(2);
                rdr.GetString(3);
                rdr.GetString(4);
                rdr.GetString(5);
                rdr.GetString(6);
                rdr.GetString(7);
                rdr.GetString(8);
                rdr.GetString(9);
                rdr.GetString(10);
                rdr.GetString(11);
                rdr.GetString(12);
                rdr.GetString(13);
                rdr.GetString(14);
                rdr.GetString(15);
                rdr.GetString(16);
                rdr.GetString(17);
                rdr.GetString(18);
                rdr.GetString(19);
            }

            rdr.Close();
            con.Close();
        }
    }
}
