using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Songs : MonoBehaviour
{
    [SerializeField] private AudioSource classicMineTheme;
    [SerializeField] private AudioSource exchancheTheme;
    [SerializeField] private AudioSource plantTheme;
    [SerializeField] private AudioSource prestigePanelTheme;
    [SerializeField] private AudioSource clickEffect;
    [SerializeField] private AudioSource mineEffect;

    [SerializeField] private Slider masterSld;
    [SerializeField] private Slider musicSld;
    [SerializeField] private Slider sfxSld;

    [SerializeField] private AudioMixerGroup mixer;

    private float vol;

    private void Start()
    {
        classicMineTheme.Play();
    }

    public void ChangeOnExchangeTheme()
    {
        StopAllMusics();
        exchancheTheme.Play();
    }

    public void ChangeOnClassicMineTheme()
    {
        StopAllMusics();
        classicMineTheme.Play();
    }

    public void ChangeOnPlantTheme()
    {
        StopAllMusics();
        plantTheme.Play();
    }

    public void ChangeOnPrestigePanelTheme()
    {
        StopAllMusics();
        prestigePanelTheme.Play();
    }

    public void ClickEffect()
    {
        clickEffect.Play();
    }

    public void MineEffect()
    {
        mineEffect.pitch = Random.Range(0.4f, 2f);
        mineEffect.Play();
    }

    public void ChangeMasterVolume()
    {
        mixer.audioMixer.SetFloat("MasterVolume", masterSld.value);
    }

    public void ChangeMusicVolume()
    {
        mixer.audioMixer.SetFloat("MusicVolume", musicSld.value);
    }

    public void ChangeSFXVolume()
    {
        mixer.audioMixer.SetFloat("SFXVolume", sfxSld.value);
    }

    public void StopAllMusics()
    {
        classicMineTheme.Stop();
        exchancheTheme.Stop();
        plantTheme.Stop();
        prestigePanelTheme.Stop();
    }
}