using System;
using System.Reflection.Emit;
using UnityEngine;

namespace Assignment18
{
    public class Character  //class
    {
        private int health; //field
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

        private void DisplayInfo()
        {
            Debug.Log($"Name: {name}");
            Debug.Log($"Health: {health}");
            position.printPosition();
        }

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
        public Position
        (float x, float y, float z) //constructor with 3 parameters inside
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public float x;
        public float y;
        public float z;


    }

    public class Soldier
    {
        string name;
        int health;
        Position position;
    }

}