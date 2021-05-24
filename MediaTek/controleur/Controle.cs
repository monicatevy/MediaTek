using MediaTek.vue;

namespace MediaTek.controleur
{
    /// <summary>
    /// Gère les intéractions entre le modèle et la vue
    /// </summary>
    public class Controle
    {
        /// <summary>
        /// Ouverture de la fenêtre
        /// </summary>
        public Controle()
        {
            (new Login(this)).ShowDialog();
        }
    }
}
