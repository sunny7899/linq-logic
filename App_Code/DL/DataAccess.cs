using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

/// <summary>
/// Summary description for DataAccess
/// </summary>
public class DataAccess
{
    public DataAccess()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Myconstr"].ToString());
    public int AddUserDetails(Bobject ObjBO) // passing Bussiness object Here 
    {
        SqlCommand cmd = new SqlCommand("sprocUserinfoInsertUpdateSingleItem", con);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@Name", ObjBO.Name);
        cmd.Parameters.AddWithValue("@Address", ObjBO.address);
        cmd.Parameters.AddWithValue("@EmailID", ObjBO.EmailID);
        cmd.Parameters.AddWithValue("@Mobilenumber", ObjBO.Mobilenumber);
        con.Open();
        int Result = cmd.ExecuteNonQuery();
        cmd.Dispose();
        return Result;
    }
}