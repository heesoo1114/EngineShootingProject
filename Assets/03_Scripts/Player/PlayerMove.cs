using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{

    public StageData StageData;
    
    public LayerMask groundLayerMask;
    public float speed = 5f;

    Rigidbody2D rigid;
    //private BoxCollider2D collider;
    Vector2 pos;
    [SerializeField] Transform dir; //좌우반전
    Animator anim;

    //bool isGround = false;

    private void Start()
    {
        //collider = GetComponent<BoxCollider2D>();
        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        
    }

    private void Update()
    {
        Move();

        // 좌우반전
        float dir = Input.GetAxis("Horizontal");
        if (dir < 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else if (dir > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }

        // 애니메이션 Run, Idle
        if (Mathf.Abs(dir) > 0.4)
        {
            anim.SetBool("isWalking", true);
        }
        else
        {
            anim.SetBool("isWalking", false);
        }
    }

    private void LateUpdate()
    {
        // 이동제한
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, StageData.LimitMin.x, StageData.LimitMax.x),
                                         Mathf.Clamp(transform.position.y, StageData.LimitMin.y, StageData.LimitMax.y));
    }

    private void Move()
    {
        float x = Input.GetAxisRaw("Horizontal");

        transform.position += new Vector3(x, 0, 0) * speed * Time.deltaTime;
    }

    public void Die()
    {
        anim.SetBool("isDeath", true);
        SceneManager.LoadScene("GameOver");
    }
}
