Public Class Form1
    Private Sub btnGetRetail_Click(sender As Object, e As EventArgs) Handles btnGetRetail.Click
        Dim dblWholesale As Double
        Dim dblMarkup As Double
        Dim dblRetail As Double
        'Dim dblTempValue As Double

        If (Not Double.TryParse(txtWholesaleCost.Text, dblWholesale)) Or (Not Double.TryParse(txtMarkup.Text, dblMarkup)) Then
            MessageBox.Show("Please enter a numeric value")
        ElseIf (dblWholesale < 0) Or (dblMarkup < 0) Then
            MessageBox.Show("Please enter a positive value ")
        Else
            'MessageBox.Show("It is a valid value")
            dblRetail = CalculateRetail(dblWholesale, dblMarkup)

            'Show the retail price
            lblRetailPriceVal.Text = dblRetail.ToString("C")
        End If

    End Sub

    Function CalculateRetail(ByVal dblWholesale As Double, ByVal dblMarkup As Double) As Double
        'Declare the variables
        Dim dblMarkupAmount As Double
        Dim dblRetailPrice As Double

        'Calculate the markup amount
        dblMarkupAmount = dblWholesale * (dblMarkup * 0.01)

        'Retail Price
        dblRetailPrice = dblWholesale + dblMarkupAmount

        Return dblRetailPrice
    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
