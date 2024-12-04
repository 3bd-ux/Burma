using System;
using System.Reflection.Emit;
using UnityEngine;

namespace Assignment18
{
    public class Character  //class
    {
        public Character(string name, int health, Position position)
        {
            this.name = name;
            this.health = health;
            this.position = position;

            DisplayInfo();
        }
        public Character() : this("No name", 100, new(0, 0, 0))
        {
        }

        public virtual void DisplayInfo()
        {
            Debug.Log($"Name: {name}");
            Debug.Log($"Health: {health}");
            position.printPosition();
        }
        private int health; //field

        public string name;// field
        protected Position position; //field
        public int Health //property
        {
            get { return health; }
            set
            {
                if (value > 100) health = 100;
                else if (value < 0) health = 0;
                else health = value;
            }
        }

        public void Attack(int damage, Character target, string attackType = null)
        {
            if (attackType != null) //
            {
                Debug.Log($"{damage} {target} {attackType}");
            }
            else
            {
                Debug.Log($"{damage} {target}");
            }
            health -= damage;
        }

    }

    public struct Position //struct
    {
        public void printPosition()
        {
            Debug.Log($"x= {x},y= {y},z= {z},");
        }
        public Position(float x, float y, float z) //constructor with 3 parameters inside
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public float x;
        public float y;
        public float z;


    }

    public class Soldier : Character
    {
        public Soldier() : base()
        {
            DisplayInfo();
            base.DisplayInfo();
        }
        public Soldier(string name, int health, Position position) : base(name, health, position)
        {
            this.name = name;
            this.health = health;
            this.position = position;

            DisplayInfo();
        }
        private int health;
        public override void DisplayInfo()
        {
            Debug.Log("Soldier");
            base.DisplayInfo();
        }
    }
    public class Officer : Character
    {
        public Officer() : base()
        {
            DisplayInfo();
            base.DisplayInfo();
        }
        public Officer(string name, int health, Position position) : base(name, health, position)
        {
            this.name = name;
            this.health = health;
            this.position = position;

            DisplayInfo();
            base.DisplayInfo();
        }
        private int health;
        public override void DisplayInfo()
        {
            Debug.Log("Officer");
        }
    }

}