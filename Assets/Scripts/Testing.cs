using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using Random = UnityEngine.Random;

public class Testing : MonoBehaviour
{
    void Start()
    {
        EntityManager entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;
        EntityArchetype entityArchetype = entityManager.CreateArchetype(typeof(Level), typeof(Translation));
        NativeArray<Entity> entities=new NativeArray<Entity>(10,Allocator.Temp);
        entityManager.CreateEntity(entityArchetype, entities);
        for (int i = 0; i < entities.Length; i++)
        {
            entityManager.SetComponentData(entities[i],new Translation{Value=new float3(Random.Range(0,100),Random.Range(0,100),Random.Range(0,100))});
        }
    }

}
