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
        private List<string> history;
        private int addressCounter;
        private String homeaddress;
        public Browser()
        {
            history = new List<string>();
            addressCounter = -1;
            homeaddress = "reddit.com";
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
            }
            try
            {
                txt_url.Text = address;
                webBrowser.Navigate(new Uri(address));
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
            navigateHistory("B");
        }

        private void panel_forward_MouseClick(object sender, MouseEventArgs e)
        {
            navigateHistory("F");
        }

        private void navigateHistory(String sender)
        {
            int counter = -1;
            foreach (string url in history)
            {
                counter++;
                if (counter == addressCounter + 1 && sender == "F" || counter == addressCounter - 1 && sender == "B")
                {
                    txt_url.Text = url;
                    webBrowser.Navigate(new Uri(url));
                    addressCounter = counter;
                    break;
                }
            }
        }
        private void panel_home_Click(object sender, EventArgs e)
        {
            GotoAddress(homeaddress);
            updatePanels();
        }

        private void Browser_Load(object sender, EventArgs e)
        {
            GotoAddress(homeaddress);
            webBrowser.ScriptErrorsSuppressed = true;
        }

        private void panel_refresh_Click(object sender, EventArgs e)
        {
            if (!webBrowser.Url.Equals("about:blank"))
            {
                webBrowser.Refresh();
            }
        }

        private void panel_refresh_MouseHover(object sender, EventArgs e)
        {
            panel_refresh.BackColor = SystemColors.ActiveCaption;
        }

        private void panel_home_MouseHover(object sender, EventArgs e)
        {
            panel_home.BackColor = SystemColors.ActiveCaption;
        }

        private void panel_forward_MouseHover(object sender, EventArgs e)
        {
            if (panel_forward.BackColor == SystemColors.Control)
            {
                panel_forward.BackColor = SystemColors.ActiveCaption;
            }
        }

        private void panel_back_MouseHover(object sender, EventArgs e)
        {
            if (panel_back.BackColor == SystemColors.Control)
            {
                panel_back.BackColor = SystemColors.ActiveCaption;
            }
        }

        private void panel_home_MouseLeave(object sender, EventArgs e)
        {
            panel_home.BackColor = SystemColors.Control;
        }

        private void panel_refresh_MouseLeave(object sender, EventArgs e)
        {
            panel_refresh.BackColor = SystemColors.Control;
        }

        private void panel_forward_MouseLeave(object sender, EventArgs e)
        {
            updatePanels();
        }

        private void panel_back_MouseLeave(object sender, EventArgs e)
        {
            updatePanels();
        }

        private void updatePanels()
        {
            if (addressCounter > 0)
            {
                panel_back.BackColor = SystemColors.Control;
            }
            else
            {
                panel_back.BackColor = SystemColors.ControlDark;
            }
            if (addressCounter < history.Count() - 1)
            {
                panel_forward.BackColor = SystemColors.Control;
            }
            else
            {
                panel_forward.BackColor = SystemColors.ControlDark;
            }
        }

        private void webBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            if (webBrowser.Url != null && webBrowser.Url.ToString() != txt_url.Text)
            {
                addressCounter++;
                if (addressCounter < history.Count)
                {
                    for (int i = history.Count; i > addressCounter && addressCounter > 0; i--)
                    {
                        history.RemoveAt(i - 1);
                    }
                }
                txt_url.Text = webBrowser.Url.ToString();
                webBrowser.Navigate(new Uri(webBrowser.Url.ToString()));
                history.Add(webBrowser.Url.ToString());
                updatePanels();
            }
        }
    }
}
