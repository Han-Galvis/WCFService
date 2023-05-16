using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

/// <summary>
/// Descripción breve de Methods
/// </summary>
public class Methods
{
    string con = "server=DESKTOP-V37CE5D\\SQLEXPRESS ; database=WCFservice ; integrated security = true";
    public Methods()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public List<User> GetUsers()
    {
        List<User> users = new List<User>();
        try 
        {
            using (SqlConnection conn = new SqlConnection(con))
            {
                conn.Open();

                SqlCommand command = new SqlCommand("[dbo].[sp_GetUsers]", conn);
                command.CommandType = CommandType.StoredProcedure;

                SqlDataReader registros = command.ExecuteReader();
         
                conn.Close();
                return users;


            }
        }
        catch (Exception ex)
        {
            return users;
        }
        

    }
}