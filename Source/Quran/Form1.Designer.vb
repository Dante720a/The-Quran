<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mainfrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mainfrm))
        Me.SoreList = New System.Windows.Forms.ComboBox()
        Me.AyeList = New System.Windows.Forms.ComboBox()
        Me.ConnectToDB = New System.Windows.Forms.Button()
        Me.tArab = New System.Windows.Forms.TextBox()
        Me.tAnsarian = New System.Windows.Forms.TextBox()
        Me.tAyati = New System.Windows.Forms.TextBox()
        Me.tBahrampour = New System.Windows.Forms.TextBox()
        Me.tFooladvand = New System.Windows.Forms.TextBox()
        Me.tGharaati = New System.Windows.Forms.TextBox()
        Me.tGhomshei = New System.Windows.Forms.TextBox()
        Me.tKhorramdel = New System.Windows.Forms.TextBox()
        Me.tKhorramshahi = New System.Windows.Forms.TextBox()
        Me.tMakarem = New System.Windows.Forms.TextBox()
        Me.tMoezzi = New System.Windows.Forms.TextBox()
        Me.tMojtabavi = New System.Windows.Forms.TextBox()
        Me.tSadeqi = New System.Windows.Forms.TextBox()
        Me.TranslatePreview = New System.Windows.Forms.RichTextBox()
        Me.MatnArab = New System.Windows.Forms.RichTextBox()
        Me.TranslateList = New System.Windows.Forms.CheckedListBox()
        Me.TList = New System.Windows.Forms.ListBox()
        Me.SetTranslates = New System.Windows.Forms.Button()
        Me.LoadTexts = New System.Windows.Forms.Button()
        Me.AyehAddress = New System.Windows.Forms.TextBox()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.FontFars = New System.Windows.Forms.Button()
        Me.TFName = New System.Windows.Forms.TextBox()
        Me.TFSize = New System.Windows.Forms.TextBox()
        Me.LoadFontFromDB = New System.Windows.Forms.Button()
        Me.AFSize = New System.Windows.Forms.TextBox()
        Me.AFName = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SaveLastAye = New System.Windows.Forms.Button()
        Me.LoadLastAye = New System.Windows.Forms.Button()
        Me.LoadAyehList = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SettingPanel1 = New System.Windows.Forms.Panel()
        Me.LoadSoreHa = New System.Windows.Forms.Button()
        Me.ghari = New System.Windows.Forms.ComboBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.DeleteBookmarkAyeh = New System.Windows.Forms.Button()
        Me.ViewBookmarkAyeh = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.BookmarksList = New System.Windows.Forms.ListBox()
        Me.PlayMP3 = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LoadBookMarks = New System.Windows.Forms.Button()
        Me.VCounter = New System.Windows.Forms.TextBox()
        Me.AddViewCounts = New System.Windows.Forms.Button()
        Me.ExtractAudio = New System.Windows.Forms.Button()
        Me.LoadReward = New System.Windows.Forms.Button()
        Me.TextReward = New System.Windows.Forms.TextBox()
        Me.PlayAudio = New System.Windows.Forms.Button()
        Me.MP3File1 = New System.Windows.Forms.TextBox()
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pintop = New System.Windows.Forms.Button()
        Me.AutoNextAye = New System.Windows.Forms.CheckBox()
        Me.AyehAdressStat = New System.Windows.Forms.TextBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.wX = New System.Windows.Forms.TextBox()
        Me.wY = New System.Windows.Forms.TextBox()
        Me.wW = New System.Windows.Forms.TextBox()
        Me.wH = New System.Windows.Forms.TextBox()
        Me.FormLastLocation = New System.Windows.Forms.Button()
        Me.LoadGhariList = New System.Windows.Forms.Button()
        Me.MP3FilePath1 = New System.Windows.Forms.TextBox()
        Me.Lastghari = New System.Windows.Forms.Button()
        Me.MP3FilePath2 = New System.Windows.Forms.TextBox()
        Me.MP3File2 = New System.Windows.Forms.TextBox()
        Me.FillFileNames = New System.Windows.Forms.Button()
        Me.MP3FilePath0 = New System.Windows.Forms.TextBox()
        Me.MP3File0 = New System.Windows.Forms.TextBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.SettingPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SoreList
        '
        Me.SoreList.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SoreList.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.SoreList.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.SoreList.ForeColor = System.Drawing.Color.Black
        Me.SoreList.FormattingEnabled = True
        Me.SoreList.Location = New System.Drawing.Point(272, 2)
        Me.SoreList.Name = "SoreList"
        Me.SoreList.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SoreList.Size = New System.Drawing.Size(190, 26)
        Me.SoreList.TabIndex = 1
        '
        'AyeList
        '
        Me.AyeList.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AyeList.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.AyeList.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.AyeList.ForeColor = System.Drawing.Color.Black
        Me.AyeList.FormattingEnabled = True
        Me.AyeList.Location = New System.Drawing.Point(272, 32)
        Me.AyeList.Name = "AyeList"
        Me.AyeList.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.AyeList.Size = New System.Drawing.Size(190, 26)
        Me.AyeList.TabIndex = 2
        '
        'ConnectToDB
        '
        Me.ConnectToDB.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ConnectToDB.Location = New System.Drawing.Point(104, 169)
        Me.ConnectToDB.Name = "ConnectToDB"
        Me.ConnectToDB.Size = New System.Drawing.Size(93, 23)
        Me.ConnectToDB.TabIndex = 9
        Me.ConnectToDB.Text = "ConnectToDB"
        Me.ConnectToDB.UseVisualStyleBackColor = True
        Me.ConnectToDB.Visible = False
        '
        'tArab
        '
        Me.tArab.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tArab.Location = New System.Drawing.Point(6, 254)
        Me.tArab.Name = "tArab"
        Me.tArab.Size = New System.Drawing.Size(34, 20)
        Me.tArab.TabIndex = 12
        Me.tArab.Visible = False
        '
        'tAnsarian
        '
        Me.tAnsarian.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tAnsarian.Location = New System.Drawing.Point(6, 281)
        Me.tAnsarian.Name = "tAnsarian"
        Me.tAnsarian.Size = New System.Drawing.Size(34, 20)
        Me.tAnsarian.TabIndex = 13
        Me.tAnsarian.Visible = False
        '
        'tAyati
        '
        Me.tAyati.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tAyati.Location = New System.Drawing.Point(6, 307)
        Me.tAyati.Name = "tAyati"
        Me.tAyati.Size = New System.Drawing.Size(34, 20)
        Me.tAyati.TabIndex = 14
        Me.tAyati.Visible = False
        '
        'tBahrampour
        '
        Me.tBahrampour.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tBahrampour.Location = New System.Drawing.Point(6, 333)
        Me.tBahrampour.Name = "tBahrampour"
        Me.tBahrampour.Size = New System.Drawing.Size(34, 20)
        Me.tBahrampour.TabIndex = 15
        Me.tBahrampour.Visible = False
        '
        'tFooladvand
        '
        Me.tFooladvand.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tFooladvand.Location = New System.Drawing.Point(6, 359)
        Me.tFooladvand.Name = "tFooladvand"
        Me.tFooladvand.Size = New System.Drawing.Size(34, 20)
        Me.tFooladvand.TabIndex = 16
        Me.tFooladvand.Visible = False
        '
        'tGharaati
        '
        Me.tGharaati.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tGharaati.Location = New System.Drawing.Point(6, 385)
        Me.tGharaati.Name = "tGharaati"
        Me.tGharaati.Size = New System.Drawing.Size(34, 20)
        Me.tGharaati.TabIndex = 17
        Me.tGharaati.Visible = False
        '
        'tGhomshei
        '
        Me.tGhomshei.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tGhomshei.Location = New System.Drawing.Point(6, 411)
        Me.tGhomshei.Name = "tGhomshei"
        Me.tGhomshei.Size = New System.Drawing.Size(34, 20)
        Me.tGhomshei.TabIndex = 18
        Me.tGhomshei.Visible = False
        '
        'tKhorramdel
        '
        Me.tKhorramdel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tKhorramdel.Location = New System.Drawing.Point(46, 254)
        Me.tKhorramdel.Name = "tKhorramdel"
        Me.tKhorramdel.Size = New System.Drawing.Size(34, 20)
        Me.tKhorramdel.TabIndex = 19
        Me.tKhorramdel.Visible = False
        '
        'tKhorramshahi
        '
        Me.tKhorramshahi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tKhorramshahi.Location = New System.Drawing.Point(46, 280)
        Me.tKhorramshahi.Name = "tKhorramshahi"
        Me.tKhorramshahi.Size = New System.Drawing.Size(34, 20)
        Me.tKhorramshahi.TabIndex = 20
        Me.tKhorramshahi.Visible = False
        '
        'tMakarem
        '
        Me.tMakarem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tMakarem.Location = New System.Drawing.Point(46, 306)
        Me.tMakarem.Name = "tMakarem"
        Me.tMakarem.Size = New System.Drawing.Size(34, 20)
        Me.tMakarem.TabIndex = 21
        Me.tMakarem.Visible = False
        '
        'tMoezzi
        '
        Me.tMoezzi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tMoezzi.Location = New System.Drawing.Point(46, 332)
        Me.tMoezzi.Name = "tMoezzi"
        Me.tMoezzi.Size = New System.Drawing.Size(34, 20)
        Me.tMoezzi.TabIndex = 22
        Me.tMoezzi.Visible = False
        '
        'tMojtabavi
        '
        Me.tMojtabavi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tMojtabavi.Location = New System.Drawing.Point(46, 358)
        Me.tMojtabavi.Name = "tMojtabavi"
        Me.tMojtabavi.Size = New System.Drawing.Size(34, 20)
        Me.tMojtabavi.TabIndex = 23
        Me.tMojtabavi.Visible = False
        '
        'tSadeqi
        '
        Me.tSadeqi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tSadeqi.Location = New System.Drawing.Point(46, 384)
        Me.tSadeqi.Name = "tSadeqi"
        Me.tSadeqi.Size = New System.Drawing.Size(34, 20)
        Me.tSadeqi.TabIndex = 24
        Me.tSadeqi.Visible = False
        '
        'TranslatePreview
        '
        Me.TranslatePreview.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TranslatePreview.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.TranslatePreview.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TranslatePreview.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TranslatePreview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.TranslatePreview.Location = New System.Drawing.Point(0, 2)
        Me.TranslatePreview.Name = "TranslatePreview"
        Me.TranslatePreview.ReadOnly = True
        Me.TranslatePreview.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TranslatePreview.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.TranslatePreview.Size = New System.Drawing.Size(548, 162)
        Me.TranslatePreview.TabIndex = 26
        Me.TranslatePreview.Text = "به نام خداوند بخشنده مهربان"
        '
        'MatnArab
        '
        Me.MatnArab.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MatnArab.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.MatnArab.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MatnArab.Font = New System.Drawing.Font("Calibri", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.MatnArab.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.MatnArab.Location = New System.Drawing.Point(553, 2)
        Me.MatnArab.Name = "MatnArab"
        Me.MatnArab.ReadOnly = True
        Me.MatnArab.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MatnArab.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.MatnArab.Size = New System.Drawing.Size(547, 59)
        Me.MatnArab.TabIndex = 41
        Me.MatnArab.Text = "بِسْمِ اللّهِ الرَّحْمنِ الرَّحِيمِ"
        '
        'TranslateList
        '
        Me.TranslateList.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TranslateList.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.TranslateList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TranslateList.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TranslateList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.TranslateList.FormattingEnabled = True
        Me.TranslateList.Location = New System.Drawing.Point(377, 0)
        Me.TranslateList.Margin = New System.Windows.Forms.Padding(0)
        Me.TranslateList.Name = "TranslateList"
        Me.TranslateList.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TranslateList.Size = New System.Drawing.Size(167, 252)
        Me.TranslateList.TabIndex = 43
        '
        'TList
        '
        Me.TList.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TList.FormattingEnabled = True
        Me.TList.Location = New System.Drawing.Point(86, 309)
        Me.TList.Name = "TList"
        Me.TList.Size = New System.Drawing.Size(34, 30)
        Me.TList.TabIndex = 48
        Me.TList.Visible = False
        '
        'SetTranslates
        '
        Me.SetTranslates.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SetTranslates.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.SetTranslates.Location = New System.Drawing.Point(377, 252)
        Me.SetTranslates.Name = "SetTranslates"
        Me.SetTranslates.Size = New System.Drawing.Size(96, 33)
        Me.SetTranslates.TabIndex = 51
        Me.SetTranslates.Text = "اعمال تغییرات"
        Me.SetTranslates.UseVisualStyleBackColor = True
        '
        'LoadTexts
        '
        Me.LoadTexts.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoadTexts.Location = New System.Drawing.Point(5, 169)
        Me.LoadTexts.Name = "LoadTexts"
        Me.LoadTexts.Size = New System.Drawing.Size(93, 23)
        Me.LoadTexts.TabIndex = 52
        Me.LoadTexts.Text = "Load Texts"
        Me.LoadTexts.UseVisualStyleBackColor = True
        Me.LoadTexts.Visible = False
        '
        'AyehAddress
        '
        Me.AyehAddress.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AyehAddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.AyehAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AyehAddress.Enabled = False
        Me.AyehAddress.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AyehAddress.ForeColor = System.Drawing.Color.Black
        Me.AyehAddress.Location = New System.Drawing.Point(46, 410)
        Me.AyehAddress.Name = "AyehAddress"
        Me.AyehAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.AyehAddress.Size = New System.Drawing.Size(127, 26)
        Me.AyehAddress.TabIndex = 55
        Me.AyehAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.AyehAddress.Visible = False
        '
        'FontDialog1
        '
        Me.FontDialog1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        '
        'FontFars
        '
        Me.FontFars.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FontFars.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FontFars.Location = New System.Drawing.Point(260, 102)
        Me.FontFars.Name = "FontFars"
        Me.FontFars.Size = New System.Drawing.Size(108, 27)
        Me.FontFars.TabIndex = 57
        Me.FontFars.Text = "فونت فارسی"
        Me.FontFars.UseVisualStyleBackColor = True
        '
        'TFName
        '
        Me.TFName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TFName.Location = New System.Drawing.Point(86, 254)
        Me.TFName.Name = "TFName"
        Me.TFName.Size = New System.Drawing.Size(24, 20)
        Me.TFName.TabIndex = 58
        Me.TFName.Visible = False
        '
        'TFSize
        '
        Me.TFSize.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TFSize.Location = New System.Drawing.Point(86, 280)
        Me.TFSize.Name = "TFSize"
        Me.TFSize.Size = New System.Drawing.Size(24, 20)
        Me.TFSize.TabIndex = 59
        Me.TFSize.Visible = False
        '
        'LoadFontFromDB
        '
        Me.LoadFontFromDB.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoadFontFromDB.Location = New System.Drawing.Point(104, 196)
        Me.LoadFontFromDB.Name = "LoadFontFromDB"
        Me.LoadFontFromDB.Size = New System.Drawing.Size(93, 23)
        Me.LoadFontFromDB.TabIndex = 61
        Me.LoadFontFromDB.Text = "Load Fonts From DB"
        Me.LoadFontFromDB.UseVisualStyleBackColor = True
        Me.LoadFontFromDB.Visible = False
        '
        'AFSize
        '
        Me.AFSize.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AFSize.Location = New System.Drawing.Point(116, 280)
        Me.AFSize.Name = "AFSize"
        Me.AFSize.Size = New System.Drawing.Size(26, 20)
        Me.AFSize.TabIndex = 63
        Me.AFSize.Visible = False
        '
        'AFName
        '
        Me.AFName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AFName.Location = New System.Drawing.Point(116, 254)
        Me.AFName.Name = "AFName"
        Me.AFName.Size = New System.Drawing.Size(26, 20)
        Me.AFName.TabIndex = 62
        Me.AFName.Visible = False
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button4.Location = New System.Drawing.Point(260, 73)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(108, 27)
        Me.Button4.TabIndex = 64
        Me.Button4.Text = "فونت عربی"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'SaveLastAye
        '
        Me.SaveLastAye.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveLastAye.Location = New System.Drawing.Point(6, 225)
        Me.SaveLastAye.Name = "SaveLastAye"
        Me.SaveLastAye.Size = New System.Drawing.Size(92, 23)
        Me.SaveLastAye.TabIndex = 65
        Me.SaveLastAye.Text = "ذخیره آخرین آیه"
        Me.SaveLastAye.UseVisualStyleBackColor = True
        Me.SaveLastAye.Visible = False
        '
        'LoadLastAye
        '
        Me.LoadLastAye.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoadLastAye.Location = New System.Drawing.Point(104, 225)
        Me.LoadLastAye.Name = "LoadLastAye"
        Me.LoadLastAye.Size = New System.Drawing.Size(92, 23)
        Me.LoadLastAye.TabIndex = 66
        Me.LoadLastAye.Text = "لود آخرین آیه"
        Me.LoadLastAye.UseVisualStyleBackColor = True
        Me.LoadLastAye.Visible = False
        '
        'LoadAyehList
        '
        Me.LoadAyehList.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoadAyehList.Location = New System.Drawing.Point(6, 196)
        Me.LoadAyehList.Name = "LoadAyehList"
        Me.LoadAyehList.Size = New System.Drawing.Size(92, 23)
        Me.LoadAyehList.TabIndex = 67
        Me.LoadAyehList.Text = "Load Aye List"
        Me.LoadAyehList.UseVisualStyleBackColor = True
        Me.LoadAyehList.Visible = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label1.Location = New System.Drawing.Point(464, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(83, 16)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "انتخاب سوره:"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label2.Location = New System.Drawing.Point(464, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "انتخاب آیه:"
        '
        'SettingPanel1
        '
        Me.SettingPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SettingPanel1.Controls.Add(Me.Button8)
        Me.SettingPanel1.Controls.Add(Me.LoadSoreHa)
        Me.SettingPanel1.Controls.Add(Me.ghari)
        Me.SettingPanel1.Controls.Add(Me.Button7)
        Me.SettingPanel1.Controls.Add(Me.Button5)
        Me.SettingPanel1.Controls.Add(Me.DeleteBookmarkAyeh)
        Me.SettingPanel1.Controls.Add(Me.ViewBookmarkAyeh)
        Me.SettingPanel1.Controls.Add(Me.Button6)
        Me.SettingPanel1.Controls.Add(Me.BookmarksList)
        Me.SettingPanel1.Controls.Add(Me.FontFars)
        Me.SettingPanel1.Controls.Add(Me.Button4)
        Me.SettingPanel1.Controls.Add(Me.TranslateList)
        Me.SettingPanel1.Controls.Add(Me.SetTranslates)
        Me.SettingPanel1.Location = New System.Drawing.Point(553, 64)
        Me.SettingPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.SettingPanel1.Name = "SettingPanel1"
        Me.SettingPanel1.Size = New System.Drawing.Size(547, 325)
        Me.SettingPanel1.TabIndex = 71
        Me.SettingPanel1.Visible = False
        '
        'LoadSoreHa
        '
        Me.LoadSoreHa.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoadSoreHa.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.LoadSoreHa.Location = New System.Drawing.Point(260, 145)
        Me.LoadSoreHa.Name = "LoadSoreHa"
        Me.LoadSoreHa.Size = New System.Drawing.Size(108, 36)
        Me.LoadSoreHa.TabIndex = 81
        Me.LoadSoreHa.Text = "لود تمام سوره ها "
        Me.LoadSoreHa.UseVisualStyleBackColor = True
        '
        'ghari
        '
        Me.ghari.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ghari.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ghari.FormattingEnabled = True
        Me.ghari.Location = New System.Drawing.Point(272, 291)
        Me.ghari.Name = "ghari"
        Me.ghari.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ghari.Size = New System.Drawing.Size(265, 26)
        Me.ghari.TabIndex = 82
        '
        'Button7
        '
        Me.Button7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button7.Location = New System.Drawing.Point(260, 185)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(108, 38)
        Me.Button7.TabIndex = 80
        Me.Button7.Text = "لود سوره های منتخب "
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button5.Location = New System.Drawing.Point(260, 9)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(108, 42)
        Me.Button5.TabIndex = 79
        Me.Button5.Text = "ریست شمارشگر تعداد بازدید از آیات"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'DeleteBookmarkAyeh
        '
        Me.DeleteBookmarkAyeh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DeleteBookmarkAyeh.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.DeleteBookmarkAyeh.Location = New System.Drawing.Point(115, 291)
        Me.DeleteBookmarkAyeh.Name = "DeleteBookmarkAyeh"
        Me.DeleteBookmarkAyeh.Size = New System.Drawing.Size(55, 31)
        Me.DeleteBookmarkAyeh.TabIndex = 78
        Me.DeleteBookmarkAyeh.Text = "حذف"
        Me.DeleteBookmarkAyeh.UseVisualStyleBackColor = True
        '
        'ViewBookmarkAyeh
        '
        Me.ViewBookmarkAyeh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ViewBookmarkAyeh.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ViewBookmarkAyeh.Location = New System.Drawing.Point(176, 291)
        Me.ViewBookmarkAyeh.Name = "ViewBookmarkAyeh"
        Me.ViewBookmarkAyeh.Size = New System.Drawing.Size(75, 31)
        Me.ViewBookmarkAyeh.TabIndex = 77
        Me.ViewBookmarkAyeh.Text = "نمایش"
        Me.ViewBookmarkAyeh.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button6.Location = New System.Drawing.Point(11, 291)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(91, 31)
        Me.Button6.TabIndex = 76
        Me.Button6.Text = "اضافه کردن"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'BookmarksList
        '
        Me.BookmarksList.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BookmarksList.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.BookmarksList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BookmarksList.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BookmarksList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.BookmarksList.FormattingEnabled = True
        Me.BookmarksList.ItemHeight = 18
        Me.BookmarksList.Location = New System.Drawing.Point(0, 0)
        Me.BookmarksList.Name = "BookmarksList"
        Me.BookmarksList.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BookmarksList.Size = New System.Drawing.Size(251, 288)
        Me.BookmarksList.TabIndex = 65
        '
        'PlayMP3
        '
        Me.PlayMP3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PlayMP3.AutoSize = True
        Me.PlayMP3.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.PlayMP3.FlatAppearance.BorderSize = 2
        Me.PlayMP3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PlayMP3.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.PlayMP3.Location = New System.Drawing.Point(352, 60)
        Me.PlayMP3.Name = "PlayMP3"
        Me.PlayMP3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PlayMP3.Size = New System.Drawing.Size(137, 23)
        Me.PlayMP3.TabIndex = 82
        Me.PlayMP3.Text = "پخش صوت آیه"
        Me.PlayMP3.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label4.Location = New System.Drawing.Point(175, 414)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(70, 16)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "سوره / آیه:"
        Me.Label4.Visible = False
        '
        'LoadBookMarks
        '
        Me.LoadBookMarks.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoadBookMarks.Location = New System.Drawing.Point(46, 442)
        Me.LoadBookMarks.Name = "LoadBookMarks"
        Me.LoadBookMarks.Size = New System.Drawing.Size(115, 23)
        Me.LoadBookMarks.TabIndex = 75
        Me.LoadBookMarks.Text = "لود لیست علایق"
        Me.LoadBookMarks.UseVisualStyleBackColor = True
        Me.LoadBookMarks.Visible = False
        '
        'VCounter
        '
        Me.VCounter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.VCounter.Location = New System.Drawing.Point(206, 196)
        Me.VCounter.Name = "VCounter"
        Me.VCounter.Size = New System.Drawing.Size(48, 20)
        Me.VCounter.TabIndex = 76
        Me.VCounter.Visible = False
        '
        'AddViewCounts
        '
        Me.AddViewCounts.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.AddViewCounts.Location = New System.Drawing.Point(203, 170)
        Me.AddViewCounts.Name = "AddViewCounts"
        Me.AddViewCounts.Size = New System.Drawing.Size(75, 23)
        Me.AddViewCounts.TabIndex = 77
        Me.AddViewCounts.Text = "load View Count"
        Me.AddViewCounts.UseVisualStyleBackColor = True
        Me.AddViewCounts.Visible = False
        '
        'ExtractAudio
        '
        Me.ExtractAudio.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ExtractAudio.Location = New System.Drawing.Point(248, 35)
        Me.ExtractAudio.Name = "ExtractAudio"
        Me.ExtractAudio.Size = New System.Drawing.Size(75, 23)
        Me.ExtractAudio.TabIndex = 78
        Me.ExtractAudio.Text = "ExtractAudio"
        Me.ExtractAudio.UseVisualStyleBackColor = True
        Me.ExtractAudio.Visible = False
        '
        'LoadReward
        '
        Me.LoadReward.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LoadReward.Location = New System.Drawing.Point(311, 251)
        Me.LoadReward.Name = "LoadReward"
        Me.LoadReward.Size = New System.Drawing.Size(75, 23)
        Me.LoadReward.TabIndex = 79
        Me.LoadReward.Text = "LoadFazilat"
        Me.LoadReward.UseVisualStyleBackColor = True
        Me.LoadReward.Visible = False
        '
        'TextReward
        '
        Me.TextReward.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextReward.Location = New System.Drawing.Point(205, 225)
        Me.TextReward.Name = "TextReward"
        Me.TextReward.Size = New System.Drawing.Size(100, 20)
        Me.TextReward.TabIndex = 80
        Me.TextReward.Visible = False
        '
        'PlayAudio
        '
        Me.PlayAudio.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PlayAudio.Location = New System.Drawing.Point(329, 35)
        Me.PlayAudio.Name = "PlayAudio"
        Me.PlayAudio.Size = New System.Drawing.Size(75, 23)
        Me.PlayAudio.TabIndex = 86
        Me.PlayAudio.Text = "PlayAudio"
        Me.PlayAudio.UseVisualStyleBackColor = True
        Me.PlayAudio.Visible = False
        '
        'MP3File1
        '
        Me.MP3File1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MP3File1.Location = New System.Drawing.Point(122, 88)
        Me.MP3File1.Name = "MP3File1"
        Me.MP3File1.Size = New System.Drawing.Size(75, 20)
        Me.MP3File1.TabIndex = 85
        Me.MP3File1.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.pintop)
        Me.Panel1.Controls.Add(Me.AutoNextAye)
        Me.Panel1.Controls.Add(Me.AyehAdressStat)
        Me.Panel1.Controls.Add(Me.Button9)
        Me.Panel1.Controls.Add(Me.SoreList)
        Me.Panel1.Controls.Add(Me.AyeList)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.PlayMP3)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Location = New System.Drawing.Point(553, 395)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(547, 109)
        Me.Panel1.TabIndex = 89
        '
        'pintop
        '
        Me.pintop.Image = Global.Quran.My.Resources.Resources.never
        Me.pintop.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.pintop.Location = New System.Drawing.Point(502, 65)
        Me.pintop.Name = "pintop"
        Me.pintop.Size = New System.Drawing.Size(37, 37)
        Me.pintop.TabIndex = 90
        Me.pintop.UseVisualStyleBackColor = True
        '
        'AutoNextAye
        '
        Me.AutoNextAye.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AutoNextAye.AutoSize = True
        Me.AutoNextAye.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.AutoNextAye.Enabled = False
        Me.AutoNextAye.FlatAppearance.BorderSize = 2
        Me.AutoNextAye.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.AutoNextAye.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.AutoNextAye.Location = New System.Drawing.Point(285, 84)
        Me.AutoNextAye.Name = "AutoNextAye"
        Me.AutoNextAye.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.AutoNextAye.Size = New System.Drawing.Size(204, 23)
        Me.AutoNextAye.TabIndex = 89
        Me.AutoNextAye.Text = "رفتن اتوماتیک به آیه بعد"
        Me.AutoNextAye.UseVisualStyleBackColor = False
        '
        'AyehAdressStat
        '
        Me.AyehAdressStat.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.AyehAdressStat.Enabled = False
        Me.AyehAdressStat.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.AyehAdressStat.ForeColor = System.Drawing.Color.Black
        Me.AyehAdressStat.Location = New System.Drawing.Point(95, 3)
        Me.AyehAdressStat.Name = "AyehAdressStat"
        Me.AyehAdressStat.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.AyehAdressStat.Size = New System.Drawing.Size(171, 26)
        Me.AyehAdressStat.TabIndex = 88
        Me.AyehAdressStat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button9
        '
        Me.Button9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button9.Image = Global.Quran.My.Resources.Resources.Play
        Me.Button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button9.Location = New System.Drawing.Point(7, 35)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(85, 71)
        Me.Button9.TabIndex = 82
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.Button2.Image = Global.Quran.My.Resources.Resources.Prev
        Me.Button2.Location = New System.Drawing.Point(183, 35)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(85, 71)
        Me.Button2.TabIndex = 54
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.Button1.Image = Global.Quran.My.Resources.Resources._Next
        Me.Button1.Location = New System.Drawing.Point(95, 35)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 71)
        Me.Button1.TabIndex = 53
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(161, Byte), Integer))
        Me.Button3.Image = Global.Quran.My.Resources.Resources.settings
        Me.Button3.Location = New System.Drawing.Point(7, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(85, 32)
        Me.Button3.TabIndex = 70
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'wX
        '
        Me.wX.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.wX.Location = New System.Drawing.Point(311, 344)
        Me.wX.Name = "wX"
        Me.wX.Size = New System.Drawing.Size(100, 20)
        Me.wX.TabIndex = 90
        Me.wX.Visible = False
        '
        'wY
        '
        Me.wY.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.wY.Location = New System.Drawing.Point(311, 369)
        Me.wY.Name = "wY"
        Me.wY.Size = New System.Drawing.Size(100, 20)
        Me.wY.TabIndex = 91
        Me.wY.Visible = False
        '
        'wW
        '
        Me.wW.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.wW.Location = New System.Drawing.Point(311, 395)
        Me.wW.Name = "wW"
        Me.wW.Size = New System.Drawing.Size(100, 20)
        Me.wW.TabIndex = 92
        Me.wW.Visible = False
        '
        'wH
        '
        Me.wH.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.wH.Location = New System.Drawing.Point(311, 421)
        Me.wH.Name = "wH"
        Me.wH.Size = New System.Drawing.Size(100, 20)
        Me.wH.TabIndex = 93
        Me.wH.Visible = False
        '
        'FormLastLocation
        '
        Me.FormLastLocation.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FormLastLocation.Location = New System.Drawing.Point(418, 344)
        Me.FormLastLocation.Name = "FormLastLocation"
        Me.FormLastLocation.Size = New System.Drawing.Size(104, 23)
        Me.FormLastLocation.TabIndex = 94
        Me.FormLastLocation.Text = "FormLastLocation"
        Me.FormLastLocation.UseVisualStyleBackColor = True
        Me.FormLastLocation.Visible = False
        '
        'LoadGhariList
        '
        Me.LoadGhariList.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LoadGhariList.Location = New System.Drawing.Point(167, 35)
        Me.LoadGhariList.Name = "LoadGhariList"
        Me.LoadGhariList.Size = New System.Drawing.Size(75, 23)
        Me.LoadGhariList.TabIndex = 95
        Me.LoadGhariList.Text = "LoadGhariList"
        Me.LoadGhariList.UseVisualStyleBackColor = True
        Me.LoadGhariList.Visible = False
        '
        'MP3FilePath1
        '
        Me.MP3FilePath1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MP3FilePath1.Location = New System.Drawing.Point(203, 88)
        Me.MP3FilePath1.Name = "MP3FilePath1"
        Me.MP3FilePath1.Size = New System.Drawing.Size(282, 20)
        Me.MP3FilePath1.TabIndex = 96
        Me.MP3FilePath1.Visible = False
        '
        'Lastghari
        '
        Me.Lastghari.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Lastghari.Location = New System.Drawing.Point(86, 33)
        Me.Lastghari.Name = "Lastghari"
        Me.Lastghari.Size = New System.Drawing.Size(75, 23)
        Me.Lastghari.TabIndex = 97
        Me.Lastghari.Text = "Lastghari"
        Me.Lastghari.UseVisualStyleBackColor = True
        Me.Lastghari.Visible = False
        '
        'MP3FilePath2
        '
        Me.MP3FilePath2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MP3FilePath2.Location = New System.Drawing.Point(203, 114)
        Me.MP3FilePath2.Name = "MP3FilePath2"
        Me.MP3FilePath2.Size = New System.Drawing.Size(282, 20)
        Me.MP3FilePath2.TabIndex = 98
        Me.MP3FilePath2.Visible = False
        '
        'MP3File2
        '
        Me.MP3File2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MP3File2.Location = New System.Drawing.Point(122, 114)
        Me.MP3File2.Name = "MP3File2"
        Me.MP3File2.Size = New System.Drawing.Size(75, 20)
        Me.MP3File2.TabIndex = 99
        Me.MP3File2.Visible = False
        '
        'FillFileNames
        '
        Me.FillFileNames.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FillFileNames.Location = New System.Drawing.Point(410, 35)
        Me.FillFileNames.Name = "FillFileNames"
        Me.FillFileNames.Size = New System.Drawing.Size(75, 23)
        Me.FillFileNames.TabIndex = 100
        Me.FillFileNames.Text = "FillFileNames"
        Me.FillFileNames.UseVisualStyleBackColor = True
        Me.FillFileNames.Visible = False
        '
        'MP3FilePath0
        '
        Me.MP3FilePath0.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MP3FilePath0.Location = New System.Drawing.Point(203, 62)
        Me.MP3FilePath0.Name = "MP3FilePath0"
        Me.MP3FilePath0.Size = New System.Drawing.Size(282, 20)
        Me.MP3FilePath0.TabIndex = 102
        Me.MP3FilePath0.Visible = False
        '
        'MP3File0
        '
        Me.MP3File0.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MP3File0.Location = New System.Drawing.Point(122, 62)
        Me.MP3File0.Name = "MP3File0"
        Me.MP3File0.Size = New System.Drawing.Size(75, 20)
        Me.MP3File0.TabIndex = 101
        Me.MP3File0.Visible = False
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Button8.Location = New System.Drawing.Point(260, 238)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(108, 37)
        Me.Button8.TabIndex = 83
        Me.Button8.Text = "فهرست سوره های منتخب"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Mainfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1102, 507)
        Me.Controls.Add(Me.MP3FilePath0)
        Me.Controls.Add(Me.MP3File0)
        Me.Controls.Add(Me.FillFileNames)
        Me.Controls.Add(Me.MP3File2)
        Me.Controls.Add(Me.MP3FilePath2)
        Me.Controls.Add(Me.Lastghari)
        Me.Controls.Add(Me.MP3FilePath1)
        Me.Controls.Add(Me.LoadGhariList)
        Me.Controls.Add(Me.FormLastLocation)
        Me.Controls.Add(Me.wH)
        Me.Controls.Add(Me.wW)
        Me.Controls.Add(Me.wY)
        Me.Controls.Add(Me.wX)
        Me.Controls.Add(Me.SettingPanel1)
        Me.Controls.Add(Me.MatnArab)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LoadFontFromDB)
        Me.Controls.Add(Me.LoadTexts)
        Me.Controls.Add(Me.LoadLastAye)
        Me.Controls.Add(Me.PlayAudio)
        Me.Controls.Add(Me.MP3File1)
        Me.Controls.Add(Me.TextReward)
        Me.Controls.Add(Me.ExtractAudio)
        Me.Controls.Add(Me.LoadReward)
        Me.Controls.Add(Me.AddViewCounts)
        Me.Controls.Add(Me.VCounter)
        Me.Controls.Add(Me.LoadBookMarks)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.AyehAddress)
        Me.Controls.Add(Me.LoadAyehList)
        Me.Controls.Add(Me.SaveLastAye)
        Me.Controls.Add(Me.AFSize)
        Me.Controls.Add(Me.AFName)
        Me.Controls.Add(Me.TFSize)
        Me.Controls.Add(Me.TFName)
        Me.Controls.Add(Me.TList)
        Me.Controls.Add(Me.tSadeqi)
        Me.Controls.Add(Me.tMojtabavi)
        Me.Controls.Add(Me.tMoezzi)
        Me.Controls.Add(Me.tMakarem)
        Me.Controls.Add(Me.tKhorramshahi)
        Me.Controls.Add(Me.tKhorramdel)
        Me.Controls.Add(Me.tGhomshei)
        Me.Controls.Add(Me.tGharaati)
        Me.Controls.Add(Me.tFooladvand)
        Me.Controls.Add(Me.tBahrampour)
        Me.Controls.Add(Me.tAyati)
        Me.Controls.Add(Me.tAnsarian)
        Me.Controls.Add(Me.tArab)
        Me.Controls.Add(Me.ConnectToDB)
        Me.Controls.Add(Me.TranslatePreview)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(569, 250)
        Me.Name = "Mainfrm"
        Me.RightToLeftLayout = True
        Me.Text = "The Quran - Copyright (C) 2021 Ahmad Ahmadi. "
        Me.SettingPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SoreList As System.Windows.Forms.ComboBox
    Friend WithEvents AyeList As System.Windows.Forms.ComboBox
    Friend WithEvents ConnectToDB As System.Windows.Forms.Button
    Friend WithEvents tArab As System.Windows.Forms.TextBox
    Friend WithEvents tAnsarian As System.Windows.Forms.TextBox
    Friend WithEvents tAyati As System.Windows.Forms.TextBox
    Friend WithEvents tBahrampour As System.Windows.Forms.TextBox
    Friend WithEvents tFooladvand As System.Windows.Forms.TextBox
    Friend WithEvents tGharaati As System.Windows.Forms.TextBox
    Friend WithEvents tGhomshei As System.Windows.Forms.TextBox
    Friend WithEvents tKhorramdel As System.Windows.Forms.TextBox
    Friend WithEvents tKhorramshahi As System.Windows.Forms.TextBox
    Friend WithEvents tMakarem As System.Windows.Forms.TextBox
    Friend WithEvents tMoezzi As System.Windows.Forms.TextBox
    Friend WithEvents tMojtabavi As System.Windows.Forms.TextBox
    Friend WithEvents tSadeqi As System.Windows.Forms.TextBox
    Friend WithEvents TranslatePreview As System.Windows.Forms.RichTextBox
    Friend WithEvents MatnArab As System.Windows.Forms.RichTextBox
    Friend WithEvents TranslateList As System.Windows.Forms.CheckedListBox
    Friend WithEvents TList As System.Windows.Forms.ListBox
    Friend WithEvents SetTranslates As System.Windows.Forms.Button
    Friend WithEvents LoadTexts As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents AyehAddress As System.Windows.Forms.TextBox
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents FontFars As System.Windows.Forms.Button
    Friend WithEvents TFName As System.Windows.Forms.TextBox
    Friend WithEvents TFSize As System.Windows.Forms.TextBox
    Friend WithEvents LoadFontFromDB As System.Windows.Forms.Button
    Friend WithEvents AFSize As System.Windows.Forms.TextBox
    Friend WithEvents AFName As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents SaveLastAye As System.Windows.Forms.Button
    Friend WithEvents LoadLastAye As System.Windows.Forms.Button
    Friend WithEvents LoadAyehList As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents SettingPanel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BookmarksList As System.Windows.Forms.ListBox
    Friend WithEvents LoadBookMarks As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents ViewBookmarkAyeh As System.Windows.Forms.Button
    Friend WithEvents DeleteBookmarkAyeh As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents VCounter As System.Windows.Forms.TextBox
    Friend WithEvents AddViewCounts As System.Windows.Forms.Button
    Friend WithEvents ExtractAudio As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents LoadSoreHa As System.Windows.Forms.Button
    Friend WithEvents LoadReward As System.Windows.Forms.Button
    Friend WithEvents TextReward As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents PlayMP3 As System.Windows.Forms.CheckBox
    Friend WithEvents PlayAudio As System.Windows.Forms.Button
    Friend WithEvents MP3File1 As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip2 As System.Windows.Forms.ToolTip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents AyehAdressStat As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents wX As System.Windows.Forms.TextBox
    Friend WithEvents wY As System.Windows.Forms.TextBox
    Friend WithEvents wW As System.Windows.Forms.TextBox
    Friend WithEvents wH As System.Windows.Forms.TextBox
    Friend WithEvents FormLastLocation As System.Windows.Forms.Button
    Friend WithEvents AutoNextAye As System.Windows.Forms.CheckBox
    Friend WithEvents ghari As System.Windows.Forms.ComboBox
    Friend WithEvents LoadGhariList As System.Windows.Forms.Button
    Friend WithEvents MP3FilePath1 As System.Windows.Forms.TextBox
    Friend WithEvents Lastghari As System.Windows.Forms.Button
    Friend WithEvents MP3FilePath2 As System.Windows.Forms.TextBox
    Friend WithEvents MP3File2 As System.Windows.Forms.TextBox
    Friend WithEvents FillFileNames As System.Windows.Forms.Button
    Friend WithEvents MP3FilePath0 As System.Windows.Forms.TextBox
    Friend WithEvents MP3File0 As System.Windows.Forms.TextBox
    Friend WithEvents pintop As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button

End Class
