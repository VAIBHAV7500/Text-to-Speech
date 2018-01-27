Imports System.Speech
Imports System.Speech.Synthesis



Public Class Form1

    Dim Speaker As New SpeechSynthesizer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Speaker.Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Speaker.SpeakAsync(RichTextBox1.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Speaker.SpeakAsyncCancelAll()
    End Sub
End Class
