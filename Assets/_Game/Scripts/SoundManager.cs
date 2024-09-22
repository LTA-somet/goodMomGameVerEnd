using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum TypeSound
{
   GoodImpact,
   BadImpact,
   Win,
   bg

}
public class SoundManager : MonoBehaviour
{


    public AudioSource bg, fx;
    public List<AudioPack> lstAudioPack = new List<AudioPack>();

    public AudioPack GetAudioPack(TypeSound typeSound)
    {
        for (int i = 0; i < lstAudioPack.Count; i++)
        {
            if (lstAudioPack[i].typeSound == typeSound)
            {
                return lstAudioPack[i];
            }
        }
        return null;
    }
    public void PlaySoundFX(TypeSound type)
    {
        fx.PlayOneShot(GetAudioPack(type).clip, GetAudioPack(type).volume);
    }
}
[Serializable]
public class AudioPack
{
    public TypeSound typeSound;
    public AudioClip clip;
    [Range(0, 1)]
    public float volume = 0.5f;

}
