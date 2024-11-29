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
        go.SetActive(false);//当物体进入触发器时，调用这个方法会将 go 这个物体设置为不活跃状态，即隐藏它并使其不再参与物理、渲染和更新循环。

    }
}
