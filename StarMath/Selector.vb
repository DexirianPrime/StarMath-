
Public Module globalfleet
    Public fleet1type As String
    Public fleet1hull As String
    Public fleet1hard As String
    Public fleet1card As String
    Public fleet1count As Int16
    Public dfleet1type As String
    Public dfleet1hull As String
    Public dfleet1hard As String
    Public dfleet1card As String
    Public dfleet1count As Int16
    Public fleet2type As String
    Public fleet2hull As String
    Public fleet2hard As String
    Public fleet2card As String
    Public fleet2count As Int16
    Public dfleet2type As String
    Public dfleet2hull As String
    Public dfleet2hard As String
    Public dfleet2card As String
    Public dfleet2count As Int16
    Public attacktype As String
End Module

Public Class Selector

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BC1.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Selector_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
