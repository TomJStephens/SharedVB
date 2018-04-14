<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlanetWeight
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PlanetWeight))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.VorM = New System.Windows.Forms.Label()
        Me.lblEnterWeight = New System.Windows.Forms.Label()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.boxWeight = New System.Windows.Forms.GroupBox()
        Me.radMars = New System.Windows.Forms.RadioButton()
        Me.radVenus = New System.Windows.Forms.RadioButton()
        Me.lblResultKg = New System.Windows.Forms.Label()
        Me.lblConvertLbs = New System.Windows.Forms.Label()
        Me.lblConvertKg = New System.Windows.Forms.Label()
        Me.lblResultPound = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.boxWeight.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(431, 369)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'VorM
        '
        Me.VorM.AutoSize = True
        Me.VorM.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VorM.Location = New System.Drawing.Point(560, 28)
        Me.VorM.Name = "VorM"
        Me.VorM.Size = New System.Drawing.Size(234, 33)
        Me.VorM.TabIndex = 1
        Me.VorM.Text = "Venus or Mars?"
        '
        'lblEnterWeight
        '
        Me.lblEnterWeight.AutoSize = True
        Me.lblEnterWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnterWeight.Location = New System.Drawing.Point(478, 77)
        Me.lblEnterWeight.Name = "lblEnterWeight"
        Me.lblEnterWeight.Size = New System.Drawing.Size(194, 25)
        Me.lblEnterWeight.TabIndex = 2
        Me.lblEnterWeight.Text = "Earth weight in lbs:"
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(550, 239)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(75, 23)
        Me.btnDisplay.TabIndex = 4
        Me.btnDisplay.Text = "Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(675, 239)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtWeight
        '
        Me.txtWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeight.Location = New System.Drawing.Point(694, 78)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(100, 26)
        Me.txtWeight.TabIndex = 6
        '
        'boxWeight
        '
        Me.boxWeight.BackColor = System.Drawing.Color.FloralWhite
        Me.boxWeight.Controls.Add(Me.radMars)
        Me.boxWeight.Controls.Add(Me.radVenus)
        Me.boxWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boxWeight.Location = New System.Drawing.Point(516, 121)
        Me.boxWeight.Name = "boxWeight"
        Me.boxWeight.Size = New System.Drawing.Size(289, 92)
        Me.boxWeight.TabIndex = 7
        Me.boxWeight.TabStop = False
        Me.boxWeight.Text = "Convert Weight"
        '
        'radMars
        '
        Me.radMars.AutoSize = True
        Me.radMars.Location = New System.Drawing.Point(19, 55)
        Me.radMars.Name = "radMars"
        Me.radMars.Size = New System.Drawing.Size(215, 24)
        Me.radMars.TabIndex = 1
        Me.radMars.TabStop = True
        Me.radMars.Text = "Convert to Mars Weight"
        Me.radMars.UseVisualStyleBackColor = True
        '
        'radVenus
        '
        Me.radVenus.AutoSize = True
        Me.radVenus.Location = New System.Drawing.Point(19, 25)
        Me.radVenus.Name = "radVenus"
        Me.radVenus.Size = New System.Drawing.Size(223, 24)
        Me.radVenus.TabIndex = 0
        Me.radVenus.TabStop = True
        Me.radVenus.Text = "Convert to Venus weight"
        Me.radVenus.UseVisualStyleBackColor = True
        '
        'lblResultKg
        '
        Me.lblResultKg.AutoSize = True
        Me.lblResultKg.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultKg.Location = New System.Drawing.Point(733, 285)
        Me.lblResultKg.Name = "lblResultKg"
        Me.lblResultKg.Size = New System.Drawing.Size(72, 25)
        Me.lblResultKg.TabIndex = 8
        Me.lblResultKg.Text = "gdgdg"
        Me.lblResultKg.Visible = False
        '
        'lblConvertLbs
        '
        Me.lblConvertLbs.AutoSize = True
        Me.lblConvertLbs.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConvertLbs.Location = New System.Drawing.Point(474, 285)
        Me.lblConvertLbs.Name = "lblConvertLbs"
        Me.lblConvertLbs.Size = New System.Drawing.Size(91, 25)
        Me.lblConvertLbs.TabIndex = 9
        Me.lblConvertLbs.Text = "Pounds:"
        '
        'lblConvertKg
        '
        Me.lblConvertKg.AutoSize = True
        Me.lblConvertKg.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConvertKg.Location = New System.Drawing.Point(668, 285)
        Me.lblConvertKg.Name = "lblConvertKg"
        Me.lblConvertKg.Size = New System.Drawing.Size(59, 25)
        Me.lblConvertKg.TabIndex = 10
        Me.lblConvertKg.Text = "Kg's:"
        '
        'lblResultPound
        '
        Me.lblResultPound.AutoSize = True
        Me.lblResultPound.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultPound.Location = New System.Drawing.Point(571, 285)
        Me.lblResultPound.Name = "lblResultPound"
        Me.lblResultPound.Size = New System.Drawing.Size(72, 25)
        Me.lblResultPound.TabIndex = 11
        Me.lblResultPound.Text = "gdgdg"
        Me.lblResultPound.Visible = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(820, 326)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(45, 23)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'PlanetWeight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Goldenrod
        Me.ClientSize = New System.Drawing.Size(877, 361)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblResultPound)
        Me.Controls.Add(Me.lblConvertKg)
        Me.Controls.Add(Me.lblConvertLbs)
        Me.Controls.Add(Me.lblResultKg)
        Me.Controls.Add(Me.boxWeight)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.lblEnterWeight)
        Me.Controls.Add(Me.VorM)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "PlanetWeight"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.boxWeight.ResumeLayout(False)
        Me.boxWeight.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents VorM As Label
    Friend WithEvents lblEnterWeight As Label
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents boxWeight As GroupBox
    Friend WithEvents radMars As RadioButton
    Friend WithEvents radVenus As RadioButton
    Friend WithEvents lblResultKg As Label
    Friend WithEvents lblConvertLbs As Label
    Friend WithEvents lblConvertKg As Label
    Friend WithEvents lblResultPound As Label
    Friend WithEvents btnExit As Button
End Class
