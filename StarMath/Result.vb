Option Explicit On

Public Class Tfleet2hp

    Private AttackFleets As FleetStats()
    Private DefenseFleets As FleetStats()
    Private AttackFleetsR1 As FleetStats()
    Private DefenseFleetsR1 As FleetStats()
    Private AttackFleetsR2 As FleetStats()
    Private DefenseFleetsR2 As FleetStats()
    Private ArmadaAttackHP As Integer = 0
    Private ArmadaAttackDamage As Integer = 0
    Private ArmadaDefenseHP As Integer = 0
    Private ArmadaDefenseDamage As Integer = 0
    Private ArmadaAttackHPR0 As Integer = 0
    Private ArmadaAttackDamageR0 As Integer = 0
    Private ArmadaDefenseHPR0 As Integer = 0
    Private ArmadaDefenseDamageR0 As Integer = 0
    Private ArmadaAttackHPR2 As Integer = 0
    Private ArmadaAttackDamageR2 As Integer = 0
    Private ArmadaDefenseHPR2 As Integer = 0
    Private ArmadaDefenseDamageR2 As Integer = 0
    Private ArmadaAttackHPR1 As Integer = 0
    Private ArmadaAttackDamageR1 As Integer = 0
    Private ArmadaDefenseHPR1 As Integer = 0
    Private ArmadaDefenseDamageR1 As Integer = 0
    Private ArmadaAttackHPR3 As Integer = 0
    Private ArmadaAttackDamageR3 As Integer = 0
    Private ArmadaDefenseHPR3 As Integer = 0
    Private ArmadaDefenseDamageR3 As Integer = 0
    Private j As Int32 = 0


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
            If FleetType = "Patrol Ship" Or FleetType = "Frigate" Or FleetType = "Dreadnaught" Then
                stats.HP /= 2
                stats.Damage /= 2
            End If
        Else
            If FleetType = "Corvette" Or FleetType = "Destroyer" Or FleetType = "Gunship" Or FleetType = "Carrier" Then
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
            stats.Type = BaseValues(i).FleetType
            result(i) = stats
        Next

        Return result
    End Function

    Function Fight(ByVal ParamArray FinalStats())

        'Apply Defense Firepower Boost in case of raid
        If attacktype = "raid" Then
            ArmadaDefenseDamage *= 1.1
            ArmadaDefenseHP *= 1.1

        End If


        'Loop for each fleet 
        For i As Integer = 0 To FinalStats.Count() - 1

                'New Temporary array for combat stats
                Dim roundstats As FleetStats = New FleetStats()
                roundstats = FinalStats(i)

                Select Case j

                    'Combat Round 0               
                    Case 0

                        'Set R0 variable from current armada stats according to round 1 boosts
                        ArmadaAttackDamageR0 = ArmadaAttackDamage * 0.72
                        ArmadaAttackHPR0 = ArmadaAttackHP * 0.72
                        ArmadaDefenseDamageR0 = ArmadaDefenseDamage * 0.72
                        ArmadaDefenseHPR0 = ArmadaDefenseHP * 0.72

                        'Calculate Damage taken for every fleet
                        If Not (FinalStats(i).FleetAttacker) Then
                            roundstats.TakenDamage = (roundstats.CombinedHP / ArmadaDefenseHPR0) * ArmadaAttackDamageR0
                        Else
                            roundstats.TakenDamage = (roundstats.CombinedHP / ArmadaAttackHPR0) * ArmadaDefenseDamageR0
                        End If

                        'Calculate Losses for every fleet
                        If (FinalStats(i).TakenDamage > FinalStats(i).HP) Then
                            roundstats.Losses = roundstats.TakenDamage \ roundstats.HP
                        End If

                        'Add losses to Total Loss count, and remove lost ships from fleet totals
                        FinalStats(i).TotalLosses += roundstats.Losses
                        FinalStats(i).CombinedHP -= (roundstats.Losses * roundstats.HP)
                        FinalStats(i).CombinedDamage -= (roundstats.Losses * roundstats.Damage)
                        FinalStats(i).Losses = 0

                    'Add post-combat values to R1 Armada Totals
                    If FinalStats(i).FleetAttacker Then
                        ArmadaAttackHPR1 += FinalStats(i).CombinedHP
                        ArmadaAttackDamageR1 += FinalStats(i).CombinedDamage
                    Else
                        ArmadaDefenseDamageR1 += FinalStats(i).CombinedDamage
                            ArmadaDefenseHPR1 += FinalStats(i).CombinedHP
                        End If


                    Case 1


                    If ArmadaDefenseDamageR1 > 0 And ArmadaAttackDamageR1 > 0 Then

                        'Calculate Damage taken for every fleet
                        If Not (FinalStats(i).FleetAttacker) Then
                            roundstats.TakenDamage = (roundstats.CombinedHP / ArmadaDefenseHPR1) * ArmadaAttackDamageR1
                        Else
                            roundstats.TakenDamage = (roundstats.CombinedHP / ArmadaAttackHPR1) * ArmadaDefenseDamageR1
                        End If

                        'Calculate Losses for every fleet
                        If (FinalStats(i).TakenDamage > FinalStats(i).HP) Then
                            roundstats.Losses = roundstats.TakenDamage \ roundstats.HP
                        End If

                        'Add losses to Total Loss count, and remove lost ships from fleet totals
                        FinalStats(i).TotalLosses += roundstats.Losses
                        FinalStats(i).CombinedHP -= (roundstats.Losses * roundstats.HP)
                        FinalStats(i).CombinedDamage -= (roundstats.Losses * roundstats.Damage)
                        FinalStats(i).Losses = 0

                        'Add post-combat values to R1 Armada Totals
                        If FinalStats(i).FleetAttacker Then
                            ArmadaAttackHPR2 += FinalStats(i).CombinedHP
                            ArmadaAttackDamageR2 += FinalStats(i).CombinedDamage
                        Else
                            ArmadaDefenseDamageR2 += FinalStats(i).CombinedDamage
                            ArmadaDefenseHPR2 += FinalStats(i).CombinedHP
                        End If

                    End If


                Case 2

                    If ArmadaDefenseDamageR2 > 0 And ArmadaAttackDamageR2 > 0 Then

                        'Set R3 variable from current armada stats according to round 1 boosts
                        ArmadaAttackDamageR3 = ArmadaAttackDamageR2 * 1.66
                        ArmadaAttackHPR3 = ArmadaAttackHPR2 * 1.66
                        ArmadaDefenseDamageR3 = ArmadaDefenseDamageR2 * 1.66
                        ArmadaDefenseHPR3 = ArmadaDefenseHPR2 * 1.66

                        'Calculate Damage taken for every fleet
                        If Not (FinalStats(i).FleetAttacker) Then
                            roundstats.TakenDamage = (roundstats.CombinedHP / ArmadaDefenseHPR3) * ArmadaAttackDamageR3
                        Else
                            roundstats.TakenDamage = (roundstats.CombinedHP / ArmadaAttackHPR3) * ArmadaDefenseDamageR3
                        End If

                        'Calculate Losses for every fleet
                        If (roundstats.TakenDamage > roundstats.HP) Then
                            roundstats.Losses = roundstats.TakenDamage \ roundstats.HP
                        End If

                        'Add losses to Total Loss count, and remove lost ships from fleet totals
                        FinalStats(i).TotalLosses += roundstats.Losses
                        FinalStats(i).CombinedHP -= (roundstats.Losses * roundstats.HP)
                        FinalStats(i).CombinedDamage -= (roundstats.Losses * roundstats.Damage)
                        FinalStats(i).Losses = 0

                    End If

            End Select

            Next



        'Return final values
        Return FinalStats

    End Function

    Private Sub Result_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim stats, defstats As FleetStats()
        stats = Calculate(fleetarray)
        defstats = Calculate(dfleetarray)
        AttackFleets = Fight(stats)
        DefenseFleets = Fight(defstats)
        j = 1
        AttackFleetsR1 = Fight(AttackFleets)
        DefenseFleetsR1 = Fight(DefenseFleets)
        j = 2
        AttackFleetsR2 = Fight(AttackFleetsR1)
        DefenseFleetsR2 = Fight(DefenseFleetsR1)


    End Sub

    Private Sub Tfleet2hp_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Selector.Close()
    End Sub


End Class