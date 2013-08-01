using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace CodeComlete
{
    public partial class CodeView : PhoneApplicationPage
    {
        public CodeView()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (NavigationContext.QueryString != null && NavigationContext.QueryString.Count > 0 && NavigationContext.QueryString.ContainsKey("id"))
            {
                textBlock.Text = Global.Codes.First(a => a.Index == Convert.ToInt32(NavigationContext.QueryString["id"].ToString())).Code.ToString();
            }
            base.OnNavigatedTo(e);
        }
    }
}