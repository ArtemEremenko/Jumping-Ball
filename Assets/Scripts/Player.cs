using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private TMP_Text _winText;
    [SerializeField] private TMP_Text _loseText;
    [SerializeField] private TimerForWin _timerForWin;
    [SerializeField] private RestartButton _restartButton;
    [SerializeField] private MenuButton _menuButton;

    private void Update()
    {
        if (transform.position.y > -10)
            return;
        Die();
    }
    public void Win()
    {
        _winText.gameObject.SetActive(true);
        _restartButton.gameObject.SetActive(true);
        _menuButton.gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    private void Die()
    {
        _loseText.gameObject.SetActive(true);
        _restartButton.gameObject.SetActive(true);
        _menuButton.gameObject.SetActive(true);
        Time.timeScale = 0;
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<WinComponent>())
        {
            _timerForWin.StartWinTimer();
        } 
    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.GetComponent<WinComponent>() != null)
        {
            _timerForWin.ResetTimer();
        }
        
        if (collider.CompareTag("LevelBoundary"))
        {
            Die();
        }
    }
}

