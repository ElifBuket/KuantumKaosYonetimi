using System;
using System.Collections.Generic;
using KuantumKaosYonetimi.Base;
using KuantumKaosYonetimi.Entities;
using KuantumKaosYonetimi.Interfaces;
using KuantumKaosYonetimi.Exceptions;

namespace KuantumKaosYonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            List<KuantumNesnesi> envanter = new();
            Random rnd = new();
            while (true)
            {
                try
                {
                    Console.WriteLine("\nKUANTUM AMBARI KONTROL PANELİ");
                    Console.WriteLine("1. Yeni Nesne Ekle");
                    Console.WriteLine("2. Envanteri Listele");
                    Console.WriteLine("3. Nesneyi Analiz Et");
                    Console.WriteLine("4. Acil Durum Soğutması");
                    Console.WriteLine("5. Çıkış");
                    Console.Write("Seçiminiz: ");
                    string secim = Console.ReadLine();

                    switch (secim)
                    {
                        case "1":
                            string id = Guid.NewGuid().ToString().Substring(0, 8);
                            int r = rnd.Next(3);
                            KuantumNesnesi nesne = r switch
                            {
                                0 => new VeriPaketi(id),
                                1 => new KaranlikMadde(id),
                                _ => new AntiMadde(id)
                            };
                            envanter.Add(nesne);
                            Console.WriteLine($"{id} eklendi.");
                            break;

                        case "2":
                            if (envanter.Count == 0) Console.WriteLine("Envanter boş.");
                            else envanter.ForEach(n => Console.WriteLine(n.DurumBilgisi()));
                            break;

                        case "3":
                            Console.Write("Analiz ID: ");
                            string aID = Console.ReadLine();
                            var aNesne = envanter.Find(n => n.ID == aID);
                            if (aNesne == null) Console.WriteLine("ID bulunamadı.");
                            else aNesne.AnalizEt();
                            break;

                        case "4":
                            Console.Write("Soğut ID: ");
                            string sID = Console.ReadLine();
                            var sNesne = envanter.Find(n => n.ID == sID);
                            if (sNesne == null) { Console.WriteLine("ID bulunamadı."); break; }
                            if (sNesne is IKritik kritik) kritik.AcilDurumSogutmasi();
                            else Console.WriteLine("Bu nesne soğutulamaz!");
                            break;

                        case "5":
                            return;

                        default:
                            Console.WriteLine("Geçersiz seçim.");
                            break;
                    }
                }
                catch (KuantumCokusuException ex)
                {
                    Console.WriteLine("\nSİSTEM ÇÖKTÜ! TAHLİYE BAŞLATILIYOR...");
                    Console.WriteLine(ex.Message);
                    return;
                }
            }
        }
    }
}
