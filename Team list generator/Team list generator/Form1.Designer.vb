<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.tlp_form = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_name = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_playerID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtp_dateOfBirth = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tb_eventName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_createForm = New System.Windows.Forms.Button()
        Me.tb_teamList = New System.Windows.Forms.TextBox()
        Me.tlp_form.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlp_form
        '
        Me.tlp_form.ColumnCount = 2
        Me.tlp_form.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlp_form.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlp_form.Controls.Add(Me.Label1, 0, 0)
        Me.tlp_form.Controls.Add(Me.tb_name, 1, 0)
        Me.tlp_form.Controls.Add(Me.Label2, 0, 1)
        Me.tlp_form.Controls.Add(Me.tb_playerID, 1, 1)
        Me.tlp_form.Controls.Add(Me.Label3, 0, 2)
        Me.tlp_form.Controls.Add(Me.dtp_dateOfBirth, 1, 2)
        Me.tlp_form.Controls.Add(Me.Label4, 0, 3)
        Me.tlp_form.Controls.Add(Me.tb_eventName, 1, 3)
        Me.tlp_form.Controls.Add(Me.Label5, 0, 4)
        Me.tlp_form.Controls.Add(Me.btn_createForm, 0, 6)
        Me.tlp_form.Controls.Add(Me.tb_teamList, 0, 5)
        Me.tlp_form.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlp_form.Location = New System.Drawing.Point(0, 0)
        Me.tlp_form.Name = "tlp_form"
        Me.tlp_form.RowCount = 7
        Me.tlp_form.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlp_form.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlp_form.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlp_form.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlp_form.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlp_form.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlp_form.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlp_form.Size = New System.Drawing.Size(294, 301)
        Me.tlp_form.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tb_name
        '
        Me.tb_name.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tb_name.Location = New System.Drawing.Point(74, 3)
        Me.tb_name.Name = "tb_name"
        Me.tb_name.Size = New System.Drawing.Size(217, 20)
        Me.tb_name.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Player ID"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tb_playerID
        '
        Me.tb_playerID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tb_playerID.Location = New System.Drawing.Point(74, 29)
        Me.tb_playerID.Name = "tb_playerID"
        Me.tb_playerID.Size = New System.Drawing.Size(217, 20)
        Me.tb_playerID.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Date of birth"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtp_dateOfBirth
        '
        Me.dtp_dateOfBirth.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtp_dateOfBirth.Location = New System.Drawing.Point(74, 55)
        Me.dtp_dateOfBirth.Name = "dtp_dateOfBirth"
        Me.dtp_dateOfBirth.Size = New System.Drawing.Size(217, 20)
        Me.dtp_dateOfBirth.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Event name"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tb_eventName
        '
        Me.tb_eventName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tb_eventName.Location = New System.Drawing.Point(74, 81)
        Me.tb_eventName.Name = "tb_eventName"
        Me.tb_eventName.Size = New System.Drawing.Size(217, 20)
        Me.tb_eventName.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.tlp_form.SetColumnSpan(Me.Label5, 2)
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(3, 124)
        Me.Label5.Margin = New System.Windows.Forms.Padding(3, 20, 3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(288, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Paste your team list in Pokémon Showdown format below:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_createForm
        '
        Me.btn_createForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tlp_form.SetColumnSpan(Me.btn_createForm, 2)
        Me.btn_createForm.Location = New System.Drawing.Point(3, 275)
        Me.btn_createForm.Name = "btn_createForm"
        Me.btn_createForm.Size = New System.Drawing.Size(75, 23)
        Me.btn_createForm.TabIndex = 9
        Me.btn_createForm.Text = "Create form"
        Me.btn_createForm.UseVisualStyleBackColor = True
        '
        'tb_teamList
        '
        Me.tb_teamList.AcceptsReturn = True
        Me.tb_teamList.AllowDrop = True
        Me.tb_teamList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlp_form.SetColumnSpan(Me.tb_teamList, 2)
        Me.tb_teamList.Location = New System.Drawing.Point(3, 140)
        Me.tb_teamList.Multiline = True
        Me.tb_teamList.Name = "tb_teamList"
        Me.tb_teamList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tb_teamList.Size = New System.Drawing.Size(288, 129)
        Me.tb_teamList.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 301)
        Me.Controls.Add(Me.tlp_form)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(500, 530)
        Me.MinimumSize = New System.Drawing.Size(310, 340)
        Me.Name = "Form1"
        Me.Text = "VG team list generator"
        Me.tlp_form.ResumeLayout(False)
        Me.tlp_form.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlp_form As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents tb_name As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tb_playerID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtp_dateOfBirth As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents tb_eventName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_createForm As Button
    Friend WithEvents tb_teamList As TextBox
End Class
