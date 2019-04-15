using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dll_cSharpe
{
    public class DLL
    {
        /// <summary>
        /// Envoye un texte en paramettre et verifie si le texte contien ou est un nombre si oui retounre le nombre en question
        /// </summary>
        /// <param name="textToVal">String</param>
        /// <returns>Decimal</returns>
        public decimal validationNumber(string textToVal)
        {
            //Declare le nombre qui va etre retourner
            decimal number;
            //Verifie si le texte envoyer est bien un nombre 
            bool success = decimal.TryParse(textToVal, out number);
            //Si oui on retourne le nombre en question
            if (success) { return number; }
            //Si non on retourne 0 pour eviter que le code plante
            else { return 0;}          
        }


        /// <summary>
        /// Recois 2 nombre et retourne le resultat de ces deux nombres additionnés
        /// </summary>
        /// <param name="nb1">Decimal</param>
        /// <param name="nb2">Decimal</param>
        /// <returns>Decimal</returns>
        //Fonction de retour d'addition possibliter de surcharge jusqu'a un maximum de 4 nombres  
        public decimal add(decimal nb1, decimal nb2)
        {
            //Declare le nombre qui va etre retourner et effectue l'addition
            decimal number = nb1 + nb2;
            //Retourne le resulat
            return number;
        }

        /// <summary>
        /// Recois 3 nombre et retourne le resultat de ces deux nombres additionnés
        /// </summary>
        /// <param name="nb1">Decimal</param>
        /// <param name="nb2">Decimal</param>
        /// <param name="nb3">Decimal</param>
        /// <returns>Decimal</returns>
        public decimal add(decimal nb1, decimal nb2, decimal nb3)
        {
            //Declare le nombre qui va etre retourner et effectue l'addition
            decimal number = nb1 + nb2 + nb3;
            //Retourne le resulat
            return number;
        }

        /// <summary>
        /// Recois 4 nombre et retourne le resultat de ces deux nombres additionnés
        /// </summary>
        /// <param name="nb1">Decimal</param>
        /// <param name="nb2">Decimal</param>
        /// <param name="nb3">Decimal</param>
        /// <param name="nb4">Decimal</param>
        /// <returns>Decimal</returns>
        public decimal add(decimal nb1, decimal nb2, decimal nb3, decimal nb4)
        {
            //Declare le nombre qui va etre retourner et effectue l'addition
            decimal number = nb1 + nb2 + nb3 + nb4;
            //Retourne le resulat
            return number;
        }

        /// <summary>
        /// Recois 2 nombre et retourne le resultat de ces deux nombres sustrais
        /// </summary>
        /// <param name="nb1">Decimal</param>
        /// <param name="nb2">Decimal</param>
        /// <returns>Decimal</returns>
        public decimal sustraction(decimal nb1, decimal nb2)
        {
            //Declare le nombre qui va etre retourner et effectue la sustraction
            decimal number = nb1 - nb2;
            //Retourne le resulat
            return number;
        }

        /// <summary>
        /// Recois 2 nombre et retourne le resultat de ces deux nombres sustrais
        /// </summary>
        /// <param name="nb1">Decimal</param>
        /// <param name="nb2">Decimal</param>
        /// <param name="nb3">Decimal</param>
        /// <returns>Decimal</returns>
        public decimal sustraction(decimal nb1, decimal nb2, decimal nb3)
        {
            //Declare le nombre qui va etre retourner et effectue la sustraction
            decimal number = nb1 - nb2 - nb3;
            //Retourne le resulat
            return number;
        }

        /// <summary>
        /// Recois 2 nombre et retourne le resultat de ces deux nombres sustrais
        /// </summary>
        /// <param name="nb1">Decimal</param>
        /// <param name="nb2">Decimal</param>
        /// <param name="nb3">Decimal</param>
        /// <param name="nb4">Decimal</param>
        /// <returns>Decimal</returns>
        public decimal sustraction(decimal nb1, decimal nb2, decimal nb3, decimal nb4)
        {
            //Declare le nombre qui va etre retourner et effectue la sustraction
            decimal number = nb1 - nb2 - nb3 - nb4;
            //Retourne le resulat
            return number;
        }

        /// <summary>
        /// Recois 2 nombre et retourne le resultat de ces deux nombres multiplier
        /// </summary>
        /// <param name="nb1">Decimal</param>
        /// <param name="nb2">Decimal</param>
        /// <returns>Decimal</returns>
        public decimal multi(decimal nb1, decimal nb2)
        {
            //Declare le nombre qui va etre retourner et effectue la multiplication
            decimal number = nb1 * nb2;
            //Retourne le resulat
            return number;
        }

        /// <summary>
        /// Recois 3 nombre et retourne le resultat de ces deux nombres multiplier
        /// </summary>
        /// <param name="nb1">Decimal</param>
        /// <param name="nb2">Decimal</param>
        /// <param name="nb3">Decimal</param>
        /// <returns>Decimal</returns>
        public decimal multi(decimal nb1, decimal nb2, decimal nb3)
        {
            //Declare le nombre qui va etre retourner et effectue la multiplication
            decimal number = nb1 * nb2 * nb3;
            //Retourne le resulat
            return number;
        }

        /// <summary>
        /// Recois 4 nombre et retourne le resultat de ces deux nombres multiplier
        /// </summary>
        /// <param name="nb1">Decimal</param>
        /// <param name="nb2">Decimal</param>
        /// <param name="nb3">Decimal</param>
        /// <param name="nb4">Decimal</param>
        /// <returns>Decimal</returns>
        public decimal multi(decimal nb1, decimal nb2, decimal nb3, decimal nb4)
        {
            //Declare le nombre qui va etre retourner et effectue la multiplication
            decimal number = nb1 * nb2 * nb3 * nb4;
            //Retourne le resulat
            return number;
        }

        //Créer un random pour le carathère bidon
        public static Random rnd = new Random();

        /// <summary>
        /// Recois du texte et retourne le texte crypter
        /// </summary>
        /// <param name="textToCrypt">String</param>
        /// <returns>String</returns>
        public string cryptSimple(string textToCrypt)
        {     
            //Decalare la variable qui va contenir le texte crypter c'est cette variable qui est returnée
            string textCrypt = "";
            //Pour chaque caratère change le caratère pour un autre aléatoire
            foreach (char item in textToCrypt)
            {
                //Change le caratère pour le meme caratère avec un code ascii augmenter de 6
                textCrypt += Convert.ToChar(item + 6);
                //Crée un code bidon
                textCrypt += Convert.ToChar(rnd.Next(43, 90));
            }
            return textCrypt;
        }

        /// <summary>
        /// Recois du texte crypter et retoure le texte decryptés
        /// </summary>
        /// <param name="textToUnCrypt"></param>
        /// <returns></returns>
        public string unCryptSimple(string textToUnCrypt)
        {
            //L'index pour recuperer les bon caratère
            int index = 2;
            //Contien le texte décripter cette variable est retourner
            string textUnCrypt = "";
            foreach (char item in textToUnCrypt)
            {
                //Quand l'index est paire (donc pas le caratere bidon) on l'ajoute au texte en diminuant de 6 son code ascii
                if (index % 2 == 0) { textUnCrypt += Convert.ToChar(item - 6);}
                //Augmente l'index a la main
                index++;
            }
            //retourne le texte décrypter
            return textUnCrypt;
        }
    }
}
