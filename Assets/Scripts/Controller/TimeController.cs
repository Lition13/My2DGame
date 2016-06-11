using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimeController : MonoBehaviour, IExecute
{
    [SerializeField]
    private Text year;
    [SerializeField]
    private Text month;
    [SerializeField]
    private Text day;
    [SerializeField]
    private Text mimute;
    [SerializeField]
    private Text second;

    [SerializeField]
    int h = 23;
    [SerializeField]
    int m = 59;
    [SerializeField]
    int s = 0;
    float tempS = 50;

    // Use this for initialization
    void Start()
    {
        year.text = GameManager.Instance.TimeDate.Year.ToString();
        month.text = GameManager.Instance.TimeDate.Month.ToString();
        day.text = GameManager.Instance.TimeDate.Day.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        Calculator();
        UpdateDate();
        //Test();
    }

    public void UpdateDate()
    {
        year.text = GameManager.Instance.TimeDate.Year.ToString();
        month.text = GameManager.Instance.TimeDate.Month.ToString();
        day.text = GameManager.Instance.TimeDate.Day.ToString();
    }

    public void Test()
    {
        //Debug.Log(GameManager.Instance.TimeDate.Hour);
        //Debug.Log(GameManager.Instance.TimeDate.Minute);
        //Debug.Log(GameManager.Instance.TimeDate.Second);
        Debug.Log(h);
        Debug.Log(m);
        Debug.Log(s);
    }

    //时间器
    public void Calculator()
    {
        tempS += Time.deltaTime;
        s = (int)tempS;

        if (s >= 60)
        {
            m++;
            tempS = 0;
        }

        if (m >= 60)
        {
            h++;
            m = 0;
        }

        if (h >= 24)
        {
            GameManager.Instance.TimeDate.Day++;
            h = 0;
        }
    }

    public void Execute(GameObject obj, string tag)
    {
    }
}
