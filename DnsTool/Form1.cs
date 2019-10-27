using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DnsClient;
using DnsClient.Protocol;

namespace DnsTool
{
    public partial class DnsToolWindow : Form
    {
        private LookupClient Client;
        private StringBuilder Str1 = new StringBuilder("");
        private Net nt = new Net();
        public DnsToolWindow()
        {
            InitializeComponent();
            Client = new LookupClient();
            Client.UseCache = true;
        }
        public void Out(string MyString)
        {
            Str1.Clear();
            Str1.Append(MyString);
            OutputWindow.Text += Str1 + "\n";
        }

        private void LookUpButton_MouseClick(object sender, MouseEventArgs e)
        {
            //Purely for testing purpose
            Out(nt.GetA(UrlTextBox.Text));
            Out(nt.GetAAAA(UrlTextBox.Text));
        }
        private void test()
        {
          
        }
    }
}
