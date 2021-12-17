using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1030FinalProject.InventorySystem
{
    //Enum to specify projectile type
    public enum ProjectileType { Bullet, Arrow, Explosive }

    //Projectile inherits from Item
    public class Projectile : Item
    {
        //Type of projectile
        private ProjectileType _type;
        public ProjectileType Type
        {
            get { return _type; }
            set { _type = value; }
        }

        //Effect of gravity on this projectile
        private float _gravity;
        public float Gravity
        {
            get { return _gravity; }
            set { _gravity = value; }
        }

        //Length of projectile
        private float _length;
        public float Length
        {
            get { return _length; }
            set { _length = value; }
        }

        //Width of projectile
        private float _width;
        public float Width
        {
            get { return _width; }
            set { _width = value; }
        }

        //X component of direction vector
        private float _xDirection;
        public float XDirection
        {
            get { return _xDirection; }
            set { _xDirection = value; }
        }

        //Y component of direction vector
        private float _yDirection;
        public float YDirection
        {
            get { return _yDirection; }
            set { _yDirection = value; }
        }

        //Damage of this projectile
        private float _projectileDamage;
        public float ProjectileDamage
        {
            get { return _projectileDamage; }
            set { _projectileDamage = value; }
        }

        //Function to get stats
        public override List<string> ToStrings()
        {
            List<string> s = new List<string>();
            s.Add("Type: " + Type);
            s.Add("Projectile Damage: " + ProjectileDamage);
            s.Add("Gravity: " + Gravity);
            s.Add("Length: " + Length);
            s.Add("Width: " + Width);
            s.Add("X Direction: " + XDirection);
            s.Add("Y Direction: " + YDirection);
            return s;
        }

    }
}
