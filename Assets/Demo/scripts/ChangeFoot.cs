using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ChangeFoot : MonoBehaviour
{

    private SkinnedMeshRenderer oldSmr = null;
    private SkinnedMeshRenderer newSmr = null;

    private Object oldObj = null;
    private Object newObj = null;

    private GameObject oldInstance = null;
    private GameObject newInstance = null;

    public static ChangeFoot instance;
    void OnGUI()
    {
        /*if (GUI.Button(new Rect(00, 0, 100, 30), "Change Foot"))
        {
            ChangeFeet();
        }*/
    }

    void Start()
    {
        instance = this;
        
    }

    public void ChangeFeet(string item)
    {
        if (gameObject.transform.GetChild(2).name == "jiao")
        {
            gameObject.transform.GetChild(2).SetSiblingIndex(0);
        }
        else if (gameObject.transform.GetChild(1).name == "jiao")
        {
            gameObject.transform.GetChild(1).SetSiblingIndex(0);
        }

        //加载替换对象的资源文件
        newObj = Resources.Load("prefab-girl/"+item);
        newInstance = Instantiate(newObj) as GameObject;

        oldSmr = gameObject.GetComponentInChildren<SkinnedMeshRenderer>();
        newSmr = newInstance.GetComponentInChildren<SkinnedMeshRenderer>();

        Transform[] oldBones = gameObject.GetComponentsInChildren<Transform>();
        //Transform[] oldBones = oldSmr.bones;              //模型会出现错乱
        Debug.Log("oldBones.Length: " + oldBones.Length);
        Transform[] newBones = newSmr.bones;
        Debug.Log("newBones.Length: " + newBones.Length);

        //对骨骼进行重新排序
        List<Transform> bones = new List<Transform>();
        foreach (Transform bone in newBones)
        {
            foreach (Transform oldBone in oldBones)
            {
                if (bone != null && oldBone != null)
                {
                    if (bone.name != oldBone.name)
                    {
                        continue;
                    }
                    bones.Add(oldBone);
                }
            }
        }
        //替换Mesh数据
        oldSmr.bones = bones.ToArray();
        oldSmr.sharedMesh = newSmr.sharedMesh;
        oldSmr.materials = newSmr.materials;

        //删除无用的对象
        GameObject.DestroyImmediate(newInstance);
        GameObject.DestroyImmediate(newSmr);
    }
    public void Changecloth(string item)
    {
        if(gameObject.transform.GetChild(2).name == "shen")
        {
            gameObject.transform.GetChild(2).SetSiblingIndex(0);
        }
        else if (gameObject.transform.GetChild(1).name == "shen")
        {
            gameObject.transform.GetChild(1).SetSiblingIndex(0);
        }
        

        //加载替换对象的资源文件
        newObj = Resources.Load("prefab-girl/" + item);
        newInstance = Instantiate(newObj) as GameObject;

        oldSmr = gameObject.GetComponentInChildren<SkinnedMeshRenderer>();
        newSmr = newInstance.GetComponentInChildren<SkinnedMeshRenderer>();

        Transform[] oldBones = gameObject.GetComponentsInChildren<Transform>();
        //Transform[] oldBones = oldSmr.bones;              //模型会出现错乱
        Debug.Log("oldBones.Length: " + oldBones.Length);
        Transform[] newBones = newSmr.bones;
        Debug.Log("newBones.Length: " + newBones.Length);

        //对骨骼进行重新排序
        List<Transform> bones = new List<Transform>();
        foreach (Transform bone in newBones)
        {
            foreach (Transform oldBone in oldBones)
            {
                if (bone != null && oldBone != null)
                {
                    if (bone.name != oldBone.name)
                    {
                        continue;
                    }
                    bones.Add(oldBone);
                }
            }
        }
        //替换Mesh数据
        oldSmr.bones = bones.ToArray();
        oldSmr.sharedMesh = newSmr.sharedMesh;
        oldSmr.materials = newSmr.materials;

        //删除无用的对象
        GameObject.DestroyImmediate(newInstance);
        GameObject.DestroyImmediate(newSmr);
    }

}