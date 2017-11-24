namespace KockaSimple
{
    public class KockaData
    {
        public int PocetTydnu { get; set; }
        public int PocetKocek { get; set; }
        public int MnozstviMasaNaKocku { get; set; }

        public int VypoctiSpotrebuMasa()
        {
            return PocetTydnu * PocetKocek * MnozstviMasaNaKocku;
        }
    }
}
