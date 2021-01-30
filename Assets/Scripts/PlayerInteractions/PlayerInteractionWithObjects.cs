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

    private PlayerInput _playerInput;

    private bool _pulse = false;

    private PlayerInformation _playerInformation;

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

        _playerInput = FindObjectOfType<PlayerInput>();

        _playerInformation = GetComponent<PlayerInformation>();

    }

    //Interactúa directamente con los objetos que tiene dentro del radio de acción
    public void Interact()
    {
        List<Rigidbody> auxList = new List<Rigidbody>();

        foreach (Rigidbody rb in _interacionSphere.GetInteractuableObjects())
        {

            if (rb)
            {
                //Darle la vuelta al rb y transform para que los atraiga en lugar de repelerlos
                rb.AddForce((rb.transform.position - transform.position).normalized * _interactionForce);
            }

            else
            {
                auxList.Add(rb);
            }
        }

        foreach(Rigidbody rb in auxList)
            _interacionSphere.RemoveItem(rb);

    }


    public void Update()
    {
        _pulse = false;

        if (_playerInformation._myPlayerNumber == myPlayerNumber.Player1)
        {
            _pulse = _playerInput._player1Pulse;
        }
        else
        {
            _pulse = _playerInput._player2Pulse;
        }

        if (_pulse && _canInteract)
        {
            _currentInteractionCounter += Time.deltaTime;

            if (_currentInteractionCounter >= _interactionCounter)
            {
                _currentInteractionCounter = 0;
                _canInteract = false;
                Interact();
            }
        }

        else if (!_pulse)
        {
            _currentInteractionCounter = 0;
            _canInteract = true;
        }

    }
}
