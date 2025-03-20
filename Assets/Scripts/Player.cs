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
        // 플레이어가 시작할떄 내가 지정한 위치로 이동하라.
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

    // 입력에 맞는 방향을 설정하는 법

    // 캐릭터가 방향

    // 시간 속력 움직인 거

    void CreateDust()
    {
        dust.Play();
    }
}
