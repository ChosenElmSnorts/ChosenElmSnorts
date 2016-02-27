using UnityEngine;
using System.Collections;

public class GetMerchants : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(getRequest());
    }

    IEnumerator getRequest()
    {
        string url = "http://thebrandmans.net/joshtest/merchants/merchant_ids.html";
        WWW www = new WWW(url);
        yield return www;

        GetComponent<TextMesh>().text = www.text;
    }

    // Update is called once per frame
    void Update () {
	
	}
}
