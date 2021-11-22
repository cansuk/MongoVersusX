using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoVersusX.Common;
using MongoVersusX.Common.Enums;
using MongoVersusX.Data;

namespace MongoVersusX.API
{
    [Route("api/[controller]/{action}")]
    [ApiController]
    public class InitController : ControllerBase
    {
        [HttpGet]
        public bool IsOk()
        {
            return true;
        }
        // normalde :
        //[HttpPost]
        //public bool InsertTestDataToDb([FromBody]string sourceScriptPath, DbTypeEnum targetDb)
        //{            
        //    return DataHelper.ExecuteScript(sourceScriptPath, targetDb);
        //}
        // şimdilik :
        [HttpPost]
        public bool InsertTestDataToDb()
        {
            try
            {
                string sourceScriptPath = @"D:\documents\mssql\xab.sql";
                //List<string> scriptNames = new List<string>();
                //scriptNames.Add("xab.sql");
                DbTypeEnum targetDb = DbTypeEnum.Sql;

                return DataHelper.ExecuteScript(sourceScriptPath, targetDb);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}