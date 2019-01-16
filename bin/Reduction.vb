Public Class Reduction

    Public Function DeleteReductionDetail(ByVal ReductionID As Integer) As Integer
        Try
            Dim CN As New ADODB.Connection
            CN.ConnectionString = "Driver={Microsoft Access Driver (*.mdb)};Dbq=labeldb.mdb;Uid=Admin;Pwd=;"
            CN.Open()
            CN.Execute("Delete from ReductionDetail where reductionID=" & ReductionID)

            CN.Close()
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function GetReductionDetail(ByVal ReductionID As Integer) As Integer
        Try


            Dim L As New LSX.LSX
            L.Url = _WSXurl
            Dim Ds As New DataSet
            Dim SqlStr As String
            Ds = L.GetReductionDetail(ReductionID)
            Dim CN As New ADODB.Connection
            CN.ConnectionString = "Driver={Microsoft Access Driver (*.mdb)};Dbq=labeldb.mdb;Uid=Admin;Pwd=;"
            CN.Open()
            Dim DR As DataRow
            For Each DR In Ds.Tables(0).Rows
                SqlStr = "insert into ReductionDetail (ReductionID, Barcode, OldPrice, NewPrice, altcode) values (" & ReductionID & ", '" & DR("Barcode").ToString & "', " & DR("LastPrice") & ", " & DR("NewPrice") & ", '" & DR("altcode").ToString.Replace("'", "''") & "')"
                CN.Execute(SqlStr)
            Next

            CN.Close()
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function
    Public Event ProcessReduction(ByVal Status As String)
    Public Event Doingsomething()

    Public Function GetReductionheaders() As Integer
        Dim L As New LSX.LSX
        L.Url = _WSXurl
        Dim DS As New DataSet
        Dim Rowcount As Integer = 0
        Dim sqlstr As String
        RaiseEvent ProcessReduction("Downloading from " & _WSXurl)

        DS = L.GetReductions(GetMaxReductionIDInDatabase, _Branch)
        Dim DR As DataRow
        Dim CN As New ADODB.Connection
        CN.ConnectionString = "Driver={Microsoft Access Driver (*.mdb)};Dbq=labeldb.mdb;Uid=Admin;Pwd=;"
        CN.Open()
        For Each DR In DS.Tables(0).Rows
            Rowcount = Rowcount + 1
            'MsgBox(DR("MKDN_Batch_NO").ToString)
            sqlstr = "INSERT INTO ReductionHeader (ID, Reference, LiveDate) values (" & DR("Markdown_id") & ",'" & DR("MKDN_BATCH_NO").ToString.Replace("'", "''") & "','" & CType(DR("MKDN_EFFECTIVE_DATE"), Date).ToString("yyyy-MM-dd") & "')"
            CN.Execute(sqlstr)
            RaiseEvent Doingsomething()

            RaiseEvent ProcessReduction("Processing " & Rowcount & "/" & DS.Tables(0).Rows.Count & "  " & DR("MKDN_BATCH_NO").ToString & " - " & CType(DR("MKDN_EFFECTIVE_DATE"), Date).ToString("dd/MM/yyyy"))
            If GetReductionDetail(DR("Markdown_id")) = 0 Then
                're-try. we timed out!
                GetReductionDetail(DR("Markdown_id"))
            End If
        Next
        CN.Close()
    End Function

    Public Function GetReductionSheets() As Integer
        Try
            Dim L As New LSX.LSX
            L.Url = _WSXurl
            Dim DS As New DataSet
            Dim DR As DataRow
            Dim CN As New ADODB.Connection
            Dim Sqlstr As String
            Dim Rowcount As Integer = 0
            CN.ConnectionString = "Driver={Microsoft Access Driver (*.mdb)};Dbq=labeldb.mdb;Uid=Admin;Pwd=;"
            CN.Open()
            RaiseEvent ProcessReduction("Downloading from " & _WSXurl)
            DS = L.GetReductionSheetNumbers(GetMaxSheetNumberInDatabase)
            For Each DR In DS.Tables(0).Rows
                RaiseEvent ProcessReduction("Processing " & Rowcount & "/" & DS.Tables(0).Rows.Count & "  " & DR("SheetNumber"))
                RaiseEvent Doingsomething()
                Sqlstr = "INSERT INTO ReductionSheets (ID, RMISID, SheetNumber) values (" & DR("id") & ",'" & DR("RmisID").ToString.Replace("'", "''") & "', '" & DR("SheetNumber").ToString.Replace("'", "''") & "')"
                CN.Execute(Sqlstr)
            Next
            CN.Close()

            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function GetMaxReductionIDInDatabase() As Integer
        Dim Sqlstr As String
        Dim Cn As New ADODB.Connection
        Dim ID As Integer
        Cn.ConnectionString = "Driver={Microsoft Access Driver (*.mdb)};Dbq=labeldb.mdb;Uid=Admin;Pwd=;"
        Cn.Open()
        Sqlstr = "select max(ID) as 'id' from ReductionHeader"
        Dim RS As New ADODB.Recordset
        RS = Cn.Execute(Sqlstr)
        ' If RS.RecordCount > 0 Then
        If RS.EOF = False And RS.BOF = False Then
            Try
                ID = RS(0).Value
            Catch ex As Exception
                ID = 0
            End Try

        Else
            ID = 0
        End If
        RS.Close()
        Cn.Close()
        Return ID
    End Function
    Public Function GetAltCodesInReduction(ByVal ReductionSheet As String) As DataTable
        Dim DT As New DataTable
        DT.Columns.Add("altcode")
        Dim Sqlstr As String
        Dim CN As New ADODB.Connection
        Dim RS As New ADODB.Recordset
        CN.ConnectionString = "Driver={Microsoft Access Driver (*.mdb)};Dbq=labeldb.mdb;Uid=Admin;Pwd=;"
        CN.Open()
        Sqlstr = "select distinct rd.altcode as 'altcode' from reductionDetail rd, ReductionHeader rh, ReductionSheets RS " & _
        "WHERE (RH.ID=RD.ReductionID AND RH.REFERENCE='" & ReductionSheet & "') Order By rd.Altcode asc"
        RS = CN.Execute(Sqlstr)
        Dim DR(0) As String
        Do While Not RS.EOF
            DR(0) = RS(0).Value

            DT.Rows.Add(DR)
            RS.MoveNext()
        Loop
        CN.Close()
        Return DT
    End Function

    Public Function GetMaxSheetNumberInDatabase() As Integer
        Dim Sqlstr As String
        Dim CN As New ADODB.Connection
        Dim ID As Integer
        CN.ConnectionString = "Driver={Microsoft Access Driver (*.mdb)};Dbq=labeldb.mdb;Uid=Admin;Pwd=;"
        CN.Open()
        Sqlstr = "select max(ID) as 'id' from ReductionSheets"
        Dim RS As New ADODB.Recordset
        RS = CN.Execute(Sqlstr)
        ' If RS.RecordCount > 0 Then
        If RS.EOF = False And RS.BOF = False Then
            Try
                ID = RS(0).Value
            Catch ex As Exception
                ID = 0
            End Try

        Else
            ID = 0
        End If
        RS.Close()
        CN.Close()
        Return ID

        CN.Close()
    End Function


    Public Function GetStockLevelByBarcode(ByVal Barcode As String) As Integer
        Dim level As Integer = 0
        Dim sqlstr As String
        Try
            If _Connection = "DB" Then
                Dim DB As New DBC(_CN)
                level = DB.getBranchStocklevel(Barcode)
            Else
                Dim WSX As New LSX.LSX
                WSX.Url = _WSXurl
                level = WSX.GetBranchStockFromBarcode(Barcode, _Branch)
            End If
        Catch ex As Exception
            level = 0
        End Try

        Return level

    End Function

    Public Function GetLast20ReductionSheets() As DataTable
        Dim sqlstr As String
        Dim CN As New ADODB.Connection
        Dim ID As Integer

        CN.ConnectionString = "Driver={Microsoft Access Driver (*.mdb)};Dbq=labeldb.mdb;Uid=Admin;Pwd=;"
        CN.Open()

        sqlstr = "select top 20 SheetNumber, RmisID from ReductionSheets ORDER BY id Desc"
        Dim RS As New ADODB.Recordset
        RS = CN.Execute(sqlstr)
        Dim DT As New DataTable
        DT.Columns.Add("SheetNumber")
        DT.Columns.Add("RmisID")
        Dim DR(1) As String
        Do While Not RS.EOF
            DR(0) = RS("SheetNumber").Value
            DR(1) = RS("RmisID").Value
            DT.Rows.Add(DR)
            RS.MoveNext()
        Loop
        RS.Close()
        CN.Close()

        Return DT
    End Function
    Public Event StatusChanged(ByVal StatusText As String)
    Public Event DownloadComplete()

    Public Function GetReductionFromHO(ByVal RmisID As String, Optional ByVal AltCode As String = "") As DataSet
        Dim DT As New DataTable

        _SaleStatus = "Starting to process sale"
        RaiseEvent StatusChanged(_SaleStatus)
        DT.Columns.Add("barcode")
        DT.Columns.Add("product")
        DT.Columns.Add("colour")
        DT.Columns.Add("size")
        DT.Columns.Add("price")
        DT.Columns.Add("rrp")
        DT.Columns.Add("was")
        DT.Columns.Add("qty")
        Dim DR(7)

        Dim WSX As New LSX.LSX
        WSX.Url = _WSXurl

        Dim RmisIDInt As Integer
        RmisIDInt = WSX.GetRmisReductionIDFromReductionName(RmisID)

        Dim DS As New DataSet
        If AltCode = "" Then
            DS = WSX.GetReductionWithStockByBranch(RmisIDInt, _Branch)
        Else
            DS = WSX.GetReductionWithStockByBranchWithAltCode(RmisIDInt, _Branch, AltCode)
        End If

        For Each DTR As DataRow In DS.Tables(0).Rows
            DR(0) = DTR("barcode")
            DR(1) = DTR("style")
            DR(2) = DTR("colour")
            DR(3) = DTR("size")
            DR(4) = DTR("now")
            DR(5) = DTR("rrp")

            If CType(DTR("was"), Double) > CType(DTR("currentsp"), Double) Then
                If CType(DTR("currentsp"), Double) > CType(DTR("now"), Double) Then
                    DR(6) = DTR("currentsp")
                Else
                    DR(6) = DTR("was")
                End If
            Else
                    DR(6) = DTR("was")
                End If
                ' DR(6) = DTR("was")
                DR(7) = DTR("qty")
                DT.Rows.Add(DR)
        Next
        _SaleStatus = "Process complete"
        Dim DSr As New DataSet
        DSr.Tables.Add(DT)
        RaiseEvent DownloadComplete()
        Return DSr
    End Function
    Public Function GetReduction(ByVal RmisID As String, Optional ByVal AltCode As String = "") As DataSet
        Dim DT As New DataTable

        _SaleStatus = "Starting to process sale"
        RaiseEvent StatusChanged(_SaleStatus)
        DT.Columns.Add("barcode")
        DT.Columns.Add("product")
        DT.Columns.Add("colour")
        DT.Columns.Add("size")
        DT.Columns.Add("price")
        DT.Columns.Add("rrp")
        DT.Columns.Add("was")
        DT.Columns.Add("qty")
        Dim DR(7)
        Dim sqlstr As String
        Dim CN As New ADODB.Connection
        Dim ID As Integer
        CN.ConnectionString = "Driver={Microsoft Access Driver (*.mdb)};Dbq=labeldb.mdb;Uid=Admin;Pwd=;"
        CN.Open()

        sqlstr = "SELECT ReductionDetail.Barcode, ReductionDetail.OldPrice, ReductionDetail.NewPrice " & _
        "FROM ReductionDetail INNER JOIN ReductionHeader ON ReductionDetail.ReductionID = ReductionHeader.ID " & _
        "WHERE (((ReductionHeader.Reference)='" & RmisID & "'))"

        If AltCode <> "" Then
            sqlstr &= " AND (ReductionDetail.AltCode='" & AltCode.Replace("'", "''") & "') "
        End If
        Dim RS As New ADODB.Recordset
        Dim RowCount As Integer = 0
        Dim CurrentRow As Integer = 0
        Dim StatusRow As Integer = 0
        Dim StartTime As TimeSpan = Now.TimeOfDay
        ' Dim CurrentTime As TimeSpan
        Dim ElapsedTime As TimeSpan
        Dim RemainingTime As TimeSpan
        Dim RemainingTimeI As Integer
        RS = CN.Execute(sqlstr)
        _SaleStatus = "Counting rows"
        RaiseEvent StatusChanged(_SaleStatus)
        Do While Not RS.EOF
            RowCount = RowCount + 1
            RS.MoveNext()
        Loop
        Dim Msg As MsgBoxResult

        If RowCount = 0 Then
            Msg = MsgBox("This reduction is not on your local database. Do you wish to download it now from head office?", MsgBoxStyle.YesNo, "Download Reduction")
            If Msg = MsgBoxResult.Yes Then
                GetReductionDetail(getIDfromReductionHeader(RmisID))

                Return GetReduction(RmisID, AltCode)
                Exit Function

            Else
                Dim DS1 As New DataSet
                DS1.Tables.Add(DT)
                Return DS1
                Exit Function
            End If
        End If

        RS.MoveFirst()
        Do While Not RS.EOF
            CurrentRow = CurrentRow + 1
            StatusRow = StatusRow + 1

            Dim Product As New LSX.Product
            If _Connection = "DB" Then
                Dim DB As New DBC(_CN)
                Product = DB.CheckBarcode(RS(0).Value)
            Else
                Dim WSX As New LSX.LSX
                WSX.Url = _WSXurl

                Product = WSX.CheckBarcode(RS(0).Value, _Branch)
            End If
            If StatusRow = 5 Then
                ElapsedTime = _
         Now.TimeOfDay.Subtract(StartTime)
                RemainingTimeI = (ElapsedTime.TotalSeconds / CurrentRow) * (RowCount - CurrentRow)

                'RemainingTime = RemainingTimeI
                RemainingTime = New TimeSpan(0, 0, RemainingTimeI)

                _SaleStatus = "Processing " & Product.Name & "(" & RS(0).Value & ") " & CurrentRow & "/" & RowCount & ") Time Remaining: " & RemainingTime.Minutes & ":" & RemainingTime.Seconds

                RaiseEvent StatusChanged(_SaleStatus)
                StatusRow = 0


            End If
            If Product.ResponseCode = 0 Then
                DR(0) = RS(0).Value
                DR(1) = Product.Name
                DR(2) = Product.Colour
                DR(3) = Product.Size
                DR(4) = RS(2).Value
                DR(5) = Product.RRP
                DR(6) = RS(1).Value
                DR(7) = GetStockLevelByBarcode(RS(0).Value)
            End If
            If DR(7) > 0 Then
                DT.Rows.Add(DR)
            End If
            RS.MoveNext()
        Loop
        _SaleStatus = "Process complete"
        RaiseEvent StatusChanged(_SaleStatus)
        Dim DS As New DataSet
        DS.Tables.Add(DT)


        CN.Close()
        RaiseEvent DownloadComplete()

        Return DS

    End Function

    Public Function getIDfromReductionHeader(ByVal ReductionHeader As String) As Integer
        Dim CN As New ADODB.Connection
        Dim ID As Integer
        CN.ConnectionString = "Driver={Microsoft Access Driver (*.mdb)};Dbq=labeldb.mdb;Uid=Admin;Pwd=;"
        CN.Open()
        Dim Sqlstr As String
        Sqlstr = "select ID from reductionHeader where reference='" & ReductionHeader & "'"
        Dim RS As New ADODB.Recordset
        RS = CN.Execute(Sqlstr)
        If RS.EOF = False And RS.BOF = False Then
            ID = RS("id").Value
        Else
            ID = 0
        End If
        CN.Close()
        Return ID
    End Function
End Class
