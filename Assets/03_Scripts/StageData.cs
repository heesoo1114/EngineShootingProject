using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]  //프로젝트 뷰에 StageData 생성 가능하게 만듬
public class StageData : ScriptableObject  // ScriptableObject = 오브젝트에 스크립트를 넣지 않아도 역할을 할 수 있음
{
    [SerializeField]
    private Vector2 limitMin;   //최소
    [SerializeField]
    private Vector2 limitMax;   //최대

    public Vector2 LimitMin => limitMin;  // 잘 모르겠음
    public Vector2 LimitMax => limitMax;
}
