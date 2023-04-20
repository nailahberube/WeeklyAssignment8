<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTextBoxApplication
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblElectricSavings = New System.Windows.Forms.Label()
        Me.lblAverageMonthlySavings = New System.Windows.Forms.Label()
        Me.lblSignificantMonthlySavings = New System.Windows.Forms.Label()
        Me.btnDisplayStatistics = New System.Windows.Forms.Button()
        Me.cboMonths = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WeeklyAssignment8.My.Resources.Resources.smarthome
        Me.PictureBox1.Location = New System.Drawing.Point(0, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(368, 260)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft YaHei", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(457, 32)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(276, 84)
        Me.lblHeading.TabIndex = 1
        Me.lblHeading.Text = "Smart Home" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Electric Savings "
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblElectricSavings
        '
        Me.lblElectricSavings.Font = New System.Drawing.Font("Microsoft YaHei", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblElectricSavings.Location = New System.Drawing.Point(305, 281)
        Me.lblElectricSavings.Name = "lblElectricSavings"
        Me.lblElectricSavings.Size = New System.Drawing.Size(428, 22)
        Me.lblElectricSavings.TabIndex = 2
        Me.lblElectricSavings.Text = "XXXXXXXXXXXXXX"
        '
        'lblAverageMonthlySavings
        '
        Me.lblAverageMonthlySavings.Font = New System.Drawing.Font("Microsoft YaHei", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageMonthlySavings.Location = New System.Drawing.Point(295, 372)
        Me.lblAverageMonthlySavings.Name = "lblAverageMonthlySavings"
        Me.lblAverageMonthlySavings.Size = New System.Drawing.Size(438, 22)
        Me.lblAverageMonthlySavings.TabIndex = 3
        Me.lblAverageMonthlySavings.Text = "XXXXXXXXXXXXXX"
        '
        'lblSignificantMonthlySavings
        '
        Me.lblSignificantMonthlySavings.Font = New System.Drawing.Font("Microsoft YaHei", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignificantMonthlySavings.Location = New System.Drawing.Point(259, 410)
        Me.lblSignificantMonthlySavings.Name = "lblSignificantMonthlySavings"
        Me.lblSignificantMonthlySavings.Size = New System.Drawing.Size(474, 22)
        Me.lblSignificantMonthlySavings.TabIndex = 4
        Me.lblSignificantMonthlySavings.Text = "XXXXXXXXXXXXXX"
        '
        'btnDisplayStatistics
        '
        Me.btnDisplayStatistics.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnDisplayStatistics.Font = New System.Drawing.Font("Microsoft YaHei", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplayStatistics.ForeColor = System.Drawing.Color.White
        Me.btnDisplayStatistics.Location = New System.Drawing.Point(355, 316)
        Me.btnDisplayStatistics.Name = "btnDisplayStatistics"
        Me.btnDisplayStatistics.Size = New System.Drawing.Size(193, 41)
        Me.btnDisplayStatistics.TabIndex = 5
        Me.btnDisplayStatistics.Text = "Display Statistics"
        Me.btnDisplayStatistics.UseVisualStyleBackColor = False
        '
        'cboMonths
        '
        Me.cboMonths.FormattingEnabled = True
        Me.cboMonths.Location = New System.Drawing.Point(523, 138)
        Me.cboMonths.Name = "cboMonths"
        Me.cboMonths.Size = New System.Drawing.Size(121, 28)
        Me.cboMonths.TabIndex = 6
        '
        'frmTextBoxApplication
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cboMonths)
        Me.Controls.Add(Me.btnDisplayStatistics)
        Me.Controls.Add(Me.lblSignificantMonthlySavings)
        Me.Controls.Add(Me.lblAverageMonthlySavings)
        Me.Controls.Add(Me.lblElectricSavings)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmTextBoxApplication"
        Me.Text = "Smart Home Application"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblElectricSavings As Label
    Friend WithEvents lblAverageMonthlySavings As Label
    Friend WithEvents lblSignificantMonthlySavings As Label
    Friend WithEvents btnDisplayStatistics As Button
    Friend WithEvents cboMonths As ComboBox
End Class
