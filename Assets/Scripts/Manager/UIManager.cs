using UnityEngine;
using System.Collections.Generic;

/*
    理解：
        1.该管理器用了三个主要的函数：ToScreen,GoBack,PlayScreen,
        由于ToScreen和GoBack都带有跳转页面的作用，所以为了减少耦合度，
        用PlayScreen来处理跳转逻辑
*/

public class UIManager : MonoBehaviour {

	public GameObject startScreen;
    /// <summary>
    /// 存放动画事件名称
    /// </summary>
	public string outTrigger;
    /// <summary>
    /// 存储历史页面
    /// </summary>
	private List<GameObject> screenHistory;

    [SerializeField]
    private GameObject preGameObject;

    //private Dictionary<string,GameObject> windowHistory;

    [SerializeField]
    private bool isOpen;

    void Awake(){
        //初始化历史页面
		this.screenHistory = new List<GameObject>{this.startScreen};
        //windowHistory = new Dictionary<string, GameObject>();
        isOpen = true;
        preGameObject = null;
    }

    /// <summary>
    /// 跳转到下一个页面
    /// </summary>
    /// <param name="target">跳转的目标页面</param>
    public void ToScreen(GameObject target){

        //获得目前所在页面
		GameObject current = this.screenHistory[this.screenHistory.Count - 1];

        //判断是否存在下一页，如果下一页不存在，直接返回
		if(target == null || target == current) return;

        //如果存在下一页，
		this.PlayScreen(current , target , false , this.screenHistory.Count);
        //添加下一页到历史页面集合中去
		this.screenHistory.Add(target);
	}

    public void ToWindow(GameObject target)
    {
        PlayWindow(target);
    }

    /// <summary>
    /// 返回上一级页面
    /// </summary>
	public void GoBack(){

		if(this.screenHistory.Count > 1){

			int currentIndex = this.screenHistory.Count - 1;
			this.PlayScreen(this.screenHistory[currentIndex] , this.screenHistory[currentIndex - 1] , true , currentIndex - 2);
			this.screenHistory.RemoveAt(currentIndex);
		}
	}


    /// <summary>
    /// 处理跳转页面逻辑
    /// </summary>
    /// <param name="current">目前页面</param>
    /// <param name="target">目标页面</param>
    /// <param name="isBack">是否返回</param>
    /// <param name="order">页面层级</param>
	private void PlayScreen(GameObject current , GameObject target , bool isBack , int order){

        //设置触碰器
		//current.GetComponent<Animator>().SetTrigger(this.outTrigger);

		if(isBack){

			current.GetComponent<Canvas>().sortingOrder = order;
		}else{

			current.GetComponent<Canvas>().sortingOrder = order - 1;
			target.GetComponent<Canvas>().sortingOrder = order;
		}

        current.SetActive(false);
		target.SetActive(true);
	}

    private void PlayWindow(GameObject target)
    {
        //TODO:优化代码
        if (preGameObject == null)
        {
            preGameObject = target;
            preGameObject.SetActive(true);
        }
        else if (preGameObject == target && isOpen == true)
        {
            preGameObject.SetActive(false);
            isOpen = false;
        }
        else if (isOpen == false && preGameObject == target)
        {
            preGameObject.SetActive(true);
            isOpen = true;
        }
        else
        {
            preGameObject.SetActive(false);
            target.SetActive(true);
            preGameObject = target;
            isOpen = true;
        }


        #region Test
        //#region 添加Window
        //if (windowHistory.ContainsValue(target))
        //{
        //    Debug.Log("该物体已经纯在");
        //}
        //else
        //{
        //    windowHistory.Add(target.name, target);
        //    Debug.Log(windowHistory.Count);

        //}
        //#endregion

        //#region 判断窗口的状态
        //if (isOpen)
        //{
        //    foreach (var item in windowHistory)
        //    {
        //        item.Value.SetActive(false);
        //    }
        //    isOpen = false;
        //    //target.SetActive(false);
        //    Debug.Log("你已经打开了该窗口！！");
        //}
        //else
        //{
        //    isOpen = true;
        //    target.SetActive(true);
        //}
        //#endregion
        #endregion
    }
}
