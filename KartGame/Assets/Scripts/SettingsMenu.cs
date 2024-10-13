using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;
using TMPro;

public class SettingsMenu : MonoBehaviour
{
    public static SettingsMenu instance;

    public Slider musicVolumeSlider, effectVolumeSlider;
    public Toggle fullscreenToggle;
    public TMP_Dropdown resolutionDropdown;

    public AudioSource music;

    Resolution[] resolutions;
    AudioSource[] effectAudios;

    public void Awake()
    {
        instance = this;
    }

    public void Start()
    {
        //storing all available resolutions in array and adding them to the dropdown of available resolutions to chose from
        resolutions = Screen.resolutions;

        resolutionDropdown.ClearOptions();

        List<string> options = new List<string>();

        int currentResolutionIndex = 0;
        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);

            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
                currentResolutionIndex = i;
        }

        resolutionDropdown.AddOptions(options);
        if (Settings.resIndex == 0) Settings.resIndex = currentResolutionIndex;

        LoadGraphics();

        StartCoroutine(LateStart(0.1f));
    }

    IEnumerator LateStart(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        //Gettting all AudioSources with tag "EffectAudio"
        GameObject[] eAGameObjects = GameObject.FindGameObjectsWithTag("EffectAudio");
        effectAudios = new AudioSource[eAGameObjects.Length];
        for (int i = 0; i < eAGameObjects.Length; i++)
        {
            effectAudios[i] = eAGameObjects[i].GetComponent<AudioSource>();
        }

        //Loading Audio Settings
        LoadAudio();
    }


    //Loading pre-saved settings after scene change, ... (Another possibility would be to keep the object instead of destroying it after scene change, however this concept would be less flexible)
    public void LoadSettings()
    {
        SetMusicVolume(Settings.musicVolume);
        musicVolumeSlider.value = Settings.musicVolume;
        SetEffectVolume(Settings.effectVolume);
        effectVolumeSlider.value = Settings.effectVolume;
        SetResolution(Settings.resIndex);
        resolutionDropdown.value = Settings.resIndex;
        resolutionDropdown.RefreshShownValue();
        SetFullscreen(Settings.fullscreen);
        fullscreenToggle.isOn = Settings.fullscreen;
    }

    public void LoadGraphics()
    {
        SetResolution(Settings.resIndex);
        resolutionDropdown.value = Settings.resIndex;
        resolutionDropdown.RefreshShownValue();
        SetFullscreen(Settings.fullscreen);
        fullscreenToggle.isOn = Settings.fullscreen;
    }

    public void LoadAudio()
    {
        SetMusicVolume(Settings.musicVolume);
        musicVolumeSlider.value = Settings.musicVolume;
        SetEffectVolume(Settings.effectVolume);
        effectVolumeSlider.value = Settings.effectVolume;
    }

    public void SetMusicVolume(float volume)
    {
        music.volume = volume;
        Settings.musicVolume = volume;
    }

    public void SetEffectVolume(float volume)
    {
        for (int i = 0; i < effectAudios.Length; i++)
        {
            effectAudios[i].volume = volume;
        }
        Settings.effectVolume = volume;
    }

    public void SetResolution(int index)
    {
        Resolution resolution = resolutions[index];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
        Settings.resIndex = index;
    }

    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
        Settings.fullscreen = isFullscreen;
    }
}
