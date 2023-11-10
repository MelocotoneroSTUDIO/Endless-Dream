using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{

    [SerializeField] Transform rotationPivot;

    public float currentAngle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         
    }


    public void SetRotation(float angle)
    {
        rotationPivot.eulerAngles = Vector3.up * angle;
    }
}
