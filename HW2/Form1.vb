Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblFederal.Text = ""
        lblFica.Text = ""
        lblState.Text = ""
        lblNetIn.Text = ""
        txtGross.Clear()
        txtGross.Focus()
    End Sub

    Private Sub btnTaxCalc_Click(sender As Object, e As EventArgs) Handles btnTaxCalc.Click
        Dim strIncome As String
        Dim decIncome As Decimal
        Dim decFica As Decimal
        Dim decFederal As Decimal
        Dim decState As Decimal
        Dim decNet As Decimal

        Const cdecFica As Decimal = 0.0765D
        Const cdecFed As Decimal = 0.22D
        Const cdecState As Decimal = 0.04D

        strIncome = txtGross.Text
        decIncome = Convert.ToInt32(strIncome)

        decFica = decIncome * cdecFica
        decFederal = decIncome * cdecFed
        decState = decIncome * cdecState

        decNet = decIncome - decFica - decFederal - decState

        lblFica.Text = decFica.ToString("C")
        lblFederal.Text = decFederal.ToString("C")
        lblState.Text = decState.ToString("C")
        lblNetIn.Text = decNet.ToString("C")


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblFederal.Text = ""
        lblFica.Text = ""
        lblState.Text = ""
        lblNetIn.Text = ""
        txtGross.Clear()
        txtGross.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
