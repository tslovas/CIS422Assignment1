<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMDIChild
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.grpCustInfo = New System.Windows.Forms.GroupBox()
        Me.txtPhoneNo = New System.Windows.Forms.MaskedTextBox()
        Me.lblCustID = New System.Windows.Forms.Label()
        Me.lblPhoneNo = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblMiddleInitial = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtCustID = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtMI = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.grpTires = New System.Windows.Forms.GroupBox()
        Me.lblTire = New System.Windows.Forms.Label()
        Me.radTire = New System.Windows.Forms.RadioButton()
        Me.grpCarWash = New System.Windows.Forms.GroupBox()
        Me.lblDeluxe = New System.Windows.Forms.Label()
        Me.lblStandard = New System.Windows.Forms.Label()
        Me.radDeluxe = New System.Windows.Forms.RadioButton()
        Me.radStandard = New System.Windows.Forms.RadioButton()
        Me.grpDetail = New System.Windows.Forms.GroupBox()
        Me.chkComplete = New System.Windows.Forms.CheckBox()
        Me.chkExterior = New System.Windows.Forms.CheckBox()
        Me.chkInterior = New System.Windows.Forms.CheckBox()
        Me.lblComplete = New System.Windows.Forms.Label()
        Me.lblExterior = New System.Windows.Forms.Label()
        Me.lblInterior = New System.Windows.Forms.Label()
        Me.grpOilChange = New System.Windows.Forms.GroupBox()
        Me.lblSynthetic = New System.Windows.Forms.Label()
        Me.lblStandardOil = New System.Windows.Forms.Label()
        Me.radSynthetic = New System.Windows.Forms.RadioButton()
        Me.radStandardOil = New System.Windows.Forms.RadioButton()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.chkGift = New System.Windows.Forms.CheckBox()
        Me.txtGift = New System.Windows.Forms.TextBox()
        Me.chkDiscount = New System.Windows.Forms.CheckBox()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grpCustInfo.SuspendLayout()
        Me.grpTires.SuspendLayout()
        Me.grpCarWash.SuspendLayout()
        Me.grpDetail.SuspendLayout()
        Me.grpOilChange.SuspendLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpCustInfo
        '
        Me.grpCustInfo.Controls.Add(Me.txtPhoneNo)
        Me.grpCustInfo.Controls.Add(Me.lblCustID)
        Me.grpCustInfo.Controls.Add(Me.lblPhoneNo)
        Me.grpCustInfo.Controls.Add(Me.lblLastName)
        Me.grpCustInfo.Controls.Add(Me.lblMiddleInitial)
        Me.grpCustInfo.Controls.Add(Me.lblFirstName)
        Me.grpCustInfo.Controls.Add(Me.txtCustID)
        Me.grpCustInfo.Controls.Add(Me.txtLastName)
        Me.grpCustInfo.Controls.Add(Me.txtMI)
        Me.grpCustInfo.Controls.Add(Me.txtFirstName)
        Me.grpCustInfo.Location = New System.Drawing.Point(24, 23)
        Me.grpCustInfo.Margin = New System.Windows.Forms.Padding(6)
        Me.grpCustInfo.Name = "grpCustInfo"
        Me.grpCustInfo.Padding = New System.Windows.Forms.Padding(6)
        Me.grpCustInfo.Size = New System.Drawing.Size(926, 119)
        Me.grpCustInfo.TabIndex = 0
        Me.grpCustInfo.TabStop = False
        Me.grpCustInfo.Text = "Customer Information:"
        '
        'txtPhoneNo
        '
        Me.txtPhoneNo.Location = New System.Drawing.Point(496, 69)
        Me.txtPhoneNo.Mask = "(999) 000-0000"
        Me.txtPhoneNo.Name = "txtPhoneNo"
        Me.txtPhoneNo.Size = New System.Drawing.Size(211, 31)
        Me.txtPhoneNo.TabIndex = 10
        '
        'lblCustID
        '
        Me.lblCustID.AutoSize = True
        Me.lblCustID.Location = New System.Drawing.Point(714, 38)
        Me.lblCustID.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblCustID.Name = "lblCustID"
        Me.lblCustID.Size = New System.Drawing.Size(136, 25)
        Me.lblCustID.TabIndex = 9
        Me.lblCustID.Text = "Customer ID:"
        '
        'lblPhoneNo
        '
        Me.lblPhoneNo.AutoSize = True
        Me.lblPhoneNo.Location = New System.Drawing.Point(502, 38)
        Me.lblPhoneNo.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblPhoneNo.Name = "lblPhoneNo"
        Me.lblPhoneNo.Size = New System.Drawing.Size(161, 25)
        Me.lblPhoneNo.TabIndex = 8
        Me.lblPhoneNo.Text = "Phone Number:"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(290, 38)
        Me.lblLastName.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(121, 25)
        Me.lblLastName.TabIndex = 7
        Me.lblLastName.Text = "Last Name:"
        '
        'lblMiddleInitial
        '
        Me.lblMiddleInitial.AutoSize = True
        Me.lblMiddleInitial.Location = New System.Drawing.Point(224, 38)
        Me.lblMiddleInitial.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblMiddleInitial.Name = "lblMiddleInitial"
        Me.lblMiddleInitial.Size = New System.Drawing.Size(41, 25)
        Me.lblMiddleInitial.TabIndex = 6
        Me.lblMiddleInitial.Text = "MI:"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(14, 38)
        Me.lblFirstName.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(122, 25)
        Me.lblFirstName.TabIndex = 5
        Me.lblFirstName.Text = "First Name:"
        '
        'txtCustID
        '
        Me.txtCustID.Enabled = False
        Me.txtCustID.Location = New System.Drawing.Point(714, 69)
        Me.txtCustID.Margin = New System.Windows.Forms.Padding(6)
        Me.txtCustID.Name = "txtCustID"
        Me.txtCustID.Size = New System.Drawing.Size(196, 31)
        Me.txtCustID.TabIndex = 4
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(290, 69)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(6)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(196, 31)
        Me.txtLastName.TabIndex = 2
        '
        'txtMI
        '
        Me.txtMI.Location = New System.Drawing.Point(224, 69)
        Me.txtMI.Margin = New System.Windows.Forms.Padding(6)
        Me.txtMI.Name = "txtMI"
        Me.txtMI.Size = New System.Drawing.Size(50, 31)
        Me.txtMI.TabIndex = 1
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(12, 69)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(6)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(196, 31)
        Me.txtFirstName.TabIndex = 0
        '
        'grpTires
        '
        Me.grpTires.Controls.Add(Me.lblTire)
        Me.grpTires.Controls.Add(Me.radTire)
        Me.grpTires.Location = New System.Drawing.Point(24, 154)
        Me.grpTires.Margin = New System.Windows.Forms.Padding(6)
        Me.grpTires.Name = "grpTires"
        Me.grpTires.Padding = New System.Windows.Forms.Padding(6)
        Me.grpTires.Size = New System.Drawing.Size(450, 81)
        Me.grpTires.TabIndex = 1
        Me.grpTires.TabStop = False
        Me.grpTires.Text = "Tires:"
        '
        'lblTire
        '
        Me.lblTire.AutoSize = True
        Me.lblTire.Location = New System.Drawing.Point(364, 42)
        Me.lblTire.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblTire.Name = "lblTire"
        Me.lblTire.Size = New System.Drawing.Size(78, 25)
        Me.lblTire.TabIndex = 1
        Me.lblTire.Text = "$15.00"
        '
        'radTire
        '
        Me.radTire.AutoSize = True
        Me.radTire.Location = New System.Drawing.Point(14, 35)
        Me.radTire.Margin = New System.Windows.Forms.Padding(6)
        Me.radTire.Name = "radTire"
        Me.radTire.Size = New System.Drawing.Size(166, 29)
        Me.radTire.TabIndex = 0
        Me.radTire.TabStop = True
        Me.radTire.Text = "Tire Rotation"
        Me.radTire.UseVisualStyleBackColor = True
        '
        'grpCarWash
        '
        Me.grpCarWash.Controls.Add(Me.lblDeluxe)
        Me.grpCarWash.Controls.Add(Me.lblStandard)
        Me.grpCarWash.Controls.Add(Me.radDeluxe)
        Me.grpCarWash.Controls.Add(Me.radStandard)
        Me.grpCarWash.Location = New System.Drawing.Point(486, 154)
        Me.grpCarWash.Margin = New System.Windows.Forms.Padding(6)
        Me.grpCarWash.Name = "grpCarWash"
        Me.grpCarWash.Padding = New System.Windows.Forms.Padding(6)
        Me.grpCarWash.Size = New System.Drawing.Size(450, 121)
        Me.grpCarWash.TabIndex = 2
        Me.grpCarWash.TabStop = False
        Me.grpCarWash.Text = "Car Wash:"
        '
        'lblDeluxe
        '
        Me.lblDeluxe.AutoSize = True
        Me.lblDeluxe.Location = New System.Drawing.Point(360, 77)
        Me.lblDeluxe.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblDeluxe.Name = "lblDeluxe"
        Me.lblDeluxe.Size = New System.Drawing.Size(78, 25)
        Me.lblDeluxe.TabIndex = 3
        Me.lblDeluxe.Text = "$13.75"
        '
        'lblStandard
        '
        Me.lblStandard.AutoSize = True
        Me.lblStandard.Location = New System.Drawing.Point(360, 35)
        Me.lblStandard.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblStandard.Name = "lblStandard"
        Me.lblStandard.Size = New System.Drawing.Size(66, 25)
        Me.lblStandard.TabIndex = 2
        Me.lblStandard.Text = "$9.75"
        '
        'radDeluxe
        '
        Me.radDeluxe.AutoSize = True
        Me.radDeluxe.Location = New System.Drawing.Point(14, 77)
        Me.radDeluxe.Margin = New System.Windows.Forms.Padding(6)
        Me.radDeluxe.Name = "radDeluxe"
        Me.radDeluxe.Size = New System.Drawing.Size(211, 29)
        Me.radDeluxe.TabIndex = 1
        Me.radDeluxe.TabStop = True
        Me.radDeluxe.Text = "Deluxe Car Wash"
        Me.radDeluxe.UseVisualStyleBackColor = True
        '
        'radStandard
        '
        Me.radStandard.AutoSize = True
        Me.radStandard.Location = New System.Drawing.Point(14, 35)
        Me.radStandard.Margin = New System.Windows.Forms.Padding(6)
        Me.radStandard.Name = "radStandard"
        Me.radStandard.Size = New System.Drawing.Size(231, 29)
        Me.radStandard.TabIndex = 0
        Me.radStandard.TabStop = True
        Me.radStandard.Text = "Standard Car Wash"
        Me.radStandard.UseVisualStyleBackColor = True
        '
        'grpDetail
        '
        Me.grpDetail.Controls.Add(Me.chkComplete)
        Me.grpDetail.Controls.Add(Me.chkExterior)
        Me.grpDetail.Controls.Add(Me.chkInterior)
        Me.grpDetail.Controls.Add(Me.lblComplete)
        Me.grpDetail.Controls.Add(Me.lblExterior)
        Me.grpDetail.Controls.Add(Me.lblInterior)
        Me.grpDetail.Location = New System.Drawing.Point(24, 246)
        Me.grpDetail.Margin = New System.Windows.Forms.Padding(6)
        Me.grpDetail.Name = "grpDetail"
        Me.grpDetail.Padding = New System.Windows.Forms.Padding(6)
        Me.grpDetail.Size = New System.Drawing.Size(450, 165)
        Me.grpDetail.TabIndex = 3
        Me.grpDetail.TabStop = False
        Me.grpDetail.Text = "Detailing:"
        '
        'chkComplete
        '
        Me.chkComplete.AutoSize = True
        Me.chkComplete.Location = New System.Drawing.Point(10, 126)
        Me.chkComplete.Name = "chkComplete"
        Me.chkComplete.Size = New System.Drawing.Size(225, 29)
        Me.chkComplete.TabIndex = 8
        Me.chkComplete.Text = "Complete Detailing"
        Me.chkComplete.UseVisualStyleBackColor = True
        '
        'chkExterior
        '
        Me.chkExterior.AutoSize = True
        Me.chkExterior.Location = New System.Drawing.Point(10, 82)
        Me.chkExterior.Name = "chkExterior"
        Me.chkExterior.Size = New System.Drawing.Size(208, 29)
        Me.chkExterior.TabIndex = 7
        Me.chkExterior.Text = "Exterior Detailing"
        Me.chkExterior.UseVisualStyleBackColor = True
        '
        'chkInterior
        '
        Me.chkInterior.AutoSize = True
        Me.chkInterior.Location = New System.Drawing.Point(12, 41)
        Me.chkInterior.Name = "chkInterior"
        Me.chkInterior.Size = New System.Drawing.Size(200, 29)
        Me.chkInterior.TabIndex = 6
        Me.chkInterior.Text = "Interior Detailing"
        Me.chkInterior.UseVisualStyleBackColor = True
        '
        'lblComplete
        '
        Me.lblComplete.AutoSize = True
        Me.lblComplete.Location = New System.Drawing.Point(364, 125)
        Me.lblComplete.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblComplete.Name = "lblComplete"
        Me.lblComplete.Size = New System.Drawing.Size(78, 25)
        Me.lblComplete.TabIndex = 5
        Me.lblComplete.Text = "$42.00"
        '
        'lblExterior
        '
        Me.lblExterior.AutoSize = True
        Me.lblExterior.Location = New System.Drawing.Point(364, 81)
        Me.lblExterior.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblExterior.Name = "lblExterior"
        Me.lblExterior.Size = New System.Drawing.Size(78, 25)
        Me.lblExterior.TabIndex = 4
        Me.lblExterior.Text = "$25.00"
        '
        'lblInterior
        '
        Me.lblInterior.AutoSize = True
        Me.lblInterior.Location = New System.Drawing.Point(364, 40)
        Me.lblInterior.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblInterior.Name = "lblInterior"
        Me.lblInterior.Size = New System.Drawing.Size(78, 25)
        Me.lblInterior.TabIndex = 3
        Me.lblInterior.Text = "$22.50"
        '
        'grpOilChange
        '
        Me.grpOilChange.Controls.Add(Me.lblSynthetic)
        Me.grpOilChange.Controls.Add(Me.lblStandardOil)
        Me.grpOilChange.Controls.Add(Me.radSynthetic)
        Me.grpOilChange.Controls.Add(Me.radStandardOil)
        Me.grpOilChange.Location = New System.Drawing.Point(486, 287)
        Me.grpOilChange.Margin = New System.Windows.Forms.Padding(6)
        Me.grpOilChange.Name = "grpOilChange"
        Me.grpOilChange.Padding = New System.Windows.Forms.Padding(6)
        Me.grpOilChange.Size = New System.Drawing.Size(450, 125)
        Me.grpOilChange.TabIndex = 4
        Me.grpOilChange.TabStop = False
        Me.grpOilChange.Text = "Oil Change:"
        '
        'lblSynthetic
        '
        Me.lblSynthetic.AutoSize = True
        Me.lblSynthetic.Location = New System.Drawing.Point(360, 85)
        Me.lblSynthetic.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblSynthetic.Name = "lblSynthetic"
        Me.lblSynthetic.Size = New System.Drawing.Size(78, 25)
        Me.lblSynthetic.TabIndex = 4
        Me.lblSynthetic.Text = "$29.99"
        '
        'lblStandardOil
        '
        Me.lblStandardOil.AutoSize = True
        Me.lblStandardOil.Location = New System.Drawing.Point(360, 42)
        Me.lblStandardOil.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblStandardOil.Name = "lblStandardOil"
        Me.lblStandardOil.Size = New System.Drawing.Size(78, 25)
        Me.lblStandardOil.TabIndex = 2
        Me.lblStandardOil.Text = "$19.99"
        '
        'radSynthetic
        '
        Me.radSynthetic.AutoSize = True
        Me.radSynthetic.Location = New System.Drawing.Point(14, 83)
        Me.radSynthetic.Margin = New System.Windows.Forms.Padding(6)
        Me.radSynthetic.Name = "radSynthetic"
        Me.radSynthetic.Size = New System.Drawing.Size(245, 29)
        Me.radSynthetic.TabIndex = 1
        Me.radSynthetic.TabStop = True
        Me.radSynthetic.Text = "Synthetic Oil Change"
        Me.radSynthetic.UseVisualStyleBackColor = True
        '
        'radStandardOil
        '
        Me.radStandardOil.AutoSize = True
        Me.radStandardOil.Location = New System.Drawing.Point(14, 38)
        Me.radStandardOil.Margin = New System.Windows.Forms.Padding(6)
        Me.radStandardOil.Name = "radStandardOil"
        Me.radStandardOil.Size = New System.Drawing.Size(243, 29)
        Me.radStandardOil.TabIndex = 0
        Me.radStandardOil.TabStop = True
        Me.radStandardOil.Text = "Standard Oil Change"
        Me.radStandardOil.UseVisualStyleBackColor = True
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(24, 510)
        Me.btnGenerate.Margin = New System.Windows.Forms.Padding(6)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(450, 96)
        Me.btnGenerate.TabIndex = 5
        Me.btnGenerate.Text = "Generate Invoice"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(486, 510)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(6)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(450, 96)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'chkGift
        '
        Me.chkGift.AutoSize = True
        Me.chkGift.Location = New System.Drawing.Point(36, 415)
        Me.chkGift.Margin = New System.Windows.Forms.Padding(6)
        Me.chkGift.Name = "chkGift"
        Me.chkGift.Size = New System.Drawing.Size(180, 29)
        Me.chkGift.TabIndex = 7
        Me.chkGift.Text = "Gift Certificate"
        Me.chkGift.UseVisualStyleBackColor = True
        '
        'txtGift
        '
        Me.txtGift.Enabled = False
        Me.txtGift.Location = New System.Drawing.Point(36, 460)
        Me.txtGift.Margin = New System.Windows.Forms.Padding(6)
        Me.txtGift.Name = "txtGift"
        Me.txtGift.Size = New System.Drawing.Size(196, 31)
        Me.txtGift.TabIndex = 8
        Me.txtGift.Text = "0"
        '
        'chkDiscount
        '
        Me.chkDiscount.AutoSize = True
        Me.chkDiscount.Location = New System.Drawing.Point(500, 415)
        Me.chkDiscount.Margin = New System.Windows.Forms.Padding(6)
        Me.chkDiscount.Name = "chkDiscount"
        Me.chkDiscount.Size = New System.Drawing.Size(128, 29)
        Me.chkDiscount.TabIndex = 9
        Me.chkDiscount.Text = "Discount"
        Me.chkDiscount.UseVisualStyleBackColor = True
        '
        'txtDiscount
        '
        Me.txtDiscount.Enabled = False
        Me.txtDiscount.Location = New System.Drawing.Point(500, 460)
        Me.txtDiscount.Margin = New System.Windows.Forms.Padding(6)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(196, 31)
        Me.txtDiscount.TabIndex = 10
        Me.txtDiscount.Text = "0"
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'frmMDIChild
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 616)
        Me.Controls.Add(Me.txtDiscount)
        Me.Controls.Add(Me.chkDiscount)
        Me.Controls.Add(Me.txtGift)
        Me.Controls.Add(Me.chkGift)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.grpOilChange)
        Me.Controls.Add(Me.grpDetail)
        Me.Controls.Add(Me.grpCarWash)
        Me.Controls.Add(Me.grpTires)
        Me.Controls.Add(Me.grpCustInfo)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "frmMDIChild"
        Me.Text = "frmMDIChild"
        Me.grpCustInfo.ResumeLayout(False)
        Me.grpCustInfo.PerformLayout()
        Me.grpTires.ResumeLayout(False)
        Me.grpTires.PerformLayout()
        Me.grpCarWash.ResumeLayout(False)
        Me.grpCarWash.PerformLayout()
        Me.grpDetail.ResumeLayout(False)
        Me.grpDetail.PerformLayout()
        Me.grpOilChange.ResumeLayout(False)
        Me.grpOilChange.PerformLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpCustInfo As GroupBox
    Friend WithEvents lblCustID As Label
    Friend WithEvents lblPhoneNo As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblMiddleInitial As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtCustID As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtMI As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents grpTires As GroupBox
    Friend WithEvents lblTire As Label
    Friend WithEvents radTire As RadioButton
    Friend WithEvents grpCarWash As GroupBox
    Friend WithEvents lblDeluxe As Label
    Friend WithEvents lblStandard As Label
    Friend WithEvents radDeluxe As RadioButton
    Friend WithEvents radStandard As RadioButton
    Friend WithEvents grpDetail As GroupBox
    Friend WithEvents lblComplete As Label
    Friend WithEvents lblExterior As Label
    Friend WithEvents lblInterior As Label
    Friend WithEvents grpOilChange As GroupBox
    Friend WithEvents lblSynthetic As Label
    Friend WithEvents lblStandardOil As Label
    Friend WithEvents radSynthetic As RadioButton
    Friend WithEvents radStandardOil As RadioButton
    Friend WithEvents btnGenerate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents chkGift As CheckBox
    Friend WithEvents txtGift As TextBox
    Friend WithEvents chkDiscount As CheckBox
    Friend WithEvents txtDiscount As TextBox
    Friend WithEvents txtPhoneNo As MaskedTextBox
    Friend WithEvents ErrorProvider As ErrorProvider
    Friend WithEvents chkComplete As CheckBox
    Friend WithEvents chkExterior As CheckBox
    Friend WithEvents chkInterior As CheckBox
End Class
