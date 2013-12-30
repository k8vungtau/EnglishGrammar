using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using EnglishGrammar.Resources;
using Newtonsoft.Json;

namespace EnglishGrammar
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            setCategoryList();
            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void setCategoryList()
        {
            lstCategory.DataContext = SingleTonData.Instance.category();
            System.Diagnostics.Debug.WriteLine(SingleTonData.Instance.category()[0].pageName[1]);
        }

        private void lstCategory_SelectionChange(object sender, SelectionChangedEventArgs e)
        {
            Category category = lstCategory.SelectedItem as Category;
            PhoneApplicationService.Current.State["Category"] = category;
            //System.Diagnostics.Debug.WriteLine(id);
            NavigationService.Navigate(new Uri("/CategoryDetail.xaml", UriKind.Relative));
        }
    }
}