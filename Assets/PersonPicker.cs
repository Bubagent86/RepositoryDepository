using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonPicker : MonoBehaviour
{
    public NameInHat[] namesInHat;
    public PersonScriptableObject[] namesScriptable;
    public PersonScriptableObject ginele;
    public string[] names;
    public Color[] colors;
    public bool[] goodToPresent;                
    public AnimationCurve pickCurve;
    public TextMesh nameText;
    float timer;
    public float timeToPick;
    public int numberOfPicks;

    int prevPick;
    public static PersonPicker me;

    private void Awake() {
        me = this;
    }



    private void Update() {
        //PickName();
        timer += Time.deltaTime;
        var normalizedTime = timer / timeToPick;
        var curveVal = pickCurve.Evaluate(normalizedTime);
        var pick = Mathf.FloorToInt(curveVal * (float)numberOfPicks);
        if (prevPick != pick)
            PickName();
        prevPick = pick;

    }

    void PickName() {
        int rand = Random.Range(0, namesInHat.Length);
        int i = 0;
        while (!namesInHat[rand].readyToPresent) {
            rand = Random.Range(0, namesInHat.Length);
            i++;
            if (i > 1000) {
                Debug.LogError("No one is ready to present! Get it together guys.");
                break;
            }
        }
        Camera.main.backgroundColor = namesInHat[rand].color;
        nameText.text = namesInHat[rand].name;
    }
}
[System.Serializable]
public class NameInHat {
    public string name;
    public Color color;
    public bool readyToPresent;

}
