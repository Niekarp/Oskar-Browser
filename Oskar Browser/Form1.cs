using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oskar_Browser
{
    public partial class MainWindow : Form
    {
        private bool _urlFieldLostFocus = true;
        #region TabThings
        private readonly Dictionary<Button, Gecko.GeckoWebBrowser> _tabs = new Dictionary<Button, Gecko.GeckoWebBrowser>();
        private Button _currentTab = null;
        private string _defaultNewTabPageAdress = "http://www.google.pl/";

        private void AddNewTab()
        {
            var newTabButton = new Button();
            Controls.Add(newTabButton);
            newTabButton.BackColor = System.Drawing.SystemColors.Control;
            newTabButton.FlatAppearance.BorderSize = 0;
            newTabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            newTabButton.ForeColor = System.Drawing.Color.Black;
            newTabButton.Location = new System.Drawing.Point(-2 + (160 * _tabs.Count), -2);
            newTabButton.Name = "TabButton";
            newTabButton.Size = new System.Drawing.Size(162, 26);
            newTabButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            newTabButton.UseVisualStyleBackColor = false;
            newTabButton.MouseDown += new System.Windows.Forms.MouseEventHandler(TabClick);


            var newBrowserForm = new Gecko.GeckoWebBrowser();
            Controls.Add(newBrowserForm);
            newBrowserForm.AllowDrop = true;
            newBrowserForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            newBrowserForm.Location = new System.Drawing.Point(-1, 74);
            newBrowserForm.Name = "BrowserForm";
            newBrowserForm.Size = new System.Drawing.Size(this.Size.Width - 15, this.Size.Height - 113);
            newBrowserForm.TabIndex = 4;
            newBrowserForm.UseHttpActivityObserver = false;
            newBrowserForm.Navigating += new System.EventHandler<Gecko.Events.GeckoNavigatingEventArgs>(BrowserForm_Navigating);
            newBrowserForm.DocumentCompleted += new System.EventHandler<Gecko.Events.GeckoDocumentCompletedEventArgs>(BrowserForm_DocumentCompleted);
            newBrowserForm.CanGoBackChanged += new System.EventHandler(BrowserForm_CanGoBackChanged);
            newBrowserForm.CanGoForwardChanged += new System.EventHandler(BrowserForm_CanGoForwardChanged);
            newBrowserForm.CreateWindow += new System.EventHandler<Gecko.GeckoCreateWindowEventArgs>(BrowserForm_CreateWindow);
            newBrowserForm.DomFocus += new System.EventHandler<Gecko.DomEventArgs>(BrowserForm_DomFocus);

            _tabs.Add(newTabButton, newBrowserForm);
            newBrowserForm.Navigate(_defaultNewTabPageAdress);
            SwapTab(newTabButton);

            AddTabButton.Location = new System.Drawing.Point(-2 + (160 * _tabs.Count), -2);
        }
        private void AddNewTab(string firstUrl)
        {
            var newTabButton = new Button();
            Controls.Add(newTabButton);
            newTabButton.BackColor = System.Drawing.SystemColors.Control;
            newTabButton.FlatAppearance.BorderSize = 0;
            newTabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            newTabButton.ForeColor = System.Drawing.Color.Black;
            newTabButton.Location = new System.Drawing.Point(-2 + (160 * _tabs.Count), -2);
            newTabButton.Name = "TabButton";
            newTabButton.Size = new System.Drawing.Size(162, 26);
            newTabButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            newTabButton.UseVisualStyleBackColor = false;
            newTabButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TabClick);


            var newBrowserForm = new Gecko.GeckoWebBrowser();
            Controls.Add(newBrowserForm);
            newBrowserForm.AllowDrop = true;
            newBrowserForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            newBrowserForm.Location = new System.Drawing.Point(-1, 74);
            newBrowserForm.Name = "BrowserForm";
            newBrowserForm.Size = new System.Drawing.Size(this.Size.Width - 15, this.Size.Height - 113);
            newBrowserForm.TabIndex = 4;
            newBrowserForm.UseHttpActivityObserver = false;
            newBrowserForm.Navigating += new System.EventHandler<Gecko.Events.GeckoNavigatingEventArgs>(BrowserForm_Navigating);
            newBrowserForm.DocumentCompleted += new System.EventHandler<Gecko.Events.GeckoDocumentCompletedEventArgs>(BrowserForm_DocumentCompleted);
            newBrowserForm.CanGoBackChanged += new System.EventHandler(BrowserForm_CanGoBackChanged);
            newBrowserForm.CanGoForwardChanged += new System.EventHandler(BrowserForm_CanGoForwardChanged);
            newBrowserForm.CreateWindow += new System.EventHandler<Gecko.GeckoCreateWindowEventArgs>(BrowserForm_CreateWindow);
            newBrowserForm.DomFocus += new System.EventHandler<Gecko.DomEventArgs>(BrowserForm_DomFocus);

            _tabs.Add(newTabButton, newBrowserForm);
            newBrowserForm.Navigate(firstUrl);
            SwapTab(newTabButton);

            AddTabButton.Location = new System.Drawing.Point(-2 + (160 * _tabs.Count), -2);
        }
        private void RemoveTab(Button tab)
        {
            Controls.Remove(_tabs[tab]);
            Controls.Remove(tab);
            _tabs[tab].Dispose();
            _tabs.Remove(tab);

            if (tab == _currentTab && _tabs.Count > 0)
            {
                _currentTab = null;
                var tabToSrang = _tabs.Keys.OrderBy(btn => Math.Abs(btn.Location.X - tab.Location.X - 1)).First();
                SwapTab(tabToSrang);
            }

            var tabsToMove = _tabs.Keys.Where(btn => btn.Location.X > tab.Location.X);
            foreach (var btn in tabsToMove)
                btn.Location += new Size(-160, 0);

            if (_tabs.Count == 0)
            {
                _currentTab = null;
                UrlField.Text = "";
            }

            AddTabButton.Location = new Point(AddTabButton.Location.X - 160, -2);
        }
        private void SwapTab(Button tab)
        {
            if (_currentTab != null)
            {
                _currentTab.BackColor = System.Drawing.SystemColors.Control;
                _currentTab.FlatAppearance.BorderSize = 0;
                _currentTab.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
                tab.Size = new Size(162, 26);
                _tabs[_currentTab].Hide();
            }

            _currentTab = tab;
            _tabs[_currentTab].Show();
            _tabs[_currentTab].Focus();
            UrlField.Text = (string)_currentTab.Tag;
            UpdateDirectionButtons();

            tab.BackColor = System.Drawing.SystemColors.ScrollBar;
            tab.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            tab.Size = new Size(163, 26);
            tab.SendToBack();
        }
        #endregion

        public MainWindow()
        {
            InitializeComponent();

            PreviousPageButton.BackColor = Color.Silver;
            PreviousPageButton.ForeColor = Color.Red;
            NextPageButton.BackColor = Color.Silver;
            NextPageButton.ForeColor = Color.Red;

            AddNewTab();
            _tabs[_currentTab].Navigate(_defaultNewTabPageAdress);
        }

        #region Events
        private void PreviousPage_MouseDown(object sender, MouseEventArgs e)
        {
            if (_currentTab != null)
            {
                if (_tabs[_currentTab].CanGoBack)
                {
                    _tabs[_currentTab].GoBack();
                }
            }
        }
        private void NextPage_MouseDown(object sender, MouseEventArgs e)
        {
            if (_currentTab != null)
            {
                if (_tabs[_currentTab].CanGoForward)
                {
                    _tabs[_currentTab].GoForward();
                }
            }
        }
        private void UrlField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && _currentTab != null)
            {
                if (!UrlField.Text.Contains('.'))
                {
                    _tabs[_currentTab].Navigate("https://www.google.pl/?gws_rd=ssl#q=" + UrlField.Text);
                }
                else _tabs[_currentTab].Navigate(UrlField.Text);

                _urlFieldLostFocus = true;
            }
        }
        private void BrowserForm_Navigating(object sender, Gecko.Events.GeckoNavigatingEventArgs e)
        {
            _tabs[_currentTab].Cursor = Cursors.WaitCursor;
            PageLoadingButton.BackColor = Color.SandyBrown;
        }
        private void RefreshButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (_currentTab != null)
                _tabs[_currentTab].Navigate(_tabs[_currentTab].Url.AbsoluteUri);
        }
        private void BrowserForm_DocumentCompleted(object sender, Gecko.Events.GeckoDocumentCompletedEventArgs e)
        {
            var actualTab = _tabs.Where(v => v.Value == (sender as Gecko.GeckoWebBrowser)).First().Key;
            if (actualTab == _currentTab)
            {
                UrlField.Clear();
                _currentTab.Tag = _tabs[_currentTab].Url.AbsoluteUri;
                UrlField.Text = (string)_currentTab.Tag;
            }
            else
                actualTab.Tag = _tabs[actualTab].Url.AbsoluteUri;

            PageLoadingButton.BackColor = Color.LightSteelBlue;

            actualTab.Text = (sender as Gecko.GeckoWebBrowser).DomDocument.Title;
        }
        private void HomePageButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (_currentTab != null)
                _tabs[_currentTab].Navigate("www.google.pl");
        }
        private void BrowserForm_CreateWindow(object sender, Gecko.GeckoCreateWindowEventArgs e)
        {
            AddNewTab(e.Uri);
            e.Cancel = true;
        }
        private void BrowserForm_CanGoBackChanged(object sender, EventArgs e)
        {
            if (_tabs[_currentTab].CanGoBack)
            {
                PreviousPageButton.BackColor = Color.Transparent;
                PreviousPageButton.ForeColor = Color.Black;
            }
            else
            {
                PreviousPageButton.BackColor = Color.Silver;
                PreviousPageButton.ForeColor = Color.Red;
            }
        }
        private void BrowserForm_CanGoForwardChanged(object sender, EventArgs e)
        {
            if (_tabs[_currentTab].CanGoForward)
            {
                NextPageButton.BackColor = Color.Transparent;
                NextPageButton.ForeColor = Color.Black;
            }
            else
            {
                NextPageButton.BackColor = Color.Silver;
                NextPageButton.ForeColor = Color.Red;
            }
        }
        private void UrlField_Leave(object sender, EventArgs e)
        {
            _urlFieldLostFocus = true;
            if (_currentTab != null) _currentTab.Tag = UrlField.Text;
        }
        private void UrlField_MouseUp(object sender, MouseEventArgs e)
        {
            if (!_urlFieldLostFocus) return;
            UrlField.SelectAll();
            _urlFieldLostFocus = false;
        }
        private void BrowserForm_DomFocus(object sender, Gecko.DomEventArgs e)
        {
            if (_currentTab != null)
                _tabs[_currentTab].Focus();
        }
        private void AddTabButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.AddNewTab();
        }
        private void TabClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                RemoveTab(sender as Button);
            }
            else if (e.Button == MouseButtons.Left)
            {
                SwapTab(sender as Button);
            }
        }
        #endregion
        private void UpdateDirectionButtons()
        {
            if (_tabs[_currentTab].CanGoBack)
            {
                PreviousPageButton.BackColor = Color.Transparent;
                PreviousPageButton.ForeColor = Color.Black;
            }
            else
            {
                PreviousPageButton.BackColor = Color.Silver;
                PreviousPageButton.ForeColor = Color.Red;
            }
            if (_tabs[_currentTab].CanGoForward)
            {
                NextPageButton.BackColor = Color.Transparent;
                NextPageButton.ForeColor = Color.Black;
            }
            else
            {
                NextPageButton.BackColor = Color.Silver;
                NextPageButton.ForeColor = Color.Red;
            }
        }
    }
}