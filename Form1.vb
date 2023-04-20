Public Class frmTextBoxApplication
    Private _intSizeOfArray As Integer = 11
    Private _strSavings(_intSizeOfArray) As String
    Private _decBill(_intSizeOfArray) As Decimal

    Private Sub frmTextBoxApplication_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Reads the savings text file and 
        'fills the ComboBox object with the months 
        'Initialize as instance of the StreamReader object
        Dim objReader As IO.StreamReader
        Dim strSavingsAmount As String
        Dim intCount As Integer = 0
        Dim intFill As Integer

        lblElectricSavings.Text = ""
        lblAverageMonthlySavings.Text = ""
        lblSignificantMonthlySavings.Text = ""

        'The If statement verifies that the files exists
        If IO.File.Exists("C:\Users\salin\Desktop\WeeklyAssignment8\savings.txt") = True Then
            objReader = IO.File.OpenText("C:\Users\salin\Desktop\WeeklyAssignment8\savings.txt")
            'The file is read line by line until the file is completed 
            Do While objReader.Peek <> -1
                _strSavings(intCount) = objReader.ReadLine()
                strSavingsAmount = objReader.ReadLine()
                _decBill(intCount) = Convert.ToDecimal(strSavingsAmount)
                intCount += 1
            Loop
            objReader.Close()
            'The ComboBox object is filled with the Bill years 
            For intFill = 0 To (_strSavings.Length - 1)
                cboMonths.Items.Add(_strSavings(intFill))
            Next
        Else
            MsgBox("The file is not avaliable. Restart the program when the file is avaliable", , "Error")
        End If
    End Sub

    Private Sub cboMonths_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMonths.SelectedIndexChanged
        'The cboMonths selectedIndexChanged displays the savings for the selected month
        Dim intSelectedCityIndex As Integer

        intSelectedCityIndex = cboMonths.SelectedIndex
        lblElectricSavings.Text = "The electric savings for " & _strSavings(intSelectedCityIndex) & " is $" & _decBill(intSelectedCityIndex).ToString()
        btnDisplayStatistics.Visible = True
    End Sub

    Private Sub btnDisplayStatistics_Click(sender As Object, e As EventArgs) Handles btnDisplayStatistics.Click
        'The btnDisplayStatistics click event calls two sub methods to compute the average 
        'monthly savings and the most savings fie a given month
        ComputeAverageMonthlySavings()
        ComputeSignificantMonthlySavings()

    End Sub

    Private Sub ComputeSignificantMonthlySavings()
        Dim intMonths As Integer
        Dim intLargestSavingsValue As Integer = 0
        Dim intIndexValue As Integer = 0
        Dim strYearValue As String = ""

        For Each intMonths In _decBill
            intLargestSavingsValue = Math.Max(intLargestSavingsValue, intMonths)
            If (intMonths >= intLargestSavingsValue) Then
                strYearValue = _strSavings(intIndexValue)
            End If
            intIndexValue += 1
        Next
        lblSignificantMonthlySavings.Text = strYearValue & " had the most significant monthly savings"
    End Sub

    Private Sub ComputeAverageMonthlySavings()
        Dim intCountYears As Integer
        Dim intYears As Integer = 0
        Dim decTotalBill As Decimal = 0
        Dim decAverageNumberOfBill As Decimal = 0D

        For Each intCountYears In _decBill
            decTotalBill += _decBill(intYears)
            intYears += 1
        Next
        decAverageNumberOfBill = decTotalBill / Convert.ToDecimal(_decBill.Length())
        lblAverageMonthlySavings.Text = "The average monthly savings: " & decAverageNumberOfBill.ToString("C2")
    End Sub
End Class

