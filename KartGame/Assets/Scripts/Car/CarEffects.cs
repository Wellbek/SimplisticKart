using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarEffects : MonoBehaviour
{
    public ParticleSystem[] boostParticles;

    public ParticleSystem[] boostRDYParticles;

    public TrailRenderer[] tireMarks;
    private bool tireMarksFlag;

    public void startEmitter()
    {
        if (tireMarksFlag) return;
        foreach (TrailRenderer T in tireMarks)
            T.emitting = true;

        tireMarksFlag = true;
    }

    public void stopEmitter()
    {
        if (!tireMarksFlag) return;
        foreach (TrailRenderer T in tireMarks)
            T.emitting = false;

        tireMarksFlag = false;
    }

    public void boostRdy()
    {
        for (int i = 0; i < boostParticles.Length; i++)
        {
            if (!boostRDYParticles[i].isPlaying)
                boostRDYParticles[i].Play();
        }
    }

    public void Boost()
    {
        
        for (int i = 0; i < boostParticles.Length; i++)
        {
            boostRDYParticles[i].Stop();
            boostParticles[i].Play();
        }
    }
}
