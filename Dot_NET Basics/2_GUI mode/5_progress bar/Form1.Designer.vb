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
        components = New ComponentModel.Container()
        ProgressBar1 = New ProgressBar()
        Button1 = New Button()
        Label1 = New Label()
        Button2 = New Button()
        Timer1 = New Timer(components)
        SuspendLayout()
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.BackColor = SystemColors.Control
        ProgressBar1.Location = New Point(263, 182)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(254, 29)
        ProgressBar1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(185, 105)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 41)
        Button1.TabIndex = 1
        Button1.Text = "start"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(366, 248)
        Label1.Name = "Label1"
        Label1.Size = New Size(84, 18)
        Label1.TabIndex = 2
        Label1.Text = "progress"' 
        ' Button2
        ' 
        Button2.Font = New Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(543, 105)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 41)
        Button2.TabIndex = 4
        Button2.Text = "reset"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Timer1
        ' 
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(ProgressBar1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Timer1 As Timer
End Class
