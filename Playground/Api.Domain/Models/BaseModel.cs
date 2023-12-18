using System;

namespace Api.Domain.Models
{
    public class BaseModel
    {
        public Guid Id { get; set; }
        public DateTime UpdateAt { get; set; }

        private DateTime? _createAt;
        public DateTime? CreateAt
        {
            get => _createAt;
            set => _createAt = value ?? DateTime.UtcNow;
        }

    }
}
