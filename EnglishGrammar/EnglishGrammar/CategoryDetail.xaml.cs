using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace EnglishGrammar
{
    public partial class CategoryDetail : PhoneApplicationPage
    {        
        Category category;
        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            var k = PhoneApplicationService.Current.State["Category"];
            category = (Category)k;
            //string Name = NavigationContext.QueryString["Name"];
            ParaTitle.Text = category.title;            
            //System.Diagnostics.Debug.WriteLine(category.title);

            addParaItem();
            base.OnNavigatedTo(e);
        }
        public CategoryDetail()
        {
            InitializeComponent();
            
            
        }

        private void addParaItem()
        {
            PanoramaItem panoItem = new PanoramaItem();
            WebBrowser webBrower = new WebBrowser();
            for(int i = 0; i < category.pageName.Count; i++) {
                panoItem = new PanoramaItem();
                panoItem.Header = category.pageName[i];
                PageView.Items.Add(panoItem);
                webBrower = new WebBrowser();
                webBrower.Navigate(new Uri(category.pageURL[i], UriKind.Absolute));
                panoItem.Content = webBrower;
            }
            //panoItem.Header = 
            
        }
    }
}