using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonbox3 : MonoBehaviour
{
    public asansorscrpt asansor;
    private bool durum = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("box"))
        {
            durum = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("box"))
        {
            durum= false;
        }
    }

    private void Update()
    {
        asansor.box3 = durum;
    }


}
