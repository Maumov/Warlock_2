using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GearSelection : MonoBehaviour
{
    CharacterCustomizer characterCustomizer;
    public PartsCategoryHandler helmet1, helmet2, helmet3, helmetAttachment, back, ShoulderR,ShoulderL, ElbowL,ElbowR, Hips, KneeR,KneeL;
    public PartsCategoryHandler maleHead,  maleTorso, maleAUR, maleAUL, maleALR, maleALL, maleHR, maleHL, maleHips, maleLR, maleLL;
    public PartsCategoryHandler femaleHead, femaleTorso, femaleAUR, femaleAUL, femaleALR, femaleALL, femaleHR, femaleHL, femaleHips, femaleLR, femaleLL;

    private void Start() {
        characterCustomizer = GetComponent<CharacterCustomizer>();
        Invoke("SetToEmpty", 1f);
    }

    void SetToEmpty() {
        SetHelmet1(-1);
        SetHelmet2(-1);
        SetHelmet3(-1);
        SetHelmetAttachment(-1);
        SetBack(-1);
        SetShoulder(-1);
        SetHipAttachment(-1);
        SetKnee(-1);
        SetHead(-1);
        SetTorso(0);
        SetHips(0);
        SetAU(0);
        SetAL(0);
        SetH(0);
        SetLegs(0);
    }

    public void SetHelmet1(int value) {
        helmet1.SetToValue(value);
    }
    public void SetHelmet2(int value) {
        helmet2.SetToValue(value);
    }
    public void SetHelmet3(int value) {
        helmet3.SetToValue(value);
    }


    public void SetHelmetAttachment(int value) {
        helmetAttachment.SetToValue(value);
    }
    public void SetKnee(int value) {
        KneeR.SetToValue(value);
        KneeL.SetToValue(value);
    }
    public void SetHipAttachment(int value) {
        Hips.SetToValue(value);
    }

    public void SetBack(int value) {
        back.SetToValue(value);
    }

    public void SetShoulder(int value) {
        ShoulderR.SetToValue(value);
        ShoulderL.SetToValue(value);
    }

    public void SetElbow(int value) {
        ElbowL.SetToValue(value);
        ElbowR.SetToValue(value);
    }


    public void SetHips(int value) {
        if(characterCustomizer.isMale) {
            maleHips.SetToValue(value);
        } else {
            femaleHips.SetToValue(value);
        }
    }

    public void SetLegs(int value) {
        if(characterCustomizer.isMale) {
            maleLR.SetToValue(value);
            maleLL.SetToValue(value);
        } else {
            femaleLR.SetToValue(value);
            femaleLL.SetToValue(value);
        }
    }

    public void SetTorso(int value) {
        if(characterCustomizer.isMale) {
            maleTorso.SetToValue(value);
        } else {
            femaleTorso.SetToValue(value);
        }
    }
    public void SetHead(int value) {
        if(characterCustomizer.isMale) {
            maleHead.SetToValue(value);
        } else {
            femaleHead.SetToValue(value);
        }
    }
    public void SetAU(int value) {
        if(characterCustomizer.isMale) {
            maleAUR.SetToValue(value);
            maleAUL.SetToValue(value);
        } else {
            femaleAUR.SetToValue(value);
            femaleAUL.SetToValue(value);
        }
    }
    public void SetAL(int value) {
        if(characterCustomizer.isMale) {
            maleALR.SetToValue(value);
            maleALL.SetToValue(value);
        } else {
            femaleALR.SetToValue(value);
            femaleALL.SetToValue(value);
        }
    }

    public void SetH(int value) {
        if(characterCustomizer.isMale) {
            maleHR.SetToValue(value);
            maleHL.SetToValue(value);
        } else {
            femaleHR.SetToValue(value);
            femaleHL.SetToValue(value);
        }
    }


    public void Next(string category) {
        switch(category) {
            case "HelmetAttachment":
                helmetAttachment.NextPart();
            break;
            case "Back":
                back.NextPart();
            break;
            case "Shoulder":
                ShoulderR.NextPart();
                ShoulderL.NextPart();
            break;
            case "Elbow":
                ElbowL.NextPart();
                ElbowR.NextPart();
            break;
            case "HipsAttachment":
                Hips.NextPart();
            break;
            case "Knee":
                KneeL.NextPart();
                KneeR.NextPart();
            break;
            case "Helmet":
            if(characterCustomizer.isMale) {
                maleHead.NextPart();
            } else {
                femaleHead.NextPart();
            }
            break;
            case "Torso":
            if(characterCustomizer.isMale) {
                maleTorso.NextPart();
            } else {
                femaleTorso.NextPart();
            }
            break;
            case "ArmUpper":
            if(characterCustomizer.isMale) {
                maleAUL.NextPart();
                maleAUR.NextPart();
            } else {
                femaleAUL.NextPart();
                femaleAUR.NextPart();
            }
            
            break;
            case "ArmLower":
            if(characterCustomizer.isMale) {
                maleALL.NextPart();
                maleALR.NextPart();
            } else {
                femaleALL.NextPart();
                femaleALR.NextPart();
            }
            break;
            case "Hand":
            if(characterCustomizer.isMale) {
                maleHL.NextPart();
                maleHR.NextPart();
            } else {
                femaleHL.NextPart();
                femaleHR.NextPart();
            }
            break;
            case "Hips":
            if(characterCustomizer.isMale) {
                maleHips.NextPart();
            } else {
                femaleHips.NextPart();
            }
            break;
            case "Leg":
            if(characterCustomizer.isMale) {
                maleLL.NextPart();
                maleLR.NextPart();
            } else {
                femaleLL.NextPart();
                femaleLR.NextPart();
            }
            break;
        }
    }
    public void Previous(string category) {
        switch(category) {
            case "HelmetAttachment":
            helmetAttachment.PreviousPart();
            break;
            case "BackAttachment":
            back.PreviousPart();
            break;
            case "ShoulderAttach":
            ShoulderR.PreviousPart();
            ShoulderL.PreviousPart();
            break;
            case "ElbowAttach":
            ElbowL.PreviousPart();
            ElbowR.PreviousPart();
            break;
            case "HipsAttachment":
            Hips.PreviousPart();
            break;
            case "KneeAttach":
            KneeL.PreviousPart();
            KneeR.PreviousPart();
            break;
            case "Helmet":
            if(characterCustomizer.isMale) {
                maleHead.PreviousPart();
            } else {
                femaleHead.PreviousPart();
            }
            break;
            case "Torso":
            if(characterCustomizer.isMale) {
                maleTorso.PreviousPart();
            } else {
                femaleTorso.PreviousPart();
            }
            break;
            case "ArmUpper":
            if(characterCustomizer.isMale) {
                maleAUL.PreviousPart();
                maleAUR.PreviousPart();
            } else {
                femaleAUL.PreviousPart();
                femaleAUR.PreviousPart();
            }

            break;
            case "ArmLower":
            if(characterCustomizer.isMale) {
                maleALL.PreviousPart();
                maleALR.PreviousPart();
            } else {
                femaleALL.PreviousPart();
                femaleALR.PreviousPart();
            }
            break;
            case "Hand":
            if(characterCustomizer.isMale) {
                maleHL.PreviousPart();
                maleHR.PreviousPart();
            } else {
                femaleHL.PreviousPart();
                femaleHR.PreviousPart();
            }
            break;
            case "Hips":
            if(characterCustomizer.isMale) {
                maleHips.PreviousPart();
            } else {
                femaleHips.PreviousPart();
            }
            break;
            case "Leg":
            if(characterCustomizer.isMale) {
                maleLL.PreviousPart();
                maleLR.PreviousPart();
            } else {
                femaleLL.PreviousPart();
                femaleLR.PreviousPart();
            }
            break;
        }
    }
}
