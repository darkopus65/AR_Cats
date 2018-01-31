using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TouchController : MonoBehaviour {


    private void Update()
    {
        if(Input.GetTouch(0).phase == TouchPhase.Began){

            foreach (Touch touch in Input.touches)
            {
                Ray ray = Camera.main.ScreenPointToRay(touch.position);

                RaycastHit hit;

                if (Physics.Raycast(ray, out hit, 10)) {

                    if(hit.collider.gameObject.tag == "whiskas"){

                        Destroy(hit.collider.gameObject);
                        WhiskasCreator.wCount += 1;

                    }

                }

            }

        }
    }

}
