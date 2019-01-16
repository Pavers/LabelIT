Imports Microsoft.SqlHelper

Public Class DBC
    Private _CN As String
    Sub New(ByVal ConnectionString As String)
        _CN = ConnectionString
    End Sub

    Sub New()

    End Sub

    Public Function CheckBarcode(ByVal Barcode As String) As LSX.Product
        Dim sqlstr As String

        Dim p As New LSX.Product
        Try
            Dim DS As DataSet
            sqlstr = "SELECT product_master.ALT_CODE1 AS 'Product', product_master.DESCRIPTION AS 'Description', product_detail.current_RRP as 'rrp', product_detail.current_sp AS 'Price', product_detail.original_sp as 'was', colour.COLOUR_DESC AS 'Colour', sizes.SIZES_DESC AS 'Size' " & _
                    "FROM epos.dbo.colour colour, epos.dbo.product_detail product_detail, epos.dbo.product_master product_master, epos.dbo.sizes sizes " & _
                    "WHERE product_detail.COLOUR_ID = colour.COLOUR_ID AND product_detail.SIZES_ID = sizes.SIZES_ID AND product_master.PROD_ID = product_detail.PRODUCT_ID AND ((product_detail.POS_CODE='" & Barcode & "')) "

            DS = SqlHelper.ExecuteDataset(_CN, CommandType.Text, sqlstr)
            If DS.Tables(0).Rows.Count = 0 Then
                Throw New Exception("Barcode not found")
            End If

            p.Name = DS.Tables(0).Rows(0).Item("Product")
            p.Colour = DS.Tables(0).Rows(0).Item("Colour")
            p.Size = DS.Tables(0).Rows(0).Item("Size")
            p.Price = DS.Tables(0).Rows(0).Item("Price")
            p.Description = DS.Tables(0).Rows(0).Item("description")
            p.RRP = DS.Tables(0).Rows(0).Item("rrp")
            p.Was = DS.Tables(0).Rows(0).Item("was")
            p.ResponseCode = 0
            If p.Price > p.Was Then p.Was = p.Price


            Return p
        Catch ex As Exception
            p.ResponseCode = -1
            p.ResponseMessage = ex.Message

            Return p
        End Try
    End Function


    Public Function GetBarcodesByProductName(ByVal ProductName As String) As DataSet
        Dim Sqlstr As String
        Sqlstr = "SELECT product_detail.POS_CODE AS 'Barcode', colour.COLOUR_DESC AS 'Colour', sizes.SIZES_DESC AS 'Size' " & _
                "FROM epos.dbo.colour colour, epos.dbo.product_detail product_detail, epos.dbo.product_master product_master, epos.dbo.sizes sizes " & _
                "WHERE product_detail.PRODUCT_ID = product_master.PROD_ID AND colour.COLOUR_ID = product_detail.COLOUR_ID AND sizes.SIZES_ID = product_detail.SIZES_ID AND ((product_master.ALT_CODE1='" & ProductName & "')) order By POS_Code DESC"

        Return SqlHelper.ExecuteDataset(_CN, CommandType.Text, Sqlstr)
    End Function

    Public Function SearchProductWildcards(ByVal ProductName As String) As DataSet
        Dim Sqlstr As String
        Sqlstr = "select alt_code1, description from epos.dbo.product_master where alt_code1 like '" & ProductName & "%'"
        Return SqlHelper.ExecuteDataset(_CN, CommandType.Text, Sqlstr)

    End Function

    Public Function GetLabelFormats() As DataSet
        Dim DS As New DataSet
        Dim DT As New DataTable
        DT.Columns.Add("id")
        DT.Columns.Add("name")
        Dim DR(1) As String
        Dim CN As New ADODB.Connection
        Dim RS As New ADODB.Recordset

        CN.ConnectionString = "Driver={Microsoft Access Driver (*.mdb)};Dbq=labeldb.mdb;Uid=Admin;Pwd=;"
        CN.Open()
        Dim Sqlstr As String
        Sqlstr = "select labelID, LabelName from format Order BY labelName"
        RS = CN.Execute(Sqlstr)
        Do While Not RS.EOF
            DR(0) = RS("labelID").Value
            DR(1) = RS("labelName").Value
            DT.Rows.Add(DR)

            RS.MoveNext()
        Loop
        RS.Close()
        CN.Close()
        DS.Tables.Add(DT)
        Return DS
    End Function

    Public Function GetLabelFormatImage(ByVal FormatID As Integer) As LSX.ImageData
        Dim I As New LSX.ImageData

        Dim Sqlstr As String
        Sqlstr = "select LabelImage from Format where LabelID=" & FormatID
        Dim CN As New ADODB.Connection
        Dim RS As New ADODB.Recordset

        CN.ConnectionString = "Driver={Microsoft Access Driver (*.mdb)};Dbq=labeldb.mdb;Uid=Admin;Pwd=;"
        CN.Open()
        RS = CN.Execute(Sqlstr)
        If RS.EOF = False Then
            I.Data = CType(RS("LabelImage").Value, Byte())
            I.Result = 0
        Else
            I.Data = Nothing
            I.Result = -1
        End If
        CN.Close()
        Return I
    End Function
    Public Function GetLastRetailPrice(ByVal Barcode As String) As Decimal
        Dim Price As Decimal
        Dim sqlstr As String
        sqlstr = "select top 1 OldPrice from reductionDetail rd, ReductionHeader rh WHERE rd.barcode='" & Barcode & "' AND rd.reductionID=RH.iD and RH.LiveDate< #" & Now.ToString("dd/MM/yyyy") & "# ORDER BY RH.id DESC"
        Dim CN As New ADODB.Connection
        Dim RS As New ADODB.Recordset

        CN.ConnectionString = "Driver={Microsoft Access Driver (*.mdb)};Dbq=labeldb.mdb;Uid=Admin;Pwd=;"
        CN.Open()
        RS = CN.Execute(sqlstr)
        If RS.EOF = True And RS.BOF = True Then
            Price = 0
        Else
            Price = RS(0).Value
        End If

        RS.Close()
        CN.Close()
        Return Price
    End Function
    Public Function GetLabelFormat(ByVal FormatID As Integer) As String
        Dim Sqlstr As String
        Dim CN As New ADODB.Connection
        Dim RS As New ADODB.Recordset

        CN.ConnectionString = "Driver={Microsoft Access Driver (*.mdb)};Dbq=labeldb.mdb;Uid=Admin;Pwd=;"
        CN.Open()


        Sqlstr = "select LabelFormat from format where labelid=" & FormatID
        RS = CN.Execute(Sqlstr)
        Return RS("labelformat").Value
    End Function


    Public Function getBranchStocklevel(ByVal Barcode As String) As Integer
        Dim sqlstr As String
        sqlstr = "SELECT     PRODUCT_HISTORY.STOCK_UNITS_FREE " & _
        "FROM         EPOS.dbo.PRODUCT_HISTORY PRODUCT_HISTORY INNER JOIN " & _
              "EPOS.dbo.product_detail product_detail ON PRODUCT_HISTORY.SKU_ID = product_detail.SKU_ID INNER JOIN " & _
              "EPOS.dbo.branch branch ON PRODUCT_HISTORY.BRANCH_ID = branch.BRANCH_ID " & _
        "WHERE     (PRODUCT_HISTORY.WEEK_SELECTOR = 0) AND (branch.BRANCH_CODE = '" & _Branch & "') AND (product_detail.POS_CODE = '" & Barcode & "') "

        Return SqlHelper.ExecuteScalar(_CN, CommandType.Text, sqlstr)
    End Function
End Class
