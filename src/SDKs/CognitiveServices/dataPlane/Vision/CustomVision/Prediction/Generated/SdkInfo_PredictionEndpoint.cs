
using System;
using System.Collections.Generic;
using System.Linq;

internal static partial class SdkInfo
{
    public static IEnumerable<Tuple<string, string, string>> ApiInfo_PredictionEndpoint
    {
        get
        {
            return new Tuple<string, string, string>[]
            {
                new Tuple<string, string, string>("PredictionEndpoint", "PredictImage", "2.0"),
                new Tuple<string, string, string>("PredictionEndpoint", "PredictImageUrl", "2.0"),
                new Tuple<string, string, string>("PredictionEndpoint", "PredictImageUrlWithNoStore", "2.0"),
                new Tuple<string, string, string>("PredictionEndpoint", "PredictImageWithNoStore", "2.0"),
            }.AsEnumerable();
        }
    }
}
