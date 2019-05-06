using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace Arch.Cqrs.Contracts.AutoMapper
{
    public interface ICustomMapper
    {
        void Mappings(IMapperConfigurationExpression config);
    }
}
