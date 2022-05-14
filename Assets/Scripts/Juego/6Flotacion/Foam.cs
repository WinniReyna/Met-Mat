using UnityEngine;

public class Foam : MonoBehaviour
{
    [SerializeField] private SpriteRenderer foamSprite;
    [SerializeField] private float speed = 0;
    [SerializeField] private GameObject tubeRight;
    [SerializeField] private GameObject tubeLeft;
    [SerializeField] private GameObject box1;
    [SerializeField] private GameObject box2;
    [SerializeField] private GameObject box3;
    [SerializeField] private Animator fan;

    private bool clickedBtn = false;

    public void BtnFoam()
    {
        speed += 0.15f;
        clickedBtn = true;
        
    }
    void Start()
    {
        box2.SetActive(false);
        box3.SetActive(false);

        foamSprite = gameObject.GetComponent<SpriteRenderer>();
        fan.GetComponent<Animator>().enabled = false;
    }

    void Update()
    {
        clickedBtn = false;
        if (!clickedBtn)
        {
            speed -= 0.005f;
        }
        if(speed <= 0)
        {
            speed = 0;
            tubeLeft.SetActive(false);
            tubeRight.SetActive(false);
            fan.GetComponent<Animator>().enabled = false;
        }
        else
        {
            tubeLeft.SetActive(true);
            tubeRight.SetActive(true);
            fan.GetComponent<Animator>().enabled = true;

        }
        foamSprite.color = new Color(1f, 1f, 1f, speed);    

        if(speed >= 3)
        {
            box1.SetActive(false);
            box2.SetActive(true);
        }
        if (speed >= 5)
        {
            box2.SetActive(false);
            box3.SetActive(true);
        }
    }
}
