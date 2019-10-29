using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
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


        //Not my code
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;
        ///
        /// Handling the window messages
        ///
        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
                message.Result = (IntPtr)HTCAPTION;
        }
        //////////////////////////////////////////////////////////////////////

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
            Out($"Please wait for {UrlTextBox.Text} to respond...");
            OutputWindow.Refresh();
            Out(nt.PerformPing(UrlTextBox.Text, PingUpDown.Value.ToString()));
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void DnsToolWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
