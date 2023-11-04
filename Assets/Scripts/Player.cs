using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour

{
    private void Win()
    {
        //win game
        Debug.Log("Player are Winner");
    }

    private void Die()
    {
        // player is Dead 
       Debug.Log("Player are dead now");
    }
    private void OnTriggerEnter(Collider collider)
    {
        if(collider.GetComponent<TargetForWin>() != null)
        {
            Win();
        } 

    }
}

