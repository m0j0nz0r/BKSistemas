Namespace My

    ' The following events are available for MyApplication:
    ' 
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication
        Private Sub MyApp_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shutdown
            If logged Then
                'Dim noclose As New Form
                'noclose.Opacity = 0
                'noclose.Show()
                Debug.WriteLine("Shutting down...")
                If HaveInternetConnection() Then
                    Dim adapter As New DatabaseWebAdapter()
                    adapter.UpdateCommand = New DatabaseWebCommand("", New DatabaseWebConnection(My.Settings.ConnectionString))
                    adapter.Update(MainDSO)
                End If
                If My.Settings.SaveData <> "" Then
                    If Not IO.File.Exists(My.Settings.SaveData) Then
                        My.Settings.SaveData = ""
                    End If
                End If
                Dim rst As DialogResult
                If My.Settings.SaveData = "" Then
                    Dim openfileDlg As New SaveFileDialog
                    openfileDlg.Filter = "Respaldo BkSistema (*.bks)|*.bks"
                    openfileDlg.AddExtension = True
                    openfileDlg.Title = "Seleccionar el directorio donde desea respaldar la Data"
                    rst = openfileDlg.ShowDialog()
                    If rst = DialogResult.OK Then
                        My.Settings.SaveData = openfileDlg.FileName
                        My.Settings.Save()
                    End If
                End If
                If rst = DialogResult.OK And My.Settings.SaveData <> "" Then
                    Dim file As IO.StreamWriter
                    Try
                        file = My.Computer.FileSystem.OpenTextFileWriter(My.Settings.SaveData, False)
                        file.Write(JsonConvert.SerializeObject(MainDSO))
                        file.Close()
                        MessageBox.Show("Respaldo exitoso!")
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                End If
                logged = False
                'noclose.Close()
            End If
        End Sub
        Private Sub StartupEvent(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup
            Dim keys As String() = My.Computer.Registry.ClassesRoot.GetSubKeyNames()
            Dim found As Boolean = False
            For Each s As String In keys
                If s.ToLower = ".bks" Then
                    found = True
                    Exit For
                End If
            Next
        End Sub
    End Class
End Namespace

