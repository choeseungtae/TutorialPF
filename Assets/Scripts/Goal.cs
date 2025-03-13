using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject ClearInfoObject;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        ClearInfoObject.SetActive(true);

    }

    
}
