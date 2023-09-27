using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public GameObject instance;
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
                //Instantiate(instance, touchPosition, new Quaternion(0, 0, 0, 0));
                Collider[] colliders = Physics.OverlapSphere(touchPosition, 1); 
                foreach (Collider collider in colliders) 
                {
                    collider.gameObject.GetComponent<InteractableObject>()?.Interact();
                }
            }
        }
    }
}
