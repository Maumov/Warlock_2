using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
