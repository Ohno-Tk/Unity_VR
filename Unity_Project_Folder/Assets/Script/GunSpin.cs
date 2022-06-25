using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunSpin : MonoBehaviour
{
    [SerializeField]
	float speed = 1000.0f;

    private bool flag = true;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            OneRotate();
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

    private void OneRotate()
    {
        transform.DOLocalRotate(new Vector3(0, 0, 360f), 1f,
                                RotateMode.FastBeyond360).OnComplete(OneRotateComplete);
    }

    private void OneRotateComplete()
    {
        Debug.Log("COMPLETED");

        Vector3 eulerAngles = transform.eulerAngles;
        eulerAngles.z = 0.0f;
        transform.eulerAngles = eulerAngles;

        flag = true;
    }
}
