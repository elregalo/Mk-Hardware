Public Class Form1
    REM declare PI as global and intialize with pi
    Const PI As Double = Math.PI

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Try
            REM declare tank shape var and assign as string
            Dim tankShape As String = cmbTankShape.Text
            Dim tankHeight, tankRadius, tankVolume As Double

            If tankShape.Length = 0 Then
                MessageBox.Show("SHAPE ERROR: invalid data passed, please select tank shape", "VALUE ERROR!")
            Else
                If Double.TryParse(txtTankHeight.Text, tankHeight) Then
                    If Double.TryParse(txtTankRadius.Text, tankRadius) Then
                        REM check tank shape
                        If tankShape = "Cone" Then
                            REM calculate cylinder volume
                            tankVolume = PI * (tankRadius * tankRadius) / tankHeight * 3
                        Else
                            REM calculate cylinder volume
                            tankVolume = PI * (tankRadius * tankRadius) / tankHeight
                        End If
                        REM output tank volume
                        rtbTankDetails.Text = String.Format("Tank Shape : {0}" & vbNewLine & vbNewLine & "Tank Height: {1} " & vbNewLine & vbNewLine & "Tank Radius: {2}" & vbNewLine & vbNewLine & "Tank Volume (Liter's) : {3}", tankShape, tankHeight, tankRadius, tankVolume.ToString("#.00"))
                    Else
                        MessageBox.Show("RADIUS ERROR: invalid data passed, please enter numeric value", "VALUE ERROR!")
                    End If
                Else
                    MessageBox.Show("HEIGHT ERROR: invalid data passed, please enter numeric value", "VALUE ERROR!")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("CALCULATE ERROR, failed to calculate volume try again", "Error!")
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cmbTankShape.Text = ""
        txtTankHeight.Text = ""
        txtTankRadius.Text = ""
        rtbTankDetails.Text = "Tank Shape : " & vbNewLine & vbNewLine & "Tank Height : " & vbNewLine & vbNewLine & "Tank Radius : "
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim existStatus As DialogResult = MessageBox.Show("Are you sure you want to exit ?", "Warning", MessageBoxButtons.YesNo)

        If existStatus = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

End Class
