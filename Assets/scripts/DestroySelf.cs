using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DestroySelf : MonoBehaviour
{
    public float targetTime = 10.0f;

void Update(){

targetTime -= Time.deltaTime;

if (targetTime <= 0.0f)
{
   Destroy(gameObject);
}

}
}