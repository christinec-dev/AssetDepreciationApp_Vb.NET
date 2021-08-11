Public Class FormMain
    Private Sub Depr_Calc_Btn_Click(sender As Object, e As EventArgs) Handles CalcBtn.Click

        'This defines our variables for future use in functions provided below
        Dim salvage As Double
        Dim uselife As Double = CDbl(UseLifeLst.SelectedItem)
        Dim cost As Double
        Dim period As Integer
        Dim doubleDec As Double
        Dim sumOfDigits As Double
        Dim numperiod As Integer
        Dim converted1 As Boolean
        Dim converted2 As Boolean
        Dim converted3 As Boolean

        'This converts our strings so that they can be represented as numerical values that can be returned
        converted2 = Double.TryParse(SalvgValTxt.Text, salvage)
        converted3 = Integer.TryParse(UseLifeLst.Text, period)

        'This assigns our textboxes and enforces they start on a new line
        DepDDPTxt.Text = DepDDPTxt.Text & ControlChars.NewLine
        DepSYDTxt.Text = DepSYDTxt.Text & ControlChars.NewLine

        'This calculates our Double Declining Balance
        For numperiod = 1 To period Step 1
            doubleDec = Financial.DDB(cost, salvage, uselife, numperiod)
            DepDDPTxt.Text += numperiod.ToString & "          " & Convert.ToString(Math.Round(doubleDec, 2)) _
            & ControlChars.NewLine
        Next numperiod

        'This calculates our Sum-of-first year digits
        For numperiod = 1 To period Step 1
            sumOfDigits = Financial.SYD(cost, salvage, uselife, numperiod)
            DepSYDTxt.Text += numperiod.ToString & "          " & Convert.ToString(Math.Round(sumOfDigits, 2)) _
            & ControlChars.NewLine
        Next numperiod


    End Sub

    Private Sub ExtBtn_Click(sender As Object, e As EventArgs) Handles ExtBtn.Click

        'This will close the applciation upon the useer clicking on it
        Me.Close()

    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
