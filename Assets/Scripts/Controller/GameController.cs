using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameController : MonoBehaviour
{
    private List<IExecute> controllerList;
    //public IExecute[] controllerList;

    void Start()
    {
        controllerList = new List<IExecute>();

        for (int i = 0; i < transform.childCount; i++)
        {
            controllerList.Add(transform.GetChild(i).GetComponent<IExecute>());
        }

        Debug.Log(controllerList.Count);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Execute(GameObject obj)
    {
        for (int i = 0; i < controllerList.Count; i++)
        {
            controllerList[i].Execute(obj,obj.tag);
        }
        Test();
    }

    void Test()
    {
        Debug.Log(GameManager.Instance.Hunger);
        Debug.Log(GameManager.Instance.Humor);
        Debug.Log(GameManager.Instance.Coin);
        Debug.Log(GameManager.Instance.Tired);
    }
}
