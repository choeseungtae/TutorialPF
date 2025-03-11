using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 2.5f;
    public Transform playerStartPosition;
    private Rigidbody2D rigid;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        // 플레이어가 시작할떄 내가 지정한 위치로 이동하라.
        transform.position = playerStartPosition.position;
    }

    // Update is called once per frame
    void Update()
    {
        float moneInput_X = Input.GetAxisRaw("Horizontal");

        rigid.velocity = new Vector2(moneInput_X * moveSpeed, rigid.velocity.y);

        if (Input.GetKey(KeyCode.Space))
        {
            rigid.velocity = new Vector2(rigid.velocity.x, 10);
        }

        // 입력에 맞는 방향을 설정하는 법

        // 캐릭터가 방향

        // 시간 속력 움직인 거리
    }
}
