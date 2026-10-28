using TMPro;
using UnityEngine;

public class ShowHaveMoney : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI HaveMoneyText;
    [SerializeField] private TapTest tapTest;
    private string haveMoney;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        haveMoney = tapTest.HaveMoney.ToString();
        HaveMoneyText.text = haveMoney;
        Debug.Log("ÉgÅ[É^ÉãÇÃã‡äz" + tapTest.HaveMoney);
    }
}
