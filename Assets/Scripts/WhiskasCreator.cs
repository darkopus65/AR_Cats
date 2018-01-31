using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WhiskasCreator : MonoBehaviour {

    public GameObject whiskas;

    public Transform ParentGP;

    public int maxCount = 30;

    public static int wCount = 0;

    private void Start()
    {
        StartCoroutine(Creating());
    }


    IEnumerator Creating(){

        for (int i = 1; i <= maxCount; i++){

            yield return new WaitForSeconds(2);

            if (i >= maxCount)
            {
                SceneManager.LoadScene("GameOver");
            }
            else
            {
                GameObject w = Instantiate(whiskas, new Vector3(Random.Range(-0.7f, 0.7f), transform.position.y + 0f, Random.Range(-0.7f, 0.7f)), Quaternion.identity, gameObject.transform);
                Destroy(w, 1.5f);
            }


        }

    }

}
