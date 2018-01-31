using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BitcoinCreator : MonoBehaviour {

    public int maxCount = 4;
    public Text whiskasCountText;
    public Slider slider;
    public GameObject bitcoin;
    public Transform catPos;

    // Update is called once per frame
    void Update () {

        whiskasCountText.text = WhiskasCreator.wCount.ToString();

        if(WhiskasCreator.wCount >= 4){
            maxCount--;
            WhiskasCreator.wCount = 0;
            GameObject bit = Instantiate(bitcoin, catPos.position, Quaternion.identity);

            slider.value = 4 - maxCount;
            Destroy(bit, 2f);
        }

        if(maxCount == 0){
            SceneManager.LoadScene("Win");
        }
	}
}
