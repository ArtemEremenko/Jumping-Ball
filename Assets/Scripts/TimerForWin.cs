using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerForWin : MonoBehaviour
{
    [SerializeField] private TMP_Text _timerText;

    [SerializeField] private Player _player;

    private float _countdownTimer = 4;

    private bool _isTimerStarted = false;

    private void Awake()
    {
        gameObject.SetActive(false);
    }

    private void Update()
    {
        if (_isTimerStarted)
        {
            _countdownTimer -= Time.deltaTime;
            //int minutes = Mathf.FloorToInt(_countdownTimer / 60);
            _countdownTimer = Mathf.Max(0, _countdownTimer);

            int seconds = Mathf.FloorToInt(_countdownTimer % 60);
            //_timerText.text = _countdownTimer.ToString();
            _timerText.text = string.Format("{0}", seconds);
        
            if (_countdownTimer <= 0)
            {
                _player.Win();
                gameObject.SetActive(false);
            }
        }
    }

    public void StartWinTimer()
    {
        gameObject.SetActive(true);
        _isTimerStarted = true;
    }
    public void ResetTimer()
    {
        Debug.Log("Reset please");
        _countdownTimer = 4;
        _isTimerStarted = false;
        gameObject.SetActive(false);
    }
}
