using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CoinController : MonoBehaviour,IExecute
{
    [SerializeField]
    private Text coin;
    [SerializeField]
    private Text coinShow;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        coin.text = GameManager.Instance.Coin.ToString();
        coinShow.text = GameManager.Instance.Coin.ToString();
    }

    public void Execute(GameObject obj, string tag)
    {
        GameManager.Instance.Coin -= 100;
    }
}
