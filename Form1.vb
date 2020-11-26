Public Class Form1
    Private Sub ColorResistenciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorResistenciaToolStripMenuItem.Click
        Dim color_r As New Form_Color_Resistencia

        color_r.MdiParent = Me
        color_r.StartPosition = FormStartPosition.CenterScreen
        color_r.Show()

    End Sub

    Private Sub ResistenciaColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResistenciaColorToolStripMenuItem.Click
        Dim resistencia_c As New Form_Resistencia_Color

        resistencia_c.MdiParent = Me
        resistencia_c.StartPosition = FormStartPosition.CenterScreen
        resistencia_c.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim about As New Form_About

        about.MdiParent = Me
        about.StartPosition = FormStartPosition.CenterScreen
        about.Show()
    End Sub
End Class
