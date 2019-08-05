using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartsCategoryHandler : MonoBehaviour
{
    public bool isRequired;
    public bool usingThisFeature;
    public List<GameObject> Parts;
    public int currentPart;

    public void Start() {
        List<SkinnedMeshRenderer> Parts2 = new List<SkinnedMeshRenderer>();
        Parts2.AddRange(GetComponentsInChildren<SkinnedMeshRenderer>());
        foreach(SkinnedMeshRenderer smr in Parts2) {
            Parts.Add(smr.gameObject);
        }
        UseThisFeature(isRequired);
    }

    public void NextPart() {
        currentPart++;
        if(currentPart >= Parts.Count) {
            currentPart = (isRequired ? 0 : -1);
        }
        
    }
    public void PreviousPart() {
        currentPart--;
        if(currentPart < (isRequired ? 0 : -1)) {
            currentPart = Parts.Count-1;
        }
        SetToValue(currentPart);
    }

    public void SetToValue(int value) {
        if(value == -1 || value >= Parts.Count) {
            value = isRequired ? 0 : -1;
        }
        if(value == -1 || value >= Parts.Count) {
            UseThisFeature(false);
        } else {
            currentPart = value;
            UseThisFeature(true);
        }
    }

    public void UseThisFeature(bool sw) {
        usingThisFeature = sw;
        ShowPart();
    }

    public void ShowPart() {
        foreach(GameObject g in Parts) {
            g.SetActive(false);
        }
        if(usingThisFeature) {
            Parts[currentPart].SetActive(true);
        }
    }
}
