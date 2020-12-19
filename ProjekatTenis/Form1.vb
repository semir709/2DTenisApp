Public Class Form1
    Dim moveRightBall As Boolean
    Dim MoveUpBall As Boolean

    Dim racketSpeed As Integer = 3

    Dim ballSpeed As Integer = 5

    Dim racket1UP As Boolean
    Dim racket2Up As Boolean
    Dim racket1Down As Boolean
    Dim racket2Down As Boolean

    'Ovo su nam varijable koje prate da li je specijalni potez pritisnut

    'Za igraca 1
    Dim p1s1 As Boolean 'p1 - Player1; s1 - spevijalni potez 1
    Dim p1s2 As Boolean

    'Za igraca 2
    Dim p2s1 As Boolean
    Dim p2s2 As Boolean


    ' Brojanje sekunde zaledenog reketa
    Dim sekunde1 As Integer = 0
    Dim sekunde2 As Integer = 0


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2

        lopta.Top = Teren.Height / 2
        lopta.Left = Teren.Width / 2

        ComboBoxLopta.SelectedIndex = 0
        ComboBoxReket.SelectedIndex = 0
        ComboBoxVLopte.SelectedIndex = 1


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        racketMoving()

        speedBall()

        ballCrashSides()

        detectionCrashInRacket()

        rezultat()

    End Sub

    Sub racketMoving()
        If racket1UP = True And Reket1.Top >= Teren.Top Then
            Reket1.Top -= racketSpeed
        End If
        If racket1Down = True And Reket1.Top + Reket1.Height <= Teren.Height Then
            Reket1.Top += racketSpeed
        End If
        If racket2Up = True And Reket2.Top >= Teren.Top Then
            Reket2.Top -= racketSpeed
        End If
        If racket2Down = True And Reket2.Top + Reket2.Height <= Teren.Height Then
            Reket2.Top += racketSpeed

        End If
    End Sub

    '----------------------------------------------------------------------------------------------------------------------------------
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyValue = Keys.Up Then
            racket2Up = True
            racket2Down = False
        End If

        If e.KeyValue = Keys.Down Then
            racket2Down = True
            racket2Up = False
        End If

        If e.KeyValue = Keys.W Then
            racket1UP = True
            racket1Down = False
            'e.SuppressKeyPress = True ' da se ne desava beep kad pritisnem dugme
        End If

        If e.KeyValue = Keys.S Then
            racket1Down = True
            racket1UP = False
            'e.SuppressKeyPress = True ' da se ne desava beep kad pritisnem dugme
        End If

        If e.KeyValue = Keys.P Then

            If Timer1.Enabled Then
                Timer1.Stop()
            Else
                Timer1.Start()
            End If

            'e.SuppressKeyPress = True ' da se ne desava beep kad pritisnem dugme
        End If

        If e.KeyValue = Keys.R Then
            restart()
            e.SuppressKeyPress = True
        End If


        'Specijalni potez 1
        If e.KeyValue = Keys.NumPad1 Then

            If p1s1 = False Then
                'LabelDrugi.ForeColor = Color.Red

                LabelPrvi.Text = LabelPrvi.Text - 1
                LabelPrvi.ForeColor = Color.Lime

                'LabelDrugi.Text = LabelDrugi.Text - 1
                'LabelDrugi.ForeColor = Color.Lime

                p1s1 = True
            Else
                e.Handled = True

            End If
            'e.SuppressKeyPress = True

        End If

        If e.KeyValue = Keys.Y Then
            If p2s1 = False Then
                'LabelPrvi.ForeColor = Color.Red
                'LabelPrvi.Text = LabelPrvi.Text - 1
                'LabelPrvi.ForeColor = Color.Lime

                LabelDrugi.Text = LabelDrugi.Text - 1
                LabelDrugi.ForeColor = Color.Lime

                p2s1 = True
            Else
                e.Handled = True

            End If
            'e.SuppressKeyPress = True
        End If

        'Specijalno potez 2

        If e.KeyValue = Keys.NumPad2 Then
            If p1s2 = False Then

                Reket1.Visible = False
                TimerStop1.Start()

                p1s2 = True
            Else
                e.Handled = True

            End If
            'e.SuppressKeyPress = True
        End If

        If e.KeyValue = Keys.X Then
            If p2s2 = False Then

                Reket2.Visible = False
                TimerStop2.Start()

                p2s2 = True
            Else
                e.Handled = True

            End If
            'e.SuppressKeyPress = True
        End If

        e.SuppressKeyPress = True
    End Sub

    '----------------------------------------------------------------------------------------------------------------------------

    Sub ballCrashSides()
        'Za lijevo i desno
        If lopta.Left <= Teren.Left Then
            'moveRightBall = True
            LabelDrugi.Text = LabelDrugi.Text + 1
            lopta.Left = Teren.Width / 2
            lopta.Top = Teren.Height / 2
        ElseIf lopta.Left + lopta.Width >= Teren.Right Then
            'moveRightBall = False
            LabelPrvi.Text = LabelPrvi.Text + 1
            lopta.Left = Teren.Width / 2
            lopta.Top = Teren.Height / 2


        End If


        ' Za gore i dole
        If lopta.Top <= Teren.Top Then
            MoveUpBall = False
        ElseIf lopta.Top + lopta.Height >= Teren.Bottom Then
            MoveUpBall = True
        End If
    End Sub

    Sub speedBall()
        'Za lijevo i desno
        If moveRightBall = True Then
            lopta.Left += ballSpeed
        Else
            lopta.Left -= ballSpeed

        End If

        'Za gore i dole
        If MoveUpBall = True Then
            lopta.Top -= ballSpeed
        Else
            lopta.Top += ballSpeed
        End If
    End Sub

    Sub detectionCrashInRacket()

        If lopta.Left <= Reket1.Left + Reket1.Width And
            lopta.Top <= Reket1.Top + Reket1.Height And
            lopta.Top + lopta.Height >= Reket1.Top And
            lopta.Left + lopta.Width >= Reket1.Left And Reket1.Visible = True Then
            moveRightBall = True
        End If

        If lopta.Left <= Reket2.Left + Reket2.Width And
            lopta.Top <= Reket2.Top + Reket2.Height And
            lopta.Top + lopta.Height >= Reket2.Top And
            lopta.Left + lopta.Width >= Reket2.Left And Reket2.Visible = True Then
            moveRightBall = False
        End If
    End Sub

    Private Sub ButtonStart_Click(sender As Object, e As EventArgs) Handles ButtonStart.Click
        Timer1.Start()
        ComboBoxLopta.Enabled = False
        ComboBoxReket.Enabled = False
        ComboBoxVLopte.Enabled = False
        ButtonStart.Enabled = False
        ButtonContols.Enabled = False
        TextBoxPobjednik.Enabled = False
        ButtonExit.Enabled = False
        p1s1 = False
        p1s2 = False
        p2s1 = False
        p2s2 = False

        If TextBoxPobjednik.Text = "" Then
            TextBoxPobjednik.Text = 10
        End If


    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Me.Close()

    End Sub

    Private Sub ButtonContols_Click(sender As Object, e As EventArgs) Handles ButtonContols.Click
        FormKontrole.Show()

    End Sub

    Private Sub ComboBoxVLopte_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxVLopte.SelectedIndexChanged
        If ComboBoxVLopte.SelectedIndex = 0 Then
            lopta.Width = 22
            lopta.Height = 22
        ElseIf ComboBoxVLopte.SelectedIndex = 1 Then
            lopta.Width = 33
            lopta.Height = 33
        ElseIf ComboBoxVLopte.SelectedIndex = 2 Then
            lopta.Width = 66
            lopta.Height = 66
        Else
            lopta.Width = 33
            lopta.Height = 33
        End If
    End Sub

    Private Sub ComboBoxReket_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxReket.SelectedIndexChanged
        If ComboBoxReket.SelectedIndex = 0 Then
            racketSpeed = 3
        ElseIf ComboBoxReket.SelectedIndex = 1 Then
            racketSpeed = 5
        ElseIf ComboBoxReket.SelectedIndex = 2 Then
            racketSpeed = 7
        Else
            racketSpeed = 3
        End If
    End Sub

    Private Sub ComboBoxLopta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxLopta.SelectedIndexChanged
        If ComboBoxLopta.SelectedIndex = 0 Then
            ballSpeed = 5
        ElseIf ComboBoxLopta.SelectedIndex = 1 Then
            ballSpeed = 8
        ElseIf ComboBoxLopta.SelectedIndex = 2 Then
            ballSpeed = 11
        Else
            ballSpeed = 5
        End If
    End Sub

    Sub rezultat()
        If TextBoxPobjednik.Text = LabelPrvi.Text Then
            Timer1.Stop()
            MsgBox("Pobjednik je Igrac2 !!!!!")

            dopusti()
            defaultt()

        End If

        If TextBoxPobjednik.Text = LabelDrugi.Text Then
            Timer1.Stop()
            MsgBox("Pobjenik je Igrac1!!!!!")

            dopusti()
            defaultt()

        End If


        If Asc(TextBoxPobjednik.Text) < 48 Or Asc(TextBoxPobjednik.Text) > 57 Then
            Timer1.Stop()
            MsgBox("Slova ili karakteri se ne simiju dodavati u ovo Polje!!!")

            dopusti()

        End If

        If LabelPrvi.Text = 10 Then
            LabelPrvi.Left = 280
        ElseIf LabelPrvi.Text = 100 Then
            LabelPrvi.Left = 265
        ElseIf LabelPrvi.Text = 1000 Then
            LabelPrvi.Left = 255
        End If
    End Sub

    Sub dopusti()
        TextBoxPobjednik.Enabled = True
        ComboBoxLopta.Enabled = True
        ComboBoxReket.Enabled = True
        ComboBoxVLopte.Enabled = True
        LabelDrugi.Enabled = True
        LabelPrvi.Enabled = True
        ButtonContols.Enabled = True
        ButtonExit.Enabled = True
        ButtonStart.Enabled = True
    End Sub

    Sub defaultt()
        'TextBoxPobjednik.Text = ""
        ComboBoxLopta.SelectedIndex = 0
        ComboBoxReket.SelectedIndex = 0
        ComboBoxVLopte.SelectedIndex = 1
        LabelDrugi.Text = 0
        LabelPrvi.Text = 0
    End Sub

    Sub restart()

        Timer1.Stop()
        lopta.Left = Teren.Width / 2
        lopta.Top = Teren.Height / 2
        dopusti()
        defaultt()
        p1s1 = False
        p1s2 = False
        p2s1 = False
        p2s2 = False

        Reket1.Visible = True
        Reket2.Visible = True


    End Sub

    Private Sub TimerStop1_Tick(sender As Object, e As EventArgs) Handles TimerStop1.Tick

        If Reket1.Visible = False Then
            sekunde1 += 1
            If sekunde1 = 5 Then
                TimerStop1.Stop()
                sekunde1 = 0
                Reket1.Visible = True

            End If
        End If

    End Sub

    Private Sub TimerStop2_Tick(sender As Object, e As EventArgs) Handles TimerStop2.Tick
        If Reket2.Visible = False Then
            sekunde2 += 1
            If sekunde2 = 5 Then
                TimerStop2.Stop()
                sekunde2 = 0
                Reket2.Visible = True
            End If
        End If
    End Sub

    Private Sub Form1_Leave(sender As Object, e As EventArgs) Handles Me.Leave

    End Sub
End Class
