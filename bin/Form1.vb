Imports System.io
Public Class Form1
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
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents btnBatch As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents lblBarcode As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents lblRRP As System.Windows.Forms.Label
    Friend WithEvents lblSize As System.Windows.Forms.Label
    Friend WithEvents lblColour As System.Windows.Forms.Label
    Friend WithEvents lblDesc As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblWas As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dtDelivery As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents cbSale As System.Windows.Forms.CheckBox
    Friend WithEvents nmQTY As System.Windows.Forms.NumericUpDown
    Friend WithEvents cbqty As System.Windows.Forms.CheckBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents btnPrint1 As System.Windows.Forms.Button
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cmbSaleSheets As System.Windows.Forms.ComboBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents cmbAltCode As System.Windows.Forms.ComboBox
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents AutoAdd As System.Windows.Forms.CheckBox
    Friend WithEvents lblAutoAdd As System.Windows.Forms.Label
    Friend WithEvents lblSaleStatus As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DataGrid1 = New System.Windows.Forms.DataGrid()
        Me.btnPrint1 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btnBatch = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lblAutoAdd = New System.Windows.Forms.Label()
        Me.AutoAdd = New System.Windows.Forms.CheckBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblBarcode = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.lblWas = New System.Windows.Forms.Label()
        Me.lblRRP = New System.Windows.Forms.Label()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.lblColour = New System.Windows.Forms.Label()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtDelivery = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.lblSaleStatus = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.cmbAltCode = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.cmbSaleSheets = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbSale = New System.Windows.Forms.CheckBox()
        Me.nmQTY = New System.Windows.Forms.NumericUpDown()
        Me.cbqty = New System.Windows.Forms.CheckBox()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.btnBatch.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.nmQTY, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGrid1
        '
        Me.DataGrid1.AlternatingBackColor = System.Drawing.Color.LightGray
        Me.DataGrid1.BackColor = System.Drawing.Color.Gainsboro
        Me.DataGrid1.BackgroundColor = System.Drawing.Color.Silver
        Me.DataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGrid1.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.DataGrid1.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.FlatMode = True
        Me.DataGrid1.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.DataGrid1.ForeColor = System.Drawing.Color.Black
        Me.DataGrid1.GridLineColor = System.Drawing.Color.DimGray
        Me.DataGrid1.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.DataGrid1.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.DataGrid1.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.DataGrid1.HeaderForeColor = System.Drawing.Color.White
        Me.DataGrid1.LinkColor = System.Drawing.Color.MidnightBlue
        Me.DataGrid1.Location = New System.Drawing.Point(12, 234)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ParentRowsBackColor = System.Drawing.Color.DarkGray
        Me.DataGrid1.ParentRowsForeColor = System.Drawing.Color.Black
        Me.DataGrid1.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.DataGrid1.SelectionForeColor = System.Drawing.Color.White
        Me.DataGrid1.Size = New System.Drawing.Size(752, 264)
        Me.DataGrid1.TabIndex = 22
        '
        'btnPrint1
        '
        Me.btnPrint1.BackColor = System.Drawing.Color.Lime
        Me.btnPrint1.Location = New System.Drawing.Point(12, 506)
        Me.btnPrint1.Name = "btnPrint1"
        Me.btnPrint1.Size = New System.Drawing.Size(104, 24)
        Me.btnPrint1.TabIndex = 23
        Me.btnPrint1.Text = "Printer 1"
        Me.btnPrint1.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Red
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(660, 506)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(104, 24)
        Me.Button5.TabIndex = 24
        Me.Button5.Text = "Clear"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'btnBatch
        '
        Me.btnBatch.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.btnBatch.Controls.Add(Me.TabPage1)
        Me.btnBatch.Location = New System.Drawing.Point(8, 8)
        Me.btnBatch.Multiline = True
        Me.btnBatch.Name = "btnBatch"
        Me.btnBatch.SelectedIndex = 0
        Me.btnBatch.Size = New System.Drawing.Size(432, 220)
        Me.btnBatch.TabIndex = 26
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lblAutoAdd)
        Me.TabPage1.Controls.Add(Me.AutoAdd)
        Me.TabPage1.Controls.Add(Me.lblPrice)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.lblBarcode)
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Controls.Add(Me.lblWas)
        Me.TabPage1.Controls.Add(Me.lblRRP)
        Me.TabPage1.Controls.Add(Me.lblSize)
        Me.TabPage1.Controls.Add(Me.lblColour)
        Me.TabPage1.Controls.Add(Me.lblDesc)
        Me.TabPage1.Controls.Add(Me.lblName)
        Me.TabPage1.Controls.Add(Me.TextBox2)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(23, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(405, 212)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Individual"
        '
        'lblAutoAdd
        '
        Me.lblAutoAdd.AutoSize = True
        Me.lblAutoAdd.Location = New System.Drawing.Point(307, 8)
        Me.lblAutoAdd.Name = "lblAutoAdd"
        Me.lblAutoAdd.Size = New System.Drawing.Size(51, 13)
        Me.lblAutoAdd.TabIndex = 48
        Me.lblAutoAdd.Text = "Auto Add"
        '
        'AutoAdd
        '
        Me.AutoAdd.AutoSize = True
        Me.AutoAdd.Location = New System.Drawing.Point(324, 24)
        Me.AutoAdd.Name = "AutoAdd"
        Me.AutoAdd.Size = New System.Drawing.Size(15, 14)
        Me.AutoAdd.TabIndex = 47
        Me.AutoAdd.UseVisualStyleBackColor = True
        '
        'lblPrice
        '
        Me.lblPrice.Location = New System.Drawing.Point(344, 120)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(64, 16)
        Me.lblPrice.TabIndex = 46
        Me.lblPrice.Text = "Label15"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(288, 120)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 16)
        Me.Label12.TabIndex = 45
        Me.Label12.Text = "Retail"
        '
        'lblBarcode
        '
        Me.lblBarcode.Location = New System.Drawing.Point(280, 32)
        Me.lblBarcode.Name = "lblBarcode"
        Me.lblBarcode.Size = New System.Drawing.Size(8, 16)
        Me.lblBarcode.TabIndex = 44
        Me.lblBarcode.Visible = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LightSlateGray
        Me.Button3.ForeColor = System.Drawing.Color.AliceBlue
        Me.Button3.Location = New System.Drawing.Point(176, 144)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(64, 24)
        Me.Button3.TabIndex = 43
        Me.Button3.Text = "Add"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'lblWas
        '
        Me.lblWas.Location = New System.Drawing.Point(216, 120)
        Me.lblWas.Name = "lblWas"
        Me.lblWas.Size = New System.Drawing.Size(48, 16)
        Me.lblWas.TabIndex = 42
        Me.lblWas.Text = "Label15"
        '
        'lblRRP
        '
        Me.lblRRP.Location = New System.Drawing.Point(64, 120)
        Me.lblRRP.Name = "lblRRP"
        Me.lblRRP.Size = New System.Drawing.Size(48, 16)
        Me.lblRRP.TabIndex = 41
        Me.lblRRP.Text = "Label14"
        '
        'lblSize
        '
        Me.lblSize.Location = New System.Drawing.Point(216, 96)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(96, 16)
        Me.lblSize.TabIndex = 40
        Me.lblSize.Text = "Label13"
        '
        'lblColour
        '
        Me.lblColour.Location = New System.Drawing.Point(64, 96)
        Me.lblColour.Name = "lblColour"
        Me.lblColour.Size = New System.Drawing.Size(88, 16)
        Me.lblColour.TabIndex = 39
        Me.lblColour.Text = "Label12"
        '
        'lblDesc
        '
        Me.lblDesc.Location = New System.Drawing.Point(64, 72)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(232, 16)
        Me.lblDesc.TabIndex = 38
        Me.lblDesc.Text = "Label11"
        '
        'lblName
        '
        Me.lblName.Location = New System.Drawing.Point(64, 48)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(168, 16)
        Me.lblName.TabIndex = 37
        Me.lblName.Text = "Label10"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(96, 144)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(72, 20)
        Me.TextBox2.TabIndex = 36
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 144)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 16)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "QTY"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(152, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 16)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Was"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 16)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "RRP"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(152, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 16)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Size"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 16)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Colour"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Desc"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Product"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button2.ForeColor = System.Drawing.Color.Navy
        Me.Button2.Location = New System.Drawing.Point(184, 24)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 24)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "Search"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(8, 24)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(168, 20)
        Me.TextBox1.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Barcode"
        '

        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Button7.Location = New System.Drawing.Point(248, 96)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(152, 32)
        Me.Button7.TabIndex = 11
        Me.Button7.Text = "Add labels (new stock)"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(296, 24)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(104, 24)
        Me.Button6.TabIndex = 10
        Me.Button6.Text = "Connecting"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(296, 8)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(100, 16)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "Connection Status"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(8, 32)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(288, 16)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "This function requires a direct connection to head office."
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 24)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Entire Delivery"
        '
        'dtDelivery
        '
        Me.dtDelivery.Location = New System.Drawing.Point(8, 144)
        Me.dtDelivery.Name = "dtDelivery"
        Me.dtDelivery.Size = New System.Drawing.Size(216, 20)
        Me.dtDelivery.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Lavender
        Me.Button1.Location = New System.Drawing.Point(248, 136)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(152, 32)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Add Labels (replenishment)"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 128)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(168, 16)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Despatched Date"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 88)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(192, 24)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "To print off an entire delivery, please enter the date DESPATCHED from head offic" &
    "e."
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.lblSaleStatus)
        Me.TabPage3.Controls.Add(Me.Label18)
        Me.TabPage3.Controls.Add(Me.Label17)
        Me.TabPage3.Controls.Add(Me.Button8)
        Me.TabPage3.Controls.Add(Me.cmbAltCode)
        Me.TabPage3.Controls.Add(Me.Button4)
        Me.TabPage3.Controls.Add(Me.cmbSaleSheets)
        Me.TabPage3.Controls.Add(Me.Label16)
        Me.TabPage3.Controls.Add(Me.Label14)
        Me.TabPage3.Location = New System.Drawing.Point(23, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(405, 212)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Sale"
        '
        'lblSaleStatus
        '
        Me.lblSaleStatus.Location = New System.Drawing.Point(8, 152)
        Me.lblSaleStatus.Name = "lblSaleStatus"
        Me.lblSaleStatus.Size = New System.Drawing.Size(384, 16)
        Me.lblSaleStatus.TabIndex = 8
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(8, 120)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(32, 16)
        Me.Label18.TabIndex = 7
        Me.Label18.Text = "Style"
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(8, 80)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(40, 16)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "Sheet#"
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Red
        Me.Button8.ForeColor = System.Drawing.Color.White
        Me.Button8.Location = New System.Drawing.Point(224, 120)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(168, 24)
        Me.Button8.TabIndex = 5
        Me.Button8.Text = "Download This style"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'cmbAltCode
        '
        Me.cmbAltCode.DisplayMember = "altcode"
        Me.cmbAltCode.Location = New System.Drawing.Point(64, 120)
        Me.cmbAltCode.Name = "cmbAltCode"
        Me.cmbAltCode.Size = New System.Drawing.Size(152, 21)
        Me.cmbAltCode.TabIndex = 4
        Me.cmbAltCode.ValueMember = "altcode"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Crimson
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(224, 80)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(168, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Download Entire Sale Sheet"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'cmbSaleSheets
        '
        Me.cmbSaleSheets.DisplayMember = "SheetNumber"
        Me.cmbSaleSheets.Location = New System.Drawing.Point(64, 80)
        Me.cmbSaleSheets.Name = "cmbSaleSheets"
        Me.cmbSaleSheets.Size = New System.Drawing.Size(152, 21)
        Me.cmbSaleSheets.TabIndex = 2
        Me.cmbSaleSheets.ValueMember = "RmisID"
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(8, 48)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(360, 23)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Please select / enter the sale sheet number to print off all reductions"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(8, 8)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(120, 23)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Sale Sheets"
        '
        'cbSale
        '
        Me.cbSale.Location = New System.Drawing.Point(284, 506)
        Me.cbSale.Name = "cbSale"
        Me.cbSale.Size = New System.Drawing.Size(96, 24)
        Me.cbSale.TabIndex = 27
        Me.cbSale.Text = "Sale Tickets"
        '
        'nmQTY
        '
        Me.nmQTY.Enabled = False
        Me.nmQTY.Location = New System.Drawing.Point(476, 506)
        Me.nmQTY.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nmQTY.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nmQTY.Name = "nmQTY"
        Me.nmQTY.Size = New System.Drawing.Size(32, 20)
        Me.nmQTY.TabIndex = 28
        Me.nmQTY.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'cbqty
        '
        Me.cbqty.Location = New System.Drawing.Point(380, 506)
        Me.cbqty.Name = "cbqty"
        Me.cbqty.Size = New System.Drawing.Size(96, 24)
        Me.cbqty.TabIndex = 29
        Me.cbqty.Text = "Multiply qty by"
        '
        'Form1
        '
        Me.AcceptButton = Me.Button2
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(549, 535)
        Me.Controls.Add(Me.cbqty)
        Me.Controls.Add(Me.nmQTY)
        Me.Controls.Add(Me.cbSale)
        Me.Controls.Add(Me.btnBatch)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.btnPrint1)
        Me.Controls.Add(Me.DataGrid1)
        Me.Name = "Form1"
        Me.Text = "Label it"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.btnBatch.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.nmQTY, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private DT As New DataTable
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BarcodeString = ""
        Dim F As New frmLookupProduct
        F.ShowDialog()
        TextBox1.Text = BarcodeString
        Button2_Click(sender, e)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            If TextBox1.Text.Trim = "" Then Exit Sub
            Dim SearchString As String
            SearchString = TextBox1.Text

            If SearchString.Substring(0, 1) = "X" Then
                Dim prefix As String = SearchString.Substring(1, 3)
                Dim postfix As String = SearchString.Substring(4, 1)
                Dim b As New Button
                Select Case prefix
                    Case "000"
                        cbqty.Checked = True
                        nmQTY.Enabled = True
                        nmQTY.Value = Integer.Parse(postfix)
                    Case "100"
                        b.Name = "btnPrint1"
                        Button4_Click(b, e)
                    Case "200"
                        b.Name = "btnPrint2"
                        Button4_Click(b, e)
                    Case "300"
                        Button5_Click(sender, e)
                    Case "400"
                        cbSale.Checked = True
                        b.Name = "btnPrint2"
                        Button4_Click(b, e)
                        cbSale.Checked = False
                End Select

                TextBox1.Text = ""
                TextBox1.Focus()


            Else
                If AutoAdd.Checked Then

                    SearchProductByBarcode(SearchString)
                    If lblName.Text.Trim <> "" Then
                        Button3_Click(sender, e)
                    End If

                Else

                    If IsNumeric(Mid(SearchString, 1, 1)) Then
                        'we have a barcode
                        SearchProductByBarcode(SearchString)
                    Else
                        'they have entered a product code.
                        'check for wildcards
                        If Me.HasWildcard(SearchString) = True Then

                            'found wildcard
                            searchProductBywildcard(SearchString)
                        Else
                            'no wildcard - this is the name of a product
                            SearchProductByName(SearchString)
                        End If
                    End If
                End If


            End If

            Exit Sub
        Catch ex As Exception
            MsgBox("An error has occured. " & vbCrLf & vbCrLf & "Please ensure that the connection icon at the bottom of the screen is green (Connected)." & vbCrLf & vbCrLf & " The reported message is " & ex.Message, MsgBoxStyle.Critical, "An error has occured")
        End Try

    End Sub
    Private Sub searchProductBywildcard(ByVal SearchName As String)
        Try
            SearchName = Replace(SearchName, "*", "")
            Dim DT As New DataTable



            If _Connection = "DB" Then
                Dim DB As New DBC(_CN)
                DT = DB.SearchProductWildcards(SearchName).Tables(0)
            Else
                Dim WSX As New LSX.LSX
                WSX.Url = _WSXurl
                DT = WSX.SearchProductWildcards(SearchName).Tables(0)

            End If

            If DT.Rows.Count = 0 Then
                MsgBox(SearchName & " not found", MsgBoxStyle.Critical)
            Else
                BarcodeString = ""
                _DataTable = DT

                Dim F As New frmLookupProduct
                F.ShowDialog()
                If BarcodeString <> "" Then
                    SearchProductByName(BarcodeString)
                End If
            End If
        Catch ex As Exception
            MsgBox("An error has occured. " & vbCrLf & vbCrLf & "Please ensure that the connection icon at the bottom of the screen is green (Connected)." & vbCrLf & vbCrLf & " The reported message is " & ex.Message, MsgBoxStyle.Critical, "An error has occured")
        End Try
    End Sub
    Private Sub SearchProductByName(ByVal Name As String)
        Try
            BarcodeString = ""
            If Trim(Name) = "" Then Exit Sub
            Dim DT As New DataTable

            If _Connection = "DB" Then
                Dim DB As New DBC(_CN)
                DT = DB.GetBarcodesByProductName(Name).Tables(0)
            Else
                Dim WSX As New LSX.LSX
                WSX.Url = _WSXurl

                ' Product = WSX.CheckBarcode(Barcode)
                DT = WSX.GetBarcodesByProductName(Name).Tables(0)
            End If



            If DT.Rows.Count = 0 Then
                MsgBox(Name & " not found", MsgBoxStyle.Information)
            Else
                BarcodeString = ""
                _DataTable = DT

                Dim F As New frmLookupProduct
                F.ShowDialog()
                If BarcodeString <> "" Then
                    SearchProductByBarcode(BarcodeString)
                End If
            End If
        Catch ex As Exception
            MsgBox("An error has occured. " & vbCrLf & vbCrLf & "Please ensure that the connection icon at the bottom of the screen is green (Connected)." & vbCrLf & vbCrLf & " The reported message is " & ex.Message, MsgBoxStyle.Critical, "An error has occured")
        End Try
    End Sub
    Private Sub SearchProductByBarcode(ByVal Barcode As String)
        Try
            Dim Product As New LSX.Product
            If _Connection = "DB" Then
                Dim DB As New DBC(_CN)
                Product = DB.CheckBarcode(Barcode)
            Else
                Dim WSX As New LSX.LSX
                WSX.Url = _WSXurl

                Product = WSX.CheckBarcode(Barcode, _Branch)
            End If

            If Product.ResponseCode = 0 Then

                lblBarcode.Text = Barcode
                lblName.Text = Product.Name
                lblDesc.Text = Product.Description
                lblColour.Text = Product.Colour
                lblSize.Text = Product.Size
                lblPrice.Text = CurrencyPrice(Product.Price)
                lblWas.Text = CurrencyPrice(Product.Was)
                lblRRP.Text = CurrencyPrice(Product.RRP)
                Me.AcceptButton = Button3
                TextBox2.Text = ""
                TextBox2.Focus()
            Else
                lblBarcode.Text = ""
                lblName.Text = ""
                lblDesc.Text = ""
                lblColour.Text = ""
                lblSize.Text = ""
                lblPrice.Text = ""
                lblRRP.Text = ""
                lblWas.Text = ""
                TextBox1.Text = ""
                Me.AcceptButton = Button2
                TextBox1.Focus()
                If Not AutoAdd.Checked Then
                    MsgBox(Product.ResponseMessage)
                End If
            End If
        Catch ex As Exception
            MsgBox("An error has occured. " & vbCrLf & vbCrLf & "Please ensure that the connection icon at the bottom of the screen is green (Connected)." & vbCrLf & vbCrLf & " The reported message is " & ex.Message, MsgBoxStyle.Critical, "An error has occured")
        End Try
    End Sub
    Private Function HasWildcard(ByVal CheckString As String) As Boolean
        Dim sLen As Integer
        sLen = CheckString.Length
        Dim N As Integer
        For N = 1 To sLen
            If Mid(CheckString, N, 1) = "*" Then
                'we have a wildcard - exit function return true
                Return True
                Exit Function
            End If
        Next

        Return False
    End Function
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Blanklabel()

            ClearDT()

            btnPrint1.Text = "Print"
            lblBarcode.Text = ""
            lblName.Text = ""
            lblDesc.Text = ""
            lblColour.Text = ""
            lblSize.Text = ""
            lblPrice.Text = ""
            lblRRP.Text = ""
            lblWas.Text = ""
            TextBox1.Text = ""

        Catch ex As Exception
            MsgBox("An error has occured. " & vbCrLf & vbCrLf & "Please ensure that the connection icon at the bottom of the screen is green (Connected)." & vbCrLf & vbCrLf & " The reported message is " & ex.Message, MsgBoxStyle.Critical, "An error has occured")
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try

            If TextBox2.Text = "" Then
                TextBox2.Text = "1"
            End If
            Dim qty As Integer
            qty = TextBox2.Text

            If qty > 10 Then
                Dim Resp As MsgBoxResult
                Resp = MsgBox("Are you sure you wish to print that amount of labels?", MsgBoxStyle.YesNo, "Have you scanned the barcode again???")
                If Resp = MsgBoxResult.No Then Exit Sub
            End If
            Dim dr(7) As String
            dr(0) = lblBarcode.Text
            dr(1) = lblName.Text
            dr(2) = lblColour.Text
            dr(3) = lblSize.Text
            dr(4) = lblPrice.Text
            dr(5) = lblRRP.Text
            dr(6) = lblWas.Text
            dr(7) = TextBox2.Text
            DT.Rows.Add(dr)
            UpdateDT()

            TextBox1.Clear()
            TextBox2.Clear()
            TextBox1.Focus()

            Me.AcceptButton = Button2

        Catch ex As Exception
            MsgBox("An error has occured. " & vbCrLf & vbCrLf & "Please ensure that the connection icon at the bottom of the screen is green (Connected)." & vbCrLf & vbCrLf & " The reported message is " & ex.Message, MsgBoxStyle.Critical, "An error has occured")
        End Try
    End Sub

    Private Sub UpdateDT()
        DataGrid1.DataSource = DT
    End Sub
    Public Structure Product
        Dim Barcode As String
        Dim Name As String
        Dim Description As String
        Dim Colour As String
        Dim Size As String
        Dim qty As Integer
        Dim Price As Double
        Dim RRP As Double
        Dim Was As Double
    End Structure
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint1.Click
        Try
            MsgBox("Sent to printer.", MsgBoxStyle.Information, "Printed!")
        Catch ex As Exception
            MsgBox("An error has occured. " & vbCrLf & vbCrLf & "Please ensure that the connection icon at the bottom of the screen is green (Connected)." & vbCrLf & vbCrLf & " The reported message is " & ex.Message, MsgBoxStyle.Critical, "An error has occured")
        End Try

    End Sub
    Private Sub PreparePrint(ByVal p() As Product, ByVal LabelFormat As String, ByVal PrinterName As String)
        Dim pr As Product
        Dim LabelText As String
        Dim XVtext As String
        Dim C As Decimal
        Dim PrintText As String = ""
        For Each pr In p
            If cbSale.Checked = True And pr.Was <> pr.Price Then
                PrintText &= SetPrintString(pr, LabelFormat)
            ElseIf cbSale.Checked = False Then
                PrintText &= SetPrintString(pr, LabelFormat)
            End If
        Next
        If _JobEnd = True Then
            PrintText &= JobEndLabel(LabelFormat)
        End If
        RawPrinterHelper.SendStringToPrinter(PrinterName, PrintText)

    End Sub

    Private Function JobEndLabel(ByVal LabelFormat As String) As String
        Dim LabelText As String
        LabelText = LabelFormat
        LabelText = LabelText.Replace("<rrp>", "BLANK")

        LabelText = LabelText.Replace("<retail>", "BLANK")
        LabelText = LabelText.Replace("<barcode>", "00000000")
        LabelText = LabelText.Replace("<name>", "BLANK")
        LabelText = LabelText.Replace("<colour>", "BLANK")
        LabelText = LabelText.Replace("<size>", "BLANK")
        LabelText = LabelText.Replace("<qty>", 1)

        LabelText = LabelText.Replace("<was>", "BLANK")

        LabelText = LabelText.Replace("<bmprice>", "BLANK")
        LabelText = LabelText.Replace("<bmwasshort>", "BLANK")
        LabelText = LabelText.Replace("<bmnowshort>", "BLANK")
        If GetSetting("labelit", "settings", "currency") <> "£" Then
            LabelText = LabelText.Replace("œ", GetSetting("labelit", "settings", "currency"))
        End If
        Return LabelText
    End Function
    Private Function SetPrintString(ByVal Pr As Product, ByVal LabelFormat As String) As String
        Dim LabelText As String
        LabelText = LabelFormat

        LabelText = LabelText.Replace("<rrp>", CurrencyPrice(Pr.RRP))

        LabelText = LabelText.Replace("<retail>", CurrencyPrice(Pr.Price))
        LabelText = LabelText.Replace("<barcode>", Pr.Barcode)
        LabelText = LabelText.Replace("<name>", Pr.Name)
        LabelText = LabelText.Replace("<colour>", Pr.Colour)
        LabelText = LabelText.Replace("<size>", Pr.Size)
        LabelText = LabelText.Replace("<qty>", Pr.qty)

        LabelText = LabelText.Replace("<was>", CurrencyPrice(Pr.Was))

        LabelText = LabelText.Replace("<bmprice>", Me.BMPriceBarcode(CurrencyPrice(Pr.Price)))
        LabelText = LabelText.Replace("<bmwasshort>", Me.BMPriceString(CurrencyPrice(Pr.Was)))
        LabelText = LabelText.Replace("<bmnowshort>", Me.BMPriceString(CurrencyPrice(Pr.Price)))
        If Pr.Was = Pr.Price Then
            LabelText = LabelText.Replace("<xval>", "")

        Else
            LabelText = LabelText.Replace("<xval>", "XVAL")
        End If
        If GetSetting("labelit", "settings", "currency") <> "£" Then
            LabelText = LabelText.Replace("œ", "Õ")
        End If
        Dim Vpos, Hpos As Integer
        If GetSetting("labelit", "adjustment", "vpos", "0") <> 0 Then
            Vpos = GetSetting("labelit", "adjustment", "vpos", "0")
        End If

        If GetSetting("labelit", "adjustment", "hpos", "0") <> 0 Then
            Hpos = GetSetting("labelit", "adjustment", "hpos", "0")
        End If

        If Vpos <> 0 Or Hpos <> 0 Then
            Dim R As System.Text.RegularExpressions.Regex
            R = New System.Text.RegularExpressions.Regex("H(?<HPos>\d+)V(?<vPos>\d+)")
            Dim M As System.Text.RegularExpressions.Match
            For Each M In R.Matches(LabelText)
                'MsgBox(M.ToString)
                'MsgBox(M.Groups(0).ToString)
                LabelText = LabelText.Replace(M.Groups(0).ToString, "H" & GetHPos(M.Groups(1).ToString) & "V" & GetVPos(M.Groups(2).ToString))
            Next

        End If
        Return LabelText
    End Function

    Public Function GetVPos(ByVal Vpos As Integer) As String
        Vpos = Vpos + GetSetting("labelit", "adjustment", "vpos", "0")
        Dim VposString As String
        VposString = Vpos
        If VposString.Length = 1 Then
            'prefix 000
            VposString = "000" & Vpos
        ElseIf VposString.Length = 2 Then
            VposString = "00" & Vpos
        ElseIf VposString.Length = 3 Then
            VposString = "0" & Vpos
        Else
            VposString = Vpos
        End If

        Return VposString
    End Function

    Public Function GetHPos(ByVal Hpos As Integer) As String
        Hpos = Hpos + GetSetting("labelit", "adjustment", "hpos", "0")
        Dim HposString As String
        HposString = Hpos
        If HposString.Length = 1 Then
            'prefix 000
            HposString = "000" & Hpos
        ElseIf HposString.Length = 2 Then
            HposString = "00" & Hpos
        ElseIf HposString.Length = 3 Then
            HposString = "0" & Hpos
        Else
            HposString = Hpos
        End If

        Return HposString
    End Function
    Public Function ChangeCharacter(ByVal St As String) As String
        St = Replace(St, vbCrLf, "")
        'St = Replace(St, "|", Chr(27))
        'St = Replace(St, "^", Chr(3))
        'St = Replace(St, "~", Chr(2))
        Return St
    End Function
    Public Function GetFileContents(ByVal FullPath As String,
       Optional ByRef ErrInfo As String = "") As String

        Dim strContents As String
        Dim objReader As StreamReader
        Try

            objReader = New StreamReader(FullPath)
            strContents = objReader.ReadToEnd()
            objReader.Close()
            Return strContents
        Catch Ex As Exception
            ErrInfo = Ex.Message
        End Try
    End Function

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ClearDT()
        TextBox1.Focus()
    End Sub

    Private Sub ClearDT()
        DT = New DataTable
        DT.Columns.Add("barcode")
        DT.Columns.Add("product")
        DT.Columns.Add("colour")
        DT.Columns.Add("size")
        DT.Columns.Add("price")
        DT.Columns.Add("rrp")
        DT.Columns.Add("was")
        DT.Columns.Add("qty")
        UpdateDT()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim WSX As New LSX.lsx
            WSX.Url = _WSXurl

            Dim DS As New DataSet

            DS = WSX.GetDeliveryDetails(dtDelivery.Value, _Branch)
            If DS.Tables(0).Rows.Count = 0 Then
                MsgBox("There is no delivery for this date")
                Exit Sub
            End If

            Dim Drow As DataRow
            Dim dr(7) As String
            For Each Drow In DS.Tables(0).Rows
                dr(0) = Drow("pos_code")
                dr(1) = Drow("alt_code1")
                dr(2) = Drow("colour_desc")
                dr(3) = Drow("size_desc_short")
                dr(4) = CurrencyPrice(Drow("current_sp"))
                dr(5) = CurrencyPrice(Drow("original_rrp"))
                dr(6) = CurrencyPrice(Drow("was"))
                dr(7) = Drow("p_qty")
                DT.Rows.Add(dr)
            Next
        Catch ex As Exception
            MsgBox("An error has occured. " & vbCrLf & vbCrLf & "Please ensure that the connection icon at the bottom of the screen is green (Connected)." & vbCrLf & vbCrLf & " The reported message is " & ex.Message, MsgBoxStyle.Critical, "An error has occured")
        End Try


    End Sub
    Private Function BMPriceBarcode(ByVal RetailPrice As Double) As String
        Dim BMString As String
        BMString = RetailPrice * 100
        If BMString.Length = 3 Then
            BMString = "00" & BMString
        ElseIf BMString.Length = 4 Then
            BMString = "0" & BMString
        End If

        BMString = "*487" & BMString

        Return BMString
    End Function

    Private Function BMPriceString(ByVal RetailPrice As Double) As String
        Dim BMString As String
        BMString = RetailPrice * 100
        If BMString.Length = 2 Then
            BMString = "000" & BMString
        ElseIf BMString.Length = 3 Then
            BMString = "00" & BMString
        ElseIf BMString.Length = 4 Then
            BMString = "0" & BMString
        End If


        Return BMString
    End Function
    Private Function CurrencyPrice(ByVal Price As Decimal) As String
        Dim CPrice As String = System.Math.Round(Price, 2).ToString
        Dim Cprices() As String
        Cprices = Split(CPrice, ".")

        If Cprices.Length > 1 Then
            'we have a decimal value

            If Cprices(1).Length = "1" Then
                CPrice = CPrice & "0"
            Else

            End If


        Else
            'we dont
            CPrice = CPrice & ".00"
        End If

        Return CPrice
    End Function
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim F As New frmSetup
        F.ShowDialog()
        _WSXurl = GetSetting("labelIt", "settings", "wsx")
        _printer = GetSetting("labelIt", "settings", "printer")
        _Branch = GetSetting("labelIt", "settings", "branch")
    End Sub

    'Private Function Blanklabel() As String
    '    'Dim strName As String
    '    'strName = "LabelIt.blank.txt"
    '    ''Return New String(System.Reflection.Assembly.GetExecutingAssembly.GetManifestResourceStream(strName))
    '    'System.Reflection.Assembly.GetExecutingAssembly.GetManifestResourceStream(strName)


    '    'Dim Assm As System.Reflection.Assembly = Me.GetType().Assembly
    '    '' Open the required resource and create stream from it.
    '    'Dim xmlStream As System.IO.Stream = Assm.GetManifestResourceStream(strName)
    '    'Dim reader As New System.IO.StreamReader(xmlStream)
    '    Dim buffer As String '= reader.ReadToEnd()
    '    'reader.Close()
    '    'xmlStream.Close()

    '    'Return buffer


    '    Dim oFile As System.IO.File
    '    Dim oRead As System.IO.StreamReader
    '    oRead = oFile.OpenText("blank.txt")
    '    buffer = oRead.ReadToEnd
    '    oRead.Close()
    '    Return buffer
    'End Function



    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBatch.SelectedIndexChanged
        '   MsgBox(TabControl1.SelectedIndex)



        If btnBatch.SelectedIndex = 1 Then
            Button6.Text = "Connecting"
            Button6.BackColor = System.Drawing.Color.Yellow

            Button1.Enabled = False
            Dim T As Threading.Thread
            T = New Threading.Thread(AddressOf checkConnection)
            T.Start()


        Else

        End If

    End Sub

    Private Sub checkConnection()
        Dim WSX As New LSX.lsx
        WSX.Url = _WSXurl

        Dim isConnected As Integer = 0
        Try
            isConnected = WSX.isConnectionActive
            If isConnected = 1 Then
                'we are connected
                updateButton("Button6", "Connected", System.Drawing.Color.Green)
                updatebuttonStatus("Button1", True)

            Else
                Throw New Exception("")
            End If

        Catch ex As Exception
            updateButton("Button6", "Not Connected", System.Drawing.Color.Red)
            updatebuttonStatus("Button1", False)

        End Try
    End Sub
    Private Delegate Sub updatebuttonStatusSub(ByVal name As String, ByVal status As Boolean)
    Private Sub updatebuttonStatus(ByVal name As String, ByVal status As Boolean)
        If Me.InvokeRequired Then
            Me.Invoke(New updatebuttonStatusSub(AddressOf updatebuttonStatus), New Object() {name, status})
            Return
        End If
        CType(Me.Controls.Find(name, True)(0), Button).Enabled = status

    End Sub

    Private Delegate Sub updateButtonsub(ByVal name As String, ByVal text As String, ByVal c As System.Drawing.Color)
    Private Sub updateButton(ByVal name As String, ByVal text As String, ByVal c As System.Drawing.Color)
        If Me.InvokeRequired Then
            Me.Invoke(New updateButtonsub(AddressOf updateButton), New Object() {name, text, c})
            Return
        End If
        Dim b As New Button
        b = CType(Me.Controls.Find(name, True)(0), Button)
        b.Text = text
        b.BackColor = c
    End Sub

    Function GetEmbeddedIcon(ByVal strName As String) As Icon
        strName = "LabelIt." & strName
        Return New Icon(System.Reflection.Assembly.GetExecutingAssembly.GetManifestResourceStream(strName))
    End Function



    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim T As Threading.Thread
        T = New Threading.Thread(AddressOf checkConnection)
        T.Start()
    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub cbqty_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbqty.CheckedChanged
        If cbqty.Checked = True Then
            nmQTY.Enabled = True

            If GetSetting("labelit", "settings", "multiply") <> "" Then
                Me.nmQTY.Value = GetSetting("labelit", "settings", "multiply")
                nmQTY.Enabled = True
            End If
        Else
            nmQTY.Enabled = False

        End If
        TextBox1.Focus()
    End Sub

    Private Sub cbSale_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSale.CheckedChanged
        If cbSale.Checked = True Then
            If GetSetting("labelit", "settings", "multiply") <> "" Then
                Me.cbqty.Checked = True
                Me.nmQTY.Value = GetSetting("labelit", "settings", "multiply")
                nmQTY.Enabled = True
                'check was price from reduction sheets.

            Else
                Me.cbqty.Checked = False
                Me.nmQTY.Value = 1
                nmQTY.Enabled = False
            End If

        Else
            Me.cbqty.Checked = False
            Me.nmQTY.Value = 1
            nmQTY.Enabled = False
        End If
        TextBox1.Focus()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Try
            Dim WSX As New LSX.lsx
            WSX.Url = _WSXurl

            Dim DS As New DataSet

            DS = WSX.GetManualDeliveryDetails(dtDelivery.Value, _Branch)
            If DS.Tables(0).Rows.Count = 0 Then
                MsgBox("There is no delivery for this date")
                Exit Sub
            End If

            Dim Drow As DataRow
            Dim dr(7) As String
            For Each Drow In DS.Tables(0).Rows
                dr(0) = Drow("pos_code")
                dr(1) = Drow("alt_code1")
                dr(2) = Drow("colour_desc")
                dr(3) = Drow("size_desc_short")
                dr(4) = CurrencyPrice(Drow("current_sp"))
                dr(5) = CurrencyPrice(Drow("original_rrp"))
                dr(6) = CurrencyPrice(Drow("was"))
                dr(7) = Drow("p_qty")
                DT.Rows.Add(dr)
            Next
        Catch ex As Exception
            MsgBox("An error has occured. " & vbCrLf & vbCrLf & "Please ensure that the connection icon at the bottom of the screen is green (Connected)." & vbCrLf & vbCrLf & " The reported message is " & ex.Message, MsgBoxStyle.Critical, "An error has occured")
        End Try
    End Sub

    Private WithEvents R As New Reduction

    Private Sub GetReductionFromHO(ByVal RmisID As String, Optional ByVal AltCode As String = "")

    End Sub

    Private Sub GetReduction(ByVal RmisID As String, Optional ByVal Altcode As String = "")
        '        Dim RmisID As String

        '  Dim R As New Reduction
        Try


            Dim DS As New DataSet
            If GetSetting("labelit", "settings", "horeduction", "0") = "1" Then
                DS = R.GetReductionFromHO(RmisID, Altcode)
            Else

                DS = R.GetReduction(RmisID, Altcode)
            End If
            If DS.Tables(0).Rows.Count = 0 Then
                MsgBox("You have no items in stock for this reduction")
                Exit Sub
            End If
            Dim Drow As DataRow
            Dim dr(7) As String
            Dim DView As New DataView(DS.Tables(0))
            DView.Sort = "product"
            DS.Tables(0).DefaultView.Sort = "product ASC, colour ASC"

            Dim pWas, pNow As Double

            For Each Drow In DS.Tables(0).Rows
                dr(0) = Drow("barcode")
                dr(1) = Drow("product")
                dr(2) = Drow("colour")
                dr(3) = Drow("size")
                dr(4) = CurrencyPrice(Drow("price"))
                dr(5) = CurrencyPrice(Drow("rrp"))
                dr(6) = CurrencyPrice(Drow("was"))
                dr(7) = Drow("qty")
                pWas = Drow("was")
                pNow = Drow("price")
                '  If Drow("price") < Drow("was") Then
                If pNow < pWas Then
                    DT.Rows.Add(dr)
                End If
                '  End If

            Next
            DT.DefaultView.Sort = "product ASC"
        Catch ex As Exception
            MsgBox("An error has occured - " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private t As Threading.Thread
    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Button4.Enabled = False
        Button8.Enabled = False
        'Try
        '    t.Abort()
        'Catch ex As Exception

        'End Try
        't = New Threading.Thread(AddressOf SaleThreadStart)
        't.Start()
        SaleThreadStart()
    End Sub

    Private Sub SaleThreadStart()
        GetReduction(Me.cmbSaleSheets.SelectedValue)
    End Sub

    Private Sub SaleThreadStartAltcode()
        GetReduction(Me.cmbSaleSheets.SelectedValue, Me.cmbAltCode.SelectedValue)
    End Sub
    Private Sub cmbSaleSheets_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSaleSheets.SelectedIndexChanged
        Dim R As New Reduction
        cmbAltCode.DataSource = R.GetAltCodesInReduction(cmbSaleSheets.SelectedValue)
    End Sub

    Private Sub TabPage3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage3.Click

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Button8.Enabled = False
        'Try
        '    t.Abort()
        'Catch ex As Exception

        'End Try
        't = New Threading.Thread(AddressOf )
        't.Start()

        SaleThreadStartAltcode()
    End Sub

    Private Sub R_StatusChanged(ByVal StatusText As String) Handles R.StatusChanged

        lblSaleStatus.Text = StatusText
        System.Windows.Forms.Application.DoEvents()
    End Sub

    Private Sub Form1_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Try
            t.Abort()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub R_DownloadComplete() Handles R.DownloadComplete
        Button4.Enabled = True
        Button8.Enabled = True
    End Sub


    Private Sub TabPage4_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub btnBatch1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub AutoAdd_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles AutoAdd.CheckedChanged
        TextBox1.Focus()

    End Sub

    Private Sub nmQTY_LocationChanged(sender As Object, e As System.EventArgs) Handles nmQTY.LocationChanged
        TextBox1.Focus()
    End Sub





    Private Sub DataGrid1_Navigate(sender As System.Object, ne As System.Windows.Forms.NavigateEventArgs) Handles DataGrid1.Navigate

    End Sub
End Class
