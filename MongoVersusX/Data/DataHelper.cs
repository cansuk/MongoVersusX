using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using MongoVersusX.Common;
using MongoVersusX.Common.Enums;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MongoVersusX.Data
{
    public static class DataHelper
    {
        public static bool ExecuteScript(string scriptPath, DbTypeEnum dbType)
        {
            try
            {
                bool result = false;

                switch (dbType)
                {
                    case DbTypeEnum.Sql:
                        #region SQL db reset

                        try
                        {
                            string sqlConStr = ConfigurationConstants.SqlConnectionStr;

                            string script = File.ReadAllText(scriptPath);

                            SqlConnection sqlConn = new SqlConnection(sqlConStr);

                            Server server = new Server(new ServerConnection(sqlConn));

                            server.ConnectionContext.ExecuteNonQuery(script);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                            result = false;
                        }

                        #endregion SQL db reset
                        break;
                    case DbTypeEnum.Postgre:
                        break;
                    case DbTypeEnum.Mongo:
                        break;
                    default:
                        break;
                }

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }           
        }

    }
}
