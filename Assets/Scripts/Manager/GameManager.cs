using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    //Data
    private int hunger;
    private int tired;
    private int coin;
    private int humor;
    private float time;

    //Data property
    public int Hunger
    {
        get
        {
            return hunger;
        }

        set
        {
            hunger = value;
        }
    }
    public int Tired
    {
        get
        {
            return tired;
        }

        set
        {
            tired = value;
        }
    }
    public int Coin
    {
        get
        {
            return coin;
        }

        set
        {
            coin = value;
        }
    }
    public int Humor
    {
        get
        {
            return humor;
        }

        set
        {
            humor = value;
        }
    }
    public float Time
    {
        get
        {
            return time;
        }

        set
        {
            time = value;
        }
    }

    //State
    public enum StateEnum
    {
        HEALTH,
        FAVORABLE,
        DANGER,
        DIE
    }
    public StateEnum HungerState;
    public StateEnum TiredState;
    public StateEnum HumorState;

    //Time Format
    [System.Serializable]
    public struct TimeFormat
    {
        public int Year;
        public int Month;
        public int Day;
        public int Hour;
        public int Minute;
        public int Second;
    }
    public TimeFormat TimeDate;

    void Awake()
    {
        Instance = this;

        TimeDate.Year = 2016;
        TimeDate.Month = 6;
        TimeDate.Day = 1;

        hunger = 100;
        humor = 100;
        coin = 1000;
        tired = 100;
    }
}
