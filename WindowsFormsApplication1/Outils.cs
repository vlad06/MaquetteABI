using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Outils
    {
        public static bool isMadeFromLetters(string s)
        {
            char c;
            bool code = true;
            if (s.Length > 0)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    c = s[i];
                    if (!(char.IsLetter(c)))
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
                code = false;   //on à un problème lorsque la longueur de la string est <= 0 ou >= 10
            }
            return code;
        }
    }
}
