<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits MetroFramework.Forms.MetroForm

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim Animation11 As AnimatorNS.Animation = New AnimatorNS.Animation()
        Dim Animation12 As AnimatorNS.Animation = New AnimatorNS.Animation()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MetroTile1 = New MetroFramework.Controls.MetroTile()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroComboBox1 = New MetroFramework.Controls.MetroComboBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Animator1 = New AnimatorNS.Animator(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MetroTile2 = New MetroFramework.Controls.MetroTile()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.txtExclude = New System.Windows.Forms.TextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.Animator2 = New AnimatorNS.Animator(Me.components)
        Me.cmbOutputVector = New MetroFramework.Controls.MetroComboBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.MetroTile1)
        Me.Panel1.Controls.Add(Me.MetroLabel1)
        Me.Panel1.Controls.Add(Me.MetroComboBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(20, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(764, 395)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(557, 205)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'MetroTile1
        '
        Me.MetroTile1.ActiveControl = Nothing
        Me.MetroTile1.Location = New System.Drawing.Point(386, 205)
        Me.MetroTile1.Name = "MetroTile1"
        Me.MetroTile1.Size = New System.Drawing.Size(140, 29)
        Me.MetroTile1.TabIndex = 3
        Me.MetroTile1.Text = "Import"
        Me.MetroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.MetroTile1.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(75, 67)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(619, 25)
        Me.MetroLabel1.TabIndex = 2
        Me.MetroLabel1.Text = "Welcome! Let's start by importing your existing data. Choose a CSV file to begin." &
    ""
        Me.MetroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MetroComboBox1
        '
        Me.MetroComboBox1.FormattingEnabled = True
        Me.MetroComboBox1.ItemHeight = 23
        Me.MetroComboBox1.Items.AddRange(New Object() {"Browse..."})
        Me.MetroComboBox1.Location = New System.Drawing.Point(100, 205)
        Me.MetroComboBox1.Name = "MetroComboBox1"
        Me.MetroComboBox1.Size = New System.Drawing.Size(202, 29)
        Me.MetroComboBox1.TabIndex = 1
        Me.MetroComboBox1.UseSelectable = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "CSV Files (*.csv) | *.csv"
        Me.OpenFileDialog1.Title = "Import"
        '
        'Animator1
        '
        Me.Animator1.AnimationType = AnimatorNS.AnimationType.Mosaic
        Me.Animator1.Cursor = Nothing
        Animation11.BlindCoeff = CType(resources.GetObject("Animation11.BlindCoeff"), System.Drawing.PointF)
        Animation11.LeafCoeff = 0!
        Animation11.MosaicCoeff = CType(resources.GetObject("Animation11.MosaicCoeff"), System.Drawing.PointF)
        Animation11.MosaicShift = CType(resources.GetObject("Animation11.MosaicShift"), System.Drawing.PointF)
        Animation11.MosaicSize = 20
        Animation11.Padding = New System.Windows.Forms.Padding(30)
        Animation11.RotateCoeff = 0!
        Animation11.RotateLimit = 0!
        Animation11.ScaleCoeff = CType(resources.GetObject("Animation11.ScaleCoeff"), System.Drawing.PointF)
        Animation11.SlideCoeff = CType(resources.GetObject("Animation11.SlideCoeff"), System.Drawing.PointF)
        Animation11.TimeCoeff = 0!
        Animation11.TransparencyCoeff = 0!
        Me.Animator1.DefaultAnimation = Animation11
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cmbOutputVector)
        Me.Panel2.Controls.Add(Me.MetroTile2)
        Me.Panel2.Controls.Add(Me.MetroLabel4)
        Me.Panel2.Controls.Add(Me.txtExclude)
        Me.Panel2.Controls.Add(Me.MetroLabel3)
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Controls.Add(Me.MetroLabel2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(20, 60)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(764, 395)
        Me.Panel2.TabIndex = 1
        '
        'MetroTile2
        '
        Me.MetroTile2.ActiveControl = Nothing
        Me.MetroTile2.Location = New System.Drawing.Point(611, 65)
        Me.MetroTile2.Name = "MetroTile2"
        Me.MetroTile2.Size = New System.Drawing.Size(128, 31)
        Me.MetroTile2.TabIndex = 8
        Me.MetroTile2.Text = "Continue"
        Me.MetroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.MetroTile2.UseSelectable = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel4.Location = New System.Drawing.Point(308, 67)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(118, 25)
        Me.MetroLabel4.TabIndex = 6
        Me.MetroLabel4.Text = "Output Vector"
        '
        'txtExclude
        '
        Me.txtExclude.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExclude.Location = New System.Drawing.Point(128, 67)
        Me.txtExclude.Name = "txtExclude"
        Me.txtExclude.Size = New System.Drawing.Size(174, 29)
        Me.txtExclude.TabIndex = 5
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel3.Location = New System.Drawing.Point(3, 67)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(119, 25)
        Me.MetroLabel3.TabIndex = 4
        Me.MetroLabel3.Text = "Exclude these:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 104)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(764, 291)
        Me.DataGridView1.TabIndex = 3
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.Location = New System.Drawing.Point(168, 17)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(419, 25)
        Me.MetroLabel2.TabIndex = 2
        Me.MetroLabel2.Text = "CSV imported. Please select the columns to train with."
        '
        'Animator2
        '
        Me.Animator2.AnimationType = AnimatorNS.AnimationType.HorizSlide
        Me.Animator2.Cursor = Nothing
        Animation12.BlindCoeff = CType(resources.GetObject("Animation12.BlindCoeff"), System.Drawing.PointF)
        Animation12.LeafCoeff = 0!
        Animation12.MosaicCoeff = CType(resources.GetObject("Animation12.MosaicCoeff"), System.Drawing.PointF)
        Animation12.MosaicShift = CType(resources.GetObject("Animation12.MosaicShift"), System.Drawing.PointF)
        Animation12.MosaicSize = 0
        Animation12.Padding = New System.Windows.Forms.Padding(0)
        Animation12.RotateCoeff = 0!
        Animation12.RotateLimit = 0!
        Animation12.ScaleCoeff = CType(resources.GetObject("Animation12.ScaleCoeff"), System.Drawing.PointF)
        Animation12.SlideCoeff = CType(resources.GetObject("Animation12.SlideCoeff"), System.Drawing.PointF)
        Animation12.TimeCoeff = 0!
        Animation12.TransparencyCoeff = 0!
        Me.Animator2.DefaultAnimation = Animation12
        '
        'cmbOutputVector
        '
        Me.cmbOutputVector.FormattingEnabled = True
        Me.cmbOutputVector.ItemHeight = 23
        Me.cmbOutputVector.Location = New System.Drawing.Point(442, 67)
        Me.cmbOutputVector.Name = "cmbOutputVector"
        Me.cmbOutputVector.Size = New System.Drawing.Size(145, 29)
        Me.cmbOutputVector.TabIndex = 0
        Me.cmbOutputVector.UseSelectable = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 475)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Bug Assassins"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroComboBox1 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents MetroTile1 As MetroFramework.Controls.MetroTile
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Animator1 As AnimatorNS.Animator
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Animator2 As AnimatorNS.Animator
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtExclude As TextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTile2 As MetroFramework.Controls.MetroTile
    Friend WithEvents cmbOutputVector As MetroFramework.Controls.MetroComboBox
End Class
