namespace TheGame.Classes
{
    using System;

    public abstract class GameObject
    {
        #region Fields and Properties

        private string name;

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
                    throw new ArgumentOutOfRangeException("Name cannot be less than 2 symbols.");
                }

                this.name = value;
            }
        }

        #endregion

        #region Constructor

        public GameObject()
        {

        }

        public GameObject(string name)
        {
            this.Name = name;
        }

        #endregion

        #region Methods

        //TODO: ovverid to ..ToString
        public override string ToString()
        {
            return string.Format("{0}", this.name);
        }

        #endregion
    }
}
