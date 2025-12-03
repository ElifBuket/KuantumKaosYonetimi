using System;

namespace KuantumKaosYonetimi.Exceptions
{
    public class KuantumCokusuException : Exception
    {
        public KuantumCokusuException(string id)
            : base($"Nesne patladı: {id}")
        {
        }
    }
}
