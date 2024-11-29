using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;


//By Disastrophe,来源于【【Unity教程】3 小时学会 VR 开发 - Unity VR 教程完整课程】 https://www.bilibili.com/video/BV1xN2oYfEsy/?p=3&share_source=copy_web&vd_source=ca196941b76dc7b7adacdf66aee3161b
public class TriggerZone : MonoBehaviour
{
    public string targetTag;//目标物体的标签,只有带有这个标签的物体进入触发器时，才会触发事件。
    public UnityEvent<GameObject> OnEnterEvent;//当满足条件时，OnEnterEvent 会被调用，并传递进入触发器的游戏对象。
    private void OnTriggerEnter(Collider other)  //当另一个 Collider 进入该触发器时调用。
    {
        if (other.gameObject.tag == targetTag)//检查进入触发器的物体是否具有指定的 targetTag
        {
            OnEnterEvent.Invoke(other.gameObject);//如果物体的标签符合要求，调用 OnEnterEvent，并将进入触发器的物体（other.gameObject）作为参数传递给事件。
        }
    }
}
