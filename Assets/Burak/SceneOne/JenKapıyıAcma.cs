using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JenKapıyıAcma : MonoBehaviour
{

    public PanelKapıyıAcma panelscript;
    private bool isInsideTrigger = false;

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
    //private void OnTriggerStay(Collider other)
    //{
    //    if (other.CompareTag("Player"))
    //    {
    //        if (Input.GetKeyDown(KeyCode.E))
    //        {
    //            if (panelscript.bozuk)
    //            {
    //                panelscript.acilsusamacil = true;
    //            }
    //        }
    //    }
    //}


    private void Update()
    {
        if (isInsideTrigger && Input.GetKeyDown(KeyCode.E))
        {
            if (panelscript.bozuk)
            {
                panelscript.acilsusamacil = true;
            }
        }
    }
}
