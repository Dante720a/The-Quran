Imports System.Data.OleDb
Imports WMPLib
Imports Ionic.Zip
Imports System.IO

Public Class Mainfrm

    Dim WithEvents MPC3 As New WMPLib.WindowsMediaPlayer

    Private Sub PlayFile(ByVal url As String)
        MPC3 = New WMPLib.WindowsMediaPlayer
        MPC3.URL = url
        MPC3.controls.play()
    End Sub

    Dim PlayButtonPressed, favorateSores As Boolean

    '##\\ Connect to Access Database \\#################################################################################################
    Private con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\Quran.mdb")
    Dim cmd As OleDb.OleDbCommand
    Dim da As OleDb.OleDbDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Dim maxrow As Integer

    '##\\ Get Max Row in Table \\#######################################################################################################
    Private Function get_maxrow(ByVal sql)
        Try
            con.Open()
            cmd = New OleDb.OleDbCommand
            da = New OleDb.OleDbDataAdapter
            dt = New DataTable
            With cmd
                .Connection = con
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            maxrow = dt.Rows.Count
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            da.Dispose()
        End Try
        Return maxrow
    End Function

    Private Sub ConnectToDB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConnectToDB.Click

        '##\\ Load Motarjems List \\####################################################################################################
        TranslateList.Items.Clear()
        Try
            con.Open()
            cmd = New OleDb.OleDbCommand
            da = New OleDb.OleDbDataAdapter
            dt = New DataTable
            sql = "Select * from TranslateList"
            With cmd
                .Connection = con
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            For i = 0 To dt.Rows.Count - 1
                TranslateList.Items.Add(dt.Rows(i).Item(2), dt.Rows(i).Item(3))
                If dt.Rows(i).Item(3) = True Then
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            con.Close()
            da.Dispose()
        End Try

        '##\\ Load Sore List \\#########################################################################################################
        LoadSoreHa_Click(Nothing, Nothing)

        '##\\ load Ayeh List \\#########################################################################################################
        Try
            con.Open()
            cmd = New OleDb.OleDbCommand
            da = New OleDb.OleDbDataAdapter
            dt = New DataTable
            sql = "Select * From theQuran where SorehNo= " & SoreList.SelectedValue & " ORDER BY AyehNo"
            With cmd
                .Connection = con
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            AyeList.DataSource = dt
            AyeList.DisplayMember = "AyehNo"
            AyeList.ValueMember = "QID"
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            da.Dispose()
        End Try

        '##\\ Show Last Visited Ayeh \\#################################################################################################
        LoadLastAye_Click(Nothing, Nothing)

        '##\\ Get Enabled Tarjome List \\###############################################################################################
        SetTranslates_Click(Nothing, Nothing)

        '##\\ Load Arabic And Farsi Quran Text \\#######################################################################################
        LoadTexts_Click(Nothing, Nothing)


    End Sub

    Private Sub AyeList_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AyeList.SelectionChangeCommitted
        MPC3.controls.stop()
        '##\\ Load Arabic And Farsi Quran Text \\#######################################################################################
        LoadTexts_Click(Nothing, Nothing)

    End Sub

    Private Sub SoreList_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SoreList.SelectionChangeCommitted

        '##\\ load Ayeh List \\#########################################################################################################
        LoadAyehList_Click(Nothing, Nothing)

        '##\\ load Tarjome Text to textbox \\###########################################################################################
        LoadTexts_Click(Nothing, Nothing)

    End Sub

    Private Sub SetTranslates_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetTranslates.Click

        '##\\ Modify Enabled Tarjome Text in Database \\################################################################################
        Dim clean As New OleDbCommand("UPDATE TranslateList SET Show = false ", con)
        con.Open()
        clean.ExecuteNonQuery()
        con.Close()
        For Each check1 As Object In TranslateList.CheckedItems
            Dim cmd As New OleDbCommand("UPDATE TranslateList SET Show = true where Motarjem =@show ", con)
            cmd.Parameters.AddWithValue("@show", check1.ToString)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        Next
        TList.Items.Clear()
        Try
            con.Open()
            cmd = New OleDb.OleDbCommand
            da = New OleDb.OleDbDataAdapter
            dt = New DataTable
            sql = "Select * from TranslateList where Show = true"
            With cmd
                .Connection = con
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            For i = 0 To dt.Rows.Count - 1
                TList.Items.Add(dt.Rows(i).Item(2))
                If dt.Rows(i).Item(3) = True Then
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            da.Dispose()
        End Try

        '##\\ Show Tarjome Text \\######################################################################################################
        LoadTexts_Click(Nothing, Nothing)
    End Sub

    Private Sub Mainfrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillFileNames_Click(Nothing, Nothing)
        LoadGhariList_Click(Nothing, Nothing)

        '##\\ Resize Arabic and Translate Text Field Height \\######################################################################### 
        MatnArab.Height = MatnArab.Height + 330
        TranslatePreview.Height = TranslatePreview.Height + 343

        '##\\ Application Startup \\###################################################################################################
        ConnectToDB_Click(Nothing, Nothing)
        LoadFontFromDB_Click(Nothing, Nothing)

        '##\\ Load Bookmarks Ayeh \\###################################################################################################
        LoadBookMarks_Click(Nothing, Nothing)

        '##\\ Load Last Window Location \\#############################################################################################
        FormLastLocation_Click(Nothing, Nothing)
        If Me.Height < 290 Then
            MatnArab.Font = New Font(AFName.Text, 16)
        Else
            LoadFontFromDB_Click(Nothing, Nothing)
        End If
    End Sub


    Private Sub LoadTexts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadTexts.Click


        '##\\ Save Last Visited Ayeh to Database \\#####################################################################################
        SaveLastAye_Click(Nothing, Nothing)

        '##\\ load Tarjome Text to textbox \\###########################################################################################
        Try
            sql = "Select * From theQuran Where QID = " & AyeList.SelectedValue & ""
            maxrow = get_maxrow(sql)
            If maxrow > 0 Then
                With dt.Rows(0)
                    tArab.Text = .Item("Ayehtext")
                    tAnsarian.Text = .Item("Ansarian")
                    tAyati.Text = .Item("Ayati")
                    tBahrampour.Text = .Item("Bahrampour")
                    tFooladvand.Text = .Item("Fooladvand")
                    tGharaati.Text = .Item("Gharaati")
                    tGhomshei.Text = .Item("Ghomshei")
                    tKhorramdel.Text = .Item("Khorramdel")
                    tKhorramshahi.Text = .Item("Khorramshahi")
                    tMakarem.Text = .Item("Makarem")
                    tMoezzi.Text = .Item("Moezzi")
                    tMojtabavi.Text = .Item("Mojtabavi")
                    tSadeqi.Text = .Item("Sadeqi")
                End With
            End If
        Catch ex As Exception

        End Try



        '##\\ Show Sore & Aye Adress \\#################################################################################################
        AyehAdressStat.Text = "سوره: " & SoreList.SelectedValue & " | آیه: " & AyeList.SelectedIndex + 1 & " از " & AyeList.Items.Count
        Me.Text = "The Quran - Copyright (C) 2021 Ahmad Ahmadi. " & " - " & AyehAdressStat.Text & " - (تعداد بازدید این آیه:" & VCounter.Text & ") "

        '##\\ Load Sore Rewards Tooltip \\#######################################################################################################
        LoadReward_Click(Nothing, Nothing)

        '##\\ Show Arabic Text \\#######################################################################################################
        MatnArab.Clear()
        MatnArab.SelectionCharOffset = 10
        MatnArab.SelectedText = tArab.Text

        '##\\ Show Enabled Farsi Tarjome Text \\########################################################################################
        TranslatePreview.Text = ""
        Dim currentFont As System.Drawing.Font = TranslatePreview.SelectionFont
        If TList.Items.Contains("انصاریان") = True Then
            TranslatePreview.SelectionColor() = Color.FromArgb(255, 130, 120, 110)
            TranslatePreview.SelectionFont = New Font(currentFont.FontFamily, currentFont.Size, FontStyle.Bold)
            TranslatePreview.SelectedText = "انصاریان: "
            TranslatePreview.SelectionColor() = Color.FromArgb(255, 187, 178, 161)
            TranslatePreview.SelectionFont = New Font(currentFont.FontFamily, currentFont.Size, FontStyle.Regular)
            TranslatePreview.SelectedText = tAnsarian.Text & vbCrLf
            TranslatePreview.SelectionFont = New Font(currentFont.FontFamily, 5, FontStyle.Bold)
            TranslatePreview.SelectedText = "" & vbCrLf
        End If
        If TList.Items.Contains("آیتی") = True Then
            TranslatePreview.SelectionColor() = Color.FromArgb(255, 130, 120, 110)
            TranslatePreview.SelectionFont = New Font(currentFont.FontFamily, currentFont.Size, FontStyle.Bold)
            TranslatePreview.SelectedText = "آیتی: "
            TranslatePreview.SelectionColor() = Color.FromArgb(255, 187, 178, 161)
            TranslatePreview.SelectionFont = New Font(currentFont.FontFamily, currentFont.Size, FontStyle.Regular)
            TranslatePreview.SelectedText = tAyati.Text & vbCrLf
            TranslatePreview.SelectionFont = New Font(currentFont.FontFamily, 5, FontStyle.Bold)
            TranslatePreview.SelectedText = "" & vbCrLf
        End If
        If TList.Items.Contains("بهرام پور") = True Then
            TranslatePreview.SelectionColor() = Color.FromArgb(255, 130, 120, 110)
            TranslatePreview.SelectionFont = New Font(currentFont.FontFamily, currentFont.Size, FontStyle.Bold)
            TranslatePreview.SelectedText = "بهرام پور: "
            TranslatePreview.SelectionColor() = Color.FromArgb(255, 187, 178, 161)
            TranslatePreview.SelectionFont = New Font(currentFont.FontFamily, currentFont.Size, FontStyle.Regular)
            TranslatePreview.SelectedText = tBahrampour.Text & vbCrLf
            TranslatePreview.SelectionFont = New Font(currentFont.FontFamily, 5, FontStyle.Bold)
            TranslatePreview.SelectedText = "" & vbCrLf
        End If
        If TList.Items.Contains("فولادوند") = True Then
            TranslatePreview.SelectionColor() = Color.FromArgb(255, 130, 120, 110)
            TranslatePreview.SelectionFont = New Font(currentFont.FontFamily, currentFont.Size, FontStyle.Bold)
            TranslatePreview.SelectedText = "فولادوند: "
            TranslatePreview.SelectionColor() = Color.FromArgb(255, 187, 178, 161)
            TranslatePreview.SelectionFont = New Font(currentFont.FontFamily, currentFont.Size, FontStyle.Regular)
            TranslatePreview.SelectedText = tFooladvand.Text & vbCrLf
            TranslatePreview.SelectionFont = New Font(currentFont.FontFamily, 5, FontStyle.Bold)
            TranslatePreview.SelectedText = "" & vbCrLf
        End If
        If TList.Items.Contains("قرائتی") = True Then
            TranslatePreview.SelectionColor() = Color.FromArgb(255, 130, 120, 110)
            TranslatePreview.SelectionFont = New Font(currentFont.FontFamily, currentFont.Size, FontStyle.Bold)
            TranslatePreview.SelectedText = "قرائتی: "
            TranslatePreview.SelectionColor() = Color.FromArgb(255, 187, 178, 161)
            TranslatePreview.SelectionFont = New Font(currentFont.FontFamily, currentFont.Size, FontStyle.Regular)
            TranslatePreview.SelectedText = tGharaati.Text & vbCrLf
            TranslatePreview.SelectionFont = New Font(currentFont.FontFamily, 5, FontStyle.Bold)
            TranslatePreview.SelectedText = "" & vbCrLf
        End If
        If TList.Items.Contains("الهی قمشه‌ای") = True Then
            TranslatePreview.SelectionColor() = Color.FromArgb(255, 130, 120, 110)
            TranslatePreview.SelectionFont = New Font(currentFont.FontFamily, currentFont.Size, FontStyle.Bold)
            TranslatePreview.SelectedText = "الهی قمشه‌ای: "
            TranslatePreview.SelectionColor() = Color.FromArgb(255, 187, 178, 161)
            TranslatePreview.SelectionFont = New Font(currentFont.FontFamily, currentFont.Size, FontStyle.Regular)
            TranslatePreview.SelectedText = tGhomshei.Text & vbCrLf
            TranslatePreview.SelectionFont = New Font(currentFont.FontFamily, 5, FontStyle.Bold)
            TranslatePreview.SelectedText = "" & vbCrLf
        End If
        If TList.Items.Contains("خرمدل") = True Then
            TranslatePreview.SelectionColor() = Color.FromArgb(255, 130, 120, 110)
            TranslatePreview.SelectionFont = New Font(currentFont.FontFamily, currentFont.Size, FontStyle.Bold)
            TranslatePreview.SelectedText = "خرمدل: "
            TranslatePreview.SelectionColor() = Color.FromArgb(255, 187, 178, 161)
            TranslatePreview.SelectionFont = New Font(currentFont.FontFamily, currentFont.Size, FontStyle.Regular)
            TranslatePreview.SelectedText = tKhorramdel.Text & vbCrLf
            TranslatePreview.SelectionFont = New Font(currentFont.FontFamily, 5, FontStyle.Bold)
            TranslatePreview.SelectedText = "" & vbCrLf
        End If
        If TList.Items.Contains("خرمشاهی") = True Then
            TranslatePreview.SelectionColor() = Color.FromArgb(255, 130, 120, 110)
            TranslatePreview.SelectionFont = New Font(currentFont.FontFamily, currentFont.Size, FontStyle.Bold)
            TranslatePreview.SelectedText = "خرمشاهی: "
            TranslatePreview.SelectionColor() = Color.FromArgb(255, 187, 178, 161)
            TranslatePreview.SelectionFont = New Font(currentFont.FontFamily, currentFont.Size, FontStyle.Regular)
            TranslatePreview.SelectedText = tKhorramshahi.Text & vbCrLf
            TranslatePreview.SelectionFont = New Font(currentFont.FontFamily, 5, FontStyle.Bold)
            TranslatePreview.SelectedText = "" & vbCrLf
        End If
        If TList.Items.Contains("مکارم شیرازی") = True Then
            TranslatePreview.SelectionColor() = Color.FromArgb(255, 130, 120, 110)
            TranslatePreview.SelectionFont = New Font(currentFont.FontFamily, currentFont.Size, FontStyle.Bold)
            TranslatePreview.SelectedText = "مکارم شیرازی: "
            TranslatePreview.SelectionColor() = Color.FromArgb(255, 187, 178, 161)
            TranslatePreview.SelectionFont = New Font(currentFont.FontFamily, currentFont.Size, FontStyle.Regular)
            TranslatePreview.SelectedText = tMakarem.Text & vbCrLf
            TranslatePreview.SelectionFont = New Font(currentFont.FontFamily, 5, FontStyle.Bold)
            TranslatePreview.SelectedText = "" & vbCrLf
        End If

        If TList.Items.Contains("معزی") = True Then
            TranslatePreview.SelectionColor() = Color.FromArgb(255, 130, 120, 110)
            TranslatePreview.SelectionFont = New Font(currentFont.FontFamily, currentFont.Size, FontStyle.Bold)
            TranslatePreview.SelectedText = "معزی: "
            TranslatePreview.SelectionColor() = Color.FromArgb(255, 187, 178, 161)
            TranslatePreview.SelectionFont = New Font(currentFont.FontFamily, currentFont.Size, FontStyle.Regular)
            TranslatePreview.SelectedText = tMoezzi.Text & vbCrLf
            TranslatePreview.SelectionFont = New Font(currentFont.FontFamily, 5, FontStyle.Bold)
            TranslatePreview.SelectedText = "" & vbCrLf
        End If
        If TList.Items.Contains("مجتبوی") = True Then
            TranslatePreview.SelectionColor() = Color.FromArgb(255, 130, 120, 110)
            TranslatePreview.SelectionFont = New Font(currentFont.FontFamily, currentFont.Size, FontStyle.Bold)
            TranslatePreview.SelectedText = "مجتبوی: "
            TranslatePreview.SelectionColor() = Color.FromArgb(255, 187, 178, 161)
            TranslatePreview.SelectionFont = New Font(currentFont.FontFamily, currentFont.Size, FontStyle.Regular)
            TranslatePreview.SelectedText = tMojtabavi.Text & vbCrLf
            TranslatePreview.SelectionFont = New Font(currentFont.FontFamily, 5, FontStyle.Bold)
            TranslatePreview.SelectedText = "" & vbCrLf
        End If
        If TList.Items.Contains("صادقی تهرانی") = True Then
            TranslatePreview.SelectionColor() = Color.FromArgb(255, 130, 120, 110)
            TranslatePreview.SelectionFont = New Font(currentFont.FontFamily, currentFont.Size, FontStyle.Bold)
            TranslatePreview.SelectedText = "صادقی تهرانی: "
            TranslatePreview.SelectionColor() = Color.FromArgb(255, 187, 178, 161)
            TranslatePreview.SelectionFont = New Font(currentFont.FontFamily, currentFont.Size, FontStyle.Regular)
            TranslatePreview.SelectedText = tSadeqi.Text & vbCrLf
        End If
        AddViewCounts_Click(Nothing, Nothing)

        '##\\ Sajdeh Notification \\###################################################################################################
        Dim sajdeh As String
        sajdeh = MatnArab.Text.Substring(MatnArab.Text.Length - 1)
        'MsgBox(sajdeh)
        If sajdeh = "۩" Then
            MatnArab.ForeColor = Color.Yellow
            TranslatePreview.ForeColor = Color.Yellow
        Else
            MatnArab.ForeColor = Color.FromArgb(187, 178, 161)
            TranslatePreview.ForeColor = Color.FromArgb(187, 178, 161)
        End If

        '##\\ Play Aye MP3 Audio \\####################################################################################################
        If MPC3.playState = WMPPlayState.wmppsPlaying Then
        Else
            MPC3.close()
            PlayAudio_Click(Nothing, Nothing)
        End If

    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MPC3.controls.stop()
        '##\\ Go to Next Available Ayeh \\#############################################################################################
        If Val(AyeList.Text) >= AyeList.Items.Count Then
            If SoreList.SelectedIndex >= 113 Then
                Exit Sub
            Else
                SoreList.SelectedIndex = SoreList.SelectedIndex + 1
                LoadAyehList_Click(Nothing, Nothing)
                LoadTexts_Click(Nothing, Nothing)
            End If
        Else
            AyeList.Text = AyeList.Text + 1
            LoadTexts_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MPC3.controls.stop()
        '##\\ Go to Previous Available Ayeh \\#########################################################################################
        If Val(AyeList.Text) = 1 Then
            If SoreList.SelectedIndex < 1 Then
                Exit Sub
            Else
                SoreList.SelectedIndex = SoreList.SelectedIndex - 1
                LoadAyehList_Click(Nothing, Nothing)
                AyeList.Text = AyeList.Items.Count
                LoadTexts_Click(Nothing, Nothing)
            End If
        Else
            AyeList.Text = AyeList.Text - 1
            LoadTexts_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub FontFars_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontFars.Click

        '##\\ Open Font Dialog \\######################################################################################################
        FontDialog1.Font = TranslatePreview.Font
        FontDialog1.ShowDialog()
        TFName.Text = FontDialog1.Font.Name
        TFSize.Text = FontDialog1.Font.Size
        '##\\ Apply new Font Dialog \\#################################################################################################
        TranslatePreview.Font = New Font(TFName.Text, TFSize.Text)
        TranslatePreview.Clear()
        LoadTexts_Click(Nothing, Nothing)

        '##\\ Save New Font in Database \\#############################################################################################
        Dim clean As New OleDbCommand("UPDATE LastAye SET FarsFontName = '" & TFName.Text & "' , FarsFontSize = '" & TFSize.Text & "' ", con)
        con.Open()
        clean.ExecuteNonQuery()
        con.Close()

    End Sub


    Private Sub LoadFontFromDB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadFontFromDB.Click

        '##\\ Load Font Setting from Database \\#######################################################################################
        sql = "Select * From LastAye"
        maxrow = get_maxrow(sql)
        If maxrow > 0 Then
            With dt.Rows(0)
                TFName.Text = .Item("FarsFontName")
                TFSize.Text = .Item("FarsFontSize")
                AFName.Text = .Item("ArabFontName")
                AFSize.Text = .Item("ArabFontSize")
            End With
        End If
        MatnArab.Font = New Font(AFName.Text, AFSize.Text)
        TranslatePreview.Font = New Font(TFName.Text, TFSize.Text)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        '##\\ Open Font Dialog  for Arabic Text \\#####################################################################################
        FontDialog1.Font = MatnArab.Font
        FontDialog1.ShowDialog()
        AFName.Text = FontDialog1.Font.Name
        AFSize.Text = FontDialog1.Font.Size

        '##\\ Apply new Font Dialog for Arabic Text \\#################################################################################
        MatnArab.Font = New Font(AFName.Text, AFSize.Text)

        '##\\ Save New Arabic Font in Database \\######################################################################################
        Dim clean As New OleDbCommand("UPDATE LastAye SET ArabFontName = '" & AFName.Text & "' , ArabFontSize = '" & AFSize.Text & "' ", con)
        con.Open()
        clean.ExecuteNonQuery()
        con.Close()
    End Sub

    Private Sub SaveLastAye_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveLastAye.Click

        '##\\ Save Last Read Ayeh in Database \\#######################################################################################
        Try
            If favorateSores = False Then
                Dim clean As New OleDbCommand("UPDATE LastAye SET comSooreh = " & SoreList.SelectedValue & " , comAyeh = " & AyeList.SelectedIndex + 1, con)
                con.Open()
                clean.ExecuteNonQuery()
                con.Close()
            Else
                Dim clean As New OleDbCommand("UPDATE LastAye SET FavSooreh = " & SoreList.SelectedValue & " , FavAyeh = " & AyeList.SelectedIndex + 1, con)
                con.Open()
                clean.ExecuteNonQuery()
                con.Close()
            End If
        Catch ex As Exception

        End Try



    End Sub

    Private Sub LoadLastAye_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadLastAye.Click

        '##\\ Load Last Ayeh  from Database \\#########################################################################################
        sql = "Select * From LastAye"
        maxrow = get_maxrow(sql)
        If maxrow > 0 Then
            With dt.Rows(0)

                If favorateSores = False Then
                    SoreList.SelectedValue = .Item("comSooreh")
                    LoadAyehList_Click(Nothing, Nothing)
                    AyeList.Text = .Item("comAyeh")
                Else
                    SoreList.SelectedValue = .Item("FavSooreh")
                    LoadAyehList_Click(Nothing, Nothing)
                    AyeList.Text = .Item("FavAyeh")
                End If

            End With
        End If


    End Sub

    Private Sub LoadAyehList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadAyehList.Click

        '##\\ load Ayeh List \\#########################################################################################################
        Try
            con.Open()
            cmd = New OleDb.OleDbCommand
            da = New OleDb.OleDbDataAdapter
            dt = New DataTable
            sql = "Select * From theQuran where SorehNo= " & SoreList.SelectedValue & " ORDER BY AyehNo"
            With cmd
                .Connection = con
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            AyeList.DataSource = dt
            AyeList.DisplayMember = "AyehNo"
            AyeList.ValueMember = "QID"
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            da.Dispose()
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
 
        If Me.Height < 487 Then

            Me.Height = 487
            If SettingPanel1.Visible = True Then
                Me.MinimumSize = New Size(569, 325)
                MatnArab.Height = MatnArab.Height + 330
                SettingPanel1.Visible = False
            Else

                Me.MinimumSize = New Size(569, 487)
                MatnArab.Height = MatnArab.Height - 330
                SettingPanel1.Visible = True
            End If
            LoadFontFromDB_Click(Nothing, Nothing)
        Else

            '##\\ Auto Resize Arabic Text Height \\#########################################################################################
            If SettingPanel1.Visible = True Then
                Me.MinimumSize = New Size(569, 250)
                MatnArab.Height = MatnArab.Height + 330
                SettingPanel1.Visible = False
            Else
                Me.MinimumSize = New Size(569, 487)
                MatnArab.Height = MatnArab.Height - 330
                SettingPanel1.Visible = True
            End If
        End If
    End Sub

    Private Sub LoadBookMarks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadBookMarks.Click

        '##\\ Load ‌Bookmarked Ayeh  from Database \\####################################################################################
        BookmarksList.Items.Clear()
        Try
            con.Open()
            cmd = New OleDb.OleDbCommand
            da = New OleDb.OleDbDataAdapter
            dt = New DataTable
            sql = "Select * from FaivorateAye where isDelete = false"
            With cmd
                .Connection = con
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            For i = 0 To dt.Rows.Count - 1
                BookmarksList.Items.Add("[" & dt.Rows(i).Item(1) & ":" & dt.Rows(i).Item(2) & "] - " & dt.Rows(i).Item(3) & "                                           <" & dt.Rows(i).Item(0) & ">")
            Next
        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            con.Close()
            da.Dispose()
        End Try


    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        '##\\ Save ‌Bookmarked Ayeh to Database \\#######################################################################################
        Dim clean As New OleDbCommand("INSERT INTO FaivorateAye (comSooreh, comAyeh, AyehAddress) VALUES (" & SoreList.SelectedValue & " , " & AyeList.Text & " , '" & SoreList.Text & " آیه - " & AyeList.Text & "')", con)
        con.Open()
        clean.ExecuteNonQuery()
        con.Close()
        LoadBookMarks_Click(Nothing, Nothing)
    End Sub

    Private Sub BookmarksList_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookmarksList.DoubleClick

        '##\\ Resume From ‌Bookmarked \\#################################################################################################
        Dim a, b, c, SoreAdress, AyeAdress As String
        a = Split(BookmarksList.Text, "]")(0).ToString
        b = a.Length
        c = a.Substring(1, a.Length - 1)
        SoreAdress = Split(c, ":")(0).ToString
        AyeAdress = Split(c, ":")(1).ToString
        SoreList.SelectedValue = SoreAdress
        LoadAyehList_Click(Nothing, Nothing)
        AyeList.Text = AyeAdress
        LoadTexts_Click(Nothing, Nothing)
    End Sub

    Private Sub ViewBookmarkAyeh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewBookmarkAyeh.Click
        '##\\ Resume From ‌Bookmarked \\#################################################################################################
        BookmarksList_DoubleClick(Nothing, Nothing)
    End Sub

    Private Sub DeleteBookmarkAyeh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteBookmarkAyeh.Click

        '##\\ Check if List is Empty on Not Selected \\################################################################################
        If (BookmarksList.Text = "") Then
            MessageBox.Show("ابتدا یک آیتم از لیست را انتخاب کنید", _
                                          "خطا", _
                                          MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            '##\\ Show Yes No Dialog to confirm Delete \\#############################################################################
            Dim result As DialogResult = MessageBox.Show("?این آیه از لیست علاقه مندی ها حذف شود", _
                                          "درخواست حذف آیه از لیست علاقه مندی", _
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If (result = DialogResult.Yes) Then

                '##\\ Get BookMark Id  \\#############################################################################################
                Dim a, b As String
                a = Split(BookmarksList.Text, "<")(1).ToString
                b = a.Substring(0, a.Length - 1)

                '##\\ Delete From ‌Bookmarked Ayeh \\##################################################################################
                Dim clean As New OleDbCommand("UPDATE FaivorateAye SET isDelete = true Where ID= " & b, con)
                con.Open()
                clean.ExecuteNonQuery()
                con.Close()
                LoadBookMarks_Click(Nothing, Nothing)
            Else

            End If
        End If
    End Sub


    Private Sub AddViewCounts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddViewCounts.Click

        '##\\ Read and Update ViewCounts Ayeh \\######################################################################################
        sql = "Select ViewCounts From AyeCounter where ID = " & AyeList.SelectedValue
        maxrow = get_maxrow(sql)

        If IsDBNull(dt.Rows(0).Item("ViewCounts")) = True Then
            VCounter.Text = 0
        Else
            VCounter.Text = dt.Rows(0).Item("ViewCounts")
        End If
        Dim clean As New OleDbCommand("UPDATE AyeCounter SET ViewCounts = " & Val(VCounter.Text) + 1 & " Where ID = " & AyeList.SelectedValue, con)
        con.Open()
        clean.ExecuteNonQuery()
        con.Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        '##\\ Reset ViewCounts in Database \\######################################################################################
        Dim result As DialogResult = MessageBox.Show("?شمارشگر آیات خوانده شده ریست شود", _
                                                 "شمارشگر آیه ", _
                                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (result = DialogResult.Yes) Then
            Dim clean As New OleDbCommand("UPDATE AyeCounter SET ViewCounts = 0", con)
            con.Open()
            clean.ExecuteNonQuery()
            con.Close()
        End If
        VCounter.Text = 0
        AyehAdressStat.Text = "سوره: " & SoreList.SelectedValue & " | آیه: " & AyeList.Text & "/" & AyeList.Items.Count
        Me.Text = "The Quran - Copyright (C) 2021 Ahmad Ahmadi. " & " - " & AyehAdressStat.Text & " - (تعداد بازدید این آیه:" & VCounter.Text & ") "
    End Sub

    Private Sub LoadSoreHa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadSoreHa.Click


        '##\\ Set Sore List to Faivorate mode \\###################################################################################
        favorateSores = False

        '##\\ Load Sore List from Database \\######################################################################################
        Try
            con.Open()
            cmd = New OleDb.OleDbCommand
            da = New OleDb.OleDbDataAdapter
            dt = New DataTable
            sql = "Select * From theQuran_List"
            With cmd
                .Connection = con
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            SoreList.DataSource = dt
            SoreList.DisplayMember = "SorehName"
            SoreList.ValueMember = "SorehNo"
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            da.Dispose()
        End Try

        '##\\ Load AyeHa List Text \\#############################################################################################
        LoadAyehList_Click(Nothing, Nothing)

        '##\\ Show Last Visited Ayeh \\###########################################################################################
        LoadLastAye_Click(Nothing, Nothing)

        '##\\ Load Quran Text \\##################################################################################################
        LoadTexts_Click(Nothing, Nothing)

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click


        '##\\ Set Sore List to Faivorate mode \\###################################################################################
        favorateSores = True

        '##\\ Load Stared Sore List from Database \\###############################################################################
        Try
            con.Open()
            cmd = New OleDb.OleDbCommand
            da = New OleDb.OleDbDataAdapter
            dt = New DataTable
            sql = "Select * From theQuran_List where note2 IS NOT NULL ORDER BY note2 ASC"
            With cmd
                .Connection = con
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            SoreList.DataSource = dt
            SoreList.DisplayMember = "SorehName"
            SoreList.ValueMember = "SorehNo"
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            da.Dispose()
        End Try

        '##\\ Load AyeHa List Text \\#############################################################################################
        LoadAyehList_Click(Nothing, Nothing)

        '##\\ Show Last Visited Ayeh \\###########################################################################################
        LoadLastAye_Click(Nothing, Nothing)

        '##\\ Load Quran Text \\##################################################################################################
        LoadTexts_Click(Nothing, Nothing)
    End Sub

    Private Sub LoadReward_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadReward.Click

        '##\\ Load Sore Reward as Tooltip \\########################################################################################
        Try
            sql = "Select * From theQuran_List where SorehNo =" & SoreList.SelectedValue
            maxrow = get_maxrow(sql)
            If maxrow > 0 Then
                With dt.Rows(0)
                    TextReward.Text = .Item("note")
                End With
            End If
        Catch ex As Exception

        End Try


        ToolTip2.RemoveAll()
        ToolTip2.SetToolTip(SoreList, TextReward.Text)

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click


        If System.IO.File.Exists(MP3FilePath1.Text) Then
            If MPC3.playState = WMPPlayState.wmppsPlaying Then
                MPC3.controls.pause()
            Else
                MPC3.controls.play()
            End If
        Else
            ExtractAudio_Click(Nothing, Nothing)
            PlayFile(MP3FilePath1.Text)

        End If

    End Sub

    Private Sub PlayAudio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlayAudio.Click

        FillFileNames_Click(Nothing, Nothing)
        PlayFile(MP3FilePath1.Text)

        If PlayMP3.Checked = True Then
            ExtractAudio_Click(Nothing, Nothing)
            MPC3.controls.play()
        Else
            MPC3.controls.stop()
        End If

    End Sub

    Private Sub PlayMP3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlayMP3.CheckedChanged
        If PlayMP3.Checked = True Then
            AutoNextAye.Enabled = True
            AutoNextAye.Checked = True

        Else
            AutoNextAye.Enabled = False
            AutoNextAye.Checked = False
        End If
    End Sub


    Private Sub MPC3_PlayStateChange(ByVal NewState As Integer) Handles MPC3.PlayStateChange




        Select Case NewState

            Case 0          'Undefined - Windows Media Player is in an undefined state.
            Case 1          'Stopped - Playback of the current media item is stopped.
                Button9.Image = Quran.My.Resources.Resources.Play
            Case 2          'Paused - Playback of the current media item is paused. When a media item is paused, resuming playback begins from the same location.
                Button9.Image = Quran.My.Resources.Resources.Play

            Case 3          'Playing - The current media item is playing.
                Button9.Image = Quran.My.Resources.Resources.Pause

            Case 4          'ScanForward - The current media item is fast forwarding.
            Case 5          'ScanReverse - The current media item is fast rewinding.
            Case 6          'Buffering - The current media item is getting additional data from the server.
            Case 7          'Waiting - Connection is established, but the server is not sending data. Waiting for session to begin.
            Case 8          'MediaEnded - Media item has completed playback.
                Button9.Image = Quran.My.Resources.Resources.Play
                MPC3.close()
                If AutoNextAye.Checked = True Then
                    Button1_Click(Nothing, Nothing)
                End If
            Case 9          'Transitioning - Preparing new media item.
            Case 10          'Ready - Ready to begin playing.
            Case 11          'Reconnecting - Reconnecting to stream.

        End Select
        'MsgBox(NewState)
    End Sub




    Private Sub Mainfrm_ResizeEnd(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ResizeEnd
        If Me.Height < 325 Then
            MatnArab.Font = New Font(AFName.Text, 16)
        Else
            LoadFontFromDB_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub Mainfrm_Deactivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Deactivate
        'Timer1.Enabled = True
    End Sub

    Private Sub Mainfrm_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        'Me.Opacity = 1
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Opacity = Me.Opacity - 0.1
        If Me.Opacity <= 0.7 Then Timer1.Enabled = False

    End Sub

    Private Sub Mainfrm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        wX.Text = Me.Location.X
        wY.Text = Me.Location.Y
        wW.Text = Me.Width
        wH.Text = Me.Height

        Dim clean As New OleDbCommand("UPDATE LastAye SET winX = " & wX.Text & " , winY = " & wY.Text & " , winW = " & wW.Text & " , winH = " & wH.Text, con)
        con.Open()
        clean.ExecuteNonQuery()
        con.Close()
    End Sub

    Private Sub FormLastLocation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormLastLocation.Click

        '##\\ Load Last Ayeh  from Database \\#########################################################################################
        sql = "Select * From LastAye"
        maxrow = get_maxrow(sql)
        If maxrow > 0 Then
            With dt.Rows(0)
                wX.Text = .Item("winX")
                wY.Text = .Item("winY")
                wW.Text = .Item("winW")
                wH.Text = .Item("winH")
            End With
        End If

        Me.Location = New Point(wX.Text, wY.Text)
        Me.Width = wW.Text
        Me.Height = wH.Text

    End Sub

    Private Sub LoadGhariList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadGhariList.Click
        For Each folder As String In System.IO.Directory.GetDirectories(Application.StartupPath & "\Audio\")
            ghari.Items.Add(IO.Path.GetFileName(folder))
        Next
        Lastghari_Click(Nothing, Nothing)
    End Sub

    Private Sub MP3File_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MP3File1.TextChanged

    End Sub


    Private Sub ExtractAudio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExtractAudio.Click
        Me.Cursor = Cursors.WaitCursor
        If System.IO.File.Exists(MP3FilePath0.Text) Then
        Else
            Try
                Using zip1 As ZipFile = ZipFile.Read(Application.StartupPath & "\Audio\" & ghari.Text & "\000_versebyverse.zip")
                    For Each z In zip1
                        If z.FileName = MP3File0.Text & ".mp3" Then
                            Directory.CreateDirectory(Application.StartupPath & "\temp\")
                            z.Extract(Application.StartupPath & "\temp\", ExtractExistingFileAction.OverwriteSilently)
                        End If
                    Next
                End Using
            Catch
            End Try
        End If
        If System.IO.File.Exists(MP3FilePath1.Text) Then
        Else
            Try
                Using zip1 As ZipFile = ZipFile.Read(Application.StartupPath & "\Audio\" & ghari.Text & "\000_versebyverse.zip")
                    For Each z In zip1
                        If z.FileName = MP3File1.Text & ".mp3" Then
                            Directory.CreateDirectory(Application.StartupPath & "\temp\")
                            z.Extract(Application.StartupPath & "\temp\", ExtractExistingFileAction.OverwriteSilently)
                        End If
                    Next
                End Using
            Catch
            End Try
        End If
        If System.IO.File.Exists(MP3FilePath2.Text) Then
        Else
            Try
                Using zip1 As ZipFile = ZipFile.Read(Application.StartupPath & "\Audio\" & ghari.Text & "\000_versebyverse.zip")
                    For Each z In zip1
                        If z.FileName = MP3File2.Text & ".mp3" Then
                            Directory.CreateDirectory(Application.StartupPath & "\temp\")
                            z.Extract(Application.StartupPath & "\temp\", ExtractExistingFileAction.OverwriteSilently)
                        End If
                    Next
                End Using
            Catch
            End Try
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ghari_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ghari.SelectedIndexChanged


        Dim clean As New OleDbCommand("UPDATE LastAye SET LastGhari = '" & ghari.Text & "'", con)
        con.Open()
        clean.ExecuteNonQuery()
        con.Close()

        If IO.Directory.Exists(Application.StartupPath & "\temp\") Then
            Me.Cursor = Cursors.WaitCursor
            My.Computer.FileSystem.DeleteDirectory(Application.StartupPath & "\temp\", FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
            Me.Cursor = Cursors.Default
        End If


    End Sub




    Private Sub Lastghari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lastghari.Click
        '##\\ Load Last Ghari from Database \\#########################################################################################
        sql = "Select * From LastAye"
        maxrow = get_maxrow(sql)

        If maxrow > 0 Then
            With dt.Rows(0)

                If ghari.Items.Contains(.Item("LastGhari")) = True Then
                    ghari.Text = .Item("LastGhari")
                Else
                    Try
                        ghari.SelectedIndex = 0
                    Catch ex As Exception

                    End Try

                End If

            End With
        End If
    End Sub
    Private Sub FillFileNames_Click(sender As Object, e As EventArgs) Handles FillFileNames.Click
        Dim Threezeros, SoreZeros, AyeZeros As String
        Dim PrevSore, PrevAyeh, CurrentSore, CurrentAyeh, NextSore, NextAyeh As Integer

        Threezeros = "000"
        CurrentSore = SoreList.SelectedIndex + 1
        CurrentAyeh = AyeList.SelectedIndex + 1
        SoreZeros = Threezeros.Substring(0, 3 - CurrentSore.ToString.Length)
        AyeZeros = Threezeros.Substring(0, 3 - CurrentAyeh.ToString.Length)
        MP3File1.Text = SoreZeros & SoreList.SelectedValue & AyeZeros & AyeList.SelectedIndex + 1
        MP3FilePath1.Text = Application.StartupPath & "\temp\" & SoreZeros & SoreList.SelectedValue & AyeZeros & AyeList.SelectedIndex + 1 & ".mp3"

        If AyeList.SelectedIndex = 0 Then
            If SoreList.SelectedIndex < 1 Then
                MP3File0.Text = "001001"
                MP3FilePath0.Text = Application.StartupPath & "\temp\" & MP3File0.Text & ".mp3"
                MP3File2.Text = "001002"
                MP3FilePath2.Text = Application.StartupPath & "\temp\" & MP3File2.Text & ".mp3"
                Exit Sub
            Else
                PrevSore = SoreList.SelectedIndex
                sql = "Select * From TheQuran_List where SorehNo = " & PrevSore
                maxrow = get_maxrow(sql)
                If maxrow > 0 Then
                    With dt.Rows(0)
                        PrevAyeh = .Item("TedadAyeh")
                    End With
                End If
                SoreZeros = Threezeros.Substring(0, 3 - PrevSore.ToString.Length)
                AyeZeros = Threezeros.Substring(0, 3 - PrevAyeh.ToString.Length)
                MP3File0.Text = SoreZeros & PrevSore & AyeZeros & PrevAyeh
                MP3FilePath0.Text = Application.StartupPath & "\temp\" & MP3File0.Text & ".mp3"
            End If
        Else

            MP3File0.Text = SoreZeros & SoreList.SelectedValue & AyeZeros & AyeList.SelectedIndex
            MP3FilePath0.Text = Application.StartupPath & "\temp\" & MP3File0.Text & ".mp3"
        End If

        If AyeList.SelectedIndex + 1 >= AyeList.Items.Count Then
            If SoreList.SelectedIndex >= 113 Then
                Exit Sub
            Else
                NextSore = SoreList.SelectedIndex + 2
                SoreZeros = Threezeros.Substring(0, 3 - NextSore.ToString.Length)
                MP3File2.Text = SoreZeros & NextSore & "001"
                MP3FilePath2.Text = Application.StartupPath & "\temp\" & MP3File2.Text & ".mp3"
            End If
        Else
            NextAyeh = AyeList.SelectedIndex + 2
            AyeZeros = Threezeros.Substring(0, 3 - NextAyeh.ToString.Length)
            MP3File2.Text = SoreZeros & SoreList.SelectedValue & AyeZeros & AyeList.SelectedIndex + 2
            MP3FilePath2.Text = Application.StartupPath & "\temp\" & MP3File2.Text & ".mp3"
        End If
    End Sub

    Private Sub pintop_Click(sender As Object, e As EventArgs) Handles pintop.Click


        If Me.TopMost = True Then
            Me.TopMost = False
            pintop.Image = Quran.My.Resources.Resources.never
        Else
            Me.TopMost = True
            pintop.Image = Quran.My.Resources.Resources.always
        End If

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Form2.Show()
    End Sub
End Class

