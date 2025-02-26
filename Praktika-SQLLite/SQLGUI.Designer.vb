<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SQLGUI
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
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtboxName = New System.Windows.Forms.TextBox()
        Me.txtboxCode = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblResponse = New System.Windows.Forms.Label()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtboxGrade = New System.Windows.Forms.TextBox()
        Me.lvTabel = New System.Windows.Forms.ListView()
        Me.lvName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvCode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvGrade = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnUnsafeAdd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(542, 207)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 48)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtboxName
        '
        Me.txtboxName.Location = New System.Drawing.Point(521, 89)
        Me.txtboxName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtboxName.Name = "txtboxName"
        Me.txtboxName.Size = New System.Drawing.Size(146, 26)
        Me.txtboxName.TabIndex = 7
        '
        'txtboxCode
        '
        Me.txtboxCode.Location = New System.Drawing.Point(521, 127)
        Me.txtboxCode.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtboxCode.Name = "txtboxCode"
        Me.txtboxCode.Size = New System.Drawing.Size(146, 26)
        Me.txtboxCode.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(458, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Code"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(457, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 20)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Name"
        '
        'lblResponse
        '
        Me.lblResponse.AutoSize = True
        Me.lblResponse.Location = New System.Drawing.Point(571, 332)
        Me.lblResponse.Name = "lblResponse"
        Me.lblResponse.Size = New System.Drawing.Size(39, 20)
        Me.lblResponse.TabIndex = 14
        Me.lblResponse.Text = " N/A"
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(542, 265)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(100, 48)
        Me.btnRemove.TabIndex = 15
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(457, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 20)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Grade"
        '
        'txtboxGrade
        '
        Me.txtboxGrade.Location = New System.Drawing.Point(521, 167)
        Me.txtboxGrade.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtboxGrade.Name = "txtboxGrade"
        Me.txtboxGrade.Size = New System.Drawing.Size(146, 26)
        Me.txtboxGrade.TabIndex = 21
        '
        'lvTabel
        '
        Me.lvTabel.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lvName, Me.lvCode, Me.lvGrade})
        Me.lvTabel.HideSelection = False
        Me.lvTabel.Location = New System.Drawing.Point(29, 40)
        Me.lvTabel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lvTabel.Name = "lvTabel"
        Me.lvTabel.Size = New System.Drawing.Size(415, 273)
        Me.lvTabel.TabIndex = 20
        Me.lvTabel.UseCompatibleStateImageBehavior = False
        Me.lvTabel.View = System.Windows.Forms.View.Details
        '
        'lvName
        '
        Me.lvName.Text = "Name"
        Me.lvName.Width = 95
        '
        'lvCode
        '
        Me.lvCode.Text = "Code"
        Me.lvCode.Width = 90
        '
        'lvGrade
        '
        Me.lvGrade.Text = "Grade"
        Me.lvGrade.Width = 89
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(551, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Add item"
        '
        'btnUnsafeAdd
        '
        Me.btnUnsafeAdd.Location = New System.Drawing.Point(650, 207)
        Me.btnUnsafeAdd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnUnsafeAdd.Name = "btnUnsafeAdd"
        Me.btnUnsafeAdd.Size = New System.Drawing.Size(100, 48)
        Me.btnUnsafeAdd.TabIndex = 22
        Me.btnUnsafeAdd.Text = "Unsafe Add"
        Me.btnUnsafeAdd.UseVisualStyleBackColor = True
        '
        'SQLGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 402)
        Me.Controls.Add(Me.btnUnsafeAdd)
        Me.Controls.Add(Me.lvTabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtboxName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtboxCode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtboxGrade)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.lblResponse)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "SQLGUI"
        Me.Text = "SQLGUI"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtboxName As TextBox
    Friend WithEvents txtboxCode As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblResponse As Label
    Friend WithEvents btnRemove As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtboxGrade As TextBox
    Friend WithEvents lvTabel As ListView
    Friend WithEvents lvName As ColumnHeader
    Friend WithEvents lvCode As ColumnHeader
    Friend WithEvents lvGrade As ColumnHeader
    Friend WithEvents Label2 As Label
    Friend WithEvents btnUnsafeAdd As Button
End Class
