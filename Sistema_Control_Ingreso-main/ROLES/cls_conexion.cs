﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ROLES
{
    public class cls_conexion
    {
        public SqlConnection connection = new SqlConnection("Data Source=DESKTOP-6MUA0BA;Initial Catalog=dbs_roles;Integrated Security=True");

    }
}