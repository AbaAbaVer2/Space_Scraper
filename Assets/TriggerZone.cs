using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;


//By Disastrophe,��Դ�ڡ���Unity�̡̳�3 Сʱѧ�� VR ���� - Unity VR �̳������γ̡� https://www.bilibili.com/video/BV1xN2oYfEsy/?p=3&share_source=copy_web&vd_source=ca196941b76dc7b7adacdf66aee3161b
public class TriggerZone : MonoBehaviour
{
    public string targetTag;//Ŀ������ı�ǩ,ֻ�д��������ǩ��������봥����ʱ���Żᴥ���¼���
    public UnityEvent<GameObject> OnEnterEvent;//����������ʱ��OnEnterEvent �ᱻ���ã������ݽ��봥��������Ϸ����
    private void OnTriggerEnter(Collider other)  //����һ�� Collider ����ô�����ʱ���á�
    {
        if (other.gameObject.tag == targetTag)//�����봥�����������Ƿ����ָ���� targetTag
        {
            OnEnterEvent.Invoke(other.gameObject);//�������ı�ǩ����Ҫ�󣬵��� OnEnterEvent���������봥���������壨other.gameObject����Ϊ�������ݸ��¼���
        }
    }
}
