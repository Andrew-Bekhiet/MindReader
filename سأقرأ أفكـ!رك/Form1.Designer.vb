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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(61, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(293, 92)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "اختر رقم من 1 - 60"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(65, 191)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(288, 82)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "التالي"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 19.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.Location = New System.Drawing.Point(360, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(58, 47)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "X"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Button2
        Me.ClientSize = New System.Drawing.Size(420, 308)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.MaximumSize = New System.Drawing.Size(436, 347)
        Me.MinimumSize = New System.Drawing.Size(436, 347)
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "0"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
