using System;
using System.Collections.Generic;

namespace VsroAccount.Repository.Entities
{
    public partial class Books
    {
        public Books()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime Pubdate { get; set; }

        public string Synopsis { get; set; }

        public bool Inprint { get; set; }

        public int SalesCount { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
