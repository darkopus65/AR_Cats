using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Cat : MonoBehaviour {

    public GameObject bitcoin;

    public float speed = 1f;

    private Animator moving;

    private string playerID;

	// Use this for initialization
	void Start () {

        StartCoroutine(SetTime());

	}

    // Update is called once per frame
    void Update () {

        CatMoving();

	}

    void CatMoving(){
        
        if (Mathf.Abs(transform.position.x) >= 0.7 || Mathf.Abs(transform.position.z) >= 0.7)
        {
            if (transform.rotation.y <= 180)
            {
                transform.position = new Vector3((float)((transform.position.x) / 1.11), transform.position.y, (float)((transform.position.z) / 1.1));
                transform.Rotate(new Vector3(transform.rotation.x, Random.Range(180, 360), transform.rotation.z));
            }
            else
            {
                transform.position = new Vector3((float)((transform.position.x) / 1.11), transform.position.y, (float)((transform.position.z) / 1.1));
                transform.Rotate(new Vector3(transform.rotation.x, Random.Range(0, 180), transform.rotation.z));
            }


        }

        transform.Translate(Vector3.forward * speed * Time.deltaTime);

    }

    IEnumerator SetTime(){
        
        while(true){
            yield return new WaitForSeconds(1);
            transform.Rotate(new Vector3(transform.rotation.x, Random.Range(0, 360), transform.rotation.z));
        }

    }


}
