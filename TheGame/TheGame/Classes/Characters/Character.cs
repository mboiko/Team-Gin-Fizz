namespace TheGame
{
    using System;
    public abstract class Character
    {
        private string nickname;
        //private Login login { get; private set; }

        //public Character(string name, Login login)   
        //{
        //    this.Nickname = name;
        //    this.login = login;
        //}


        // properties
        public string Nickname
        {
            get { return this.nickname; }
            set 
            {
                if (string.IsNullOrEmpty(value) || value.Length < 2 && value.Length > 15)
                {
                    // how we'll visualise this?
                    throw new ArgumentException(
                        "Invalid nickname. It must be longer than 2 and shorter than 15 symbols.");
                }
                this.nickname = value;
            }
        }

        //methods
        public int GetRandomNumber(int min, int max)
        {
            Random randomInt = new Random();
            return randomInt.Next(min, max + 1);
        }
    }
}
