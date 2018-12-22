
Public Class Selector
    Public hulls As New List(Of HullItem)
    Public hardPoints As New List(Of HardPointItem)
    Public fleets As New Dictionary(Of String, FleetItem)
    Public enemies As New Dictionary(Of String, EnemyList)
    Public EnType As String() = {"Patrols", "Frigates", "Dreadnaughts"}

    Private Sub btnBattleCalc_Click(sender As Object, e As EventArgs) Handles btnBattleCalc.Click
        DefFleet.Show()
        Me.Hide()
    End Sub

    Private Sub Selector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.WindowState = FormWindowState.Normal

        ' We need to load in our XML files - first the fleets
        ' This is LINQ from XML.  Cool stuff, bruh
        Try
            Dim docFleets = XDocument.Load(Application.StartupPath + "\Definitions\FleetSpecs.xml")
            Dim fleetTypes As IEnumerable(Of XElement) = From el In docFleets.Root.Elements() Select el

            For Each f In fleetTypes
                fleets.Add(f.Element("Name"), New FleetItem(CInt(f.Element("HP")), CInt(f.Element("FP")), f.Element("Type"), CBool(f.Element("CanBomb")), CBool(f.Element("AllowHardPointHP")), CBool(f.Element("AllowHardPointFP")), CBool(f.Element("AllowHullHP")), CBool(f.Element("AllowHullFP"))))
            Next

            Dim docHP = XDocument.Load(Application.StartupPath + "\Definitions\HardPoints.xml")
            Dim hardpts As IEnumerable(Of XElement) = From el In docHP.Root.Elements() Select el

            For Each hp In hardpts
                hardPoints.Add(New HardPointItem(hp.Element("Name"), hp.Element("Type"), hp.Element("Class"), CInt(hp.Element("Boost"))))
            Next

            Dim docHull = XDocument.Load(Application.StartupPath + "\Definitions\Hulls.xml")
            Dim hull As IEnumerable(Of XElement) = From el In docHull.Root.Elements() Select el

            For Each hl In hull
                hulls.Add(New HullItem(hl.Element("Name"), hl.Element("Type"), hl.Element("Class"), CInt(hl.Element("Boost"))))
            Next

            Dim docEnemy = XDocument.Load(Application.StartupPath + "\Definitions\Enemies.xml")
            Dim enList As IEnumerable(Of XElement) = From el In docEnemy.Root.Elements() Select el

            For Each en In enList
                enemies.Add(en.Element("Name"), New EnemyList(CInt(en.Element("Level"))))

                For Each ent In EnType
                    For Each enL In en.Elements(ent.ToString())
                        enemies.Item(en.Element("Name")).AddItem(ent.ToString(), enL.Value)
                    Next
                Next
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "An Error Occured")
            Application.Exit()
        End Try
    End Sub
End Class

Public Class FleetItem
    Public hp As Integer
    Public fp As Integer
    Public type As String
    Public canBomb As Boolean
    Public allowHardPointHP As Boolean
    Public allowHardPointFP As Boolean
    Public allowHullHP As Boolean
    Public allowHullFP As Boolean

    Public Sub New(_hp As Integer, _fp As Integer, _t As String, _cb As Boolean, _ahphp As Boolean, _ahpfp As Boolean, _ahhp As Boolean, _ahfp As Boolean)
        hp = _hp
        fp = _fp
        type = _t
        canBomb = _cb
        allowHardPointFP = _ahpfp
        allowHardPointHP = _ahphp
        allowHullFP = _ahfp
        allowHullHP = _ahhp
    End Sub
End Class

Public Class HardPointItem
    Public name As String
    Public type As String
    Public _class As String
    Public boost As Integer

    Public Sub New(_n As String, _t As String, _c As String, _b As Integer)
        name = _n
        type = _t
        _class = _c
        boost = _b
    End Sub
End Class

Public Class HullItem
    Public name As String
    Public type As String
    Public _class As String
    Public boost As Integer

    Public Sub New(_n As String, _t As String, _c As String, _b As Integer)
        name = _n
        type = _t
        _class = _c
        boost = _b
    End Sub
End Class

Public Class EnemyList
    Public level As Integer
    Public LineItems As New Stack(Of KeyValuePair(Of String, Integer))

    Public Sub New(_l As Integer)
        level = _l
    End Sub

    Public Sub AddItem(_t As String, _a As Integer)
        LineItems.Push(New KeyValuePair(Of String, Integer)(_t, _a))
    End Sub
End Class
