using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 La variable pública _interactionCounter es el tiempo que tiene que mantener el jugador pulsado el botón para interactuar

 El atributo _interactionSpehere es una esfera de interacción, todos los elementos que estén dentro de esta cuando
    el jugador pulse el botón se verán afectados.
 
 Para que todo funcione, los objetos afectados tienen que ser del tipo InteractableObject y tener box collider

 */

public class PlayerInteractionWithObjects : MonoBehaviour
{

    public float _interactionForce = 1;

    [SerializeField]
    private float _interactionCounter = 1f;

    private float _currentInteractionCounter = 0f;

    public GameObject _interactionSpehereObject = null;
    private PlayerSphereInteracion _interacionSphere;

    private bool _canInteract = true;

    private void Start()
    {
        if (!_interactionSpehereObject)
        {
            Debug.LogError("La esfera de interacción del jugador no ha sido asignada.");
            return;
        }

        if(!_interactionSpehereObject.GetComponent<Rigidbody>())
        {
            Debug.LogError("La esfera de interacción no tiene RigidBody");
            return;
        }

        _interactionForce *= 1000;

        _interactionSpehereObject.GetComponent<Collider>().isTrigger = true;
        _interacionSphere = _interactionSpehereObject.AddComponent<PlayerSphereInteracion>();
    }

    //Interactúa directamente con los objetos que tiene dentro del radio de acción
    public void Interact()
    {
        foreach(Rigidbody rb in _interacionSphere.GetInteractuableObjects())
        {
            //Darle la vuelta al rb y transform para que los atraiga en lugar de repelerlos
            rb.AddForce((rb.transform.position - transform.position).normalized  * _interactionForce);
        }
    }


    public void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) && _canInteract)
        {
            _currentInteractionCounter += Time.deltaTime;

            if (_currentInteractionCounter >= _interactionCounter)
            {
                _currentInteractionCounter = 0;
                _canInteract = false;
                Interact();
            }
        }

        else if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            _currentInteractionCounter = 0;
            _canInteract = true;
        }

    }
}
