using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animeventforAsansor : MonoBehaviour
{
    public ParticleSystem[] particleSystemsToControl;

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
        }
    }

    public void StopParticleSystems()
    {
        foreach (ParticleSystem particleSystem in particleSystemsToControl)
        {
            particleSystem.Stop();
        }
    }
}
