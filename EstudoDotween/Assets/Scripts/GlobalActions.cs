using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class GlobalActions : MonoBehaviour

   
{

    public GameObject car;
    public Sprite othercar;
    public Sprite car1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Move()
    {
        car.transform.DOMoveX(5, 2);
    }

    public void Fadecar()
    {
        car.GetComponent<SpriteRenderer>().material.DOFade(0, 2);
    }

    public void restore()
    {
        car.transform.DOMove(new Vector2(0, 0), 0);
        car.GetComponent<SpriteRenderer>().material.DOFade(1, 0);
        car.transform.DORotate(new Vector3(0, 0, 0), 0);
        car.GetComponent<SpriteRenderer>().sprite = car1;


    }

    public void moverotare()
    {
        car.transform.DOMoveX(5, 2);
        car.transform.DORotate(new Vector3(0, 180, 0), 2);
    }

    public void moverotatefinal()
    {
        Sequence mySequence = DOTween.Sequence();
        mySequence.Append(car.transform.DOMoveX(5, 2)).
            Append(car.transform.DORotate(new Vector3(0, 180, 0), 2));
    }

    public void goandreturn()
    {
        car.transform.DOMoveX(5, 1).SetEase(Ease.InOutSine).
            SetLoops(6, LoopType.Yoyo);
    }

    public void movechangeimage()
    {
        car.transform.DOMoveX(5, 2).OnComplete(changeImage);
    }

    public void changeImage()
    {
        car.GetComponent<SpriteRenderer>().sprite = othercar;
    }
}
