using System;
using KuantumKaosYonetimi.Base;
using KuantumKaosYonetimi.Interfaces;

namespace KuantumKaosYonetimi.Entities
{
    public class KaranlikMadde : KuantumNesnesi, IKritik
    {
        public KaranlikMadde(string id) : base(id, 80, 7) { }

        public override void AnalizEt()
        {
            Stabilite -= 15;
            Console.WriteLine("Karanlık madde analiz edildi.");
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
