using MediaTek.dal;
using MediaTek.modele;
using MediaTek.vue;
using System.Collections.Generic;

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
            (new GestionPersonnel(this)).ShowDialog();
        }

        /// <summary>
        /// Récupère et retourne les infos du personnel provenant de la BDD
        /// </summary>
        /// <returns>liste des personnels</returns>
        public List<Personnel> GetLesPersonnels()
        {
            return AccesDonnees.GetLesPersonnels();
        }

        /// <summary>
        /// Récupère et retourne les infos des services provenant de la BDD
        /// </summary>
        /// <returns>liste des services</returns>
        public List<Service> GetLesServices()
        {
            return AccesDonnees.GetLesServices();
        }

        /// <summary>
        /// Demande d'ajout d'un personnel
        /// </summary>
        /// <param name="personnel"></param>
        public void AddPersonnel(Personnel personnel)
        {
            AccesDonnees.AddPersonnel(personnel);
        }

        /// <summary>
        /// Demande de suppression d'un personnel
        /// </summary>
        /// <param name="personnel"></param>
        public void DelPersonnel(int idpersonnel)
        {
            AccesDonnees.DelPersonnel(idpersonnel);
        }

        /// <summary>
        /// Demande de modification d'un personnel
        /// </summary>
        /// <param name="personnel"></param>
        public void UpdatePersonnel(Personnel personnel)
        {
            AccesDonnees.UpdatePersonnel(personnel);
        }

        /// <summary>
        /// Récupère et retourne les infos des absences provenant de la BDD
        /// </summary>
        /// <returns>liste des absences</returns>
        public List<Absence> GetLesAbsences(int idpersonnel)
        {
            return AccesDonnees.GetLesAbsences(idpersonnel);
        }

        /// <summary>
        /// Récupère et retourne les infos des motifs provenant de la BDD
        /// </summary>
        /// <returns>liste des motifs</returns>
        public List<Motif> GetLesMotifs()
        {
            return AccesDonnees.GetLesMotifs();
        }

        /// <summary>
        /// Demande d'ajout d'une absence
        /// </summary>
        /// <param name="personnel"></param>
        public void AddAbsence(Absence absence, int idpersonnel)
        {
            AccesDonnees.AddAbsence(absence, idpersonnel);
        }

        /// <summary>
        /// Demande de suppression d'une absence
        /// </summary>
        /// <param name="personnel"></param>
        public void DelAbsence(Absence absence, int idpersonnel)
        {
            AccesDonnees.DelAbsence(absence, idpersonnel);
        }
    }
}
