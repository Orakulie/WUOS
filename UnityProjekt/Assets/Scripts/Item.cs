using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Item{
    public string Name;
    public int ID;
    public string Beschreibung;
    public ItemType itemType;
    public enum ItemType
    {
        Waffe,
        Verbrauchbares,
        Quest
    }
}
