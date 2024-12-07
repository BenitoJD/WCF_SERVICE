using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
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
        string GetResult(Student S);

        [OperationContract]
        int GetMax(int[] ar);

        [OperationContract]
        int[] GetSorted(int[] ar);

        [OperationContract]
        Student GetTopper(List<Student> Ls);
        [OperationContract]
        List<Country> GetAllCountry();
    }

    [DataContract]
    class Student
    {
        [DataMember]
        public int Sid { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int M1 { get; set; }
        [DataMember]
        public int M2 { get; set; }
        [DataMember]
        public int M3 { get; set; }
    }
    [DataContract]
    class Country
    {
        [DataMember]
        public int CountryId { get; set; }
        [DataMember]
        public string CountryName { get; set; }

    }
}
