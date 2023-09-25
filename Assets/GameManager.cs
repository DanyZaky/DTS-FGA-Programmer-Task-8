using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public AudioSource SFX;
    public ParticleSystem VFX;
    void Start()
    {
        SFX.Stop();
        VFX.Stop();
    }

    public void ButtonAction()
    {
        SFX.Play();
        VFX.Play();
    }
}
