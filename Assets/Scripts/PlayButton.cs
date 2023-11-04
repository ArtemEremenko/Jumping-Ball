using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayButton : MonoBehaviour
{
    [SerializeField] public TMP_Text PlayButtonWasPressed;
    
    public void ButtonPressed()
    {
        PlayButtonWasPressed.text = "Play was pressed";
    }
}
