﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Fasterflect;
using UnityEngine;

namespace Framework.PackageExtractor
{
    public class DelayedLink
    {
        public bool IsImport = true;
        public object TargetReference;
        public string AbsoluteObjectReference;
        public bool IsTypeReference;
        public string SkipTestClassReference = string.Empty;
        public string AbsoluteClassPath = string.Empty;
        public int IndexReference;
        public FieldInfo FieldReference;

        public void Assign(object obj)
        {
            if (TargetReference.GetType().IsArray)
            {
                var array = TargetReference as Array;
                if (array.Length <= IndexReference)
                {
                    var arrResized = Array.CreateInstance(array.GetType().GetElementType(), IndexReference + 1);
                    array.CopyTo(arrResized, 0);
                    arrResized.SetValue(obj, IndexReference);
                    FieldReference.SetValue(TargetReference, arrResized);
                }
                else
                {
                    array.SetValue(obj, IndexReference);
                }
                TryMarkDirty();
            }
            else
            {
                if (TargetReference.GetType().IsGenericType && TargetReference.GetType().GetGenericTypeDefinition() == typeof(List<>))
                {
                    var list = TargetReference as IList;
                    if (list.Count <= IndexReference)
                    {
                        list.Add(obj);
                    }
                    else
                    {
                        list[IndexReference] = obj;
                    }
                    TryMarkDirty();
                }
                else
                {
                    try
                    {
                        FieldReference.SetValue(TargetReference, obj);
                        TryMarkDirty();
                    }
                    catch (Exception e)
                    {
                        if (FieldReference.FieldType.IsArray)
                        {
                            try
                            {
                                var array = FieldReference.Get(TargetReference) as Array;
                                if (array.Length <= IndexReference)
                                {
                                    var arrResized = Array.CreateInstance(array.GetType().GetElementType(), IndexReference + 1);
                                    array.CopyTo(arrResized, 0);
                                    arrResized.SetValue(obj, IndexReference);
                                    FieldReference.SetValue(TargetReference, arrResized);
                                    TryMarkDirty();
                                    return;
                                }
                                array.SetValue(obj, IndexReference);
                                TryMarkDirty();
                                return;
                            }
                            catch (Exception ae)
                            {
                                Debug.LogException(ae);
                                return;
                            }
                        }
                        Debug.LogException(e);
                    }
                }
            }
        }

        void TryMarkDirty() //just to be sure
        {
            #if UNITY_EDITOR
            var unityObject = TargetReference as UnityEngine.Object;
            if (unityObject != null) UnityEditor.EditorUtility.SetDirty(unityObject);
            UnityEditor.SceneManagement.EditorSceneManager.MarkAllScenesDirty();
            #endif
        }
    }
}
