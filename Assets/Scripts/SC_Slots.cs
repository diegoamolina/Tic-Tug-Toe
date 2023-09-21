using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SC_Slots : MonoBehaviour
{
    [SerializeField] private GameObject circle;
    [SerializeField] private  Vector3 position;

    public void PressButton(Vector3 position)
    {
        Instantiate(circle, position, Quaternion.identity);
    }
}
