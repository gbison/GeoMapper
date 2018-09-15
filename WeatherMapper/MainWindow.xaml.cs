using System;
using System.Collections.Generic;
using System.Linq;
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

//extra apis for GIS
using Newtonsoft.Json;
using Geocoding.Microsoft.Json;
using Microsoft.Maps.MapControl.WPF;

namespace WeatherMapper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //API Key generated from provider
        public string appID = "eDcd4ySThl2veAVO4XZx~uKuoi0sefFXPgdb2lay5Sw~AkSNFiMwLsH3tSsJtxSZJJwg6sjz998wVqisNgKONNemUravyaZZ_0LnrX7wifCh";

        public MainWindow()
        {
            InitializeComponent();

            ApplicationIdCredentialsProvider provider = new ApplicationIdCredentialsProvider(appID);
            MainMap.CredentialsProvider = provider;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Application.Current.Shutdown();
            
        }

        private void MainMap_MouseUp(object sender, MouseButtonEventArgs e)
        {
            var direction = this.MainMap.Heading;
            this.Direction.Text = direction.ToString();

            var directionCenter = this.MainMap.TargetCenter;
            this.DirectionCenter.Text = directionCenter.ToString();

            var zoomTargetLevel = this.MainMap.TargetZoomLevel;
            this.ZoomTarget.Text = zoomTargetLevel.ToString();

            var zoomLevel = this.MainMap.ZoomLevel;
            this.ZoomLevel.Text = zoomLevel.ToString();

            var centerOfMap = this.MainMap.Center;
            this.MapCenter.Text = centerOfMap.ToString();
            
        }
    }
}


