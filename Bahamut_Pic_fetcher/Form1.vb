Imports System.Text
Imports System.Net.Security
Imports System.Security.Cryptography.X509Certificates
Imports System.IO
Imports HtmlAgilityPack

Public Class Form1
    Dim cookies As New CookieContainer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'PictureBox1_Click(sender, e)
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Dim resquest As HttpWebResponse = HttpWebResponseUtility.CreateGetHttpResponse("http://user.gamer.com.tw/kcaptchaImg.php", Nothing, Nothing, cookies)
        Dim responseStream As System.IO.Stream = resquest.GetResponseStream()
        Dim bitmap2 As New Bitmap(responseStream)
        PictureBox1.Image = bitmap2
    End Sub

    Private Sub Btn_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_login.Click
        If Not TB_account.Text = "" AndAlso Not TB_password.Text = "" AndAlso Not TB_check.Text = "" Then
            Dim username As String = TB_account.Text
            Dim password As String = TB_password.Text
            Dim cert As String = TB_check.Text
            Try
                Dim parameters As IDictionary(Of String, String) = New Dictionary(Of String, String)()
                parameters.Add("onlogin", 0)
                parameters.Add("hasCheck", 1)
                parameters.Add("uidh", username)
                parameters.Add("passwdh", password)
                parameters.Add("kpwd", cert)
                parameters.Add("saveid", "T")
                parameters.Add("rnb", Nothing)
                Dim login_response As HttpWebResponse = HttpWebResponseUtility.CreatePostHttpResponse("http://user.gamer.com.tw/doLogin.php", parameters, Nothing, Nothing, Encoding.UTF8, cookies)
                Form2.Visible = True
                Form2.cookies = cookies
                Form2.username = username
                Form2.Text = "巴哈姆特場外圖片抓取器 @ " & username
                Me.Visible = False
            Catch ex As Exception
                MsgBox("連線錯誤或帳號密碼輸入錯誤，請重新嘗試")
            End Try
        Else
            MsgBox("請把所有格子填齊")
        End If
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Not Form2.Visible = True Then
            Me.Close()
        End If
    End Sub
End Class

''' <summary>
''' 有關HTTP請求的模組
''' </summary>
Public Class HttpWebResponseUtility
    Private Shared ReadOnly DefaultUserAgent As String = "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; WOW64; Trident/6.0; MAMIJS)"
    ''' <summary>
    ''' 創建GET方式的HTTP請求
    ''' </summary>
    ''' <param name="url">請求的URL</param>
    ''' <param name="timeout">請求的超時時間</param>
    ''' <param name="userAgent">請求的客戶端瀏覽器信息，可以為空</param>
    ''' <param name="cookies">隨同HTTP請求發送的Cookie信息，如果不需要身分驗證可以為空</param>
    ''' <returns></returns>
    Public Shared Function CreateGetHttpResponse(ByVal url As String, ByVal timeout As System.Nullable(Of Integer), ByVal userAgent As String, ByVal cookies As CookieContainer) As HttpWebResponse
        If String.IsNullOrEmpty(url) Then
            Throw New ArgumentNullException("url")
        End If
        Dim request As HttpWebRequest = TryCast(WebRequest.Create(url), HttpWebRequest)
        request.Method = "GET"
        request.KeepAlive = True
        request.UserAgent = DefaultUserAgent
        If Not String.IsNullOrEmpty(userAgent) Then
            request.UserAgent = userAgent
        End If
        If timeout.HasValue Then
            request.Timeout = timeout.Value
        End If
        If cookies IsNot Nothing Then
            request.CookieContainer = cookies
            'request.CookieContainer = New CookieContainer()
            'request.CookieContainer.Add(cookies)
        End If
        Return TryCast(request.GetResponse(), HttpWebResponse)
    End Function
    ''' <summary>
    ''' 創建POST方式的HTTP請求
    ''' </summary>
    ''' <param name="url">請求的URL</param>
    ''' <param name="parameters">隨同請求POST的參數名稱及參數值字典</param>
    ''' <param name="timeout">請求的超時時間</param>
    ''' <param name="userAgent">請求的客戶端瀏覽器信息，可以為空</param>
    ''' <param name="requestEncoding">發送HTTP請求時所用的編碼</param>
    ''' <param name="cookies">隨同HTTP請求發送的Cookie信息，如果不需要身分驗證可以為空</param>
    ''' <returns></returns>
    Public Shared Function CreatePostHttpResponse(ByVal url As String, ByVal parameters As IDictionary(Of String, String), ByVal timeout As System.Nullable(Of Integer), ByVal userAgent As String, ByVal requestEncoding As Encoding, ByVal cookies As CookieContainer) As HttpWebResponse
        If String.IsNullOrEmpty(url) Then
            Throw New ArgumentNullException("url")
        End If
        If requestEncoding Is Nothing Then
            Throw New ArgumentNullException("requestEncoding")
        End If
        Dim request As HttpWebRequest = Nothing
        '如果是發送HTTPS請求
        If url.StartsWith("https", StringComparison.OrdinalIgnoreCase) Then
            ServicePointManager.ServerCertificateValidationCallback = New RemoteCertificateValidationCallback(AddressOf CheckValidationResult)
            request = TryCast(WebRequest.Create(url), HttpWebRequest)
            request.ProtocolVersion = HttpVersion.Version10
        Else
            request = TryCast(WebRequest.Create(url), HttpWebRequest)
        End If
        request.Method = "POST"
        request.KeepAlive = True
        request.ContentType = "application/x-www-form-urlencoded"

        If Not String.IsNullOrEmpty(userAgent) Then
            request.UserAgent = userAgent
        Else
            request.UserAgent = DefaultUserAgent
        End If

        If timeout.HasValue Then
            request.Timeout = timeout.Value
        End If
        If cookies IsNot Nothing Then
            request.CookieContainer = cookies
            'request.CookieContainer = New CookieContainer()
            'request.CookieContainer.Add(cookies)
        End If
        '如果需要POST數據
        If Not (parameters Is Nothing OrElse parameters.Count = 0) Then
            Dim buffer As New StringBuilder()
            Dim i As Integer = 0
            For Each key As String In parameters.Keys
                If i > 0 Then
                    buffer.AppendFormat("&{0}={1}", key, parameters(key))
                Else
                    buffer.AppendFormat("{0}={1}", key, parameters(key))
                End If
                i += 1
            Next
            Dim data As Byte() = requestEncoding.GetBytes(buffer.ToString())
            Using stream As Stream = request.GetRequestStream()
                stream.Write(data, 0, data.Length)
            End Using
        End If
        Return TryCast(request.GetResponse(), HttpWebResponse)

    End Function

    Private Shared Function CheckValidationResult(ByVal sender As Object, ByVal certificate As X509Certificate, ByVal chain As X509Chain, ByVal errors As SslPolicyErrors) As Boolean
        Return True
        '總是接受
    End Function
End Class
