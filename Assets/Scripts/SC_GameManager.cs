using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_GameManager : MonoBehaviour
{
    [SerializeField] GameObject circle;
    [SerializeField] GameObject ex;
    //[SerializeField] Transform parentTransform;

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
}
