using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class celikkapiacilis : MonoBehaviour
{
    public Animator doorAnim;
    private bool isInsideTrigger = false;
    public bool box1 = false;
    public bool box2 = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isInsideTrigger = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isInsideTrigger = false;
        }
    }

    private void Update()
    {
        if (box1 && box2)
            doorAnim.SetBool("AcılB", isInsideTrigger); // "IsOpen" adlı Bool parametresini true yap
    }
}
