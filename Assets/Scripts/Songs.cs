using UnityEngine;
using UnityEngine.Audio;

public class Songs : MonoBehaviour
{
    [SerializeField] private AudioSource classicMineTheme;
    [SerializeField] private AudioSource specialMineTheme;
    [SerializeField] private AudioSource oldestMineTheme;
    [SerializeField] private AudioSource exchancheTheme;
    [SerializeField] private AudioSource clickEffect;
    [SerializeField] private AudioSource mineEffect;

   public AudioMixerGroup mixer;

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

    public void ClickEffect()
    {
        clickEffect.Play();
    }

    public void MineEffect()
    {
        mineEffect.pitch = Random.Range(0.4f, 2f);
        mineEffect.Play();
    }

    public void ChangeMusicVolume(float volume)
    {
        mixer.audioMixer.SetFloat("MasterVolume", Mathf.Lerp(-10, volume, -80));
    }

    private void StopAllMusics()
    {
        classicMineTheme.Stop();
        exchancheTheme.Stop();
    }
}