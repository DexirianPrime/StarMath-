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
    Private ArmadaDefenseHPR As Integer = 0
    Private ArmadaDefenseDamageR As Integer = 0
    Private ConvertedFinal As Array(,)
    Private ConvertedFinalD As Array(,)
    Private SupressionTaken As Int32

    Private j As Int32 = 0

    Sub GetBaseValues(ByRef base As FleetBase, ByRef stats As FleetStats)
        'Prepare combat result variables
        stats.Count = base.FleetCount
        stats.Count2 = base.FleetCount
        stats.Count3 = base.FleetCount
        'This Case applies all the base fleet stats using the user input to determine values
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
                Select Case base.FleetCard
                    Case "Fleet Cadet"
                        stats.HPBoost += 5
                        stats.DamageBoost += 2
                    Case "Max Rykov"
                        If attacktype = "raid" Then
                            stats.HPBoost += 25

                        End If
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
                Select Case base.FleetCard
                    Case "Fleet Cadet"
                        stats.HPBoost += 25
                        stats.DamageBoost += 10
                    Case "Max Rykov"
                        If attacktype = "raid" Then
                            stats.HPBoost += 125
                        End If
                End Select
            Case "Carrier", "Dreadnaught"
                stats.HP = 5000
                stats.Damage = 2000
                Select Case base.FleetHull
                    Case "Common HP"
                        stats.HPBoost = stats.HPBoost + 625
                    Case "Rare HP"
                        stats.HPBoost = stats.HPBoost + 1250
                    Case "Epic HP"
                        stats.HPBoost = stats.HPBoost + 1875
                    Case "Legendary HP"
                        stats.HPBoost = stats.HPBoost + 2500
                    Case "Common DMG"
                        stats.DamageBoost = stats.DamageBoost + 125
                    Case "Rare DMG"
                        stats.DamageBoost = stats.DamageBoost + 250
                    Case "Epic DMG"
                        stats.DamageBoost = stats.DamageBoost + 375
                    Case "Legendary DMG"
                        stats.DamageBoost = stats.DamageBoost + 500
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
                Select Case base.FleetCard
                    Case "Fleet Cadet"
                        stats.HPBoost += 125
                        stats.DamageBoost += 50
                End Select
        End Select
        'Add the boost from cards to base fleet stats
        stats.HP += stats.HPBoost
        stats.Damage += stats.DamageBoost
    End Sub

    Private Sub CalculateStatPenalty(ByRef stats As FleetStats, FleetType As String, Attacker As Boolean, FleetCount As Integer)
        'Apply Penalties depending on ship type and policies
        If Attacker Then
            If FleetType = "Patrol Ship" Or FleetType = "Frigate" Or FleetType = "Dreadnaught" Then
                stats.HP /= 2
                If Not ByOurBlood Then
                    stats.Damage /= 2
                End If
            End If
        Else
            If FleetType = "Corvette" Or FleetType = "Destroyer" Or FleetType = "Gunship" Or FleetType = "Carrier" Then
                stats.HP /= 2
                stats.Damage /= 2
            End If
        End If
        'Calculate post-penalty total HP and Damage of fleet
        stats.CombinedHP = stats.HP * FleetCount
        stats.CombinedDamage = stats.Damage * FleetCount
    End Sub

    Function Calculate(ByVal ParamArray BaseValues() As FleetBase) As FleetStats()
        'Init temp FleetStats object array
        Dim result(BaseValues.Count() - 1) As FleetStats
        'Run for all fleets 
        For i As Integer = 0 To BaseValues.Count() - 1
            'Init temp FleetStats object
            Dim stats As FleetStats = New FleetStats()
            'Calculate FinalStats from BaseStats
            GetBaseValues(BaseValues(i), stats)
            CalculateStatPenalty(stats, BaseValues(i).FleetType, BaseValues(i).Attacker, BaseValues(i).FleetCount)
            'Add fleet totals to armada totals
            If BaseValues(i).Attacker Then
                ArmadaAttackHP += stats.CombinedHP
                ArmadaAttackDamage += stats.CombinedDamage
                stats.FleetAttacker = True
            Else
                ArmadaDefenseHP += stats.CombinedHP
                ArmadaDefenseDamage += stats.CombinedDamage
                stats.FleetAttacker = False
            End If
            'Prepare combat output variables
            stats.Type = BaseValues(i).FleetType
            stats.SCombinedDamage = stats.CombinedDamage
            stats.SCombinedHP = stats.CombinedHP
            'Send stats object results to the array
            result(i) = stats
        Next
        'Return the array
        Return result
    End Function

    Function Fight(ByVal ParamArray FinalStats())
        'Set Temp Variables to 0
        ArmadaDefenseHPR = 0
        ArmadaDefenseDamageR = 0
        'Apply Defense Firepower Boost in case of raid on temp variables
        If attacktype = "raid" Then
            ArmadaDefenseHPR = ArmadaDefenseHP * 1.1
            ArmadaDefenseDamageR = ArmadaDefenseDamage * 1.1
        End If
        'Loop for each fleet 
        For i As Integer = 0 To FinalStats.Count() - 1
            'New Temporary object array for combat stats
            Dim roundstats As FleetStats = New FleetStats()
            roundstats = FinalStats(i)
            SupressionTaken = 0
            Select Case j
                    'Combat Round 0               
                Case 0
                    'Set R0 variable from current armada stats according to round 1 boosts
                    ArmadaAttackDamageR0 = ArmadaAttackDamage * 0.72
                    ArmadaAttackHPR0 = ArmadaAttackHP
                    ArmadaDefenseDamageR0 = ArmadaDefenseDamageR * 0.72
                    ArmadaDefenseHPR0 = ArmadaDefenseHPR
                    roundstats.TCombinedHP = roundstats.CombinedHP
                    roundstats.TCombinedDamage = roundstats.CombinedDamage * 0.72
                    roundstats.THP = roundstats.HP
                    roundstats.TDamage = roundstats.Damage * 0.72
                    'Calculate Damage taken for every fleet
                    If Not (roundstats.FleetAttacker) Then
                        roundstats.TakenDamage = (roundstats.TCombinedHP / ArmadaDefenseHPR0) * ArmadaAttackDamageR0
                    Else
                        roundstats.TakenDamage = (roundstats.TCombinedHP / ArmadaAttackHPR0) * ArmadaDefenseDamageR0
                    End If
                    'Calculate Losses for every fleet
                    If (roundstats.TakenDamage > roundstats.THP) Then
                        roundstats.Losses = roundstats.TakenDamage \ roundstats.THP
                    End If
                    If (roundstats.Losses > roundstats.Count) Then
                        roundstats.Losses = roundstats.Count
                    End If
                    roundstats.Count -= roundstats.Losses
                    'Add losses to Total Loss count, and remove lost ships from fleet totals
                    FinalStats(i).TotalLosses += roundstats.Losses
                    If roundstats.Count = 0 Then
                        FinalStats(i).CombinedHP = 0
                        FinalStats(i).CombinedDamage = 0
                        FinalStats(i).Count = 0
                    Else
                        FinalStats(i).CombinedHP -= (roundstats.Losses * roundstats.HP)
                        FinalStats(i).CombinedDamage -= (roundstats.Losses * roundstats.Damage)
                        FinalStats(i).Count -= roundstats.Losses
                    End If
                    FinalStats(i).Count2 -= FinalStats(i).Losses
                    FinalStats(i).Losses = 0
                    'Add post-combat values to R1 Armada Totals
                    If FinalStats(i).FleetAttacker Then
                        ArmadaAttackHPR1 += FinalStats(i).CombinedHP
                        ArmadaAttackDamageR1 += FinalStats(i).CombinedDamage
                    Else
                        ArmadaDefenseDamageR1 += FinalStats(i).CombinedDamage
                        ArmadaDefenseHPR1 += FinalStats(i).CombinedHP
                    End If
                    'Combat Round 1
                Case 1

                    If ArmadaDefenseDamageR1 > 0 And ArmadaAttackDamageR1 > 0 Then

                        'Calculate Damage taken for every fleet
                        If Not (roundstats.FleetAttacker) Then
                            roundstats.TakenDamage = (roundstats.CombinedHP / ArmadaDefenseHPR1) * ArmadaAttackDamageR1
                        Else
                            roundstats.TakenDamage = (roundstats.CombinedHP / ArmadaAttackHPR1) * ArmadaDefenseDamageR1
                        End If
                        'Calculate Losses for every fleet
                        If (roundstats.TakenDamage > roundstats.HP) Then
                            roundstats.Losses = roundstats.TakenDamage \ roundstats.HP
                        End If

                        If (roundstats.Losses > roundstats.Count) Then
                            roundstats.Losses = roundstats.Count
                        End If
                        roundstats.Count -= roundstats.Losses
                        'Add losses to Total Loss count, and remove lost ships from fleet totals
                        FinalStats(i).TotalLosses += roundstats.Losses
                        If roundstats.Count = 0 Then
                            FinalStats(i).CombinedHP = 0
                            FinalStats(i).CombinedDamage = 0
                            FinalStats(i).Count = 0
                        Else
                            FinalStats(i).CombinedHP -= (roundstats.Losses * roundstats.HP)
                            FinalStats(i).CombinedDamage -= (roundstats.Losses * roundstats.Damage)
                            FinalStats(i).Count -= roundstats.Losses
                        End If
                        FinalStats(i).Count2 -= FinalStats(i).Losses
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
                    'Combat Round 2
                Case 2
                    If ArmadaDefenseDamageR2 > 0 And ArmadaAttackDamageR2 > 0 Then
                        'Set R3 variable from current armada stats according to round 1 boosts
                        ArmadaAttackDamageR3 = ArmadaAttackDamageR2 * 1.66
                        ArmadaAttackHPR3 = ArmadaAttackHPR2
                        ArmadaDefenseDamageR3 = ArmadaDefenseDamageR2 * 1.66
                        ArmadaDefenseHPR3 = ArmadaDefenseHPR2
                        roundstats.TCombinedHP = roundstats.CombinedHP
                        roundstats.TCombinedDamage = roundstats.CombinedDamage * 1.66
                        roundstats.THP = roundstats.HP
                        roundstats.TDamage = roundstats.Damage * 1.66
                        'Calculate Damage taken for every fleet
                        If Not (roundstats.FleetAttacker) Then
                            roundstats.TakenDamage = (roundstats.TCombinedHP / ArmadaDefenseHPR3) * ArmadaAttackDamageR3
                        Else
                            roundstats.TakenDamage = (roundstats.TCombinedHP / ArmadaAttackHPR3) * ArmadaDefenseDamageR3
                        End If
                        'Calculate Losses for every fleet
                        If (roundstats.TakenDamage > roundstats.THP) Then
                            roundstats.Losses = roundstats.TakenDamage \ roundstats.THP
                        End If
                        If (roundstats.Losses > roundstats.Count) Then
                            roundstats.Losses = roundstats.Count
                        End If
                        roundstats.Count -= roundstats.Losses
                        'Add losses to Total Loss count, and remove lost ships from fleet totals
                        FinalStats(i).TotalLosses += roundstats.Losses
                        If roundstats.Count = 0 Then
                            FinalStats(i).CombinedHP = 0
                            FinalStats(i).CombinedDamage = 0
                            FinalStats(i).Count = 0
                        Else
                            FinalStats(i).CombinedHP -= (roundstats.Losses * roundstats.HP)
                            FinalStats(i).CombinedDamage -= (roundstats.Losses * roundstats.Damage)
                            FinalStats(i).Count -= roundstats.Losses
                        End If
                        FinalStats(i).Count2 -= FinalStats(i).Losses
                        FinalStats(i).Losses = 0
                    End If
            End Select
        Next
        'Return final values
        Return FinalStats
    End Function

    'Function Suppression(ByVal ParamArray FinalStats())
    '    If FinalStats.FleetAttacker Then
    '        If DefSupression > FinalStats.HP Then
    '            SupressionTaken = (FinalStats.TCombinedHP / ArmadaAttackHPR0)
    '            ArmadaAttackDamageR0 -= (SupressionTaken \ FinalStats.THP) * FinalStats.TDamage
    '        End If
    '    End If
    'End Function


    Private Sub Result_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Init Temp FleetStats object array
        Dim stats, defstats As FleetStats()
        'Calculate Final Stats of every fleet
        stats = Calculate(fleetarray)
        defstats = Calculate(dfleetarray)
        'Execute 3 rounds of combat using new variables each time
        AttackFleets = Fight(stats)
        DefenseFleets = Fight(defstats)
        'Set Round to 1 (R0 being round 1, R1 being round 2, R2 being round 3)
        j = 1
        AttackFleetsR1 = Fight(AttackFleets)
        DefenseFleetsR1 = Fight(DefenseFleets)
        'Set Round to 2
        j = 2
        AttackFleetsR2 = Fight(AttackFleetsR1)
        DefenseFleetsR2 = Fight(DefenseFleetsR1)
        'Display final results
        DataGridView1.Rows.Clear()
        For k As Integer = 0 To AttackFleetsR2.GetLength(0) - 1
            DataGridView1.Rows.Add(AttackFleetsR2(k).Type, AttackFleetsR2(k).Count3, AttackFleetsR2(k).HP, AttackFleetsR2(k).Damage, AttackFleetsR2(k).SCombinedHP, AttackFleetsR2(k).SCombinedDamage, AttackFleetsR2(k).FleetAttacker, AttackFleetsR2(k).TotalLosses, AttackFleetsR2(k).Count2)
        Next
        DataGridView1.Rows.Add("Attacking Armada", "", "", "", ArmadaAttackHP, ArmadaAttackDamage)
        DataGridView1.Rows.Add()
        For l As Integer = 0 To DefenseFleetsR2.GetLength(0) - 1
            DataGridView1.Rows.Add(DefenseFleetsR2(l).Type, DefenseFleetsR2(l).Count3, DefenseFleetsR2(l).HP, DefenseFleetsR2(l).Damage, DefenseFleetsR2(l).SCombinedHP, DefenseFleetsR2(l).SCombinedDamage, DefenseFleetsR2(l).FleetAttacker, DefenseFleetsR2(l).TotalLosses, DefenseFleetsR2(l).Count2)
        Next
        DataGridView1.Rows.Add("Defending Armada", "", "", "", ArmadaDefenseHPR, ArmadaDefenseDamageR)
    End Sub

    Private Sub Tfleet2hp_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Selector.Close()
    End Sub


End Class