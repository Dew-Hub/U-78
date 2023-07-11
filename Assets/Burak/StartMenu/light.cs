using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light : MonoBehaviour
{
    public float delay = 1f;

    void Start()
    {
        StartCoroutine(AcKapatIsigi());
    }

    IEnumerator AcKapatIsigi()
    {
        Light lightComponent = GetComponent<Light>();

        while (true)
        {
            lightComponent.enabled = true; // Işığı aç

            yield return new WaitForSeconds(delay); // Belirli bir süre bekle

            lightComponent.enabled = false; // Işığı kapat

            yield return new WaitForSeconds(delay); // Belirli bir süre bekle
        }
    }

}
