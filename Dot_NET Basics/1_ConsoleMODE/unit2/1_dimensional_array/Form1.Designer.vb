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
        Me.btnPrintArray = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnReadArray = New System.Windows.Forms.Button()
        Me.txtArray = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnPrintArray
        '
        Me.btnPrintArray.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnPrintArray.Location = New System.Drawing.Point(413, 380)
        Me.btnPrintArray.Name = "btnPrintArray"
        Me.btnPrintArray.Size = New System.Drawing.Size(186, 42)
        Me.btnPrintArray.TabIndex = 0
        Me.btnPrintArray.Text = "PRINT ARRAY"
        Me.btnPrintArray.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(173, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(393, 38)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ONE DIMENSIONAL ARRAY"
        '
        'btnReadArray
        '
        Me.btnReadArray.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnReadArray.Location = New System.Drawing.Point(112, 380)
        Me.btnReadArray.Name = "btnReadArray"
        Me.btnReadArray.Size = New System.Drawing.Size(186, 42)
        Me.btnReadArray.TabIndex = 2
        Me.btnReadArray.Text = "READ ARRAY"
        Me.btnReadArray.UseVisualStyleBackColor = True
        '
        'txtArray
        '
        Me.txtArray.Location = New System.Drawing.Point(284, 162)
        Me.txtArray.Name = "txtArray"
        Me.txtArray.Size = New System.Drawing.Size(125, 27)
        Me.txtArray.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtArray)
        Me.Controls.Add(Me.btnReadArray)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPrintArray)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPrintArray As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnReadArray As Button
    Friend WithEvents txtArray As TextBox
End Class
