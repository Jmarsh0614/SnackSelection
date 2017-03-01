<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSnackSelection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSnackSelection))
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.btnCheeseNCrackers = New System.Windows.Forms.Button()
        Me.btnSaltedPeanuts = New System.Windows.Forms.Button()
        Me.btnChocChipCookies = New System.Windows.Forms.Button()
        Me.btnMiniPretzels = New System.Windows.Forms.Button()
        Me.picCheeseNCrackers = New System.Windows.Forms.PictureBox()
        Me.picChocChipCookies = New System.Windows.Forms.PictureBox()
        Me.picMiniPretzels = New System.Windows.Forms.PictureBox()
        Me.picSaltedPeanuts = New System.Windows.Forms.PictureBox()
        Me.btnConfirmSelection = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblConfirmChoice = New System.Windows.Forms.Label()
        CType(Me.picCheeseNCrackers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picChocChipCookies, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMiniPretzels, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSaltedPeanuts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(182, 9)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(434, 23)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Please make a snack selection from the list"
        '
        'btnCheeseNCrackers
        '
        Me.btnCheeseNCrackers.AutoSize = True
        Me.btnCheeseNCrackers.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnCheeseNCrackers.Location = New System.Drawing.Point(12, 47)
        Me.btnCheeseNCrackers.Name = "btnCheeseNCrackers"
        Me.btnCheeseNCrackers.Size = New System.Drawing.Size(130, 23)
        Me.btnCheeseNCrackers.TabIndex = 1
        Me.btnCheeseNCrackers.Text = "Cheese and Crackers"
        Me.btnCheeseNCrackers.UseVisualStyleBackColor = False
        '
        'btnSaltedPeanuts
        '
        Me.btnSaltedPeanuts.AutoSize = True
        Me.btnSaltedPeanuts.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnSaltedPeanuts.Location = New System.Drawing.Point(12, 179)
        Me.btnSaltedPeanuts.Name = "btnSaltedPeanuts"
        Me.btnSaltedPeanuts.Size = New System.Drawing.Size(130, 23)
        Me.btnSaltedPeanuts.TabIndex = 4
        Me.btnSaltedPeanuts.Text = "Salted Peanuts"
        Me.btnSaltedPeanuts.UseVisualStyleBackColor = False
        '
        'btnChocChipCookies
        '
        Me.btnChocChipCookies.AutoSize = True
        Me.btnChocChipCookies.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnChocChipCookies.Location = New System.Drawing.Point(12, 91)
        Me.btnChocChipCookies.Name = "btnChocChipCookies"
        Me.btnChocChipCookies.Size = New System.Drawing.Size(130, 23)
        Me.btnChocChipCookies.TabIndex = 2
        Me.btnChocChipCookies.Text = "Chocolate Chip Cookies"
        Me.btnChocChipCookies.UseVisualStyleBackColor = False
        '
        'btnMiniPretzels
        '
        Me.btnMiniPretzels.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnMiniPretzels.Location = New System.Drawing.Point(12, 135)
        Me.btnMiniPretzels.Name = "btnMiniPretzels"
        Me.btnMiniPretzels.Size = New System.Drawing.Size(130, 23)
        Me.btnMiniPretzels.TabIndex = 3
        Me.btnMiniPretzels.Text = "Mini Pretzels"
        Me.btnMiniPretzels.UseVisualStyleBackColor = False
        '
        'picCheeseNCrackers
        '
        Me.picCheeseNCrackers.Image = CType(resources.GetObject("picCheeseNCrackers.Image"), System.Drawing.Image)
        Me.picCheeseNCrackers.Location = New System.Drawing.Point(259, 47)
        Me.picCheeseNCrackers.Name = "picCheeseNCrackers"
        Me.picCheeseNCrackers.Size = New System.Drawing.Size(280, 185)
        Me.picCheeseNCrackers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCheeseNCrackers.TabIndex = 5
        Me.picCheeseNCrackers.TabStop = False
        Me.picCheeseNCrackers.Visible = False
        '
        'picChocChipCookies
        '
        Me.picChocChipCookies.BackColor = System.Drawing.SystemColors.HighlightText
        Me.picChocChipCookies.Image = Global.SnackSelection.My.Resources.Resources.grandmas_mini_chocolate_chip
        Me.picChocChipCookies.Location = New System.Drawing.Point(259, 47)
        Me.picChocChipCookies.Name = "picChocChipCookies"
        Me.picChocChipCookies.Size = New System.Drawing.Size(280, 185)
        Me.picChocChipCookies.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picChocChipCookies.TabIndex = 6
        Me.picChocChipCookies.TabStop = False
        Me.picChocChipCookies.Visible = False
        '
        'picMiniPretzels
        '
        Me.picMiniPretzels.Image = Global.SnackSelection.My.Resources.Resources.sny_021_1z
        Me.picMiniPretzels.Location = New System.Drawing.Point(259, 47)
        Me.picMiniPretzels.Name = "picMiniPretzels"
        Me.picMiniPretzels.Size = New System.Drawing.Size(280, 185)
        Me.picMiniPretzels.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMiniPretzels.TabIndex = 7
        Me.picMiniPretzels.TabStop = False
        Me.picMiniPretzels.Visible = False
        '
        'picSaltedPeanuts
        '
        Me.picSaltedPeanuts.Image = Global.SnackSelection.My.Resources.Resources.f99b9861_ca9a_4ac9_8306_f43e94117b93_1_a6532ea2e2434bb60b0a26125781759c
        Me.picSaltedPeanuts.Location = New System.Drawing.Point(259, 47)
        Me.picSaltedPeanuts.Name = "picSaltedPeanuts"
        Me.picSaltedPeanuts.Size = New System.Drawing.Size(280, 185)
        Me.picSaltedPeanuts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSaltedPeanuts.TabIndex = 8
        Me.picSaltedPeanuts.TabStop = False
        Me.picSaltedPeanuts.Visible = False
        '
        'btnConfirmSelection
        '
        Me.btnConfirmSelection.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnConfirmSelection.Enabled = False
        Me.btnConfirmSelection.Location = New System.Drawing.Point(334, 327)
        Me.btnConfirmSelection.Name = "btnConfirmSelection"
        Me.btnConfirmSelection.Size = New System.Drawing.Size(130, 23)
        Me.btnConfirmSelection.TabIndex = 9
        Me.btnConfirmSelection.Text = "Confirm Choice"
        Me.btnConfirmSelection.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.NavajoWhite
        Me.btnExit.Location = New System.Drawing.Point(334, 403)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(130, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit "
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblConfirmChoice
        '
        Me.lblConfirmChoice.AutoSize = True
        Me.lblConfirmChoice.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmChoice.Location = New System.Drawing.Point(31, 287)
        Me.lblConfirmChoice.Name = "lblConfirmChoice"
        Me.lblConfirmChoice.Size = New System.Drawing.Size(686, 19)
        Me.lblConfirmChoice.TabIndex = 10
        Me.lblConfirmChoice.Text = "Choice confirmed! Your snack will be brought out shortly. Thank you for flying wi" &
    "th us." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblConfirmChoice.Visible = False
        '
        'frmSnackSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(749, 481)
        Me.Controls.Add(Me.lblConfirmChoice)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnConfirmSelection)
        Me.Controls.Add(Me.picSaltedPeanuts)
        Me.Controls.Add(Me.picMiniPretzels)
        Me.Controls.Add(Me.picChocChipCookies)
        Me.Controls.Add(Me.picCheeseNCrackers)
        Me.Controls.Add(Me.btnSaltedPeanuts)
        Me.Controls.Add(Me.btnMiniPretzels)
        Me.Controls.Add(Me.btnChocChipCookies)
        Me.Controls.Add(Me.btnCheeseNCrackers)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmSnackSelection"
        Me.Text = "Snack Selection"
        CType(Me.picCheeseNCrackers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picChocChipCookies, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMiniPretzels, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSaltedPeanuts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents btnCheeseNCrackers As Button
    Friend WithEvents btnSaltedPeanuts As Button
    Friend WithEvents btnChocChipCookies As Button
    Friend WithEvents btnMiniPretzels As Button
    Friend WithEvents picCheeseNCrackers As PictureBox
    Friend WithEvents picChocChipCookies As PictureBox
    Friend WithEvents picMiniPretzels As PictureBox
    Friend WithEvents picSaltedPeanuts As PictureBox
    Friend WithEvents btnConfirmSelection As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblConfirmChoice As Label
End Class
