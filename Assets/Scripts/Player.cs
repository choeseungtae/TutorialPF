using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 2.5f;
    public Transform playerStartPosition;
    private Rigidbody2D rigid;

    ParticleSystem dust;


    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        dust = GetComponentInChildren<ParticleSystem>();
    }

    // Start is called before the first frame update
    void Start()
    {
        // �÷��̾ �����ҋ� ���� ������ ��ġ�� �̵��϶�.
        transform.position = playerStartPosition.position;
    }

    // Update is called once per frame
    void Update()
    {
        float moneInput_X = Input.GetAxisRaw("Horizontal");

        rigid.velocity = new Vector2(moneInput_X * moveSpeed, rigid.velocity.y);

        if (Input.GetKey(KeyCode.Space))
        {
            CreateDust();
            rigid.velocity = new Vector2(rigid.velocity.x, 10);
        }

        // �Է¿� �´� ������ �����ϴ� ��

        // ĳ���Ͱ� ����

        // �ð� �ӷ� ������ �Ÿ�
    }

    void CreateDust()
    {
        dust.Play();
    }
}
