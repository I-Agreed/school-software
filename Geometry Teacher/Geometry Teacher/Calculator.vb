Public Class Calculator
    Property prev As Integer = 0
    Public add As Func(Of Integer, Integer, Integer) = Function(x As Integer, y As Integer) x + y
    Public subtract As Func(Of Integer, Integer, Integer) = Function(x As Integer, y As Integer) y - x
    Public multiply As Func(Of Integer, Integer, Integer) = Function(x As Integer, y As Integer) x * y
    Public divide As Func(Of Integer, Integer, Integer) = Function(x As Integer, y As Integer) y / x
    Public empty As Func(Of Integer, Integer, Integer) = Function(x As Integer, y As Integer) 0
    Property op As Func(Of Integer, Integer, Integer)

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        op = empty
    End Sub

    Private Sub Calculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mainDisplay.TextAlign = HorizontalAlignment.Right
    End Sub

    Function getValue() As Integer
        Try
            Return CInt(mainDisplay.Text)
        Catch ex As InvalidCastException
            Return 0
        End Try
    End Function

    Sub bumpUp(s As String)
        If prevDisplay.Text <> "" Then
            equalsButton_Click(New Object, New EventArgs)
        End If
        If mainDisplay.Text <> "" Then
            prevDisplay.Text = mainDisplay.Text + " " + s
        Else
            prevDisplay.Text = "0 " + s
        End If
        prev = getValue()
        mainDisplay.Text = ""
    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        prev = 0
        prevDisplay.Text = ""
        mainDisplay.Text = ""
    End Sub

    Private Sub ACButton_Click(sender As Object, e As EventArgs) Handles ACButton.Click
        mainDisplay.Text = ""
    End Sub

    Private Sub delButton_Click(sender As Object, e As EventArgs) Handles delButton.Click
        If mainDisplay.Text.Length > 0 Then
            mainDisplay.Text = mainDisplay.Text.Substring(0, mainDisplay.Text.Length - 1)
        End If
    End Sub

    Sub typeNumber(n As String)
        If mainDisplay.Text.Length < mainDisplay.MaxLength Then
            mainDisplay.Text += n
        End If
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        typeNumber("1")
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        typeNumber("2")
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        typeNumber("3")
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        typeNumber("4")
    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        typeNumber("5")
    End Sub

    Private Sub button6_Click(sender As Object, e As EventArgs) Handles button6.Click
        typeNumber("6")
    End Sub

    Private Sub button7_Click(sender As Object, e As EventArgs) Handles button7.Click
        typeNumber("7")
    End Sub

    Private Sub button8_Click(sender As Object, e As EventArgs) Handles button8.Click
        typeNumber("8")
    End Sub

    Private Sub button9_Click(sender As Object, e As EventArgs) Handles button9.Click
        typeNumber("9")
    End Sub

    Private Sub button0_Click(sender As Object, e As EventArgs) Handles button0.Click
        typeNumber("0")
    End Sub

    Private Sub plusButton_Click(sender As Object, e As EventArgs) Handles plusButton.Click
        op = add
        bumpUp("+")
    End Sub

    Private Sub minusButton_Click(sender As Object, e As EventArgs) Handles minusButton.Click
        op = subtract
        bumpUp("-")
    End Sub

    Private Sub multiplyButton_Click(sender As Object, e As EventArgs) Handles multiplyButton.Click
        op = multiply
        bumpUp("×")
    End Sub

    Private Sub divideButton_Click(sender As Object, e As EventArgs) Handles divideButton.Click
        op = divide
        bumpUp("÷")
    End Sub

    Private Sub equalsButton_Click(sender As Object, e As EventArgs) Handles equalsButton.Click
        Dim result = op(getValue(), prev)
        If result > 999999999 Or result < 0 Then
            prevDisplay.Text = "ERROR"
            mainDisplay.Text = ""
        Else

            prevDisplay.Text = ""
            mainDisplay.Text = result
        End If
    End Sub

    Private Sub dont(ByVal sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        Hide()
    End Sub

    Private Sub Calculator_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        Root.toggleCalc.correctIcon()
    End Sub
End Class