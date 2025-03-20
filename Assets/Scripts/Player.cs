using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 2.5f;
    public Transform playerStartPosition;
    private Rigidbody2D rigid;
    private bool isGrounded = false;
    public bool isActivate = true;

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
        CreateDust();
        float moneInput_X = Input.GetAxisRaw("Horizontal");

        rigid.velocity = new Vector2(moneInput_X * moveSpeed, rigid.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
        }

    } 
    void Jump()
    {
        animator.SetTrigger("jump");
        SoundManager.Instance?.PlaySFX("Jump");
       
        rigid.velocity = new Vector2(rigid.velocity.x, 20);
        isGrounded = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (isActivate)
        {
            isGrounded = true;
        }

    }

    // �Է¿� �´� ������ �����ϴ� ��

    // ĳ���Ͱ� ����

    // �ð� �ӷ� ������ ��

    void CreateDust()
    {
        dust.Play();
    }
}
