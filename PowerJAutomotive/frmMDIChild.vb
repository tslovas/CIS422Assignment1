'------------------------------------------------------------
'-                File Name : frmMDIChild.frm               - 
'-                Part of Project: Assign1                  -
'------------------------------------------------------------
'-                Written By: Todd Lovas III                -
'-                Written On: 9/4/2019                      -
'------------------------------------------------------------
'- File Purpose:                                            -
'- This file contains the code for the child form. This form-
'- does everything, it controls all the functions of the    -
'- form, does all the math for the invoice, error checks the-
'- form and generates the invoice in a lstbox on a form.    -
'------------------------------------------------------------
Imports System.ComponentModel

Public Class frmMDIChild

    Const dblSynthetic As Double = 29.99
    Const dblStandardOil As Double = 19.99
    Const dblDeluxe As Double = 13.75
    Const dblStandard As Double = 9.75
    Const dblTire As Double = 15.0
    Const dblInterior As Double = 22.5
    Const dblExterior As Double = 25.0
    Const dblComplete As Double = 42.0
    '------------------------------------------------------------
    '-                Subprogram Name: Errors                   -
    '------------------------------------------------------------
    '-                Written By: Todd Lovas III                -
    '-                Written On: 9/4/2019                      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This is uses our error provider, and sets alerts if      -
    '- entered data is invalid.                                 -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Sub Errors()
        If (IsNumeric(txtFirstName.Text)) Then
            ErrorProvider.SetError(Me.txtFirstName, "Please enter a valid first name")
        End If

        If (IsNumeric(txtMI.Text)) Then
            ErrorProvider.SetError(Me.txtMI, "Please enter a valid middle intital")
        End If

        If (IsNumeric(txtLastName.Text)) Then
            ErrorProvider.SetError(Me.txtLastName, "Please enter a valid last name")
        End If

        If Not (IsNumeric(txtGift.Text)) Then
            ErrorProvider.SetError(Me.txtLastName, "Please enter a total number of gift cards")
        End If

        If Not (IsNumeric(txtDiscount.Text)) Then
            ErrorProvider.SetError(Me.txtLastName, "Please enter a dollar amount in integer form")
        End If
    End Sub
    '------------------------------------------------------------
    '-                Subprogram Name: Computation              -
    '------------------------------------------------------------
    '-                Written By: Todd Lovas III                -
    '-                Written On: 9/4/2019                      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This is another big sub. It is called by generateInvoice -
    '- and sets all of the order details for the invoice.       -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- dblOverallTotal - this is the grand total cost           -
    '- dblTotal - this is the basic total, before tex, gift, etc-
    '- dblTax - this is the total tax of the order              -
    '- intGift - this is the number of gift certificates desired-
    '- intDiscount - this is the total discount to be applied   -
    '------------------------------------------------------------
    Sub Computation()
        Dim dblOverallTotal As Double
        Dim dblTotal As Double
        Dim dblTax As Double
        Dim intGift As Integer
        Dim intDiscount As Integer

        If radTire.Checked = True Then
            dblTotal += dblTire
            frmInvoice.lstInvoice.Items.Add("Tire Rotation: " & FormatCurrency(dblTire))
        End If

        If radStandard.Checked = True Then
            radDeluxe.Visible = False
            dblTotal += dblStandard
            frmInvoice.lstInvoice.Items.Add("Standard Car Wash: " & FormatCurrency(dblStandard))
        End If

        If radDeluxe.Checked = True Then
            radStandard.Visible = False
            dblTotal += dblDeluxe
            frmInvoice.lstInvoice.Items.Add("Deluxe Car Wash: " & FormatCurrency(dblDeluxe))
        End If

        If chkInterior.Checked = True Then
            dblTotal += dblInterior
            frmInvoice.lstInvoice.Items.Add("Interior Detailing" & FormatCurrency(dblInterior))
        End If

        If chkExterior.Checked = True Then
            grpCarWash.Visible = False
            dblTotal += dblExterior
            frmInvoice.lstInvoice.Items.Add("Exterior Detailing and Car Wash" & FormatCurrency(dblExterior))
        End If

        If chkInterior.Checked And chkExterior.Checked = True Then
            dblTotal += dblComplete
        End If

        If chkComplete.Checked = True Then
            grpCarWash.Visible = False
            dblTotal += dblComplete
            frmInvoice.lstInvoice.Items.Add("Complete Detailing and Car Wash: " & FormatCurrency(dblComplete))
        End If

        If radSynthetic.Checked = True Then
            radStandardOil.Visible = False
            dblTotal += dblSynthetic
            frmInvoice.lstInvoice.Items.Add("Synthetic Oil Change: " & FormatCurrency(dblSynthetic))
        End If

        If radStandardOil.Checked = True Then
            radSynthetic.Visible = False
            dblTotal += dblStandardOil
            frmInvoice.lstInvoice.Items.Add("Standard Oil Change: " & FormatCurrency(dblStandardOil))
        End If

        frmInvoice.lstInvoice.Items.Add("--------------------------------------------------------------------")
        If chkGift.Checked = True Then
            intGift = txtGift.Text
            dblTotal *= intGift
            frmInvoice.lstInvoice.Items.Add("Gift Card: " & "Yes: " & txtGift.Text)
        ElseIf frmInvoice.lstInvoice.Items.Add("Gift Card: " & "No") Then
        End If

        If chkDiscount.Checked = True Then
            intDiscount = txtDiscount.Text
            dblTotal -= intDiscount
            frmInvoice.lstInvoice.Items.Add("Discount: " & "Yes: " & FormatCurrency(txtDiscount.Text))
        ElseIf frmInvoice.lstInvoice.Items.Add("Discount: " & "No") Then
        End If

        dblTax = (dblTotal * 0.06)
        dblOverallTotal = dblTotal + dblTax
        frmInvoice.lstInvoice.Items.Add("Total: " & FormatCurrency(dblOverallTotal))

    End Sub
    '------------------------------------------------------------
    '-                Subprogram Name: btnGenerate_Click        -
    '------------------------------------------------------------
    '-                Written By: Todd Lovas III                -
    '-                Written On: 9/4/2019                      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This is the big sub. When the generate button is clicked -
    '- every sub is called in order to process and create the   -
    '- invoice. After that, it shows the invoice.               -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Errors()
        generateInvoice()
        Computation()
        frmInvoice.Show()
    End Sub
    '------------------------------------------------------------
    '-                Subprogram Name: chkDiscount_Click        -
    '------------------------------------------------------------
    '-                Written By: Todd Lovas III                -
    '-                Written On: 9/4/2019                      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This resets the form to whatever error-checking is needed-
    '- based on the discount checkbox. It also resets the form  -
    '- to normal if they decide they do not want a discount     -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub chkDiscount_Click(sender As Object, e As EventArgs) Handles chkDiscount.Click
        If chkDiscount.Checked = True Then
            txtDiscount.Enabled = True
        Else txtDiscount.Enabled = False
            txtDiscount.Clear()
            txtDiscount.Text = 0
        End If
    End Sub
    '------------------------------------------------------------
    '-                Subprogram Name: chkGift_Click            -
    '------------------------------------------------------------
    '-                Written By: Todd Lovas III                -
    '-                Written On: 9/4/2019                      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This resets the form to whatever error-checking is needed-
    '- based on the gift certificate checkbox. It also resets   -
    '- the form to normal if they decide they do not want       -
    '- a gift certificate.                                      -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub chkGift_Click(sender As Object, e As EventArgs) Handles chkGift.Click
        If chkGift.Checked = True Then
            txtGift.Enabled = True
        Else txtGift.Enabled = False
            txtGift.Clear()
            txtGift.Text = 0
        End If
    End Sub
    '------------------------------------------------------------
    '-                Subprogram Name: txtPhoneNo_TextChanged   -
    '------------------------------------------------------------
    '-                Written By: Todd Lovas III                -
    '-                Written On: 9/4/2019                      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub is how I create my customer id. It looks at the -
    '- phone number text box and uses a substring to make the id-
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub txtPhoneNo_TextChanged(sender As Object, e As EventArgs) Handles txtPhoneNo.TextChanged
        If (txtPhoneNo.Text.Length >= 7) Then
            txtCustID.Text = txtPhoneNo.Text.Substring(txtPhoneNo.Text.Length - 7)
        End If
    End Sub
    '------------------------------------------------------------
    '-                Subprogram Name: chkExterior_Click        -
    '------------------------------------------------------------
    '-                Written By: Todd Lovas III                -
    '-                Written On: 9/4/2019                      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This resets the form to whatever error-checking is needed-
    '- based on the interior detailing checkbox. It also resets -
    '- the form to normal if they decide they do not want       -
    '- interior detailing.                                      -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub chkInterior_Click(sender As Object, e As EventArgs) Handles chkInterior.Click
        If chkExterior.Checked = True Then
            chkExterior.Visible = False
            chkInterior.Visible = False
            chkComplete.Checked = True
        End If

        If chkExterior.Checked = False Then
            grpCarWash.Visible = True
        End If
    End Sub
    '------------------------------------------------------------
    '-                Subprogram Name: chkExterior_Click        -
    '------------------------------------------------------------
    '-                Written By: Todd Lovas III                -
    '-                Written On: 9/4/2019                      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This resets the form to whatever error-checking is needed-
    '- based on the exterior detailing checkbox. It also resets -
    '- the form to normal if they decide they do not want       -
    '- exterior detailing.                                      -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub chkExterior_Click(sender As Object, e As EventArgs) Handles chkExterior.Click
        grpCarWash.Visible = False
        radDeluxe.Checked = False
        radStandard.Checked = False
        If chkInterior.Checked = True Then
            chkInterior.Visible = False
            chkExterior.Visible = False
            chkComplete.Checked = True
        End If

        If chkExterior.Checked = False Then
            grpCarWash.Visible = True
        End If
    End Sub
    '------------------------------------------------------------
    '-                Subprogram Name: chkComplete_Click        -
    '------------------------------------------------------------
    '-                Written By: Todd Lovas III                -
    '-                Written On: 9/4/2019                      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This resets the form to whatever error-checking is needed-
    '- based on the complete detailing checkbox. It also resets -
    '- the form to normal if they decide they do not want       -
    '- complete detailing.                                      -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub chkComplete_Click(sender As Object, e As EventArgs) Handles chkComplete.Click
        If chkComplete.Checked = True Then
            grpCarWash.Visible = False
            radDeluxe.Checked = False
            radStandard.Checked = False
            chkInterior.Checked = False
            chkExterior.Checked = False
            chkInterior.Visible = False
            chkExterior.Visible = False
        End If

        If chkComplete.Checked = False Then
            grpCarWash.Visible = True
            radDeluxe.Checked = False
            radStandard.Checked = False
            chkInterior.Checked = False
            chkExterior.Checked = False
            chkInterior.Visible = True
            chkExterior.Visible = True
        End If
    End Sub
    '------------------------------------------------------------
    '-                Subprogram Name: btnClear_Click           -
    '------------------------------------------------------------
    '-                Written By: Todd Lovas III                -
    '-                Written On: 9/4/2019                      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub clears the form when the button is clicked.     -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFirstName.Clear()
        txtMI.Clear()
        txtLastName.Clear()
        txtPhoneNo.Clear()
        radTire.Checked = False
        radStandard.Checked = False
        radDeluxe.Checked = False
        chkInterior.Checked = False
        chkExterior.Checked = False
        chkComplete.Checked = False
        radSynthetic.Checked = False
        radStandardOil.Checked = False
        chkGift.Checked = False
        chkDiscount.Checked = False
        txtGift.Enabled = False
        txtDiscount.Enabled = False
        txtGift.Text = 0
        txtDiscount.Text = 0
    End Sub
    '------------------------------------------------------------
    '-                Subprogram Name: generateInvoice          -
    '------------------------------------------------------------
    '-                Written By: Todd Lovas III                -
    '-                Written On: 9/4/2019                      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub creates the beginning of the invoice, front     –
    '- loading client information.                              -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- strFullName - a string to pull the clients name together -
    '------------------------------------------------------------
    Sub generateInvoice()
        Dim strFullName As String

        strFullName = (txtFirstName.Text & " " & txtMI.Text & " " & txtLastName.Text)

        frmInvoice.lstInvoice.Items.Add("PowerJAutomotive")
        frmInvoice.lstInvoice.Items.Add("--------------------------------------------------------------------")
        frmInvoice.lstInvoice.Items.Add("Name: " & strFullName)
        frmInvoice.lstInvoice.Items.Add("Phone Number: " & txtPhoneNo.Text)
        frmInvoice.lstInvoice.Items.Add("Customer ID: " & txtCustID.Text)
        frmInvoice.lstInvoice.Items.Add("--------------------------------------------------------------------")
    End Sub
    '------------------------------------------------------------
    '-                Subprogram Name: frmMDIChild_Closing      -
    '------------------------------------------------------------
    '-                Written By: Todd Lovas III                -
    '-                Written On: 9/4/2019                      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the program starts    -
    '- closing. The program will prompt if the user really wants–
    '- to quit, and if the user clicks Yes, the program will    -
    '- terminate.  If the user click No, the program will       -
    '- continue to run.                                         –                                                    -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub frmMDIChild_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If MessageBox.Show("Are you sure you want to quit?", "", MessageBoxButtons.YesNo) = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
End Class