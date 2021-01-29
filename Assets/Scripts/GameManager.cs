using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //UI
    public Text timerText;

    //Gestión del tiempo
    [Header("Tiempo para Objetivo")]
    public float minutesToGetObjective = 5;
    public float secondsToGetObjective = 1;

    //Random Objectives
    public bool RandomObjectives = false;

    //Props Objetivo
    public List<ObjectiveProp>  _objectiveProps;    //Ahora mismo es de objetivos, pero será de puntos de spawn
    private ObjectiveProp       _currentObjective;  
    private int                 _objectiveIndex;    //Indice en la lista de objetivos en caso de no ser aleatorio

    //Timer en segundos
    private float _currentTimer;


    //Patrón singleton de toda la vida
    public static GameManager instance;


    //Awake is always called before any Start functions
    void Awake()
    {
        //Check if instance already exists
        if (instance == null)
        {
            instance = this;
            SetUp();
            DontDestroyOnLoad(gameObject);
        }
        else if (instance != this)
            Destroy(gameObject);
    }


    void SetUp()
    {
        _objectiveProps = new List<ObjectiveProp>();
        _currentTimer = secondsToGetObjective + (minutesToGetObjective * 60);
    }

    // Update is called once per frame
    void Update()
    {
        //Si no tengo objetivo, selecciono uno
        if (_currentObjective == null) SetNewObjective();
        else
        {
            if (_currentTimer >= 0)
            {
                _currentTimer -= Time.deltaTime;
                int minutes = (int)_currentTimer / 60;              //Get total minutes
                int seconds = (int)_currentTimer - (minutes * 60);  //Get seconds for display alongside minutes
                timerText.text = "TIEMPO: " + minutes.ToString("D2") + ":" + seconds.ToString("D2");      
            }
            else
            {
                OnGameOver();
            }
        }
    }

    public void AddNewObjectiveProp(ObjectiveProp prop)
    {
        _objectiveProps.Add(prop);
        Debug.Log("added a prop: " + prop.name + "\ncount: " + _objectiveProps.Count);
    }

    public void SetNewObjective()
    {
        if (_objectiveProps.Count > 0)
        {
            if (RandomObjectives)
            {
                int rnd = Random.Range(0, _objectiveProps.Count);
                _currentObjective = _objectiveProps[rnd];
            }
            else
            {
                _objectiveIndex++;
                _currentObjective = _objectiveProps[_objectiveIndex];
            }
            _currentObjective.SetAsCurrentObjective();
            Debug.LogWarning("CURRENT OBJECTIVE: " + _currentObjective);
        }
    }

    public void OnObjectiveCollected(ObjectiveProp collectedProp)
    {
        Debug.Log("Objetivo conseguido :)");
        _objectiveProps.Remove(collectedProp);
        _currentObjective = null; //a null porque se pone en el update

        //Sumar tiempo o lo que sea
        _currentTimer += 60;
    }

    public bool IsRandomMode() { return RandomObjectives; }


    /// <summary>
    /// Método que es llamado cuando termina el juego
    /// </summary>
    void OnGameOver()
    {
        Debug.Log("Game over!");
        //Ir al menú de resultados, o lo que sea
    }
}
