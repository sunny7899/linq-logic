using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Blogic
/// </summary>
public class Blogic
{
    public Blogic()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public int SaveUserregisrationBL(Bobject objUserBL) // passing Bussiness object Here 
    {
        Bobject objUserda = new Bobject(); // Creating object of Dataccess

        return objUserda.AddUserDetails(objUserBL);
    }