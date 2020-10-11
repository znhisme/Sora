using Newtonsoft.Json;
using Sora.Converter;

namespace Sora.Module.CQCodes.CQCodeModel
{
    /// <summary>
    /// <para>群成员戳一戳</para>
    /// <para>仅发送</para>
    /// <para>仅支持Go</para>
    /// </summary>
    internal struct Poke
    {
        #region 属性
        /// <summary>
        /// 需要戳的成员
        /// </summary>
        [JsonConverter(typeof(StringConverter))]
        [JsonProperty(PropertyName = "qq")]
        internal long Uid { get; set; }
        #endregion
    }
}