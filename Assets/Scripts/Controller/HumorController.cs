using UnityEngine;
using System.Collections;
using System;

public class HumorController : MonoBehaviour,IExecute
{
    public void Execute(GameObject obj, string tag)
    {
        GameManager.Instance.Humor -= 10;
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
