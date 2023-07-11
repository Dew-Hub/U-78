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
    //private void OnTriggerStay(Collider other)
    //{
    //    if (other.CompareTag("Player"))
    //    {
    //        if (Input.GetKeyDown(KeyCode.E))
    //        {
    //            Debug.Log("E tuşuna basıldı.");
    //            // Burada istediğiniz işlemi yapabilirsiniz.

    //            if (acilsusamacil)
    //            {
    //                doorAnim.SetTrigger("ikinciacılıs");
    //                return;
    //            }

    //            doorAnim.SetTrigger("ilkacılıs");
    //            bozuk = true;
    //        }
    //    }
    //}

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

    private void Update()
    {
        if (isInsideTrigger && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("E tuşuna basıldı.");
            // Burada istediğiniz işlemi yapabilirsiniz.

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
