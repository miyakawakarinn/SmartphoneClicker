using UnityEngine;

public class TapTest : MonoBehaviour
{
    [SerializeField]
    int GetMoney = 100;
    int HaveMoney = 0;
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                Debug.Log("タップ開始！");
                HaveMoney += GetMoney;
                Debug.Log("所持金: " + HaveMoney);
            }
        }
    }
}
