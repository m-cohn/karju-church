using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    [SerializeField] private FirstPerson player;
    [SerializeField] private Slider speedSlider;
    [SerializeField] private Slider sensSlider;
    [SerializeField] private Toggle invert;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        speedSlider.onValueChanged.AddListener(delegate { SpeedChanged(); });
        sensSlider.onValueChanged.AddListener(delegate { SensitivityChanged(); });
        invert.onValueChanged.AddListener(delegate { InvertToggled(); });
    }

    private void SpeedChanged()
    {
        player.SetSpeed(speedSlider.value);
    }

    private void SensitivityChanged()
    {
        player.SetSensitivity(sensSlider.value);
    }

    private void InvertToggled()
    {
        player.SetInvert(invert.isOn);
    }
}
