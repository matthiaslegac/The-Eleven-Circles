using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackGhost : MonoBehaviour
{
    
    public bool isZone = false;
    public Animator animator;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            isZone = true;
            animator.SetBool("Dedans", isZone);
        }
    }
}
