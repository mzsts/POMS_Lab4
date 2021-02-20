using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace POMS_Lab4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageHistory : ContentPage
    {
        public List<HistoryItem> HistoryItems;
        public PageHistory()
        {
            InitializeComponent();
            HistoryItems = new List<HistoryItem>();
            historyListView.ItemsSource = HistoryItems;
        }

    }
}