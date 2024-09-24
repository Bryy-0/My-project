using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ClearButton : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Info;

    string Name = "N/A";
    int Age = 0;
    string Race = "N/A";
    int PhysicalDamage = 0;
    int Armor = 0;
    int MagicDamage = 0;
    int MagicResistance = 0;
    float Speed = 0;

    public void Clear()
    {
        Info.text = "Player Info: \r\n \r\nName: " + Name + "\r\nAge: " + Age + "\r\nRace: " + Race + "\r\nPhysicalDamage: " + PhysicalDamage + "\r\nArmor: " + Armor + "\r\nMagicDamage: " + MagicDamage + "\r\nMagicResistance: " + MagicResistance + "\r\nSpeed: " + Speed;
    }

}