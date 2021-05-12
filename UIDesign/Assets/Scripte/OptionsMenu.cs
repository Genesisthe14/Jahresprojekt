using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    private Slider[] sliderList;
    private GameObject menu;

    // Start is called before the first frame update
    private void Start()
    {
        sliderList = Slider.FindObjectsOfType<Slider>();
        if (sliderList.Length > 0)
        {
            Reset();
        }
        this.gameObject.SetActive(false);
    }

    // Controls the whole volume.
    public void SetTotalVolume(float volume)
    {
        audioMixer.SetFloat("Master", volume);
    }

    //Controls the music.
    public void SetMusicVolume(float volume)
    {
        audioMixer.SetFloat("Musik", volume);
    }

    //Controls the soundeffects
    public void SetSoundeffectsVolume(float volume)
    {
        audioMixer.SetFloat("Effekte", volume);
    }

    //Set all options to its default value
    public void Reset()
    {
        foreach (Slider slider in sliderList)
        {
            float defaultValue = slider.maxValue - (Mathf.Abs(slider.maxValue - slider.minValue) / 2);
            slider.value = defaultValue;
        }
    }

    public void Speichern(GameObject vorher)
    {
        menu = vorher;
        menu.SetActive(false);
    }

    public void Laden()
    {
        menu.SetActive(true);
    }

    public void Kalibrieren()
    {
        Debug.Log("Neu kalibrieren!!");
    }
}
