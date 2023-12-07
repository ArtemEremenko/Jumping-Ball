using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerForWin : MonoBehaviour
{
    [SerializeField] private TMP_Text _timerText;

    [SerializeField] private Player _player;

    private float _countdownTimer = 3;

    private void Update()
    {
        _countdownTimer -= Time.deltaTime;
        
        _timerText.text = _countdownTimer.ToString("0");
    
        if (_countdownTimer <= 0)
        {
            _player.Win();
            gameObject.SetActive(false);
        }
    }

    public void StartWinTimer()
    {
        gameObject.SetActive(true);
    }
    public void ResetTimer()
    {
        _countdownTimer = 3;
        gameObject.SetActive(false);
    }
}
