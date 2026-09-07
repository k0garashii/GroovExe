using System.Collections.Generic;
using UnityEngine;

public class EditorManager : MonoBehaviour
{
    public static EditorManager mng;
    private List<EditorObject> obj = new List<EditorObject>();

    void Awake()
    {
        if (mng == null)
            mng = this;
    }
}
