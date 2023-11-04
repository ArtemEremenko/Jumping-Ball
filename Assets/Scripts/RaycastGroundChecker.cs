using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastGroundChecker : GroundChecker
{
    public override bool IsOnGround()
    {
        Ray ray = new Ray(transform.position,Vector3.down);

        bool hit = Physics.Raycast(ray, 0.51f, LayerMask.GetMask("Default"));

        return hit;
    }
}
