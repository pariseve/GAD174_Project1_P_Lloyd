using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewSpeaker", menuName = "Data/New Speaker")]
[System.Serializable]
public class Speaker : ScriptableObject
{
    [TextArea(3, 10)]
    public string[] sentences;

    public string characterName;
    public List<Sprite> sprites;
}