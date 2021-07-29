<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Editor
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Editor))
        Me.Bar = New System.Windows.Forms.ToolStrip()
        Me.Projector = New System.Windows.Forms.ToolStripLabel()
        Me.LightSaver = New System.Windows.Forms.ToolStripDropDownButton()
        Me.Öncekiler = New System.Windows.Forms.ToolStripButton()
        Me.NXT = New System.Windows.Forms.ToolStripButton()
        Me.Pixar = New System.Windows.Forms.ToolStripDropDownButton()
        Me.SquezeToTopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SqueseToLeftToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FadeInAndOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KapatŞunu = New System.Windows.Forms.Label()
        Me.BaşlıkSağTık = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MetinSağTık = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FontToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResimSeç = New System.Windows.Forms.OpenFileDialog()
        Me.GeriZekalı = New System.Windows.Forms.Label()
        Me.YürüGit = New System.Windows.Forms.Label()
        Me.LinkAt = New System.Windows.Forms.TextBox()
        Me.İleriZekalı = New System.Windows.Forms.Label()
        Me.GeriDönüşüm = New System.Windows.Forms.Label()
        Me.TaramalıSayfa = New System.Windows.Forms.TabPage()
        Me.SaçTarayıcı = New System.Windows.Forms.WebBrowser()
        Me.AnaEkran = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.Başlık = New System.Windows.Forms.RichTextBox()
        Me.ÜstResim = New System.Windows.Forms.PictureBox()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.AltResim = New System.Windows.Forms.PictureBox()
        Me.anavideo = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Metin2 = New System.Windows.Forms.RichTextBox()
        Me.SekmeYönetici = New System.Windows.Forms.TabControl()
        Me.BabaEkran = New System.Windows.Forms.TabPage()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BekResim = New System.Windows.Forms.PictureBox()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.yokol = New System.Windows.Forms.Timer(Me.components)
        Me.çık = New System.Windows.Forms.Timer(Me.components)
        Me.kay = New System.Windows.Forms.Timer(Me.components)
        Me.vrl = New System.Windows.Forms.Timer(Me.components)
        Me.Bar.SuspendLayout()
        Me.BaşlıkSağTık.SuspendLayout()
        Me.MetinSağTık.SuspendLayout()
        Me.TaramalıSayfa.SuspendLayout()
        Me.AnaEkran.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.ÜstResim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.AltResim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.anavideo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SekmeYönetici.SuspendLayout()
        Me.BabaEkran.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BekResim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Bar
        '
        Me.Bar.BackColor = System.Drawing.Color.SteelBlue
        Me.Bar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Projector, Me.LightSaver, Me.Öncekiler, Me.NXT, Me.Pixar})
        Me.Bar.Location = New System.Drawing.Point(0, 0)
        Me.Bar.Name = "Bar"
        Me.Bar.Size = New System.Drawing.Size(800, 27)
        Me.Bar.TabIndex = 0
        Me.Bar.Text = "ToolStrip1"
        '
        'Projector
        '
        Me.Projector.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Projector.ForeColor = System.Drawing.Color.White
        Me.Projector.Name = "Projector"
        Me.Projector.Size = New System.Drawing.Size(86, 24)
        Me.Projector.Text = "PROJΣCTOR "
        '
        'LightSaver
        '
        Me.LightSaver.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.LightSaver.ForeColor = System.Drawing.Color.White
        Me.LightSaver.Image = CType(resources.GetObject("LightSaver.Image"), System.Drawing.Image)
        Me.LightSaver.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.LightSaver.Name = "LightSaver"
        Me.LightSaver.Size = New System.Drawing.Size(44, 24)
        Me.LightSaver.Text = "Save"
        '
        'Öncekiler
        '
        Me.Öncekiler.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Öncekiler.ForeColor = System.Drawing.Color.White
        Me.Öncekiler.Image = CType(resources.GetObject("Öncekiler.Image"), System.Drawing.Image)
        Me.Öncekiler.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Öncekiler.Name = "Öncekiler"
        Me.Öncekiler.Size = New System.Drawing.Size(56, 24)
        Me.Öncekiler.Text = "Previous"
        '
        'NXT
        '
        Me.NXT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.NXT.ForeColor = System.Drawing.Color.White
        Me.NXT.Image = CType(resources.GetObject("NXT.Image"), System.Drawing.Image)
        Me.NXT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NXT.Name = "NXT"
        Me.NXT.Size = New System.Drawing.Size(35, 24)
        Me.NXT.Text = "Next"
        '
        'Pixar
        '
        Me.Pixar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Pixar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SquezeToTopToolStripMenuItem, Me.SqueseToLeftToolStripMenuItem, Me.FadeInAndOutToolStripMenuItem})
        Me.Pixar.ForeColor = System.Drawing.Color.White
        Me.Pixar.Image = CType(resources.GetObject("Pixar.Image"), System.Drawing.Image)
        Me.Pixar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Pixar.Name = "Pixar"
        Me.Pixar.Size = New System.Drawing.Size(76, 24)
        Me.Pixar.Text = "Animation"
        '
        'SquezeToTopToolStripMenuItem
        '
        Me.SquezeToTopToolStripMenuItem.Name = "SquezeToTopToolStripMenuItem"
        Me.SquezeToTopToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.SquezeToTopToolStripMenuItem.Text = "Squeze To Top"
        '
        'SqueseToLeftToolStripMenuItem
        '
        Me.SqueseToLeftToolStripMenuItem.Name = "SqueseToLeftToolStripMenuItem"
        Me.SqueseToLeftToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.SqueseToLeftToolStripMenuItem.Text = "Squese To Left "
        '
        'FadeInAndOutToolStripMenuItem
        '
        Me.FadeInAndOutToolStripMenuItem.Name = "FadeInAndOutToolStripMenuItem"
        Me.FadeInAndOutToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.FadeInAndOutToolStripMenuItem.Text = "Fade In and Out"
        '
        'KapatŞunu
        '
        Me.KapatŞunu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KapatŞunu.AutoSize = True
        Me.KapatŞunu.BackColor = System.Drawing.Color.SteelBlue
        Me.KapatŞunu.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.KapatŞunu.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.KapatŞunu.Location = New System.Drawing.Point(771, 0)
        Me.KapatŞunu.Name = "KapatŞunu"
        Me.KapatŞunu.Size = New System.Drawing.Size(25, 24)
        Me.KapatŞunu.TabIndex = 2
        Me.KapatŞunu.Text = "Ø"
        '
        'BaşlıkSağTık
        '
        Me.BaşlıkSağTık.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FontToolStripMenuItem})
        Me.BaşlıkSağTık.Name = "BaşlıkSağTık"
        Me.BaşlıkSağTık.Size = New System.Drawing.Size(99, 26)
        Me.BaşlıkSağTık.Text = "You clicked it Right!"
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.FontToolStripMenuItem.Text = "Font"
        '
        'MetinSağTık
        '
        Me.MetinSağTık.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FontToolStripMenuItem1})
        Me.MetinSağTık.Name = "MetinSağTık"
        Me.MetinSağTık.Size = New System.Drawing.Size(99, 26)
        Me.MetinSağTık.Text = "You clicked it not left!"
        '
        'FontToolStripMenuItem1
        '
        Me.FontToolStripMenuItem1.Name = "FontToolStripMenuItem1"
        Me.FontToolStripMenuItem1.Size = New System.Drawing.Size(98, 22)
        Me.FontToolStripMenuItem1.Text = "Font"
        '
        'ResimSeç
        '
        Me.ResimSeç.Filter = "Images | *.png;*.jpg;*.jpeg;*.bmp;*.tiff;*.tif;*.gif|All Files|*.*"
        '
        'GeriZekalı
        '
        Me.GeriZekalı.AutoSize = True
        Me.GeriZekalı.BackColor = System.Drawing.Color.SteelBlue
        Me.GeriZekalı.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!)
        Me.GeriZekalı.ForeColor = System.Drawing.Color.White
        Me.GeriZekalı.Location = New System.Drawing.Point(305, -2)
        Me.GeriZekalı.Name = "GeriZekalı"
        Me.GeriZekalı.Size = New System.Drawing.Size(37, 26)
        Me.GeriZekalı.TabIndex = 3
        Me.GeriZekalı.Text = "☚"
        '
        'YürüGit
        '
        Me.YürüGit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.YürüGit.AutoSize = True
        Me.YürüGit.BackColor = System.Drawing.Color.SteelBlue
        Me.YürüGit.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!)
        Me.YürüGit.ForeColor = System.Drawing.Color.White
        Me.YürüGit.Location = New System.Drawing.Point(667, 0)
        Me.YürüGit.Name = "YürüGit"
        Me.YürüGit.Size = New System.Drawing.Size(37, 26)
        Me.YürüGit.TabIndex = 4
        Me.YürüGit.Text = "☄"
        '
        'LinkAt
        '
        Me.LinkAt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkAt.Location = New System.Drawing.Point(391, 4)
        Me.LinkAt.Name = "LinkAt"
        Me.LinkAt.Size = New System.Drawing.Size(270, 20)
        Me.LinkAt.TabIndex = 5
        '
        'İleriZekalı
        '
        Me.İleriZekalı.AutoSize = True
        Me.İleriZekalı.BackColor = System.Drawing.Color.SteelBlue
        Me.İleriZekalı.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!)
        Me.İleriZekalı.ForeColor = System.Drawing.Color.White
        Me.İleriZekalı.Location = New System.Drawing.Point(348, -3)
        Me.İleriZekalı.Name = "İleriZekalı"
        Me.İleriZekalı.Size = New System.Drawing.Size(37, 26)
        Me.İleriZekalı.TabIndex = 6
        Me.İleriZekalı.Text = "☛"
        '
        'GeriDönüşüm
        '
        Me.GeriDönüşüm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GeriDönüşüm.AutoSize = True
        Me.GeriDönüşüm.BackColor = System.Drawing.Color.SteelBlue
        Me.GeriDönüşüm.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!)
        Me.GeriDönüşüm.ForeColor = System.Drawing.Color.White
        Me.GeriDönüşüm.Location = New System.Drawing.Point(710, 0)
        Me.GeriDönüşüm.Name = "GeriDönüşüm"
        Me.GeriDönüşüm.Size = New System.Drawing.Size(35, 26)
        Me.GeriDönüşüm.TabIndex = 7
        Me.GeriDönüşüm.Text = "♻"
        '
        'TaramalıSayfa
        '
        Me.TaramalıSayfa.Controls.Add(Me.SaçTarayıcı)
        Me.TaramalıSayfa.Location = New System.Drawing.Point(4, 22)
        Me.TaramalıSayfa.Name = "TaramalıSayfa"
        Me.TaramalıSayfa.Padding = New System.Windows.Forms.Padding(3)
        Me.TaramalıSayfa.Size = New System.Drawing.Size(792, 397)
        Me.TaramalıSayfa.TabIndex = 1
        Me.TaramalıSayfa.Text = "Web Browser"
        Me.TaramalıSayfa.UseVisualStyleBackColor = True
        '
        'SaçTarayıcı
        '
        Me.SaçTarayıcı.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SaçTarayıcı.Location = New System.Drawing.Point(3, 3)
        Me.SaçTarayıcı.MinimumSize = New System.Drawing.Size(20, 20)
        Me.SaçTarayıcı.Name = "SaçTarayıcı"
        Me.SaçTarayıcı.Size = New System.Drawing.Size(786, 391)
        Me.SaçTarayıcı.TabIndex = 0
        Me.SaçTarayıcı.Url = New System.Uri("http://www.google.com", System.UriKind.Absolute)
        '
        'AnaEkran
        '
        Me.AnaEkran.BackColor = System.Drawing.Color.Black
        Me.AnaEkran.Controls.Add(Me.SplitContainer1)
        Me.AnaEkran.Location = New System.Drawing.Point(4, 22)
        Me.AnaEkran.Name = "AnaEkran"
        Me.AnaEkran.Padding = New System.Windows.Forms.Padding(3)
        Me.AnaEkran.Size = New System.Drawing.Size(792, 397)
        Me.AnaEkran.TabIndex = 0
        Me.AnaEkran.Text = "Editor"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer1.Panel1MinSize = 0
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Panel2MinSize = 0
        Me.SplitContainer1.Size = New System.Drawing.Size(786, 391)
        Me.SplitContainer1.SplitterDistance = 64
        Me.SplitContainer1.TabIndex = 2
        '
        'SplitContainer3
        '
        Me.SplitContainer3.BackColor = System.Drawing.Color.Black
        Me.SplitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.BackColor = System.Drawing.Color.Black
        Me.SplitContainer3.Panel1.Controls.Add(Me.Başlık)
        Me.SplitContainer3.Panel1MinSize = 0
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.ÜstResim)
        Me.SplitContainer3.Panel2MinSize = 0
        Me.SplitContainer3.Size = New System.Drawing.Size(786, 64)
        Me.SplitContainer3.SplitterDistance = 582
        Me.SplitContainer3.TabIndex = 2
        '
        'Başlık
        '
        Me.Başlık.BackColor = System.Drawing.Color.Black
        Me.Başlık.ContextMenuStrip = Me.BaşlıkSağTık
        Me.Başlık.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Başlık.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!)
        Me.Başlık.ForeColor = System.Drawing.Color.White
        Me.Başlık.Location = New System.Drawing.Point(0, 0)
        Me.Başlık.Name = "Başlık"
        Me.Başlık.Size = New System.Drawing.Size(578, 60)
        Me.Başlık.TabIndex = 0
        Me.Başlık.Text = ""
        '
        'ÜstResim
        '
        Me.ÜstResim.BackColor = System.Drawing.Color.Black
        Me.ÜstResim.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ÜstResim.Image = CType(resources.GetObject("ÜstResim.Image"), System.Drawing.Image)
        Me.ÜstResim.Location = New System.Drawing.Point(0, 0)
        Me.ÜstResim.Name = "ÜstResim"
        Me.ÜstResim.Size = New System.Drawing.Size(196, 60)
        Me.ÜstResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ÜstResim.TabIndex = 1
        Me.ÜstResim.TabStop = False
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.AltResim)
        Me.SplitContainer2.Panel1.Controls.Add(Me.anavideo)
        Me.SplitContainer2.Panel1MinSize = 0
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.Metin2)
        Me.SplitContainer2.Panel2MinSize = 0
        Me.SplitContainer2.Size = New System.Drawing.Size(786, 323)
        Me.SplitContainer2.SplitterDistance = 535
        Me.SplitContainer2.TabIndex = 2
        '
        'AltResim
        '
        Me.AltResim.BackColor = System.Drawing.Color.Black
        Me.AltResim.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AltResim.Image = CType(resources.GetObject("AltResim.Image"), System.Drawing.Image)
        Me.AltResim.Location = New System.Drawing.Point(0, 0)
        Me.AltResim.Name = "AltResim"
        Me.AltResim.Size = New System.Drawing.Size(531, 319)
        Me.AltResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.AltResim.TabIndex = 0
        Me.AltResim.TabStop = False
        '
        'anavideo
        '
        Me.anavideo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.anavideo.Enabled = True
        Me.anavideo.Location = New System.Drawing.Point(0, 0)
        Me.anavideo.Name = "anavideo"
        Me.anavideo.OcxState = CType(resources.GetObject("anavideo.OcxState"), System.Windows.Forms.AxHost.State)
        Me.anavideo.Size = New System.Drawing.Size(531, 319)
        Me.anavideo.TabIndex = 1
        '
        'Metin2
        '
        Me.Metin2.BackColor = System.Drawing.Color.Black
        Me.Metin2.ContextMenuStrip = Me.MetinSağTık
        Me.Metin2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Metin2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!)
        Me.Metin2.ForeColor = System.Drawing.Color.White
        Me.Metin2.Location = New System.Drawing.Point(0, 0)
        Me.Metin2.Name = "Metin2"
        Me.Metin2.Size = New System.Drawing.Size(243, 319)
        Me.Metin2.TabIndex = 1
        Me.Metin2.Text = ""
        '
        'SekmeYönetici
        '
        Me.SekmeYönetici.Controls.Add(Me.AnaEkran)
        Me.SekmeYönetici.Controls.Add(Me.BabaEkran)
        Me.SekmeYönetici.Controls.Add(Me.TaramalıSayfa)
        Me.SekmeYönetici.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SekmeYönetici.Location = New System.Drawing.Point(0, 27)
        Me.SekmeYönetici.Name = "SekmeYönetici"
        Me.SekmeYönetici.SelectedIndex = 0
        Me.SekmeYönetici.Size = New System.Drawing.Size(800, 423)
        Me.SekmeYönetici.TabIndex = 1
        '
        'BabaEkran
        '
        Me.BabaEkran.BackColor = System.Drawing.Color.DodgerBlue
        Me.BabaEkran.Controls.Add(Me.ComboBox1)
        Me.BabaEkran.Controls.Add(Me.Label3)
        Me.BabaEkran.Controls.Add(Me.Label2)
        Me.BabaEkran.Controls.Add(Me.TrackBar1)
        Me.BabaEkran.Controls.Add(Me.TextBox1)
        Me.BabaEkran.Controls.Add(Me.Button1)
        Me.BabaEkran.Controls.Add(Me.Label1)
        Me.BabaEkran.Controls.Add(Me.BekResim)
        Me.BabaEkran.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.BabaEkran.Location = New System.Drawing.Point(4, 22)
        Me.BabaEkran.Name = "BabaEkran"
        Me.BabaEkran.Padding = New System.Windows.Forms.Padding(3)
        Me.BabaEkran.Size = New System.Drawing.Size(792, 397)
        Me.BabaEkran.TabIndex = 3
        Me.BabaEkran.Text = "The Project"
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(448, 333)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(336, 21)
        Me.ComboBox1.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(445, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Opacity:"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(747, 194)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "%86"
        '
        'TrackBar1
        '
        Me.TrackBar1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TrackBar1.AutoSize = False
        Me.TrackBar1.Location = New System.Drawing.Point(490, 191)
        Me.TrackBar1.Maximum = 100
        Me.TrackBar1.Minimum = 10
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(254, 25)
        Me.TrackBar1.TabIndex = 8
        Me.TrackBar1.TickStyle = System.Windows.Forms.TickStyle.None
        Me.TrackBar1.Value = 86
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(448, 75)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(221, 20)
        Me.TextBox1.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(675, 73)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "BackGround Image"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 32.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(526, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 58)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Projector"
        '
        'BekResim
        '
        Me.BekResim.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BekResim.BackColor = System.Drawing.Color.Transparent
        Me.BekResim.Image = CType(resources.GetObject("BekResim.Image"), System.Drawing.Image)
        Me.BekResim.InitialImage = Nothing
        Me.BekResim.Location = New System.Drawing.Point(0, 0)
        Me.BekResim.Name = "BekResim"
        Me.BekResim.Size = New System.Drawing.Size(442, 397)
        Me.BekResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BekResim.TabIndex = 0
        Me.BekResim.TabStop = False
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(0, 0)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(442, 397)
        Me.AxWindowsMediaPlayer1.TabIndex = 1
        '
        'yokol
        '
        Me.yokol.Interval = 4
        '
        'çık
        '
        Me.çık.Interval = 4
        '
        'kay
        '
        Me.kay.Interval = 4
        '
        'vrl
        '
        Me.vrl.Interval = 4
        '
        'Editor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SekmeYönetici)
        Me.Controls.Add(Me.GeriDönüşüm)
        Me.Controls.Add(Me.İleriZekalı)
        Me.Controls.Add(Me.LinkAt)
        Me.Controls.Add(Me.YürüGit)
        Me.Controls.Add(Me.GeriZekalı)
        Me.Controls.Add(Me.KapatŞunu)
        Me.Controls.Add(Me.Bar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Editor"
        Me.Opacity = 0.01R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Editor"
        Me.Bar.ResumeLayout(False)
        Me.Bar.PerformLayout()
        Me.BaşlıkSağTık.ResumeLayout(False)
        Me.MetinSağTık.ResumeLayout(False)
        Me.TaramalıSayfa.ResumeLayout(False)
        Me.AnaEkran.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.ÜstResim, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.AltResim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.anavideo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SekmeYönetici.ResumeLayout(False)
        Me.BabaEkran.ResumeLayout(False)
        Me.BabaEkran.PerformLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BekResim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Bar As ToolStrip
    Friend WithEvents LightSaver As ToolStripDropDownButton
    Friend WithEvents Öncekiler As ToolStripButton
    Friend WithEvents NXT As ToolStripButton
    Friend WithEvents Pixar As ToolStripDropDownButton
    Friend WithEvents KapatŞunu As Label
    Friend WithEvents Projector As ToolStripLabel
    Friend WithEvents SquezeToTopToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SqueseToLeftToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FadeInAndOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BaşlıkSağTık As ContextMenuStrip
    Friend WithEvents MetinSağTık As ContextMenuStrip
    Friend WithEvents FontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResimSeç As OpenFileDialog
    Friend WithEvents GeriZekalı As Label
    Friend WithEvents YürüGit As Label
    Friend WithEvents LinkAt As TextBox
    Friend WithEvents İleriZekalı As Label
    Friend WithEvents GeriDönüşüm As Label
    Friend WithEvents TaramalıSayfa As TabPage
    Friend WithEvents SaçTarayıcı As WebBrowser
    Friend WithEvents AnaEkran As TabPage
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents SplitContainer3 As SplitContainer
    Friend WithEvents Başlık As RichTextBox
    Friend WithEvents ÜstResim As PictureBox
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents anavideo As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents AltResim As PictureBox
    Friend WithEvents Metin2 As RichTextBox
    Friend WithEvents SekmeYönetici As TabControl
    Friend WithEvents BabaEkran As TabPage
    Friend WithEvents FontToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents yokol As Windows.Forms.Timer
    Friend WithEvents çık As Windows.Forms.Timer
    Friend WithEvents kay As Windows.Forms.Timer
    Friend WithEvents vrl As Windows.Forms.Timer
    Friend WithEvents BekResim As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
