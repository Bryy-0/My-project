using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Info;

    string Name = "Sarah";
    int Age = 21;
    string Race = "Elf";
    int PhysicalDamage = 20;
    int Armor = 75;
    int MagicDamage = 100;
    int MagicResistance = 40;
    float Speed = 59.9f;

    public void Button2Pressed()
    {
        Info.text = "Player Info: \r\n \r\nName: " + Name + "\r\nAge: " + Age + "\r\nRace:" + Race + "\r\nPhysicalDamage: " + PhysicalDamage + "\r\nArmor: " + Armor + "\r\nMagicDamage: " + MagicDamage + "\r\nMagicResistance: " + MagicResistance + "\r\nSpeed: " + Speed;
    }

}