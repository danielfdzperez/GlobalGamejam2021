using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSphereInteracion : MonoBehaviour
{
    private List<Rigidbody> _interactuableRB = new List<Rigidbody>();

    private void Start()
    {
        GetComponent<Rigidbody>().isKinematic = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<InteractableObject>())
        {
            _interactuableRB.Add(other.GetComponent<Rigidbody>());
            other.GetComponent<InteractableObject>().ShowObjectInteraction();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<InteractableObject>())
        {
            _interactuableRB.Remove(other.GetComponent<Rigidbody>());
            other.GetComponent<InteractableObject>().HideObjectInteraction();
        }
    }

    public List<Rigidbody> GetInteractuableObjects()
    {
        return _interactuableRB;
    }

}
