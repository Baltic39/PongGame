using UnityEngine;
using UnityEngine.Audio;

public class Settings : MonoBehaviour
{
    private bool isFullScreen;
    public AudioMixer am;

    public void FullScreenToggle()
    {
        isFullScreen = !isFullScreen;
        Screen.fullScreen = isFullScreen;
    }

    //связываем значение слайдера с громкостью музыки
    public void AudioVolume(float sliderValue)
    {
        am.SetFloat("MasterVolume", sliderValue);
    }

    //передаём значение графики 
    public void Quality(int q)
    {
        QualitySettings.SetQualityLevel(q);
    }
}
