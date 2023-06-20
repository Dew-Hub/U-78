using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animeventforAsansor : MonoBehaviour
{
    public ParticleSystem[] particleSystemsToControl;
    public CinemachineVirtualCamera yCamera;
    private void Start()
    {
        foreach (ParticleSystem particleSystem in particleSystemsToControl)
        {
            particleSystem.Stop();
        }
    }

    private void StartParticleSystems()
    {
        foreach (ParticleSystem particleSystem in particleSystemsToControl)
        {
            particleSystem.Play();
            yCamera.Priority = 11;
        }
    }

    public void StopParticleSystems()
    {
        foreach (ParticleSystem particleSystem in particleSystemsToControl)
        {
            particleSystem.Stop();
            yCamera.Priority = 0;
        }
    }
}
