Module Module1
    Public _WSXurl As String
    Public BarcodeString As String
    Public _printer As String
    Public _DataTable As DataTable
    Public _Branch As String
    Public _CN As String
    Public _Connection As String
    Public _JobEnd As Boolean
    Public _SaleStatus As String


    Sub Main()
        If GetSetting("labelIt", "settings", "wsx") = "" Then
            Dim F As New frmSetup
            F.ShowDialog()
            Exit Sub
        End If

        _WSXurl = GetSetting("labelIt", "settings", "wsx")
        _printer = GetSetting("labelIt", "settings", "printer")
        _Branch = GetSetting("labelIt", "settings", "branch")
        If GetSetting("labelIt", "settings", "jobend", "") <> "1" Then
            _JobEnd = False
        Else
            _JobEnd = True
        End If
        _Connection = GetSetting("labelit", "settings", "Connection")
        If GetSetting("labelIt", "settings", "dynamicprinter", 0) = 1 Then
            Dim h As System.Net.IPHostEntry = System.Net.Dns.GetHostByName(System.Net.Dns.GetHostName)

            _printer = "\\" & h.AddressList.GetValue(0).ToString & "\sato"

            SaveSetting("labelIt", "settings", "printer", _printer)
        End If
        Dim frmMain As New frmMain

        Dim LastPollDate As Date

        Try
            LastPollDate = CType(GetSetting("labelit", "polling", "lastPolled", ""), Date)
        Catch ex As Exception
            LastPollDate = Now.AddDays(-1)
        End Try

        Dim TodayDate As Date
        TodayDate = Now
        If LastPollDate.ToShortDateString = TodayDate.ToShortDateString Then
            'just load the main program
            frmMain.ShowDialog()
        Else
            'poll first, then load
            Dim FD As New frmDownloadSale
            FD.ShowDialog()
            FD.Dispose()

            frmMain.ShowDialog()
        End If
    End Sub


End Module




