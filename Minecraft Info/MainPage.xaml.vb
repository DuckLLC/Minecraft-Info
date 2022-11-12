' The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page

    Private Const V As Boolean = True

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Verions.Visibility = V
        Swords.Visibility = Visibility.Collapsed
    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        Verions.Visibility = Visibility.Collapsed
        Swords.Visibility = V
    End Sub
End Class
