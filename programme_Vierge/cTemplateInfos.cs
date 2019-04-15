using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace programme_Vierge
{
    public abstract class cTemplateInfos
    {
        /// <summary>
        /// -- Ces 4 éléments seront envoyés aux héritiers
        /// </summary>
        /// <returns></returns>
        public abstract string isAuthor();
        public abstract string isContent();
        public abstract int isDate();

        /// <summary>
        /// Must start with an alphabetic character. Can contain the following characters: a-z A-Z 0-9 - and _
        /// </summary>
        /// <param name="titleEntry">Entrée de titre à valider</param>
        /// <returns>bool</returns>
        public virtual bool IsTitle(string titleEntry)
        {
            Regex validEntry = new Regex(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,}$");
            Match match = validEntry.Match(titleEntry);
            if (match.Success)
            {
                return true;
            }
            return false;
        }
    }
}
