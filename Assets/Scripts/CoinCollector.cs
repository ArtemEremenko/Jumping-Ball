using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    [SerializeField] private TMP_Text _coinCounterText;

    private int _coinCounter = 0;

    private void OnTriggerEnter(Collider coinCollision)
    {
        if (!coinCollision.CompareTag("Collectible"))
            return;
        
        Destroy(coinCollision.gameObject);
        
        _coinCounter ++;
        _coinCounterText.color = Color.magenta;
        _coinCounterText.text = "Coin counter " + _coinCounter.ToString();
    }
}
