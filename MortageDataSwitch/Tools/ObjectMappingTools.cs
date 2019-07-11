using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MortageDataSwitch.Tools
{
    public static class ObjectMappingTools
    {
        public static void TransferObject(object fromObject, object toObject, bool skipRefId = false)
        {
            if (fromObject == null || toObject == null)
            {
                return;
            }

            foreach (var toProperty in toObject.GetType().GetProperties())
            {
                if ((toProperty.Name.ToLower() == "refid" || toProperty.Name.ToLower() == "_refid") && skipRefId)
                {
                    continue;
                }

                foreach (var fromProperty in fromObject.GetType().GetProperties())
                {
                    if (toProperty.Name.ToLower() != fromProperty.Name.ToLower()
                        && toProperty.Name.ToLower() != $"_{fromProperty.Name.ToLower()}"
                        && $"_{toProperty.Name.ToLower()}" != $"_{fromProperty.Name.ToLower()}"
                        && $"_{toProperty.Name.ToLower()}" != fromProperty.Name.ToLower())
                    {
                        continue;
                    }

                    if (!toProperty.CanWrite) { continue; }

                    if (fromProperty.GetValue(fromObject, null) == null)
                    {
                        toProperty.SetValue(toObject, null, null);
                        break;
                    }

                    var propertyValue = fromProperty.GetValue(fromObject, null);
                    var propertyType = toProperty.PropertyType;

                    if ((toProperty.Name.ToLower() == "id" || toProperty.Name.ToLower() == "_id") && new Guid(propertyValue?.ToString() ?? Guid.Empty.ToString()) == Guid.Empty)
                    {
                        continue;
                    }

                    switch (Type.GetTypeCode(propertyType))
                    {
                        case TypeCode.String:
                            toProperty.SetValue(toObject, propertyValue ?? string.Empty, null);
                            break;
                        case TypeCode.Decimal:
                            toProperty.SetValue(toObject, Convert.ToDecimal(propertyValue ?? "0"), null);
                            break;
                        case TypeCode.Int16:
                            toProperty.SetValue(toObject, Convert.ToInt16(propertyValue ?? "0"), null);
                            break;
                        case TypeCode.Int32:
                            toProperty.SetValue(toObject, Convert.ToInt32(propertyValue ?? "0"), null);
                            break;
                        case TypeCode.Int64:
                            toProperty.SetValue(toObject, Convert.ToInt64(propertyValue ?? "0"), null);
                            break;
                        case TypeCode.DateTime:
                            if (Convert.ToDateTime(propertyValue) != new DateTime(1, 1, 1))
                            {
                                toProperty.SetValue(toObject, Convert.ToDateTime(propertyValue), null);
                            }
                            else
                            {
                                toProperty.SetValue(toObject, new DateTime(1900, 1, 1), null);
                            }

                            break;
                        default:
                            if (propertyType == typeof(long) || propertyType == typeof(long?))
                            {
                                toProperty.SetValue(toObject, Convert.ToInt64(propertyValue ?? "0"), null);
                            }
                            else if (toProperty.PropertyType.IsGenericType && toProperty.PropertyType.GenericTypeArguments[0].IsEnum)
                            {
                                if (toProperty.PropertyType.GenericTypeArguments[0].IsEnumDefined(propertyValue))
                                {
                                    try
                                    {
                                        var newPropertyValue = toProperty.PropertyType.GenericTypeArguments[0].GetEnumValues().Cast<Enum>().ToList().First(c => ((Enum)c).GetHashCode() == (int)propertyValue);
                                        toProperty.SetValue(toObject, newPropertyValue ?? null, null);
                                    }
                                    catch { }
                                }

                            }
                            else
                            {
                                try
                                {
                                    toProperty.SetValue(toObject, propertyValue ?? string.Empty, null);
                                }
                                catch { }
                            }
                            break;
                    }
                    break;
                }
            }
        }

        public static TDestination GetNewPopulatedObject<TDestination>(object sourceObject)
            where TDestination : new()
        {
            var newObject = new TDestination();
            TransferObject(sourceObject, newObject);
            return newObject;
        }

        public static void TransferEnumerableObject<TSource, TDestination>(IEnumerable<TSource> fromEnumerableObject, ICollection<TDestination> toEnumerableObject) where TDestination : new()
        {
            foreach (var fromObject in fromEnumerableObject)
            {
                var toObject = new TDestination();
                TransferObject(fromObject, toObject);
                toEnumerableObject.Add(toObject);
            }
        }
    }
}
