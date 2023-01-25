using CoreWCF;
using System;
using System.Runtime.Serialization;
using System.Text;

namespace CoreWCFService1
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);
    }

    public partial class Service : IService
    {
        public string GetData(int value, [Injected] HttpResponse httpResponse, [Injected] HttpRequest httpRequest)
        {
            var sb = new StringBuilder();
            foreach (var header in httpRequest.Headers)
            {
                sb.AppendLine($"{header.Key} : {header.Value}");
            }
            sb.AppendLine($"Path : {httpRequest.Path}");
            sb.AppendLine($"Method : {httpRequest.Method}");
            sb.AppendLine($"Host : {httpRequest.Host}");
            sb.AppendLine($"Protocol : {httpRequest.Protocol}");
            sb.AppendLine($"ContentType : {httpRequest.ContentType}");
            sb.AppendLine($"ContentLength : {httpRequest.ContentLength}");
            sb.AppendLine($"IsHttps : {httpRequest.IsHttps}");
            foreach (var query in httpRequest.Query)
            {
                sb.AppendLine($"{query.Key} : {query.Value}");
            }
            foreach (var cookies in httpRequest.Cookies)
            {
                sb.AppendLine($"{cookies.Key} : {cookies.Value}");
            }

            var str = sb.ToString();

            var msg = string.Format("You entered: {0}", value);
            return msg;
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
