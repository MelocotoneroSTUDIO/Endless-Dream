using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDraggingObject : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.transform.parent = transform;
    }

    private void OnTriggerExit(Collider other)
    {
        other.gameObject.transform.parent = null;
    }
}
