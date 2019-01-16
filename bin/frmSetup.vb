Public Class frmSetup
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtBranch As System.Windows.Forms.TextBox
    Friend WithEvents CBJobEnd As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDBServer As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents rdWS As System.Windows.Forms.RadioButton
    Friend WithEvents rdDB As System.Windows.Forms.RadioButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCurrency As System.Windows.Forms.TextBox
    Friend WithEvents cbMultiply As System.Windows.Forms.CheckBox
    Friend WithEvents nmMultiply As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtPrinter2 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbDynamic As System.Windows.Forms.CheckBox
    Friend WithEvents cbHoReduction As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtBranch = New System.Windows.Forms.TextBox
        Me.CBJobEnd = New System.Windows.Forms.CheckBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtDBServer = New System.Windows.Forms.TextBox
        Me.txtUsername = New System.Windows.Forms.TextBox
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.rdWS = New System.Windows.Forms.RadioButton
        Me.rdDB = New System.Windows.Forms.RadioButton
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtCurrency = New System.Windows.Forms.TextBox
        Me.cbMultiply = New System.Windows.Forms.CheckBox
        Me.nmMultiply = New System.Windows.Forms.NumericUpDown
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtPrinter2 = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.cbDynamic = New System.Windows.Forms.CheckBox
        Me.cbHoReduction = New System.Windows.Forms.CheckBox
        CType(Me.nmMultiply, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(272, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Setup"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(120, 56)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(272, 20)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "http://212.250.100.5/LabelService/LSX.asmx"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Webservice address"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Printer Name"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(120, 184)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(272, 20)
        Me.TextBox2.TabIndex = 4
        Me.TextBox2.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(112, 416)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 24)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Save"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 248)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Branch"
        '
        'txtBranch
        '
        Me.txtBranch.Location = New System.Drawing.Point(120, 248)
        Me.txtBranch.MaxLength = 3
        Me.txtBranch.Name = "txtBranch"
        Me.txtBranch.Size = New System.Drawing.Size(272, 20)
        Me.txtBranch.TabIndex = 7
        Me.txtBranch.Text = "999"
        '
        'CBJobEnd
        '
        Me.CBJobEnd.Location = New System.Drawing.Point(120, 352)
        Me.CBJobEnd.Name = "CBJobEnd"
        Me.CBJobEnd.Size = New System.Drawing.Size(184, 24)
        Me.CBJobEnd.TabIndex = 8
        Me.CBJobEnd.Text = "Print Job End label"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Database server"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Username"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 152)
        Me.Label7.Name = "Label7"
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Password"
        '
        'txtDBServer
        '
        Me.txtDBServer.Location = New System.Drawing.Point(120, 88)
        Me.txtDBServer.Name = "txtDBServer"
        Me.txtDBServer.Size = New System.Drawing.Size(272, 20)
        Me.txtDBServer.TabIndex = 12
        Me.txtDBServer.Text = ""
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(120, 120)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(272, 20)
        Me.txtUsername.TabIndex = 13
        Me.txtUsername.Text = ""
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(120, 152)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(272, 20)
        Me.txtPassword.TabIndex = 14
        Me.txtPassword.Text = ""
        '
        'rdWS
        '
        Me.rdWS.Checked = True
        Me.rdWS.Location = New System.Drawing.Point(120, 384)
        Me.rdWS.Name = "rdWS"
        Me.rdWS.Size = New System.Drawing.Size(112, 24)
        Me.rdWS.TabIndex = 15
        Me.rdWS.TabStop = True
        Me.rdWS.Text = "Use Webservice"
        '
        'rdDB
        '
        Me.rdDB.Location = New System.Drawing.Point(248, 384)
        Me.rdDB.Name = "rdDB"
        Me.rdDB.Size = New System.Drawing.Size(120, 24)
        Me.rdDB.TabIndex = 16
        Me.rdDB.Text = "Use Database"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(8, 280)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(136, 23)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Currency Symbol"
        '
        'txtCurrency
        '
        Me.txtCurrency.Location = New System.Drawing.Point(120, 280)
        Me.txtCurrency.MaxLength = 1
        Me.txtCurrency.Name = "txtCurrency"
        Me.txtCurrency.Size = New System.Drawing.Size(16, 20)
        Me.txtCurrency.TabIndex = 18
        Me.txtCurrency.Text = "£"
        '
        'cbMultiply
        '
        Me.cbMultiply.Location = New System.Drawing.Point(120, 312)
        Me.cbMultiply.Name = "cbMultiply"
        Me.cbMultiply.Size = New System.Drawing.Size(24, 24)
        Me.cbMultiply.TabIndex = 19
        '
        'nmMultiply
        '
        Me.nmMultiply.Location = New System.Drawing.Point(144, 320)
        Me.nmMultiply.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nmMultiply.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nmMultiply.Name = "nmMultiply"
        Me.nmMultiply.Size = New System.Drawing.Size(48, 20)
        Me.nmMultiply.TabIndex = 20
        Me.nmMultiply.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(8, 320)
        Me.Label9.Name = "Label9"
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Multiply on sale"
        '
        'txtPrinter2
        '
        Me.txtPrinter2.Location = New System.Drawing.Point(120, 214)
        Me.txtPrinter2.Name = "txtPrinter2"
        Me.txtPrinter2.Size = New System.Drawing.Size(272, 20)
        Me.txtPrinter2.TabIndex = 23
        Me.txtPrinter2.Text = ""
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(8, 214)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 16)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "2nd Printer Name"
        '
        'cbDynamic
        '
        Me.cbDynamic.Location = New System.Drawing.Point(400, 184)
        Me.cbDynamic.Name = "cbDynamic"
        Me.cbDynamic.Size = New System.Drawing.Size(72, 24)
        Me.cbDynamic.TabIndex = 24
        Me.cbDynamic.Text = "Dynamic"
        '
        'cbHoReduction
        '
        Me.cbHoReduction.Location = New System.Drawing.Point(248, 352)
        Me.cbHoReduction.Name = "cbHoReduction"
        Me.cbHoReduction.Size = New System.Drawing.Size(224, 24)
        Me.cbHoReduction.TabIndex = 25
        Me.cbHoReduction.Text = "Process Reduction from Head Office"
        '
        'frmSetup
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(490, 448)
        Me.ControlBox = False
        Me.Controls.Add(Me.cbHoReduction)
        Me.Controls.Add(Me.cbDynamic)
        Me.Controls.Add(Me.txtPrinter2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.nmMultiply)
        Me.Controls.Add(Me.cbMultiply)
        Me.Controls.Add(Me.txtCurrency)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.rdDB)
        Me.Controls.Add(Me.rdWS)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtDBServer)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CBJobEnd)
        Me.Controls.Add(Me.txtBranch)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSetup"
        Me.Text = "Setup"
        CType(Me.nmMultiply, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text.Trim = "" Or TextBox2.Text.Trim = "" Then
            MsgBox("Please supply all the information", MsgBoxStyle.Critical)
            Exit Sub
        End If


        SaveSetting("labelIt", "settings", "printer", TextBox2.Text)
        SaveSetting("labelIt", "settings", "wsx", TextBox1.Text)
        SaveSetting("labelIt", "settings", "branch", txtBranch.Text)
        SaveSetting("labelIt", "settings", "db", Me.txtDBServer.Text)
        SaveSetting("labelIt", "settings", "user", Me.txtUsername.Text)
        SaveSetting("labelIt", "settings", "pass", Me.txtPassword.Text)
        SaveSetting("labelit", "settings", "currency", Me.txtCurrency.Text)
        SaveSetting("labelit", "settings", "printer2", txtPrinter2.Text)
        If cbMultiply.Checked = True Then
            SaveSetting("labelit", "settings", "multiply", nmMultiply.Value)
        Else
            SaveSetting("labelit", "settings", "multiply", "")
        End If
        If cbHoReduction.Checked = True Then
            SaveSetting("labelit", "settings", "horeduction", "1")
        Else
            SaveSetting("labelit", "settings", "horeduction", "0")
        End If
        Dim Conmethod As String
        If rdWS.Checked = True Then
            Conmethod = "WS"
        Else
            Conmethod = "DB"
        End If

        SaveSetting("labelIt", "settings", "Connection", Conmethod)
        Dim JE As Integer
        If CBJobEnd.Checked = True Then
            JE = 1
        Else
            JE = 0

        End If
        SaveSetting("labelIt", "settings", "jobend", JE)

        Dim Dyn As Integer
        If cbDynamic.Checked = True Then
            Dyn = 1
        Else
            Dyn = 0
        End If

        SaveSetting("labelIt", "settings", "dynamicprinter", Dyn)
        Me.Close()
    End Sub

    Private Sub frmSetup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If GetSetting("labelIt", "settings", "printer") <> "" Then
            TextBox2.Text = GetSetting("labelIt", "settings", "printer")
        End If

        If GetSetting("labelIt", "settings", "wsx") <> "" Then
            TextBox1.Text = GetSetting("labelIt", "settings", "wsx")
        End If

        If GetSetting("labelIt", "settings", "branch") <> "" Then
            txtBranch.Text = GetSetting("labelIt", "settings", "branch")
        End If

        If GetSetting("labelit", "settings", "db") <> "" Then
            Me.txtDBServer.Text = GetSetting("labelit", "settings", "db")
        End If
        If GetSetting("labelit", "settings", "user") <> "" Then
            Me.txtUsername.Text = GetSetting("labelit", "settings", "user")
        End If
        If GetSetting("labelit", "settings", "pass") <> "" Then
            Me.txtPassword.Text = GetSetting("labelit", "settings", "pass")
        End If
        If GetSetting("labelit", "settings", "currency") <> "" Then
            Me.txtCurrency.Text = GetSetting("labelit", "settings", "currency")
        End If
        If GetSetting("labelit", "settings", "horeduction", "0") = "1" Then
            Me.cbHoReduction.Checked = True
        Else
            Me.cbHoReduction.Checked = False


        End If
        If GetSetting("labelit", "settings", "Connection") <> "DB" Then
            rdWS.Checked = True
        Else
            rdDB.Checked = True
        End If
        txtPrinter2.Text = GetSetting("labelit", "settings", "printer2", "")

        If GetSetting("labelit", "settings", "multiply") <> "" Then
            cbMultiply.Checked = True
            nmMultiply.Value = GetSetting("labelit", "settings", "multiply")
        Else
            cbMultiply.Checked = False
        End If

        If GetSetting("labelIt", "settings", "jobend", "0") = 1 Then
            Me.CBJobEnd.Checked = True
        Else
            Me.CBJobEnd.Checked = False
        End If

        If GetSetting("labelIt", "settings", "dynamicprinter", 0) = 1 Then
            Me.cbDynamic.Checked = True
        Else
            Me.cbDynamic.Checked = False
        End If
    End Sub
End Class
