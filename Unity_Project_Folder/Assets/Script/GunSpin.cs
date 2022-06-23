using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunSpin : MonoBehaviour
{
    Transform target;
    [SerializeField]
	float speed = 1000.0f;

    bool flag = true;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && flag)
        {
            OneRotation();
            flag = false;
        }
    }

/*

    無限に回転させる

*/
    private void InfiniteRotate()
    {
        transform.Rotate(0,0,speed * Time.deltaTime);
    }

/*

    1回だけ回転させる

*/
    private void OneRotation()
    {
        transform.DOLocalRotate(new Vector3(0, 0, 360f), 1f,
                RotateMode.FastBeyond360).OnComplete(RotateComplete);
    }

/*

    DOTweenのOnCompleteの時に呼び出される

*/
    private void RotateComplete()
    {
        Debug.Log("銃1回転：終了");
        transform.eulerAngles = new Vector3(0.0f,0.0f,0.0f);
        flag = true;
    }
}