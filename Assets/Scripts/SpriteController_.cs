using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteController_ : MonoBehaviour
{
    public Animator animator;

    public void ChangeAnimation(string animationTrigger)
    {
        animator.SetTrigger(animationTrigger);
    }
}
