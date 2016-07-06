using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePractice
{
    public enum DrinkGroup { Water, Soda, Juice, Cocktail, Tea, Coffee }

    public class Drink
    {
        private readonly string _name;
        private readonly DrinkGroup _group;

        public string Name { get { return _name;  } }

        public DrinkGroup Group { get { return _group; } }

        public Drink(string name, DrinkGroup group)
        {
            _name = name;
            _group = group;
        }

        public override string ToString()
        {
            return _name;
        }

        public static bool operator ==(Drink drink1, Drink drink2)
        {
            return object.Equals(drink1, drink2);
        }

        public static bool operator !=(Drink drink1, Drink drink2)
        {
            return !object.Equals(drink1, drink2);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            if (obj.GetType() != this.GetType())
                return false;
            Drink other = obj as Drink;
            return _name == other._name && _group == other._group;
        }

        public override int GetHashCode()
        {
            return _name.GetHashCode() ^ _group.GetHashCode();
        }
    }
}
