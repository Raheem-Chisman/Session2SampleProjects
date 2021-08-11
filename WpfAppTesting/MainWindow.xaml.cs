using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace WpfAppTesting
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private readonly HttpClient client = new HttpClient();

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var stringTask =  await client.GetStringAsync("https://b2cwebapirestendpoint.azurewebsites.net/api/TodoItems");

            var listOfItems = JsonConvert.DeserializeObject<List<TodoItem>>(stringTask);
           
            icTodoList.ItemsSource = listOfItems;
        }
    }
    public class TodoItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete{ get; set; }
    }
}
