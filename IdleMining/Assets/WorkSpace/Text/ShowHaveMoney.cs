using UnityEngine;

public class ShowHaveMoney : MonoBehaviour
{
    private TapTest tapTest;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tapTest = GetComponent<TapTest>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        Debug.Log("ƒg[ƒ^ƒ‹‚Ì‹àŠz" + tapTest.HaveMoney);
    }
}
