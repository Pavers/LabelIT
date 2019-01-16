Imports System.management
Public Class frmDownloadSale
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
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblProcessStatus As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmDownloadSale))
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblStatus = New System.Windows.Forms.Label
        Me.lblProcessStatus = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label It"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 32)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(48, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Please wait......"
        '
        'lblStatus
        '
        Me.lblStatus.Location = New System.Drawing.Point(160, 16)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(344, 16)
        Me.lblStatus.TabIndex = 3
        '
        'lblProcessStatus
        '
        Me.lblProcessStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcessStatus.Location = New System.Drawing.Point(160, 32)
        Me.lblProcessStatus.Name = "lblProcessStatus"
        Me.lblProcessStatus.Size = New System.Drawing.Size(344, 23)
        Me.lblProcessStatus.TabIndex = 4
        '
        'Timer1
        '
        Me.Timer1.Interval = 60000
        '
        'frmDownloadSale
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(520, 48)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblProcessStatus)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDownloadSale"
        Me.Opacity = 0.8
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public ActivityTime As TimeSpan
    Public TimeSinceActivity As TimeSpan
    Public startTime As TimeSpan
    Public T As Threading.Thread
    Dim objStatus As ManagementObject
    Dim pingResults As String

    'Public Sub Ping()

    '    On Error Resume Next

    '    Dim objPing As New SelectQuery("Select StatusCode from Win32_PingStatus WHERE Address = '192.168.0.300'")
    '    Dim Search As New ManagementObjectSearcher(objPing)

    '    For Each objStatus In Search.Get()

    '        pingResults = objStatus("StatusCode").ToString

    '    Next

    '    objPing = Nothing
    '    Search = Nothing

    'End Sub



    Private Sub frmDownloadSale_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Try

        'Catch ex As Exception
        '    Me.Close()
        '   End Try

        ' ()

        'Ping()
        'Exit Sub

        'MsgBox("load")


    End Sub
    Private WithEvents R As New Reduction

    Private Delegate Sub closeFormSub()
    Private Sub closeForm()
        Try
            If Me.InvokeRequired Then
                Me.Invoke(New closeFormSub(AddressOf closeForm))
                Return
            End If
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Delegate Sub updateLabelSub(ByVal name As String, ByVal text As String)
    Private Sub updateLabel(ByVal name As String, ByVal text As String)
        Try
            If Me.InvokeRequired Then
                Me.Invoke(New updateLabelSub(AddressOf updateLabel), New Object() {name, text})
                Return
            End If
            Dim l As New Label
            l = CType(Me.Controls.Find(name, True)(0), Label)
            l.Text = text
        Catch ex As Exception
        End Try
    End Sub

    Private Sub PollHeadOffice()
        System.Windows.Forms.Application.DoEvents()
        Dim LSX As New LSX.LSX
        LSX.Url = GetSetting("labelIt", "settings", "wsx")
        ''''attempting connection to head office
        'if this doesn't work - there is no point continuing.

        updateLabel("lblStatus", "Attempting connection to head office")

        updateLabel("lblProcessStatus", ".........")
        System.Windows.Forms.Application.DoEvents()
        Try
            If LSX.isConnectionActive = 1 Then

                updateLabel("lblStatus", "Connected to head office")
                ' MsgBox("Connected to head office")
                updateLabel("lblProcessStatus", ".........")
                System.Windows.Forms.Application.DoEvents()
                updateLabel("lblStatus", "Downloading reduction sheets.....please wait")
                updateLabel("lblProcessStatus", ".........")
                System.Windows.Forms.Application.DoEvents()
                R.GetReductionheaders()

                updateLabel("lblStatus", "Matching reduction sheet numbers ..please wait")
                updateLabel("lblProcessStatus", ".........")
                System.Windows.Forms.Application.DoEvents()
                R.GetReductionSheets()
                SaveSetting("labelit", "polling", "lastPolled", Now)

            Else
                updateLabel("lblStatus", "Unable to connect to head office")
                ' MsgBox("Unable to connect to head office")
                updateLabel("lblProcessStatus", ".........")
                System.Windows.Forms.Application.DoEvents()

            End If
            Timer1.Stop()
        Catch ex As Exception
            ' MsgBox(ex.Message)
            'T.Abort()
            Timer1.Stop()
            closeForm()
        End Try
        'T.Abort()
        Timer1.Stop()
        closeForm()


    End Sub


    Private Sub R_ProcessReduction(ByVal Status As String) Handles R.ProcessReduction
        updateLabel("lblProcessStatus", Status)
        System.Windows.Forms.Application.DoEvents()

    End Sub

    Private Sub R_Doingsomething() Handles R.Doingsomething
        ActivityTime = New TimeSpan

        ActivityTime = Now.TimeOfDay

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ActivityTime.TotalSeconds > 0 Then
            TimeSinceActivity = _
                  Now.TimeOfDay.Subtract(ActivityTime)

        Else
            TimeSinceActivity = _
                              Now.TimeOfDay.Subtract(startTime)
        End If
        Dim resp As New MsgBoxResult

        If TimeSinceActivity.TotalSeconds > 60 Then
            resp = MsgBox("The program was unable to process any data for the last 60 seconds. There may be a problem connecting to head office. Do you wish to cancel the download?", MsgBoxStyle.YesNo)
            If resp = MsgBoxResult.Yes Then
                'cancel the thread and close this window
                Try
                    'T.Abort()
                    Me.Close()
                Catch ex As Exception

                End Try

            Else
                'reset counters and continue
                startTime = Now.TimeOfDay
                ActivityTime = Now.TimeOfDay

            End If
        End If
        '  MsgBox(TimeSinceActivity.TotalSeconds & " seconds elapsed " & TimeSinceActivity.ToString & " - " & ActivityTime.ToString)
    End Sub

    Private Sub frmDownloadSale_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed

    End Sub

    Private Sub frmDownloadSale_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Try
            'T.Abort()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmDownloadSale_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.GotFocus
        'startTime = New TimeSpan
        'startTime = Now.TimeOfDay
        '()


        T = New Threading.Thread(AddressOf PollHeadOffice)
        T.Start()
        'Timer1.Start()
        'MsgBox("got focus")
    End Sub

    Private Sub frmDownloadSale_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        'MsgBox("activated")
    End Sub

    Private Sub frmDownloadSale_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        'MsgBox("visible changed")
    End Sub
End Class
