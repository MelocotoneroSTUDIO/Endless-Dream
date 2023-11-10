using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{

    [SerializeField] Transform rotationPivot;

    [SerializeField] float speed;

    Vector3 desiredAngle;
    Vector3 startingAngle;

    float elapsedTime;
    float totalTime;

    public float currentAngle;

    // Start is called before the first frame update
    void Start()
    {
        totalTime = 1;
        desiredAngle = transform.eulerAngles;
        startingAngle = transform.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        rotationPivot.eulerAngles = Vector3.Lerp(startingAngle, desiredAngle, elapsedTime / totalTime);
        elapsedTime += Time.deltaTime;
        if(elapsedTime >= totalTime)
        {
            elapsedTime = totalTime;
        }
    }


    public void SetRotation(float angle)
    {
        desiredAngle = Vector3.up * angle;
        startingAngle = transform.eulerAngles;
        float dif = Mathf.Abs(desiredAngle.y - startingAngle.y);
        totalTime = dif / speed;
        elapsedTime = 0;

    }
}
