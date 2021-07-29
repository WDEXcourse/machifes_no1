using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))//スペースキーがおされたら
        {
            animator.SetBool("jump", true);
            animator.SetBool("walk_f", false);
            animator.SetBool("walk_b", false);       
        }
        else if (Input.GetKey(KeyCode.UpArrow))//上向き矢印キーがおされたら
        {
            animator.SetBool("walk_f", true);
            animator.SetBool("jump", false);
            animator.SetBool("walk_b", false);
        }
        else if (Input.GetKey(KeyCode.DownArrow))//下向き矢印キーがおされたら
        {
            animator.SetBool("walk_b", true);
            animator.SetBool("walk_f", false);
            animator.SetBool("jump", false);
        }else{
            animator.SetBool("jump", false);
            animator.SetBool("walk_f", false);
            animator.SetBool("walk_b", false);
        }
    }
}
