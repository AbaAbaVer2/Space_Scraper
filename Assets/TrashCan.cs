using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TrashCan : MonoBehaviour
{
    private void Start()
    {
        GetComponent<TriggerZone>().OnEnterEvent.AddListener(InsideTrash);
    }

    public void InsideTrash(GameObject go)
    {
        go.SetActive(false);//��������봥����ʱ��������������Ὣ go �����������Ϊ����Ծ״̬������������ʹ�䲻�ٲ���������Ⱦ�͸���ѭ����

    }
}
