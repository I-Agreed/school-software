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
    Public windows As List(Of Rectangle)

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        windows = New List(Of Rectangle)
        getWindows()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Function getWindows()
        windows.Clear()
        window.EnumWindows(AddressOf handleWindows, 0)
    End Function

    Function handleWindows(ByVal hwnd As IntPtr, ByVal lParam As Integer) As Boolean
        Dim myMonitor = MonitorFromWindow(Me.Handle, 0)
        If IsWindowVisible(hwnd) And myMonitor = MonitorFromWindow(hwnd, 0) Then
            Dim d As New RECT
            DwmGetWindowAttribute(hwnd, DWMWINDOWATTRIBUTE.DWMWA_EXTENDED_FRAME_BOUNDS, d, Marshal.SizeOf(d))
            windows.Add(convertRect(d))
        End If
        Return True
    End Function

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        getWindows()
        Dim g As Graphics = e.Graphics
        Dim p As Pen = New Pen(Color.Black)
        g.Clear(Me.BackColor)

        For Each box As Rectangle In windows
            Dim newRect As New Rectangle(box.X - Me.Left, box.Y - Me.Top, box.Width, box.Height)
            g.DrawRectangle(p, newRect)
        Next
    End Sub

    Private Sub frame_Tick(sender As Object, e As EventArgs) Handles frame.Tick
        Me.Invalidate()
    End Sub

    Function convertRect(r As RECT)
        Return New Rectangle(r.Left, r.Top, r.Right - r.Left - 1, r.Bottom - r.Top - 1)
    End Function
End Class
