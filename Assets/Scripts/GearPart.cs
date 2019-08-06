using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot {
    public Item item;
    public int amount;

    public void Use() {

    }
}

public class Item {

    public int MaxStackAmount;
    public string name;
    public bool consumable;

    public virtual void Use() {
        Debug.Log("Used item " +name);
    }
}

public class Armor : Item{
    public GearPart gearPart;
    public ArmorStats stats;

    public override void Use() {
        
    }
}

public class Consumable : Item {
    public ConsumableEffect consumableEffect;
    public override void Use() {

    }
}

public enum EffectType { bonusHP, bonusSpeed}
public class ConsumableEffect {
    public EffectType effect;
    public float duration;
}


public class ArmorStats {
    public int HP;
}

public class GearPart {
    public string gameName;
    public int id;
    public GearCategory category;
}
public class CharacterPart {
    public string gameName;
    public int id;
    public CharacterCategory category;
}
public enum GearCategory {
    Helmet1,
    Helmet2,
    Helmet3,
    HelmetAttachment,
    Helmet,
    Back,
    Chest,
    Shoulder,
    Feet,
    Leg,
    Waist,
    WaistAttachment,
    Knee,
    Hand,
    Elbow,
    UArm,
    LArm
}
public enum CharacterCategory {
    Hair,
    Ear,
    Head,
    Eyebrows,
    FacialHair
}
