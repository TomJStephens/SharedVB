Public Class PlanetWeight


    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' Calculate weight after pressing DISPLAY-----------------------------------------------------
        'Calculates Cost
        Dim decWeight As Decimal
        Dim decPounds As Decimal
        Dim decKg As Decimal
        Dim decVenusLb As Decimal = 0.907D
        Dim decMarsLb As Decimal = 0.377D
        Dim decConvertKg As Decimal = 0.454D



        If IsNumeric(txtWeight.Text) Then
            decWeight = Convert.ToDecimal(txtWeight.Text)
            'solve for lbs
            If decWeight > 0 Then
                If radVenus.Checked Then
                    decPounds = decVenusLb * decWeight
                ElseIf radMars.Checked Then
                    decPounds = decMarsLb * decWeight
                End If

                'solve for kg
                decKg = decPounds * decConvertKg

                'Round to 1 decimal, convert to string, and put into label
                lblResultKg.Text = decKg.ToString("n1")
                lblResultPound.Text = decPounds.ToString("n1")

                ' ALTERNATE CODE FOR ABOVE 2 LINES
                'round to 1 decimal place
                '              decPounds = Decimal.Round(decPounds, 1)
                '              decKg = Decimal.Round(decKg, 1)
                '
                'convert dec to string
                '               Dim p As String = System.Convert.ToString(decPounds)
                '               Dim k As String = System.Convert.ToString(decKg)
                '
                ' put string into label
                '               lblResultPound.Text = p
                '               lblResultKg.Text = k


                ' Make Labels Visible
                Me.lblResultKg.Visible = True
                Me.lblResultPound.Visible = True

            Else
                'Display Error Message
                MsgBox("You Entered " & decWeight.ToString() & " Enter a positive number.", , "Input Error")
                txtWeight.Text = ""
                txtWeight.Focus()
            End If



        Else
            'Not Numeric
            MsgBox("Enter your weight in Earth pounds as a numeric value.", , "Input Error")
            txtWeight.Text = ""
            txtWeight.Focus()
        End If
        ' DISPLAY BUTTON -----------------------------------------------------------------------------
    End Sub
    ' CLEAR BUTTON -----------------------------------------------------------------------------
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clears weight results and resets radio buttons------------------------------------------
        txtWeight.Clear()
        lblResultKg.Text = ""
        lblResultPound.Text = ""
        radVenus.Checked = False
        radMars.Checked = False
    End Sub
    ' CLEAR BUTTON -----------------------------------------------------------------------------
    Private Sub PlanetWeight_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        txtWeight.Focus()
        lblResultPound.Text = ""
        lblResultKg.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        '------------------------------------------- Closes if user answers yes----------------
        Dim Response As Integer
        Response = MessageBox.Show("You need to go masturbate instead?", "",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Response = vbYes Then
            Me.Close()
        End If
        '------------------------------------------- Closes if user answers yes----------------

    End Sub
End Class
