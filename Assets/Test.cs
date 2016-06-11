using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour
{
    public GameObject test1;
    public GameObject test2;
    public GameObject test3;

    // Use this for initialization
    void Start ()
    {
        Debug.Log("世界坐标:");
        Debug.Log(test1.transform.position);
        Debug.Log(test2.transform.position);
        Debug.Log(test3.transform.position);

        Debug.Log("本地坐标:");
        Debug.Log(test1.transform.localPosition);
        Debug.Log(test2.transform.localPosition);
        Debug.Log(test3.transform.localPosition);
    }

    // Update is called once per frame
    void Update ()
    {
	
	}
}
