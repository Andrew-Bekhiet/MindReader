<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 17.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(40, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(268, 73)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "رقمك هو"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 17.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(40, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(268, 73)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "0"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(128, 223)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 65)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "إعادة"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 19.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.Location = New System.Drawing.Point(287, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(58, 47)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "X"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 313)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximumSize = New System.Drawing.Size(373, 352)
        Me.MinimumSize = New System.Drawing.Size(373, 352)
        Me.Name = "Form8"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "="
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
