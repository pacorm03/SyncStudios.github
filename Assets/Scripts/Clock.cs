using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEditor.TerrainTools;
using UnityEngine;

public class Clock : MonoBehaviour
{
    // Singletone.
    public static Clock Instance { get; private set; }

    // Variables.
    [SerializeField] float _bpm;
    float _beatTime;
    event Action _tickEvent;

    // Properties.
    public event Action TickEvent{ add { _tickEvent += value; } remove { _tickEvent -= value; } }

    private void Awake()
    {
        // Singletone.
        if(Instance == null)
        {
            Instance = this;
        }else
        {
            Destroy(gameObject);
        }


        _beatTime = 60f / _bpm;
        InvokeRepeating("Tick", 0, _beatTime);
    }

    private void Tick()
    {
        _tickEvent?.Invoke();
        Debug.Log("Tick");
    }
}
