Imports Dll_cSharpe
Public Class Form1

    Private Sub btnCrypt_Click(sender As Object, e As EventArgs) Handles btnCrypt.Click
        Dim dll As New DLL()
        txtResult.Text = dll.cryptSimple(txtText.Text)
        txtText.Text = ""
    End Sub

    Private Sub btnUnCrypt_Click(sender As Object, e As EventArgs) Handles btnUnCrypt.Click
        Dim dll As New DLL()
        txtResult.Text = dll.unCryptSimple(txtText.Text)
        txtText.Text = ""
    End Sub
End Class
