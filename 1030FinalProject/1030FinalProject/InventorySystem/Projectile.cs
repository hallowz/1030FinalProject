using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1030FinalProject.InventorySystem
{
    public enum ProjectileType { Bullet, Arrow, Explosive }
    public class Projectile : Item
    {
        private ProjectileType _type;
        public ProjectileType Type
        {
            get { return _type; }
            set { _type = value; }
        }

        private float _gravity;
        public float Gravity
        {
            get { return _gravity; }
            set { _gravity = value; }
        }
        private float _length;
        public float Length
        {
            get { return _length; }
            set { _length = value; }
        }
        private float _width;

        public float Width
        {
            get { return _width; }
            set { _width = value; }
        }
        private float _xDirection;
        public float XDirection
        {
            get { return _xDirection; }
            set { _xDirection = value; }
        }
        private float _yDirection;
        public float YDirection
        {
            get { return _yDirection; }
            set { _yDirection = value; }
        }
        private float _projectileDamage;
        public float ProjectileDamage
        {
            get { return _projectileDamage; }
            set { _projectileDamage = value; }
        }
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
