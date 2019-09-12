<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvoice
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
        Me.lstInvoice = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lstInvoice
        '
        Me.lstInvoice.FormattingEnabled = True
        Me.lstInvoice.ItemHeight = 25
        Me.lstInvoice.Location = New System.Drawing.Point(13, 13)
        Me.lstInvoice.Name = "lstInvoice"
        Me.lstInvoice.Size = New System.Drawing.Size(775, 429)
        Me.lstInvoice.TabIndex = 0
        '
        'frmInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lstInvoice)
        Me.Name = "frmInvoice"
        Me.Text = "frmInvoice"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstInvoice As ListBox
End Class
