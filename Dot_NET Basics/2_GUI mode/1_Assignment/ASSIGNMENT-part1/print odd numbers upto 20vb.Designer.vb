<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class print_odd_numbers_upto_20vb
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
        Me.odd_number = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(214, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(438, 45)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "print odd nubmers upto 20"
        '
        'odd_number
        '
        Me.odd_number.FormattingEnabled = True
        Me.odd_number.ItemHeight = 20
        Me.odd_number.Location = New System.Drawing.Point(315, 149)
        Me.odd_number.Name = "odd_number"
        Me.odd_number.Size = New System.Drawing.Size(94, 264)
        Me.odd_number.TabIndex = 15
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(531, 386)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 52)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "print"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(671, 386)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 52)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'print_odd_numbers_upto_20vb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.odd_number)
        Me.Controls.Add(Me.Label1)
        Me.Name = "print_odd_numbers_upto_20vb"
        Me.Text = "print_odd_numbers_upto_20vb"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents odd_number As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
