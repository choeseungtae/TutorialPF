using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 2.5f;
    public Transform playerStartPosition;
    private Rigidbody2D rigid;

    ParticleSystem dust;
    Animator animator;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        dust = GetComponentInChildren<ParticleSystem>();
    }

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        // �÷��̾ �����ҋ� ���� ������ ��ġ�� �̵��϶�.
        transform.position = playerStartPosition.position;
    }

    // Update is called once per frame
    void Update()
    {
        float moneInput_X = Input.GetAxisRaw("Horizontal");

        rigid.velocity = new Vector2(moneInput_X * moveSpeed, rigid.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("jump");
            SoundManager.Instance?.PlaySFX("Jump"); 
            CreateDust(); 
            rigid.velocity = new Vector2(rigid.velocity.x, 20);
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
