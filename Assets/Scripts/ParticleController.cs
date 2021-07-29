using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour
{

    public TreasureCountScript tcSctipt;
    public GameObject player;
    private int treasure;

    // Start is called before the first frame update
    void Start()
    {
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(false);
        }
        tcSctipt = player.GetComponent<TreasureCountScript>();
    }

    // Update is called once per frame
    void Update()
    {
        treasure = tcSctipt.treasure;
        if(treasure == 1){
            foreach (Transform child in transform)
            {
                child.gameObject.SetActive(true);
            }
        }
    }
}
