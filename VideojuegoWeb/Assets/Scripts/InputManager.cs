using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    Vector3 touchPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
