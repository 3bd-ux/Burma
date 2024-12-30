using UnityEngine;

public class CustomObject
{
    public CustomObject(int id, string name)
    {
        ID = id;
        Name = name;
    }
    public int ID { get; set; }
    public string Name { get; set; }
    public override string ToString()
    {
        return $"{nameof(CustomObject)} [ID: {ID}, Name: {Name}]";
    }
    /*
    public override bool Equals(object obj)
    {
        if (obj is CustomObject other)
        {
            return ID == other.ID && Name == other.Name;
        }
        return false;
    }
    */
    public static bool operator ==(CustomObject obj1, CustomObject obj2)
    {
        if (obj1 is null || obj2 is null) return false;

        return (obj1.Name.Equals(obj2.Name) && obj1.ID.Equals(obj2.ID));
    }

    public static bool operator !=(CustomObject obj1, CustomObject obj2)
    {
        return !(obj1.Name.Equals(obj2.Name) && obj1.ID.Equals(obj2.ID));
    }
}