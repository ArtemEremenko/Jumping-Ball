using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerGroundChecker : GroundChecker
{
    private bool _isOnGround = false;
    
    public override bool IsOnGround()
    {
        return _isOnGround;
    }

    private void OnTriggerEnter(Collider otherCollider)
    {
        _isOnGround = true;
    }

    private void OnTriggerExit(Collider otherCollider)
    {
        _isOnGround = false;
    }
}
