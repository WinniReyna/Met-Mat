using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProceduralOpenDoors_two : MonoBehaviour
{
    [SerializeField] private GameObject Door;
    [SerializeField] private GameObject fire;
    public static bool openDoor_2 = false;
    private void Start()
    {
        openDoor_2 = false;
    }

    void Update()
    {
        if (openDoor_2)
        {
            Door.SetActive(false);
            fire.SetActive(true);
            StopAllCoroutines();
        }
        else
        {
            Door.SetActive(true);
            fire.SetActive(false);
            StartCoroutine(SetBoolTrue(Random.Range(5.0f, 7.0f)));
        }
    }
    IEnumerator SetBoolTrue(float time)
    {
        yield return new WaitForSeconds(time);
        openDoor_2 = true;
    }
    void OnMouseDown()
    {
        if (gameObject.tag == "Door")
        {
            openDoor_2 = false;
        }
    }
}