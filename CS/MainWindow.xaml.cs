using System.Windows;
using DevExpress.Xpf.Map;

namespace DXMap_Runtime {

    public partial class MainWindow : Window {
        public MainWindow () {
            InitializeComponent();
        }

        private void Window_Loaded (object sender, RoutedEventArgs e) {
            // Create a map control.
            MapControl map = new MapControl();

            // Create a layer.
            ImageTilesLayer layer = new ImageTilesLayer();
            map.Layers.Add(layer);

            // Create a data provider.
            OpenStreetMapDataProvider provider = new OpenStreetMapDataProvider();
            layer.DataProvider = provider;

            // Add the map control to the window.
            this.Content = map;
        }

    }
}
