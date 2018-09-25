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
        Me.butCalculate = New System.Windows.Forms.Button()
        Me.txtCurrentGrade = New System.Windows.Forms.TextBox()
        Me.txtFinalPercent = New System.Windows.Forms.TextBox()
        Me.txtGradeWanted = New System.Windows.Forms.TextBox()
        Me.lblCurrentGrade = New System.Windows.Forms.Label()
        Me.lblFinalPercent = New System.Windows.Forms.Label()
        Me.lblGradeWanted = New System.Windows.Forms.Label()
        Me.lblSign1 = New System.Windows.Forms.Label()
        Me.lblSign2 = New System.Windows.Forms.Label()
        Me.lblSign3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'butCalculate
        '
        Me.butCalculate.BackColor = System.Drawing.SystemColors.InfoText
        Me.butCalculate.Font = New System.Drawing.Font("Bradley Hand ITC", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butCalculate.ForeColor = System.Drawing.Color.SkyBlue
        Me.butCalculate.Location = New System.Drawing.Point(84, 169)
        Me.butCalculate.Name = "butCalculate"
        Me.butCalculate.Size = New System.Drawing.Size(169, 47)
        Me.butCalculate.TabIndex = 0
        Me.butCalculate.Text = "Calculate"
        Me.butCalculate.UseVisualStyleBackColor = False
        '
        'txtCurrentGrade
        '
        Me.txtCurrentGrade.ForeColor = System.Drawing.Color.LightSlateGray
        Me.txtCurrentGrade.Location = New System.Drawing.Point(122, 58)
        Me.txtCurrentGrade.Name = "txtCurrentGrade"
        Me.txtCurrentGrade.Size = New System.Drawing.Size(119, 20)
        Me.txtCurrentGrade.TabIndex = 1
        Me.txtCurrentGrade.Text = "(e.g. 85.3 )"
        '
        'txtFinalPercent
        '
        Me.txtFinalPercent.ForeColor = System.Drawing.Color.LightSlateGray
        Me.txtFinalPercent.Location = New System.Drawing.Point(122, 87)
        Me.txtFinalPercent.Name = "txtFinalPercent"
        Me.txtFinalPercent.Size = New System.Drawing.Size(119, 20)
        Me.txtFinalPercent.TabIndex = 2
        Me.txtFinalPercent.Text = "(e.g. 15)"
        '
        'txtGradeWanted
        '
        Me.txtGradeWanted.ForeColor = System.Drawing.Color.LightSlateGray
        Me.txtGradeWanted.Location = New System.Drawing.Point(122, 122)
        Me.txtGradeWanted.Name = "txtGradeWanted"
        Me.txtGradeWanted.Size = New System.Drawing.Size(119, 20)
        Me.txtGradeWanted.TabIndex = 3
        Me.txtGradeWanted.Text = "(e.g. 90 )"
        '
        'lblCurrentGrade
        '
        Me.lblCurrentGrade.AutoSize = True
        Me.lblCurrentGrade.Location = New System.Drawing.Point(15, 61)
        Me.lblCurrentGrade.Name = "lblCurrentGrade"
        Me.lblCurrentGrade.Size = New System.Drawing.Size(105, 13)
        Me.lblCurrentGrade.TabIndex = 4
        Me.lblCurrentGrade.Text = "Your current grade is"
        '
        'lblFinalPercent
        '
        Me.lblFinalPercent.AutoSize = True
        Me.lblFinalPercent.Location = New System.Drawing.Point(30, 90)
        Me.lblFinalPercent.Name = "lblFinalPercent"
        Me.lblFinalPercent.Size = New System.Drawing.Size(90, 13)
        Me.lblFinalPercent.TabIndex = 5
        Me.lblFinalPercent.Text = "Your final is worth"
        '
        'lblGradeWanted
        '
        Me.lblGradeWanted.AutoSize = True
        Me.lblGradeWanted.Location = New System.Drawing.Point(22, 125)
        Me.lblGradeWanted.Name = "lblGradeWanted"
        Me.lblGradeWanted.Size = New System.Drawing.Size(98, 13)
        Me.lblGradeWanted.TabIndex = 6
        Me.lblGradeWanted.Text = "You want at least a" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblSign1
        '
        Me.lblSign1.AutoSize = True
        Me.lblSign1.Location = New System.Drawing.Point(247, 61)
        Me.lblSign1.Name = "lblSign1"
        Me.lblSign1.Size = New System.Drawing.Size(15, 13)
        Me.lblSign1.TabIndex = 7
        Me.lblSign1.Text = "%"
        '
        'lblSign2
        '
        Me.lblSign2.AutoSize = True
        Me.lblSign2.Location = New System.Drawing.Point(247, 90)
        Me.lblSign2.Name = "lblSign2"
        Me.lblSign2.Size = New System.Drawing.Size(15, 13)
        Me.lblSign2.TabIndex = 8
        Me.lblSign2.Text = "%"
        '
        'lblSign3
        '
        Me.lblSign3.AutoSize = True
        Me.lblSign3.Location = New System.Drawing.Point(247, 125)
        Me.lblSign3.Name = "lblSign3"
        Me.lblSign3.Size = New System.Drawing.Size(15, 13)
        Me.lblSign3.TabIndex = 9
        Me.lblSign3.Text = "%"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(315, 262)
        Me.Controls.Add(Me.lblSign3)
        Me.Controls.Add(Me.lblSign2)
        Me.Controls.Add(Me.lblSign1)
        Me.Controls.Add(Me.lblGradeWanted)
        Me.Controls.Add(Me.lblFinalPercent)
        Me.Controls.Add(Me.lblCurrentGrade)
        Me.Controls.Add(Me.txtGradeWanted)
        Me.Controls.Add(Me.txtFinalPercent)
        Me.Controls.Add(Me.txtCurrentGrade)
        Me.Controls.Add(Me.butCalculate)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents butCalculate As System.Windows.Forms.Button
    Friend WithEvents txtCurrentGrade As System.Windows.Forms.TextBox
    Friend WithEvents txtFinalPercent As System.Windows.Forms.TextBox
    Friend WithEvents txtGradeWanted As System.Windows.Forms.TextBox
    Friend WithEvents lblCurrentGrade As System.Windows.Forms.Label
    Friend WithEvents lblFinalPercent As System.Windows.Forms.Label
    Friend WithEvents lblGradeWanted As System.Windows.Forms.Label
    Friend WithEvents lblSign1 As System.Windows.Forms.Label
    Friend WithEvents lblSign2 As System.Windows.Forms.Label
    Friend WithEvents lblSign3 As System.Windows.Forms.Label

End Class
