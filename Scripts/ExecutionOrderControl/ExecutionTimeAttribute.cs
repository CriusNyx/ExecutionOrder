using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AttributeUsage(AttributeTargets.Class, Inherited = true)]
public class ExecutionOrderAttribute : Attribute
{
    public readonly int order;

    public ExecutionOrderAttribute(ExecutionOrderValue order)
    {
        this.order = (int)order;
    }

    public ExecutionOrderAttribute(int order)
    {
        this.order = order;
    }
}

public enum ExecutionOrderValue
{
    Earliest = Early - 10,
    Early = Logic - 10,
    PreLogic = Logic - 1,
    Logic = 0,
    PostLogic = Logic + 1,
    PrePhysics = Physics - 1,
    Physics = Logic + 10,
    PhysicsStep = Physics + 1,
    PostPhysics = PhysicsStep + 1,
    Camera = PostPhysics + 10,
}