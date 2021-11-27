﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;

namespace NASB_Moveset_Editor
{
    public static class ReflectionUtil
    {
        private const BindingFlags _allBindingFlags = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;

        {
            (obj is Type ? (Type)obj : obj.GetType())
                .GetField(fieldName, _allBindingFlags)
                .SetValue(obj, value);
        }

        {
            return (obj is Type ? (Type)obj : obj.GetType())
                .GetField(fieldName, _allBindingFlags)
                .GetValue(obj);
        }


        {
            (obj is Type ? (Type)obj : obj.GetType())
                .GetProperty(propertyName, _allBindingFlags)
                .SetValue(obj, value, null);
        }

        {
            return (obj is Type ? (Type)obj : obj.GetType())
                .GetProperty(propertyName, _allBindingFlags)
                .GetValue(obj);
        }



        {
            return (obj is Type ? (Type)obj : obj.GetType())
                .GetMethod(methodName, _allBindingFlags)
                .Invoke(obj, methodParams);
        }

        {
            Type[] types = new Type[constructorParams.Length];
            for (int i = 0; i < constructorParams.Length; i++) types[i] = constructorParams[i].GetType();
            return (obj is Type ? (Type)obj : obj.GetType())
                .GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, types, null)
                .Invoke(constructorParams);
        }

        {
            return Type.GetType(clazz);
        }

        {
            return AppDomain.CurrentDomain.GetAssemblies();
        }

        {
            IEnumerable<string> ret = Enumerable.Empty<string>();
            ret = ret.Concat(assembly.GetTypes()
                    .Select(t => t.Namespace)
                    .Distinct()
                    .Where(n => n != null));
            return ret.Distinct();
        }

        {
            {
                {
                        .Where(t => t.IsClass)
                        .Select(t => t.Name);
                }
            }
            return null;
        }

        {
            Behaviour copy = null;

            try
            {
                copy = destination.AddComponent(overridingType) as Behaviour;
            }
            catch (Exception)
            {

            }

            copy.enabled = false;

            while (type != typeof(MonoBehaviour))
            {
                CopyForType(type, original, copy);
                type = type.BaseType;
            }

            copy.enabled = true;
            return copy;
        }

        public static void SetPrivateField(this object obj, string fieldName, object value)
        {
            var field = obj.GetType().GetField(fieldName, BindingFlags.Instance | BindingFlags.NonPublic);
            field.SetValue(obj, value);
        }

        public static T GetPrivateField<T>(this object obj, string fieldName)
        {
            var field = obj.GetType().GetField(fieldName, BindingFlags.Instance | BindingFlags.NonPublic);
            var value = field.GetValue(obj);
            return (T)value;
        }

        public static object GetPrivateField(Type type, object obj, string fieldName)
        {
            var field = obj.GetType().GetField(fieldName, BindingFlags.Instance | BindingFlags.NonPublic);
            var value = field.GetValue(obj);
            return value;
        }

        public static void InvokePrivateMethod(this object obj, string methodName, object[] methodParams)
        {
            var method = obj.GetType().GetMethod(methodName, BindingFlags.Instance | BindingFlags.NonPublic);
            method.Invoke(obj, methodParams);
        }

        {
            FieldInfo[] myObjectFields = type.GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.GetField | BindingFlags.SetField);

            foreach (FieldInfo fi in myObjectFields)
            {
                fi.SetValue(destination, fi.GetValue(source));
            }
        }
    }
}