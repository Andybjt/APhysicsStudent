using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMgr : MonoBehaviour
{
    public static GameMgr I;
    public Lvl_01 lvl_01;
    public Lvl_02 lvl_02;
    public Player player;

    private void Awake()
    {
        I = this;

        player.Init();

        lvl_01.Init();
        lvl_02.Init();
        


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
