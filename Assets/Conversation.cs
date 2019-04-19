using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class Conversation : ScriptableObject {
    public CharacterInfo character1;
    public CharacterInfo character2;

}

[System.Serializable]
public struct CharacterInfo {
    public string name;
    public bool bearded;
    public enum Occupation {
        miner,
        gameDesigner,
        professor,
        student,
        graveDigger,
        holeDigger
    }
    public Occupation job;


}
