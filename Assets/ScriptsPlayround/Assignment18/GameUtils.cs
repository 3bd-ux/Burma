using UnityEngine;
namespace lecture18
{
    public class GameUtils
    {
        public static string DescribeItem<T>(T something)
        {
            return $"This item is a {something}";
        }
    }
}