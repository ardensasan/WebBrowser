using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class Browser : Form
    {
        List<string> history;
        int addressCounter;
        public Browser()
        {
            history = new List<string>();
            addressCounter = -1;
            InitializeComponent();
        }

        private void GotoAddress(String address)
        {
            if (String.IsNullOrEmpty(address)) return;
            if (address.Equals("about:blank")) return;
            if (!address.StartsWith("http://") &&
                !address.StartsWith("https://"))
            {
                address = "https://" + address;
                addressCounter++;
                history.Add(address);
            }
            try
            {
                txt_url.Text = address;
                webrowser.Navigate(new Uri(address));
            }
            catch (System.UriFormatException)
            {
                return;
            }
        }

        private void txt_url_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GotoAddress(txt_url.Text);
                e.SuppressKeyPress = true;
            }
        }

        private void panel_back_MouseClick(object sender, MouseEventArgs e)
        {
            int counter = -1;
            foreach (string url in history)
            {
                counter++;
                if (counter == addressCounter - 1)
                {
                    txt_url.Text = url;
                    webrowser.Navigate(new Uri(url));
                    addressCounter = counter;
                    break;
                }
            }
        }

        private void panel_forward_MouseClick(object sender, MouseEventArgs e)
        {
            int counter = -1;
            foreach (string url in history)
            {
                counter++;
                if (counter == addressCounter+1)
                {
                    txt_url.Text = url;
                    webrowser.Navigate(new Uri(url));
                    addressCounter = counter;
                    break;
                }
            }
        }
    }
}
