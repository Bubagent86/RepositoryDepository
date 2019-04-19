using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonDisplayer : MonoBehaviour
{
    // Update is called once per frame
    void Update() {
        Debug.Log(PersonPicker.me.ginele.myName);
    }

    void DoJob (CharacterInfo.Occupation job) {
        if (job == CharacterInfo.Occupation.graveDigger) {
            //DigGrave();
        } else if (job == CharacterInfo.Occupation.professor) {
            //Teach();
        }

        switch (job) {
            case CharacterInfo.Occupation.professor:
                //Teach()
                break;
            case CharacterInfo.Occupation.graveDigger:
                //PlaceTombStone();
            case CharacterInfo.Occupation.holeDigger:
                //DigHole();
                break;
        }

    } 

}
