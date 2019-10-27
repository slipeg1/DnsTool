using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DnsClient;

namespace DnsTool
{
    public partial class DnsToolWindow : Form
    {
        private LookupClient Client;
        public DnsToolWindow()
        {
            InitializeComponent();
            Client = new LookupClient();
            Client.UseCache = true;         
        }
    }
}
