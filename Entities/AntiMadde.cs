using System;
using KuantumKaosYonetimi.Base;
using KuantumKaosYonetimi.Interfaces;

namespace KuantumKaosYonetimi.Entities
{
    public class AntiMadde : KuantumNesnesi, IKritik
    {
        public AntiMadde(string id) : base(id, 60, 10) { }

        public override void AnalizEt()
        {
            Stabilite -= 25;
            Console.WriteLine("Evrenin dokusu titriyor...");
            CheckCollapse();
        }

        public void AcilDurumSogutmasi()
        {
            Stabilite += 50;
            if (Stabilite > 100) Stabilite = 100;
            Console.WriteLine($"{ID} soğutuldu. Yeni stabilite: {Stabilite}");
        }
    }
}
