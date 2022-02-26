using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    [SerializeField] AudioSource source;
    [SerializeField] AudioSource ambience;
    [SerializeField] AudioClip intro;
    [SerializeField] AudioClip full;
    [SerializeField] AudioClip loop;
 
    private void Awake(){
        Invoke(nameof(LoopMusic), source.clip.length);
    }
    public void StartGame()
    {
        CancelInvoke();
        source.clip = full;
        source.Play();
        Invoke(nameof(LoopMusic), source.clip.length);
        ambience.Play();
    }
    public void StopGame()
    {
        CancelInvoke();
        ambience.Stop();
        source.clip = intro;
        source.Play();
        Invoke(nameof(LoopMusic), source.clip.length);
    }
    void LoopMusic(){
        source.clip = loop;
        source.loop = true;
        source.Play();
    }
}
