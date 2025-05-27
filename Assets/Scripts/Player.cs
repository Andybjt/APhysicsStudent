using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5;         //This is the best value fot the speed.
    public float jumpForce;
    public Animator animator;
    public bool isGround;
    public Rigidbody2D rb;

    public void Init()
    {
        Hide();
    }
    public void Show()
    {
        this.gameObject.SetActive(true);
    }
    public void Hide()
    {
        this.gameObject.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Move the character.
        animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));

        var horizontalValue = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position = transform.position + horizontalValue * Time.deltaTime * speed;

        //Jump
        CheckGround();

        animator.SetFloat("Jump", Input.GetAxis("Jump"));

        if (isGround && Input.GetButtonDown("Jump"))
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    private void CheckGround()
    {
        Collider2D collider = Physics2D.OverlapBox(transform.position, new Vector2(0.5f, 0.3f), 0, LayerMask.GetMask("Ground"));
        if (collider != null)
        {
            isGround = true;
        }
        else
        {
            isGround = false;
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawCube(transform.position, new Vector2(0.5f, 0.1f));
        Gizmos.color = Color.red;
    }
}
