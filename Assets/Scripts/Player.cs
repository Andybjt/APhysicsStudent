using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public Animator animator;


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
        animator.SetFloat("Horizontal",Input.GetAxis("Horizontal"));
        animator.SetFloat("Jump", Input.GetAxis("Jump"));

        var horizontalValue = new Vector3(Input.GetAxis("Horizontal"),0f,0f);
        transform.position = transform.position + horizontalValue * Time.deltaTime * speed;


    }
}
