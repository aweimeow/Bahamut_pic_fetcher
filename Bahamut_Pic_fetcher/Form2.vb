Imports System.Text
Imports System.Net.Security
Imports System.Security.Cryptography.X509Certificates
Imports System.IO
Imports HtmlAgilityPack
Imports System.Web

Public Class Form2
    Public cookies As New CookieContainer
    Public username As String
    Dim picurl(1000) As String
    Dim index As Integer = 0
    Dim watchindex As Integer = 0
    Public savepath As String = ""
    Dim saveindex As Integer = 0

    Private Sub Btn_fetch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_fetch.Click
        index = 0
        Dim _url As String = TB_url.Text
        Dim page As Integer = 1
        Dim newpage As String
        Dim oldpage As String = ""
        '       Try
        If Not _url.Contains("page=1") Then
            MsgBox("請在網址內加入page=1")
        Else
            Dim response As HttpWebResponse = HttpWebResponseUtility.CreateGetHttpResponse(_url, Nothing, Nothing, cookies)
            Dim reader As StreamReader = New StreamReader(response.GetResponseStream, System.Text.Encoding.GetEncoding("UTF-8"))
            Dim respHTML As String = reader.ReadToEnd()
            Dim doc As New HtmlDocument()
            doc.LoadHtml(respHTML)
            Dim node As HtmlNode = doc.DocumentNode
            Dim p As HtmlNode = node.SelectNodes("//p[@class='BH-pagebtnA']")(0)
            Dim a_count As Integer = p.SelectNodes("a[@href]").Count
            Dim a As HtmlNode = p.SelectNodes("a[@href]")(a_count - 1)
            Dim lastpage As Integer = Integer.Parse(a.InnerText)
            For page = 1 To lastpage
                If page > 1 Then
                    newpage = "page=" & page
                    _url = _url.Replace(oldpage, newpage)
                End If
                findpic(_url)
                oldpage = "page=" & page
            Next
        End If
        'Catch ex As Exception
        '    MsgBox("發生錯誤，請回報作者：Btn_fetch_Click")
        'End Try
        If index < 8 Then
            Btn_next.Enabled = False
        End If
        display()
    End Sub

    Private Sub display()
        Dim PBarray() As PictureBox = {PB_1, PB_2, PB_3, PB_4, PB_5, PB_6, PB_7, PB_8, PB_9}
        For i As Integer = 0 To 8
            If Not picurl(watchindex + i) = Nothing Then
                PBarray(i).ImageLocation = picurl(watchindex + i)
            End If
        Next
    End Sub

    Private Sub findpic(ByVal _url)
        Dim response As HttpWebResponse = HttpWebResponseUtility.CreateGetHttpResponse(_url, Nothing, Nothing, cookies)
        Dim reader As StreamReader = New StreamReader(response.GetResponseStream, System.Text.Encoding.GetEncoding("UTF-8"))
        Dim respHTML As String = reader.ReadToEnd()
        Dim doc As New HtmlDocument()
        doc.LoadHtml(respHTML)
        Dim node As HtmlNode = doc.DocumentNode
        Dim max As Integer = HttpUtility.HtmlDecode(node.SelectNodes("//p[@class='FM-cbox5']").Count)
        Dim count As Integer = 0 '此頁圖片總數
        Dim cbox7(max) As HtmlNode
        Try
            count = node.SelectNodes("//a[@name='attachImgName']").Count
        Catch ex As Exception
            count = 0
        End Try
        Dim find_pic(count) As HtmlNode
        Dim temp As String
        For i = 1 To count
            find_pic(i - 1) = node.SelectNodes("//a[@name='attachImgName']")(i - 1)
            temp = find_pic(i - 1).GetAttributeValue("href", "")
            picurl(index) = temp
            index = index + 1
            'MsgBox(find_pic(i - 1).GetAttributeValue("href", ""))
        Next
        'For i As Integer = 1 To max
        '    count = 0
        '    cbox7(i - 1) = node.SelectNodes("//div[@class='FM-cbox7']")(i - 1)
        '    If cbox7(i - 1).InnerHtml.Contains("attachImgName") Then
        '        '''''''''''''''''''''''''''''出錯位置'''''''''''''''''''''''''''''
        '        count = HttpUtility.HtmlDecode(cbox7(i - 1).SelectNodes("//a[@name='attachImgName']").Count)
        '        MsgBox(count)
        '        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '        MsgBox(cbox7(i - 1).InnerHtml)
        '        For j As Integer = 1 To count
        '            find_a = cbox7(i - 1).SelectNodes("a")(j - 1)
        '            MsgBox(find_a.GetAttributeValue("href", ""))
        '            picurl(index) = find_a.GetAttributeValue("href", "")
        '            index = index + 1
        '        Next
        '    End If

        'Next
    End Sub

    Private Sub Btn_next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_next.Click
        watchindex = watchindex + 9
        If watchindex > 9 Then
            Btn_previous.Enabled = True
        End If
        If (index - watchindex) < 9 Then
            Btn_next.Enabled = False
        End If
        display()
    End Sub

    Private Sub Btn_previous_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_previous.Click
        watchindex = watchindex - 9
        If watchindex < 9 Then
            Btn_previous.Enabled = False
        End If
        display()
    End Sub

    Private Sub PB_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PB_1.Click
        PB_large.ImageLocation = PB_1.ImageLocation
    End Sub

    Private Sub PB_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PB_2.Click
        PB_large.ImageLocation = PB_2.ImageLocation
    End Sub

    Private Sub PB_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PB_3.Click
        PB_large.ImageLocation = PB_3.ImageLocation
    End Sub

    Private Sub PB_4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PB_4.Click
        PB_large.ImageLocation = PB_4.ImageLocation
    End Sub

    Private Sub PB_5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PB_5.Click
        PB_large.ImageLocation = PB_5.ImageLocation
    End Sub

    Private Sub PB_6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PB_6.Click
        PB_large.ImageLocation = PB_6.ImageLocation
    End Sub

    Private Sub PB_7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PB_7.Click
        PB_large.ImageLocation = PB_7.ImageLocation
    End Sub

    Private Sub PB_8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PB_8.Click
        PB_large.ImageLocation = PB_8.ImageLocation
    End Sub

    Private Sub PB_9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PB_9.Click
        PB_large.ImageLocation = PB_9.ImageLocation
    End Sub

    Private Sub PB_large_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles PB_large.DoubleClick
        SaveFileDialog1.Filter = "Image files (*.jpg,*.png,*.gif)|*.jpg,*.png,*.gif"
        SaveFileDialog1.ShowDialog()
        PB_large.Image.Save(SaveFileDialog1.FileName)
    End Sub

End Class
