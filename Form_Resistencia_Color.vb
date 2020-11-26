Public Class Form_Resistencia_Color
    Private Sub boton_calc_Click(sender As Object, e As EventArgs) Handles boton_calc.Click
        Dim resistencia As String
        Dim cifra1 As Integer
        Dim cifra2 As Integer
        Dim largoRemovido As Integer
        Dim cifra1_conCeros As Integer
        Dim temp As String
        Dim largoDeResistencia As Integer
        Dim multiplicador As Integer
        Dim rNominal As Integer
        Dim tMaxPlata As Integer
        Dim tMinPlata As Integer
        Dim tMaxDorado As Integer
        Dim tMinDorado As Integer
        Dim tMaxClear As Integer
        Dim tMinClear As Integer


        resistencia = input.Text
        If Val(resistencia.Length) = 1 Then
            cifra1 = resistencia
        Else
            cifra1 = resistencia.Remove(resistencia.Length - (Len(resistencia) - 1))
        End If

        If cifra1 = 0 Then
            banda_cifra1.BackColor = Color.Black

        ElseIf cifra1 = 1 Then
            banda_cifra1.BackColor = Color.SaddleBrown

        ElseIf cifra1 = 2 Then
            banda_cifra1.BackColor = Color.Red

        ElseIf cifra1 = 3 Then
            banda_cifra1.BackColor = Color.Orange

        ElseIf cifra1 = 4 Then
            banda_cifra1.BackColor = Color.Yellow

        ElseIf cifra1 = 5 Then
            banda_cifra1.BackColor = Color.Green

        ElseIf cifra1 = 6 Then
            banda_cifra1.BackColor = Color.Blue

        ElseIf cifra1 = 7 Then
            banda_cifra1.BackColor = Color.Purple

        ElseIf cifra1 = 8 Then
            banda_cifra1.BackColor = Color.Gray

        ElseIf cifra1 = 9 Then
            banda_cifra1.BackColor = Color.White
        End If


        If Val(resistencia.Length) = 1 Then
            cifra2 = 0
        Else
            largoRemovido = Len(resistencia) - 1
            cifra1_conCeros = cifra1
            Do
                cifra1_conCeros = cifra1_conCeros * 10
                largoRemovido = largoRemovido - 1
            Loop Until largoRemovido = 0
            temp = resistencia - cifra1_conCeros
            If Val(resistencia.Length) = 2 Then
                cifra2 = temp
            Else
                cifra2 = temp.Remove(temp.Length - (Len(temp) - 1))
            End If
        End If

        If cifra2 = 0 Then
            banda_cifra2.BackColor = Color.Black

        ElseIf cifra2 = 1 Then
            banda_cifra2.BackColor = Color.SaddleBrown

        ElseIf cifra2 = 2 Then
            banda_cifra2.BackColor = Color.Red

        ElseIf cifra2 = 3 Then
            banda_cifra2.BackColor = Color.Orange

        ElseIf cifra2 = 4 Then
            banda_cifra2.BackColor = Color.Yellow

        ElseIf cifra2 = 5 Then
            banda_cifra2.BackColor = Color.Green

        ElseIf cifra2 = 6 Then
            banda_cifra2.BackColor = Color.Blue

        ElseIf cifra2 = 7 Then
            banda_cifra2.BackColor = Color.Purple

        ElseIf cifra2 = 8 Then
            banda_cifra2.BackColor = Color.Gray

        ElseIf cifra2 = 9 Then
            banda_cifra2.BackColor = Color.White
        End If


        largoDeResistencia = Len(resistencia)

        If largoDeResistencia = 2 Then
            banda_multiplicador.BackColor = Color.Black
            multiplicador = 1

        ElseIf largoDeResistencia = 3 Then
            banda_multiplicador.BackColor = Color.SaddleBrown
            multiplicador = 10

        ElseIf largoDeResistencia = 4 Then
            banda_multiplicador.BackColor = Color.Red
            multiplicador = 100

        ElseIf largoDeResistencia = 5 Then
            banda_multiplicador.BackColor = Color.Orange
            multiplicador = 1000

        ElseIf largoDeResistencia = 6 Then
            banda_multiplicador.BackColor = Color.Yellow
            multiplicador = 10000

        ElseIf largoDeResistencia = 7 Then
            banda_multiplicador.BackColor = Color.Green
            multiplicador = 100000

        ElseIf largoDeResistencia = 8 Then
            banda_multiplicador.BackColor = Color.Blue
            multiplicador = 1000000

        ElseIf largoDeResistencia = 9 Then
            banda_multiplicador.BackColor = Color.Purple
            multiplicador = 10000000

        ElseIf largoDeResistencia = 10 Then
            banda_multiplicador.BackColor = Color.Gray
            multiplicador = 100000000

        ElseIf largoDeResistencia = 11 Then
            banda_multiplicador.BackColor = Color.White
            multiplicador = 1000000000
        End If


        rNominal = Val(cifra1 & cifra2) * multiplicador
        tMaxPlata = rNominal * 1.1
        tMinPlata = rNominal * 0.9
        tMaxDorado = rNominal * 1.05
        tMinDorado = rNominal * 0.95
        tMaxClear = rNominal * 1.2
        tMinClear = rNominal * 0.8

        If rNominal >= tMinPlata Or rNominal <= tMaxPlata Then
            banda_tolerancia.BackColor = Color.Silver

        ElseIf rNominal >= tMinDorado Or rNominal <= tMaxDorado Then
            banda_tolerancia.BackColor = Color.Gold

        ElseIf rNominal >= tMinClear Or rNominal <= tMaxClear Then
            banda_tolerancia.BackColor = Color.WhiteSmoke
        End If

    End Sub

    Private Sub boton_reset_Click(sender As Object, e As EventArgs) Handles boton_reset.Click
        input.Text = ""
        banda_cifra1.BackColor = Color.WhiteSmoke
        banda_cifra2.BackColor = Color.WhiteSmoke
        banda_multiplicador.BackColor = Color.WhiteSmoke
        banda_tolerancia.BackColor = Color.WhiteSmoke
    End Sub
End Class
