using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{

    [SerializeField] Transform rotationPivot;

    [SerializeField] float speed;

    Quaternion desiredRotation;
    Quaternion startingRotation;

    float elapsedTime;
    float totalTime;

    public float currentAngle;

    // Start is called before the first frame update
    void Start()
    {
        totalTime = 1;
        desiredRotation = transform.rotation;
        startingRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        rotationPivot.rotation = Quaternion.Lerp(startingRotation, desiredRotation, elapsedTime / totalTime);
        elapsedTime += Time.deltaTime;
        if(elapsedTime >= totalTime)
        {
            elapsedTime = totalTime;
        }
    }


    public void SetRotation(float angle)
    {
        desiredRotation = Quaternion.Euler(0,angle,0);
        startingRotation = transform.rotation;
        float dif = Quaternion.Angle(desiredRotation, startingRotation);
        totalTime = dif / speed;
        elapsedTime = 0;

    }
}
