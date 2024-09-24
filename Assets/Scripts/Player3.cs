using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player3 : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Info;

    string Name = "Dexter";
    int Age = 30;
    string Race = "Warrior";
    int PhysicalDamage = 30;
    int Armor = 100;
    int MagicDamage = 0;
    int MagicResistance = 80;
    float Speed = 40.5f;

    public void Button3Pressed()
    {
        Info.text = "Player Info: \r\n \r\nName: " + Name + "\r\nAge: " + Age + "\r\nRace: " + Race + "\r\nPhysicalDamage: " + PhysicalDamage + "\r\nArmor: " + Armor + "\r\nMagicDamage: " + MagicDamage + "\r\nMagicResistance: " + MagicResistance + "\r\nSpeed: " + Speed;
    }

}