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

    Function Fight(ByVal ParamArray BaseValues2() As FleetBase) As FleetStats()
        Dim result(BaseValues2.Count() - 1) As FleetStats

        For i As Integer = 0 To result.Count() - 1
            Dim stats As FleetStats = New FleetStats()
            If Not (BaseValues2(i).Attacker) Then
                result(i).TakenDamage = (result(i).CombinedHP / ArmadaDefenseHP) * ArmadaAttackDamage
            Else
                result(i).TakenDamage = (result(i).CombinedHP / ArmadaAttackHP) * ArmadaDefenseDamage
            End If

            If (result(i).TakenDamage > result(i).HP) Then
                result(i).Losses = result(i).TakenDamage \ result(i).HP
            End If

            result(i) = stats
        Next
        Return result
    End Function

    Function Fight(ByVal ParamArray FinalStats() As FleetStats) As FleetStats()
        Dim result(FinalStats.Count() - 1) As FleetStats

        For i As Integer = 0 To result.Count() - 1
            Dim stat As FleetStats = New FleetStats()
            If (FinalStats(i).FleetAttacker) Then
                result(i).TakenDamage = (result(i).CombinedHP / ArmadaDefenseHP) * ArmadaAttackDamage
            Else
                result(i).TakenDamage = (result(i).CombinedHP / ArmadaAttackHP) * ArmadaDefenseDamage
            End If

            If (result(i).TakenDamage > result(i).HP) Then
                result(i).Losses = result(i).TakenDamage \ result(i).HP
            End If
            result(i) = stat
        Next
        Return result
    End Function


    Private Sub Result_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim stats, defstats As FleetStats()
        stats = Calculate(fleetarray)
        defstats = Calculate(dfleetarray)

        'Fleet 1 Variable Init'

        'Dim fleet1hp As Int64
        'Dim fleet1dmg As Int64
        'Dim fleet1hpboost As Int64
        'Dim fleet1dmgboost As Int64
        'Dim cfleet1hp As Int64
        'Dim cfleet1dmg As Int64

        ''Defending Fleet 1 Variable Init'

        'Dim dfleet1hp As Int64
        'Dim dfleet1dmg As Int64
        'Dim dfleet1hpboost As Int64
        'Dim dfleet1dmgboost As Int64
        'Dim dcfleet1hp As Int64
        'Dim dcfleet1dmg As Int64

        ''Fleet 2 Variable Init'

        'Dim fleet2hp As Int64
        'Dim fleet2dmg As Int64
        'Dim fleet2hpboost As Int64
        'Dim fleet2dmgboost As Int64
        'Dim cfleet2hp As Int64
        'Dim cfleet2dmg As Int64

        ''Defending Fleet 2 Variable Init'

        'Dim dfleet2hp As Int64
        'Dim dfleet2dmg As Int64
        'Dim dfleet2hpboost As Int64
        'Dim dfleet2dmgboost As Int64
        'Dim dcfleet2hp As Int64
        'Dim dcfleet2dmg As Int64

        ''Combat Variables Init'

        'Dim armadahp As Int64
        'Dim armadadmg As Int64
        'Dim darmadahp As Int64
        'Dim darmadadmg As Int64
        'Dim damagetaken1 As Decimal
        'Dim damagedealt1 As Decimal
        'Dim damagetaken2 As Decimal
        'Dim damagedealt2 As Decimal
        'Dim fleet1loss As Int64
        'Dim fleet2loss As Int64
        'Dim dfleet1loss As Int64
        'Dim dfleet2loss As Int64

        ''Initial fleet HP/DMG Boost and DMG values to 0'

        'fleet1hpboost = 0
        'fleet1dmgboost = 0
        'dfleet1hpboost = 0
        'dfleet1dmgboost = 0
        'fleet2hpboost = 0
        'fleet2dmgboost = 0
        'dfleet2hpboost = 0
        'dfleet2dmgboost = 0
        'damagetaken1 = 0
        'damagetaken2 = 0
        'damagedealt1 = 0
        'damagedealt2 = 0

        ''Case for Card Bonuses Calculations'

        ''Select Case fleet1type

        ''    Case "Industrial"

        ''        fleet1hp = 400

        ''        Select Case fleet1hull

        ''            Case "Common HP"
        ''                fleet1hpboost = fleet1hpboost + 25
        ''            Case "Rare HP"
        ''                fleet1hpboost = fleet1hpboost + 50
        ''            Case "Epic HP"
        ''                fleet1hpboost = fleet1hpboost + 75
        ''            Case "Legendary HP"
        ''                fleet1hpboost = fleet1hpboost + 100

        ''        End Select

        ''        Select Case fleet1hard

        ''            Case "Common HP"
        ''                fleet1hpboost = fleet1hpboost + 20
        ''            Case "Rare HP"
        ''                fleet1hpboost = fleet1hpboost + 30
        ''            Case "Epic HP"
        ''                fleet1hpboost = fleet1hpboost + 40
        ''            Case "Legendary HP"
        ''                fleet1hpboost = fleet1hpboost + 50

        ''        End Select

        ''    Case "Corvette", "Patrol Ship"

        ''        fleet1hp = 200
        ''        fleet1dmg = 80

        ''        Select Case fleet1hull

        ''            Case "Common HP"
        ''                fleet1hpboost = fleet1hpboost + 25
        ''            Case "Rare HP"
        ''                fleet1hpboost = fleet1hpboost + 50
        ''            Case "Epic HP"
        ''                fleet1hpboost = fleet1hpboost + 75
        ''            Case "Legendary HP"
        ''                fleet1hpboost = fleet1hpboost + 100
        ''            Case "Common DMG"
        ''                fleet1dmgboost = fleet1dmgboost + 5
        ''            Case "Rare DMG"
        ''                fleet1dmgboost = fleet1dmgboost + 10
        ''            Case "Epic DMG"
        ''                fleet1dmgboost = fleet1dmgboost + 15
        ''            Case "Legendary DMG"
        ''                fleet1dmgboost = fleet1dmgboost + 20

        ''        End Select

        ''        Select Case fleet1hard

        ''            Case "Common HP"
        ''                fleet1hpboost = fleet1hpboost + 20
        ''            Case "Rare HP"
        ''                fleet1hpboost = fleet1hpboost + 30
        ''            Case "Epic HP"
        ''                fleet1hpboost = fleet1hpboost + 40
        ''            Case "Legendary HP"
        ''                fleet1hpboost = fleet1hpboost + 50
        ''            Case "Common DMG"
        ''                fleet1dmgboost = fleet1dmgboost + 10
        ''            Case "Rare DMG"
        ''                fleet1dmgboost = fleet1dmgboost + 20
        ''            Case "Epic DMG"
        ''                fleet1dmgboost = fleet1dmgboost + 30
        ''            Case "Legendary DMG"
        ''                fleet1dmgboost = fleet1dmgboost + 40

        ''        End Select

        ''    Case "Destroyer", "Frigate", "Gunship"

        ''        fleet1hp = 1000
        ''        fleet1dmg = 400

        ''        Select Case fleet1hull

        ''            Case "Common HP"
        ''                fleet1hpboost = fleet1hpboost + 125
        ''            Case "Rare HP"
        ''                fleet1hpboost = fleet1hpboost + 250
        ''            Case "Epic HP"
        ''                fleet1hpboost = fleet1hpboost + 375
        ''            Case "Legendary HP"
        ''                fleet1hpboost = fleet1hpboost + 500
        ''            Case "Common DMG"
        ''                fleet1dmgboost = fleet1dmgboost + 25
        ''            Case "Rare DMG"
        ''                fleet1dmgboost = fleet1dmgboost + 50
        ''            Case "Epic DMG"
        ''                fleet1dmgboost = fleet1dmgboost + 75
        ''            Case "Legendary DMG"
        ''                fleet1dmgboost = fleet1dmgboost + 100

        ''        End Select

        ''        Select Case fleet1hard

        ''            Case "Common HP"
        ''                fleet1hpboost = fleet1hpboost + 100
        ''            Case "Rare HP"
        ''                fleet1hpboost = fleet1hpboost + 150
        ''            Case "Epic HP"
        ''                fleet1hpboost = fleet1hpboost + 200
        ''            Case "Legendary HP"
        ''                fleet1hpboost = fleet1hpboost + 200
        ''            Case "Common DMG"
        ''                fleet1dmgboost = fleet1dmgboost + 50
        ''            Case "Rare DMG"
        ''                fleet1dmgboost = fleet1dmgboost + 100
        ''            Case "Epic DMG"
        ''                fleet1dmgboost = fleet1dmgboost + 150
        ''            Case "Legendary DMG"
        ''                fleet1dmgboost = fleet1dmgboost + 200

        ''        End Select

        ''        'Select Case fleet1card

        ''    Case "Carrier", "Dreadnaught"

        ''                fleet1hp = 5000
        ''                fleet1dmg = 2000

        ''                Select Case fleet1hull

        ''                    Case "Common HP"
        ''                        fleet1hpboost = fleet1hpboost + 125
        ''                    Case "Rare HP"
        ''                        fleet1hpboost = fleet1hpboost + 250
        ''                    Case "Epic HP"
        ''                        fleet1hpboost = fleet1hpboost + 375
        ''                    Case "Legendary HP"
        ''                        fleet1hpboost = fleet1hpboost + 500
        ''                    Case "Common DMG"
        ''                        fleet1dmgboost = fleet1dmgboost + 25
        ''                    Case "Rare DMG"
        ''                        fleet1dmgboost = fleet1dmgboost + 50
        ''                    Case "Epic DMG"
        ''                        fleet1dmgboost = fleet1dmgboost + 75
        ''                    Case "Legendary DMG"
        ''                        fleet1dmgboost = fleet1dmgboost + 100

        ''                End Select

        ''                Select Case fleet1hard

        ''                    Case "Common HP"
        ''                        fleet1hpboost = fleet1hpboost + 500
        ''                    Case "Rare HP"
        ''                        fleet1hpboost = fleet1hpboost + 750
        ''                    Case "Epic HP"
        ''                        fleet1hpboost = fleet1hpboost + 1000
        ''                    Case "Legendary HP"
        ''                        fleet1hpboost = fleet1hpboost + 1000
        ''                    Case "Common DMG"
        ''                        fleet1dmgboost = fleet1dmgboost + 250
        ''                    Case "Rare DMG"
        ''                        fleet1dmgboost = fleet1dmgboost + 500
        ''                    Case "Epic DMG"
        ''                        fleet1dmgboost = fleet1dmgboost + 750
        ''                    Case "Legendary DMG"
        ''                        fleet1dmgboost = fleet1dmgboost + 1000

        ''                End Select

        ''        End Select

        'Select Case fleet2type
        '    Case "Industrial"
        '        fleet2hp = 400
        '        Select Case fleet2hull
        '            Case "Common HP"
        '                fleet2hpboost = fleet2hpboost + 25
        '            Case "Rare HP"
        '                fleet2hpboost = fleet2hpboost + 50
        '            Case "Epic HP"
        '                fleet2hpboost = fleet2hpboost + 75
        '            Case "Legendary HP"
        '                fleet2hpboost = fleet2hpboost + 100
        '        End Select
        '        Select Case fleet2hard
        '            Case "Common HP"
        '                fleet2hpboost = fleet2hpboost + 20
        '            Case "Rare HP"
        '                fleet2hpboost = fleet2hpboost + 30
        '            Case "Epic HP"
        '                fleet2hpboost = fleet2hpboost + 40
        '            Case "Legendary HP"
        '                fleet2hpboost = fleet2hpboost + 50
        '        End Select

        '    Case "Corvette", "Patrol Ship"

        '        fleet2hp = 200
        '        fleet2dmg = 80
        '        Select Case fleet2hull
        '            Case "Common HP"
        '                fleet2hpboost = fleet2hpboost + 25
        '            Case "Rare HP"
        '                fleet2hpboost = fleet2hpboost + 50
        '            Case "Epic HP"
        '                fleet2hpboost = fleet2hpboost + 75
        '            Case "Legendary HP"
        '                fleet2hpboost = fleet2hpboost + 100
        '            Case "Common DMG"
        '                fleet2dmgboost = fleet2dmgboost + 5
        '            Case "Rare DMG"
        '                fleet2dmgboost = fleet2dmgboost + 10
        '            Case "Epic DMG"
        '                fleet2dmgboost = fleet2dmgboost + 15
        '            Case "Legendary DMG"
        '                fleet2dmgboost = fleet2dmgboost + 20
        '        End Select
        '        Select Case fleet2hard
        '            Case "Common HP"
        '                fleet2hpboost = fleet2hpboost + 20
        '            Case "Rare HP"
        '                fleet2hpboost = fleet2hpboost + 30
        '            Case "Epic HP"
        '                fleet2hpboost = fleet2hpboost + 40
        '            Case "Legendary HP"
        '                fleet2hpboost = fleet2hpboost + 50
        '            Case "Common DMG"
        '                fleet2dmgboost = fleet2dmgboost + 10
        '            Case "Rare DMG"
        '                fleet2dmgboost = fleet2dmgboost + 20
        '            Case "Epic DMG"
        '                fleet2dmgboost = fleet2dmgboost + 30
        '            Case "Legendary DMG"
        '                fleet2dmgboost = fleet2dmgboost + 40
        '        End Select
        '    Case "Destroyer", "Frigate", "Gunship"
        '        fleet2hp = 1000
        '        fleet2dmg = 400
        '        Select Case fleet2hull
        '            Case "Common HP"
        '                fleet2hpboost = fleet2hpboost + 125
        '            Case "Rare HP"
        '                fleet2hpboost = fleet2hpboost + 250
        '            Case "Epic HP"
        '                fleet2hpboost = fleet2hpboost + 375
        '            Case "Legendary HP"
        '                fleet2hpboost = fleet2hpboost + 500
        '            Case "Common DMG"
        '                fleet2dmgboost = fleet2dmgboost + 25
        '            Case "Rare DMG"
        '                fleet2dmgboost = fleet2dmgboost + 50
        '            Case "Epic DMG"
        '                fleet2dmgboost = fleet2dmgboost + 75
        '            Case "Legendary DMG"
        '                fleet2dmgboost = fleet2dmgboost + 100
        '        End Select
        '        Select Case fleet2hard
        '            Case "Common HP"
        '                fleet2hpboost = fleet2hpboost + 100
        '            Case "Rare HP"
        '                fleet2hpboost = fleet2hpboost + 150
        '            Case "Epic HP"
        '                fleet2hpboost = fleet2hpboost + 200
        '            Case "Legendary HP"
        '                fleet2hpboost = fleet2hpboost + 200
        '            Case "Common DMG"
        '                fleet2dmgboost = fleet2dmgboost + 50
        '            Case "Rare DMG"
        '                fleet2dmgboost = fleet2dmgboost + 100
        '            Case "Epic DMG"
        '                fleet2dmgboost = fleet2dmgboost + 150
        '            Case "Legendary DMG"
        '                fleet2dmgboost = fleet2dmgboost + 200
        '        End Select
        '    Case "Carrier", "Dreadnaught"
        '        fleet2hp = 5000
        '        fleet2dmg = 2000
        '        Select Case fleet2hull
        '            Case "Common HP"
        '                fleet2hpboost = fleet2hpboost + 125
        '            Case "Rare HP"
        '                fleet2hpboost = fleet2hpboost + 250
        '            Case "Epic HP"
        '                fleet2hpboost = fleet2hpboost + 375
        '            Case "Legendary HP"
        '                fleet2hpboost = fleet2hpboost + 500
        '            Case "Common DMG"
        '                fleet2dmgboost = fleet2dmgboost + 25
        '            Case "Rare DMG"
        '                fleet2dmgboost = fleet2dmgboost + 50
        '            Case "Epic DMG"
        '                fleet2dmgboost = fleet2dmgboost + 75
        '            Case "Legendary DMG"
        '                fleet2dmgboost = fleet2dmgboost + 100
        '        End Select
        '        Select Case fleet2hard
        '            Case "Common HP"
        '                fleet2hpboost = fleet2hpboost + 500
        '            Case "Rare HP"
        '                fleet2hpboost = fleet2hpboost + 750
        '            Case "Epic HP"
        '                fleet2hpboost = fleet2hpboost + 1000
        '            Case "Legendary HP"
        '                fleet2hpboost = fleet2hpboost + 1000
        '            Case "Common DMG"
        '                fleet2dmgboost = fleet2dmgboost + 250
        '            Case "Rare DMG"
        '                fleet2dmgboost = fleet2dmgboost + 500
        '            Case "Epic DMG"
        '                fleet2dmgboost = fleet2dmgboost + 750
        '            Case "Legendary DMG"
        '                fleet2dmgboost = fleet2dmgboost + 1000
        '        End Select
        'End Select

        'Select Case dfleet2type
        '    Case "Industrial"
        '        dfleet2hp = 400
        '        Select Case dfleet2hull
        '            Case "Common HP"
        '                dfleet2hpboost = dfleet2hpboost + 25
        '            Case "Rare HP"
        '                dfleet2hpboost = dfleet2hpboost + 50
        '            Case "Epic HP"
        '                dfleet2hpboost = dfleet2hpboost + 75
        '            Case "Legendary HP"
        '                dfleet2hpboost = dfleet2hpboost + 100
        '        End Select
        '        Select Case dfleet2hard
        '            Case "Common HP"
        '                dfleet2hpboost = dfleet2hpboost + 20
        '            Case "Rare HP"
        '                dfleet2hpboost = dfleet2hpboost + 30
        '            Case "Epic HP"
        '                dfleet2hpboost = dfleet2hpboost + 40
        '            Case "Legendary HP"
        '                dfleet2hpboost = dfleet2hpboost + 50
        '        End Select

        '    Case "Corvette", "Patrol Ship"
        '        dfleet2hp = 200
        '        dfleet2dmg = 80
        '        Select Case dfleet2hull
        '            Case "Common HP"
        '                dfleet2hpboost = dfleet2hpboost + 25
        '            Case "Rare HP"
        '                dfleet2hpboost = dfleet2hpboost + 50
        '            Case "Epic HP"
        '                dfleet2hpboost = dfleet2hpboost + 75
        '            Case "Legendary HP"
        '                dfleet2hpboost = dfleet2hpboost + 100
        '            Case "Common DMG"
        '                dfleet2dmgboost = dfleet2dmgboost + 5
        '            Case "Rare DMG"
        '                dfleet2dmgboost = dfleet2dmgboost + 10
        '            Case "Epic DMG"
        '                dfleet2dmgboost = dfleet2dmgboost + 15
        '            Case "Legendary DMG"
        '                dfleet2dmgboost = dfleet2dmgboost + 20
        '        End Select
        '        Select Case dfleet2hard
        '            Case "Common HP"
        '                dfleet2hpboost = dfleet2hpboost + 20
        '            Case "Rare HP"
        '                dfleet2hpboost = dfleet2hpboost + 30
        '            Case "Epic HP"
        '                dfleet2hpboost = dfleet2hpboost + 40
        '            Case "Legendary HP"
        '                dfleet2hpboost = dfleet2hpboost + 50
        '            Case "Common DMG"
        '                dfleet2dmgboost = dfleet2dmgboost + 10
        '            Case "Rare DMG"
        '                dfleet2dmgboost = dfleet2dmgboost + 20
        '            Case "Epic DMG"
        '                dfleet2dmgboost = dfleet2dmgboost + 30
        '            Case "Legendary DMG"
        '                dfleet2dmgboost = dfleet2dmgboost + 40
        '        End Select
        '    Case "Destroyer", "Frigate", "Gunship"
        '        dfleet2hp = 1000
        '        dfleet2dmg = 400
        '        Select Case dfleet2hull
        '            Case "Common HP"
        '                dfleet2hpboost = dfleet2hpboost + 125
        '            Case "Rare HP"
        '                dfleet2hpboost = dfleet2hpboost + 250
        '            Case "Epic HP"
        '                dfleet2hpboost = dfleet2hpboost + 375
        '            Case "Legendary HP"
        '                dfleet2hpboost = dfleet2hpboost + 500
        '            Case "Common DMG"
        '                dfleet2dmgboost = dfleet2dmgboost + 25
        '            Case "Rare DMG"
        '                dfleet2dmgboost = dfleet2dmgboost + 50
        '            Case "Epic DMG"
        '                dfleet2dmgboost = dfleet2dmgboost + 75
        '            Case "Legendary DMG"
        '                dfleet2dmgboost = dfleet2dmgboost + 100
        '        End Select
        '        Select Case dfleet2hard
        '            Case "Common HP"
        '                dfleet2hpboost = dfleet2hpboost + 100
        '            Case "Rare HP"
        '                dfleet2hpboost = dfleet2hpboost + 150
        '            Case "Epic HP"
        '                dfleet2hpboost = dfleet2hpboost + 200
        '            Case "Legendary HP"
        '                dfleet2hpboost = dfleet2hpboost + 200
        '            Case "Common DMG"
        '                dfleet2dmgboost = dfleet2dmgboost + 50
        '            Case "Rare DMG"
        '                dfleet2dmgboost = dfleet2dmgboost + 100
        '            Case "Epic DMG"
        '                dfleet2dmgboost = dfleet2dmgboost + 150
        '            Case "Legendary DMG"
        '                dfleet2dmgboost = dfleet2dmgboost + 200
        '        End Select
        '    Case "Carrier", "Dreadnaught"
        '        dfleet2hp = 5000
        '        dfleet2dmg = 2000
        '        Select Case dfleet2hull
        '            Case "Common HP"
        '                dfleet2hpboost = dfleet2hpboost + 125
        '            Case "Rare HP"
        '                dfleet2hpboost = dfleet2hpboost + 250
        '            Case "Epic HP"
        '                dfleet2hpboost = dfleet2hpboost + 375
        '            Case "Legendary HP"
        '                dfleet2hpboost = dfleet2hpboost + 500
        '            Case "Common DMG"
        '                dfleet2dmgboost = dfleet2dmgboost + 25
        '            Case "Rare DMG"
        '                dfleet2dmgboost = dfleet2dmgboost + 50
        '            Case "Epic DMG"
        '                dfleet2dmgboost = dfleet2dmgboost + 75
        '            Case "Legendary DMG"
        '                dfleet2dmgboost = dfleet2dmgboost + 100
        '        End Select
        '        Select Case dfleet2hard
        '            Case "Common HP"
        '                dfleet2hpboost = dfleet2hpboost + 500
        '            Case "Rare HP"
        '                dfleet2hpboost = dfleet2hpboost + 750
        '            Case "Epic HP"
        '                dfleet2hpboost = dfleet2hpboost + 1000
        '            Case "Legendary HP"
        '                dfleet2hpboost = dfleet2hpboost + 1000
        '            Case "Common DMG"
        '                dfleet2dmgboost = dfleet2dmgboost + 250
        '            Case "Rare DMG"
        '                dfleet2dmgboost = dfleet2dmgboost + 500
        '            Case "Epic DMG"
        '                dfleet2dmgboost = dfleet2dmgboost + 750
        '            Case "Legendary DMG"
        '                dfleet2dmgboost = dfleet2dmgboost + 1000
        '        End Select
        'End Select

        'Select Case dfleet1type
        '    Case "Corvette", "Patrol Ship"
        '        dfleet1hp = 200
        '        dfleet1dmg = 80
        '        Select Case fleet1hull
        '            Case "Common HP"
        '                dfleet1hpboost = dfleet1hpboost + 25
        '            Case "Rare HP"
        '                dfleet1hpboost = dfleet1hpboost + 50
        '            Case "Epic HP"
        '                dfleet1hpboost = dfleet1hpboost + 75
        '            Case "Legendary HP"
        '                dfleet1hpboost = dfleet1hpboost + 100
        '            Case "Common DMG"
        '                dfleet1dmgboost = dfleet1dmgboost + 5
        '            Case "Rare DMG"
        '                dfleet1dmgboost = dfleet1dmgboost + 10
        '            Case "Epic DMG"
        '                dfleet1dmgboost = dfleet1dmgboost + 15
        '            Case "Legendary DMG"
        '                dfleet1dmgboost = dfleet1dmgboost + 20
        '        End Select
        '        Select Case fleet1hard
        '            Case "Common HP"
        '                dfleet1hpboost = dfleet1hpboost + 20
        '            Case "Rare HP"
        '                dfleet1hpboost = dfleet1hpboost + 30
        '            Case "Epic HP"
        '                dfleet1hpboost = dfleet1hpboost + 40
        '            Case "Legendary HP"
        '                dfleet1hpboost = dfleet1hpboost + 50
        '            Case "Common DMG"
        '                dfleet1dmgboost = dfleet1dmgboost + 10
        '            Case "Rare DMG"
        '                dfleet1dmgboost = dfleet1dmgboost + 20
        '            Case "Epic DMG"
        '                dfleet1dmgboost = dfleet1dmgboost + 30
        '            Case "Legendary DMG"
        '                dfleet1dmgboost = dfleet1dmgboost + 40
        '        End Select
        '    Case "Destroyer", "Frigate", "Gunship"
        '        dfleet1hp = 1000
        '        dfleet1dmg = 400
        '        Select Case fleet1hull
        '            Case "Common HP"
        '                dfleet1hpboost = dfleet1hpboost + 125
        '            Case "Rare HP"
        '                dfleet1hpboost = dfleet1hpboost + 250
        '            Case "Epic HP"
        '                dfleet1hpboost = dfleet1hpboost + 375
        '            Case "Legendary HP"
        '                dfleet1hpboost = dfleet1hpboost + 500
        '            Case "Common DMG"
        '                dfleet1dmgboost = dfleet1dmgboost + 25
        '            Case "Rare DMG"
        '                dfleet1dmgboost = dfleet1dmgboost + 50
        '            Case "Epic DMG"
        '                dfleet1dmgboost = dfleet1dmgboost + 75
        '            Case "Legendary DMG"
        '                dfleet1dmgboost = dfleet1dmgboost + 100
        '        End Select
        '        Select Case fleet1hard
        '            Case "Common HP"
        '                dfleet1hpboost = dfleet1hpboost + 100
        '            Case "Rare HP"
        '                dfleet1hpboost = dfleet1hpboost + 150
        '            Case "Epic HP"
        '                dfleet1hpboost = dfleet1hpboost + 200
        '            Case "Legendary HP"
        '                dfleet1hpboost = dfleet1hpboost + 200
        '            Case "Common DMG"
        '                dfleet1dmgboost = dfleet1dmgboost + 50
        '            Case "Rare DMG"
        '                dfleet1dmgboost = dfleet1dmgboost + 100
        '            Case "Epic DMG"
        '                dfleet1dmgboost = dfleet1dmgboost + 150
        '            Case "Legendary DMG"
        '                dfleet1dmgboost = dfleet1dmgboost + 200
        '        End Select
        '    Case "Carrier", "Dreadnaught"
        '        dfleet1hp = 5000
        '        dfleet1dmg = 2000
        '        Select Case fleet1hull
        '            Case "Common HP"
        '                dfleet1hpboost = dfleet1hpboost + 125
        '            Case "Rare HP"
        '                dfleet1hpboost = dfleet1hpboost + 250
        '            Case "Epic HP"
        '                dfleet1hpboost = dfleet1hpboost + 375
        '            Case "Legendary HP"
        '                dfleet1hpboost = dfleet1hpboost + 500
        '            Case "Common DMG"
        '                dfleet1dmgboost = dfleet1dmgboost + 25
        '            Case "Rare DMG"
        '                dfleet1dmgboost = dfleet1dmgboost + 50
        '            Case "Epic DMG"
        '                dfleet1dmgboost = dfleet1dmgboost + 75
        '            Case "Legendary DMG"
        '                dfleet1dmgboost = dfleet1dmgboost + 100
        '        End Select
        '        Select Case fleet1hard
        '            Case "Common HP"
        '                dfleet1hpboost = dfleet1hpboost + 500
        '            Case "Rare HP"
        '                dfleet1hpboost = dfleet1hpboost + 750
        '            Case "Epic HP"
        '                dfleet1hpboost = dfleet1hpboost + 1000
        '            Case "Legendary HP"
        '                dfleet1hpboost = dfleet1hpboost + 1000
        '            Case "Common DMG"
        '                dfleet1dmgboost = dfleet1dmgboost + 250
        '            Case "Rare DMG"
        '                dfleet1dmgboost = dfleet1dmgboost + 500
        '            Case "Epic DMG"
        '                dfleet1dmgboost = dfleet1dmgboost + 750
        '            Case "Legendary DMG"
        '                dfleet1dmgboost = dfleet1dmgboost + 1000
        '        End Select
        'End Select

        ''Card Bonuses application to Fleet Vars'

        ''Fleet 1'
        'If fleet1count > 0 Then
        '    fleet1hp = fleet1hp + fleet1hpboost
        '    fleet1dmg = fleet1dmg + fleet1dmgboost
        '    cfleet1hp = fleet1hp * fleet1count
        '    cfleet1dmg = fleet1dmg * fleet1count
        'End If

        ''D Fleet 1'
        'If dfleet1count > 0 Then
        '    dfleet1hp = dfleet1hp + dfleet1hpboost
        '    dfleet1dmg = dfleet1dmg + dfleet1dmgboost
        '    dcfleet1hp = dfleet1hp * dfleet1count
        '    dcfleet1dmg = dfleet1dmg * dfleet1count
        'End If

        ''Fleet 2'
        'If fleet2count > 0 Then
        '    fleet2hp = fleet2hp + fleet2hpboost
        '    fleet2dmg = fleet2dmg + fleet2dmgboost
        '    cfleet2hp = fleet2hp * fleet2count
        '    cfleet2dmg = fleet2dmg * fleet2count
        'End If

        ''D Fleet 2'
        'If dfleet2count > 0 Then
        '    dfleet2hp = dfleet2hp + dfleet2hpboost
        '    dfleet2dmg = dfleet2dmg + dfleet2dmgboost
        '    dcfleet2hp = dfleet2hp * dfleet2count
        '    dcfleet2dmg = dfleet2dmg * dfleet2count
        'End If

        ''Text Fields Assignation'

        'tfleet1.Text = fleet1type
        'tfleet1count.Text = fleet1count
        'tfleet1hp.Text = cfleet1hp
        'tfleet1dmg.Text = cfleet1dmg

        'tfleet2.Text = fleet2type
        'tfleet2count.Text = fleet2count
        'tfleet2hpp.Text = cfleet2hp
        'tfleet2dmg.Text = cfleet2dmg

        ''Damage Reduction Application'

        'If fleet1type = "Patrol Ship" Or "Frigate" Then
        '    cfleet1hp = cfleet1hp / 2
        '    cfleet1dmg = cfleet1dmg / 2
        'End If

        'If fleet2type = "Patrol Ship" Or "Frigate" Then
        '    cfleet2hp = cfleet2hp / 2
        '    cfleet2dmg = cfleet2dmg / 2
        'End If

        'If dfleet1type = "Corvette" Or "Destroyer" Or "Gunship" Then
        '    dcfleet1hp = dcfleet1hp / 2
        '    dcfleet1dmg = dcfleet1dmg / 2
        'End If

        'If dfleet2type = "Corvette" Or "Destroyer" Or "Gunship" Then
        '    dcfleet2hp = dcfleet2hp / 2
        '    dcfleet2dmg = dcfleet2dmg / 2
        'End If

        ''Armada HP Calculations'

        'armadahp = cfleet1hp + cfleet2hp
        'armadadmg = cfleet1dmg + cfleet2dmg
        'darmadadmg = dcfleet1dmg + dcfleet2dmg
        'darmadahp = dcfleet1hp + dcfleet2hp





        ''Individual Fleet DMG Calculation'


        'If dfleet1count > 0 Then
        '    'FleetStats.DamageTaken(DefendingFleet) = (FleetStats.FleetHP / ArmadaDefenseHP) * ArmadaAttackDamage
        'End If


        'If dfleet2count > 0 Then
        '    damagedealt2 = (dcfleet2hp / darmadahp) * armadadmg
        'End If

        'If fleet1count > 0 Then
        '    damagetaken1 = (cfleet1hp / armadahp) * darmadadmg
        'End If


        'If fleet2count > 0 Then
        '    damagetaken2 = (cfleet2hp / armadahp) * darmadadmg
        'End If


        'tfleet1taken.Text = damagetaken1
        'tfleet2taken.Text = damagetaken2


        'If damagedealt1 > dfleet1hp Then
        '    dfleet1loss = damagedealt1 \ dfleet1hp

        'End If

        'If damagedealt2 > dfleet2hp Then
        '    dfleet2loss = damagedealt2 \ dfleet2hp

        'End If

        'If damagetaken1 > fleet1hp Then
        '    fleet1loss = damagetaken1 \ fleet1hp
        '    tfleet1loss.Text = fleet1loss
        'End If

        'If damagetaken2 > fleet2hp Then
        '    fleet2loss = damagetaken2 \ fleet2hp
        '    tfleet2loss.Text = fleet2loss
        'End If



    End Sub

    Private Sub Tfleet2hp_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Selector.Close()
    End Sub
End Class