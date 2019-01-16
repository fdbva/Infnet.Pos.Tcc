using System;

namespace Infnet.Pos.Tcc.Domain.Model.Entities
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
    }
}