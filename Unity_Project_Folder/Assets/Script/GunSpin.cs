using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunSpin : MonoBehaviour
{
    Transform target;
    [SerializeField]
	float speed = 1000.0f;
	float step;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        a();
    }

/*

    無限に回転させる

*/
    private void InfiniteRotate()
    {
        transform.Rotate(0,0,speed * Time.deltaTime);
    }

    private void a()
    {
        transform.DOLocalRotate(new Vector3(0, 0, 360f), speed * Time.deltaTime, RotateMode.FastBeyond360)
    .SetEase(Ease.Linear)
    .SetLoops(-1, LoopType.Restart);
    }
}
