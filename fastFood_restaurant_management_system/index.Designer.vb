<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class index
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(index))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.slidePanel = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button_Logout = New System.Windows.Forms.Button()
        Me.Button_Record = New System.Windows.Forms.Button()
        Me.Button_Report = New System.Windows.Forms.Button()
        Me.Button_Admin = New System.Windows.Forms.Button()
        Me.Button_Billing = New System.Windows.Forms.Button()
        Me.Button_Master = New System.Windows.Forms.Button()
        Me.Button_Dashboard = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Red
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(239, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(713, 31)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(686, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(21, 21)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Navy
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.slidePanel)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Button_Logout)
        Me.Panel2.Controls.Add(Me.Button_Record)
        Me.Panel2.Controls.Add(Me.Button_Report)
        Me.Panel2.Controls.Add(Me.Button_Admin)
        Me.Panel2.Controls.Add(Me.Button_Billing)
        Me.Panel2.Controls.Add(Me.Button_Master)
        Me.Panel2.Controls.Add(Me.Button_Dashboard)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(239, 546)
        Me.Panel2.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(5, 521)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 16)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Date:"
        '
        'slidePanel
        '
        Me.slidePanel.BackColor = System.Drawing.Color.Red
        Me.slidePanel.Location = New System.Drawing.Point(17, 133)
        Me.slidePanel.Name = "slidePanel"
        Me.slidePanel.Size = New System.Drawing.Size(16, 39)
        Me.slidePanel.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(42, 521)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 16)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(73, 500)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 16)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(6, 500)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 16)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Welcome,"
        '
        'Button_Logout
        '
        Me.Button_Logout.BackColor = System.Drawing.Color.Transparent
        Me.Button_Logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button_Logout.FlatAppearance.BorderSize = 0
        Me.Button_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Logout.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Logout.ForeColor = System.Drawing.Color.White
        Me.Button_Logout.Image = CType(resources.GetObject("Button_Logout.Image"), System.Drawing.Image)
        Me.Button_Logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_Logout.Location = New System.Drawing.Point(34, 403)
        Me.Button_Logout.Name = "Button_Logout"
        Me.Button_Logout.Size = New System.Drawing.Size(205, 39)
        Me.Button_Logout.TabIndex = 14
        Me.Button_Logout.Text = "          Logout"
        Me.Button_Logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_Logout.UseVisualStyleBackColor = False
        '
        'Button_Record
        '
        Me.Button_Record.BackColor = System.Drawing.Color.Transparent
        Me.Button_Record.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button_Record.FlatAppearance.BorderSize = 0
        Me.Button_Record.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Record.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Record.ForeColor = System.Drawing.Color.White
        Me.Button_Record.Image = CType(resources.GetObject("Button_Record.Image"), System.Drawing.Image)
        Me.Button_Record.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_Record.Location = New System.Drawing.Point(34, 358)
        Me.Button_Record.Name = "Button_Record"
        Me.Button_Record.Size = New System.Drawing.Size(205, 39)
        Me.Button_Record.TabIndex = 12
        Me.Button_Record.Text = "          Records"
        Me.Button_Record.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_Record.UseVisualStyleBackColor = False
        '
        'Button_Report
        '
        Me.Button_Report.BackColor = System.Drawing.Color.Transparent
        Me.Button_Report.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button_Report.FlatAppearance.BorderSize = 0
        Me.Button_Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Report.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Report.ForeColor = System.Drawing.Color.White
        Me.Button_Report.Image = CType(resources.GetObject("Button_Report.Image"), System.Drawing.Image)
        Me.Button_Report.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_Report.Location = New System.Drawing.Point(34, 313)
        Me.Button_Report.Name = "Button_Report"
        Me.Button_Report.Size = New System.Drawing.Size(205, 39)
        Me.Button_Report.TabIndex = 11
        Me.Button_Report.Text = "          Reports"
        Me.Button_Report.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_Report.UseVisualStyleBackColor = False
        '
        'Button_Admin
        '
        Me.Button_Admin.BackColor = System.Drawing.Color.Transparent
        Me.Button_Admin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button_Admin.FlatAppearance.BorderSize = 0
        Me.Button_Admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Admin.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Admin.ForeColor = System.Drawing.Color.White
        Me.Button_Admin.Image = CType(resources.GetObject("Button_Admin.Image"), System.Drawing.Image)
        Me.Button_Admin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_Admin.Location = New System.Drawing.Point(34, 268)
        Me.Button_Admin.Name = "Button_Admin"
        Me.Button_Admin.Size = New System.Drawing.Size(205, 39)
        Me.Button_Admin.TabIndex = 10
        Me.Button_Admin.Text = "          Administration"
        Me.Button_Admin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_Admin.UseVisualStyleBackColor = False
        '
        'Button_Billing
        '
        Me.Button_Billing.BackColor = System.Drawing.Color.Transparent
        Me.Button_Billing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button_Billing.FlatAppearance.BorderSize = 0
        Me.Button_Billing.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Billing.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Billing.ForeColor = System.Drawing.Color.White
        Me.Button_Billing.Image = CType(resources.GetObject("Button_Billing.Image"), System.Drawing.Image)
        Me.Button_Billing.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_Billing.Location = New System.Drawing.Point(34, 223)
        Me.Button_Billing.Name = "Button_Billing"
        Me.Button_Billing.Size = New System.Drawing.Size(205, 39)
        Me.Button_Billing.TabIndex = 9
        Me.Button_Billing.Text = "          Billing"
        Me.Button_Billing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_Billing.UseVisualStyleBackColor = False
        '
        'Button_Master
        '
        Me.Button_Master.BackColor = System.Drawing.Color.Transparent
        Me.Button_Master.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button_Master.FlatAppearance.BorderSize = 0
        Me.Button_Master.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Master.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Master.ForeColor = System.Drawing.Color.White
        Me.Button_Master.Image = CType(resources.GetObject("Button_Master.Image"), System.Drawing.Image)
        Me.Button_Master.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_Master.Location = New System.Drawing.Point(34, 178)
        Me.Button_Master.Name = "Button_Master"
        Me.Button_Master.Size = New System.Drawing.Size(205, 39)
        Me.Button_Master.TabIndex = 8
        Me.Button_Master.Text = "          Master"
        Me.Button_Master.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_Master.UseVisualStyleBackColor = False
        '
        'Button_Dashboard
        '
        Me.Button_Dashboard.BackColor = System.Drawing.Color.Transparent
        Me.Button_Dashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button_Dashboard.FlatAppearance.BorderSize = 0
        Me.Button_Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Dashboard.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Dashboard.ForeColor = System.Drawing.Color.White
        Me.Button_Dashboard.Image = CType(resources.GetObject("Button_Dashboard.Image"), System.Drawing.Image)
        Me.Button_Dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_Dashboard.Location = New System.Drawing.Point(34, 133)
        Me.Button_Dashboard.Name = "Button_Dashboard"
        Me.Button_Dashboard.Size = New System.Drawing.Size(205, 39)
        Me.Button_Dashboard.TabIndex = 7
        Me.Button_Dashboard.Text = "          Dashboard"
        Me.Button_Dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button_Dashboard.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.PeachPuff
        Me.Label2.Location = New System.Drawing.Point(92, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "RESTAURANT"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(76, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "FAST FOOD"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Location = New System.Drawing.Point(5, 99)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(230, 5)
        Me.Panel3.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(-15, -11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(114, 120)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.Location = New System.Drawing.Point(239, 32)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(712, 513)
        Me.Panel4.TabIndex = 2
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'index
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 546)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "index"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "index"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button_Dashboard As Button
    Friend WithEvents Button_Logout As Button
    Friend WithEvents Button_Record As Button
    Friend WithEvents Button_Report As Button
    Friend WithEvents Button_Admin As Button
    Friend WithEvents Button_Billing As Button
    Friend WithEvents Button_Master As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents slidePanel As Panel
    Friend WithEvents Label5 As Label
End Class
