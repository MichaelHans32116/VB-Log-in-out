<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.signO = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.saveBut = New System.Windows.Forms.Button()
        Me.inpEID = New System.Windows.Forms.TextBox()
        Me.inpName = New System.Windows.Forms.TextBox()
        Me.inpSName = New System.Windows.Forms.TextBox()
        Me.inpAge = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AllowDrop = True
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "EId"
        '
        'signO
        '
        Me.signO.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.signO.Location = New System.Drawing.Point(33, 31)
        Me.signO.Name = "signO"
        Me.signO.Size = New System.Drawing.Size(124, 38)
        Me.signO.TabIndex = 2
        Me.signO.Text = "Sign Out"
        Me.signO.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(510, 105)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(8, 8)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AllowDrop = True
        Me.Label2.AutoSize = True
        Me.Label2.Enabled = False
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 40)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AllowDrop = True
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 210)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 40)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Surname"
        '
        'Label4
        '
        Me.Label4.AllowDrop = True
        Me.Label4.AutoSize = True
        Me.Label4.Enabled = False
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 268)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 40)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Age"
        '
        'saveBut
        '
        Me.saveBut.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveBut.Location = New System.Drawing.Point(260, 345)
        Me.saveBut.Name = "saveBut"
        Me.saveBut.Size = New System.Drawing.Size(124, 38)
        Me.saveBut.TabIndex = 4
        Me.saveBut.Text = "Save"
        Me.saveBut.UseVisualStyleBackColor = True
        '
        'inpEID
        '
        Me.inpEID.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inpEID.Location = New System.Drawing.Point(218, 106)
        Me.inpEID.Name = "inpEID"
        Me.inpEID.Size = New System.Drawing.Size(234, 39)
        Me.inpEID.TabIndex = 6
        '
        'inpName
        '
        Me.inpName.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inpName.Location = New System.Drawing.Point(218, 159)
        Me.inpName.Name = "inpName"
        Me.inpName.Size = New System.Drawing.Size(234, 39)
        Me.inpName.TabIndex = 6
        '
        'inpSName
        '
        Me.inpSName.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inpSName.Location = New System.Drawing.Point(218, 210)
        Me.inpSName.Name = "inpSName"
        Me.inpSName.Size = New System.Drawing.Size(234, 39)
        Me.inpSName.TabIndex = 6
        '
        'inpAge
        '
        Me.inpAge.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inpAge.Location = New System.Drawing.Point(218, 268)
        Me.inpAge.Name = "inpAge"
        Me.inpAge.Size = New System.Drawing.Size(234, 39)
        Me.inpAge.TabIndex = 6
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.inpAge)
        Me.Controls.Add(Me.inpSName)
        Me.Controls.Add(Me.inpName)
        Me.Controls.Add(Me.inpEID)
        Me.Controls.Add(Me.saveBut)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.signO)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents signO As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents saveBut As Button
    Friend WithEvents inpEID As TextBox
    Friend WithEvents inpName As TextBox
    Friend WithEvents inpSName As TextBox
    Friend WithEvents inpAge As TextBox
End Class
