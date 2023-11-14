using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerPlayTime : MonoBehaviour
{
    [SerializeField] private TMP_Text _globalTimerText;

    private float _playTime;
    void Update()
    {
        _playTime += Time.deltaTime;
        float minutes = Mathf.FloorToInt(_playTime / 60); 
        float seconds = Mathf.FloorToInt(_playTime % 60); 
        _globalTimerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
