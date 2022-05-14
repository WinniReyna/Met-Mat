using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    [SerializeField] private GameObject ingot_object;
    [SerializeField] private GameObject[] ingot;

    [SerializeField] private float speed = 0;

    void Start()
    {
        
    }

    void Update()
    {
        ingot_object.transform.position += Vector3.left * (speed / 2) * Time.deltaTime;
    }
}
