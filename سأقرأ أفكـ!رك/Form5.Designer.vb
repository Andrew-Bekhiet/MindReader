<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(111, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 223)
        Me.Label1.TabIndex = 54
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Button3.Location = New System.Drawing.Point(12, 334)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(126, 35)
        Me.Button3.TabIndex = 52
        Me.Button3.Text = "لا"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(234, 334)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 35)
        Me.Button1.TabIndex = 53
        Me.Button1.Text = "نعم"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 15.0!)
        Me.Label2.Location = New System.Drawing.Point(8, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(289, 57)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "أم هنا؟"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 19.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.Location = New System.Drawing.Point(303, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(58, 47)
        Me.Button2.TabIndex = 50
        Me.Button2.Text = "X"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 381)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.MaximumSize = New System.Drawing.Size(386, 420)
        Me.MinimumSize = New System.Drawing.Size(386, 420)
        Me.Name = "Form5"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "4"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
