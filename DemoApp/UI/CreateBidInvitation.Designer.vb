<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateBidInvitation
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
        Me.dtpDueTime = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.dtpDueDate = New System.Windows.Forms.DateTimePicker()
        Me.cmbTransactionFee = New System.Windows.Forms.ComboBox()
        Me.cmbBidStatus = New System.Windows.Forms.ComboBox()
        Me.cmbBidType = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBidTitle = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.dgvSelectedCompany = New System.Windows.Forms.DataGridView()
        Me.dgvCompanyList = New System.Windows.Forms.DataGridView()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.txtItemDescription = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtItemUOM = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtItemQuantity = New System.Windows.Forms.TextBox()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtAttachments = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel9.SuspendLayout()
        CType(Me.dgvSelectedCompany, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCompanyList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpDueTime
        '
        Me.dtpDueTime.CustomFormat = "MMMM dd, yyyy HH:mm:ss"
        Me.dtpDueTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDueTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpDueTime.Location = New System.Drawing.Point(312, 114)
        Me.dtpDueTime.Name = "dtpDueTime"
        Me.dtpDueTime.ShowUpDown = True
        Me.dtpDueTime.Size = New System.Drawing.Size(108, 22)
        Me.dtpDueTime.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(23, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Bid Title"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkGray
        Me.Panel4.Location = New System.Drawing.Point(187, 106)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(996, 309)
        Me.Panel4.TabIndex = 1
        '
        'dtpDueDate
        '
        Me.dtpDueDate.CustomFormat = "MMMM dd, yyyy HH:mm:ss"
        Me.dtpDueDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDueDate.Location = New System.Drawing.Point(26, 114)
        Me.dtpDueDate.Name = "dtpDueDate"
        Me.dtpDueDate.Size = New System.Drawing.Size(280, 22)
        Me.dtpDueDate.TabIndex = 1
        '
        'cmbTransactionFee
        '
        Me.cmbTransactionFee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTransactionFee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbTransactionFee.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTransactionFee.FormattingEnabled = True
        Me.cmbTransactionFee.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30"})
        Me.cmbTransactionFee.Location = New System.Drawing.Point(27, 262)
        Me.cmbTransactionFee.Name = "cmbTransactionFee"
        Me.cmbTransactionFee.Size = New System.Drawing.Size(392, 24)
        Me.cmbTransactionFee.TabIndex = 5
        '
        'cmbBidStatus
        '
        Me.cmbBidStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBidStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbBidStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBidStatus.FormattingEnabled = True
        Me.cmbBidStatus.Items.AddRange(New Object() {"Open", "Closed", "Cancelled"})
        Me.cmbBidStatus.Location = New System.Drawing.Point(27, 212)
        Me.cmbBidStatus.Name = "cmbBidStatus"
        Me.cmbBidStatus.Size = New System.Drawing.Size(392, 24)
        Me.cmbBidStatus.TabIndex = 4
        '
        'cmbBidType
        '
        Me.cmbBidType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBidType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbBidType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBidType.FormattingEnabled = True
        Me.cmbBidType.Items.AddRange(New Object() {"Public ", "Selected Vendors"})
        Me.cmbBidType.Location = New System.Drawing.Point(27, 162)
        Me.cmbBidType.Name = "cmbBidType"
        Me.cmbBidType.Size = New System.Drawing.Size(392, 24)
        Me.cmbBidType.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(23, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Bid Due Date"
        '
        'txtBidTitle
        '
        Me.txtBidTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBidTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBidTitle.Location = New System.Drawing.Point(26, 66)
        Me.txtBidTitle.Name = "txtBidTitle"
        Me.txtBidTitle.Size = New System.Drawing.Size(635, 22)
        Me.txtBidTitle.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(23, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "General Information"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.dtpDueTime)
        Me.Panel2.Controls.Add(Me.dtpDueDate)
        Me.Panel2.Controls.Add(Me.cmbTransactionFee)
        Me.Panel2.Controls.Add(Me.cmbBidStatus)
        Me.Panel2.Controls.Add(Me.cmbBidType)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtBidTitle)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(181, 101)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(996, 309)
        Me.Panel2.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(26, 161)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(394, 27)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Location = New System.Drawing.Point(26, 260)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(394, 27)
        Me.PictureBox3.TabIndex = 11
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(26, 210)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(394, 27)
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(23, 242)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Transaction Fee Rate"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(23, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Bid Status"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(23, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Bid Type"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(426, 11)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 17)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Business Centre"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(335, 11)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(46, 17)
        Me.Label17.TabIndex = 26
        Me.Label17.Text = "Profile"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(891, 11)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(77, 17)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "Accounting"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Nasalization Rg", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(87, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 25)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "LINK"
        '
        'lblUser
        '
        Me.lblUser.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.White
        Me.lblUser.Location = New System.Drawing.Point(1126, 12)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(106, 17)
        Me.lblUser.TabIndex = 13
        Me.lblUser.Text = "User"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(575, 11)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 17)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Bidding"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(675, 11)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 17)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Procure"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(240, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 17)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Home"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(780, 11)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 17)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Payment"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.lblUser)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Location = New System.Drawing.Point(1, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1349, 41)
        Me.Panel3.TabIndex = 34
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(1013, 11)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(57, 17)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "Settings"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.AutoSize = True
        Me.Panel1.Controls.Add(Me.Label27)
        Me.Panel1.Controls.Add(Me.Label26)
        Me.Panel1.Controls.Add(Me.Panel11)
        Me.Panel1.Controls.Add(Me.Panel9)
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Panel8)
        Me.Panel1.Controls.Add(Me.Panel10)
        Me.Panel1.Controls.Add(Me.Panel12)
        Me.Panel1.Controls.Add(Me.Panel13)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1370, 491)
        Me.Panel1.TabIndex = 33
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label27.Location = New System.Drawing.Point(249, 65)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(192, 18)
        Me.Label27.TabIndex = 16
        Me.Label27.Text = "| CREATE BID INVITATION"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label26.Location = New System.Drawing.Point(178, 65)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(76, 18)
        Me.Label26.TabIndex = 12
        Me.Label26.Text = "BIDDING "
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.White
        Me.Panel11.Controls.Add(Me.Button5)
        Me.Panel11.Controls.Add(Me.btnSave)
        Me.Panel11.Location = New System.Drawing.Point(2, 1434)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(1349, 50)
        Me.Panel11.TabIndex = 21
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Red
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(686, 9)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(305, 32)
        Me.Button5.TabIndex = 23
        Me.Button5.Text = "Cancel"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Green
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(365, 9)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(305, 32)
        Me.btnSave.TabIndex = 22
        Me.btnSave.Text = "Save and Publish Bidding Invitation"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.White
        Me.Panel9.Controls.Add(Me.Label25)
        Me.Panel9.Controls.Add(Me.Button4)
        Me.Panel9.Controls.Add(Me.Button3)
        Me.Panel9.Controls.Add(Me.dgvSelectedCompany)
        Me.Panel9.Controls.Add(Me.dgvCompanyList)
        Me.Panel9.Controls.Add(Me.Label21)
        Me.Panel9.Controls.Add(Me.TextBox7)
        Me.Panel9.Controls.Add(Me.Label28)
        Me.Panel9.Location = New System.Drawing.Point(181, 1019)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(996, 215)
        Me.Panel9.TabIndex = 15
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label25.Location = New System.Drawing.Point(523, 49)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(103, 17)
        Me.Label25.TabIndex = 16
        Me.Label25.Text = "Selected Banks"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(476, 135)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(42, 23)
        Me.Button4.TabIndex = 18
        Me.Button4.Text = "<<"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(476, 106)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(42, 23)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = ">>"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'dgvSelectedCompany
        '
        Me.dgvSelectedCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSelectedCompany.Location = New System.Drawing.Point(526, 76)
        Me.dgvSelectedCompany.Name = "dgvSelectedCompany"
        Me.dgvSelectedCompany.Size = New System.Drawing.Size(440, 113)
        Me.dgvSelectedCompany.TabIndex = 13
        '
        'dgvCompanyList
        '
        Me.dgvCompanyList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCompanyList.Location = New System.Drawing.Point(27, 76)
        Me.dgvCompanyList.Name = "dgvCompanyList"
        Me.dgvCompanyList.Size = New System.Drawing.Size(440, 113)
        Me.dgvCompanyList.TabIndex = 12
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(23, 49)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(51, 17)
        Me.Label21.TabIndex = 11
        Me.Label21.Text = "Search"
        '
        'TextBox7
        '
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(80, 44)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(387, 22)
        Me.TextBox7.TabIndex = 16
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label28.Location = New System.Drawing.Point(23, 16)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(144, 18)
        Me.Label28.TabIndex = 0
        Me.Label28.Text = "Company Selection"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.White
        Me.Panel7.Controls.Add(Me.txtItemDescription)
        Me.Panel7.Controls.Add(Me.Label24)
        Me.Panel7.Controls.Add(Me.Label23)
        Me.Panel7.Controls.Add(Me.txtItemUOM)
        Me.Panel7.Controls.Add(Me.Label22)
        Me.Panel7.Controls.Add(Me.txtItemQuantity)
        Me.Panel7.Controls.Add(Me.txtItemName)
        Me.Panel7.Controls.Add(Me.Label19)
        Me.Panel7.Controls.Add(Me.Label20)
        Me.Panel7.Location = New System.Drawing.Point(181, 769)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(996, 227)
        Me.Panel7.TabIndex = 10
        '
        'txtItemDescription
        '
        Me.txtItemDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemDescription.Location = New System.Drawing.Point(26, 113)
        Me.txtItemDescription.Multiline = True
        Me.txtItemDescription.Name = "txtItemDescription"
        Me.txtItemDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtItemDescription.Size = New System.Drawing.Size(940, 89)
        Me.txtItemDescription.TabIndex = 14
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label24.Location = New System.Drawing.Point(25, 93)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(80, 17)
        Me.Label24.TabIndex = 11
        Me.Label24.Text = "Description"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label23.Location = New System.Drawing.Point(800, 46)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(140, 17)
        Me.Label23.TabIndex = 10
        Me.Label23.Text = "Unit of Measurement"
        '
        'txtItemUOM
        '
        Me.txtItemUOM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemUOM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemUOM.Location = New System.Drawing.Point(803, 66)
        Me.txtItemUOM.Name = "txtItemUOM"
        Me.txtItemUOM.Size = New System.Drawing.Size(163, 22)
        Me.txtItemUOM.TabIndex = 13
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label22.Location = New System.Drawing.Point(658, 46)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(63, 17)
        Me.Label22.TabIndex = 8
        Me.Label22.Text = "Quantity"
        '
        'txtItemQuantity
        '
        Me.txtItemQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemQuantity.Location = New System.Drawing.Point(661, 66)
        Me.txtItemQuantity.Name = "txtItemQuantity"
        Me.txtItemQuantity.Size = New System.Drawing.Size(127, 22)
        Me.txtItemQuantity.TabIndex = 12
        '
        'txtItemName
        '
        Me.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemName.Location = New System.Drawing.Point(26, 66)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(620, 22)
        Me.txtItemName.TabIndex = 11
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(23, 46)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(37, 17)
        Me.Label19.TabIndex = 1
        Me.Label19.Text = "Item"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(23, 16)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(134, 18)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Item Specification"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.Button2)
        Me.Panel5.Controls.Add(Me.Button1)
        Me.Panel5.Controls.Add(Me.txtAttachments)
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.Controls.Add(Me.txtDescription)
        Me.Panel5.Controls.Add(Me.Label16)
        Me.Panel5.Controls.Add(Me.Label18)
        Me.Panel5.Location = New System.Drawing.Point(181, 434)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(996, 309)
        Me.Panel5.TabIndex = 6
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(555, 216)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(555, 187)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Browse"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtAttachments
        '
        Me.txtAttachments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAttachments.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAttachments.Location = New System.Drawing.Point(26, 187)
        Me.txtAttachments.Multiline = True
        Me.txtAttachments.Name = "txtAttachments"
        Me.txtAttachments.Size = New System.Drawing.Size(523, 99)
        Me.txtAttachments.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(24, 167)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 17)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Attachments"
        '
        'txtDescription
        '
        Me.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(26, 66)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescription.Size = New System.Drawing.Size(940, 89)
        Me.txtDescription.TabIndex = 7
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(23, 46)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(80, 17)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Description"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(23, 16)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(145, 18)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Project Description"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.DarkGray
        Me.Panel6.Location = New System.Drawing.Point(187, 439)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(996, 309)
        Me.Panel6.TabIndex = 2
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.DarkGray
        Me.Panel8.Location = New System.Drawing.Point(187, 775)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(996, 226)
        Me.Panel8.TabIndex = 3
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.DarkGray
        Me.Panel10.Location = New System.Drawing.Point(187, 1025)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(996, 214)
        Me.Panel10.TabIndex = 4
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.White
        Me.Panel12.Controls.Add(Me.TextBox2)
        Me.Panel12.Controls.Add(Me.Label31)
        Me.Panel12.Location = New System.Drawing.Point(181, 1260)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(996, 147)
        Me.Panel12.TabIndex = 19
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(26, 37)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox2.Size = New System.Drawing.Size(940, 89)
        Me.TextBox2.TabIndex = 20
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label31.Location = New System.Drawing.Point(23, 16)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(112, 18)
        Me.Label31.TabIndex = 0
        Me.Label31.Text = "Note to Bidder"
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.DarkGray
        Me.Panel13.Location = New System.Drawing.Point(187, 1265)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(996, 147)
        Me.Panel13.TabIndex = 7
        '
        'CreateBidInvitation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 491)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "CreateBidInvitation"
        Me.Text = "CreateBidInvitation"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        CType(Me.dgvSelectedCompany, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCompanyList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtpDueTime As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents dtpDueDate As DateTimePicker
    Friend WithEvents cmbTransactionFee As ComboBox
    Friend WithEvents cmbBidStatus As ComboBox
    Friend WithEvents cmbBidType As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBidTitle As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtAttachments As TextBox
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label25 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents dgvSelectedCompany As DataGridView
    Friend WithEvents dgvCompanyList As DataGridView
    Friend WithEvents Label21 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents txtItemDescription As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents txtItemUOM As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txtItemQuantity As TextBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents Panel13 As Panel
End Class
