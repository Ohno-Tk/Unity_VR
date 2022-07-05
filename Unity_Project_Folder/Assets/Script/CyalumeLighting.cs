using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CyalumeLighting : MonoBehaviour
{
    [SerializeField]
    private GameObject CyalumeCylinder;

    [SerializeField]
    private int ColorNo = 0;

    [SerializeField]
    private Material[] CyalumeMaterial;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log ("サイリウム　カラー番号：" + ColorNo);

        // サイリウム部分 マテリアル変更
        CyalumeCylinder.GetComponent<MeshRenderer>().material = CyalumeMaterial[ColorNo];
    }

/*

    サイリウム色変更

*/
    public void ChangeCyalumeColor(int index)
    {
        CyalumeCylinder.GetComponent<MeshRenderer>().material = CyalumeMaterial[index];
    }
}
