using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]  //������Ʈ �信 StageData ���� �����ϰ� ����
public class StageData : ScriptableObject  // ScriptableObject = ������Ʈ�� ��ũ��Ʈ�� ���� �ʾƵ� ������ �� �� ����
{
    [SerializeField]
    private Vector2 limitMin;   //�ּ�
    [SerializeField]
    private Vector2 limitMax;   //�ִ�

    public Vector2 LimitMin => limitMin;  // �� �𸣰���
    public Vector2 LimitMax => limitMax;
}
