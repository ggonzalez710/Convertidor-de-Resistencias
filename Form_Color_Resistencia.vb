Public Class Form_Color_Resistencia
    Dim cifra1 As Integer
    Dim cifra2 As Integer
    Dim multiplicador As Double
    Dim tolerancia As Double
    Dim opcion As String

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        opcion = ComboBox1.SelectedItem.ToString()
        If opcion Is "Negro" Then
            banda_cifra1.BackColor = Color.Black
            cifra1 = 0

        ElseIf opcion Is "Marron" Then
            banda_cifra1.BackColor = Color.SaddleBrown
            cifra1 = 1

        ElseIf opcion Is "Rojo" Then
            banda_cifra1.BackColor = Color.Red
            cifra1 = 2

        ElseIf opcion Is "Naranja" Then
            banda_cifra1.BackColor = Color.Orange
            cifra1 = 3

        ElseIf opcion Is "Amarillo" Then
            banda_cifra1.BackColor = Color.Yellow
            cifra1 = 4

        ElseIf opcion Is "Verde" Then
            banda_cifra1.BackColor = Color.Green
            cifra1 = 5

        ElseIf opcion Is "Azul" Then
            banda_cifra1.BackColor = Color.Blue
            cifra1 = 6

        ElseIf opcion Is "Violeta" Then
            banda_cifra1.BackColor = Color.Purple
            cifra1 = 7

        ElseIf opcion Is "Gris" Then
            banda_cifra1.BackColor = Color.Gray
            cifra1 = 8

        ElseIf opcion Is "Blanco" Then
            banda_cifra1.BackColor = Color.White
            cifra1 = 9
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        opcion = ComboBox2.SelectedItem.ToString()
        If opcion Is "Negro" Then
            banda_cifra2.BackColor = Color.Black
            cifra2 = 0

        ElseIf opcion Is "Marron" Then
            banda_cifra2.BackColor = Color.SaddleBrown
            cifra2 = 1

        ElseIf opcion Is "Rojo" Then
            banda_cifra2.BackColor = Color.Red
            cifra2 = 2

        ElseIf opcion Is "Naranja" Then
            banda_cifra2.BackColor = Color.Orange
            cifra2 = 3

        ElseIf opcion Is "Amarillo" Then
            banda_cifra2.BackColor = Color.Yellow
            cifra2 = 4

        ElseIf opcion Is "Verde" Then
            banda_cifra2.BackColor = Color.Green
            cifra2 = 5

        ElseIf opcion Is "Azul" Then
            banda_cifra2.BackColor = Color.Blue
            cifra2 = 6

        ElseIf opcion Is "Violeta" Then
            banda_cifra2.BackColor = Color.Purple
            cifra2 = 7

        ElseIf opcion Is "Gris" Then
            banda_cifra2.BackColor = Color.Gray
            cifra2 = 8

        ElseIf opcion Is "Blanco" Then
            banda_cifra2.BackColor = Color.White
            cifra2 = 9
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        opcion = ComboBox3.SelectedItem.ToString()
        If opcion Is "Negro" Then
            banda_multiplicador.BackColor = Color.Black
            multiplicador = 1

        ElseIf opcion Is "Marron" Then
            banda_multiplicador.BackColor = Color.SaddleBrown
            multiplicador = 10

        ElseIf opcion Is "Rojo" Then
            banda_multiplicador.BackColor = Color.Red
            multiplicador = 100

        ElseIf opcion Is "Naranja" Then
            banda_multiplicador.BackColor = Color.Orange
            multiplicador = 1000

        ElseIf opcion Is "Amarillo" Then
            banda_multiplicador.BackColor = Color.Yellow
            multiplicador = 10000

        ElseIf opcion Is "Verde" Then
            banda_multiplicador.BackColor = Color.Green
            multiplicador = 100000

        ElseIf opcion Is "Azul" Then
            banda_multiplicador.BackColor = Color.Blue
            multiplicador = 1000000

        ElseIf opcion Is "Violeta" Then
            banda_multiplicador.BackColor = Color.Purple
            multiplicador = 10000000

        ElseIf opcion Is "Gris" Then
            banda_multiplicador.BackColor = Color.Gray
            multiplicador = 100000000

        ElseIf opcion Is "Blanco" Then
            banda_multiplicador.BackColor = Color.White
            multiplicador = 1000000000

        ElseIf opcion Is "Dorado" Then
            banda_multiplicador.BackColor = Color.Gold
            multiplicador = 0.1

        ElseIf opcion Is "Plata" Then
            banda_multiplicador.BackColor = Color.Silver
            multiplicador = 0.01
        End If
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        opcion = ComboBox4.SelectedItem.ToString()
        If opcion Is "Negro" Then
            banda_tolerancia.BackColor = Color.Black

        ElseIf opcion Is "Marron" Then
            banda_tolerancia.BackColor = Color.SaddleBrown
            tolerancia = 1 / 100

        ElseIf opcion Is "Rojo" Then
            banda_tolerancia.BackColor = Color.Red
            tolerancia = 2 / 100

        ElseIf opcion Is "Naranja" Then
            banda_tolerancia.BackColor = Color.Orange
            tolerancia = 3 / 100

        ElseIf opcion Is "Amarillo" Then
            banda_tolerancia.BackColor = Color.Yellow
            tolerancia = 4 / 100

        ElseIf opcion Is "Verde" Then
            banda_tolerancia.BackColor = Color.Green
            tolerancia = 0.5 / 100

        ElseIf opcion Is "Azul" Then
            banda_tolerancia.BackColor = Color.Blue
            tolerancia = 0.25 / 100

        ElseIf opcion Is "Violeta" Then
            banda_tolerancia.BackColor = Color.Purple
            tolerancia = 0.1 / 100

        ElseIf opcion Is "Gris" Then
            banda_tolerancia.BackColor = Color.Gray
            tolerancia = 0.05 / 100

        ElseIf opcion Is "Blanco" Then
            banda_tolerancia.BackColor = Color.White

        ElseIf opcion Is "Dorado" Then
            banda_tolerancia.BackColor = Color.Gold
            tolerancia = 5 / 100

        ElseIf opcion Is "Plata" Then
            banda_tolerancia.BackColor = Color.Silver
            tolerancia = 10 / 100

        ElseIf opcion Is "Clear" Then
            banda_tolerancia.BackColor = Color.WhiteSmoke
            tolerancia = 20 / 100
        End If
    End Sub

    Private Sub boton_calc_Click(sender As Object, e As EventArgs) Handles boton_calc.Click
        resistenciaNom.Text = Val(cifra1 & cifra2) * multiplicador
        resistenciaMax.Text = Val(resistenciaNom.Text) * (1 + tolerancia)
        resistenciaMin.Text = Val(resistenciaNom.Text) * (1 - tolerancia)
    End Sub

    Private Sub boton_reset_Click(sender As Object, e As EventArgs) Handles boton_reset.Click
        resistenciaNom.Text = ""
        resistenciaMax.Text = ""
        resistenciaMin.Text = ""

        banda_cifra1.BackColor = Color.WhiteSmoke
        banda_cifra2.BackColor = Color.WhiteSmoke
        banda_multiplicador.BackColor = Color.WhiteSmoke
        banda_tolerancia.BackColor = Color.WhiteSmoke
    End Sub
End Class
