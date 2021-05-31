namespace MediaTek.modele
{
    public class Motif
    {
        private int idmotif;
        private string libelle;

        public int Idmotif { get => idmotif; }
        public string Libelle { get => libelle; }

        /// <summary>
        /// Constructeur : valorise les propriétés
        /// </summary>
        /// <param name="idmotif"></param>
        /// <param name="libelle"></param>
        public Motif(int idmotif, string libelle)
        {
            this.idmotif = idmotif;
            this.libelle = libelle;
        }

        /// <summary>
        /// Définit l'information à afficher : libelle
        /// </summary>
        /// <returns>nom du motif</returns>
        public override string ToString()
        {
            return this.libelle;
        }
    }
}
