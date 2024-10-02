using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatInteractor : MonoBehaviour
{
    [SerializeField] BeatManager _beatManager;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(_beatManager.IsOnBeat());
        }
    }
}
