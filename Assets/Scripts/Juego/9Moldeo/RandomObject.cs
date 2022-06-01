using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObject : MonoBehaviour
{
    [SerializeField] private GameObject[] mold;
    int randomNumber;

    private void Start()
    {
        randomNumber = Random.Range(0, 3);
    }

    void Update()
    {
        switch (randomNumber)
        {
            case 0:                
                mold[0].SetActive(true);
                mold[1].SetActive(false);
                mold[2].SetActive(false);
                StartCoroutine("RandomNumber");
                break;
            case 1:
                mold[0].SetActive(false);
                mold[1].SetActive(true);
                mold[2].SetActive(false);
                StartCoroutine("RandomNumber");
                break;
            case 2:
                mold[0].SetActive(false);
                mold[1].SetActive(false);
                mold[2].SetActive(true);
                StartCoroutine("RandomNumber");
                break;
        }
    }

    IEnumerator RandomNumber()
    {        
        yield return new WaitForSeconds(5.8f);
        randomNumber = Random.Range(0, 3);
        StopAllCoroutines();
    }
}
