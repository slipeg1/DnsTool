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
            Str1.Append("["+DateTime.Now+"]\n");
            Str1.Append(MyString);
            OutputWindow.Text += Str1 + "\n";
        }

        private void LookUpButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (IPVFourBox.Checked) 
            {
                Out(nt.GetA(UrlTextBox.Text));
            }
            if (IPVSixBox.Checked) 
            {
                Out(nt.GetAAAA(UrlTextBox.Text));
            }
            if (WhoisBox.Checked) 
            {
                Out(nt.PerformWhois(UrlTextBox.Text));
            }
        }
        private void test()
        {
          
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            OutputWindow.Text = "";
        }

        private void PingButton_Click(object sender, EventArgs e)
        {
            Out(nt.PerformPing(UrlTextBox.Text, PingUpDown.Value.ToString()));
        }

        private void OutputWindow_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
