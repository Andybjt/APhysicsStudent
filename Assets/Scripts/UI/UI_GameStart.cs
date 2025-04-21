using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class UI_GameStart : MonoBehaviour
{
    public Button btn_option;
    public Button btn_start;
    public Transform title;
    public Transform teacher;
    public Transform student;
    public Transform mate;
    

    public void Init()
    {
        this.gameObject.SetActive(true);


        btn_start.onClick.AddListener(()=>
        {
            this.gameObject.SetActive(false);
        });

        btn_option.onClick.AddListener(() =>
        {

        });

        AnimShow();
    }

    public void AnimShow() 
    {
        DOTween.Sequence()
            .AppendInterval(1.5f)
            .Append(teacher.DOLocalMoveX(-334, 0.8f))
            .Append(mate.DOLocalMoveY(-77, 0.2f));
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
