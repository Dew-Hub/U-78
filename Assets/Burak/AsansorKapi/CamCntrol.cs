using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamCntrol : MonoBehaviour
{
    public CinemachineVirtualCamera yCamera;

    public void EnableCameraStatus()
    {
        yCamera.enabled = true; // Kameranın status kısmını aç
    }

    public void DisableCameraStatus()
    {
        yCamera.enabled = false; // Kameranın status kısmını kapat
    }
}
