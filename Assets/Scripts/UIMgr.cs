using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMgr : MonoBehaviour
{
    public static UIMgr I;
    public UI_GameStart ui_GameStart;

   

    void Awake()
    {
        I = this;
        ui_GameStart.Init();

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
