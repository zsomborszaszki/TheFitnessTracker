using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheFitnessTracker;
using MySqlConnector;



namespace MyApp.Tests
{
    [TestClass]
    public class BasicTests
    {

        [TestMethod]
        public void RecordTest()
        {
            string aktSportag = "Futás";
            string aktHelyszin = "Budapest";
            int aktIdotartam = 30;
            DateTime aktDatum = new DateTime(2026, 03, 19);
            string cs = @"server=localhost;userid=root;port=3307;password=;database=test";
            string query = "INSERT INTO sporttev(Sportág,Dátum,Időtartam,Helyszín) VALUES (@sportag,@datum,@idotartam,@helyszin)";


            using (MySqlConnection cs = new MySqlConnection(cs))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, cs))
                {
                    cmd.Parameters.AddWithValue("@sportag", aktSportag);
                    cmd.Parameters.AddWithValue("@datum", aktDatum);
                    cmd.Parameters.AddWithValue("@idotartam", aktIdotartam);
                    cmd.Parameters.AddWithValue("@helyszin", aktHelyszin);

                    con.Open();
                    cmd.ExecuteNonQuery();

                    string selectQuery = "SELECT sportag, datum, helyszin, idotartam FROM sporttev WHERE sportag = @sportag ORDER BY id DESC LIMIT 1";
                    using (MySqlCommand selectCmd = new MySqlCommand(selectQuery, cs))
                    {
                        selectCmd.Parameters.AddWithValue("@sportag", aktSportag);

                        using (MySqlDataReader reader = selectCmd.ExecuteReader())
                        {
                            Assert.IsTrue(reader.Read());
                            Assert.AreEqual("Futás", reader.GetString("sportag"));
                            Assert.AreEqual("Budapest", reader.GetString("helyszin"));
                            Assert.AreEqual(30, reader.GetInt32("idotartam"));
                        }
                    }
                }
            }
        }



    }
}
