namespace programme_Vierge
{
    class cGit : cTemplateInfos
    {
        /// <summary>
        /// -- Variables publiques contenues dans la classe enfant uniquement. Leurs valeurs seront attribuées par les éléments 
        ///    hérités du parent
        /// </summary>
        public string nameChild = "";
        public string contentChild = "";
        public int dateEntryChild = 0;

        /// <summary>
        /// --Hérite de la classe template qui est son parent. L'enfant pourra la modifier à sa guise mais doit l'avoir
        /// </summary>
        /// <returns> string de nom</returns>
        public override string isAuthor()
        {
            nameChild = "Philippe et Émile";
            return nameChild;
        }

        public override string isContent()
        {
            contentChild = "gitgitgitgit";
            return contentChild;
        }

        /// <summary>
        /// --Hérite de la classe template qui est son parent. L'enfant pourra la modifier à sa guise mais doit l'avoir
        /// </summary>
        /// <returns> Int représentant la date</returns>
        public override int isDate()
        {
            dateEntryChild = 20190409;
            return dateEntryChild;
        }
    }
}
