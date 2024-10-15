using System.Collections;
using UnityEngine;

public class Counter : MonoBehaviour
{
    //
    private UnityEngine.Coroutine hello;


    // Start is called before the first frame update
    private void Start()
    {
        hello = StartCoroutine(SayHello());

        StartCoroutine(Numbering());
    }


    private void Update()
    {
        Click();
    }


    private void Click()
    {

    }

    private IEnumerator SayHello()
    {
        // dependency inversion
        YieldInstruction wfs = new WaitForSeconds(4);

        while (true)
        {
            Debug.Log("Hello");

            yield return wfs;
        }    
    }


    private IEnumerator Numbering()
    {
        // dependency inversion
        YieldInstruction wfs = new WaitForSeconds(1);

        for(int i = 0; ;i++)
        {

            if (i >= 30) {StopCoroutine(hello);}
            
            Debug.Log(i);

            yield return wfs;

            
        }
    }
}
