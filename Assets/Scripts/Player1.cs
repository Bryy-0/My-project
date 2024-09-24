using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Info;

    string Name = "Alexis";
    int Age = 24;
    string Race = "Dragon";
    int PhysicalDamage = 50;
    int Armor = 75;
    int MagicDamage = 80;
    int MagicResistance = 60;
    float Speed = 65.8f;

    public void ButtonPressed()
    {
        Info.text = "Player Info: \r\n \r\nName: " + Name + "\r\nAge: " + Age + "\r\nRace: " + Race + "\r\nPhysicalDamage: " + PhysicalDamage + "\r\nArmor: " + Armor + "\r\nMagicDamage: " + MagicDamage + "\r\nMagicResistance: " + MagicResistance + "\r\nSpeed: " + Speed;
    }

}