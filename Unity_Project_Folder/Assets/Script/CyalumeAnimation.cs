using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CyalumeAnimation : MonoBehaviour
{
    private float ShakeMax = 80.0f;
    private float ShakeMin = 10.0f;
    private float Speed = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        transform.DOLocalRotate(new Vector3(ShakeMax, 0, 0f), Speed,
                                RotateMode.FastBeyond360).OnComplete(CyalumeUpComplete);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void CyalumeUpComplete()
    {
        Debug.Log("CyalumeUp:COMPLETED");

        Vector3 eulerAngles = transform.eulerAngles;
        eulerAngles.x = ShakeMax;
        transform.eulerAngles = eulerAngles;

        transform.DOLocalRotate(new Vector3(ShakeMin, 0, 0f), Speed,
                                RotateMode.FastBeyond360).OnComplete(CyalumeDownComplete);
    }

    private void CyalumeDownComplete()
    {
        Debug.Log("CyalumeUp:COMPLETED");

        Vector3 eulerAngles = transform.eulerAngles;
        eulerAngles.x = ShakeMin;
        transform.eulerAngles = eulerAngles;

        transform.DOLocalRotate(new Vector3(ShakeMax, 0, 0f), Speed,
                                RotateMode.FastBeyond360).OnComplete(CyalumeUpComplete);
    }
}
