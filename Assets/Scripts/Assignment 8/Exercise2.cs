using UnityEngine;

public class Exercise2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string funnySentence = null;
        string[] abu7aidar = { "Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird" };
        string[] om7aidar = new string[7];
        int i = 0;
        while (i < om7aidar.Length)
        {
            funnySentence += abu7aidar[Random.Range(0, abu7aidar.Length)] + " ";
            om7aidar[i] = abu7aidar[Random.Range(0, abu7aidar.Length)];
            i++;
        }
        for (i = 0; i < om7aidar.Length; i++)
        {
            Debug.Log(om7aidar[i]);
        }
        Debug.Log(funnySentence);

    }
}