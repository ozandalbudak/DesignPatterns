using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CompositeKontrol cKontrolRoot = new CompositeKontrol("Form1",
           "WinApplication 1", KontrolTip.Form);
            cKontrolRoot.Ekle(new LeafKontrol("TextBox1", "Adınızı Giriniz...",
           KontrolTip.TextBox));
            cKontrolRoot.Ekle(new LeafKontrol("TextBox2", "Soyadınız Giriniz...",
           KontrolTip.TextBox));
            cKontrolRoot.Ekle(new LeafKontrol("Button1", "Kontrol Et",
           KontrolTip.Button));
            CompositeKontrol cKontrol1 = new CompositeKontrol("Panel1", "Adres Bilgileri", KontrolTip.Panel); 
           
            cKontrol1.Ekle(new LeafKontrol("TextBox4", "Adres Satır 1",
           KontrolTip.TextBox));
            cKontrol1.Ekle(new LeafKontrol("TextBox5", "Adres Satır 2",
           KontrolTip.TextBox));
            cKontrolRoot.Ekle(cKontrol1);
            CompositeKontrol cKontrol2 = new CompositeKontrol("Panel2", "Telefon Bilgileri", KontrolTip.Panel); 
           cKontrol2.Ekle(new LeafKontrol("TextBox6", "Telefon 1",
KontrolTip.TextBox));
            cKontrol2.Ekle(new LeafKontrol("TextBox7", "Telefon 2",
           KontrolTip.TextBox));
            cKontrolRoot.Ekle(cKontrol2);
            cKontrolRoot.Ekle(new LeafKontrol("Button2", "Gönder",
           KontrolTip.Button));
            cKontrolRoot.Goster(1);
            Console.Read();
        }
    }
} 