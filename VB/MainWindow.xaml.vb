Imports System.Windows
Imports DevExpress.Xpf.Map

Namespace DXMap_Runtime

	Partial Public Class MainWindow
		Inherits Window

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			' Create a map control and add it to the window.
			Dim map As New MapControl()
			Me.Content = map

			' Create a layer.
			Dim layer As New ImageLayer() With {
				.DataProvider = New BingMapDataProvider() With {
					.BingKey = "Insert your Bing Maps key here.",
					.Kind = BingMapKind.Road
				}
			}
			map.Layers.Add(layer)
			map.ZoomLevel = 4
			map.CenterPoint = New GeoPoint(40, -100)
		End Sub

	End Class
End Namespace
