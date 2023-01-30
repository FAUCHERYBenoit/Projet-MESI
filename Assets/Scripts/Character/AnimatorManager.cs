using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorManager : MonoBehaviour
{
    [SerializeField] Animator animator;
    private bool isRunning;

    public void StartRunning()
    {
        if (!isRunning)
        {
            isRunning = true;
            animator.SetFloat("Speed", 1);
        }
    }

    public void StopRunnning()
    {
        if (isRunning)
        {
            isRunning = false;
            animator.SetFloat("Speed", 0);
        }
    }

    public void SpecialMovement()
    {
        animator.CrossFade("SpecialMovement", 0.15f);
        animator.SetBool("IsSpecialMotion", true);
        animator.Play("SpecialMovement");
    }

    public void StopSpecialMotion()
    {
        animator.SetBool("IsSpecialMotion", false);
    }
}
