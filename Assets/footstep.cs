using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class footstep : MonoBehaviour
{
    public AudioClip[] footstepSounds;
    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayFootstepSound()
    {
        if (footstepSounds.Length == 0)
            return;

        int randomIndex = Random.Range(0, footstepSounds.Length);
        audioSource.clip = footstepSounds[randomIndex];
        audioSource.Play();
    }
}
