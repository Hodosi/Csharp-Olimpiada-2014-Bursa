using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Bursa
{
    class ACTIUNI
    {
        CONNECT conn = new CONNECT();

        public void deleteActiunileMele()
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "Delete From ActiunileMele";
            command.Connection = conn.GetConnection();

            conn.openConnection();
            command.ExecuteNonQuery();
            conn.closeConnection();
        }
        public void initActiunileMele()
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "INSERT INTO ActiunileMele(Denumire,Numar_Actiuni,Valoare_Actiune_Initial,Valoare_Actiune_Momentana,Total_Valoare_Initiala) SELECT Denumire,NrActiuni,Valoare,Valoare,NrActiuni*Valoare FROM Actiuni";
            command.Connection = conn.GetConnection();

            conn.openConnection();
            command.ExecuteNonQuery();
            conn.closeConnection();

            //command.CommandText = "INSERT INTO ActiunileMele(Total_Valoare_Initiala) SELECT NrActiuni*Valoare FROM Actiuni";

        }

        public DataTable getBursaInitiala()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = conn.GetConnection();
            command.CommandText = "Select * From ActiunileMele";
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }
    }
}
