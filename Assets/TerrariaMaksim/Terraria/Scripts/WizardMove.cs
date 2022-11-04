using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizardMove : MonoBehaviour
{
    //��������
    public float speed = 1.0f;
    //������ ������
    public float jumpForce = 3.0f;

    private Rigidbody2D rigidbody2D;
    // ���������� ��� ��������
    private SpriteRenderer sprite;

    void Awake()
    {
        //�������� ���������
        rigidbody2D = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    private void Run()
    {
        //����� �����������
        Vector3 direction = transform.right * Input.GetAxis("Horizontal");
        //�������� 
        transform.position = Vector2.MoveTowards(transform.position, transform.position + direction, speed * Time.deltaTime);

        sprite.flipX = direction.x < 0.0f;

      //  animator.SetInteger("State", 1);
    }
    //������
    private void Jump()
    {
        //        animator.SetInteger("State", 2);
        rigidbody2D.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
    }

    private void FixedUpdate()

    {
        //        animator.SetInteger("State", 2);
        if (Input.GetButton("Horizontal"))
        {
            Run();
        }
        if (isGround() && Input.GetButton("Jump"))
        {
            Jump();
        }
    }


    private bool isGround()
    {
        bool ground = false;
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, 0.7f);
        foreach (Collider2D coll in colliders)
        {
            if (coll.gameObject.name == "Tilemap" && colliders.Length == 2)
            {
                ground = true;
            }
        }
        return ground;
    }
}
