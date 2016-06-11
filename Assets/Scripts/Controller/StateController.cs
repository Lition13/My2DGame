using UnityEngine;
using System.Collections;

public class StateController
{
    private static StateController instance;

    public static StateController Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new StateController();
            }
            return instance;
        }
    }

    public void State()
    {
        #region HungerState
        switch (GameManager.Instance.Hunger)
        {
            case 100:

            case 60:
                GameManager.Instance.HungerState = GameManager.StateEnum.HEALTH;
                break;

            case 30:
                GameManager.Instance.HungerState = GameManager.StateEnum.FAVORABLE;
                break;

            case 0:
                GameManager.Instance.HungerState = GameManager.StateEnum.DANGER;
                break;

            default:
                GameManager.Instance.HungerState = GameManager.StateEnum.DIE;
                break;
        }
        #endregion

        #region HumorState
        switch (GameManager.Instance.Humor)
        {
            case 100:

            case 60:
                GameManager.Instance.HumorState = GameManager.StateEnum.HEALTH;
                break;

            case 30:
                GameManager.Instance.HumorState = GameManager.StateEnum.FAVORABLE;
                break;

            case 0:
                GameManager.Instance.HumorState = GameManager.StateEnum.DANGER;
                break;

            default:
                GameManager.Instance.HumorState = GameManager.StateEnum.DIE;
                break;
        }
        #endregion

        #region TiredState
        switch (GameManager.Instance.Tired)
        {
            case 100:

            case 60:
                GameManager.Instance.TiredState = GameManager.StateEnum.HEALTH;
                break;

            case 30:
                GameManager.Instance.TiredState = GameManager.StateEnum.FAVORABLE;
                break;

            case 0:
                GameManager.Instance.TiredState = GameManager.StateEnum.DANGER;
                break;

            default:
                GameManager.Instance.TiredState = GameManager.StateEnum.DIE;
                break;
        }
        #endregion
    }
}
