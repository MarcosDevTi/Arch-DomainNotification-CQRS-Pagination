using System.Runtime.Serialization;

namespace Arch.Cqrs.Contracts.Paging
{
    [DataContract]
    public enum SortDirection
    {
        [EnumMember]
        Ascending,

        [EnumMember]
        Descending
    }
}
