<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TWO_DIMENSION
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
        Me.btnReadArray = New System.Windows.Forms.Button()
        Me.btnPrintArray = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(196, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(402, 38)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "TWO DIMENSIONAL ARRAY"
        '
        'btnReadArray
        '
        Me.btnReadArray.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnReadArray.Location = New System.Drawing.Point(101, 348)
        Me.btnReadArray.Name = "btnReadArray"
        Me.btnReadArray.Size = New System.Drawing.Size(186, 42)
        Me.btnReadArray.TabIndex = 5
        Me.btnReadArray.Text = "READ ARRAY"
        Me.btnReadArray.UseVisualStyleBackColor = True
        '
        'btnPrintArray
        '
        Me.btnPrintArray.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnPrintArray.Location = New System.Drawing.Point(364, 348)
        Me.btnPrintArray.Name = "btnPrintArray"
        Me.btnPrintArray.Size = New System.Drawing.Size(186, 42)
        Me.btnPrintArray.TabIndex = 6
        Me.btnPrintArray.Text = "PRINT ARRAY"
        Me.btnPrintArray.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 31
        Me.ListBox1.Location = New System.Drawing.Point(306, 131)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(106, 128)
        Me.ListBox1.TabIndex = 7
        '
        'TWO_DIMENSION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnPrintArray)
        Me.Controls.Add(Me.btnReadArray)
        Me.Controls.Add(Me.Label1)
        Me.Name = "TWO_DIMENSION"
        Me.Text = "TWO_DIMENSION"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnReadArray As Button
    Friend WithEvents btnPrintArray As Button
    Friend WithEvents ListBox1 As ListBox
End Class
