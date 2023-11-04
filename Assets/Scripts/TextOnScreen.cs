using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextOnScreen : MonoBehaviour
{
    [SerializeField] private TMP_Text jumpCounterText;
    int jumpCounter = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
        jumpCounter ++;
        jumpCounterText.color = Color.magenta;
        jumpCounterText.text = "Counter " + jumpCounter.ToString();
        }
    }
}
