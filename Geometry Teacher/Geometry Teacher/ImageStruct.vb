Public Class ImageStruct
    Public exitIcon As Image = Image.FromFile("../../../Resources/exit.png")
    Public checkIcon As Image = Image.FromFile("../../../Resources/check.png")
    Public crossIcon As Image = Image.FromFile("../../../Resources/cross.png")
    Public calculatorIcon As Image = Image.FromFile("../../../Resources/calculator.png")
    Public closeCalculatorIcon As Image = Image.FromFile("../../../Resources/exit.png")
    Public backIcon As Image = Image.FromFile("../../../Resources/icons8-back-arrow-64.png")

    Public Sub New()

    End Sub

    Default Public ReadOnly Property Item(ByVal name As String) As Image
        Get
            Return getImage(name)
        End Get
    End Property

    Public Function getImage(s As String) As Image
        Return CallByName(Me, s.Replace(" ", ""), CallType.Get)
    End Function
End Class
