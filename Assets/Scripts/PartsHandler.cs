using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartsHandler : MonoBehaviour
{

    public GameObject allGenderVisuals, femaleVisuals,maleVisuals;

    public List<Gear> allGenderParts;
    public List<Gear> femaleParts;
    public List<Gear> maleParts;

    //-------
    [Header("prefixes")]
    public string headCovering = "_HeadCoverings_";
    public string hair = "_Hair_";
    public string helmet = "_HelmetAttachment_";
    public string back = "_BackAttachment_";
    public string shoulderRight = "_ShoulderAttachRight_";
    public string shoulderLeft = "_ShoulderAttachLeft_";
    public string elbowRight = "_ElbowAttachRight_";
    public string elbowLeft = "_ElbowAttachLeft_";
    public string hipsAttachment = "_HipsAttachment_";
    public string kneeRight = "_KneeAttachRight_";
    public string kneeLeft = "_KneeAttachLeft_";
    public string ears = "_Ear_"; 

    public string head = "_Head_";
    public string eyebrows = "_Eyebrow_";
    public string facialHair = "_FacialHair_";
    public string torso = "_Torso_";
    public string upperArmRight = "_ArmUpperRight_";
    public string upperArmLeft = "_ArmUpperLeft_";
    public string lowerArmRight = "_ArmLowerRight_";
    public string lowerArmLeft = "_ArmLowerLeft_";
    public string handRight = "_HandRight_";
    public string handLeft = "_HandLeft_";
    public string hips = "_Hips_";
    public string legRight = "_LegRight_";
    public string legLeft = "_LegLeft_";

    // Start is called before the first frame update
    void Start()
    {
        //FillData();
        SetupStart(allGenderParts);
        SetupStart(maleParts);
        SetupStart(femaleParts);
        ShowBaseMale();
    }

    void SetupStart(List<Gear> parts) {
        foreach(Gear g in parts) {
            if(!g.isOwned) {
                g.visual.SetActive(false);
            } else {
                if(!g.isEquipped) {
                    g.visual.SetActive(false);
                } else {
                    g.visual.SetActive(true);
                }
            }
        }
    }

    void ShowBaseMale() {
        foreach(Gear g in maleParts) {
            if(g.visual.name.Contains("00")) {
                g.visual.SetActive(true);
            }
        }
    }
    void ShowBaseFemale() {
        foreach(Gear g in femaleParts) {
            if(g.visual.name.Contains("00")) {
                g.visual.SetActive(true);
            }
        }
    }
    void FillData() {
        allGenderParts = new List<Gear>();
        femaleParts = new List<Gear>();
        maleParts = new List<Gear>();
        GenerateGear(allGenderVisuals, allGenderParts);
        GenerateGear(femaleVisuals, femaleParts);
        GenerateGear(maleVisuals, maleParts);
    }

    void GenerateGear(GameObject theParent, List<Gear> toFill) {
        SkinnedMeshRenderer[] theVisuals = theParent.GetComponentsInChildren<SkinnedMeshRenderer>();
        foreach(SkinnedMeshRenderer smr in theVisuals) {
            Gear newGear = new Gear();
            newGear.visual = smr.gameObject;
            toFill.Add(newGear);
        }
    }

}

[System.Serializable]
public class Gear {
    public bool isEquipped;
    public bool isOwned;
    public GameObject visual;
}
