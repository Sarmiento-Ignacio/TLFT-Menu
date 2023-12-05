using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class MainPanel : MonoBehaviour
{
    [Header("Options")]
    public Slider volumeFX; 
    public Slider volumeMaster;
    public AudioMixer mixer;
    public AudioSource fxSource;
    public AudioClip clickSound;

    [Header("Panels")]
    public GameObject mainPanel;
    public GameObject optionsPanel;

    
    private void Awake()
    {
        volumeFX.onValueChanged.AddListener(ChangevolumeFX);
        volumeMaster.onValueChanged.AddListener(ChangevolumeMaster);
    }

    public void OpenPanel( GameObject panel)
    {
        mainPanel.SetActive(false);
        optionsPanel.SetActive(false);


        panel.SetActive(true);
        playSoundButton();
    }   

    public void ChangevolumeMaster(float v) 
    {
        mixer.SetFloat("VolMaster", v);
    }
    public void ChangevolumeFX(float v)
    {
        mixer.SetFloat("VolFX", v);
    }
    public void playSoundButton()
    {
        fxSource.PlayOneShot(clickSound);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
