using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace Browser
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NewTab();
        }

        private void Browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            // throw new NotImplementedException();//
            WebBrowser browser = metroTabControl1.SelectedTab.Controls[0] as WebBrowser;
            if (browser != null)
                metroTabControl1.SelectedTab.Text = browser.DocumentTitle;
        }

        private void InkBack_Click(object sender, EventArgs e)
        {
            WebBrowser browser = metroTabControl1.SelectedTab.Controls[0] as WebBrowser;
            if (browser != null)
            {
                if (browser.CanGoBack)
                    browser.GoBack();
            }
        }

        private void InkForward_Click(object sender, EventArgs e)
        {
            WebBrowser browser = metroTabControl1.SelectedTab.Controls[0] as WebBrowser;
            if (browser != null)
            {
                if (browser.CanGoForward)
                    browser.GoForward();
            }
        }

        private void BtnGO_Click(object sender, EventArgs e)
        {
            WebBrowser browser = metroTabControl1.SelectedTab.Controls[0] as WebBrowser;
            if (browser != null)
                browser.Navigate(txtUrl.Text);
        }

        private void BtnNewTab_Click(object sender, EventArgs e)
        {
            NewTab();
        }

        private void NewTab()
        {
            TabPage tab = new TabPage();
            tab.Text = "New tab";
            metroTabControl1.Controls.Add(tab);
            metroTabControl1.SelectTab(metroTabControl1.TabCount - 1);
            WebBrowser browser = new WebBrowser() { ScriptErrorsSuppressed = true };
            browser.Parent = tab;
            browser.Dock = DockStyle.Fill;
            browser.Navigate("https://www.google.com");
            txtUrl.Text = "https://www.google.com";
            browser.DocumentCompleted += Browser_DocumentCompleted;
        }

        private void BtnToolbar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
