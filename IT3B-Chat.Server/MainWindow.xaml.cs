using System.Text;
using System.Threading;
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
using System.Net;
using System.Net.WebSockets;

namespace IT3B_Chat.Server
{
 /// <summary>
 /// Interaction logic for MainWindow.xaml
 /// </summary>
    public partial class MainWindow : Window
    {
        private HttpListener _listener;
         public MainWindow()
         {
            InitializeComponent();
            
         }
        private async void StartServer()
        {
            _listener = new HttpListener();
            _listener.Prefixes.Add("http://localhost:8080/");
            _listener.Start();
            AddMessage();
        }

        private void AddMessage()
        {
            Dispatcher.Invoke();
        }
    }
}