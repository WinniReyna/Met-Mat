using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    private int timer = 0;
    public void Start()
    {
        timer = 0;
        StartCoroutine(time());
    }
    public void Update()
    {
        if (timer >= 180)   Debug.Log("finish");

        if (ProceduralOpenDoors_one.openDoor_1 == true && 
                ProceduralOpenDoors_two.openDoor_2 == true &&
                    ProceduralOpenDoors_three.openDoor_3 && true)
        {
            SceneManager.LoadScene("7Fusion");
        }
    }
    IEnumerator time()
    {
        while (true)
        {
            timeCount();
            yield return new WaitForSeconds(1);
        }
    }
    void timeCount()
    {
        timer += 1;
    }
}
