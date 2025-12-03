using System;
using KuantumKaosYonetimi.Base;

namespace KuantumKaosYonetimi.Entities
{
    public class VeriPaketi : KuantumNesnesi
    {
        public VeriPaketi(string id) : base(id, 100, 1) { }

        public override void AnalizEt()
        {
            Stabilite -= 5;
            Console.WriteLine("Veri içeriği okundu.");
            CheckCollapse();
        }
    }
}
