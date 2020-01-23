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

        public DataTable getBursa()
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

        public void updateCrestere(int r, string nume)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "Update ActiunileMele Set Crescut_Scazut=@r Where Denumire=@nume ";
            command.Connection = conn.GetConnection();

            command.Parameters.Add("r", SqlDbType.Int).Value = r;
            command.Parameters.Add("nume", SqlDbType.VarChar).Value = nume;

            conn.openConnection();
            command.ExecuteNonQuery();
            conn.closeConnection();
        }

        public void updateValMomentana()
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "Update ActiunileMele Set Valoare_Actiune_Momentana=Valoare_Actiune_Momentana+Crescut_Scazut";
            command.Connection = conn.GetConnection();

            conn.openConnection();
            command.ExecuteNonQuery();
            conn.closeConnection();
        }
        public void updateValTotalInit()
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "Update ActiunileMele Set Total_Valoare_Initiala=Numar_Actiuni*Valoare_Actiune_Initial";
            command.Connection = conn.GetConnection();

            conn.openConnection();
            command.ExecuteNonQuery();
            conn.closeConnection();
        }

        public void updateValTotalMoment()
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "Update ActiunileMele Set Total_Valoare_Momentana=Numar_Actiuni*Valoare_Actiune_Momentana";
            command.Connection = conn.GetConnection();

            conn.openConnection();
            command.ExecuteNonQuery();
            conn.closeConnection();
        }

        public void updateProfitMoment()
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "Update ActiunileMele Set Profit_Pierdere_Momentana=Numar_Actiuni*Crescut_Scazut";
            command.Connection = conn.GetConnection();

            conn.openConnection();
            command.ExecuteNonQuery();
            conn.closeConnection();
        }

        public void updateProfitTotal()
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "Update ActiunileMele Set Profit_Pierdere_Totala=Total_Valoare_Initiala*Profit_Pierdere_Momentana";
            command.Connection = conn.GetConnection();

            conn.openConnection();
            command.ExecuteNonQuery();
            conn.closeConnection();
        }

        public int getProfit()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = conn.GetConnection();
            command.CommandText = "Select SUM(Profit_Pierdere_Totala) From ActiunileMele";

            conn.openConnection();
            int s = Convert.ToInt32(command.ExecuteScalar()); ;
            conn.closeConnection();

            return s;
        }

    }
}
