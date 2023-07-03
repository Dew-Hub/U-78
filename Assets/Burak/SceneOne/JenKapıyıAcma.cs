using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JenKapıyıAcma : MonoBehaviour
{

    public PanelKapıyıAcma panelscript;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if(panelscript.bozuk)
            {
                panelscript.acilsusamacil = true;
            }
        }
    }
}
