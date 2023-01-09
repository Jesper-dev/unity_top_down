using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody2D body;

    float hori;
    float verti;
    float moveLimiter = 0.7f;

    public float runSpeed = 10.0f;
    public Vector2 move;
    public float hf = 0.0f;
    public float vf = 0.0f;
    Animator anim;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        hori = Input.GetAxisRaw("Horizontal");
        verti = Input.GetAxisRaw("Vertical");
        move = move.normalized;
    }

    private void FixedUpdate()
    {
        move.x = Input.GetAxisRaw("Horizontal");
        move.y = Input.GetAxisRaw("Vertical");
        body.MovePosition(body.position + move * runSpeed * Time.fixedDeltaTime);

        hf = move.x > 0.01f ? move.x : move.x < -0.01f ? 1 : 0;
        vf = move.y > 0.01f ? move.y : move.y < -0.01f ? 1 : 0;
        if(move.x < 0.01f)
        {
            this.gameObject.transform.localScale = new Vector3(-1, 1, 1);
        } else
        {
            this.gameObject.transform.localScale = new Vector3(1, 1, 1);
        }
        anim.SetFloat("horizontal", hf);
        anim.SetFloat("vertical", move.y);
        anim.SetFloat("speed", vf);


    }

    private void PlayAnim()
    {
       
    }
}
