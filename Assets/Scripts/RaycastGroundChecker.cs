using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastGroundChecker : GroundChecker
{
    public override bool IsOnGround()
    {
        Ray ray = new Ray(transform.position,Vector3.down);
        
        float radius = 0.1f;
        bool hit = Physics.SphereCast(ray, radius, 0.51f, LayerMask.GetMask("Default"));
        //bool hit = Physics.Raycast(ray, 0.51f, LayerMask.GetMask("Default"));

        return hit;
    }
}
