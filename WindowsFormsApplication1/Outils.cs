using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Outils
    {
        /// <summary>
        /// retourne true si la string s est composée de lettres et des symboles -(tiret), (espace),_(underscore)
        /// retourne false dans le cas contraire
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool isMadeOfLetters(string s)
        {
            char c;
            bool code = true;
            if (s.Length > 0)   //si il n'y a pas de chaine, on retourne false
            {
                for (int i = 0; i < s.Length; i++)
                {
                    c = s[i];
                    if (!(char.IsLetter(c)) && !(c=='-') && !(c==' ') && !(c=='_'))
                    {
                        code = false;
                    }
                }
            }
            else
            {
                code = false;
            }
            return code;
        }
        /// <summary>
        /// retourne true si la string s est composée de lettres, de chiffres et des symboles -(tiret), (espace),_(underscore)
        /// retourne false sinon
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool isMadeOfLettersAndNumbers(string s)
        {
            char c;
            bool code = true;
            if (s.Length > 0)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    c = s[i];
                    if (!(char.IsLetterOrDigit(c)) && !(c == '-') && !(c == ' ') && !(c == '_'))
                    {
                        code = false;
                    }
                }
            }
            else
            {
                code = false;
            }
            return code;
        }
        /// <summary>
        /// retourne true si la string s est de type Int32, retourne false sinon
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool isAnInteger(string s)
        {
            /* vérifier que la chaîne reçue représente bien un entier valide :
            *  -uniquement des chiffres
            *  -pas vide
            *  -pas plus de 9 chiffres (capacité maxi du type Int32)
            */
            char c;
            bool code = true;   //code de retour, vrai par défaut

            if (s.Length < 10 && s.Length > 0) //si la longueur de la string est strictement comprise en 0 et 10 (de 1 à 9 caractères)
            {
                //on vérifie tous les caractères un à un pour s'assurer que ce sont des chiffres
                for (int i = 0; i < s.Length; i++)
                {
                    c = s[i];
                    if (!(char.IsDigit(c))) //si le char n'est pas un chiffre
                    {
                        code = false;   //alors on à un problème
                    }
                }
            }
            else
            {
                code = false;   //on à un problème si la longueur de la string est <= 0 ou >= 10
            }
            return code;
        }
        /// <summary>
        /// retourne true si la string s est de type Decimal ou double, retourne false sinon
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool isDecimalOrDouble(string s)
        {
            char c;
            bool code = true;   //code de retour, vrai par défaut

            if (s.Length > 0) //si la string existe
            {
                //on vérifie tous les caractères un à un pour s'assurer que ce sont des chiffres, un point ou une virgule
                for (int i = 0; i < s.Length; i++)
                {
                    c = s[i];
                    if (!(char.IsDigit(c)) && !(c == '.') && !(c == ',')) //si le char n'est pas un chiffre ou un séparateur de type . ou ,
                    {
                        code = false;   //alors on à un problème
                    }
                }
            }
            else
            {
                code = false;   //on à un problème si la longueur de la string est <= 0
            }
            return code;
        }
        /// <summary>
        /// retourne true si la string s est composée uniquement de chiffres, retourne false sinon
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool isMadeOfNumbers(string s)
        {
            char c;
            bool code = true;   //code de retour, vrai par défaut

            if (s.Length > 0) //si la longueur de la string est strictement supérieure à 0
            {
                //on vérifie tous les caractères un à un pour s'assurer que ce sont des chiffres
                for (int i = 0; i < s.Length; i++)
                {
                    c = s[i];
                    if (!(char.IsDigit(c)) && !(c == '+')) //si le char n'est pas un chiffre
                    {
                        code = false;   //alors on à un problème
                    }
                }
            }
            else
            {
                code = false;   //on à un problème si la longueur de la string est <= 0
            }
            return code;
        }
        /// <summary>
        /// retourne true si la raison sociale est composée de lettres, chiffres et de -/ /_ sinon retourne false
        /// TODO : vérifier combien de symboles il y a et ou ils sont placés
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool isRaisonSocialeValid(string s)
        {
            return isMadeOfLettersAndNumbers(s);
        }
        /// <summary>
        /// retourne true si l'effectif est bien de type Int32, false sinon
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool isEffectifValid(string s)
        {
            return isAnInteger(s);
        }
        /// <summary>
        /// retourne true si le chiffre d'affaire est composée de chiffres et de virgule ou point........false sinon
        /// TODO : vérifier qu'il n'y a bien qu'un seul point ou virgule et placé ni en début ni en fin de string
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool isCaValid(string s)
        {
            return isDecimalOrDouble(s);
        }
        /// <summary>
        /// retourne true si le telephone est composée uniquement de chiffres
        /// TODO : rajouter des contrôles supplémentaires pour les () le + et un nombre de chiffres maximum
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool isTelephoneValid(string s)
        {
            return isMadeOfNumbers(s);
        }
        /// <summary>
        /// retourne true si le nom est composée de lettres, tiret, espace ou underscore et false sinon
        /// TODO : vérifier combien de symboles il y a et ou ils sont placés
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool isNomValid(string s)
        {
            return isMadeOfLetters(s);
        }
        /// <summary>
        /// retourne true si le prénom est composée de lettres, tiret, espace ou underscore et false sinon
        /// TODO : vérifier combien de symboles il y a et ou ils sont placés
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool isPrenomValid(string s)
        {
            return isMadeOfLetters(s);
        }
        /// <summary>
        /// retourne true si la fonction est composée de lettres, tiret, espace ou underscore et false sinon
        /// TODO : vérifier combien de symboles il y a et ou ils sont placés
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool isFonctionValid(string s)
        {
            return isMadeOfLetters(s);
        }
        /// <summary>
        /// retourne l'id idéale pouvant être utilisée pour la création du prochain contact
        /// </summary>
        /// <returns></returns>
        public static int bestIdContact()
        {
            int id = 1;
            if (Donnees.abiDb.TContact.ToList() != null)
            {
                foreach (TContact contactEF in Donnees.abiDb.TContact.ToList())
                {
                    if (contactEF.IdContact == id)
                    {
                        id++;
                    }
                    else
                    {
                        return id;
                    }
                }
            }
            return id;
        }
        /// <summary>
        /// retourne l'id inutilisée la plus basse possible
        /// </summary>
        /// <returns></returns>
        public static int bestIdClient()
        {
            int id = 1;
            if(Donnees.abiDb.TClient.ToList() != null)
            {
                foreach (TClient clientEF in Donnees.abiDb.TClient.ToList())
                {
                    if (clientEF.IdClient == id)
                    {
                        id++;
                    }
                    else
                    {
                        return id;
                    }
                }
            }
            return id;
        }
    }
}
