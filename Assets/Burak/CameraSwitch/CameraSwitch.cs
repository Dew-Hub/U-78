using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class CameraSwitch : MonoBehaviour
{
 
    public CinemachineVirtualCamera yCamera; // Hedef kamera (Y kamera)

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Eğer alana "Player" etiketli bir nesne girdiyse
        {
            
            yCamera.Priority = 11; // Y kameranın önceliğini 1 yap
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")) // Eğer alandan "Player" etiketli bir nesne çıktıysa
        {
          
            yCamera.Priority = 0; // Y kameranın önceliğini 0 yap
        }
    }
}
