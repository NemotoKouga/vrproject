using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PhotoChange : MonoBehaviour
{
    private Image img;
    private int count = 1;
    // Start is called before the first frame update
    void Start()
    {
        img = GameObject.Find("Image").GetComponent<Image>();
    }

    // Update is called once per frame
    public void Next()
    {
        count++;
        if(count>=7)
        SceneManager.LoadScene("SampleScene");

        img.sprite = Resources.Load<Sprite>("Image/スライド" + count.ToString());
    }

    public void Back()
    {
        count--;
        if(count<=0)
        count=1;

        img.sprite = Resources.Load<Sprite>("Image/スライド" + count.ToString());
    }
}
