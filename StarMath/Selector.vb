Imports System.Xml
Imports System.Xml.Linq
Imports StarMath



Public Module globalfleet

    Public attacktype As String
    Public fleetcount As Int16
    Public dfleetcount As Int16
    Public fleetarray As FleetBase()
    Public dfleetarray As FleetBase()



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


Public Class FleetBase
    Public FleetType As String
    Public FleetDamage As Integer
    Public FleetHealth As Integer
    Public FleetHull As String
    Public FleetHard As String
    Public FleetCount As Integer
    Public FleetCard As String
    Public Attacker As Boolean
End Class

Public Class FleetStats
    Public HP As Int64
    Public Damage As Int64
    Public HPBoost As Int64
    Public DamageBoost As Int64
    Public CombinedHP As Int64
    Public CombinedDamage As Int64
    Public TakenDamage As Int32
    Public Losses As Int32
    Public FleetAttacker As Boolean
    Public TotalLosses As Int32



    Public Sub New()
        HP = 0
        Damage = 0
        HPBoost = 0
        DamageBoost = 0
        CombinedHP = 0
        CombinedDamage = 0
        TakenDamage = 0
        Losses = 0
        TotalLosses = 0
    End Sub
End Class




