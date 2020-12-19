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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Teren = New System.Windows.Forms.Panel()
        Me.LabelIzmdeu = New System.Windows.Forms.Label()
        Me.LabelDrugi = New System.Windows.Forms.Label()
        Me.LabelPrvi = New System.Windows.Forms.Label()
        Me.Reket2 = New System.Windows.Forms.Panel()
        Me.Reket1 = New System.Windows.Forms.Panel()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.lopta = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxVLopte = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBoxReket = New System.Windows.Forms.ComboBox()
        Me.ComboBoxLopta = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxPobjednik = New System.Windows.Forms.TextBox()
        Me.ButtonStart = New System.Windows.Forms.Button()
        Me.ButtonContols = New System.Windows.Forms.Button()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.TimerStop1 = New System.Windows.Forms.Timer(Me.components)
        Me.TimerStop2 = New System.Windows.Forms.Timer(Me.components)
        Me.Teren.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'Teren
        '
        Me.Teren.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Teren.Controls.Add(Me.LabelIzmdeu)
        Me.Teren.Controls.Add(Me.LabelDrugi)
        Me.Teren.Controls.Add(Me.LabelPrvi)
        Me.Teren.Controls.Add(Me.Reket2)
        Me.Teren.Controls.Add(Me.Reket1)
        Me.Teren.Controls.Add(Me.ShapeContainer1)
        Me.Teren.Dock = System.Windows.Forms.DockStyle.Left
        Me.Teren.Location = New System.Drawing.Point(0, 0)
        Me.Teren.Name = "Teren"
        Me.Teren.Size = New System.Drawing.Size(931, 519)
        Me.Teren.TabIndex = 0
        '
        'LabelIzmdeu
        '
        Me.LabelIzmdeu.AutoSize = True
        Me.LabelIzmdeu.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelIzmdeu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LabelIzmdeu.Location = New System.Drawing.Point(451, 9)
        Me.LabelIzmdeu.Name = "LabelIzmdeu"
        Me.LabelIzmdeu.Size = New System.Drawing.Size(27, 38)
        Me.LabelIzmdeu.TabIndex = 4
        Me.LabelIzmdeu.Text = ":"
        '
        'LabelDrugi
        '
        Me.LabelDrugi.AutoSize = True
        Me.LabelDrugi.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDrugi.ForeColor = System.Drawing.Color.Lime
        Me.LabelDrugi.Location = New System.Drawing.Point(494, 9)
        Me.LabelDrugi.Name = "LabelDrugi"
        Me.LabelDrugi.Size = New System.Drawing.Size(36, 38)
        Me.LabelDrugi.TabIndex = 3
        Me.LabelDrugi.Text = "0"
        '
        'LabelPrvi
        '
        Me.LabelPrvi.AutoSize = True
        Me.LabelPrvi.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPrvi.ForeColor = System.Drawing.Color.Lime
        Me.LabelPrvi.Location = New System.Drawing.Point(399, 9)
        Me.LabelPrvi.Name = "LabelPrvi"
        Me.LabelPrvi.Size = New System.Drawing.Size(36, 38)
        Me.LabelPrvi.TabIndex = 1
        Me.LabelPrvi.Text = "0"
        '
        'Reket2
        '
        Me.Reket2.BackColor = System.Drawing.Color.DarkRed
        Me.Reket2.Location = New System.Drawing.Point(902, 155)
        Me.Reket2.Name = "Reket2"
        Me.Reket2.Size = New System.Drawing.Size(26, 157)
        Me.Reket2.TabIndex = 1
        '
        'Reket1
        '
        Me.Reket1.BackColor = System.Drawing.Color.DarkRed
        Me.Reket1.Location = New System.Drawing.Point(12, 155)
        Me.Reket1.Name = "Reket1"
        Me.Reket1.Size = New System.Drawing.Size(26, 157)
        Me.Reket1.TabIndex = 0
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.lopta})
        Me.ShapeContainer1.Size = New System.Drawing.Size(931, 519)
        Me.ShapeContainer1.TabIndex = 2
        Me.ShapeContainer1.TabStop = False
        '
        'lopta
        '
        Me.lopta.BackColor = System.Drawing.Color.Blue
        Me.lopta.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.lopta.Location = New System.Drawing.Point(443, 196)
        Me.lopta.Name = "lopta"
        Me.lopta.Size = New System.Drawing.Size(33, 33)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(955, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Velicina lopte"
        '
        'ComboBoxVLopte
        '
        Me.ComboBoxVLopte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxVLopte.FormattingEnabled = True
        Me.ComboBoxVLopte.Items.AddRange(New Object() {"22", "33 Default", "66"})
        Me.ComboBoxVLopte.Location = New System.Drawing.Point(1088, 25)
        Me.ComboBoxVLopte.Name = "ComboBoxVLopte"
        Me.ComboBoxVLopte.Size = New System.Drawing.Size(118, 24)
        Me.ComboBoxVLopte.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(955, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Brzina Reketa"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1124, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Brzina Lopte"
        '
        'ComboBoxReket
        '
        Me.ComboBoxReket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxReket.FormattingEnabled = True
        Me.ComboBoxReket.Items.AddRange(New Object() {"3 Default", "5", "7"})
        Me.ComboBoxReket.Location = New System.Drawing.Point(959, 112)
        Me.ComboBoxReket.Name = "ComboBoxReket"
        Me.ComboBoxReket.Size = New System.Drawing.Size(118, 24)
        Me.ComboBoxReket.TabIndex = 6
        '
        'ComboBoxLopta
        '
        Me.ComboBoxLopta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxLopta.FormattingEnabled = True
        Me.ComboBoxLopta.Items.AddRange(New Object() {"5 default", "8", "11"})
        Me.ComboBoxLopta.Location = New System.Drawing.Point(1128, 112)
        Me.ComboBoxLopta.Name = "ComboBoxLopta"
        Me.ComboBoxLopta.Size = New System.Drawing.Size(118, 24)
        Me.ComboBoxLopta.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1041, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Pojednik do : "
        '
        'TextBoxPobjednik
        '
        Me.TextBoxPobjednik.Location = New System.Drawing.Point(1045, 189)
        Me.TextBoxPobjednik.Name = "TextBoxPobjednik"
        Me.TextBoxPobjednik.Size = New System.Drawing.Size(100, 22)
        Me.TextBoxPobjednik.TabIndex = 9
        '
        'ButtonStart
        '
        Me.ButtonStart.Location = New System.Drawing.Point(1045, 285)
        Me.ButtonStart.Name = "ButtonStart"
        Me.ButtonStart.Size = New System.Drawing.Size(118, 38)
        Me.ButtonStart.TabIndex = 10
        Me.ButtonStart.Text = "Start"
        Me.ButtonStart.UseVisualStyleBackColor = True
        '
        'ButtonContols
        '
        Me.ButtonContols.Location = New System.Drawing.Point(1045, 339)
        Me.ButtonContols.Name = "ButtonContols"
        Me.ButtonContols.Size = New System.Drawing.Size(118, 38)
        Me.ButtonContols.TabIndex = 11
        Me.ButtonContols.Text = "Kontrole"
        Me.ButtonContols.UseVisualStyleBackColor = True
        '
        'ButtonExit
        '
        Me.ButtonExit.Location = New System.Drawing.Point(1045, 394)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(118, 38)
        Me.ButtonExit.TabIndex = 12
        Me.ButtonExit.Text = "Exit"
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'TimerStop1
        '
        Me.TimerStop1.Interval = 1000
        '
        'TimerStop2
        '
        Me.TimerStop2.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1270, 519)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.ButtonContols)
        Me.Controls.Add(Me.ButtonStart)
        Me.Controls.Add(Me.TextBoxPobjednik)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBoxLopta)
        Me.Controls.Add(Me.ComboBoxReket)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBoxVLopte)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Teren)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1288, 566)
        Me.MinimumSize = New System.Drawing.Size(1288, 566)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form1"
        Me.Teren.ResumeLayout(False)
        Me.Teren.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Teren As Panel
    Friend WithEvents Reket2 As Panel
    Friend WithEvents Reket1 As Panel
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents lopta As PowerPacks.OvalShape
    Friend WithEvents LabelPrvi As Label
    Friend WithEvents LabelIzmdeu As Label
    Friend WithEvents LabelDrugi As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxVLopte As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBoxReket As ComboBox
    Friend WithEvents ComboBoxLopta As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxPobjednik As TextBox
    Friend WithEvents ButtonStart As Button
    Friend WithEvents ButtonContols As Button
    Friend WithEvents ButtonExit As Button
    Friend WithEvents TimerStop1 As Timer
    Friend WithEvents TimerStop2 As Timer
End Class
