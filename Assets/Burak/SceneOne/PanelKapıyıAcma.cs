using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelKapıyıAcma : MonoBehaviour
{

    public ParticleSystem[] particleSystemsToControl;

    public Animator doorAnim;
    public JenKapıyıAcma jenscript;
    public bool bozuk = false;
    public bool acilsusamacil = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (acilsusamacil)
            {
                doorAnim.SetTrigger("ikinciacılıs");
                return;
            }

            doorAnim.SetTrigger("ilkacılıs");
            bozuk = true;
        }
    }
}
