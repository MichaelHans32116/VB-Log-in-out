<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.inpUN = New System.Windows.Forms.TextBox()
        Me.Login = New System.Windows.Forms.Button()
        Me.inpPas = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(309, 58)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Check Connection"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(133, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(182, 42)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "UserName"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(133, 165)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 42)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Password"
        '
        'inpUN
        '
        Me.inpUN.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inpUN.Location = New System.Drawing.Point(331, 112)
        Me.inpUN.Name = "inpUN"
        Me.inpUN.Size = New System.Drawing.Size(234, 39)
        Me.inpUN.TabIndex = 3
        '
        'Login
        '
        Me.Login.Font = New System.Drawing.Font("Times New Roman", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login.Location = New System.Drawing.Point(331, 244)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(197, 60)
        Me.Login.TabIndex = 5
        Me.Login.Text = "Login"
        Me.Login.UseVisualStyleBackColor = True
        '
        'inpPas
        '
        Me.inpPas.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inpPas.Location = New System.Drawing.Point(331, 165)
        Me.inpPas.Name = "inpPas"
        Me.inpPas.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.inpPas.Size = New System.Drawing.Size(234, 39)
        Me.inpPas.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 334)
        Me.Controls.Add(Me.Login)
        Me.Controls.Add(Me.inpPas)
        Me.Controls.Add(Me.inpUN)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents inpUN As TextBox
    Friend WithEvents Login As Button
    Friend WithEvents inpPas As TextBox
End Class
