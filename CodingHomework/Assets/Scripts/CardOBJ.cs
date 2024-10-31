using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Make this in the menu
[CreateAssetMenu (fileName = "NewCard", menuName = "ScriptableObject/Cards", order = 0)]


public class CardOBJ : ScriptableObject
{
    //Declare variables used in our ScriptableObject
    public string CardName;


    public Sprite CardPicture;

    public string CardDescription;

    public int attack;

    public int health;
}
