﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace TestService
{
    [ServiceContract]
    interface IMyService
    {
        [OperationContract]
        string GetData();
        [OperationContract]
        string GetMessage(string Name);
        [OperationContract]
        string GetResult(int Sid, string SName, int M1, int M2, int M3);

        [OperationContract]
        int GetMax(int[] ar);

        [OperationContract]
        int[] GetSorted(int[] ar);
        
    }
}
