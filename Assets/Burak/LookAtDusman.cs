using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtDusman : MonoBehaviour
{
    private Transform target;

    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        // Düşmanın karakterin bulunduğu konuma bakması
        Vector3 lookDirection = target.position - transform.position;
        lookDirection.y = 0f; // Y eksenindeki rotasyonu sıfırla (düşmanın yüksekliğini korur)
        transform.rotation = Quaternion.LookRotation(lookDirection);
    }

}
