using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

//IComponent用于实现通用接口
public class Level : IComponentData
{
    public int level;
}
