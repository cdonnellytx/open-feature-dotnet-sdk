using System.Collections.Generic;
using System.Threading.Tasks;
using OpenFeature.SDK.Model;

namespace OpenFeature.SDK
{
    internal interface IFeatureClient
    {
        void AddHooks(IEnumerable<Hook> hooks);
        ClientMetadata GetMetadata();

        Task<bool> GetBooleanValue(string flagKey, bool defaultValue, EvaluationContext context = null, FlagEvaluationOptions config = null);
        Task<FlagEvaluationDetails<bool>> GetBooleanDetails(string flagKey, bool defaultValue, EvaluationContext context = null, FlagEvaluationOptions config = null);

        Task<string> GetStringValue(string flagKey, string defaultValue, EvaluationContext context = null, FlagEvaluationOptions config = null);
        Task<FlagEvaluationDetails<string>> GetStringDetails(string flagKey, string defaultValue, EvaluationContext context = null, FlagEvaluationOptions config = null);

        Task<int> GetIntegerValue(string flagKey, int defaultValue, EvaluationContext context = null, FlagEvaluationOptions config = null);
        Task<FlagEvaluationDetails<int>> GetIntegerDetails(string flagKey, int defaultValue, EvaluationContext context = null, FlagEvaluationOptions config = null);

        Task<double> GetDoubleValue(string flagKey, double defaultValue, EvaluationContext context = null, FlagEvaluationOptions config = null);
        Task<FlagEvaluationDetails<double>> GetDoubleDetails(string flagKey, double defaultValue, EvaluationContext context = null, FlagEvaluationOptions config = null);

        Task<T> GetObjectValue<T>(string flagKey, T defaultValue, EvaluationContext context = null, FlagEvaluationOptions config = null);
        Task<FlagEvaluationDetails<T>> GetObjectDetails<T>(string flagKey, T defaultValue, EvaluationContext context = null, FlagEvaluationOptions config = null);
    }
}
