using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    private string _levelName;

    private void Start ()
    {
        _levelName = SceneManager.GetActiveScene().name;
    }

    private void RestartLevel()
    {
        SceneManager.LoadScene(_levelName);
    }
}
