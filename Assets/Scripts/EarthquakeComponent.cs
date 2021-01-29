using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Requerimos el RigidBoy para poder mover el objeto
[RequireComponent(typeof(Rigidbody))]

public class EarthquakeComponent : MonoBehaviour
{

    [Header("Settings")]

    [Tooltip ("Fuerza con la que se mueve el suelo")]
    [Range(0f, 2f)]
    public float shakeForce = 0.5f;

    [Tooltip("Duración total del temblor en segundos")]
    [Range(0f, 2f)]
    public float shakeDuration = 1f;

    [Tooltip("Intervalo entre temblores")]
    public float delayBetweenShakes = 0f;
   

    //PRIVADO
    private float _timer;                                       //Timer interno de la duración de los temblores
    private Vector3 _startPos;                                  //Posición inicial
    private Vector3 _randomPos;                                 //Posición aleatoria que se le va dando al suelo

    //TODO: de qué camara se coge?
    private CameraShakeComponent _cameraShake;

    // Start is called before the first frame update
    void Start()
    {
        _startPos = transform.position;
        _cameraShake = Camera.main.GetComponent<CameraShakeComponent>();
    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(_cameraShake.Shake(2f, 0.10f));
            BeginShake();
        }
    }

    
    //Valida pijadas del editor de Unity
    private void OnValidate()
    {
        if (delayBetweenShakes > shakeDuration)
            delayBetweenShakes = shakeDuration;
    }



    /// <summary>
    /// Hace un shake del objeto al que está asignado mediante la corroutina Shake
    /// </summary>
    public void BeginShake()
    {
        StopAllCoroutines();
        StartCoroutine(Shake());
    }

    /// <summary>
    /// Mueve el objeto colocandolo en una posición aleatoria dentro de un área circular alrededor del centro del objeto que posee este componente.
    /// El temblor continúa durante la duración total establecida.
    /// Si se desean intervalos esos intervalos NO están dentro del tiempo total del movimiento, sino que son independientes.
    /// </summary>
    /// <returns>No devuelve nada</returns>
    private IEnumerator Shake()
    {
        _timer = 0f;
        while (_timer < shakeDuration)
        {
            _timer += Time.deltaTime;
            _randomPos = _startPos + (Random.insideUnitSphere * shakeForce); //Coloco el objeto en una posición aleatoria de un área de tamaño "proporcional a la fuerza"
            transform.position = _randomPos;

            if (delayBetweenShakes > 0f)
            {
                yield return new WaitForSeconds(delayBetweenShakes);
            }
            else
            {
                yield return null;
            }
        }

        //Volvemos a poner el suelo donde estaba
        transform.position = _startPos;
    }

}
