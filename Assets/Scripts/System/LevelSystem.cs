using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using Unity.Entities;
using UnityEngine;

public class LevelSystem : ComponentSystem
{
    protected override void OnUpdate()
    {
        Entities.ForEach<Level>(entity => { entity.level += Random.Range(0, 10);});
    }
}
