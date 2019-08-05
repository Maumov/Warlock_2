using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCustomizer : MonoBehaviour
{
    public bool isMale;
    public GameObject maleParts, femaleParts;

    public PartsCategoryHandler hair, ears;
    public PartsCategoryHandler maleHead, maleEyebrows, maleFacialHair;
    public PartsCategoryHandler femaleHead, femaleEyebrows, femaleFacialHair;

    private void Start() {
        Invoke("SetToEmpty", 1f);
    }

    void SetToEmpty() {
        SetHair(-1);
        SetEars(-1);
        SetHead(-1);
        SetEyebrows(-1);
        SetFacialHair(-1);
        SwitchGender(isMale);
    }
    public void SetHair(int value) {
        hair.SetToValue(value);
    }
    public void SetEars(int value) {
        ears.SetToValue(value);
    }
    public void SetHead(int value) {
        if(isMale) {
            maleHead.SetToValue(value);
        } else {
            femaleHead.SetToValue(value);
        }
    }
    public void SetEyebrows(int value) {
        if(isMale) {
            maleEyebrows.SetToValue(value);
        } else {
            femaleEyebrows.SetToValue(value);
        }
    }
    public void SetFacialHair(int value) {
        if(isMale) {
            maleFacialHair.SetToValue(value);
        } else {
            femaleFacialHair.SetToValue(value);
        }
    }

    public void SwitchGender() {
        isMale = !isMale;
        maleParts.SetActive(isMale);
        femaleParts.SetActive(!isMale);
    }

    public void SwitchGender(bool sw) {
        isMale = sw;
        maleParts.SetActive(isMale);
        femaleParts.SetActive(!isMale);
    }





    public void Next(string category) {
        switch(category) {
            case "hair":
                hair.NextPart();
            break;
            case "ears":
                ears.NextPart();
            break;
            case "maleHead":
                maleHead.NextPart();
            break;
            case "maleEyebrows":
                maleEyebrows.NextPart();
            break;
            case "maleFacialHair":
                maleFacialHair.NextPart();
            break;
            case "femaleHead":
                femaleHead.NextPart();
            break;
            case "femaleEyebrows":
                femaleEyebrows.NextPart();
            break;
            case "femaleFacialHair":
                femaleFacialHair.NextPart();
            break;
        }
    }

    public void Previous(string category) {
        switch(category) {
            case "hair":
                hair.PreviousPart();
            break;
            case "ears":
                ears.PreviousPart();
            break;
            case "maleHead":
                maleHead.PreviousPart();
            break;
            case "maleEyebrows":
                maleEyebrows.PreviousPart();
            break;
            case "maleFacialHair":
                maleFacialHair.PreviousPart();
            break;
            case "femaleHead":
                femaleHead.PreviousPart();
            break;
            case "femaleEyebrows":
                femaleEyebrows.PreviousPart();
            break;
            case "femaleFacialHair":
                femaleFacialHair.PreviousPart();
            break;
        }
    }

}
