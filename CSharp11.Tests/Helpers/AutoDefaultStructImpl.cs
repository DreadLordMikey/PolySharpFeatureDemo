#pragma warning disable CS0649
using System;

namespace CSharp11.Tests.Helpers;

/**
 * Beginning with C# 11, if you don't initialize all fields in a struct, the compiler adds code to the
 * constructor that initializes those fields to the default value. The compiler performs its usual definite
 * assignment analysis. Any fields that are accessed before being assigned, or not definitely assigned when the
 * constructor finishes executing are assigned their default values before the constructor body executes. If
 * this is accessed before all fields are assigned, the struct is initialized to the default value before the
 * constructor body executes.
 */
public class AutoDefaultStructImpl
{
    public string MyString;
    public int MyInt;
    public DateTime MyDateTime;
    public float MyFloat;
}
#pragma warning restore CS0649
