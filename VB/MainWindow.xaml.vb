Imports Microsoft.VisualBasic
Imports System.Windows
Imports DevExpress.Xpf.Map

Namespace DXMap_Runtime

	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			' Create a map control.
			Dim map As New MapControl()

			' Create a layer.
			Dim layer As New ImageTilesLayer()
			map.Layers.Add(layer)

			' Create a data provider.
			Dim provider As New OpenStreetMapDataProvider()
			layer.DataProvider = provider

			' Add the map control to the window.
			Me.Content = map
		End Sub

	End Class
End Namespace
