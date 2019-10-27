using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnsClient;
using DnsClient.Protocol;

namespace DnsTool
{
    class Net
    {
        private LookupClient client;
        public Net()
        {
            client = new LookupClient();
            client.UseCache = true;
        }
        public string GetA(string url)
        {
            foreach (var aRecord in client.Query(url, QueryType.A).Answers.ARecords())
            {
                if (aRecord != null)
                {
                    string ToReturn = $"IP:{aRecord.Address} Type: {aRecord.RecordType} DomainName: {aRecord.DomainName}";
                    return ToReturn;
                }
            }
            return "No record found.";
        } 
        public string GetAAAA(string url)
        {
            foreach (var aRecord in client.Query(url, QueryType.AAAA).Answers.AaaaRecords())
            {
                if (aRecord != null)
                {
                    string ToReturn = $"IP:{aRecord.Address} Type: {aRecord.RecordType} DomainName: {aRecord.DomainName}";
                    return ToReturn;
                }
            }
            return "No record found.";
        }
        public string GetHINFO(string url)
        {
            var record = client.Query(url, QueryType.ANY).Answers
                                                       .OfRecordType(ResourceRecordType
                                                       .HINFO)
                                                       .FirstOrDefault() as HInfoRecord;

            if (record != null)
            {
                string ToReturn = $"CPU:{record.Cpu} OS:{record.OS}";
                return ToReturn;
            }
            else
            {
                return "No record found.";
            }
        }
    }
}
