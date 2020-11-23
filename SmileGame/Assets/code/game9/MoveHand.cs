using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveHand : MonoBehaviour
{
    NextStagePanel nsp;
    [SerializeField] private GameObject hand;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetMouseButton(0))
        {
            Vector3 mousePosition
     = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
            hand.transform.position = mousePosition;
        }
    }

   /* private void OnMouseDrag()
    {
        Vector3 mousePosition
     = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
        //마우스 좌표를 스크린 투 월드로 바꾸고 이 객체의 위치로 설정해 준다.
        this.transform.position = Camera.main.ScreenToWorldPoint(mousePosition);

        if (mousePosition.x >= 96 && mousePosition.x <= 102 && 
            mousePosition.y >= 425 && mousePosition.y <= 435)
        {
            nsp = FindObjectOfType<NextStagePanel>();
            nsp.NextPanel();
        }
    }*/
}
