using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProceduralOpenDoors_three : MonoBehaviour
{
    [SerializeField] private GameObject Door;
    [SerializeField] private GameObject fire;
    public static bool openDoor_3 = false;
    private void Start()
    {
        openDoor_3 = false;
    }
    void Update()
    {
        if (openDoor_3)
        {
            Door.SetActive(false);
            fire.SetActive(true);
            StopAllCoroutines();
        }
        else
        {
            Door.SetActive(true);
            fire.SetActive(false);
            StartCoroutine(SetBoolTrue(Random.Range(4.0f, 8.0f)));
        }
    }
    IEnumerator SetBoolTrue(float time)
    {
        yield return new WaitForSeconds(time);
        openDoor_3 = true;
    }
    void OnMouseDown()
    {
        if (gameObject.tag == "Door")
        {
            openDoor_3 = false;
        }
    }
}
