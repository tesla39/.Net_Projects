Imports System.Data.SqlClient
Imports System.Data

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.Click
        'TODO: This line of code loads data into the 'BishalDataSet.bishal' table. You can move, or remove it, as needed.
        Me.BishalTableAdapter.Fill(Me.BishalDataSet.bishal)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        DataGridView1.ClearSelection()
    End Sub
End Class
