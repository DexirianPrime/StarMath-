Imports System.Xml
Imports System.Xml.Linq
Imports StarMath



Public Module globalfleet
    Public attacktype As String
    Public fleetcount As Int16
    Public dfleetcount As Int16
    Public fleetarray As FleetBase()
    Public dfleetarray As FleetBase()
    Public ByOurBlood As Boolean = False
    Public DefSupression As Int32 = 0
    Public ArmedGarisson As String = ""
End Module


Public Class Selector

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BC1.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'This would lead to harvest calculator were there one
    End Sub

End Class

Public Class FleetBase
    'Define all the elements of the FleetBase object
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
    'Define all the elements of the FleetStats object
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
    Public Type As String
    Public Count As Int16
    Public SCombinedHP As Int64
    Public SCombinedDamage As Int64
    Public Count2 As Int16
    Public Count3 As Int16
    Public TCombinedHP As Int64
    Public TCombinedDamage As Int64
    Public T1CombinedHP As Int64
    Public T1CombinedDamage As Int64
    Public THP As Int64
    Public TDamage As Int64
    Public PercentageTaken As Decimal
    'Init Variables to 0
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
        Count = 0
        SCombinedHP = 0
        SCombinedDamage = 0
        Count2 = 0
        Count3 = 0
        TCombinedHP = 0
        TCombinedDamage = 0
        T1CombinedHP = 0
        T1CombinedDamage = 0
        THP = 0
    End Sub

End Class




