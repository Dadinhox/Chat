using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
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

namespace Chat
{

    public partial class MainWindow : Window
    { 

        public MainWindow()
        {
            Thread T = new Thread(funzionethread);
            Condivisa c = new Condivisa();
          
            T.Start(c);
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Chat C = new Chat(txtNickname.Text);
            C.Show();
        }

        private void TxtNickname_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtNickname.Text != "")
            {
                btnLogin.IsEnabled = true;


            }
        }
        void funzionethread(object o)
        {
            Condivisa c = (Condivisa)o;
            TcpListener listener = new TcpListener(2003);
            TcpClient client = listener.AcceptTcpClient();
            StringWriter sw = new StringWriter(client.GetStream());
            
        }
        void client()
        {
            TcpClient c = new TcpClient("localhost", 666);

        }
   
     
    }
}
