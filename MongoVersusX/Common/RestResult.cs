using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoVersusX.Common
{
    public class RestResult<T>
    {
        public bool IsSuccessful { get; set; }
        public string TimeElapsed { get; set; }
        public T Result { get; set; }
        public string ErrorMessage { get; set; }
    }
}
