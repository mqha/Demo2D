﻿using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FlyPathAgent : MonoBehaviour
{
    [SerializeField] public FlyPath flyPath;
    [SerializeField] public float flySpeed;
    private int nextIndex = 1;

    

    private void Update()
    {
        if (flyPath == null)
            return;

        if (nextIndex >= flyPath.wayPoints.Length)
            return;

        if(transform.position != flyPath[nextIndex])
        {
            FlyToNextWayPoint();
            LookAt(flyPath[nextIndex]);
        }
        else
        {
            nextIndex++;
        }
    }

    private void FlyToNextWayPoint() => transform.position = Vector3.MoveTowards(transform.position, flyPath[nextIndex], flySpeed * Time.deltaTime);
    
    private void LookAt(Vector2 destination)
    {
        Vector2 position = transform.position;
        var lookDirection = destination - position;
        if (lookDirection.magnitude < 0.01f)
            return;
        var angle = Vector2.SignedAngle(Vector3.down, lookDirection);
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}