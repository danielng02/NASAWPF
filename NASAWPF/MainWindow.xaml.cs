using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.RegularExpressions;
using System.Collections.ObjectModel;
using System.Net.Http;

namespace NASAWPF
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string linkJSON  { get; set; }
        public static ObservableCollection<Neo> ListOfNeos { get; set; }
        public static Root data;
        public MainWindow()
        {
            InitializeComponent();
        }


        public void Button_Click(object sender, RoutedEventArgs e)
        {
            DataLoad();
        }
        private async void DataLoad()
        {
            string apiKey = "fDYUz8mf87gs1b8txmdHol2s7eTlQLJeL9PfnGql";


            string startDate = Convert.ToDateTime(DatePickStart.Text).ToString("yyyy-MM-dd");
            string endDate = Convert.ToDateTime(DatePickEnd.Text).ToString("yyyy-MM-dd");
            linkJSON = String.Format("https://api.nasa.gov/neo/rest/v1/feed?start_date={0}&end_date={1}&api_key={2}", startDate, endDate, apiKey);

            TaskObject response = await LinkRead(linkJSON);

            Regex rgx = new Regex(@"\d{4}[-]\d{2}[-]\d{2}");
            string myJSON = rgx.Replace(response.json, "dateSpotted");

            data = JsonConvert.DeserializeObject<Root>(myJSON);

            List<Neo> mergeList = new List<Neo>(data.near_earth_objects.neos01);
            mergeList.AddRange(data.near_earth_objects.neos02);

            ListOfNeos = new ObservableCollection<Neo>(mergeList);

            ListView.ItemsSource = ListOfNeos;

            label01.Content = data.element_count;
        }

        public static async Task<TaskObject> LinkRead(string url)
        {
            HttpClient client = new HttpClient();
            var textJSON = await client.GetAsync(url);
            return new TaskObject { json = await textJSON.Content.ReadAsStringAsync() };
        }
    }
    public class TaskObject
    {
        public string json { get; set; }

    }
}
