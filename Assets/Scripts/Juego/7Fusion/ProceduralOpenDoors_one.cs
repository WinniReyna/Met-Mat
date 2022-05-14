using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProceduralOpenDoors_one : MonoBehaviour
{
    [SerializeField] private GameObject Door;
    [SerializeField] private GameObject fire;
    public static bool openDoor_1 = false;
    private void Start()
    {
        openDoor_1 = false;
    }
    void Update()
    {        
        if (openDoor_1)
        {
            Door.SetActive(false);
            fire.SetActive(true);
            StopAllCoroutines();
        }
        else
        {
            Door.SetActive(true);
            fire.SetActive(false);
            StartCoroutine(SetBoolTrue(Random.Range(3.0f, 5.0f)));
        }
    }
    IEnumerator SetBoolTrue(float time)
    {
        yield return new WaitForSeconds(time);
        openDoor_1 = true;
    }
    void OnMouseDown()
    {
        if (gameObject.tag == "Door")
        {
            openDoor_1 = false;
        }
    }
}
