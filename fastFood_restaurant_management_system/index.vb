Imports System.ComponentModel

Public Class index
    Public callerForm As Form1
    Public dash As New dashboard
    Public master As New masterEntry
    Public bill As New billing
    Public admin As New administration
    Public record As New records
    Public report As New reports

    Public Function setParent(_Parent As Form1)
        callerForm = _Parent
    End Function
    Public Sub childForm(ByVal panel As Form)
        Panel4.Controls.Clear()
        panel.TopLevel = False
        panel.FormBorderStyle = Windows.Forms.BorderStyle.None
        panel.Dock = DockStyle.Fill
        Panel4.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub index_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dash.setParent(Me)
        childForm(dash)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label6.Text = Date.Now.ToString("ddd, dd MMM yyyy, HH:mm")
        'Label5.Text = Date.Now.ToString("HH:mm:ss")
    End Sub

    Private Sub Button_Dashboard_Click(sender As Object, e As EventArgs) Handles Button_Dashboard.Click
        dash.setParent(Me)
        dash.loadDashboard()
        childForm(dash)
        slidePanel.Height = Button_Dashboard.Height
        slidePanel.Top = Button_Dashboard.Top
    End Sub
    Private Sub Button_Master_Click(sender As Object, e As EventArgs) Handles Button_Master.Click
        master.setParent(Me)
        childForm(master)
        slidePanel.Height = Button_Master.Height
        slidePanel.Top = Button_Master.Top
    End Sub

    Private Sub Button_Billing_Click(sender As Object, e As EventArgs) Handles Button_Billing.Click
        bill.setParent(Me)
        childForm(bill)
        slidePanel.Height = Button_Billing.Height
        slidePanel.Top = Button_Billing.Top
    End Sub

    Private Sub Button_Admin_Click(sender As Object, e As EventArgs) Handles Button_Admin.Click
        admin.setParent(Me)
        childForm(admin)
        slidePanel.Height = Button_Admin.Height
        slidePanel.Top = Button_Admin.Top
    End Sub

    Private Sub Button_Report_Click(sender As Object, e As EventArgs) Handles Button_Report.Click
        report.setParent(Me)
        childForm(report)
        slidePanel.Height = Button_Report.Height
        slidePanel.Top = Button_Report.Top
    End Sub

    Private Sub Button_Record_Click(sender As Object, e As EventArgs) Handles Button_Record.Click
        record.setParent(Me)
        record.DataGridView1.Show()
        childForm(record)
        slidePanel.Height = Button_Record.Height
        slidePanel.Top = Button_Record.Top
    End Sub

    Private Sub Button_Logout_Click(sender As Object, e As EventArgs) Handles Button_Logout.Click
        Form1.Show()
        Me.Hide()
        slidePanel.Height = Button_Logout.Height
        slidePanel.Top = Button_Logout.Top
    End Sub

End Class