'------------------------------------------------------------
'-                File Name : Form1.frm                     - 
'-                Part of Project: Assign1                  -
'------------------------------------------------------------
'-                Written By: Todd Lovas III                -
'-                Written On: 9/4/2019                      -
'------------------------------------------------------------
'- File Purpose:                                            -
'- This file contains the main application form where the   -
'- user can create a new form, exit the application, view   -
'- the forms in a window list, and view the about form.     -
'------------------------------------------------------------
'- Program Purpose:                                         -
'-                                                          -
'- This program is for PowerJAutomotive, so they can have a -
'- new and improved billing system to make things easier on -
'- employees and clients.                                   -
'------------------------------------------------------------
Public Class frmMDIParent
    '------------------------------------------------------------
    '-                Subprogram Name: mnuFileNew_Click         -
    '------------------------------------------------------------
    '-                Written By: Todd Lovas III                -
    '-                Written On: 9/4/2019                      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -  
    '- This subroutine is called whenever the user clicks the   -
    '- mnuFileNew button.  The program will create a new child  –
    '- form, and show the form                                  -
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- aNewChildForm - the new instance of child form           -
    '------------------------------------------------------------
    Private Sub mnuFileNew_Click(sender As Object, e As EventArgs) Handles mnuFileNew.Click

        Dim aNewChildForm As frmMDIChild = New frmMDIChild()
        aNewChildForm.MdiParent = Me
        aNewChildForm.Show()

    End Sub
    '------------------------------------------------------------
    '-                Subprogram Name: mnuHelpAbout_Click       -
    '------------------------------------------------------------
    '-                Written By: Todd Lovas III                -
    '-                Written On: 9/4/2019                      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -  
    '- This subroutine is called whenever the user clicks the   -
    '- mnuHelpAbout button.  The program shows the about form.  –
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub mnuHelpAbout_Click(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click
        frmAbout.ShowDialog()
    End Sub
    '------------------------------------------------------------
    '-                Subprogram Name: mnuFileExit_Click        -
    '------------------------------------------------------------
    '-                Written By: Todd Lovas III                -
    '-                Written On: 9/4/2019                      -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -  
    '- This subroutine is called whenever the user clicks the   -
    '- mnuFileExit button.  The program closes down.            –
    '------------------------------------------------------------
    '- Parameter Dictionary (in parameter order):               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary (alphabetically):              -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        Me.Close()
    End Sub
    '------------------------------------------------------------
    '-                Subprogram Name: frmMDIParent_FormClosing -
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
    Private Sub frmMDIParent_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Are you sure you want to quit?", "",
            MessageBoxButtons.YesNo) = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
End Class