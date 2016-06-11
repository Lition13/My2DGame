using UnityEngine;
using System.Collections;
using System;

public class HungerController : MonoBehaviour, IExecute
{
    public void Execute(GameObject obj, string tag)
    {
        GameManager.Instance.Hunger -= 10;
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
