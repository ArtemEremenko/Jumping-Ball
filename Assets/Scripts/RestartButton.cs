using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    private string _levelName;
    
    private void Start ()
    {
        _levelName = SceneManager.GetActiveScene().name;
    }

    public void ButtonPressed()
    {
        SceneManager.LoadScene(_levelName);
        Time.timeScale = 1;
    }
}
