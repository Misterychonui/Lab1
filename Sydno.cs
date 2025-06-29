using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    [Serializable]
    public class Sydno
    {
        private string sydnoName;
        private int sydnoSpeed;
        private int sydnoCrew;
        private double sydnoCapacity;

        #region Constructors 
        public Sydno() { }
        //public Sydno(string name, int speed, int crew, double capacity)
        //{
        //    Name = name;
        //    Speed = speed;
        //    Crew = crew;
        //    Capacity = capacity;
        //}
        #endregion
        #region Methods      

        public virtual void TakeCargo(double amount)
        {
            if (amount <= sydnoCapacity)
                sydnoCapacity -= amount;
            else throw new ArgumentException("Груз превышает вместимость");
        }

        public virtual void ShowStats()
        {
            Console.WriteLine(this);
            Console.WriteLine("-----------------------");
        }
        public override string ToString()
        {
            return $"Name:{sydnoName} Speed:{sydnoSpeed} Crew:{sydnoCrew} Capacity:{sydnoCapacity}";
        }


        public static bool operator <(Sydno x, Sydno y)
        {
            return x.Speed < y.Speed;
        }
        public static bool operator >(Sydno x, Sydno y)
        {
            return x.Speed > y.Speed;
        }
        #endregion
        #region Properties
        public string Name
        {
            get { return sydnoName; }
            set { sydnoName = value; }
        }
        public int Speed
        {
            get { return sydnoSpeed; }
            set { sydnoSpeed = value; }
        }
        public int Crew
        {
            get { return sydnoCrew; }
            set
            {
                if (value >= 1)
                    sydnoCrew = value;
                else throw new ArgumentException("Wrong sydno value(crew)");
            }
        }
        public double Capacity
        {
            get { return sydnoCapacity; }
            set
            {
                if (value > 0)
                    sydnoCapacity = value;
                else throw new ArgumentException("Wrong sydno value(capacity)");
            }
        }
        #endregion
    }
}
