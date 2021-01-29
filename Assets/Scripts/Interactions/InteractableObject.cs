using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    [SerializeField]
    private float _objectWeight = 1;

    public GameObject _interactuableObjectHUD = null;

    private void Start()
    {
        if (!GetComponent<Rigidbody>())
            this.gameObject.AddComponent<Rigidbody>();

        _interactuableObjectHUD.SetActive(false);
        gameObject.GetComponent<Rigidbody>().mass = _objectWeight;
    }

    public void ShowObjectInteraction()
    {
        if (_interactuableObjectHUD)
        {
            _interactuableObjectHUD.SetActive(true);
        }
    }

    public void HideObjectInteraction()
    {
        if (_interactuableObjectHUD)
        {
            _interactuableObjectHUD.SetActive(false);
        }
    }
}
