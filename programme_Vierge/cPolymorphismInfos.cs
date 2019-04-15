namespace programme_Vierge
{
    class cPolymorphismInfos : cTemplateInfos
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
            nameChild = "Marie-Pier et Denis";
            return nameChild;
        }

        /// <summary>
        /// --Hérite de la classe template qui est son parent. L'enfant pourra la modifier à sa guise mais doit l'avoir
        /// </summary>
        /// <returns> Contenu de l'article</returns>
        public override string isContent()
        {
            contentChild = "Polymorphisme";
            return contentChild;
        }

        /// <summary>
        /// --Hérite de la classe template qui est son parent. L'enfant pourra la modifier à sa guise mais doit l'avoir
        /// </summary>
        /// <returns>int représentant la date</returns>
        public override int isDate()
        {
            dateEntryChild = 20190408;
            return dateEntryChild;
        }

        /// <summary>
        /// -- Hérite de la classe template qui est son parent. L'enfant pourra la modifier à sa guise mais peut choisit 
        /// de l'utiliser ou pas car il est virtual
        /// </summary>
        /// <returns> string de titre</returns>
        public override bool IsTitle(string titleEntry)
        {
            return base.IsTitle(titleEntry);
        }
    }
}