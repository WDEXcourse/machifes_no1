using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//textとかいじるときにかくやつ
using UnityEngine.UI;
//シーン遷移させるときにかくやつ
using UnityEngine.SceneManagement;

public class ResultScript : MonoBehaviour {

    public TreasureCountScript tcSctipt;
    public CountDownTimer CDTscript;
    public GameObject player;
    public Text timer;

    private bool timeOver;
    private int treasure;
    public Text result;

    // Use this for initialization
    void Start()
    {
        player = GameObject.Find("Player");
        CDTscript = timer.GetComponent<CountDownTimer>();
        tcSctipt = player.GetComponent<TreasureCountScript>();

        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(false);
        }

    }

    // Update is called once per frame
    void Update()
    {
        treasure = tcSctipt.treasure;
        timeOver = CDTscript.timeOver;

        if(timeOver == true)
        {
            foreach (Transform child in transform)
            {
                child.gameObject.SetActive(true);
            }

            if (Input.GetKey(KeyCode.Alpha1))
            {
                SceneManager.LoadScene("Start");
            }

            if (treasure == 0)
            {

                result.text = ("0こゲット！");

            } else if(treasure <= 1){

                result.text = ("1こゲット！");

            } else if(treasure <= 2){

                result.text = ("2こゲット！");

            } else if(treasure <= 3){

                result.text = ("3こゲット！");

            } else if(treasure <= 4){

                result.text = ("4こゲット！");
                
            } else if(treasure <= 5){

                result.text = ("5こゲット！");
                
            }
            else
            {
                result.text = ("6こ以上ゲット！");
            }
        }
    }
}
