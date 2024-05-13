Public Class PremiumSINO
    Private Sub BtnPremium_Click(sender As Object, e As EventArgs) Handles btnPremium.Click

        Dim persona1 As New Registro.Premium
        With persona1
            .tratarNombre = txtNobre.Text
            .tratarApellido = txtApellido.Text
            .tratarCodigo = txtApellido.Text
            .generarCodigo()

        End With
        MessageBox.Show("Nombre: " & persona1.tratarNombre)
        MessageBox.Show("Apellido: " & persona1.tratarApellido)
        MessageBox.Show("Código: " & persona1.tratarCodigo)
    End Sub

    Private Sub BtnNoPremium_Click(sender As Object, e As EventArgs) Handles btnNoPremium.Click
        Dim persona1 As New Registro.NoPremium
        With persona1
            .tratarNombre = txtNobre.Text
            .tratarApellido = txtApellido.Text
            .tratarCodigo = txtApellido.Text
            .generarCodigo()

        End With
        MessageBox.Show("Nombre: " & persona1.tratarNombre)
        MessageBox.Show("Apellido: " & persona1.tratarApellido)
        MessageBox.Show("Código: " & persona1.tratarCodigo)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) 
        MessageBox.Show("Nombre: ")
        Dim testString As String = "Mid Function Demo"
        ' Returns "Mid".
        MessageBox.Show("Texto:" & testString)
        Dim firstWord As String = Mid(testString, 1, 3)
        MessageBox.Show("Nombre: " & firstWord)


    End Sub
End Class
