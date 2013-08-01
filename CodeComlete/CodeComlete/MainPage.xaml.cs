using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using CodeComlete.Resources;
using CodeComlete.Model;

namespace CodeComlete
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            listBox.ItemsSource = Global.CodePieces;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e != null && e.AddedItems != null && e.AddedItems.Count > 0)
            {
                var item = e.AddedItems[0] as CodeEntity;
                NavigationService.Navigate(new Uri("/CodeView.xaml?id=" + item.Index, UriKind.Relative));
            }
        }
    }
}