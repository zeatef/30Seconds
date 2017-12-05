using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ThirtySeconds
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.Title = this.CurrentPage.Title;
            this.CurrentPageChanged += CurrentPageHasChanged;

        }

        protected void CurrentPageHasChanged(object sender, EventArgs e)
        {
            this.Title = this.CurrentPage.Title;
        }
    }
}
