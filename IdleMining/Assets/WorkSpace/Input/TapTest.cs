using UnityEngine;
using UnityEngine.UI;

public class TapTest : MonoBehaviour
{
    [SerializeField]
    int GetMoney = 100;

    public int HaveMoney = 0;

    public void Dig()
    {
        HaveMoney += GetMoney;

        Debug.Log("ÌŒ@I");
        Debug.Log("Š‹à: " + HaveMoney);
    }
}
