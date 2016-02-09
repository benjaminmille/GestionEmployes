using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaoGestionEmployes
{
    public interface IGestionEmployes
    {
        #region Utilisateur

        Boolean checkAuthentification(string Identifiant, string MotPasse);
        List<Utilisateur> findAllUtilisateurs();
        List<Utilisateur> findUsersByPrenom(string prenom);
        List<Utilisateur> findUsersByNom(string nom);
        List<Utilisateur> findUsersByRole(int role);
        List<Utilisateur> findUsersByDateDebut(string dateDebut);
        List<Utilisateur> findUsersByDateFin(string dateFin);
        List<Utilisateur> findUsersByStatus(bool status);
        object[] findUtilisateur(int IdUtilisateur);
        void createUtilisateur(Utilisateur utilisateur);
        void updateUtilisateur(Utilisateur utilisateur);
        void deleteUtilisateur(int IdUtilisateur);

        #endregion

        #region Adresse

        List<Adresse> findAllAdresses();
        List<Adresse> findAdressesByNumeroRue(string numeroRue);
        List<Adresse> findAdressesByNomRue(string nomRue);
        List<Adresse> findAdressesByCodePostal(string codePostal);
        List<Adresse> findAdressesByVille(int idVille);
        void createAdresse(Adresse adresse);
        void updateAdresse(Adresse adresse);
        void deleteAdresse(int IdUtilisateur);

        #endregion

        #region Societe

        List<Societe> findAllSocietes();
        List<Societe> findSocietesByNom(string nomSociete);
        List<Societe> findSocietesByNumeroSiret(string numeroSiret);
        List<Societe> findSocietesByUtilisateur(int idUtilisateur);
        void createSociete(Societe societe);
        void updateSociete(Societe societe);
        void deleteSociete(int IdUtilisateur);

        #endregion

        #region Role

        List<Role> findAllRoles();
        List<Role> findRolesByCode(string codeRole);
        List<Role> findRolesByDescription(string descriptionRole);
        void createRole(Role role);
        void updateRole(Role role);
        void deleteRole(int IdRole);

        #endregion

        #region Ville

        List<Ville> findAllVilles();
        List<Ville> findVillesByCode(string codeVille);
        List<Ville> findVillesByDescription(string descriptionVille);
        void createVille(Ville ville);
        void updateVille(Ville ville);
        void deleteVille(int IdVille);

        #endregion
    }
}
