using System.Windows;
using DevExpress.Xpf.Map;

namespace DXMap_Runtime {

    public partial class MainWindow : Window {
        public MainWindow () {
            InitializeComponent();
        }

        private void Window_Loaded (object sender, RoutedEventArgs e) {
            // Create a map control and add it to the window.
            MapControl map = new MapControl();
            this.Content = map;

            // Create a layer.
            ImageLayer layer = new ImageLayer() {
                DataProvider = new BingMapDataProvider() {
                    BingKey = "Insert your Bing Maps key here.",
                    Kind = BingMapKind.Road
                }
            };
            map.Layers.Add(layer);
            map.ZoomLevel = 4;
            map.CenterPoint = new GeoPoint(40, -100);
        }

    }
}
