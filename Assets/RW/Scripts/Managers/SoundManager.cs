using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    public AudioClip shootClip;
    public AudioClip sheepHitClip;
    public AudioClip sheepDroppedClip;

    private Vector3 cameraPosition;



    void Awake()
    {
        Instance = this;
        cameraPosition = Camera.main.transform.position;
    }

    private void PlaySound(AudioClip clip)
    {
        AudioSource.PlayClipAtPoint(clip, cameraPosition);
    }
    private void PlayShootClip()
        {
        PlaySound(shootClip);
        }
    private void PlaySheepHitClip()
    {
        PlaySound(sheepHitClip);
    }
    private void PlaySheepDroppedClip()
    {
        PlaySound(sheepDroppedClip);
    }
}
