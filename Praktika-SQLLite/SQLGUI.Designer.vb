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
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(347, 135)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(73, 31)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtboxName
        '
        Me.txtboxName.Location = New System.Drawing.Point(347, 58)
        Me.txtboxName.Name = "txtboxName"
        Me.txtboxName.Size = New System.Drawing.Size(99, 20)
        Me.txtboxName.TabIndex = 7
        '
        'txtboxCode
        '
        Me.txtboxCode.Location = New System.Drawing.Point(347, 83)
        Me.txtboxCode.Name = "txtboxCode"
        Me.txtboxCode.Size = New System.Drawing.Size(99, 20)
        Me.txtboxCode.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(305, 86)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Code"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(305, 58)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Name"
        '
        'lblResponse
        '
        Me.lblResponse.AutoSize = True
        Me.lblResponse.Location = New System.Drawing.Point(381, 216)
        Me.lblResponse.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblResponse.Name = "lblResponse"
        Me.lblResponse.Size = New System.Drawing.Size(30, 13)
        Me.lblResponse.TabIndex = 14
        Me.lblResponse.Text = " N/A"
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(224, 211)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(73, 31)
        Me.btnRemove.TabIndex = 15
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(305, 112)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Grade"
        '
        'txtboxGrade
        '
        Me.txtboxGrade.Location = New System.Drawing.Point(347, 109)
        Me.txtboxGrade.Name = "txtboxGrade"
        Me.txtboxGrade.Size = New System.Drawing.Size(99, 20)
        Me.txtboxGrade.TabIndex = 21
        '
        'lvTabel
        '
        Me.lvTabel.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lvName, Me.lvCode, Me.lvGrade})
        Me.lvTabel.HideSelection = False
        Me.lvTabel.Location = New System.Drawing.Point(19, 26)
        Me.lvTabel.Name = "lvTabel"
        Me.lvTabel.Size = New System.Drawing.Size(278, 179)
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
        Me.Label2.Location = New System.Drawing.Point(367, 25)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Add item"
        '
        'btnUnsafeAdd
        '
        Me.btnUnsafeAdd.Location = New System.Drawing.Point(420, 135)
        Me.btnUnsafeAdd.Name = "btnUnsafeAdd"
        Me.btnUnsafeAdd.Size = New System.Drawing.Size(73, 31)
        Me.btnUnsafeAdd.TabIndex = 22
        Me.btnUnsafeAdd.Text = "Unsafe Add"
        Me.btnUnsafeAdd.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(19, 212)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(73, 30)
        Me.BtnUpdate.TabIndex = 23
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'SQLGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 261)
        Me.Controls.Add(Me.BtnUpdate)
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
    Friend WithEvents BtnUpdate As Button
End Class
