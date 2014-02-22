namespace TheGame.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    abstract class GameObject
    {
        #region Fields and Properties

        private string name;
        private string description;

        public string Name 
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty.");
                }

                if (value.Length < 2)
                {
                    throw new ArgumentOutOfRangeException("Name cannot be less than 2 symbols");
                }

                this.name = value;
            }
        }

        public string Description 
        {
            get
            {
                return this.description;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Description cannot be null or empty.");
                }

                if (value.Length < 2)
                {
                    throw new ArgumentOutOfRangeException("Description cannot be less than 2 symbols");
                }
            }
        }

        #endregion

        #region Methods

        //TODO: ovverid to ..ToString

        #endregion
    }
}
