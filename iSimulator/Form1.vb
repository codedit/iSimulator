Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WebKitBrowser1.UserAgent = "Mozilla/5.0 (iPod; U; CPU iPhone OS 4_3_3 like Mac OS X; en-us) AppleWebKit/533.17.9 (KHTML, like Gecko) Version/5.0.2 Mobile/8J2 Safari/6533.18.5"
        WebKitBrowser1.Navigate("http://google.com/")
        'this /should/ hide those horrible scrollbars, but it doesn't
        WebKitBrowser1.VerticalScroll.Visible = False
        WebKitBrowser1.HorizontalScroll.Visible = False
     End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        WebKitBrowser1.Navigate(TextBox1.Text.ToString)
    End Sub

    Private Sub WebKitBrowser1_Navigated(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserNavigatedEventArgs) Handles WebKitBrowser1.Navigated
        TextBox1.Text = WebKitBrowser1.Url.ToString
    

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim firmware As String = TextBox2.Text.Replace(".", "_")
        Dim build As String = TextBox3.Text
        Dim locale As String = TextBox4.Text

        Dim device As String = ComboBox1.Text.ToString


        Dim ua As String = "Mozilla/5.0 (" + device + "; U; CPU iPhone OS " + firmware + " like Mac OS X; " + locale + ") AppleWebKit/533.17.9 (KHTML, like Gecko) Version/5.0.2 Mobile/" + build + " Safari/6533.18.5"
        WebKitBrowser1.UserAgent = ua
    End Sub

   
End Class
