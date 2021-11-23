﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
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

namespace Chat
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string nickname, messaggio,nickname2,risposta;
        int porta = 2003;

        private void TxtNickname_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtNickname.Text != "")
            {
                btnInvia.IsEnabled = true;


            }
        }

        private void BtnInvia_Click(object sender, RoutedEventArgs e)
        {
            byte[] data = Encoding.ASCII.GetBytes("m;" + txtMessaggio.Text + ";");

            client.Send(data, data.Length, "localhost", porta);
        }

        private void TxtMessaggio_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtMessaggio.Text != "")
            {
                btnInvia.IsEnabled = true;


            }
        }

        UdpClient client = new UdpClient();

        public MainWindow()
        {
            InitializeComponent();
        }
    }
}