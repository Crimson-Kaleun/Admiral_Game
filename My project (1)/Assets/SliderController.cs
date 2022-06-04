using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SliderController : MonoBehaviour
{
    public Slider sliderMusic;
    public Slider sliderSound;
    public float valueMusic;
    public float valueSound;

    public void Start()
    {
        if (!PlayerPrefs.HasKey("valueMusic")) PlayerPrefs.SetFloat("valueMusic", 100);
        if (!PlayerPrefs.HasKey("valueMusic")) PlayerPrefs.SetFloat("valueSound", 100);
        sliderMusic.value = PlayerPrefs.GetFloat("valueMusic");
        sliderSound.value = PlayerPrefs.GetFloat("valueSound");
    }
    public void ChangeMusic(float i) 
    {
        valueMusic = i;
        PlayerPrefs.SetFloat("valueMusic", i);

    }
    public void ChangeSound(float i) 
    {
        valueMusic = i;
        PlayerPrefs.SetFloat("valueSound", i);

    }
}
