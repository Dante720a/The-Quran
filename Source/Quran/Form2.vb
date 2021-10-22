Imports System.Data.OleDb



Public Class Form2
    '##\\ Connect to Access Database \\#################################################################################################
    Private con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\Quran.mdb")
    Dim cmd As OleDb.OleDbCommand
    Dim da As OleDb.OleDbDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Dim maxrow As Integer

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

    Private Sub LoadLists_Click(sender As Object, e As EventArgs) Handles LoadLists.Click
        SoreRemain.Items.Clear()
        Try
            con.Open()
            cmd = New OleDb.OleDbCommand
            da = New OleDb.OleDbDataAdapter
            dt = New DataTable
            sql = "Select * from TheQuran_List where note2 IS NULL"
            With cmd
                .Connection = con
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            For i = 0 To dt.Rows.Count - 1

                SoreRemain.Items.Add(dt.Rows(i).Item(1))
            Next
        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            con.Close()
            da.Dispose()
        End Try

        SoreSelect.Items.Clear()
        Try
            con.Open()
            cmd = New OleDb.OleDbCommand
            da = New OleDb.OleDbDataAdapter
            dt = New DataTable
            sql = "Select * from TheQuran_List where note2 IS not NULL ORDER BY note2 asc"
            With cmd
                .Connection = con
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            For i = 0 To dt.Rows.Count - 1
                SoreSelect.Items.Add(dt.Rows(i).Item(1))
            Next
        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            con.Close()
            da.Dispose()
        End Try
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        With SoreSelect
4:
            If .SelectedIndex > 0 Then
5:
                Dim i = .SelectedIndex - 1
6:
                .Items.Insert(i, .SelectedItem)
7:
                .Items.RemoveAt(.SelectedIndex)
8:
                .SelectedIndex = i
9:
            End If
10:
        End With
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        With SoreSelect
17:
            If .SelectedIndex < .Items.Count - 1 Then
18:
                Dim i = .SelectedIndex + 2
19:
                .Items.Insert(i, .SelectedItem)
20:
                .Items.RemoveAt(.SelectedIndex)
21:
                .SelectedIndex = i - 1
22:
            End If
23:
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SoreSelect.Items.Add(SoreRemain.SelectedItem.ToString)
        SoreRemain.Items.Remove(SoreRemain.SelectedItem.ToString)
        SoreSelect.SelectedIndex = SoreSelect.Items.Count - 1
    End Sub



    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        '##\\ Resume From ‌Bookmarked \\#################################################################################################
        Dim a, b, c, d As String
        d = SoreSelect.Text
        a = Split(SoreSelect.Text, ")")(0).ToString
        b = a.Length
        c = a.Substring(1, a.Length - 1)

        Dim clean As New OleDbCommand("UPDATE TheQuran_List SET note2 = NULL WHERE SorehNo = " & c, con)
        con.Open()
        clean.ExecuteNonQuery()
        con.Close()
        LoadLists_Click(Nothing, Nothing)


        With SoreRemain
            .SelectedIndex = -1 '// -1 Index ='s No.Item.Selected.

            For Each itm As String In .Items '// loop thru items.
                If itm.ToLower = d.ToLower Then '// Case inSensitive search.
                    .SelectedItem = itm '// select item.
                    Exit For '// exit loop since item located. 
                End If
            Next
            Exit Sub '// just.because the next 2 lines are not worth reading. :)

        End With



    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)

        SoreSelect.Items.Add(SoreRemain.SelectedItem.ToString)
        SoreRemain.Items.Remove(SoreRemain.SelectedItem.ToString)
        SoreSelect.SelectedIndex = SoreSelect.Items.Count - 1

        Dim a, b, c As String
        a = Split(SoreSelect.Text, ")")(0).ToString
        b = a.Length
        c = a.Substring(1, a.Length - 1)

        Dim clean As New OleDbCommand("UPDATE TheQuran_List SET note2 = " & SoreSelect.SelectedIndex & " WHERE SorehNo = " & c, con)
        con.Open()
        clean.ExecuteNonQuery()
        con.Close()
        LoadLists_Click(Nothing, Nothing)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        
        Button8.Enabled = False
        Me.Cursor = Cursors.WaitCursor

Dim i As Double
        Dim a, b, c As String

        With SoreSelect
            .SelectedIndex = -1 '// -1 Index ='s No.Item.Selected.

            For Each itm As String In .Items '// loop thru items.
                i = i + 1
                a = Split(itm, ")")(0).ToString
                b = a.Length
                c = a.Substring(1, a.Length - 1)

                Dim clean As New OleDbCommand("UPDATE TheQuran_List SET note2 = " & i & " WHERE SorehNo = " & c, con)
                con.Open()
                clean.ExecuteNonQuery()
                con.Close()

            Next
            Dim reset As New OleDbCommand("UPDATE LastAye SET FavSooreh = 1 , FavAyeh = 1", con)
            con.Open()
            reset.ExecuteNonQuery()
            con.Close()
            Me.Close()
            Me.Cursor = Cursors.Default
            Button8.Enabled = True
            Exit Sub '// just.because the next 2 lines are not worth reading. :)

        End With
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadLists_Click(Nothing, Nothing)
    End Sub
End Class
