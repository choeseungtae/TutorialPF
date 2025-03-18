using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBox : MonoBehaviour
{
    public GameObject CoinPrefab;

    public bool isActivate = true;

    
    SpriteRenderer _sr;
    public Sprite unActivateBoxSpriteRenderer;

    private void Start()
    {
        _sr = GetComponentInParent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isActivate)
        {
            

            isActivate = false;

            Debug.Log("�����ڽ��� �浹 �߾��.");

            

            Instantiate(CoinPrefab, transform.position, Quaternion.identity);

            _sr.sprite = unActivateBoxSpriteRenderer;

            SoundManager.Instance?.PlaySFX("Coin");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("�����ڽ� ���������.");
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("�����ڽ��� �浹 ���̿���");
    }
}
