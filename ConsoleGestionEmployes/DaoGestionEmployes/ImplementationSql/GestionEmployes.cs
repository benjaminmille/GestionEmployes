using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace DaoGestionEmployes.ImplementationSql
{
    public class GestionEmployes : IGestionEmployes
    {
        string connectionString = ConfigurationManager.ConnectionStrings["connectionGestionEmployes"].ConnectionString;

        #region Utilisateur

        public Boolean checkAuthentification(string Identifiant, string MotPasse)
        {
            string methodName = "checkAuthentification";
            string IdUtilisateur = "";
            using (SqlConnection connexion = new SqlConnection(connectionString))
            {
                try
                {
                    connexion.Open();
                    string request = "SELECT IdUtilisateur " +
                                     "FROM Utilisateur " +
                                     "WHERE Identifiant = '" + Identifiant + "' " + 
                                     "AND MotPasse = '" + MotPasse + "' " +
                                     "AND IdRole = 1;";
                    SqlCommand sqlCommand = new SqlCommand(request, connexion);
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        IdUtilisateur = reader[0].ToString();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Exception : " + e.Message + ".", "Erreur lors de l'éxécution de la méthode " + methodName + ".");
                }
            }
            if (IdUtilisateur == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public List<Utilisateur> findAllUtilisateurs()
        {
            string methodName = "findAllUtilisateurs";
            List<Utilisateur> listeUtilisateurs = new List<Utilisateur>();
            using (SqlConnection connexion = new SqlConnection(connectionString))
            {
                try
                {
                    connexion.Open();
                    string request = "SELECT * FROM Utilisateur";
                    SqlCommand sqlCommand = new SqlCommand(request, connexion);
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        int IdUtilisateur = Convert.ToInt32(reader[0]);
                        int IdRole = Convert.ToInt32(reader[1]);
                        string Prenom = reader[2].ToString();
                        string Nom = reader[3].ToString();
                        string Identifiant = reader[4].ToString();
                        string MotPasse = reader[5].ToString();
                        DateTime DateDebut = Convert.ToDateTime(reader[6]);
                        DateTime DateFin = Convert.ToDateTime(reader[7]);
                        int IdSociete = Convert.ToInt32(reader[8]);
                        listeUtilisateurs.Add(new Utilisateur(IdUtilisateur, IdRole, Identifiant, MotPasse, DateDebut, DateFin, Prenom, Nom, IdSociete));
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Exception : " + e.Message + ".", "Erreur lors de l'éxécution de la méthode " + methodName + ".");
                }
            }
            return listeUtilisateurs;
        }

        public List<Utilisateur> findUsersByPrenom(string prenom)
        {
            string methodName = "findUsersByPrenom";
            List<Utilisateur> listeUtilisateurs = new List<Utilisateur>();
            using (SqlConnection connexion = new SqlConnection(connectionString))
            {
                try
                {
                    connexion.Open();
                    string request = "SELECT * " +
                                     "FROM Utilisateur " +
                                     "WHERE Prenom LIKE '%" + prenom + "%';";
                    SqlCommand sqlCommand = new SqlCommand(request, connexion);
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        int IdUtilisateur = Convert.ToInt32(reader[0]);
                        int IdRole = Convert.ToInt32(reader[1]);
                        string Prenom = reader[2].ToString();
                        string Nom = reader[3].ToString();
                        string Identifiant = reader[4].ToString();
                        string MotPasse = reader[5].ToString();
                        DateTime DateDebut = Convert.ToDateTime(reader[6]);
                        DateTime DateFin = Convert.ToDateTime(reader[7]);
                        int IdSociete = Convert.ToInt32(reader[8]);
                        listeUtilisateurs.Add(new Utilisateur(IdUtilisateur, IdRole, Identifiant, MotPasse, DateDebut, DateFin, Prenom, Nom, IdSociete));
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Exception : " + e.Message + ".", "Erreur lors de l'éxécution de la méthode " + methodName + ".");
                }
            }
            return listeUtilisateurs;
        }

        public List<Utilisateur> findUsersByNom(string nom)
        {
            string methodName = "findUsersByNom";
            List<Utilisateur> listeUtilisateurs = new List<Utilisateur>();
            using (SqlConnection connexion = new SqlConnection(connectionString))
            {
                try
                {
                    connexion.Open();
                    string request = "SELECT * " +
                                     "FROM Utilisateur " +
                                     "WHERE Nom LIKE '%" + nom + "%';";
                    SqlCommand sqlCommand = new SqlCommand(request, connexion);
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        int IdUtilisateur = Convert.ToInt32(reader[0]);
                        int IdRole = Convert.ToInt32(reader[1]);
                        string Prenom = reader[2].ToString();
                        string Nom = reader[3].ToString();
                        string Identifiant = reader[4].ToString();
                        string MotPasse = reader[5].ToString();
                        DateTime DateDebut = Convert.ToDateTime(reader[6]);
                        DateTime DateFin = Convert.ToDateTime(reader[7]);
                        int IdSociete = Convert.ToInt32(reader[8]);
                        listeUtilisateurs.Add(new Utilisateur(IdUtilisateur, IdRole, Identifiant, MotPasse, DateDebut, DateFin, Prenom, Nom, IdSociete));
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Exception : " + e.Message + ".", "Erreur lors de l'éxécution de la méthode " + methodName + ".");
                }
            }
            return listeUtilisateurs;
        }

        public List<Utilisateur> findUsersByRole(int role)
        {
            string methodName = "findUsersByRole";
            List<Utilisateur> listeUtilisateurs = new List<Utilisateur>();
            using (SqlConnection connexion = new SqlConnection(connectionString))
            {
                try
                {
                    connexion.Open();
                    string request = "SELECT * " +
                                     "FROM Utilisateur " +
                                     "WHERE IdRole = " + role + ";";
                    SqlCommand sqlCommand = new SqlCommand(request, connexion);
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        int IdUtilisateur = Convert.ToInt32(reader[0]);
                        int IdRole = Convert.ToInt32(reader[1]);
                        string Prenom = reader[2].ToString();
                        string Nom = reader[3].ToString();
                        string Identifiant = reader[4].ToString();
                        string MotPasse = reader[5].ToString();
                        DateTime DateDebut = Convert.ToDateTime(reader[6]);
                        DateTime DateFin = Convert.ToDateTime(reader[7]);
                        int IdSociete = Convert.ToInt32(reader[8]);
                        listeUtilisateurs.Add(new Utilisateur(IdUtilisateur, IdRole, Identifiant, MotPasse, DateDebut, DateFin, Prenom, Nom, IdSociete));
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Exception : " + e.Message + ".", "Erreur lors de l'éxécution de la méthode " + methodName + ".");
                }
            }
            return listeUtilisateurs;
        }

        public List<Utilisateur> findUsersByDateDebut(string dateDebut)
        {
            string methodName = "findUsersByDateDebut";
            List<Utilisateur> listeUtilisateurs = new List<Utilisateur>();
            using (SqlConnection connexion = new SqlConnection(connectionString))
            {
                try
                {
                    connexion.Open();
                    string request = "SELECT * " +
                                     "FROM Utilisateur " +
                                     "WHERE DateDebut LIKE '%" + dateDebut + "%';";
                    SqlCommand sqlCommand = new SqlCommand(request, connexion);
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        int IdUtilisateur = Convert.ToInt32(reader[0]);
                        int IdRole = Convert.ToInt32(reader[1]);
                        string Prenom = reader[2].ToString();
                        string Nom = reader[3].ToString();
                        string Identifiant = reader[4].ToString();
                        string MotPasse = reader[5].ToString();
                        DateTime DateDebut = Convert.ToDateTime(reader[6]);
                        DateTime DateFin = Convert.ToDateTime(reader[7]);
                        int IdSociete = Convert.ToInt32(reader[8]);
                        listeUtilisateurs.Add(new Utilisateur(IdUtilisateur, IdRole, Identifiant, MotPasse, DateDebut, DateFin, Prenom, Nom, IdSociete));
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Exception : " + e.Message + ".", "Erreur lors de l'éxécution de la méthode " + methodName + ".");
                }
            }
            return listeUtilisateurs;
        }

        public List<Utilisateur> findUsersByDateFin(string dateFin)
        {
            string methodName = "findUsersByDateFin";
            List<Utilisateur> listeUtilisateurs = new List<Utilisateur>();
            using (SqlConnection connexion = new SqlConnection(connectionString))
            {
                try
                {
                    connexion.Open();
                    string request = "SELECT * " +
                                     "FROM Utilisateur " +
                                     "WHERE DateFin LIKE '%" + dateFin + "%';";
                    SqlCommand sqlCommand = new SqlCommand(request, connexion);
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        int IdUtilisateur = Convert.ToInt32(reader[0]);
                        int IdRole = Convert.ToInt32(reader[1]);
                        string Prenom = reader[2].ToString();
                        string Nom = reader[3].ToString();
                        string Identifiant = reader[4].ToString();
                        string MotPasse = reader[5].ToString();
                        DateTime DateDebut = Convert.ToDateTime(reader[6]);
                        DateTime DateFin = Convert.ToDateTime(reader[7]);
                        int IdSociete = Convert.ToInt32(reader[8]);
                        listeUtilisateurs.Add(new Utilisateur(IdUtilisateur, IdRole, Identifiant, MotPasse, DateDebut, DateFin, Prenom, Nom, IdSociete));
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Exception : " + e.Message + ".", "Erreur lors de l'éxécution de la méthode " + methodName + ".");
                }
            }
            return listeUtilisateurs;
        }

        public List<Utilisateur> findUsersByStatus(bool status)
        {
            string methodName = "findUsersByStatus";
            List<Utilisateur> listeUtilisateurs = new List<Utilisateur>();
            using (SqlConnection connexion = new SqlConnection(connectionString))
            {
                try
                {
                    connexion.Open();
                    string request = "SELECT IdUtilisateur, IdRole, Prenom, Nom, Identifiant, MotPasse, DateDebut, DateFin, IdSociete " +
                                     "FROM Utilisateur " +
                                     "WHERE Status = '" + status + "';";
                    SqlCommand sqlCommand = new SqlCommand(request, connexion);
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        int IdUtilisateur = Convert.ToInt32(reader[0]);
                        int IdRole = Convert.ToInt32(reader[1]);
                        string Prenom = reader[2].ToString();
                        string Nom = reader[3].ToString();
                        string Identifiant = reader[4].ToString();
                        string MotPasse = reader[5].ToString();
                        DateTime DateDebut = Convert.ToDateTime(reader[6]);
                        DateTime DateFin = Convert.ToDateTime(reader[7]);
                        int IdSociete = Convert.ToInt32(reader[8]);
                        listeUtilisateurs.Add(new Utilisateur(IdUtilisateur, IdRole, Identifiant, MotPasse, DateDebut, DateFin, Prenom, Nom, IdSociete));
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Exception : " + e.Message + ".", "Erreur lors de l'éxécution de la méthode " + methodName + ".");
                }
            }
            return listeUtilisateurs;
        }

        public object[] findUtilisateur(int IdUtilisateur)
        {
            string methodName = "findUtilisateur";
            object[] tabInfoUser = new object[5];
            tabInfoUser[0] = new Utilisateur();
            tabInfoUser[1] = new Adresse();
            tabInfoUser[2] = new Societe();
            tabInfoUser[3] = new Role();
            tabInfoUser[4] = new Ville();
            using (SqlConnection connexion = new SqlConnection(connectionString))
            {
                try
                {
                    connexion.Open();
                    string request = "SELECT Role.IdRole, Prenom, Nom, Identifiant, MotPasse, DateDebut, DateFin, NumeroRue, NomRue, " +
                                        "CodePostal, Ville.IdVille, NomSociete, DescriptionSociete, NumeroSiret, CodeRole, CodeVille, Societe.IdSociete " +
                                     "FROM Utilisateur, Societe, Adresse, Role, Ville " +
                                     "WHERE Utilisateur.IdSociete = Societe.IdSociete " +
                                     "AND Utilisateur.IdUtilisateur = Adresse.IdUtilisateur " +
                                     "AND Utilisateur.IdRole = Role.IdRole " +
                                     "AND Adresse.IdVille = Ville.IdVille " +
                                     "AND Utilisateur.IdUtilisateur = " + IdUtilisateur + ";";
                    SqlCommand sqlCommand = new SqlCommand(request, connexion);
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        int IdRole = Convert.ToInt32(reader[0]);
                        string Prenom = reader[1].ToString();
                        string Nom = reader[2].ToString();
                        string Identifiant = reader[3].ToString();
                        string MotPasse = reader[4].ToString();
                        DateTime DateDebut = Convert.ToDateTime(reader[5]);
                        DateTime DateFin = Convert.ToDateTime(reader[6]);
                        string NumeroRue = reader[7].ToString();
                        string NomRue = reader[8].ToString();
                        string CodePostal = reader[9].ToString();
                        int IdVille = Convert.ToInt32(reader[10]);
                        string NomSociete = reader[11].ToString();
                        string DescriptionSociete = reader[12].ToString();
                        string NumeroSiret = reader[13].ToString();
                        string CodeRole = reader[14].ToString();
                        string CodeVille = reader[15].ToString();
                        int IdSociete = Convert.ToInt32(reader[16]);

                        tabInfoUser[0] = new Utilisateur(IdUtilisateur, IdRole, Identifiant, MotPasse, DateDebut, DateFin, Prenom, Nom, IdSociete);
                        tabInfoUser[1] = new Adresse(1, NumeroRue, NomRue, CodePostal, IdVille, IdUtilisateur);
                        tabInfoUser[2] = new Societe(IdSociete, NomSociete, DescriptionSociete, NumeroSiret);
                        tabInfoUser[3] = new Role(IdRole, CodeRole, "");
                        tabInfoUser[4] = new Ville(IdVille, CodeVille, "");
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Exception : " + e.Message + ".", "Erreur lors de l'éxécution de la méthode " + methodName + ".");
                }
            }
            return tabInfoUser;
        }

        public void createUtilisateur(Utilisateur utilisateur)
        {
            string methodName = "createUtilisateur";
            using (SqlConnection connexion = new SqlConnection(connectionString))
            {
                try
                {
                    connexion.Open();
                    string request = "INSERT INTO Utilisateur(IdRole, Identifiant, MotPasse, DateDebut, DateFin, Prenom, Nom, IdSociete) " +
                                     "VALUES(" + utilisateur.IdRole + ", '" + utilisateur.Identifiant + "', '" + utilisateur.MotPasse + "', '" +
                                         utilisateur.DateDebut + "', '" + utilisateur.DateFin + "', '" + utilisateur.Prenom + "', '" +
                                         utilisateur.Nom + "', " + utilisateur.IdSociete + ");";
                    SqlCommand sqlCommand = new SqlCommand(request, connexion);
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Exception : " + e.Message + ".", "Erreur lors de l'éxécution de la méthode " + methodName + ".");
                }
            }
        }

        public void updateUtilisateur(Utilisateur utilisateur)
        {
            string methodName = "updateUtilisateur";
            using (SqlConnection connexion = new SqlConnection(connectionString))
            {
                try
                {
                    connexion.Open();
                    string request = "UPDATE Utilisateur " +
                                     "SET IdRole = " + utilisateur.IdRole + ", Identifiant = '" + utilisateur.Identifiant + "', " +
                                         "MotPasse = '" + utilisateur.MotPasse + "', DateDebut = '" + utilisateur.DateDebut + "', " +
                                         "DateFin = '" + utilisateur.DateFin + "', Prenom = '" + utilisateur.Prenom + "', " +
                                         "Nom = '" + utilisateur.Nom + "', IdSociete = '" + utilisateur.IdSociete + "' " +
                                     "WHERE IdUtilisateur = " + utilisateur.IdUtilisateur + ";";
                    SqlCommand sqlCommand = new SqlCommand(request, connexion);
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Exception : " + e.Message + ".", "Erreur lors de l'éxécution de la méthode " + methodName + ".");
                }
            }
        }

        public void deleteUtilisateur(int IdUtilisateur)
        {
            string methodName = "deleteUtilisateur";
            using (SqlConnection connexion = new SqlConnection(connectionString))
            {
                try
                {
                    connexion.Open();
                    string request = "DELETE FROM Utilisateur " + 
                                     "WHERE IdUtilisateur = " + IdUtilisateur + ";";
                    SqlCommand sqlCommand = new SqlCommand(request, connexion);
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Exception : " + e.Message + ".", "Erreur lors de l'éxécution de la méthode " + methodName + ".");
                }
            }
        }

        #endregion

        #region Adresse

        public List<Adresse> findAllAdresses()
        {
            string methodName = "findAllAdresses";
            List<Adresse> listeAdresses = new List<Adresse>();
            using (SqlConnection connexion = new SqlConnection(connectionString))
            {
                try
                {
                    connexion.Open();
                    string request = "SELECT * FROM Adresse;";
                    SqlCommand sqlCommand = new SqlCommand(request, connexion);
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        int IdAdresse = Convert.ToInt32(reader[0]);
                        string NumeroRue = reader[1].ToString();
                        string NomRue = reader[2].ToString();
                        string CodePostal = reader[3].ToString();
                        int IdVille = Convert.ToInt32(reader[4]);
                        int IdUtilisateur = Convert.ToInt32(reader[5]);
                        listeAdresses.Add(new Adresse(IdAdresse, NumeroRue, NomRue, CodePostal, IdVille, IdUtilisateur));
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Exception : " + e.Message + ".", "Erreur lors de l'éxécution de la méthode " + methodName + ".");
                }
            }
            return listeAdresses;
        }

        public List<Adresse> findAdressesByNumeroRue(string numeroRue)
        {
            string methodName = "findAdressesByNumeroRue";
            List<Adresse> listeAdresses = new List<Adresse>();
            using (SqlConnection connexion = new SqlConnection(connectionString))
            {
                try
                {
                    connexion.Open();
                    string request = "SELECT * " +
                                     "FROM Adresse " +
                                     "WHERE NumeroRue LIKE '%" + numeroRue + "%';";
                    SqlCommand sqlCommand = new SqlCommand(request, connexion);
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        int IdAdresse = Convert.ToInt32(reader[0]);
                        string NumeroRue = reader[1].ToString();
                        string NomRue = reader[2].ToString();
                        string CodePostal = reader[3].ToString();
                        int IdVille = Convert.ToInt32(reader[4]);
                        int IdUtilisateur = Convert.ToInt32(reader[5]);
                        listeAdresses.Add(new Adresse(IdAdresse, NumeroRue, NomRue, CodePostal, IdVille, IdUtilisateur));
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Exception : " + e.Message + ".", "Erreur lors de l'éxécution de la méthode " + methodName + ".");
                }
            }
            return listeAdresses;
        }

        public List<Adresse> findAdressesByNomRue(string nomRue)
        {
            string methodName = "findAdressesByNumeroRue";
            List<Adresse> listeAdresses = new List<Adresse>();
            using (SqlConnection connexion = new SqlConnection(connectionString))
            {
                try
                {
                    connexion.Open();
                    string request = "SELECT * " +
                                     "FROM Adresse " +
                                     "WHERE NomRue LIKE '%" + nomRue + "%';";
                    SqlCommand sqlCommand = new SqlCommand(request, connexion);
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        int IdAdresse = Convert.ToInt32(reader[0]);
                        string NumeroRue = reader[1].ToString();
                        string NomRue = reader[2].ToString();
                        string CodePostal = reader[3].ToString();
                        int IdVille = Convert.ToInt32(reader[4]);
                        int IdUtilisateur = Convert.ToInt32(reader[5]);
                        listeAdresses.Add(new Adresse(IdAdresse, NumeroRue, NomRue, CodePostal, IdVille, IdUtilisateur));
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Exception : " + e.Message + ".", "Erreur lors de l'éxécution de la méthode " + methodName + ".");
                }
            }
            return listeAdresses;
        }

        public List<Adresse> findAdressesByCodePostal(string codePostal)
        {
            string methodName = "findAdressesByCodePostal";
            List<Adresse> listeAdresses = new List<Adresse>();
            using (SqlConnection connexion = new SqlConnection(connectionString))
            {
                try
                {
                    connexion.Open();
                    string request = "SELECT * " +
                                     "FROM Adresse " +
                                     "WHERE CodePostal LIKE '%" + codePostal + "%';";
                    SqlCommand sqlCommand = new SqlCommand(request, connexion);
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        int IdAdresse = Convert.ToInt32(reader[0]);
                        string NumeroRue = reader[1].ToString();
                        string NomRue = reader[2].ToString();
                        string CodePostal = reader[3].ToString();
                        int IdVille = Convert.ToInt32(reader[4]);
                        int IdUtilisateur = Convert.ToInt32(reader[5]);
                        listeAdresses.Add(new Adresse(IdAdresse, NumeroRue, NomRue, CodePostal, IdVille, IdUtilisateur));
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Exception : " + e.Message + ".", "Erreur lors de l'éxécution de la méthode " + methodName + ".");
                }
            }
            return listeAdresses;
        }

        public List<Adresse> findAdressesByVille(int idVille)
        {
            string methodName = "findAdressesByVille";
            List<Adresse> listeAdresses = new List<Adresse>();
            using (SqlConnection connexion = new SqlConnection(connectionString))
            {
                try
                {
                    connexion.Open();
                    string request = "SELECT * " +
                                     "FROM Adresse " +
                                     "WHERE IdVille = " + idVille + ";";
                    SqlCommand sqlCommand = new SqlCommand(request, connexion);
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        int IdAdresse = Convert.ToInt32(reader[0]);
                        string NumeroRue = reader[1].ToString();
                        string NomRue = reader[2].ToString();
                        string CodePostal = reader[3].ToString();
                        int IdVille = Convert.ToInt32(reader[4]);
                        int IdUtilisateur = Convert.ToInt32(reader[5]);
                        listeAdresses.Add(new Adresse(IdAdresse, NumeroRue, NomRue, CodePostal, IdVille, IdUtilisateur));
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Exception : " + e.Message + ".", "Erreur lors de l'éxécution de la méthode " + methodName + ".");
                }
            }
            return listeAdresses;
        }

        public void createAdresse(Adresse adresse)
        {
            string methodName = "createAdresse";
            using (SqlConnection connexion = new SqlConnection(connectionString))
            {
                try
                {
                    connexion.Open();
                    string request = "INSERT INTO Adresse(NumeroRue, NomRue, CodePostal, IdVille, IdUtilisateur) " +
                                     "VALUES('" + adresse.NumeroRue + "', '" + adresse.NomRue + "', '" + adresse.CodePostal + "', " +
                                          adresse.IdVille + ", (SELECT MAX(IdUtilisateur) FROM Utilisateur));";
                    SqlCommand sqlCommand = new SqlCommand(request, connexion);
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Exception : " + e.Message + ".", "Erreur lors de l'éxécution de la méthode " + methodName + ".");
                }
            }
        }

        public void updateAdresse(Adresse adresse)
        {
            string methodName = "updateAdresse";
            using (SqlConnection connexion = new SqlConnection(connectionString))
            {
                try
                {
                    connexion.Open();
                    string request = "UPDATE Adresse "
                                   + "SET NumeroRue = '" + adresse.NumeroRue + "', NomRue = '" + adresse.NomRue + "', CodePostal = '" + adresse.CodePostal + "', "
                                        + "IdVille = " + adresse.IdVille + " "
                                   + "WHERE IdUtilisateur = " + adresse.IdUtilisateur + ";";
                    SqlCommand sqlCommand = new SqlCommand(request, connexion);
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Exception : " + e.Message + ".", "Erreur lors de l'éxécution de la méthode " + methodName + ".");
                }
            }
        }

        public void deleteAdresse(int IdUtilisateur)
        {
            string methodName = "deleteAdresse";
            using (SqlConnection connexion = new SqlConnection(connectionString))
            {
                try
                {
                    connexion.Open();
                    string request = "DELETE FROM Adresse " + 
                                     "WHERE IdUtilisateur = " + IdUtilisateur + ";";
                    SqlCommand sqlCommand = new SqlCommand(request, connexion);
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Exception : " + e.Message + ".", "Erreur lors de l'éxécution de la méthode " + methodName + ".");
                }
            }
        }

        #endregion

        #region Societes

        public List<Societe> findAllSocietes()
        {
            string methodName = "findAllSocietes";
            List<Societe> listeSocietes = new List<Societe>();
            using (SqlConnection connexion = new SqlConnection(connectionString))
            {
                try
                {
                    connexion.Open();
                    string request = "SELECT * FROM Societe;";
                    SqlCommand sqlCommand = new SqlCommand(request, connexion);
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        int IdSociete = Convert.ToInt32(reader[0]);
                        string NomSociete = reader[1].ToString();
                        string DescriptionSociete = reader[2].ToString();
                        string NumeroSiret = reader[3].ToString();
                        listeSocietes.Add(new Societe(IdSociete, NomSociete, DescriptionSociete, NumeroSiret));
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Exception : " + e.Message + ".", "Erreur lors de l'éxécution de la méthode " + methodName + ".");
                }
            }
            return listeSocietes;
        }

        public List<Societe> findSocietesByNom(string nomSociete)
        {
            string methodName = "findSocietesByNom";
            List<Societe> listeSocietes = new List<Societe>();
            using (SqlConnection connexion = new SqlConnection(connectionString))
            {
                try
                {
                    connexion.Open();
                    string request = "SELECT * " + 
                                     "FROM Societe " + 
                                     "WHERE NomSociete LIKE '%" + nomSociete + "%';";
                    SqlCommand sqlCommand = new SqlCommand(request, connexion);
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        int IdSociete = Convert.ToInt32(reader[0]);
                        string NomSociete = reader[1].ToString();
                        string DescriptionSociete = reader[2].ToString();
                        string NumeroSiret = reader[3].ToString();
                        listeSocietes.Add(new Societe(IdSociete, NomSociete, DescriptionSociete, NumeroSiret));
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Exception : " + e.Message + ".", "Erreur lors de l'éxécution de la méthode " + methodName + ".");
                }
            }
            return listeSocietes;
        }

        public List<Societe> findSocietesByNumeroSiret(string numeroSiret)
        {
            string methodName = "findSocietesByNumeroSiret";
            List<Societe> listeSocietes = new List<Societe>();
            using (SqlConnection connexion = new SqlConnection(connectionString))
            {
                try
                {
                    connexion.Open();
                    string request = "SELECT * " +
                                     "FROM Societe " +
                                     "WHERE NumeroSiret LIKE '" + numeroSiret + "%';";
                    SqlCommand sqlCommand = new SqlCommand(request, connexion);
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        int IdSociete = Convert.ToInt32(reader[0]);
                        string NomSociete = reader[1].ToString();
                        string DescriptionSociete = reader[2].ToString();
                        string NumeroSiret = reader[3].ToString();
                        listeSocietes.Add(new Societe(IdSociete, NomSociete, DescriptionSociete, NumeroSiret));
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Exception : " + e.Message + ".", "Erreur lors de l'éxécution de la méthode " + methodName + ".");
                }
            }
            return listeSocietes;
        }

        public List<Societe> findSocietesByUtilisateur(int idUtilisateur)
        {
            string methodName = "findSocietesByUtilisateur";
            List<Societe> listeSocietes = new List<Societe>();
            using (SqlConnection connexion = new SqlConnection(connectionString))
            {
                try
                {
                    connexion.Open();
                    string request = "SELECT Societe.IdSociete, NomSociete, DescriptionSociete, NumeroSiret " + 
                                     "FROM Societe, Utilisateur " + 
                                     "WHERE Utilisateur.IdSociete = Societe.IdSociete " +
                                     "AND Utilisateur.IdUtilisateur = " + idUtilisateur + ";";
                    SqlCommand sqlCommand = new SqlCommand(request, connexion);
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        int IdSociete = Convert.ToInt32(reader[0]);
                        string NomSociete = reader[1].ToString();
                        string DescriptionSociete = reader[2].ToString();
                        string NumeroSiret = reader[3].ToString();
                        listeSocietes.Add(new Societe(IdSociete, NomSociete, DescriptionSociete, NumeroSiret));
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Exception : " + e.Message + ".", "Erreur lors de l'éxécution de la méthode " + methodName + ".");
                }
            }
            return listeSocietes;
        }

        public void createSociete(Societe societe)
        {
            string methodName = "createSociete";
            using (SqlConnection connexion = new SqlConnection(connectionString))
            {
                try
                {
                    connexion.Open();
                    string request = "INSERT INTO Societe(NomSociete, DescriptionSociete, NumeroSiret) "
                                   + "VALUES('" + societe.NomSociete + "', '" + societe.DescriptionSociete + "', '" + societe.NumeroSiret + "');";
                    SqlCommand sqlCommand = new SqlCommand(request, connexion);
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Exception : " + e.Message + ".", "Erreur lors de l'éxécution de la méthode " + methodName + ".");
                }
            }
        }

        public void updateSociete(Societe societe)
        {
            string methodName = "updateSociete";
            using (SqlConnection connexion = new SqlConnection(connectionString))
            {
                try
                {
                    connexion.Open();
                    string request = "UPDATE Societe "
                                   + "SET NomSociete = '" + societe.NomSociete + "', DescriptionSociete = '" + societe.DescriptionSociete + "', "
                                        + "NumeroSiret = '" + societe.NumeroSiret + "' "
                                   + "WHERE IdSociete = " + societe.IdSociete + ";";
                    SqlCommand sqlCommand = new SqlCommand(request, connexion);
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Exception : " + e.Message + ".", "Erreur lors de l'éxécution de la méthode " + methodName + ".");
                }
            }
        }

        public void deleteSociete(int IdSociete)
        {
            string methodName = "deleteSociete";
            using (SqlConnection connexion = new SqlConnection(connectionString))
            {
                try
                {
                    connexion.Open();
                    string request = "DELETE FROM Societe " +
                                     "WHERE IdSociete = " + IdSociete + ";";
                    SqlCommand sqlCommand = new SqlCommand(request, connexion);
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Exception : " + e.Message + ".", "Erreur lors de l'éxécution de la méthode " + methodName + ".");
                }
            }
        }

        #endregion

        #region Role

        public List<Role> findAllRoles()
        {
            string methodName = "findAllRoles";
            List<Role> listeRoles = new List<Role>();
            using (SqlConnection connexion = new SqlConnection(connectionString))
            {
                try
                {
                    connexion.Open();
                    string request = "SELECT * FROM Role";
                    SqlCommand sqlCommand = new SqlCommand(request, connexion);
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        int IdRole = Convert.ToInt32(reader[0]);
                        string CodeRole = reader[1].ToString();
                        string DescriptionRole = reader[2].ToString();
                        listeRoles.Add(new Role(IdRole, CodeRole, DescriptionRole));
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Exception : " + e.Message + ".", "Erreur lors de l'éxécution de la méthode " + methodName + ".");
                }
            }
            return listeRoles;
        }

        public List<Role> findRolesByCode(string codeRole)
        {
            string methodName = "findRolesByCodeRole";
            List<Role> listeRoles = new List<Role>();
            using (SqlConnection connexion = new SqlConnection(connectionString))
            {
                try
                {
                    connexion.Open();
                    string request = "SELECT * FROM Role " + 
                                     "WHERE CodeRole LIKE '%" + codeRole + "%';";
                    SqlCommand sqlCommand = new SqlCommand(request, connexion);
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        int IdRole = Convert.ToInt32(reader[0]);
                        string CodeRole = reader[1].ToString();
                        string DescriptionRole = reader[2].ToString();
                        listeRoles.Add(new Role(IdRole, CodeRole, DescriptionRole));
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Exception : " + e.Message + ".", "Erreur lors de l'éxécution de la méthode " + methodName + ".");
                }
            }
            return listeRoles;
        }

        public List<Role> findRolesByDescription(string descriptionRole)
        {
            string methodName = "findRolesByDescriptionRole";
            List<Role> listeRoles = new List<Role>();
            using (SqlConnection connexion = new SqlConnection(connectionString))
            {
                try
                {
                    connexion.Open();
                    string request = "SELECT * FROM Role " + 
                                     "WHERE DescriptionRole LIKE '%" + descriptionRole + "%';";
                    SqlCommand sqlCommand = new SqlCommand(request, connexion);
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        int IdRole = Convert.ToInt32(reader[0]);
                        string CodeRole = reader[1].ToString();
                        string DescriptionRole = reader[2].ToString();
                        listeRoles.Add(new Role(IdRole, CodeRole, DescriptionRole));
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Exception : " + e.Message + ".", "Erreur lors de l'éxécution de la méthode " + methodName + ".");
                }
            }
            return listeRoles;
        }

        public void createRole(Role role)
        {
            string methodName = "createRole";
            using (SqlConnection connexion = new SqlConnection(connectionString))
            {
                try
                {
                    connexion.Open();
                    string request = "INSERT INTO Role(CodeRole, DescriptionRole) " +
                                     "VALUES('" + role.CodeRole + "', '" + role.DescriptionRole + "');";
                    SqlCommand sqlCommand = new SqlCommand(request, connexion);
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Exception : " + e.Message + ".", "Erreur lors de l'éxécution de la méthode " + methodName + ".");
                }
            }
        }

        public void updateRole(Role role)
        {
            string methodName = "updateRole";
            using (SqlConnection connexion = new SqlConnection(connectionString))
            {
                try
                {
                    connexion.Open();
                    string request = "UPDATE Role "
                                   + "SET CodeRole = '" + role.CodeRole + "', "
                                       + "DescriptionRole = '" + role.DescriptionRole + "' "
                                   + "WHERE IdRole = " + role.IdRole + ";";
                    SqlCommand sqlCommand = new SqlCommand(request, connexion);
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Exception : " + e.Message + ".", "Erreur lors de l'éxécution de la méthode " + methodName + ".");
                }
            }
        }

        public void deleteRole(int IdRole)
        {
            string methodName = "deleteRole";
            using (SqlConnection connexion = new SqlConnection(connectionString))
            {
                try
                {
                    connexion.Open();
                    string request = "DELETE FROM Role " + 
                                     "WHERE IdRole = " + IdRole + ";";
                    SqlCommand sqlCommand = new SqlCommand(request, connexion);
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Exception : " + e.Message + ".", "Erreur lors de l'éxécution de la méthode " + methodName + ".");
                }
            }
        }

        #endregion

        #region Ville

        public List<Ville> findAllVilles()
        {
            string methodName = "findAllVilles";
            List<Ville> listeVilles = new List<Ville>();
            using (SqlConnection connexion = new SqlConnection(connectionString))
            {
                try
                {
                    connexion.Open();
                    string request = "SELECT * FROM Ville";
                    SqlCommand sqlCommand = new SqlCommand(request, connexion);
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        int IdVille = Convert.ToInt32(reader[0]);
                        string CodeVille = reader[1].ToString();
                        string DescriptionVille = reader[2].ToString();
                        listeVilles.Add(new Ville(IdVille, CodeVille, DescriptionVille));
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Exception : " + e.Message + ".", "Erreur lors de l'éxécution de la méthode " + methodName + ".");
                }
            }
            return listeVilles;
        }

        public List<Ville> findVillesByCode(string codeVille)
        {
            string methodName = "findVillesByCode";
            List<Ville> listeVilles = new List<Ville>();
            using (SqlConnection connexion = new SqlConnection(connectionString))
            {
                try
                {
                    connexion.Open();
                    string request = "SELECT * FROM Ville " + 
                                     "WHERE CodeVille LIKE '%" + codeVille + "%';";
                    SqlCommand sqlCommand = new SqlCommand(request, connexion);
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        int IdVille = Convert.ToInt32(reader[0]);
                        string CodeVille = reader[1].ToString();
                        string DescriptionVille = reader[2].ToString();
                        listeVilles.Add(new Ville(IdVille, CodeVille, DescriptionVille));
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Exception : " + e.Message + ".", "Erreur lors de l'éxécution de la méthode " + methodName + ".");
                }
            }
            return listeVilles;
        }

        public List<Ville> findVillesByDescription(string descriptionVille)
        {
            string methodName = "findVillesByDescription";
            List<Ville> listeVilles = new List<Ville>();
            using (SqlConnection connexion = new SqlConnection(connectionString))
            {
                try
                {
                    connexion.Open();
                    string request = "SELECT * " + 
                                     "FROM Ville " + 
                                     "WHERE DescriptionVille LIKE '%" + descriptionVille + "%';";
                    SqlCommand sqlCommand = new SqlCommand(request, connexion);
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        int IdVille = Convert.ToInt32(reader[0]);
                        string CodeVille = reader[1].ToString();
                        string DescriptionVille = reader[2].ToString();
                        listeVilles.Add(new Ville(IdVille, CodeVille, DescriptionVille));
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Exception : " + e.Message + ".", "Erreur lors de l'éxécution de la méthode " + methodName + ".");
                }
            }
            return listeVilles;
        }

        public void createVille(Ville ville)
        {
            string methodName = "createVille";
            using (SqlConnection connexion = new SqlConnection(connectionString))
            {
                try
                {
                    connexion.Open();
                    string request = "INSERT INTO Ville(CodeVille, DescriptionVille) "
                                   + "VALUES('" + ville.CodeVille + "', '" + ville.DescriptionVille + "');";
                    SqlCommand sqlCommand = new SqlCommand(request, connexion);
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Exception : " + e.Message + ".", "Erreur lors de l'éxécution de la méthode " + methodName + ".");
                }
            }
        }

        public void updateVille(Ville ville)
        {
            string methodName = "updateVille";
            using (SqlConnection connexion = new SqlConnection(connectionString))
            {
                try
                {
                    connexion.Open();
                    string request = "UPDATE Ville "
                                   + "SET CodeVille = '" + ville.CodeVille + "', "
                                       + "DescriptionVille = '" + ville.DescriptionVille + "' "
                                   + "WHERE IdVille = " + ville.IdVille + ";";
                    SqlCommand sqlCommand = new SqlCommand(request, connexion);
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Exception : " + e.Message + ".", "Erreur lors de l'éxécution de la méthode " + methodName + ".");
                }
            }
        }

        public void deleteVille(int IdVille)
        {
            string methodName = "deleteVille";
            using (SqlConnection connexion = new SqlConnection(connectionString))
            {
                try
                {
                    connexion.Open();
                    string request = "DELETE FROM Ville " + 
                                     "WHERE IdVille = " + IdVille + ";";
                    SqlCommand sqlCommand = new SqlCommand(request, connexion);
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Exception : " + e.Message + ".", "Erreur lors de l'éxécution de la méthode " + methodName + ".");
                }
            }
        }

        #endregion
    }
}