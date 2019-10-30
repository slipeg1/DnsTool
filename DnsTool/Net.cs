using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DnsClient;
using DnsClient.Protocol;
using System.Diagnostics;
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
        //Get IPV4
        public string GetA(string url)
        {
            foreach (var aRecord in client.Query(url, QueryType.A).Answers.ARecords())
            {
                if (aRecord != null)
                {
                    string ToReturn = $"IP:{aRecord.Address}  [{aRecord.RecordType}]  DNS: {aRecord.DomainName}";
                    return ToReturn;
                }
            }
            return "No record found.";
        }
        //GET IPV6
        public string GetAAAA(string url)
        {
            foreach (var AaaaRecord in client.Query(url, QueryType.AAAA).Answers.AaaaRecords())
            {
                if (AaaaRecord != null)
                {
                    string ToReturn = $"IP:{AaaaRecord.Address}  [{AaaaRecord.RecordType}]  DNS: {AaaaRecord.DomainName}";
                    return ToReturn;
                }
            }
            return "No record found.";
        }
        //will probably be removed
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
        public string PerformWhois(string url)
        {
            Process p = new Process();
            p.StartInfo.FileName = "whois.exe";
            p.StartInfo.WorkingDirectory = Environment.CurrentDirectory;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.Arguments = "-V";
            p.StartInfo.Arguments = url;
            p.Start();


            string ToReturn = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
            return ToReturn;
        }
        public string PerformPing(string url, string PingNb)
        {
            Process p = new Process();
            p.StartInfo.FileName = "ping";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.Arguments = $"-n {PingNb} {url}";
            p.Start();

            string ToReturn = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
            return ToReturn;
        }
    }
}
