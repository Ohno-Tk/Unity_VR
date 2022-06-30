using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunAnimation : MonoBehaviour
{
    [SerializeField] Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("up"))
        {
            anim.SetTrigger("OneRotate");
            //anim.SetBool ( "OneRotate", true );
        }
    }
}
