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
    Earliest = -20,
    Early = -10,
    PreLogic = Logic - 1,
    Logic = 0,
    PostLogic = Logic + 1,
    PrePhysics = Physics - 1,
    Physics = 10,
    PostPhysics = Physics + 1,
    Camera = 20,
}