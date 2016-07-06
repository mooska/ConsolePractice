using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePractice
{
    public enum FoodGroup { Fruit, Meat, Dairy, Dessert } 

    //Using VALUE TYPE via struct
    public struct Food : IEquatable<Food>
    {
        private readonly string _name;
        private readonly FoodGroup _group;

        public string Name { get { return _name; } }

        public FoodGroup Group { get { return _group; } }

        public Food(string name, FoodGroup group)
        {
            _name = name;
            _group = group;
        }

        public override string ToString()
        {
            return _name;
        }

        public static bool operator ==(Food food1, Food food2)
        {
            return food1.Equals(food2);
        }

        public static bool operator !=(Food food1, Food food2)
        {
            return !food1.Equals(food2);
        }

        public override int GetHashCode()
        {
            return _name.GetHashCode() ^ _group.GetHashCode();
        }

        public bool Equals(Food other)
        {
            return _name == other.Name && _group == other.Group;
        }

        public override bool Equals(object obj)
        {
            if (obj is Food)
            {
                return Equals((Food)obj);
            }
            else
                return false;
        }
    }
}
