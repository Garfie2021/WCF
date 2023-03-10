using CoreWCF;
using CoreWCFService1.Model;
using CoreWCFService1.SQL;
using System;
using System.Runtime.Serialization;

namespace CoreWCFService1
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        void InsertTABLE1(TABLE1 TABLE1);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);
    }

    public class Service : IService
    {
        public string GetData(int value)
        {
            var msg = string.Format("You entered: {0}", value);
            return msg;
        }

        public void InsertTABLE1(TABLE1 TABLE1)
        {
            SQL_TABLE1.Transaction1(TABLE1);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
