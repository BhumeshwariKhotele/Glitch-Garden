using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsManager : MonoBehaviour
{
    public Slider volumeSlider;
    public Slider difficultySlider;
    private AudioManager audioManager;

    // Start is called before the first frame update
    void Start()
    {
        print(PlayerPrefManager.GetMasterVolume());
        print(PlayerPrefManager.GetDifficulty());
        volumeSlider.value = PlayerPrefManager.GetMasterVolume();
        difficultySlider.value =PlayerPrefManager.GetDifficulty();
        audioManager = GameObject.FindObjectOfType<AudioManager>();
    }

    private void Update()
    {
        audioManager.SetVolume("Background", volumeSlider.value);
    }

    public void SaveAndExit()
    {
        PlayerPrefManager.SetMasterVolume(volumeSlider.value);
        PlayerPrefManager.SetDifficulty(difficultySlider.value);       
    }
    public void SetDefaults()
    {
        volumeSlider.value = 0.5f;
        difficultySlider.value = 0.5f;
    }
}
