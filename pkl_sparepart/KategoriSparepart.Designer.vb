<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class KategoriSparepart
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KategoriSparepart))
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtKode = New System.Windows.Forms.TextBox()
        Me.TxtQty = New System.Windows.Forms.NumericUpDown()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CBPackaging = New System.Windows.Forms.ComboBox()
        Me.CBUOM = New System.Windows.Forms.ComboBox()
        Me.CBSubClass = New System.Windows.Forms.ComboBox()
        Me.CBItemClass = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtLeadTime = New System.Windows.Forms.NumericUpDown()
        Me.BtnSimpan = New System.Windows.Forms.PictureBox()
        Me.BtnBack = New System.Windows.Forms.PictureBox()
        CType(Me.TxtQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtLeadTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSimpan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtNama
        '
        Me.TxtNama.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.TxtNama.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.TxtNama.Location = New System.Drawing.Point(169, 95)
        Me.TxtNama.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(503, 32)
        Me.TxtNama.TabIndex = 175
        Me.TxtNama.Text = "DESCRIPTION SPAREPART"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(19, 95)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 20)
        Me.Label9.TabIndex = 174
        Me.Label9.Text = "Description"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(19, 49)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 20)
        Me.Label8.TabIndex = 173
        Me.Label8.Text = "Item Code"
        '
        'TxtKode
        '
        Me.TxtKode.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.TxtKode.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.TxtKode.Location = New System.Drawing.Point(169, 48)
        Me.TxtKode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtKode.Name = "TxtKode"
        Me.TxtKode.ReadOnly = True
        Me.TxtKode.Size = New System.Drawing.Size(335, 32)
        Me.TxtKode.TabIndex = 172
        Me.TxtKode.Text = "Item Code"
        '
        'TxtQty
        '
        Me.TxtQty.Location = New System.Drawing.Point(531, 238)
        Me.TxtQty.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtQty.Name = "TxtQty"
        Me.TxtQty.Size = New System.Drawing.Size(120, 22)
        Me.TxtQty.TabIndex = 199
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(657, 245)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(35, 17)
        Me.Label14.TabIndex = 205
        Me.Label14.Text = "PCS"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(437, 241)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(86, 17)
        Me.Label13.TabIndex = 204
        Me.Label13.Text = "Qty Equal to"
        '
        'CBPackaging
        '
        Me.CBPackaging.FormattingEnabled = True
        Me.CBPackaging.Items.AddRange(New Object() {"PRE576       PACK @576", "PRE648       PACK @648", "BTL72          PACK @72", "BTL96          PACK @96", "PAIL             PAIL", "PSG             PASANG", "PCS             PCS", "ROLL           ROLL", "SAK             SAK", "SAK020       SAK @ 20KG", "SAK025       SAK @ 25KG", "SET             SET", "TRUK          TRUCK", "TUBE           TUBE", "UNIT            UNIT"})
        Me.CBPackaging.Location = New System.Drawing.Point(169, 238)
        Me.CBPackaging.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CBPackaging.Name = "CBPackaging"
        Me.CBPackaging.Size = New System.Drawing.Size(249, 24)
        Me.CBPackaging.TabIndex = 198
        '
        'CBUOM
        '
        Me.CBUOM.FormattingEnabled = True
        Me.CBUOM.Items.AddRange(New Object() {"PRE576          PACK @576", "PRE648          PACK @648", "BTL72             PACK @72", "BTL96             PACK @96", "PAIL                PAIL", "PSG                 PASANG", "PCS                 PCS", "ROLL               ROLL", "SAK                 SAK", "SAK020           SAK @ 20KG", "SAK025           SAK @ 25KG", "SET                 SET", "TRUK              TRUCK", "TUBE              TUBE", "UNIT               UNIT"})
        Me.CBUOM.Location = New System.Drawing.Point(169, 207)
        Me.CBUOM.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CBUOM.Name = "CBUOM"
        Me.CBUOM.Size = New System.Drawing.Size(249, 24)
        Me.CBUOM.TabIndex = 197
        '
        'CBSubClass
        '
        Me.CBSubClass.FormatString = "15"
        Me.CBSubClass.FormattingEnabled = True
        Me.CBSubClass.Items.AddRange(New Object() {"0 RING                 0R", "BELT                    BL", "CHAIN                  CHN", "ELEKTRIK            ELEK", "GREASE               GS", "HEATHER            SP-099", "ILLIG                     ILLIG", "INSERT                INSERT", "KABEL                  KABEL", "KOMPRESSOR    KOMP", "LAMPU                 LAMP", "LEM                      LEM", "LOCKER               LOCK", "MOTOR                MTR", "NEPEL                  SMC"})
        Me.CBSubClass.Location = New System.Drawing.Point(169, 178)
        Me.CBSubClass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CBSubClass.Name = "CBSubClass"
        Me.CBSubClass.Size = New System.Drawing.Size(249, 24)
        Me.CBSubClass.TabIndex = 196
        '
        'CBItemClass
        '
        Me.CBItemClass.AllowDrop = True
        Me.CBItemClass.BackColor = System.Drawing.SystemColors.Window
        Me.CBItemClass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CBItemClass.FormattingEnabled = True
        Me.CBItemClass.Items.AddRange(New Object() {"SPAREPART"})
        Me.CBItemClass.Location = New System.Drawing.Point(169, 146)
        Me.CBItemClass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CBItemClass.Name = "CBItemClass"
        Me.CBItemClass.Size = New System.Drawing.Size(249, 24)
        Me.CBItemClass.TabIndex = 195
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(21, 241)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 17)
        Me.Label12.TabIndex = 203
        Me.Label12.Text = "Packaging"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 180)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 17)
        Me.Label7.TabIndex = 202
        Me.Label7.Text = "Sub Class"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 148)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 17)
        Me.Label6.TabIndex = 201
        Me.Label6.Text = "Item Class"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(21, 210)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(118, 17)
        Me.Label11.TabIndex = 200
        Me.Label11.Text = "Unit Of Measures"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 270)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 17)
        Me.Label2.TabIndex = 207
        Me.Label2.Text = "Lead Time"
        Me.Label2.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(295, 273)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 17)
        Me.Label5.TabIndex = 208
        Me.Label5.Text = "day(s)"
        Me.Label5.Visible = False
        '
        'TxtLeadTime
        '
        Me.TxtLeadTime.Location = New System.Drawing.Point(169, 268)
        Me.TxtLeadTime.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtLeadTime.Name = "TxtLeadTime"
        Me.TxtLeadTime.Size = New System.Drawing.Size(120, 22)
        Me.TxtLeadTime.TabIndex = 206
        Me.TxtLeadTime.Visible = False
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Image = CType(resources.GetObject("BtnSimpan.Image"), System.Drawing.Image)
        Me.BtnSimpan.Location = New System.Drawing.Point(605, 11)
        Me.BtnSimpan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(37, 39)
        Me.BtnSimpan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnSimpan.TabIndex = 194
        Me.BtnSimpan.TabStop = False
        '
        'BtnBack
        '
        Me.BtnBack.Image = CType(resources.GetObject("BtnBack.Image"), System.Drawing.Image)
        Me.BtnBack.Location = New System.Drawing.Point(648, 17)
        Me.BtnBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(29, 28)
        Me.BtnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnBack.TabIndex = 193
        Me.BtnBack.TabStop = False
        '
        'KategoriSparepart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(739, 361)
        Me.Controls.Add(Me.TxtLeadTime)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtQty)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.CBPackaging)
        Me.Controls.Add(Me.CBUOM)
        Me.Controls.Add(Me.CBSubClass)
        Me.Controls.Add(Me.CBItemClass)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.TxtNama)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtKode)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "KategoriSparepart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KategoriSparepart"
        CType(Me.TxtQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtLeadTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSimpan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtNama As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtKode As TextBox
    Friend WithEvents BtnSimpan As PictureBox
    Friend WithEvents BtnBack As PictureBox
    Friend WithEvents TxtQty As NumericUpDown
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents CBPackaging As ComboBox
    Friend WithEvents CBUOM As ComboBox
    Friend WithEvents CBSubClass As ComboBox
    Friend WithEvents CBItemClass As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtLeadTime As NumericUpDown
End Class
