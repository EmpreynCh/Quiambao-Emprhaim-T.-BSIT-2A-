
Imports System.Drawing.Text

Public Class Form1
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        txthallid.Enabled = True
        txtfullname.Enabled = True
        txtadd.Enabled = True
        txttel.Enabled = True
        txtman.Enabled = True
        btnDel.Enabled = True
        btnSave.Enabled = True

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        txthallid.Enabled = False
        txtfullname.Enabled = False
        txtadd.Enabled = False
        txttel.Enabled = False
        btnDel.Enabled = False
        btnSave.Enabled = False

    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txthallid.Enabled = True
        txtfullname.Enabled = True
        txtadd.Enabled = True
        txttel.Enabled = True
        btnDel.Enabled = False
        btnSave.Enabled = True

    End Sub



    Private Sub PopListView()
        ListView1.Clear()

        With ListView1
            .View = View.Details
            .GridLines = True
            .Columns.Add("ID", 40)
            .Columns.Add("Residence Hall", 129)
            .Columns.Add("Address", 130)
            .Columns.Add("Telephone", 80)
            .Columns.Add("Manager", 100)
        End With


    End Sub


End Class
