using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxCoin : MonoBehaviour
{

    private Rigidbody2D rigid2D;
    public float PopPowr = 2.5f;

    private void Start()
    {
        rigid2D = GetComponent<Rigidbody2D>();
        rigid2D.AddForce(Vector2.up * PopPowr, ForceMode2D.Impulse);

        Invoke(nameof(DisableObject),1.5f);
        Destroy(gameObject, 2f);


    }


    private void DisableObject()
    {
        gameObject.SetActive(false);
    }


}
