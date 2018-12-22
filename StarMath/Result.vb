Option Explicit On

Public Class Tfleet2hp

    Private AttackFleets As FleetStats()
    Private DefenseFleets As FleetStats()
    Private ArmadaAttackHP As Integer = 0
    Private ArmadaAttackDamage As Integer = 0
    Private ArmadaDefenseHP As Integer = 0
    Private ArmadaDefenseDamage As Integer = 0

    Sub GetBaseValues(ByRef base As FleetBase, ByRef stats As FleetStats)
        Select Case base.FleetType

            Case "Industrial"

                stats.HP = 400

                Select Case base.FleetHull

                    Case "Common HP"
                        stats.HPBoost = stats.HPBoost + 25
                    Case "Rare HP"
                        stats.HPBoost = stats.HPBoost + 50
                    Case "Epic HP"
                        stats.HPBoost = stats.HPBoost + 75
                    Case "Legendary HP"
                        stats.HPBoost = stats.HPBoost + 100

                End Select

                Select Case base.FleetHard

                    Case "Common HP"
                        stats.HPBoost = stats.HPBoost + 20
                    Case "Rare HP"
                        stats.HPBoost = stats.HPBoost + 30
                    Case "Epic HP"
                        stats.HPBoost = stats.HPBoost + 40
                    Case "Legendary HP"
                        stats.HPBoost = stats.HPBoost + 50

                End Select

            Case "Corvette", "Patrol Ship"

                stats.HP = 200
                stats.Damage = 80

                Select Case base.FleetHull

                    Case "Common HP"
                        stats.HPBoost = stats.HPBoost + 25
                    Case "Rare HP"
                        stats.HPBoost = stats.HPBoost + 50
                    Case "Epic HP"
                        stats.HPBoost = stats.HPBoost + 75
                    Case "Legendary HP"
                        stats.HPBoost = stats.HPBoost + 100
                    Case "Common DMG"
                        stats.DamageBoost = stats.DamageBoost + 5
                    Case "Rare DMG"
                        stats.DamageBoost = stats.DamageBoost + 10
                    Case "Epic DMG"
                        stats.DamageBoost = stats.DamageBoost + 15
                    Case "Legendary DMG"
                        stats.DamageBoost = stats.DamageBoost + 20

                End Select

                Select Case base.FleetHard

                    Case "Common HP"
                        stats.HPBoost = stats.HPBoost + 20
                    Case "Rare HP"
                        stats.HPBoost = stats.HPBoost + 30
                    Case "Epic HP"
                        stats.HPBoost = stats.HPBoost + 40
                    Case "Legendary HP"
                        stats.HPBoost = stats.HPBoost + 50
                    Case "Common DMG"
                        stats.DamageBoost = stats.DamageBoost + 10
                    Case "Rare DMG"
                        stats.DamageBoost = stats.DamageBoost + 20
                    Case "Epic DMG"
                        stats.DamageBoost = stats.DamageBoost + 30
                    Case "Legendary DMG"
                        stats.DamageBoost = stats.DamageBoost + 40

                End Select

            Case "Destroyer", "Frigate", "Gunship"

                stats.HP = 1000
                stats.Damage = 400

                Select Case base.FleetHull

                    Case "Common HP"
                        stats.HPBoost = stats.HPBoost + 125
                    Case "Rare HP"
                        stats.HPBoost = stats.HPBoost + 250
                    Case "Epic HP"
                        stats.HPBoost = stats.HPBoost + 375
                    Case "Legendary HP"
                        stats.HPBoost = stats.HPBoost + 500
                    Case "Common DMG"
                        stats.DamageBoost = stats.DamageBoost + 25
                    Case "Rare DMG"
                        stats.DamageBoost = stats.DamageBoost + 50
                    Case "Epic DMG"
                        stats.DamageBoost = stats.DamageBoost + 75
                    Case "Legendary DMG"
                        stats.DamageBoost = stats.DamageBoost + 100

                End Select

                Select Case base.FleetHard

                    Case "Common HP"
                        stats.HPBoost = stats.HPBoost + 100
                    Case "Rare HP"
                        stats.HPBoost = stats.HPBoost + 150
                    Case "Epic HP"
                        stats.HPBoost = stats.HPBoost + 200
                    Case "Legendary HP"
                        stats.HPBoost = stats.HPBoost + 200
                    Case "Common DMG"
                        stats.DamageBoost = stats.DamageBoost + 50
                    Case "Rare DMG"
                        stats.DamageBoost = stats.DamageBoost + 100
                    Case "Epic DMG"
                        stats.DamageBoost = stats.DamageBoost + 150
                    Case "Legendary DMG"
                        stats.DamageBoost = stats.DamageBoost + 200

                End Select

                'Select Case fleet1card

            Case "Carrier", "Dreadnaught"

                stats.HP = 5000
                stats.Damage = 2000

                Select Case base.FleetHull

                    'NEED TO UPDATE VALUES 

                    Case "Common HP"
                        stats.HPBoost = stats.HPBoost + 125
                    Case "Rare HP"
                        stats.HPBoost = stats.HPBoost + 250
                    Case "Epic HP"
                        stats.HPBoost = stats.HPBoost + 375
                    Case "Legendary HP"
                        stats.HPBoost = stats.HPBoost + 500
                    Case "Common DMG"
                        stats.DamageBoost = stats.DamageBoost + 25
                    Case "Rare DMG"
                        stats.DamageBoost = stats.DamageBoost + 50
                    Case "Epic DMG"
                        stats.DamageBoost = stats.DamageBoost + 75
                    Case "Legendary DMG"
                        stats.DamageBoost = stats.DamageBoost + 100

                End Select

                Select Case base.FleetHard

                    Case "Common HP"
                        stats.HPBoost = stats.HPBoost + 500
                    Case "Rare HP"
                        stats.HPBoost = stats.HPBoost + 750
                    Case "Epic HP"
                        stats.HPBoost = stats.HPBoost + 1000
                    Case "Legendary HP"
                        stats.HPBoost = stats.HPBoost + 1000
                    Case "Common DMG"
                        stats.DamageBoost = stats.DamageBoost + 250
                    Case "Rare DMG"
                        stats.DamageBoost = stats.DamageBoost + 500
                    Case "Epic DMG"
                        stats.DamageBoost = stats.DamageBoost + 750
                    Case "Legendary DMG"
                        stats.DamageBoost = stats.DamageBoost + 1000

                End Select

        End Select
    End Sub

    Private Sub FinalStats(ByRef stats As FleetStats, FleetCount As Int32)
        stats.HP += stats.HPBoost
        stats.Damage += stats.DamageBoost
        stats.CombinedHP = stats.HP * FleetCount
        stats.CombinedDamage = stats.Damage * FleetCount
    End Sub

    Private Sub CalculateStatPenalty(ByRef stats As FleetStats, FleetType As String, Attacker As Boolean)
        If Attacker Then
            If FleetType = "Patrol Ship" Or FleetType = "Frigate" Then
                stats.HP /= 2
                stats.Damage /= 2
            End If
        Else
            If FleetType = "Corvette" Or FleetType = "Destroyer" Or FleetType = "Gunship" Then
                stats.HP /= 2
                stats.Damage /= 2
            End If
        End If
    End Sub

    Function Calculate(ByVal ParamArray BaseValues() As FleetBase) As FleetStats()
        Dim result(BaseValues.Count() - 1) As FleetStats

        For i As Integer = 0 To BaseValues.Count() - 1
            Dim stats As FleetStats = New FleetStats()

            GetBaseValues(BaseValues(i), stats)
            FinalStats(stats, BaseValues(i).FleetCount)
            CalculateStatPenalty(stats, BaseValues(i).FleetType, BaseValues(i).Attacker)

            If BaseValues(i).Attacker Then
                ArmadaAttackHP += stats.CombinedHP
                ArmadaAttackDamage += stats.CombinedDamage
                stats.FleetAttacker = True
            Else
                ArmadaDefenseHP += stats.CombinedHP
                ArmadaDefenseDamage += stats.CombinedDamage
                stats.FleetAttacker = False
            End If

            result(i) = stats
        Next

        Return result
    End Function


    Function Fight(ByVal ParamArray FinalStats()) As FleetStats()

        For i As Integer = 0 To FinalStats.Count() - 1
            If Not (FinalStats(i).FleetAttacker) Then
                FinalStats(i).TakenDamage = (FinalStats(i).CombinedHP / ArmadaDefenseHP) * ArmadaAttackDamage
            Else
                FinalStats(i).TakenDamage = (FinalStats(i).CombinedHP / ArmadaAttackHP) * ArmadaDefenseDamage
            End If

            If (FinalStats(i).TakenDamage > FinalStats(i).HP) Then
                FinalStats(i).Losses = FinalStats(i).TakenDamage \ FinalStats(i).HP
            End If
        Next
        Return FinalStats

    End Function


    Private Sub GenerateText(ByVal ParamArray Values() As FleetStats)




    End Sub


    Private Sub Result_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim stats, defstats As FleetStats()
        stats = Calculate(fleetarray)
        defstats = Calculate(dfleetarray)
        AttackFleets = Fight(stats)
        DefenseFleets = Fight(defstats)


    End Sub

    Private Sub Tfleet2hp_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Selector.Close()
    End Sub





End Class