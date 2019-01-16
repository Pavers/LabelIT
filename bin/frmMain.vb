Imports Microsoft.SqlHelper

Public Class frmMain
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel2 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel3 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel4 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusBar1 = New System.Windows.Forms.StatusBar()
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel()
        Me.StatusBarPanel2 = New System.Windows.Forms.StatusBarPanel()
        Me.StatusBarPanel3 = New System.Windows.Forms.StatusBarPanel()
        Me.StatusBarPanel4 = New System.Windows.Forms.StatusBarPanel()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = New System.Drawing.Point(0, 544)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1, Me.StatusBarPanel2, Me.StatusBarPanel3, Me.StatusBarPanel4})
        Me.StatusBar1.ShowPanels = True
        Me.StatusBar1.Size = New System.Drawing.Size(704, 22)
        Me.StatusBar1.TabIndex = 1
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.Icon = CType(resources.GetObject("StatusBarPanel1.Icon"), System.Drawing.Icon)
        Me.StatusBarPanel1.Name = "StatusBarPanel1"
        Me.StatusBarPanel1.Text = "© 2007 Pavers Ltd"
        Me.StatusBarPanel1.Width = 150
        '
        'StatusBarPanel2
        '
        Me.StatusBarPanel2.Name = "StatusBarPanel2"
        Me.StatusBarPanel2.Text = "Version: "
        '
        'StatusBarPanel3
        '
        Me.StatusBarPanel3.Name = "StatusBarPanel3"
        Me.StatusBarPanel3.Text = "Connection Status"
        Me.StatusBarPanel3.ToolTipText = "0"
        '
        'StatusBarPanel4
        '
        Me.StatusBarPanel4.Name = "StatusBarPanel4"
        Me.StatusBarPanel4.Text = "Branch"
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem3, Me.MenuItem5})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2})
        Me.MenuItem1.Text = "&File"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Text = "E&xit"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 1
        Me.MenuItem3.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem4})
        Me.MenuItem3.Text = "&Labels"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 0
        Me.MenuItem4.Text = "&Print Labels"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 2
        Me.MenuItem5.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem8})
        Me.MenuItem5.Text = "&Help"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 0
        Me.MenuItem8.Text = "&About"
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(704, 566)
        Me.Controls.Add(Me.StatusBar1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Menu = Me.MainMenu1
        Me.Name = "frmMain"
        Me.Text = "Label It"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.StatusBarPanel2.Text = Application.ProductVersion



        'Dim Icon As New Icon("NotTried.ico")

        If GetSetting("labelIt", "settings", "wsx") = "" Then
            Dim F As New frmSetup
            F.ShowDialog()
            Me.Close()
            Exit Sub

        End If


        MenuItem3.Enabled = False
        If GetSetting("labelit", "settings", "Connection") <> "DB" Then
            StatusBarPanel3.ToolTipText = "Attempting connection to " & _WSXurl
            StatusBarPanel3.Text = "Attempting Connection"
            StatusBarPanel3.Icon = GetEmbeddedIcon("NotTried.ico")
            Timer1.Start()
        Else
            StatusBarPanel3.Text = "Trying DB Conn"
            StatusBarPanel3.Icon = GetEmbeddedIcon("NotTried.ico")
            setDBConn()
        End If
    End Sub
    Private Sub setDBConn()
        Dim DB, User, Pass As String
        DB = GetSetting("labelit", "settings", "db")
        User = GetSetting("labelit", "settings", "user")
        Pass = GetSetting("labelit", "settings", "pass")
        Dim i As Integer
        _CN = "Data Source=" & DB & ";User Id=" & User & ";Password=" & Pass & ";"
        Try
            i = SqlHelper.ExecuteScalar(_CN, CommandType.Text, "select 1")
        Catch ex As Exception
        End Try
        If i > 0 Then

            StatusBarPanel3.Icon = GetEmbeddedIcon("Connected.ico")
            Me.StatusBarPanel3.Text = "Using Till DB"
            StatusBarPanel3.ToolTipText = "Using local till database (" & DB & ")"
            MenuItem3.Enabled = True
        Else

            StatusBarPanel3.Icon = GetEmbeddedIcon("NoConnection.ico")
            'StatusBarPanel3.Icon = GetEmbeddedIcon("Connected.ico")
            StatusBarPanel3.Text = "Unable to connect db"
            StatusBarPanel3.ToolTipText = "Unable to connect to db (" & DB & ")"
            MenuItem3.Enabled = False


        End If

    End Sub

    Function GetEmbeddedIcon(ByVal strName As String) As Icon
        strName = "LabelIt." & strName
        Return New Icon(System.Reflection.Assembly.GetExecutingAssembly.GetManifestResourceStream(strName))
    End Function

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim WSX As New LSX.LSX
        WSX.Url = _WSXurl
        _Branch = GetSetting("labelIt", "settings", "branch")
        StatusBarPanel4.Text = "Branch : " & _Branch
        Dim isConnected As Integer = 0
        Try
            isConnected = WSX.isConnectionActive
            If isConnected = 1 Then
                'we are connected

                StatusBarPanel3.Icon = GetEmbeddedIcon("Connected.ico")
                Me.StatusBarPanel3.Text = "Connected"
                StatusBarPanel3.ToolTipText = "Succesfully connected to " & _WSXurl
                MenuItem3.Enabled = True
            Else
                Throw New Exception("")
            End If

        Catch ex As Exception
            StatusBarPanel3.Icon = GetEmbeddedIcon("NoConnection.ico")
            'StatusBarPanel3.Icon = GetEmbeddedIcon("Connected.ico")
            StatusBarPanel3.Text = "Unable to connect"
            StatusBarPanel3.ToolTipText = "Unable to connect to " & _WSXurl
            MenuItem3.Enabled = False
        End Try

        Timer1.Interval = 60000
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Me.Close()

    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Dim F As New Form1
        F.MdiParent = Me
        F.WindowState = FormWindowState.Maximized

        F.Show()

    End Sub

    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        Dim F As New frmAbout
        F.ShowDialog()

    End Sub




    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click

    End Sub


    Private Sub MenuItem13_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim DBC As New DBC
        DBC.GetLastRetailPrice("00505490")
    End Sub



End Class
