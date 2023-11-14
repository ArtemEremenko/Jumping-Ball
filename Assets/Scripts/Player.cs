using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private TimerForWin _timerForWin;
    private void Update()
    {
        if (transform.position.y > -10)
            return;
        Die();
    }
    public void Win()
    {
        //win game
        Debug.Log("Player are Winner");
    }

    private void Die()
    {
        // player is Dead 
       Debug.Log("Player are dead now");
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("WinTrigger"))
        {
            //RestartLevel();
            _timerForWin.StartWinTimer();
            //Win();
        } 
    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.CompareTag("WinTrigger"))
        {
            _timerForWin.ResetTimer();
        }
        
        if (collider.CompareTag("LevelBoundary"))
        {
            Die();
        }
    }
}

