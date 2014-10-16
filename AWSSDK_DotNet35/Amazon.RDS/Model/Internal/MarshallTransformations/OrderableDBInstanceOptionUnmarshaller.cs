/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the rds-2014-09-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.RDS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.RDS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for OrderableDBInstanceOption Object
    /// </summary>  
    public class OrderableDBInstanceOptionUnmarshaller : IUnmarshaller<OrderableDBInstanceOption, XmlUnmarshallerContext>, IUnmarshaller<OrderableDBInstanceOption, JsonUnmarshallerContext>
    {
        public OrderableDBInstanceOption Unmarshall(XmlUnmarshallerContext context)
        {
            OrderableDBInstanceOption unmarshalledObject = new OrderableDBInstanceOption();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("AvailabilityZones/AvailabilityZone", targetDepth))
                    {
                        var unmarshaller = AvailabilityZoneUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.AvailabilityZones.Add(item);
                        continue;
                    }
                    if (context.TestExpression("DBInstanceClass", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DBInstanceClass = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Engine", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Engine = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("EngineVersion", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.EngineVersion = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("LicenseModel", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.LicenseModel = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MultiAZCapable", targetDepth))
                    {
                        var unmarshaller = BoolUnmarshaller.Instance;
                        unmarshalledObject.MultiAZCapable = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ReadReplicaCapable", targetDepth))
                    {
                        var unmarshaller = BoolUnmarshaller.Instance;
                        unmarshalledObject.ReadReplicaCapable = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("StorageType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.StorageType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SupportsIops", targetDepth))
                    {
                        var unmarshaller = BoolUnmarshaller.Instance;
                        unmarshalledObject.SupportsIops = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Vpc", targetDepth))
                    {
                        var unmarshaller = BoolUnmarshaller.Instance;
                        unmarshalledObject.Vpc = unmarshaller.Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return unmarshalledObject;
                }
            }

            return unmarshalledObject;
        }

        public OrderableDBInstanceOption Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static OrderableDBInstanceOptionUnmarshaller _instance = new OrderableDBInstanceOptionUnmarshaller();        

        public static OrderableDBInstanceOptionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}