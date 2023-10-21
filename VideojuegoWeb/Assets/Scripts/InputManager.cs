using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    //Class that handles screen touches or clicks and checks for interactable objects on that position
    Vector3 touchPosition;
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit)) 
            {
                touchPosition = hit.point;
                Collider[] colliders = Physics.OverlapSphere(touchPosition, 0.1f); 
                foreach (Collider collider in colliders) 
                {
                    collider.gameObject.GetComponent<InteractableObject>()?.Interact();
                }
            }
        }
    }
}
