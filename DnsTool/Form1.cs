using System;
using System.Text;
using System.Windows.Forms;
using DnsClient;


namespace DnsTool
{
  /*I would love to give the software more funcions.
   * But I don't know any dns that let me display all this informations.
   * I have no way of testing to know if anything work appart for ipv4/ipv6, whois, ping.
   */
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
            Str1.Append("---["+DateTime.Now+"]---\n");
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
            button1.Image = Properties.Resources.XButton;
            button2.Image = Properties.Resources.MiniMizeLayer1;
            LookUpButton.Image = Properties.Resources.LookUpButton;
            PingButton.Image = Properties.Resources.PingButton;
            ClearButton.Image = Properties.Resources.ClearButton;
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.Image = Properties.Resources.XButtonDown;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Image = Properties.Resources.XButton;
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            button2.Image = Properties.Resources.MinimizeDown;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Image = Properties.Resources.MiniMizeLayer1;
        }

        private void LookUpButton_MouseDown(object sender, MouseEventArgs e)
        {
            LookUpButton.Image = Properties.Resources.LookUpButtonDown;
        }

        private void LookUpButton_MouseLeave(object sender, EventArgs e)
        {
            LookUpButton.Image = Properties.Resources.LookUpButton;
        }

        private void LookUpButton_MouseUp(object sender, MouseEventArgs e)
        {
            LookUpButton.Image = Properties.Resources.LookUpButton;
        }

        private void PingButton_MouseDown(object sender, MouseEventArgs e)
        {
            PingButton.Image = Properties.Resources.PingButtonDown;
        }

        private void PingButton_MouseLeave(object sender, EventArgs e)
        {
            PingButton.Image = Properties.Resources.PingButton;
        }

        private void PingButton_MouseUp(object sender, MouseEventArgs e)
        {
            PingButton.Image = Properties.Resources.PingButton;
        }

        private void ClearButton_MouseDown(object sender, MouseEventArgs e)
        {
            ClearButton.Image = Properties.Resources.ClearButtonDown;
        }

        private void ClearButton_MouseLeave(object sender, EventArgs e)
        {
            ClearButton.Image = Properties.Resources.ClearButton;
        }

        private void ClearButton_MouseUp(object sender, MouseEventArgs e)
        {
            ClearButton.Image = Properties.Resources.ClearButton;
        }
    }
}
