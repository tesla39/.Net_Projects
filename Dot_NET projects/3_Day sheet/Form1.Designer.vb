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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.THEORETICAL_TASK = New System.Windows.Forms.ListBox()
        Me.PRACTICAL_TASK = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ADD_LIST_1 = New System.Windows.Forms.Button()
        Me.ADD_LIST_2 = New System.Windows.Forms.Button()
        Me.DELETE_LIST_1 = New System.Windows.Forms.Button()
        Me.DELETE_LIST_2 = New System.Windows.Forms.Button()
        Me.ADD_LIST_3 = New System.Windows.Forms.Button()
        Me.DELETE_LIST_3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label1.Font = New System.Drawing.Font("Bernard MT Condensed", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(840, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 43)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TASK SCHEDULER"
        '
        'THEORETICAL_TASK
        '
        Me.THEORETICAL_TASK.BackColor = System.Drawing.Color.Indigo
        Me.THEORETICAL_TASK.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.THEORETICAL_TASK.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.THEORETICAL_TASK.FormattingEnabled = True
        Me.THEORETICAL_TASK.ItemHeight = 25
        Me.THEORETICAL_TASK.Location = New System.Drawing.Point(342, 236)
        Me.THEORETICAL_TASK.Name = "THEORETICAL_TASK"
        Me.THEORETICAL_TASK.ScrollAlwaysVisible = True
        Me.THEORETICAL_TASK.Size = New System.Drawing.Size(372, 529)
        Me.THEORETICAL_TASK.TabIndex = 1
        '
        'PRACTICAL_TASK
        '
        Me.PRACTICAL_TASK.BackColor = System.Drawing.Color.Indigo
        Me.PRACTICAL_TASK.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PRACTICAL_TASK.ForeColor = System.Drawing.Color.IndianRed
        Me.PRACTICAL_TASK.FormattingEnabled = True
        Me.PRACTICAL_TASK.ItemHeight = 25
        Me.PRACTICAL_TASK.Location = New System.Drawing.Point(871, 236)
        Me.PRACTICAL_TASK.Name = "PRACTICAL_TASK"
        Me.PRACTICAL_TASK.ScrollAlwaysVisible = True
        Me.PRACTICAL_TASK.Size = New System.Drawing.Size(361, 529)
        Me.PRACTICAL_TASK.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Algerian", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(656, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(209, 26)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "TASK TO BE DONE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Algerian", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(1578, 383)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(211, 26)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "TASK COMPLETED"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(1524, 457)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(294, 33)
        Me.ComboBox1.TabIndex = 7
        '
        'ADD_LIST_1
        '
        Me.ADD_LIST_1.BackColor = System.Drawing.Color.Gray
        Me.ADD_LIST_1.Font = New System.Drawing.Font("Snap ITC", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ADD_LIST_1.Location = New System.Drawing.Point(196, 683)
        Me.ADD_LIST_1.Name = "ADD_LIST_1"
        Me.ADD_LIST_1.Size = New System.Drawing.Size(122, 31)
        Me.ADD_LIST_1.TabIndex = 8
        Me.ADD_LIST_1.Text = "ADD TASK"
        Me.ADD_LIST_1.UseVisualStyleBackColor = False
        '
        'ADD_LIST_2
        '
        Me.ADD_LIST_2.BackColor = System.Drawing.Color.Gray
        Me.ADD_LIST_2.Font = New System.Drawing.Font("Snap ITC", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ADD_LIST_2.Location = New System.Drawing.Point(1238, 683)
        Me.ADD_LIST_2.Name = "ADD_LIST_2"
        Me.ADD_LIST_2.Size = New System.Drawing.Size(122, 31)
        Me.ADD_LIST_2.TabIndex = 11
        Me.ADD_LIST_2.Text = "ADD TASK"
        Me.ADD_LIST_2.UseVisualStyleBackColor = False
        '
        'DELETE_LIST_1
        '
        Me.DELETE_LIST_1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.DELETE_LIST_1.Font = New System.Drawing.Font("Snap ITC", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DELETE_LIST_1.Location = New System.Drawing.Point(170, 734)
        Me.DELETE_LIST_1.Name = "DELETE_LIST_1"
        Me.DELETE_LIST_1.Size = New System.Drawing.Size(122, 31)
        Me.DELETE_LIST_1.TabIndex = 14
        Me.DELETE_LIST_1.Text = "DELETE"
        Me.DELETE_LIST_1.UseVisualStyleBackColor = False
        '
        'DELETE_LIST_2
        '
        Me.DELETE_LIST_2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.DELETE_LIST_2.Font = New System.Drawing.Font("Snap ITC", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DELETE_LIST_2.Location = New System.Drawing.Point(1262, 749)
        Me.DELETE_LIST_2.Name = "DELETE_LIST_2"
        Me.DELETE_LIST_2.Size = New System.Drawing.Size(122, 31)
        Me.DELETE_LIST_2.TabIndex = 15
        Me.DELETE_LIST_2.Text = "DELETE"
        Me.DELETE_LIST_2.UseVisualStyleBackColor = False
        '
        'ADD_LIST_3
        '
        Me.ADD_LIST_3.BackColor = System.Drawing.Color.Gray
        Me.ADD_LIST_3.Font = New System.Drawing.Font("Snap ITC", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ADD_LIST_3.Location = New System.Drawing.Point(1620, 683)
        Me.ADD_LIST_3.Name = "ADD_LIST_3"
        Me.ADD_LIST_3.Size = New System.Drawing.Size(122, 31)
        Me.ADD_LIST_3.TabIndex = 16
        Me.ADD_LIST_3.Text = "ADD TASK"
        Me.ADD_LIST_3.UseVisualStyleBackColor = False
        '
        'DELETE_LIST_3
        '
        Me.DELETE_LIST_3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.DELETE_LIST_3.Font = New System.Drawing.Font("Snap ITC", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DELETE_LIST_3.Location = New System.Drawing.Point(1620, 734)
        Me.DELETE_LIST_3.Name = "DELETE_LIST_3"
        Me.DELETE_LIST_3.Size = New System.Drawing.Size(122, 31)
        Me.DELETE_LIST_3.TabIndex = 17
        Me.DELETE_LIST_3.Text = "DELETE"
        Me.DELETE_LIST_3.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1845, 895)
        Me.Controls.Add(Me.DELETE_LIST_3)
        Me.Controls.Add(Me.ADD_LIST_3)
        Me.Controls.Add(Me.DELETE_LIST_2)
        Me.Controls.Add(Me.DELETE_LIST_1)
        Me.Controls.Add(Me.ADD_LIST_2)
        Me.Controls.Add(Me.ADD_LIST_1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PRACTICAL_TASK)
        Me.Controls.Add(Me.THEORETICAL_TASK)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "schedule"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents THEORETICAL_TASK As ListBox
    Friend WithEvents PRACTICAL_TASK As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ADD_LIST_1 As Button
    Friend WithEvents ADD_LIST_2 As Button
    Friend WithEvents DELETE_LIST_1 As Button
    Friend WithEvents DELETE_LIST_2 As Button
    Friend WithEvents ADD_LIST_3 As Button
    Friend WithEvents DELETE_LIST_3 As Button
End Class
