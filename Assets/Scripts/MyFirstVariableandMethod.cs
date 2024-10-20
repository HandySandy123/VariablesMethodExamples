using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MyFirstVariableandMethod : MonoBehaviour
{
    public int CurrentAge = 27;
    public GameObject TextObject;

    TMP_Text innerText;
    

    // Start is called before the first frame update
    void Start()
    {
        innerText = TextObject.GetComponent<TMPro.TMP_Text>();
        PrintAge();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            CurrentAge += 1;
            PrintAge();
        }
    }

    public void IncreaseAge()
    {
        CurrentAge += 1;
        PrintAge();
    }

    public void IncreaseAge(int X)
    {
        CurrentAge += X;
        PrintAge();
    }

    void PrintAge()
    {
        innerText.text = "Current age is " + CurrentAge;
        //Debug.Log(innerText.text);
        //Debug.LogFormat("Current age is: {0}", CurrentAge);
    }
}
