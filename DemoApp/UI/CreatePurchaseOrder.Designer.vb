<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PurchaseOrderPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblUserHeader = New System.Windows.Forms.Label()
        Me.lblBiddingHeader = New System.Windows.Forms.Label()
        Me.lblProcureHeader = New System.Windows.Forms.Label()
        Me.lblHomeHeader = New System.Windows.Forms.Label()
        Me.lblPaymentHeader = New System.Windows.Forms.Label()
        Me.lblProfileHeader = New System.Windows.Forms.Label()
        Me.lblAccountingHeader = New System.Windows.Forms.Label()
        Me.lblBusinessCentreHeader = New System.Windows.Forms.Label()
        Me.lblSettingsHeader = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvPurchaseOrder = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbBidType = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTransactionFee = New System.Windows.Forms.Label()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.Column1 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvPurchaseOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.lblUserHeader)
        Me.Panel3.Controls.Add(Me.lblBiddingHeader)
        Me.Panel3.Controls.Add(Me.lblProcureHeader)
        Me.Panel3.Controls.Add(Me.lblHomeHeader)
        Me.Panel3.Controls.Add(Me.lblPaymentHeader)
        Me.Panel3.Controls.Add(Me.lblProfileHeader)
        Me.Panel3.Controls.Add(Me.lblAccountingHeader)
        Me.Panel3.Controls.Add(Me.lblBusinessCentreHeader)
        Me.Panel3.Controls.Add(Me.lblSettingsHeader)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1350, 41)
        Me.Panel3.TabIndex = 32
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Nasalization Rg", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(89, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 25)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "LINK"
        '
        'lblUserHeader
        '
        Me.lblUserHeader.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserHeader.ForeColor = System.Drawing.Color.White
        Me.lblUserHeader.Location = New System.Drawing.Point(1126, 9)
        Me.lblUserHeader.Name = "lblUserHeader"
        Me.lblUserHeader.Size = New System.Drawing.Size(106, 20)
        Me.lblUserHeader.TabIndex = 13
        Me.lblUserHeader.Text = "User"
        Me.lblUserHeader.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBiddingHeader
        '
        Me.lblBiddingHeader.AutoSize = True
        Me.lblBiddingHeader.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBiddingHeader.ForeColor = System.Drawing.Color.White
        Me.lblBiddingHeader.Location = New System.Drawing.Point(575, 11)
        Me.lblBiddingHeader.Name = "lblBiddingHeader"
        Me.lblBiddingHeader.Size = New System.Drawing.Size(54, 17)
        Me.lblBiddingHeader.TabIndex = 20
        Me.lblBiddingHeader.Text = "Bidding"
        Me.lblBiddingHeader.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblProcureHeader
        '
        Me.lblProcureHeader.AutoSize = True
        Me.lblProcureHeader.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcureHeader.ForeColor = System.Drawing.Color.White
        Me.lblProcureHeader.Location = New System.Drawing.Point(675, 11)
        Me.lblProcureHeader.Name = "lblProcureHeader"
        Me.lblProcureHeader.Size = New System.Drawing.Size(55, 17)
        Me.lblProcureHeader.TabIndex = 21
        Me.lblProcureHeader.Text = "Procure"
        Me.lblProcureHeader.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblHomeHeader
        '
        Me.lblHomeHeader.AutoSize = True
        Me.lblHomeHeader.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHomeHeader.ForeColor = System.Drawing.Color.White
        Me.lblHomeHeader.Location = New System.Drawing.Point(240, 11)
        Me.lblHomeHeader.Name = "lblHomeHeader"
        Me.lblHomeHeader.Size = New System.Drawing.Size(45, 17)
        Me.lblHomeHeader.TabIndex = 27
        Me.lblHomeHeader.Text = "Home"
        Me.lblHomeHeader.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblPaymentHeader
        '
        Me.lblPaymentHeader.AutoSize = True
        Me.lblPaymentHeader.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentHeader.ForeColor = System.Drawing.Color.White
        Me.lblPaymentHeader.Location = New System.Drawing.Point(780, 11)
        Me.lblPaymentHeader.Name = "lblPaymentHeader"
        Me.lblPaymentHeader.Size = New System.Drawing.Size(62, 17)
        Me.lblPaymentHeader.TabIndex = 22
        Me.lblPaymentHeader.Text = "Payment"
        Me.lblPaymentHeader.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblProfileHeader
        '
        Me.lblProfileHeader.AutoSize = True
        Me.lblProfileHeader.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProfileHeader.ForeColor = System.Drawing.Color.White
        Me.lblProfileHeader.Location = New System.Drawing.Point(335, 11)
        Me.lblProfileHeader.Name = "lblProfileHeader"
        Me.lblProfileHeader.Size = New System.Drawing.Size(46, 17)
        Me.lblProfileHeader.TabIndex = 26
        Me.lblProfileHeader.Text = "Profile"
        Me.lblProfileHeader.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblAccountingHeader
        '
        Me.lblAccountingHeader.AutoSize = True
        Me.lblAccountingHeader.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountingHeader.ForeColor = System.Drawing.Color.White
        Me.lblAccountingHeader.Location = New System.Drawing.Point(891, 11)
        Me.lblAccountingHeader.Name = "lblAccountingHeader"
        Me.lblAccountingHeader.Size = New System.Drawing.Size(77, 17)
        Me.lblAccountingHeader.TabIndex = 23
        Me.lblAccountingHeader.Text = "Accounting"
        Me.lblAccountingHeader.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblBusinessCentreHeader
        '
        Me.lblBusinessCentreHeader.AutoSize = True
        Me.lblBusinessCentreHeader.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBusinessCentreHeader.ForeColor = System.Drawing.Color.White
        Me.lblBusinessCentreHeader.Location = New System.Drawing.Point(426, 11)
        Me.lblBusinessCentreHeader.Name = "lblBusinessCentreHeader"
        Me.lblBusinessCentreHeader.Size = New System.Drawing.Size(104, 17)
        Me.lblBusinessCentreHeader.TabIndex = 25
        Me.lblBusinessCentreHeader.Text = "Business Centre"
        Me.lblBusinessCentreHeader.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblSettingsHeader
        '
        Me.lblSettingsHeader.AutoSize = True
        Me.lblSettingsHeader.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSettingsHeader.ForeColor = System.Drawing.Color.White
        Me.lblSettingsHeader.Location = New System.Drawing.Point(1013, 11)
        Me.lblSettingsHeader.Name = "lblSettingsHeader"
        Me.lblSettingsHeader.Size = New System.Drawing.Size(57, 17)
        Me.lblSettingsHeader.TabIndex = 24
        Me.lblSettingsHeader.Text = "Settings"
        Me.lblSettingsHeader.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label27.Location = New System.Drawing.Point(131, 80)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(360, 18)
        Me.Label27.TabIndex = 34
        Me.Label27.Text = "| PURCHASE ORDERS | NEW PURCHASE ORDER"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label26.Location = New System.Drawing.Point(41, 80)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(84, 18)
        Me.Label26.TabIndex = 33
        Me.Label26.Text = "PROCURE"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.lblTotal)
        Me.Panel2.Controls.Add(Me.lblTransactionFee)
        Me.Panel2.Controls.Add(Me.lblSubTotal)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.dgvPurchaseOrder)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.cmbBidType)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(44, 107)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1265, 600)
        Me.Panel2.TabIndex = 35
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(49, 441)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(1169, 91)
        Me.TextBox1.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(46, 421)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 16)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Message to Vendor"
        '
        'dgvPurchaseOrder
        '
        Me.dgvPurchaseOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPurchaseOrder.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgvPurchaseOrder.Location = New System.Drawing.Point(49, 180)
        Me.dgvPurchaseOrder.Name = "dgvPurchaseOrder"
        Me.dgvPurchaseOrder.Size = New System.Drawing.Size(1169, 188)
        Me.dgvPurchaseOrder.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(46, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 16)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Item Details"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(147, 102)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 16)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "P.O. Number"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(147, 81)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 16)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Date"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(46, 102)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 16)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "P.O. Number"
        '
        'cmbBidType
        '
        Me.cmbBidType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBidType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbBidType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBidType.FormattingEnabled = True
        Me.cmbBidType.Items.AddRange(New Object() {"Public ", "Selected Vendors"})
        Me.cmbBidType.Location = New System.Drawing.Point(150, 122)
        Me.cmbBidType.Name = "cmbBidType"
        Me.cmbBidType.Size = New System.Drawing.Size(392, 24)
        Me.cmbBidType.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(46, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Vendor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(46, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(46, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "New Purchase Order"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(149, 121)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(394, 27)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkGray
        Me.Panel4.Location = New System.Drawing.Point(50, 112)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1265, 600)
        Me.Panel4.TabIndex = 36
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(946, 371)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 16)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Sub Total"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(946, 388)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(106, 16)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Transaction Fee"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("barcode font", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(1110, 40)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(108, 49)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "P.O. Number"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(946, 407)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 16)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Total"
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTotal.Location = New System.Drawing.Point(1082, 407)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(125, 16)
        Me.lblTotal.TabIndex = 25
        Me.lblTotal.Text = "0.00"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTransactionFee
        '
        Me.lblTransactionFee.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransactionFee.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTransactionFee.Location = New System.Drawing.Point(1082, 388)
        Me.lblTransactionFee.Name = "lblTransactionFee"
        Me.lblTransactionFee.Size = New System.Drawing.Size(125, 16)
        Me.lblTransactionFee.TabIndex = 24
        Me.lblTransactionFee.Text = "0.00"
        Me.lblTransactionFee.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSubTotal
        '
        Me.lblSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblSubTotal.Location = New System.Drawing.Point(1082, 371)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(125, 16)
        Me.lblSubTotal.TabIndex = 23
        Me.lblSubTotal.Text = "0.00"
        Me.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Column1
        '
        Me.Column1.HeaderText = "Product/Service"
        Me.Column1.Name = "Column1"
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column1.Width = 300
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Description"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N0"
        DataGridViewCellStyle4.NullValue = "0"
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column3.HeaderText = "Quantity"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = "0"
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column4.HeaderText = "Unit Price"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 120
        '
        'Column5
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = "0"
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle6
        Me.Column5.HeaderText = "Total"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 150
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(870, 538)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(171, 32)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "&Save and Send"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1047, 538)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(171, 32)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "&Print"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PurchaseOrderPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "PurchaseOrderPage"
        Me.Text = "PurchaseOrderPage"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvPurchaseOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents lblUserHeader As Label
    Friend WithEvents lblBiddingHeader As Label
    Friend WithEvents lblProcureHeader As Label
    Friend WithEvents lblHomeHeader As Label
    Friend WithEvents lblPaymentHeader As Label
    Friend WithEvents lblProfileHeader As Label
    Friend WithEvents lblAccountingHeader As Label
    Friend WithEvents lblBusinessCentreHeader As Label
    Friend WithEvents lblSettingsHeader As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cmbBidType As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dgvPurchaseOrder As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTransactionFee As Label
    Friend WithEvents lblSubTotal As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Column1 As DataGridViewComboBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
