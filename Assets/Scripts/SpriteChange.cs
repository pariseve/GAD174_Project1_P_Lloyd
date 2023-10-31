using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewSpriteChange", menuName = "Data/New Sprite Change")]
[System.Serializable]
public class SpriteChange : ScriptableObject
{
    // Define the properties of the SpriteChange class, e.g., which speaker, expression, and animation trigger to use.
    public Speaker speaker;
    public int expression;
    public string animationTrigger;
}
