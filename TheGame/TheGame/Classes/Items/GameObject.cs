namespace TheGame.Classes.Items
{
    using System;

    public abstract class GameObject
    {
        #region Fields and Properties

        private string name;
        private string description;

        //public GameObject(string name, string description)
        //{
        //    this.Name = name;
        //    this.Description = description;
        //}

        public string Name 
        {
            get
            {
                return this.name;
            }
            protected set
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
            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Description cannot be null or empty.");
                }

                if (value.Length < 2)
                {
                    throw new ArgumentOutOfRangeException("Description cannot be less than 2 symbols");
                }
                this.description = value;
            }
        }

        #endregion

        #region Constructor

        public GameObject(string name, string description)
        {
            this.Name = name;
            this.Description = description;
        }

        #endregion

        #region Methods

        //TODO: ovverid to ..ToString
        public override string ToString()
        {
            return string.Format("{0} - {1}", this.name, this.description);
        }

        #endregion
    }
}
