Imports System
Imports System.Runtime.InteropServices

Public Delegate Function CallBack(ByVal hwnd As Integer, ByVal lParam As Integer) As Boolean

Public Module window
    Declare Function EnumWindows Lib "user32" (ByVal x As CallBack, ByVal y As Integer) As Integer
    Declare Function GetWindowPlacement Lib "user32" (ByVal hwnd As IntPtr, ByRef lpwndpl As WINDOWPLACEMENT) As Boolean
    Declare Function GetWindowRect Lib "user32" (ByVal hwnd As IntPtr, ByRef lprect As Rectangle) As Boolean
    Declare Function IsWindowVisible Lib "user32" (ByVal hwnd As IntPtr) As Boolean
    Declare Function GetWindowTextA Lib "user32" (ByVal hwnd As IntPtr, lpString As String(), ByVal nMaxCount As Integer) As Boolean
    Declare Function MonitorFromWindow Lib "user32" (ByVal hwnd As IntPtr, ByVal DWORD As Integer) As Integer
    Declare Function DwmGetWindowAttribute Lib "dwmapi" (ByVal hwnd As IntPtr, ByVal dwAttribute As DWMWINDOWATTRIBUTE, ByRef pvAttribute As Boolean, ByVal cbAttribute As Integer) As UInt32
    Declare Function DwmGetWindowAttribute Lib "dwmapi" (ByVal hwnd As IntPtr, ByVal dwAttribute As DWMWINDOWATTRIBUTE, ByRef pvAttribute As RECT, ByVal cbAttribute As Integer) As UInt32
End Module

Public Structure WINDOWPLACEMENT
    Public length As Integer
    Public flags As Integer
    Public showCmd As Integer
    Public ptMinPosition As Point
    Public ptMaxPosition As Point
    Public rcNormalPosition As Rectangle
    Public rcDevice As Rectangle
End Structure

Public Structure RECT
    Public Left As Integer
    Public Top As Integer
    Public Right As Integer
    Public Bottom As Integer
End Structure

Public Enum DWMWINDOWATTRIBUTE As UInteger
    DWMWA_NCRENDERING_ENABLED = 1
    DWMWA_NCRENDERING_POLICY
    DWMWA_TRANSITIONS_FORCEDISABLED
    DWMWA_ALLOW_NCPAINT
    DWMWA_CAPTION_BUTTON_BOUNDS
    DWMWA_NONCLIENT_RTL_LAYOUT
    DWMWA_FORCE_ICONIC_REPRESENTATION
    DWMWA_FLIP3D_POLICY
    DWMWA_EXTENDED_FRAME_BOUNDS
    DWMWA_HAS_ICONIC_BITMAP
    DWMWA_DISALLOW_PEEK
    DWMWA_EXCLUDED_FROM_PEEK
    DWMWA_CLOAK
    DWMWA_CLOAKED
    DWMWA_FREEZE_REPRESENTATION
    DWMWA_LAST
End Enum

Public Class Form1
    Public windowRects As List(Of Rectangle)
    Public play As Player

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        windowRects = New List(Of Rectangle)
        play = New Player()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getWindows()
        Me.Hide()
        play.Show()
    End Sub

    Sub getWindows()
        windowRects.Clear()
        EnumWindows(AddressOf handleWindows, 0)
        'windowRects.Add(ScreenResolution)
    End Sub

    Function handleWindows(ByVal hwnd As IntPtr, ByVal lParam As Integer) As Boolean
        If hwnd <> Me.Handle And hwnd <> play.Handle Then
            Dim myMonitor = MonitorFromWindow(Me.Handle, 0)
            Dim isVisible = False
            DwmGetWindowAttribute(hwnd, DWMWINDOWATTRIBUTE.DWMWA_CLOAKED, isVisible, Marshal.SizeOf(isVisible))
            If IsWindowVisible(hwnd) And myMonitor = MonitorFromWindow(hwnd, 0) And Not isVisible Then
                Dim d As New RECT
                DwmGetWindowAttribute(hwnd, DWMWINDOWATTRIBUTE.DWMWA_EXTENDED_FRAME_BOUNDS, d, Marshal.SizeOf(d))
                Dim d2 As Rectangle = convertRect(d)

                Dim res = ScreenResolution()
                If d2.Width > 0 And d2.Height > 0 And d2.Width <= res.Width And d2.Height <= res.Height Then
                    windowRects.Add(d2)
                End If
            End If
        End If
        Return True
    End Function

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        If False Then
            Dim g As Graphics = e.Graphics
            Dim p As Pen = New Pen(Color.Black)
            g.Clear(Me.BackColor)

            For Each box As Rectangle In windowRects
                Dim newRect As New Rectangle(box.X - Me.Left, box.Y - Me.Top, box.Width, box.Height)
                g.DrawRectangle(p, newRect)
            Next
        End If
    End Sub

    Private Sub frame_Tick(sender As Object, e As EventArgs) Handles frame.Tick
        getWindows()
        play.updatePos()
        Me.Hide()
    End Sub

    Function convertRect(r As RECT) As Rectangle
        Return New Rectangle(r.Left, r.Top, r.Right - r.Left - 1, r.Bottom - r.Top - 1)
    End Function

    Public Function ScreenResolution() As Rectangle
        Dim intX As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim intY As Integer = Screen.PrimaryScreen.Bounds.Height
        Return New Rectangle(0, 0, intX, intY)
    End Function
End Class
