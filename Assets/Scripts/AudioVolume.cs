using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;


public class AudioVolume : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;
    public Slider slider;

    void Update()
    {
        audioMixer.SetFloat("MasterVolume", Mathf.Log10(slider.value)*20);
    }
}
