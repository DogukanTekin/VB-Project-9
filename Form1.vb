Public Class Form1
    Dim ilac_sayisi As String
    Dim sayisal As Boolean = False
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ilac As String
        If Convert.ToInt32(ilac_sayisi) = CheckedListBox1.Items.Count Then
            MsgBox("Daha Fazla Giriş Yapamazsınız")
        Else
            Do While (Convert.ToInt32(ilac_sayisi) > CheckedListBox1.Items.Count)
                ilac = InputBox("Eklemek İstediğiniz İlacın Adını Giriniz")
                If CheckedListBox1.Items.Contains(ilac) Then
                    MsgBox("Aynı İlaç Girildi")
                Else
                    CheckedListBox1.Items.Add(ilac)
                End If
            Loop
            MsgBox("Daha Fazla İlaç Girişi Yapamazsınız")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If CheckedListBox1.CheckedItems.Count = 1 Then
            CheckedListBox1.Items.Remove(CheckedListBox1.SelectedItem)
            MsgBox("Silme İşlemi Başarılı")
        ElseIf CheckedListBox1.CheckedItems.Count = 0 Then
            MsgBox("Lütfen Silmek İstediğiniz İlaçları Seçiniz")
        Else
            If CheckedListBox1.CheckedItems.Count > 0 Then
                For checked As Integer = CheckedListBox1.CheckedItems.Count - 1 To 0 Step -1
                    CheckedListBox1.Items.Remove(CheckedListBox1.CheckedItems(checked))
                Next
            End If
            MsgBox("Silme İşlemi Başarılı")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        While (sayisal = False)
            ilac_sayisi = InputBox("Kaç Adet İlaç Girişi Yapacaksınız ?")
            If IsNumeric(ilac_sayisi) Then
                sayisal = True
            Else
                sayisal = False
                MsgBox("Lütfen Sayısal Değer Giriniz!")
            End If
        End While
        For i = 0 To Convert.ToInt32(ilac_sayisi) - 1
            CheckedListBox1.Items.Add(InputBox((i + 1).ToString() + ". İlacın İsmini Giriniz"))
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim sayi As Integer = InputBox("Kaç Adet İlacı Listeye Aktarmak İstiyorsunuz ?")
        For i = 0 To sayi - 1
            Dim indeks As Integer = InputBox("Aktarmak İstediğiniz İlaçların Sıra Numaralarını Sırayla Yazınız")
            ListBox1.Items.Add(CheckedListBox1.Items(indeks - 1))
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim ilac As String
        Dim ayni As Boolean
        If Convert.ToInt32(ilac_sayisi) = CheckedListBox1.Items.Count Then
            MsgBox("Daha Fazla Giriş Yapamazsınız")
        Else
            Do While (Convert.ToInt32(ilac_sayisi) > CheckedListBox1.Items.Count)
                ayni = False
                ilac = InputBox("Eklemek İstediğiniz İlacın Adını Giriniz")
                For i = 0 To CheckedListBox1.Items.Count - 1
                    If ilac = CheckedListBox1.Items(i) Then
                        MsgBox("Aynı İlacı Tekrar Girdiniz")
                        ayni = True
                    End If
                Next
                If ayni = False Then
                    CheckedListBox1.Items.Add(ilac)
                End If
            Loop
            MsgBox("Daha Fazla Kayıt Giremezsiniz")
        End If
    End Sub
End Class
