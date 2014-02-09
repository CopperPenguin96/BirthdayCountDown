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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblSeconds = New System.Windows.Forms.Label()
        Me.lblMinutes = New System.Windows.Forms.Label()
        Me.lblHours = New System.Windows.Forms.Label()
        Me.lblDays = New System.Windows.Forms.Label()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.Countdown = New System.Windows.Forms.Timer(Me.components)
        Me.lblHalfSeconds = New System.Windows.Forms.Label()
        Me.picFireworks = New System.Windows.Forms.PictureBox()
        CType(Me.picFireworks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSeconds
        '
        Me.lblSeconds.BackColor = System.Drawing.Color.Transparent
        Me.lblSeconds.ForeColor = System.Drawing.Color.White
        Me.lblSeconds.Location = New System.Drawing.Point(345, 123)
        Me.lblSeconds.Name = "lblSeconds"
        Me.lblSeconds.Size = New System.Drawing.Size(100, 23)
        Me.lblSeconds.TabIndex = 11
        Me.lblSeconds.Text = "{Seconds}"
        Me.lblSeconds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMinutes
        '
        Me.lblMinutes.BackColor = System.Drawing.Color.Transparent
        Me.lblMinutes.ForeColor = System.Drawing.Color.White
        Me.lblMinutes.Location = New System.Drawing.Point(345, 100)
        Me.lblMinutes.Name = "lblMinutes"
        Me.lblMinutes.Size = New System.Drawing.Size(100, 23)
        Me.lblMinutes.TabIndex = 10
        Me.lblMinutes.Text = "{Minutes}"
        Me.lblMinutes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHours
        '
        Me.lblHours.BackColor = System.Drawing.Color.Transparent
        Me.lblHours.ForeColor = System.Drawing.Color.White
        Me.lblHours.Location = New System.Drawing.Point(345, 77)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(100, 23)
        Me.lblHours.TabIndex = 9
        Me.lblHours.Text = "{Hours}"
        Me.lblHours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDays
        '
        Me.lblDays.BackColor = System.Drawing.Color.Transparent
        Me.lblDays.ForeColor = System.Drawing.Color.White
        Me.lblDays.Location = New System.Drawing.Point(345, 54)
        Me.lblDays.Name = "lblDays"
        Me.lblDays.Size = New System.Drawing.Size(100, 23)
        Me.lblDays.TabIndex = 8
        Me.lblDays.Text = "{Days}"
        Me.lblDays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHeader
        '
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.White
        Me.lblHeader.Location = New System.Drawing.Point(12, 0)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(766, 38)
        Me.lblHeader.TabIndex = 7
        Me.lblHeader.Text = "Birthday Countdown"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Countdown
        '
        Me.Countdown.Enabled = True
        '
        'lblHalfSeconds
        '
        Me.lblHalfSeconds.BackColor = System.Drawing.Color.Transparent
        Me.lblHalfSeconds.ForeColor = System.Drawing.Color.White
        Me.lblHalfSeconds.Location = New System.Drawing.Point(345, 146)
        Me.lblHalfSeconds.Name = "lblHalfSeconds"
        Me.lblHalfSeconds.Size = New System.Drawing.Size(100, 23)
        Me.lblHalfSeconds.TabIndex = 12
        Me.lblHalfSeconds.Text = "{HalfSeconds}"
        Me.lblHalfSeconds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picFireworks
        '
        Me.picFireworks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picFireworks.Image = CType(resources.GetObject("picFireworks.Image"), System.Drawing.Image)
        Me.picFireworks.Location = New System.Drawing.Point(0, 0)
        Me.picFireworks.Name = "picFireworks"
        Me.picFireworks.Size = New System.Drawing.Size(790, 250)
        Me.picFireworks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFireworks.TabIndex = 13
        Me.picFireworks.TabStop = False
        Me.picFireworks.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(790, 250)
        Me.Controls.Add(Me.lblSeconds)
        Me.Controls.Add(Me.lblMinutes)
        Me.Controls.Add(Me.lblHours)
        Me.Controls.Add(Me.lblDays)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.lblHalfSeconds)
        Me.Controls.Add(Me.picFireworks)
        Me.Name = "Form1"
        Me.Text = "Birthday Countdown"
        CType(Me.picFireworks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblSeconds As System.Windows.Forms.Label
    Friend WithEvents lblMinutes As System.Windows.Forms.Label
    Friend WithEvents lblHours As System.Windows.Forms.Label
    Friend WithEvents lblDays As System.Windows.Forms.Label
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents Countdown As System.Windows.Forms.Timer
    Friend WithEvents lblHalfSeconds As System.Windows.Forms.Label
    Friend WithEvents picFireworks As System.Windows.Forms.PictureBox

End Class
