using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirtyAnimation : MonoBehaviour
{
    [SerializeField] Vector3 rotationVelocity;


    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles += rotationVelocity * Time.deltaTime;
    }
}
