using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace TestService
{
     class MyService : IMyService
    {
        public string GetData()
        {
            return "www.Benify.com";
        }
    }
}
