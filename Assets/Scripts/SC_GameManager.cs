using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_GameManager : MonoBehaviour
{
    [SerializeField] GameObject circle;
    [SerializeField] GameObject ex;

    [SerializeField] Vector3 leftup;
    //[SerializeField] Transform parentTransform;
/*
    void Update () 
    {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);

            if(touch.phase == TouchPhase.Began)
            {
                Instantiate(circle, touchPos, Quaternion.identity);
                
            }
        }
    }
*/
    void Press(Vector3 leftup)
    {
        Instantiate(circle, leftup, Quaternion.identity);
    }
}
