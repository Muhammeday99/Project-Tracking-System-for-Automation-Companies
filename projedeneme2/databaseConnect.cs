﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace projedeneme2
{
    public class databaseConnect
    {

        /**DATABASE SERVER CONNECTOR FUNCTION
         
         It is in the namespace so we can use in all classes using that namespace.*/
        static public SqlConnection connectToSQL(){
            return new SqlConnection(@"Data source=5m-macro.database.windows.net;Initial Catalog=Project_Tracking_System;Integrated Security=False");
        }
    }
}